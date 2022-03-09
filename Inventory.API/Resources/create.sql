CREATE DATABASE CustomerOrderViewer;

USE CustomerOrderViewer;

CREATE TABLE [dbo].Customer (
	CustomerId INT IDENTITY(1,1) not null,
	FirstName varchar(50) not null,
	MiddleName varchar(50) null,
	LastName varchar(50) not null,
	Age int not null,
	IsActive bit not null,
	primary key (CustomerID)
);

Create table [dbo].Items (
	ItemId int identity(1,1) not null,
	[Description] varchar(100) not null,
	Price decimal(4,2) not null,
	IsActive bit not null,
	primary key (ItemId)
);

Create Table [dbo].[CustomerOrder] (
	CustomerOrderId int identity(1,1) not null,
	CustomerId int not null,
	ItemId int not null,
	Primary Key (CustomerOrderId),
	Foreign Key (CustomerId) References Customer(CustomerId),
	Foreign Key (ItemId) References Items(ItemId)
);

INSERT INTO dbo.Customer (FirstName, MiddleName, LastName, Age, IsActive) values ('Lawrence', NULL, 'Keener', 27,1);
Insert Into dbo.customer (FirstName, MiddleName, LastName, Age, IsActive) values ('Lynette', Null, 'Snyder', 34,1);
Insert into dbo.customer (FirstName, MiddleName, LastName, Age, IsActive) values ('Jesus', null, 'Dimick', 34,1);
Insert into dbo.Customer (FirstName, MiddleName, LastName, Age, IsActive) values ('Betty',null,'Hall',21,1);
Insert into dbo.customer (FirstName, MiddleName, LastName, Age, IsActive) values ('MaryAnn',null,'Castro',43,1);
INSERT INTO dbo.Customer (FirstName, MiddleName, LastName, Age, IsActive) values ('Michael', NULL, 'Cooper', 45,1);
INSERT INTO dbo.Customer (FirstName, MiddleName, LastName, Age, IsActive) values ('Alfred', NULL, 'Cervantes', 21,1);
INSERT INTO dbo.Customer (FirstName, MiddleName, LastName, Age, IsActive) values ('Megan', NULL, 'Read', 22,1);
INSERT INTO dbo.Customer (FirstName, MiddleName, LastName, Age, IsActive) values ('Melissa', NULL, 'Sherlock', 31,1);
INSERT INTO dbo.Customer (FirstName, MiddleName, LastName, Age, IsActive) values ('Kori', NULL, 'Higgins', 57,1);

INSERT into dbo.Items ([Description],Price, IsActive) values ('Duracell Alkaline AA Batteries', 15.99,1);
Insert into dbo.items ([Description],Price, IsActive) values ('Kirkland Signature Moist Flushable Wipes', 14.99,1);
Insert into dbo.items ([Description],Price, IsActive) values ('Carnation Breakfast Essentials', 12.59,1);
Insert into dbo.items ([Description],Price, IsActive) values ('Capri Sun  Varienty Pack', 7.99,1);
Insert into dbo.items ([Description],Price, IsActive) values ('Motts Clamato Juice', 11.79,1);
Insert into dbo.items ([Description],Price, IsActive) values ('Dr. Pepper', 9.99,1);
Insert into dbo.items ([Description],Price, IsActive) values ('Mountain Dew', 9.99,1);
Insert into dbo.items ([Description],Price, IsActive) values ('Pepsi Cola', 9.99,1);
Insert into dbo.items ([Description],Price, IsActive) values ('Sprite', 10.99,1);
Insert into dbo.items ([Description],Price, IsActive) values ('San Pellegrino Mineral Water', 17.99,1);

Insert into dbo.CustomerOrder (CustomerId, ItemId) values (1,1);
Insert into dbo.CustomerOrder (CustomerId, ItemId) values (1,2);
Insert into dbo.CustomerOrder (CustomerId, ItemId) values (1,3);
Insert into dbo.CustomerOrder (CustomerId, ItemId) values (1,4);
Insert into dbo.CustomerOrder (CustomerId, ItemId) values (1,5);
Insert into dbo.CustomerOrder (CustomerId, ItemId) values (1,6);
Insert into dbo.CustomerOrder (CustomerId, ItemId) values (2,1);
Insert into dbo.CustomerOrder (CustomerId, ItemId) values (2,2);
Insert into dbo.CustomerOrder (CustomerId, ItemId) values (2,3);
Insert into dbo.CustomerOrder (CustomerId, ItemId) values (3,1);
Insert into dbo.CustomerOrder (CustomerId, ItemId) values (4,1);
Insert into dbo.CustomerOrder (CustomerId, ItemId) values (4,2);
Insert into dbo.CustomerOrder (CustomerId, ItemId) values (5,1);
Insert into dbo.CustomerOrder (CustomerId, ItemId) values (6,1);
Insert into dbo.CustomerOrder (CustomerId, ItemId) values (6,2);
Insert into dbo.CustomerOrder (CustomerId, ItemId) values (7,1);
Insert into dbo.CustomerOrder (CustomerId, ItemId) values (7,2);
Insert into dbo.CustomerOrder (CustomerId, ItemId) values (8,1);
Insert into dbo.CustomerOrder (CustomerId, ItemId) values (8,2);
Insert into dbo.CustomerOrder (CustomerId, ItemId) values (9,1);
Insert into dbo.CustomerOrder (CustomerId, ItemId) values (9,2);
Insert into dbo.CustomerOrder (CustomerId, ItemId) values (9,3);
Insert into dbo.CustomerOrder (CustomerId, ItemId) values (9,4);
Insert into dbo.CustomerOrder (CustomerId, ItemId) values (9,5);
Insert into dbo.CustomerOrder (CustomerId, ItemId) values (9,6);
Insert into dbo.CustomerOrder (CustomerId, ItemId) values (9,7);
Insert into dbo.CustomerOrder (CustomerId, ItemId) values (9,8);

Drop table dbo.CustomerOrder;
drop table dbo.Customer;
drop table dbo.Items