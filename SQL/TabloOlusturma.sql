-- Tablo Olu�turma
-- Tablo Olu�turmak ��in Kolon �simleri Ve Veri T�rleri Yaz�lmal�d�r
-- Tablo Sat�rlar� Veri Ekledik�e Olu�acakt�r
USE OgrenciKayitSistemi
GO

-- SQL Server Veri Tipleri
-- C#		SQL
-- string   nvarchar(xx) // T�rk�e Karakter Kabul Eder
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
	-- OgrenciNo Kolunu PRIMARY KEY Yap�larak ��indeki Verilerin Unique (E�siz) Olmas� Sa�land�
	-- Bir Tablonun Sadece 1 Adet PRIMARY KEY'i Olabilir
	-- PRIMARY KEYler Bo� B�rak�lamaz
)
DROP TABLE Ogrenciler