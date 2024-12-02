USE NORTHWND
GO

SELECT ProductID, ProductName, CategoryID, UnitPrice FROM Products WHERE CategoryID = '' OR 1=1 -- AND SupplierID = 3

SELECT * FROM Employees

SELECT * FROM Employees WHERE City = 'Redmond' AND PostalCode = '98052'
SELECT * FROM Employees WHERE City = '' OR 1=1 -- AND PostalCode = '98052'

--SQL INJECTION '' OR 1=1