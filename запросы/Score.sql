USE MyProg


CREATE TABLE Score(
	ID int IDENTITY(1,1) Primary key,
	ContractID int NOT NULL,
	PaymentStatus varchar(20) NOT NULL,
	Cost int NOT NULL,
	CostWithNDS int NOT NULL,
	Date datetime NOT NULL
)

