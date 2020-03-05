USE MyProg


CREATE TABLE BoatAccessories(
	ID int IDENTITY(1,1) Primary key,
	EquipmentID int NOT NULL,
	BoatID int NOT NULL
) 

