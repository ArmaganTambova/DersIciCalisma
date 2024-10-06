-- VER� EKLEME
-- INSERT INTO
-- �ncelikle Aviable Database K�sm�nda ��lem Yapmak �stedi�iniz Veritaban�n�n Se�ili Oldu�una Dikkat Etmeliyiz

USE UniversiteDB
GO

INSERT INTO Fakulteler(Isim, Dekan) VALUES('Fen Edebiyat Fak�ltesi', 'Poyraz SAL�H')
INSERT INTO Fakulteler(Isim) VALUES('M�hendislik Mimarl�k Fak�ltesi')
-- Verileri Eklemek �stedi�imiz Kolonlar� Yaz�yoruz. VALUES Alan�nda Yazd���m�z Kolon S�ras�na G�re Verileri Ekliyoruz
-- Query �al��t�r�ld���nda "1 Sat�r Etkilendi" Bildirimi �le Verinin Ba�ar�l� Bir �ekilde Eklendi�ini G�r�yoruz
-- INSERT INTO Komutu Her �al��t�r�ld���nda  Ayn� Veriyi Ekler

INSERT INTO Bolumler(Fakulte_ID, Isim) VALUES(2, 'Bilgisayar M�hendisli�i')
INSERT INTO Bolumler(Fakulte_ID, Isim) VALUES(2, 'Makine M�hendisli�i')
INSERT INTO Bolumler(Fakulte_ID, Isim) VALUES(2, 'Kimya M�hendisli�i')
INSERT INTO Bolumler(Fakulte_ID, Isim) VALUES(2, '�n�aat M�hendisli�i')

SELECT * FROM Fakulteler
SELECT * FROM Bolumler