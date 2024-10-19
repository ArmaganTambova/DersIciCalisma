-- JOIN

SELECT * FROM Categories
SELECT * FROM Products

-- Join Foreign Key Ba�lant�s� Olan Tablolar�n Sorgu ��erisine Kat�larak Tek Bir Tablo Gibi Listelenmesi Durumudur

SELECT Products.*, Categories.* FROM Products JOIN Categories ON Products.CategoryID = Categories.CategoryID

SELECT P.ProductID, P.ProductName, C.CategoryName, C.Description, P.QuantityPerUnit, P.UnitPrice, P.UnitsInStock, P.UnitsOnOrder FROM Products AS P JOIN Categories AS C ON P.CategoryID = C.CategoryID

-- �r�nleri Kategori Ad� ve Tedarik�i Firma Bilgileri �le Listeleyiniz
SELECT P.ProductID, P.ProductName, C.CategoryName, S.CompanyName, S.ContactName, S.ContactTitle, S.Phone, P.UnitPrice, P. UnitsInStock, P.ReorderLevel FROM Products AS P JOIN Categories AS C ON P.CategoryID = C.CategoryID JOIN Suppliers AS S ON P.SupplierID = S.SupplierID WHERE P.UnitsInStock <= P.ReorderLevel
