-- VER� D�ZENLEME
-- UPDATE

USE UniversiteDB
GO
SELECT * FROM Fakulteler
SELECT * FROM Bolumler

UPDATE Fakulteler SET Isim = 'G�zel Sanatlar Fak�ltesi', Dekan = 'Alperen Efe D�z'

-- Update Komutu Where �le Sat�r Baz�nda K�s�tlanmaz �se T�m Tabloyu G�nceller

UPDATE Fakulteler SET Isim = 'Beden E�itimi Meslek Y�ksek Okulu', Dekan = 'Burhan Kaan AYDIG�R' WHERE ID = 2 -- ID'si 2 Olan Sat�r�n Isim ve Dekan Kolonunu G�ncelle
UPDATE Fakulteler SET Dekan = 'Arma�an TAMBOVA' WHERE ID = 3
UPDATE Fakulteler SET Isim = 'G�zel Sanatlar Fak�ltesi', Dekan = 'Alperen Efe D�z' WHERE ID = 1

UPDATE Bolumler SET Fakulte_ID = 3 WHERE Fakulte_ID = 2