CREATE TRIGGER AddPurchaseAndIncraseStock
ON Purchases -- Tetikleyecinin Eklendi�i Tablo
AFTER INSERT -- Tetikleyici Ne Zaman �al��acak
AS
	BEGIN
		-- �htiya� Duydu�umuz Verileri Saklayaca��m De�i�kenler
		DECLARE @pruductID int
		DECLARE @quantity int

		-- Tabloya Eklenen Sat�rda �htiyac�m Olan H�cre Verilerini Al�yorum
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