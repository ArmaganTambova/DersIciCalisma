CREATE DATABASE KoMat_Kutuphane
GO
USE KoMat_Kutuphane
GO

CREATE TABLE Turler
(
	ID int IDENTITY(1 ,1),
	Isim nvarchar(75) NOT NULL,
	CONSTRAINT PK_TurlerID PRIMARY KEY(ID)
)

GO

CREATE TABLE Yazarlar
(
	ID int IDENTITY(1 ,1),
	Isim nvarchar(75) NOT NULL,
	SoyIsim nvarchar(75) NULL,
	CONSTRAINT PK_YazalarID PRIMARY KEY(ID)
)

GO

CREATE TABLE YayinEvleri
(
	ID int IDENTITY(1, 1),
	Isim nvarchar(75),
	CONSTRAINT PK_YayinEvleriID PRIMARY KEY(ID)
)

GO

CREATE TABLE Diller
(
	ID int IDENTITY(1, 1),
	Dil nvarchar(50),
	CONSTRAINT PK_DillerID PRIMARY KEY(ID)
)

GO

CREATE TABLE Kitaplar
(
	ID int IDENTITY(1, 1),
	SiraNo smallint,
	TurID int,
	YayinEviID int,
	DilID int,
	Isim nvarchar(200),
	Barkod varchar(13),
	CONSTRAINT PK_KitapID PRIMARY KEY(ID),
	CONSTRAINT FK_KitaplarTurler FOREIGN KEY(TurID) REFERENCES Turler(ID),
	CONSTRAINT FK_KitaplarYayinEvi FOREIGN KEY(YayinEviID) REFERENCES YayinEvleri(ID),
	CONSTRAINT FK_KitaplarDiller FOREIGN KEY(DilID) REFERENCES Diller(ID)
)

GO

CREATE TABLE KitapYazarlar
(
	KitapID int,
	YazarID int,
	CONSTRAINT PK_KitapYazarID PRIMARY KEY(KitapID, YazarID),
	CONSTRAINT FK_KitapYazarlarKitaplar FOREIGN KEY(KitapID) REFERENCES Kitaplar(ID),
	CONSTRAINT FK_KitapYazarlarYazarlar FOREIGN KEY(YazarID) REFERENCES Yazarlar(ID)
)

GO

CREATE TABLE Kiralamalar
(
	ID int IDENTITY(1, 1),
	KitapID int,
	KiralamaTarihi datetime DEFAULT GETDATE(),
	TeslimTarihi datetime DEFAULT NULL,
	Aciklamalar nvarchar(MAX),
	CONSTRAINT PK_KiralamaID PRIMARY KEY(ID),
	CONSTRAINT FK_KiralamalarKitaplar FOREIGN KEY(KitapID) REFERENCES Kitaplar(ID)
)