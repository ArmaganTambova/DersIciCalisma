USE NORTHWND

GO

-- Kategoriler Tablosunun T�m Verilerini Listeleyiniz
SELECT * FROM Categories

-- Kategoriler Tablosunun ID, �sim, A��klama Kolonlar�n� Listeleyin
SELECT Categories.CategoryID, Categories.CategoryName, Categories.Description FROM Categories

-- Kategoriler Tablosuna Otomotiv Kategorisini Ekleyin
INSERT INTO Categories(CategoryName, Description) VALUES('Otomotiv', 'Binek Ara�')

-- Otomotiv �simli Kategorinin A��klamas�n� Binek Gidek Ara�lar Olarak G�ncelleyin
UPDATE Categories SET Categories.Description = 'Binek Gidek Ara�' WHERE Categories.CategoryID = 9

-- Otomotiv Kategorisini Siliniz
DELETE FROM Categories WHERE Categories.CategoryID = 9

-- �r�nleri Listeleyiniz
SELECT * FROM Products

-- �r�nlerin ID, �sim, Fiyat, Stok Bilgilerini Yazd�r�n�z
SELECT Products.ProductID, Products.ProductName, Products.UnitPrice, Products.UnitsInStock FROM Products

-- Fiyat� 50 �zerinde Olan �r�nleri Listeleyiniz
SELECT * FROM Products WHERE Products.UnitPrice >= 50

-- Sat��� Devam Etmeyen Ka� Adet �r�n Var
SELECT COUNT(*) FROM Products WHERE Products.Discontinued = 1

-- Andrew Fuller Ka� Adet Sat�� Yapm��t�r
SELECT COUNT(*) FROM Orders WHERE Orders.EmployeeID = 2

-- Sat��lar Tablosunun M��teri Firma Ad�, Sat�c� Ad�, Sipari� Tarihi, G�nderi Tarihi, G�nderildi�i Adres ve �lke �le Birlikte Listeleyiniz
SELECT O.CustomerID, C.CompanyName, E.FirstName + ' ' + E.LastName AS [EmployeeNameAndSurname], O.OrderDate, O.RequiredDate, O.ShippedDate, O.ShipAddress, O.ShipCountry FROM Orders AS O JOIN Customers AS C ON O.CustomerID = C.CustomerID JOIN Employees AS E ON O.EmployeeID = E.EmployeeID
