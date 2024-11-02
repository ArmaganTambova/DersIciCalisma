-- ORDER BY
-- Sýralama Yapma
-- Ürünleri Fiyatlarýna Göre Sýralayýnýz

SELECT * FROM Products
SELECT * FROM Products ORDER BY UnitPrice -- Küçükten Büyüðe
SELECT * FROM Products ORDER BY UnitPrice DESC -- DESC Büyükten Küçüðe

-- ORDER BY Sayýsal Kolonlarda Küçükten Büyüðe, Metinsel Kolonlarda A-Z Sýralar
-- ORDER BY *** DESC Ýse Sayýsal Kolonlarda Büyükten Küçüðe, Metinsel Kolonlarda Z-A Sýralar

-- Ürünleri Stok Miktarýna Göre Sýralayýnýz
SELECT ProductID, ProductName, UnitsInStock FROM Products ORDER BY UnitsInStock DESC

-- Ürünleri Stok Miktarýna Göre Sýralayýnýz, Stok Miktarý Ayný Olanlarý Kendi Aralarýnda Ýsimlerini Alfabetik Olarak Sýralaryýnýz
SELECT ProductID, ProductName, UnitsInStock FROM Products ORDER BY UnitsInStock DESC, ProductName

-- Ürünlerin Kategori Ýsimlerine Göre Alfabetik Olarak Sýralayýnýz
SELECT P.ProductID, P.ProductName, C.CategoryName FROM Products AS P JOIN Categories AS C ON P.CategoryID = C.CategoryID ORDER BY C.CategoryName, P.ProductName

-- Yapýlan Satýþlarý; Müþteri Firma Adýna Göre A-Z, Ayný Müþteriye Yapýlan Satýþlarý Personel Adýna Göre A-Z Sýralayýnýz
SELECT O.OrderID, C.CompanyName, E.FirstName + ' ' + E.LastName AS [EmployeeName] FROM Orders AS O JOIN Customers AS C ON O.CustomerID = C.CustomerID JOIN Employees AS E ON O.EmployeeID = E.EmployeeID ORDER BY C.CompanyName, E.FirstName + ' ' + E.LastName
