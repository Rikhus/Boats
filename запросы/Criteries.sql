USE MyProg


CREATE TABLE dbo.OrderCriteries(
	ID int IDENTITY(1,1) Primary key,
	EquipmentID int NOT NULL,
	OrderID int NOT NULL
)
