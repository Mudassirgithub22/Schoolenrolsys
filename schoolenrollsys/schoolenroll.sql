create database schoolenroll;
use schoolenroll;

create  table student_info(
id int not null primary key identity (1,1),
name nvarchar(25),
class nvarchar(50),
fathername nvarchar(30),
gender  nvarchar(10),
fcnic  nvarchar(50),
years int,
scholname nvarchar(30),
dob date,
fphone nvarchar(50),
addres nvarchar(200),
district nvarchar(30),
picpath nvarchar(400)
)
drop table student_info 

  select * from student_info;


insert into  student_info
values('mudassir', '10', 'tahir','male', '3660378', '2013','dps','11-11-2000' ,'0333693722','22wb','vehari')

