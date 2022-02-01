create database CityBusManagementDB
create table RoutDetailsTable
(
 RouteNo int primary key,
 StopNum int,
 Fare int,
 BegnStop varchar(50),
 EndStop varchar(50),
 StartTime time,
 EndTime time
 )
 create table BusDetailsTable
 (
 BusName varchar(50),
 BusNum int,
 RouteNo int FOREIGN KEY REFERENCES RoutDetailsTable(RouteNo),
 DestArrivalTime time
 )

 create table EmployeeTable
 (
 EmployeeID int primary key,
 EmployeeName varchar(50),
 EmployeeDesig varchar(50)
 )

 select * from RoutDetailsTable
 select * from BusDetailsTable
 select * from EmployeeTable

