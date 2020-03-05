USE MyProg


CREATE TABLE Orders(
	ID int IDENTITY(1,1) Primary key,
	ClientID int NOT NULL,
	ContractID int NOT NULL,
	Date datetime NOT NULL,
	FirstPayment int NOT NULL,
	Cost int NOT NULL,
	CostWithNDS int NOT NULL,
	IsReady bit NOT NULL
)

