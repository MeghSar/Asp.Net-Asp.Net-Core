use TimeSheetManagementDB

select * from Employee
insert into Employee values(2001,'Ankitha','Admin','ankitha@gmail.com','9876543210','anky','red','12-01-2014',0,0)
insert into Employee values(2002,'Rekha','Manager','rekha@gmail.com','9876543211','rekha','green','13-02-2015',2001,0)
insert into Employee values(2003,'Sravani','Manager','sravani@gmail.com','9876543212','sravy','pink','15-01-2016',2001,0)
insert into Employee values(2004,'Meghna','Analyst','meghna@gmail.com','9876543213','megh','blue','20-03-2018',2002,101)
insert into Employee values(2005,'Tiyas','TestEng','tiyas@gmail.com','9876543214','tiya','purple','20-03-2018',2002,101)
insert into Employee values(2006,'Rashmi','Designer','rashmi@gmail.com','9876543215','rashu','yellow','24-11-2018',2003,102)
insert into Employee values(2007,'Indu','Analyst','indu@gmail.com','9876543216','indu','sky','21-03-2020',2003,103)
insert into Employee values(2008,'Pavan','TestEng','pavan@gmail.com','9876543218','pavy','teal','21-03-2020',2002,0)


select * from Project
insert into Project values(101,'TimeSheetMgmt','Asp.Net core')
insert into Project values(102,'E-Bill Pay','JAVA android app')
insert into Project values(103,'Car Price Prediction','Machine Learning')


select * from Timesheet
insert into timesheet values(11102,101,2004,'09-02-2022','08:00','18:00',9,'Requested')
insert into timesheet values(11103,101,2005,'09-02-2022','08:00','18:00',9,'Requested')
insert into timesheet values(11104,102,2006,'09-02-2022','08:00','18:00',9,'Requested')
insert into timesheet values(11105,103,2007,'09-02-2022','08:00','18:00',9,'Requested')

