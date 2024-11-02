-- ORDER BY
-- S�ralama Yapma
-- �r�nleri Fiyatlar�na G�re S�ralay�n�z

SELECT * FROM Products
SELECT * FROM Products ORDER BY UnitPrice -- K���kten B�y��e
SELECT * FROM Products ORDER BY UnitPrice DESC -- DESC B�y�kten K����e

-- ORDER BY Say�sal Kolonlarda K���kten B�y��e, Metinsel Kolonlarda A-Z S�ralar
-- ORDER BY *** DESC �se Say�sal Kolonlarda B�y�kten K����e, Metinsel Kolonlarda Z-A S�ralar

-- �r�nleri Stok Miktar�na G�re S�ralay�n�z
SELECT ProductID, ProductName, UnitsInStock FROM Products ORDER BY UnitsInStock DESC

-- �r�nleri Stok Miktar�na G�re S�ralay�n�z, Stok Miktar� Ayn� Olanlar� Kendi Aralar�nda �simlerini Alfabetik Olarak S�ralary�n�z
SELECT ProductID, ProductName, UnitsInStock FROM Products ORDER BY UnitsInStock DESC, ProductName

-- �r�nlerin Kategori �simlerine G�re Alfabetik Olarak S�ralay�n�z
SELECT P.ProductID, P.ProductName, C.CategoryName FROM Products AS P JOIN Categories AS C ON P.CategoryID = C.CategoryID ORDER BY C.CategoryName, P.ProductName

-- Yap�lan Sat��lar�; M��teri Firma Ad�na G�re A-Z, Ayn� M��teriye Yap�lan Sat��lar� Personel Ad�na G�re A-Z S�ralay�n�z
SELECT O.OrderID, C.CompanyName, E.FirstName + ' ' + E.LastName AS [EmployeeName] FROM Orders AS O JOIN Customers AS C ON O.CustomerID = C.CustomerID JOIN Employees AS E ON O.EmployeeID = E.EmployeeID ORDER BY C.CompanyName, E.FirstName + ' ' + E.LastName
