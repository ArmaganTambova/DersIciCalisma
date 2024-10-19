-- WHERE KULLANIMI
-- Se�ilen Sat�rlarda K�s�tlama Yapmak ��in WHERE Kullan�l�r

USE Kutuphane
GO

-- T�rk�e Kitaplar� Listeleyelim
SELECT * FROM Books
SELECT * FROM Languages

SELECT * FROM Books WHERE LanguageID = 2 -- LanguageID Kolonu 2 Olan Sat�rlar� Listele

-- Yay�n Evi "�� Bankas� K�lt�r Yay�nlar�" Olan Kitaplar�n Listesi
SELECT * FROM PublishingHouses
SELECT * FROM Books WHERE PublishingHouseID = 23

SELECT ID, BookName, Barkod FROM Books WHERE PublishingHouseID = 23