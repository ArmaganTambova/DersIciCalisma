-- VER� SE�ME
-- SELECT

USE Kutuphane
GO

-- Yazarlar Tablosunun T�m Kolonlar� Ve Sat�rlar�
SELECT * FROM Authors
-- * T�m Kolonlar� Se� Anlam�nda Kullan�l�r

-- Yazarlar Tablosunun AuthorName ve AuthorSurname Kolonlar�n�n Verilerini Alal�m
SELECT AuthorName, AuthorSurname FROM Authors

-- Hesaplanm�� Kolonlar
SELECT ID, AuthorName + ' ' + AuthorSurname AS Authors FROM Authors