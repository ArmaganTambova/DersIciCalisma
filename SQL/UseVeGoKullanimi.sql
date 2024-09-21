-- USE Ve GO Komutu

-- ÖNCELÝKLE
-- Tablonun Oluþturulacaðý Veritabanýný Available Databases Ksýmýndan Seçmemiz Veya Query Ýle Seçtirmemiz Gerekmektedir
CREATE DATABASE OgrenciKayitSistemiDB -- Oluþtur
GO -- Önce Buraya Kadar Olan Komutlarý Çalýþtýr Sonra Devam Et
USE OgrenciKayitSistemiDB -- Kullan

USE master
GO
DROP DATABASE OgrenciKayitSistemiDB
-- Silme Ýþleminden OgrenciKayitSistemiDB Ýsimli Veritabanýný Available Databases Kýsmýndan Kaldýrdýk Ve Daha Sonra Silebildik