USE MyProg


CREATE TABLE Partners(
	ID int IDENTITY(1,1) Primary key,
	Name varchar(50) NOT NULL,
	Address varchar(50) NOT NULL,
	City varchar(20) NOT NULL
)

