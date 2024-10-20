SELECT * FROM Products
SELECT * FROM Purchases

INSERT INTO Purchases (ProductID, Quantity, Price, EmployeeID, SupplierID) VALUES (1, 10, 100, 1, 1)

DELETE FROM Purchases WHERE ID = 2

UPDATE Purchases SET Quantity = 15 WHERE ID = 3