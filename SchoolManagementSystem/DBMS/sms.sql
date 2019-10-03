CREATE DATABASE sms
use sms


/* ROLE START */
create table roles(

RoleID int primary key identity(1,1),
RoleName varchar(100) unique,
RoleStatus varchar(100)
)

create proc SP_ROLES_INSERT (
@RoleName varchar(100),
@RoleStatus varchar(100)

)
as begin 
insert into roles (RoleName,RoleStatus) values(@RoleName,@RoleStatus)
end

create proc SP_ROLES_UPDATE(
@RoleID int,
@RoleName varchar(100),
@RoleStatus varchar(100)
)
as begin 
update roles set RoleName=@RoleName,RoleStatus=@RoleStatus where RoleID=@RoleID
end

create proc SP_ROLES_DELETE(
@RoleID int
)
as begin 
Delete from roles where RoleID=@RoleID
end

create proc SP_ROLES_VIEW
as begin 
select RoleID as 'ID',RoleName as 'NAME', RoleStatus as 'STATUS' from roles
end

create proc SP_ROLES_VIEW_LIKE(
@DataItem varchar(100)

)
as begin 
select RoleID as 'ID',RoleName as 'NAME', RoleStatus as 'STATUS' from roles where RoleName like '%'+@DataItem+'%' or RoleStatus like '%'+@DataItem+'%' 
end
/* END OF ROLES */

/* LEVEL START */

create table SchoolLevel(

LevelID int primary key identity(1,1),
LevelName varchar(100) unique

)

create proc SP_LEVEL_INSERT(
@LevelName varchar(100)
)
as begin 
Insert into SchoolLevel (LevelName) values(@LevelName)
end


Create Proc SP_LEVEL_UPDATE(
@LevelID  int,
@LevelName varchar(100)
)
as begin 
update SchoolLevel  set LevelName=@LevelName where LevelID=@LevelID
end

create proc SP_LEVEL_DELETE(

@LevelID  int
)
as begin
Delete from SchoolLevel where LevelID=@LevelID
end

create proc SP_LEVEL_VIEW
as begin 
select LevelID as 'ID',LevelName as 'LEVEL' from SchoolLevel
end


create proc SP_LEVEL_VIEW_LIKE(
@DataItem varchar(100)
)
as begin 
select LevelID as 'ID',LevelName as 'LEVEL' from SchoolLevel where LevelName like '%'+@DataItem+'%'
end

/* END OF LEVEL */


/* START SECTION */
create table Section(
SectionID int primary key identity(1,1),
SectionName varchar(100) unique,
SectionStatus varchar(100)

)

create proc SP_SECTION_INSERT(

@SectionName varchar(100),
@SectionStatus varchar(100)

)
as begin
insert into Section (SectionName,SectionStatus) values(@SectionName ,@SectionStatus)
end


create proc SP_SECTION_UPDATE(
@SectionID int,
@SectionName varchar(100),
@SectionStatus varchar(100)
)
as begin
update Section set SectionName=@SectionName,SectionStatus=@SectionStatus where SectionID =@SectionID
end

create proc SP_SECTION_DELETE(
@SectionID int
)
as begin
delete from Section where SectionID=@SectionID
end

create proc SP_SECTION_VIEW
as begin
select 
SectionID as 'ID',
SectionName as 'NAME',
SectionStatus as 'STATUS' from Section
end

create proc SP_SECTION_VIEW_LIKE(
@DataItem varchar(100))
as begin
select 
SectionID as 'ID',
SectionName as 'NAME',
SectionStatus as 'STATUS' from Section where SectionName like '%'+@DataItem+'%' or SectionStatus like '%'+@DataItem+'%'
end

/* END OF SECTION */

/* START CLASS */
create table class(
ClassID int primary key identity(1,1),
ClassName varchar(100),
ClassLevel varchar(100),
ClassStatus varchar(100)

)

create proc SP_CLASS_INSERT(

@ClassName varchar(100),
@ClassLevel varchar(100),
@ClassStatus varchar(100)
)
as begin 
if(@ClassName not in (select ClassName from class))
begin
insert into class (ClassName ,ClassLevel ,ClassStatus) values(@ClassName,@ClassLevel ,@ClassStatus) 
end
end

execute SP_CLASS_INSERT 'CLASS ONE', 'PRIMARY', 'ACTIVE'

create proc SP_CLASS_UPDATE(
@ClassID int,
@ClassName varchar(100),
@ClassLevel varchar(100),
@ClassStatus varchar(100)
)
as begin 

update class set ClassName=@ClassName ,ClassLevel=@ClassLevel  ,ClassStatus=@ClassStatus where ClassID=@ClassID

end

create proc SP_CLASS_DELETE(
@ClassID int
)
as begin 

delete from class  where ClassID=@ClassID

end

create proc SP_CLASS_VIEW
as begin
select 
ClassID as 'ID',
ClassName as 'NAME',
ClassLevel as 'LEVEL',
ClassStatus as 'STATUS'
from class
end


create proc SP_CLASS_VIEW_LIKE(
@DataItem varchar(100)
)
as begin
select 
ClassID as 'ID',
ClassName as 'NAME',
ClassLevel as 'LEVEL',
ClassStatus as 'STATUS'
from class where ClassName like '%'+@DataItem+'%' or ClassLevel like '%'+@DataItem+'%' or ClassStatus like '%'+@DataItem+'%' 
end
/* END OF CLASS*/


/* START HOUSE/GROUP */
create table House(
HouseID int primary key identity(1,1),
HouseName varchar(100) unique,
HouseStatus varchar(100)

)

create proc SP_HOUSE_INSERT(

@HouseName varchar(100),
@HouseStatus varchar(100)

)
as begin
insert into House(HouseName,HouseStatus) values(@HouseName ,@HouseStatus)
end


create proc SP_HOUSE_UPDATE(
@HouseID int,
@HouseName varchar(100),
@HouseStatus varchar(100)
)
as begin
update House set HouseName=@HouseName,HouseStatus=@HouseStatus where HouseID =@HouseID
end

create proc SP_HOUSE_DELETE(
@HouseID int
)
as begin
delete from House where HouseID=@HouseID
end

create proc SP_HOUSE_VIEW
as begin
select 
HouseID as 'ID',
HouseName as 'NAME',
HouseStatus as 'STATUS' from House
end

create proc SP_HOUSE_VIEW_LIKE(
@DataItem varchar(100))
as begin
select 
HouseID as 'ID',
HouseName as 'NAME',
HouseStatus as 'STATUS' from House where HouseName like '%'+@DataItem+'%' or HouseStatus like '%'+@DataItem+'%'
end
/*END HOUSE/GROUP*/





/* START PERIOD */
create table SchoolPeriod(
PeriodID int primary key identity(1,1),
PeriodName varchar(100) unique,
PeriodStatus varchar(100)

)

create proc SP_PERIOD_INSERT(

@PeriodName varchar(100),
@PeriodStatus varchar(100)

)
as begin
insert into SchoolPeriod(PeriodName,PeriodStatus) values(@PeriodName ,@PeriodStatus)
end


create proc SP_PERIOD_UPDATE(
@PeriodID int,
@PeriodName varchar(100),
@PeriodStatus varchar(100)
)
as begin
update SchoolPeriod set PeriodName=@PeriodName,PeriodStatus=@PeriodStatus where PeriodID =@PeriodID
end

create proc SP_PERIOD_DELETE(
@PeriodID int
)
as begin
delete from SchoolPeriod where PeriodID=@PeriodID
end

create proc SP_PERIOD_VIEW
as begin
select 
PeriodID as 'ID',
PeriodName as 'NAME',
PeriodStatus as 'STATUS' from SchoolPeriod 
end

create proc SP_PERIOD_VIEW_LIKE(
@DataItem varchar(100))
as begin
select 
PeriodID as 'ID',
PeriodName as 'NAME',
PeriodStatus as 'STATUS' from SchoolPeriod where PeriodName like '%'+@DataItem+'%' or PeriodStatus like '%'+@DataItem+'%'
end
/*END OF PERIOD*/





/* SUBJECTS START */

create table Subjects(

SubjectID int primary key identity(1,1),
SubjectName varchar(100) unique

)

create proc SP_SUBJECT_INSERT(
@SubjectName varchar(100)
)
as begin 
Insert into Subjects (SubjectName) values(@SubjectName)
end


Create Proc SP_SUBJECT_UPDATE(
@SubjectID  int,
@SubjectName varchar(100)
)
as begin 
update Subjects  set SubjectName=@SubjectName where SubjectID=@SubjectID
end

create proc SP_SUBJECT_DELETE(

@SubjectID  int
)
as begin
Delete from Subjects where SubjectID=@SubjectID
end

create proc SP_SUBJECT_VIEW
as begin 
select SubjectID as 'ID',SubjectName as 'SUBJECT' from Subjects
end


create proc SP_SUBJECT_VIEW_LIKE(
@DataItem varchar(100)
)
as begin 
select SubjectID as 'ID',SubjectName as 'SUBJECT' from Subjects where SubjectName like '%'+@DataItem+'%'
end

execute SP_SUBJECT_VIEW
/* END OF SUBJECTS */

