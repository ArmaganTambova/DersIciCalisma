CREATE DATABASE Kutuphane
GO
USE Kutuphane
GO

CREATE TABLE Users
(
	ID int IDENTITY(111111, 1),
	UserName nvarchar(75) NOT NULL,
	UserSurname nvarchar(75) NOT NULL,
	UserEmail nvarchar(100) NULL,
	UserPassword nvarchar(25) NULL,
	UserRole nvarchar(15) NOT NULL,
	CreateTime datetime DEFAULT GETDATE(),
	LastLogin datetime DEFAULT NULL,
	Active bit  NOT NULL,
	CONSTRAINT PK_UsersID PRIMARY KEY(ID),
	CONSTRAINT CHK_UserRole CHECK (UserRole IN ('Admin', 'Görevli Öðrenci'))
)

GO

CREATE TABLE Authors
(
	ID int IDENTITY(1, 1),
	AuthorName nvarchar(75) NOT NULL,
	AuthorSurname nvarchar(75) NULL,
	CONSTRAINT PK_AuthorID PRIMARY KEY(ID)
)

GO

CREATE TABLE Genres
(
	ID int IDENTITY(1, 1),
	GenreName nvarchar(50) NOT NULL,
	CONSTRAINT PK_GenresID PRIMARY KEY(ID)
)

GO

CREATE TABLE Languages
(
	ID int IDENTITY(1, 1),
	BookLanguage nvarchar(50) NOT NULL,
	CONSTRAINT PK_LanguagesID PRIMARY KEY(ID)
)

GO

CREATE TABLE PublishingHouses
(
	ID int IDENTITY(1, 1),
	PublishingHouseName nvarchar(75) NOT NULL,
	CONSTRAINT PK_PublishingHouseID PRIMARY KEY(ID)
)

GO

CREATE TABLE Books
(
	ID int IDENTITY(1, 1),
	BookName nvarchar(100) NOT NULL,
	GenreID int,
	LanguageID int,
	PublishingHouseID int,
	BookNumber smallint NOT NULL,
	Barkod varchar(13) NOT NULL,
	CreateTime datetime DEFAULT GETDATE(),
	Active bit NOT NULL,
	CONSTRAINT PK_BooksID PRIMARY KEY(ID),
	CONSTRAINT FK_GenresBooks FOREIGN KEY(GenreID) REFERENCES Genres(ID),
	CONSTRAINT FK_LanguagesBooks FOREIGN KEY(LanguageID) REFERENCES Languages(ID),
	CONSTRAINT FK_PublishingHousesBooks FOREIGN KEY(PublishingHouseID) REFERENCES PublishingHouses(ID)
)

GO

CREATE TABLE BooksAndAuthors
(
	BookID int,
	AuthorID int,
	CONSTRAINT PK_BookAndAuthorID PRIMARY KEY(BookID, AuthorID),
	CONSTRAINT FK_BooksBooksAndAuthors FOREIGN KEY(BookID) REFERENCES Books(ID),
	CONSTRAINT FK_AuthorsBooksAndAuthors FOREIGN KEY(AuthorID) REFERENCES Authors(ID)
)

GO

CREATE TABLE Loans
(
	ID int IDENTITY(1, 1),
	BookID int NOT NULL,
	ProcessedByID int NOT NULL,
	LoanDate datetime DEFAULT GETDATE(),
	ReturnDate datetime DEFAULT NULL,
	ActualReturnDate datetime DEFAULT NULL,
	Details nvarchar(MAX) NOT NULL,
	CONSTRAINT PK_LoansID PRIMARY KEY(ID),
	CONSTRAINT FK_BooksLoans FOREIGN KEY(BookID) REFERENCES Books(ID),
	CONSTRAINT FK_UsersLoans FOREIGN KEY(ProcessedByID) REFERENCES Users(ID)
)

GO

CREATE TABLE ActivityLogs
(
	ID int IDENTITY(1, 1),
	UserID int,
	UserAction nvarchar(100) NOT NULL,
	ActionTime datetime DEFAULT GETDATE(),
	Details nvarchar(250) NULL,
	CONSTRAINT PK_ActivityLogsID PRIMARY KEY(ID),
	CONSTRAINT FK_UsersActivityLogs FOREIGN KEY(UserID) REFERENCES Users(ID)
)