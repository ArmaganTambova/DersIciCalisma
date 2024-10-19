USE NORTHWND
GO

-- Kategoriler
SELECT * FROM Categories

-- Tedarik�iler
SELECT * FROM Suppliers

-- �r�nler
SELECT * FROM Products

-- Sat��a Devam Eden �r�nlerin Listesi
SELECT * FROM Products WHERE Discontinued = 0

-- Ka� Adet �r�n�m Var
SELECT COUNT(*) FROM Products

-- Fiyat� 50 �st� Olan �r�nlerin Listesi
SELECT COUNT(*) FROM Products WHERE UnitPrice >= 50
SELECT * FROM Products WHERE UnitPrice >= 50

-- Sipari� Vermem Gereken �r�nlerin Listesi
SELECT * FROM Products WHERE UnitsInStock <= ReorderLevel
SELECT * FROM Products WHERE UnitsInStock <= ReorderLevel AND Discontinued = 0