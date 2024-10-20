CREATE TRIGGER AddSaleAndDecraseStock
ON Sales
AFTER INSERT
AS
	BEGIN
	DECLARE @ProductID int
	DECLARE @Quantity int

	SELECT @ProductID = ProductID, @Quantity = Quantity FROM inserted

	UPDATE Products SET Stock = Stock - @Quantity WHERE ID = @ProductID
	END

GO

CREATE TRIGGER DeleteSaleAndIncraseStock
ON Sales
AFTER DELETE
AS
	BEGIN
	DECLARE @ProductID int
	DECLARE @Quantity int

	SELECT @ProductID = ProductID, @Quantity = Quantity FROM inserted

	UPDATE Products SET Stock = Stock + @Quantity WHERE ID = @ProductID
	END

GO

CREATE TRIGGER UpdateSaleAndUpdateStock
ON Sales
AFTER UPDATE
AS
	BEGIN
    DECLARE @ProductID INT;
    DECLARE @OldQuantity INT;
    DECLARE @NewQuantity INT;

    SELECT @ProductID = ProductID, @OldQuantity = Quantity FROM deleted;
    SELECT @NewQuantity = Quantity FROM inserted;

    UPDATE Products SET Stock = Stock - (@OldQuantity - @NewQuantity) WHERE ID = @ProductID;
	END