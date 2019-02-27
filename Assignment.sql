Create Database AssignmentM

Create Table Event(
EventID int not null,
Subject nvarchar(100),
Description nvarchar(300),
Startdate datetime,
Enddate datetime,
Themecolor nvarchar(10),
Isfullday bit,
Constraint PK_Event
Primary KEY(EventID)
)
SELECT*FROM Event
SELECT*FROM [dbo].[AudioFiles]
SELECT*FROM AudioFiles

INSERT Event
VALUES (1,'Kpop Festival', 'It will celebrate at Shwe Htoot Tin' ,'2019-3-17','2019-3-17','yellow',0)
INSERT Event
VALUES (3,'EDM', 'It will celebrate at People Park' ,'07-16-2019','07-16-2019','green','False')
INSERT Event
VALUES (2,'Mario Fan Meeing', 'Location:Dagon Center' ,'02-04-2019','02-04-2019','blue','False')
INSERT Event
VALUES (4,'Mario Fan Meeing', 'Location:Sedona Hotel' ,'02-15-2019','02-15-2019','red','False')
INSERT Event
VALUES (5,'MonstaX fan Meeting', 'Location:Junction City' ,'03-22-2019','03-22-2019','red','False')
INSERT Event
VALUES (6,'BARONG BASS KINGDOM Festival', 'Location:Dagon Center' ,'04-07-2019','04-07-2019','yellow','False')
INSERT Event
VALUES (7,'SPY presents Thingyan Music Festival', 'Location:Shwe Htoot Tin' ,'04-13-2019','04-13-2019','blue','False')
INSERT Event
VALUES (8,'BARONG BASS KINGDOM Festival', 'Location:Shwe Htoot Tin' ,'04-07-2019','04-07-2019','blue','False')
INSERT Event
VALUES (9,'Sai Sai Show', 'Location:People Park' ,'02-19-2019','02-19-2019','yellow','False')
SELECT * FROM Event


DELETE FROM Event WHERE EventID=9


Create Table Collect(
FullName varchar(50) primary key not null,
Email varchar(60) not null,
Feedback varchar(500)not null
)
SELECT*FROM Collect


Insert dbo.AspNetRoles values('1','Admin')
Insert dbo.AspNetUserRoles values('ede2373b-7dab-4531-83a3-3c738f210eef', '1')
select * from  AspNetUsers





	    CREATE TABLE [dbo].[AudioFiles](  
        [ID] [int] IDENTITY(1,1) NOT NULL,  
        [Name] [nvarchar](50) NULL,  
        [FileSize] [int] NULL,  
        [FilePath] [nvarchar](100) NULL,  
     CONSTRAINT [PK_AudioFiles] PRIMARY KEY CLUSTERED   
    (  
        [ID] ASC  
    )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]  
    ) ON [PRIMARY]  
      
    GO  
      
    CREATE procedure [dbo].[spAddNewAudioFile]  
    (  
    @Name nvarchar(50),  
    @FileSize int,  
    @FilePath nvarchar(100)  
    )  
    as  
    begin  
    insert into AudioFiles (Name,FileSize,FilePath)   
    values (@Name,@FileSize,@FilePath)   
    end  
      
    CREATE procedure [dbo].[spGetAllAudioFile]  
    as  
    begin  
    select ID,Name,FileSize,FilePath from AudioFiles  
    end  
	--INSERT into [dbo].[AudioFiles]
	--VALUES(1,'Akari','2MB','D:/newfolder');