USE EHupifey_Store_DB

GO

SELECT * FROM Products
SELECT * FROM Purchases

SELECT P.ID, P.Name AS [ProductName], B.Name AS [BrandName], C.Name AS [CategoryName], P.Price, P.Stock, P.Barcode FROM Products AS P JOIN Categories AS C ON P.CategoryID = C.ID JOIN Brands AS B ON P.BrandID = B.ID

-- View Nedir Neden Kullan�l�r
-- Veritaban�nda Farkl� Tabloladan Veri �ekmek ��in JOIN Kullan�l�r
-- Ancak Elde Etti�imiz Sorgu Sonucunu Tekrar Olu�turmak �stedi�imizde Ayn� Sorguyu Tekrar Yazmak Zorunda Kal�yoruz
-- Bu Nedenle Her �htiya� Duydu�umuzda SQL Sorgusu Yazmamak ��in View Yani Sanal Tablo Olu�turuyoruz
-- View'ler Asl�nda Var Olmayan Tablolard�r

CREATE VIEW AllProducts
AS
SELECT P.ID, P.Name AS [ProductName], B.Name AS [BrandName], C.Name AS [CategoryName], P.Price, P.Stock, P.Barcode, P.Notes, P.IsDeleted, P.IsActive FROM Products AS P LEFT JOIN Categories AS C ON P.CategoryID = C.ID LEFT JOIN Brands AS B ON P.BrandID = B.ID

SELECT * FROM AllProducts
SELECT ID, ProductName, BrandName, CategoryName, Price, Stock, Barcode FROM AllProducts

SELECT P.ID, AP.ProductName, AP.BrandName, AP.CategoryName, P.Quantity, P.Price, P.Date FROM Purchases AS P JOIN AllProducts AS AP ON P.ProductID = AP.ID