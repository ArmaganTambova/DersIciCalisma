-- COUNT
-- Kay�t Say�s�n� Verir
SELECT COUNT(*) FROM Products

-- SUM
-- �lgili Konumdaki T�m H�crelerin ��eriklerini Toplar
-- Sto�umda Toplam Ka� Adet �r�n Var
SELECT SUM(UnitsInStock) AS ToplamUrun FROM Products

-- Deniz �r�nleri Kategorisinde Sto�umda Toplam Ka� �r�n Var
SELECT SUM(UnitsInStock) AS [Toplam �r�n] FROM Products WHERE CategoryID = 8

-- Deniz �r�nleri Kategorisinde Ka� Adet �r�n�m Var
SELECT COUNT(*) AS [Ka� Adet Kay�t Var] FROM Products WHERE CategoryID = 8

 -- Fiyat� 50'den B�y�k Olan Ka� Adet �r�n Kayd�m Var
SELECT COUNT(*) FROM Products WHERE UnitPrice > 50

-- Sto�umda Toplam Ne Kadarl�k �r�n�m Var
SELECT SUM(UnitsInStock * UnitPrice) FROM Products

-- Ka� Adet Chai Satm���z
SELECT SUM(Quantity) FROM [Order Details] WHERE ProductID = 1

-- Nancy Davolio Ka� Adet Sat�� Yapm��t�r
SELECT COUNT(*) FROM Orders WHERE EmployeeID = 1