USE EHupifey_Store_DB

GO

CREATE TABLE Categories
(
	ID int IDENTITY(1, 1) NOT NULL,
	Name nvarchar(100) NOT NULL,
	IsDeleted bit NULL,
	CONSTRAINT PK_CategoriesID PRIMARY KEY(ID)
)

GO

CREATE TABLE Employees
(
	ID int IDENTITY(1, 1) NOT NULL,
	FullName nvarchar(100) NOT NULL,
	UserName nvarchar(30) NOT NULL,
	Password nvarchar(30) NOT NULL,
	IsDeleted bit NULL,
	IsActive bit NOT NULL,
	CONSTRAINT PK_EmployeesID PRIMARY KEY(ID)
)
GO

CREATE TABLE Brands
(
	ID int IDENTITY(1, 1) NOT NULL,
	Name nvarchar(50) NOT NULL,
	CONSTRAINT PK_BrandsID PRIMARY KEY(ID)
)

GO

CREATE TABLE Products
(
	ID int IDENTITY(1, 1) NOT NULL,
	CategoryID int NOT NULL,
	BrandID int NOT NULL,
	Name nvarchar(50) NOT NULL,
	Stock int NULL,
	Price decimal(18, 2) NULL,
	IsDeleted bit NULL,
	IsActive bit NOT NULL,
	CONSTRAINT PK_ProductsID PRIMARY KEY(ID),
	CONSTRAINT FK_ProductsCategories FOREIGN KEY(CategoryID) REFERENCES Categories(ID),
	CONSTRAINT FK_ProductsBrands FOREIGN KEY(BrandID) REFERENCES Brands(ID)
)

GO

CREATE TABLE Suppliers
(
	ID int IDENTITY(1, 1) NOT NULL,
	CompanyName nvarchar(100) NOT NULL,
	ContactName nvarchar(100) NULL,
	City nvarchar(100) NOT NULL,
	Country nvarchar(100) NOT NULL,
	Adress nvarchar(500) NOT NULL,
	Mail nvarchar(100) NOT NULL,
	PhoneNumber nchar(25) NOT NULL,
	IsDeleted bit NULL,
	IsActive bit NOT NULL,
	CONSTRAINT PK_SuppliersID PRIMARY KEY(ID)
)

GO

CREATE TABLE Purchases
(
	ID int IDENTITY(1, 1) NOT NULL,
	ProductID int NOT NULL,
	EmployeeID int NOT NULL,
	SupplierID int NOT NULL,
	Date datetime DEFAULT GETDATE() NOT NULL,
	Quantity int NULL,
	Price decimal(18, 2) NULL,
	CONSTRAINT PK_PurchasesID PRIMARY KEY(ID),
	CONSTRAINT FK_PurchasesProduct FOREIGN KEY(ProductID) REFERENCES Products(ID),
	CONSTRAINT FK_PurchasesEmployees FOREIGN KEY(EmployeeID) REFERENCES Employees(ID),
	CONSTRAINT FK_PurchasesSuppliers FOREIGN KEY(SupplierID) REFERENCES Suppliers(ID)
)

GO

CREATE TABLE Sales
(
	ID int IDENTITY(1, 1) NOT NULL,
	EmployeeID int NOT NULL,
	ProductID int NOT NULL,
	Date datetime DEFAULT GETDATE() NOT NULL,
	Quantity int NOT NULL,
	SalesPrice decimal(18, 2) NOT NULL,
	CONSTRAINT PK_SalesID PRIMARY KEY(ID),
	CONSTRAINT FK_SalesEmployees FOREIGN KEY(EmployeeID) REFERENCES Employees(ID),
	CONSTRAINT FK_SalesProducts FOREIGN KEY(ProductID) REFERENCES Products(ID)
)