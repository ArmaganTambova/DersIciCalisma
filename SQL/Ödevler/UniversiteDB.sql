CREATE DATABASE UniversiteDB
GO
USE UniversiteDB
GO

CREATE TABLE Fakulteler
(
	ID int IDENTITY(1, 1),
	Isim nvarchar(100) NOT NULL,
	Dekan  nvarchar(120),
	CONSTRAINT PK_Fakulte PRIMARY KEY(ID)
)

GO

CREATE TABLE Bolumler
(
	ID int IDENTITY(10, 1),
	Fakulte_ID int,
	Isim nvarchar(100) NOT NULL,
	CONSTRAINT PK_Bolum  PRIMARY KEY(ID),
	CONSTRAINT FK_BolumFakulte FOREIGN KEY(Fakulte_ID) REFERENCES Fakulteler(ID)
)

GO

CREATE TABLE Dersler
(
	Kod int IDENTITY(100, 1),
	Bolum_ID int,
	Isim nvarchar(100) NOT NULL,
	Kredi tinyint,
	Saat tinyint,
	CONSTRAINT PK_Ders PRIMARY KEY(Kod),
	CONSTRAINT FK_DersBolum FOREIGN KEY(Bolum_ID) REFERENCES Bolumler(ID)
)

GO

CREATE TABLE Ogrenciler
(
	OkulNo nvarchar(11),
	Bolum_ID int,
	Isim nvarchar(75) NOT NULL,
	SoyIsim nvarchar (75) NOT NULL,
	VeliAdi nvarchar(75),
	CONSTRAINT PK_Ogrenci PRIMARY KEY(OkulNo),
	CONSTRAINT FK_OgrenciBolum FOREIGN KEY(Bolum_ID) REFERENCES Bolumler(ID)
)

GO

CREATE TABLE AlinanDersler
(
	OgrenciNo nvarchar(11),
	DersKodu int,
	CONSTRAINT PK_AlinanDers PRIMARY KEY(OgrenciNo, DersKodu),
	CONSTRAINT FK_AlinanDersOgrenci FOREIGN KEY(OgrenciNo) REFERENCES Ogrenciler(OkulNo),
	CONSTRAINT FK_AlinanDersDers FOREIGN KEY(DersKodu) REFERENCES Dersler(Kod)
)