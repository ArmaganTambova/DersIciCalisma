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
	OkulID int, -- Bu Kolona Veriler Okullar Tablosunun ID Kolonundan Gelecek, Bu Sebeple Okullar Tablosunun ID Kolonunun T�r� Ne �se (int) Bu Tablodaki OkulID Kolonunun T�r�de O Olmal�d�r
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
	-- OgrenciNo Kolunu PRIMARY KEY Yap�larak ��indeki Verilerin Unique (E�siz) Olmas� Sa�land�
	-- Bir Tablonun Sadece 1 Adet PRIMARY KEY'i Olabilir
	-- PRIMARY KEYler Bo� B�rak�lamaz, NOT NULL'dur
	-- NOT NULL Kolon ��eri�inin Null Olarak B�rak�lmas�n� Engeller
	-- IDENTITY() Say�sal PRIMARY KEY, Alanlarda Verilerin Otomatik At�lmas�n� Sa�lar
)

DROP TABLE Ogrenciler
GO
DROP TABLE Okullar
DROP TABLE Subeler