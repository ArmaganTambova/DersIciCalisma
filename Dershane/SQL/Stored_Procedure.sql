-- Stored Procedure
-- Temelde SQL ��erisinde Metot Olu�turmak ��in Kullan�l�r
-- View Sorgu Gibi Kullan�labilir Ancak Stored Procedure Sadece Programland��� ��i Yapar

CREATE PROCEDURE StockResult
AS
SELECT * FROM Products WHERE Stock < 20

EXEC StockResult

GO

CREATE PROCEDURE InsertCategory
@CategoryName nvarchar(100), @IsDeleted bit
AS
BEGIN
	DECLARE @Sayi int

	SELECT @Sayi = COUNT(*) FROM Categories WHERE Name = @CategoryName

	IF(@Sayi = 0)
		BEGIN
			INSERT INTO Categories(Name, IsDeleted) VALUES (@CategoryName, @IsDeleted)
		END
	ELSE
		BEGIN
			PRINT('Bu Kategori Daha �nce Eklenmi�')
			-- RAISERROR('Bu Kategori Daha �nce Eklenmi�', 10, 1)
		END
END

EXEC InsertCategory '��ecek', 0