USE NORTHWND
GO

-- Kategoriler
SELECT * FROM Categories

-- Tedarikçiler
SELECT * FROM Suppliers

-- Ürünler
SELECT * FROM Products

-- Satýþa Devam Eden Ürünlerin Listesi
SELECT * FROM Products WHERE Discontinued = 0

-- Kaç Adet Ürünüm Var
SELECT COUNT(*) FROM Products

-- Fiyatý 50 Üstü Olan Ürünlerin Listesi
SELECT COUNT(*) FROM Products WHERE UnitPrice >= 50
SELECT * FROM Products WHERE UnitPrice >= 50

-- Sipariþ Vermem Gereken Ürünlerin Listesi
SELECT * FROM Products WHERE UnitsInStock <= ReorderLevel
SELECT * FROM Products WHERE UnitsInStock <= ReorderLevel AND Discontinued = 0