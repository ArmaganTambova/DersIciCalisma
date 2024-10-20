CREATE TRIGGER AddPurchaseAndIncraseStock
ON Purchases -- Tetikleyecinin Eklendiði Tablo
AFTER INSERT -- Tetikleyici Ne Zaman Çalýþacak
AS
	BEGIN
		-- Ýhtiyaç Duyduðumuz Verileri Saklayacaðým Deðiþkenler
		DECLARE @pruductID int
		DECLARE @quantity int

		-- Tabloya Eklenen Satýrda Ýhtiyacým Olan Hücre Verilerini Alýyorum
		SELECT @pruductID = ProductID, @quantity = Quantity FROM inserted
		UPDATE Products SET Stock = Stock + @quantity WHERE ID = @pruductID
	END

GO

CREATE TRIGGER DeletePurchaseAndDecraseStock
ON Purchases
AFTER DELETE
AS
	BEGIN
		DECLARE @pruductID int
		DECLARE @quantity int

		SELECT @pruductID = ProductID, @quantity = Quantity FROM deleted
		UPDATE Products SET Stock = Stock - @quantity WHERE ID = @pruductID
	END

GO

CREATE TRIGGER UpdatePurchasesAndUpdateStock
ON Purchases
AFTER UPDATE
AS
	BEGIN
		DECLARE @pruductID int
		DECLARE @oldQuantity int
		DECLARE @newQuantity int

		SELECT @pruductID = ProductID, @oldQuantity = Quantity FROM deleted
		SELECT @newQuantity = Quantity FROM inserted
		UPDATE Products SET Stock = Stock - (@oldQuantity - @newQuantity) WHERE ID = @pruductID
	END