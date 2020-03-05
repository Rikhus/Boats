USE MyProg

CREATE TABLE Managers(
	ID int IDENTITY(1,1) Primary key,
	LastName varchar(50) NOT NULL,
	FirstName varchar(50) NOT NULL
)
