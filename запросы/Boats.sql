USE MyProg


CREATE TABLE Boats(
	ID int Primary key IDENTITY(1,1),
	BoatType varchar(20) NOT NULL,
	RowersCount int NOT NULL,
	IsMast bit NOT NULL,
	WoodType varchar(20) NOT NULL,
	BaseCost int NOT NULL,
	CostWithNDS int NOT NULL
)
