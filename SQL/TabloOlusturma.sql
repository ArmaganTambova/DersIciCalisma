-- Tablo Oluþturma
-- Tablo Oluþturmak Ýçin Kolon Ýsimleri Ve Veri Türleri Yazýlmalýdýr
-- Tablo Satýrlarý Veri Ekledikçe Oluþacaktýr
USE OgrenciKayitSistemi
GO

-- SQL Server Veri Tipleri
-- C#		SQL
-- string   nvarchar(xx) // Türkçe Karakter Kabul Eder
-- string   varchar(xx)
-- char     char(xx)
-- byte     tinyint
-- short    smallint
-- int      int
-- long     bigint
-- decimal  money           12,0000
-- decimal  decimal(18,2)   12,00
-- dobule   double
-- bool     bit

CREATE TABLE Ogrenciler
(
	OgrenciNo int,
	Isim nvarchar(50),
	Soyisim nvarchar(50),
	TCNO nvarchar(11),
	Sinif tinyint,
	Sube char(1),
	Telefon nvarchar(11),
	MezunMu bit,
	CONSTRAINT PK_Ogrenciler PRIMARY KEY(OgrenciNo)
	-- OgrenciNo Kolunu PRIMARY KEY Yapýlarak Ýçindeki Verilerin Unique (Eþsiz) Olmasý Saðlandý
	-- Bir Tablonun Sadece 1 Adet PRIMARY KEY'i Olabilir
	-- PRIMARY KEYler Boþ Býrakýlamaz
)
DROP TABLE Ogrenciler