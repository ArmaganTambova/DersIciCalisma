-- Stored Procedure
-- Temelde SQL Ýçerisinde Metot Oluþturmak Ýçin Kullanýlýr
-- View Sorgu Gibi Kullanýlabilir Ancak Stored Procedure Sadece Programlandýðý Ýþi Yapar

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
			PRINT('Bu Kategori Daha Önce Eklenmiþ')
			-- RAISERROR('Bu Kategori Daha Önce Eklenmiþ', 10, 1)
		END
END

EXEC InsertCategory 'Ýçecek', 0