-- COUNT
-- Kayýt Sayý Bilgisi Alma

USE Kutuphane
GO

-- Kaç Adet Kitabým Var
SELECT COUNT(*) FROM Books

-- "Ýþ Bankasý Kültür Yayýnlarý" Kitaplarýný Listeleyelim
SELECT * FROM Books WHERE PublishingHouseID = 23

-- "Ýþ Bankasý Kültür Yayýnlarý" na Ait Kaç Adet Kitabým Var
SELECT COUNT(*) FROM Books WHERE PublishingHouseID = 23

-- Kaç Adet Türkçe Kitabýmýz Var
SELECT COUNT(*) FROM Books WHERE LanguageID = 2

SELECT * FROM Authors
-- Kaç Adet "Lev Tolstoy" Kitabýmýz Var
SELECT COUNT(*) FROM BooksAndAuthors WHERE AuthorID = 54