-- VERÝ DÜZENLEME
-- UPDATE

USE UniversiteDB
GO
SELECT * FROM Fakulteler
SELECT * FROM Bolumler

UPDATE Fakulteler SET Isim = 'Güzel Sanatlar Fakültesi', Dekan = 'Alperen Efe Düz'

-- Update Komutu Where Ýle Satýr Bazýnda Kýsýtlanmaz Ýse Tüm Tabloyu Günceller

UPDATE Fakulteler SET Isim = 'Beden Eðitimi Meslek Yüksek Okulu', Dekan = 'Burhan Kaan AYDIGÖR' WHERE ID = 2 -- ID'si 2 Olan Satýrýn Isim ve Dekan Kolonunu Güncelle
UPDATE Fakulteler SET Dekan = 'Armaðan TAMBOVA' WHERE ID = 3
UPDATE Fakulteler SET Isim = 'Güzel Sanatlar Fakültesi', Dekan = 'Alperen Efe Düz' WHERE ID = 1

UPDATE Bolumler SET Fakulte_ID = 3 WHERE Fakulte_ID = 2