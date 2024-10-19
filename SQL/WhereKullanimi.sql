-- WHERE KULLANIMI
-- Seçilen Satýrlarda Kýsýtlama Yapmak Ýçin WHERE Kullanýlýr

USE Kutuphane
GO

-- Türkçe Kitaplarý Listeleyelim
SELECT * FROM Books
SELECT * FROM Languages

SELECT * FROM Books WHERE LanguageID = 2 -- LanguageID Kolonu 2 Olan Satýrlarý Listele

-- Yayýn Evi "Ýþ Bankasý Kültür Yayýnlarý" Olan Kitaplarýn Listesi
SELECT * FROM PublishingHouses
SELECT * FROM Books WHERE PublishingHouseID = 23

SELECT ID, BookName, Barkod FROM Books WHERE PublishingHouseID = 23