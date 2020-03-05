USE MyProg

CREATE TABLE OptionalEquipment(
	ID int IDENTITY(1,1) Primary key,
	Name varchar(20) NOT NULL,
	Description varchar(60) NOT NULL,
	Cost int NOT NULL,
	CostWithNDS int NOT NULL,
	Availability int NOT NULL,
	PartnerID int NOT NULL
)

