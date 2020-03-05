USE MyProg


CREATE TABLE Delivery(
	ID int IDENTITY(1,1) Primary key,
	Date datetime NOT NULL,
	ManagerID int NOT NULL,
	ClientID int NOT NULL,
	BoatID int NOT NULL,
	Adress varchar(50) NOT NULL,
	City varchar(50) NOT NULL
)

