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
CREATE TABLE Okullar
(
	ID int IDENTITY(1, 1),
	OkulAdi nvarchar(100) NOT NULL,
	OkulTelefon nvarchar(11),
	Adres nvarchar(250),
	CONSTRAINT PK_Okul PRIMARY KEY(ID)
)

GO

CREATE TABLE Subeler
(
	ID int IDENTITY(1, 1),
	Sube nvarchar (10)
	CONSTRAINT PK_Sube PRIMARY KEY(ID)
)

GO

CREATE TABLE Ogrenciler
(
	TCNO nvarchar(11),
	OkulID int, -- Bu Kolona Veriler Okullar Tablosunun ID Kolonundan Gelecek, Bu Sebeple Okullar Tablosunun ID Kolonunun Türü Ne Ýse (int) Bu Tablodaki OkulID Kolonunun Türüde O Olmalýdýr
	SubeID int,
	Isim nvarchar(50) NOT NULL,
	Soyisim nvarchar(50) NOT NULL,
	Sinif tinyint,
	Sube char(1),
	Telefon nvarchar(11),
	MezunMu bit,
	CONSTRAINT PK_Ogrenciler PRIMARY KEY(TCNO),
	CONSTRAINT FK_OgrencilerOkullar FOREIGN KEY(OkulID) REFERENCES Okullar(ID),
	CONSTRAINT FK_OgrencilerSubeler FOREIGN KEY(SubeID) REFERENCES Subeler(ID)
	-- OgrenciNo Kolunu PRIMARY KEY Yapýlarak Ýçindeki Verilerin Unique (Eþsiz) Olmasý Saðlandý
	-- Bir Tablonun Sadece 1 Adet PRIMARY KEY'i Olabilir
	-- PRIMARY KEYler Boþ Býrakýlamaz, NOT NULL'dur
	-- NOT NULL Kolon Ýçeriðinin Null Olarak Býrakýlmasýný Engeller
	-- IDENTITY() Sayýsal PRIMARY KEY, Alanlarda Verilerin Otomatik Atýlmasýný Saðlar
)

DROP TABLE Ogrenciler
GO
DROP TABLE Okullar
DROP TABLE Subeler