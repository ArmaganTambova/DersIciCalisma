-- COUNT
-- Kay�t Say� Bilgisi Alma

USE Kutuphane
GO

-- Ka� Adet Kitab�m Var
SELECT COUNT(*) FROM Books

-- "�� Bankas� K�lt�r Yay�nlar�" Kitaplar�n� Listeleyelim
SELECT * FROM Books WHERE PublishingHouseID = 23

-- "�� Bankas� K�lt�r Yay�nlar�" na Ait Ka� Adet Kitab�m Var
SELECT COUNT(*) FROM Books WHERE PublishingHouseID = 23

-- Ka� Adet T�rk�e Kitab�m�z Var
SELECT COUNT(*) FROM Books WHERE LanguageID = 2

SELECT * FROM Authors
-- Ka� Adet "Lev Tolstoy" Kitab�m�z Var
SELECT COUNT(*) FROM BooksAndAuthors WHERE AuthorID = 54