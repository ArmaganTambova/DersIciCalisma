CREATE DATABASE TechLib_DB
GO
USE TechLib_DB
GO

CREATE TABLE Students
(
	ID int IDENTITY(1, 1),
	FirstName nvarchar(75) NOT NULL,
	LastName nvarchar(75) NOT NULL,
	EMail nvarchar(100) NULL,
	Grade varchar(2) NOT NULL,
	Section char(1) NOT NULL,
	SchoolNumber varchar(6) NOT NULL,
	Active bit NOT NULL,
	CONSTRAINT PK_Students PRIMARY KEY(ID)
)

GO

CREATE TABLE Users
(
	ID int IDENTITY(111111, 1),
	FirstName nvarchar(75) NOT NULL,
	LastName nvarchar(75) NULL,
	UserEmail nvarchar(100) NULL UNIQUE,
	UserPassword varbinary(MAX) NOT NULL,
	UserRole nvarchar(20) NOT NULL,
	CreateTime datetime DEFAULT GETDATE(),
	LastLogin datetime DEFAULT NULL,
	Active bit  NOT NULL,
	CONSTRAINT PK_UsersID PRIMARY KEY(ID),
	CONSTRAINT CHK_UserRole CHECK (UserRole IN ('Admin', 'Assigned Student'))
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
	GenreID int NOT NULL,
	LanguageID int NOT NULL,
	PublishingHouseID int NOT NULL,
	BookNumber smallint NOT NULL,
	Barcode varchar(13) NULL,
	BookImage varbinary(MAX) NULL,
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
	BookID int NOT NULL,
	AuthorID int NOT NULL,
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
	UserID int NOT NULL,
	LoanDate datetime DEFAULT GETDATE() NOT NULL,
	ReturnDate datetime DEFAULT NULL,
	ActualReturnDate datetime DEFAULT NULL,
	Details nvarchar(MAX) NULL,
	CONSTRAINT PK_LoansID PRIMARY KEY(ID),
	CONSTRAINT FK_BooksLoans FOREIGN KEY(BookID) REFERENCES Books(ID),
	CONSTRAINT FK_UsersLoans FOREIGN KEY(ProcessedByID) REFERENCES Users(ID),
	CONSTRAINT FK_StudentsLoans FOREIGN KEY(UserID) REFERENCES Students(ID)
)

GO

CREATE TABLE ActivityLogs
(
	ID int IDENTITY(1, 1),
	UserID int NOT NULL,
	UserAction nvarchar(100) NOT NULL,
	ActionTime datetime DEFAULT GETDATE() NOT NULL,
	Details nvarchar(250) NULL,
	CONSTRAINT PK_ActivityLogsID PRIMARY KEY(ID),
	CONSTRAINT FK_UsersActivityLogs FOREIGN KEY(UserID) REFERENCES Users(ID)
)

GO

CREATE TABLE Reservations
(
	ID int IDENTITY(1, 1),
	BookID int NOT NULL,
	UserID int NOT NULL,
	ProcessedByID int NOT NULL,
	ReservationsDate datetime NOT NULL,
	ExpirationDate datetime NOT NULL,
	Status varchar(20) NOT NULL,
	Details nvarchar(250) NULL,
	CONSTRAINT PK_ReservationsID PRIMARY KEY(ID),
	CONSTRAINT FK_BooksReservations FOREIGN KEY(BookID) REFERENCES Books(ID),
	CONSTRAINT FK_StudentsReservations FOREIGN KEY(UserID) REFERENCES Students(ID),
	CONSTRAINT FK_UsersReservations FOREIGN KEY(ProcessedByID) REFERENCES Users(ID),
	CONSTRAINT CHK_ReservationsStatus CHECK (Status IN ('Active', 'Completed', 'Cancelled', 'Expired'))
)

GO

CREATE TABLE Alerts
(
	ID int IDENTITY(1, 1),
	UserID int NOT NULL,
	AlertType varchar(25) NOT NULL,
	AlertDate datetime DEFAULT GETDATE() NOT NULL,
	CONSTRAINT PK_AlertsID PRIMARY KEY(ID),
	CONSTRAINT FK_StudentsAlerts FOREIGN KEY(UserID) REFERENCES Students(ID)
)

GO

CREATE TABLE Suspensions
(
	ID int IDENTITY(1, 1),
	UserID int NOT NULL,
	SuspensionStartDate datetime DEFAULT GETDATE() NOT NULL,
	SuspensionEndDate datetime NOT NULL,
	Reason nvarchar(250) NOT NULL,
	CONSTRAINT PK_SuspensionID PRIMARY KEY(ID),
	CONSTRAINT FK_StudentsSuspensions FOREIGN KEY(UserID) REFERENCES Students(ID)
)