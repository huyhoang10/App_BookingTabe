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

-- INSERT VALUES
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

insert into Customer
(nameCustomer,numPhone)
values
(N'Ngô Huy Hoàng', '0123456789'),
(N'Thanh Khang', '0125395738');

insert into BOOKING
(idCustomer,idTable,dateBooking,numGuest)
values
(1,2,'20240818',2),
(2,5,'20240820',4);
--END INSERT


--SELECT TABLE
select * from statusTable as stbl
select * from isTable as tbl
select * from Customer as ctm
select * from BOOKING as bk

/*
select tbl.idTable[số bàn],tbl.maxguest[Số khách tối đa], tbl.statusTbl[Trạng thái] from BOOKING as bk, isTable as tbl--, statusTable as stbl
where dateBooking = '20240820' and statusTbl = 0
*/

select * from BOOKING as bk, isTable as tbl
where bk.dateBooking = '20240818' and bk.idTable = tbl.idTable

select bk.idBooking ,bk.dateBooking, ctm.nameCustomer, bk.idTable, bk.numGuest from BOOKING as bk
inner join Customer as ctm
on bk.idCustomer = ctm.idCustomer
where dateBooking >= GETDATE()
order by dateBooking



--END SELECT

--update isTable set statusTbl = 1 where isTable.idTable = 2