USE KutuphaneOdev_DB

GO

CREATE TABLE Kategoriler
(
	KategoriID int IDENTITY(1, 1),
	KategoriAdi nvarchar(50) NOT NULL,
	CONSTRAINT PK_KategorilerID PRIMARY KEY(KategoriID)
)

GO

CREATE TABLE Turler
(
	TurID int IDENTITY(1, 1),
	TurAdi nvarchar(50) NOT NULL,
	CONSTRAINT PK_TurlerID PRIMARY KEY(TurID)
)

GO

CREATE TABLE Yazarlar
(
	YazarID int IDENTITY(1, 1),
	Adi nvarchar(100) NOT NULL,
	Soyadi nvarchar(100) NULL,
	DogumYeri nvarchar(75) NULL,
	DogumTarihi date DEFAULT NULL,
	OlumTarihi date DEFAULT NULL,
	CONSTRAINT PK_YazalarID PRIMARY KEY(YazarID)
)

GO

CREATE TABLE YayinEvleri
(
	YayinEviID int IDENTITY(1, 1),
	Adi nvarchar(150) NOT NULL,
	Adres nvarchar(500) NULL,
	TelNo varchar(11) NULL,
	IrtibatKisisiAdi nvarchar(100) NULL,
	EMail nvarchar(250) NULL,
	Sehir nvarchar(75) NULL,
	CONSTRAINT PK_YayinEvleriID PRIMARY KEY(YayinEviID)
)

GO

CREATE TABLE Kitaplar
(
	ID int IDENTITY(1, 1),
	KitapAdi nvarchar(250) NOT NULL,
	SayfaSayisi int NOT NULL,
	BaskiSayisi int NULL,
	KategoriID int NOT NULL,
	TurID int NOT NULL,
	YazarID int NULL,
	YayinEviID int NULL,
	CONSTRAINT PK_KitaplarID PRIMARY KEY(ID),
	CONSTRAINT FK_KitaplarKategoriler FOREIGN KEY(KategoriID) REFERENCES Kategoriler(KategoriID),
	CONSTRAINT FK_KitaplarTurler FOREIGN KEY(TurID) REFERENCES Turler(TurID),
	CONSTRAINT FK_KitaplarYazarlar FOREIGN KEY(YazarID) REFERENCES Yazarlar(YazarID),
	CONSTRAINT FK_KitaplarYayinEvleri FOREIGN KEY(YayinEviID) REFERENCES YayinEvleri(YayinEviID)
)