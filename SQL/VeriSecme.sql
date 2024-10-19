-- VERÝ SEÇME
-- SELECT

USE Kutuphane
GO

-- Yazarlar Tablosunun Tüm Kolonlarý Ve Satýrlarý
SELECT * FROM Authors
-- * Tüm Kolonlarý Seç Anlamýnda Kullanýlýr

-- Yazarlar Tablosunun AuthorName ve AuthorSurname Kolonlarýnýn Verilerini Alalým
SELECT AuthorName, AuthorSurname FROM Authors

-- Hesaplanmýþ Kolonlar
SELECT ID, AuthorName + ' ' + AuthorSurname AS Authors FROM Authors