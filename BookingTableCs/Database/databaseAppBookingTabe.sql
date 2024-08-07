create database appBookingTable
go

use appbookingtable

-- Create All Table
CREATE TABLE Customer
(
	idCustomer int identity(1,1) PRIMARY KEY,
	nameCustomer nvarchar(50) not null,
	numPhone char(10), 
)

CREATE TABLE statusTable
(
	idStatus int not null PRIMARY KEY,
	nameStatus nvarchar(20) not null,
)

CREATE TABLE isTable
(
	idTable int not null PRIMARY KEY,
	maxguest int not null,
	statusTbl int default 0,
	FOREIGN KEY (statustbl)	REFERENCES dbo.statusTable (idStatus)
)

CREATE TABLE BOOKING
(
	idBooking int not null identity(1,1) PRIMARY KEY,
	idCustomer int not null,
	idTable int not null,
	dateBooking datetime not null,
	numGuest int not null,
	FOREIGN KEY (idCustomer) REFERENCES dbo.Customer (idCustomer),
	FOREIGN KEY (idTable) REFERENCES dbo.isTable (idTable)
)

-- end Creat all Table

-- insert value
insert into statusTable
values 
(0,N'Trống'),
(1,N'Đã đặt'),
(2,N'Đang sử dụng');

insert into isTable
(idTable,maxguest)
values
(1,2), --default statustbl = 0
(2,2),
(3,4),
(4,4),
(5,8),
(6,8);

