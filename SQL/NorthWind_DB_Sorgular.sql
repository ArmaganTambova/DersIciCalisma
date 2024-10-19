USE NORTHWND

GO

-- Kategoriler Tablosunun Tüm Verilerini Listeleyiniz
SELECT * FROM Categories

-- Kategoriler Tablosunun ID, Ýsim, Açýklama Kolonlarýný Listeleyin
SELECT Categories.CategoryID, Categories.CategoryName, Categories.Description FROM Categories

-- Kategoriler Tablosuna Otomotiv Kategorisini Ekleyin
INSERT INTO Categories(CategoryName, Description) VALUES('Otomotiv', 'Binek Araç')

-- Otomotiv Ýsimli Kategorinin Açýklamasýný Binek Gidek Araçlar Olarak Güncelleyin
UPDATE Categories SET Categories.Description = 'Binek Gidek Araç' WHERE Categories.CategoryID = 9

-- Otomotiv Kategorisini Siliniz
DELETE FROM Categories WHERE Categories.CategoryID = 9

-- Ürünleri Listeleyiniz
SELECT * FROM Products

-- Ürünlerin ID, Ýsim, Fiyat, Stok Bilgilerini Yazdýrýnýz
SELECT Products.ProductID, Products.ProductName, Products.UnitPrice, Products.UnitsInStock FROM Products

-- Fiyatý 50 Üzerinde Olan Ürünleri Listeleyiniz
SELECT * FROM Products WHERE Products.UnitPrice >= 50

-- Satýþý Devam Etmeyen Kaç Adet Ürün Var
SELECT COUNT(*) FROM Products WHERE Products.Discontinued = 1

-- Andrew Fuller Kaç Adet Satýþ Yapmýþtýr
SELECT COUNT(*) FROM Orders WHERE Orders.EmployeeID = 2

-- Satýþlar Tablosunun Müþteri Firma Adý, Satýcý Adý, Sipariþ Tarihi, Gönderi Tarihi, Gönderildiði Adres ve Ülke Ýle Birlikte Listeleyiniz
SELECT O.CustomerID, C.CompanyName, E.FirstName + ' ' + E.LastName AS [EmployeeNameAndSurname], O.OrderDate, O.RequiredDate, O.ShippedDate, O.ShipAddress, O.ShipCountry FROM Orders AS O JOIN Customers AS C ON O.CustomerID = C.CustomerID JOIN Employees AS E ON O.EmployeeID = E.EmployeeID
