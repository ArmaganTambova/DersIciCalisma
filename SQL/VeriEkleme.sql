-- VERÝ EKLEME
-- INSERT INTO
-- Öncelikle Aviable Database Kýsmýnda Ýþlem Yapmak Ýstediðiniz Veritabanýnýn Seçili Olduðuna Dikkat Etmeliyiz

USE UniversiteDB
GO

INSERT INTO Fakulteler(Isim, Dekan) VALUES('Fen Edebiyat Fakültesi', 'Poyraz SALÝH')
INSERT INTO Fakulteler(Isim) VALUES('Mühendislik Mimarlýk Fakültesi')
-- Verileri Eklemek Ýstediðimiz Kolonlarý Yazýyoruz. VALUES Alanýnda Yazdýðýmýz Kolon Sýrasýna Göre Verileri Ekliyoruz
-- Query Çalýþtýrýldýðýnda "1 Satýr Etkilendi" Bildirimi Ýle Verinin Baþarýlý Bir Þekilde Eklendiðini Görüyoruz
-- INSERT INTO Komutu Her Çalýþtýrýldýðýnda  Ayný Veriyi Ekler

INSERT INTO Bolumler(Fakulte_ID, Isim) VALUES(2, 'Bilgisayar Mühendisliði')
INSERT INTO Bolumler(Fakulte_ID, Isim) VALUES(2, 'Makine Mühendisliði')
INSERT INTO Bolumler(Fakulte_ID, Isim) VALUES(2, 'Kimya Mühendisliði')
INSERT INTO Bolumler(Fakulte_ID, Isim) VALUES(2, 'Ýnþaat Mühendisliði')

SELECT * FROM Fakulteler
SELECT * FROM Bolumler