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
CREATE TABLE Orders(
	ID int IDENTITY(1,1) Primary key,
	ClientID int References Clients(ID) on delete set default,
	ContractID int NOT NULL,
	Date datetime NOT NULL,
	FirstPayment int NOT NULL,
	Cost money NOT NULL,
	CostWithNDS money NOT NULL,
	IsReady bit NOT NULL
)
CREATE TABLE OptionalEquipment(
	ID int IDENTITY(1,1) Primary key,
	Name varchar(20) NOT NULL,
	Description varchar(60) NOT NULL,
	Cost money NOT NULL,
	CostWithNDS money NOT NULL,
	Availability int NOT NULL,
	PartnerID int NOT NULL
)
CREATE TABLE Boats(
	ID int Primary key IDENTITY(1,1),
	BoatType varchar(20) NOT NULL,
	RowersCount int NOT NULL,
	IsMast bit NOT NULL,
	WoodType varchar(20) NOT NULL,
	BaseCost money NOT NULL,
	CostWithNDS money NOT NULL
)
CREATE TABLE BoatAccessories(
	ID int IDENTITY(1,1) Primary key,
	EquipmentID int References OptionalEquipment(ID) on delete set default,
	BoatID int References Boats(ID) on delete set default
) 
CREATE TABLE Partners(
	ID int IDENTITY(1,1) Primary key,
	Name varchar(50) NOT NULL,
	Address varchar(50) NOT NULL,
	City varchar(20) NOT NULL
)
CREATE TABLE Score(
	ID int IDENTITY(1,1) Primary key,
	ContractID int NOT NULL,
	PaymentStatus varchar(20) NOT NULL,
	Cost money NOT NULL,
	CostWithNDS money NOT NULL,
	Date datetime NOT NULL
)
CREATE TABLE Managers(
	ID int IDENTITY(1,1) Primary key,
	LastName varchar(50) NOT NULL,
	FirstName varchar(50) NOT NULL
)
CREATE TABLE Delivery(
	ID int IDENTITY(1,1) Primary key,
	Date datetime NOT NULL,
	ManagerID int References Managers(ID) on delete set default,
	ClientID int References Clients(ID) on delete set default,
	BoatID int References Boats(ID) on delete set default,
	Adress varchar(50) NOT NULL,
	City varchar(50) NOT NULL
)
CREATE TABLE dbo.OrderCriteries(
	ID int IDENTITY(1,1) Primary key,
	EquipmentID int References OptionalEquipment(ID) on delete set default,
	OrderID int References Orders(ID) on delete set default
)

