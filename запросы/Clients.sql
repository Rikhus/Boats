USE MyProg


CREATE TABLE Clients(
	ID int IDENTITY(1,1) Primary key,
	LastName varchar(50) NOT NULL,
	FirstName varchar(50) NOT NULL,
	DateOfBirth date NOT NULL,
	Adress varchar(50) NOT NULL,
	Contacts varchar(20) NOT NULL,
	Email varchar(50) NULL,
	OrganizationName varchar(50) NULL,
	DocumentName varchar(50) NOT NULL,
	DocNumbers varchar(50) NOT NULL
)

