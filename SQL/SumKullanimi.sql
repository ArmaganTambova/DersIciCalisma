-- COUNT
-- Kayýt Sayýsýný Verir
SELECT COUNT(*) FROM Products

-- SUM
-- Ýlgili Konumdaki Tüm Hücrelerin Ýçeriklerini Toplar
-- Stoðumda Toplam Kaç Adet Ürün Var
SELECT SUM(UnitsInStock) AS ToplamUrun FROM Products

-- Deniz Ürünleri Kategorisinde Stoðumda Toplam Kaç Ürün Var
SELECT SUM(UnitsInStock) AS [Toplam Ürün] FROM Products WHERE CategoryID = 8

-- Deniz Ürünleri Kategorisinde Kaç Adet Ürünüm Var
SELECT COUNT(*) AS [Kaç Adet Kayýt Var] FROM Products WHERE CategoryID = 8

 -- Fiyatý 50'den Büyük Olan Kaç Adet Ürün Kaydým Var
SELECT COUNT(*) FROM Products WHERE UnitPrice > 50

-- Stoðumda Toplam Ne Kadarlýk Ürünüm Var
SELECT SUM(UnitsInStock * UnitPrice) FROM Products

-- Kaç Adet Chai Satmýþýz
SELECT SUM(Quantity) FROM [Order Details] WHERE ProductID = 1

-- Nancy Davolio Kaç Adet Satýþ Yapmýþtýr
SELECT COUNT(*) FROM Orders WHERE EmployeeID = 1