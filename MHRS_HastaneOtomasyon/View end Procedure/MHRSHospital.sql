USE [master]
GO
/****** Object:  Database [MHRSHospital]    Script Date: 10/08/2016 15:33:49 ******/
CREATE DATABASE [MHRSHospital] ON  PRIMARY 
( NAME = N'MHRSHospital', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\MHRSHospital.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MHRSHospital_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\MHRSHospital_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MHRSHospital] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MHRSHospital].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MHRSHospital] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [MHRSHospital] SET ANSI_NULLS OFF
GO
ALTER DATABASE [MHRSHospital] SET ANSI_PADDING OFF
GO
ALTER DATABASE [MHRSHospital] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [MHRSHospital] SET ARITHABORT OFF
GO
ALTER DATABASE [MHRSHospital] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [MHRSHospital] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [MHRSHospital] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [MHRSHospital] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [MHRSHospital] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [MHRSHospital] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [MHRSHospital] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [MHRSHospital] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [MHRSHospital] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [MHRSHospital] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [MHRSHospital] SET  DISABLE_BROKER
GO
ALTER DATABASE [MHRSHospital] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [MHRSHospital] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [MHRSHospital] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [MHRSHospital] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [MHRSHospital] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [MHRSHospital] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [MHRSHospital] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [MHRSHospital] SET  READ_WRITE
GO
ALTER DATABASE [MHRSHospital] SET RECOVERY SIMPLE
GO
ALTER DATABASE [MHRSHospital] SET  MULTI_USER
GO
ALTER DATABASE [MHRSHospital] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [MHRSHospital] SET DB_CHAINING OFF
GO
USE [MHRSHospital]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 10/08/2016 15:33:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Patient](
	[PatientID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[IdentitiyNumber] [bigint] NOT NULL,
	[Gender] [nvarchar](5) NOT NULL,
	[DateOfBirth] [datetime] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[CellPhone] [bigint] NOT NULL,
	[HomePhone] [bigint] NOT NULL,
	[SecurityQuestion] [nvarchar](50) NOT NULL,
	[Answer] [nvarchar](50) NOT NULL,
	[PlaceOfBirth] [nvarchar](50) NULL,
	[MotherName] [nvarchar](50) NULL,
	[FatherName] [nvarchar](50) NULL,
	[Deleted] [bit] NOT NULL,
	[Picture] [varchar](50) NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[PatientID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Patient] ON
INSERT [dbo].[Patient] ([PatientID], [FirstName], [LastName], [IdentitiyNumber], [Gender], [DateOfBirth], [Email], [Password], [CellPhone], [HomePhone], [SecurityQuestion], [Answer], [PlaceOfBirth], [MotherName], [FatherName], [Deleted], [Picture]) VALUES (1, N'Turgay', N'Kaya', 12345678910, N'Erkek', CAST(0x00002F5D00000000 AS DateTime), N'yiwit.tas@gmail.com', N'123456', 53737125869, 2164875412, N'Köpeğin İsmi', N'AT', N'Istanbul', N'Ayşe', N'Mahmut', 0, NULL)
INSERT [dbo].[Patient] ([PatientID], [FirstName], [LastName], [IdentitiyNumber], [Gender], [DateOfBirth], [Email], [Password], [CellPhone], [HomePhone], [SecurityQuestion], [Answer], [PlaceOfBirth], [MotherName], [FatherName], [Deleted], [Picture]) VALUES (4, N'Ozan', N'Kuş', 12345678510, N'Kadın', CAST(0x0000809400000000 AS DateTime), N'aop@gmail.com', N'564787', 54542135548, 124548783, N'Atın ismi', N'köpek', N'Izmır', N'Mahmut', N'Ayşe', 1, NULL)
INSERT [dbo].[Patient] ([PatientID], [FirstName], [LastName], [IdentitiyNumber], [Gender], [DateOfBirth], [Email], [Password], [CellPhone], [HomePhone], [SecurityQuestion], [Answer], [PlaceOfBirth], [MotherName], [FatherName], [Deleted], [Picture]) VALUES (6, N'Ferhat', N'Yılmaz', 560982213874, N'Male', CAST(0x000083A000000000 AS DateTime), N'ferht@gmail.com', N'1', 4567976547, 7359093645, N'En sevdiğin Pokomon', N'Balbazaar', N'Konya', N' ', N' ', 0, N' ')
INSERT [dbo].[Patient] ([PatientID], [FirstName], [LastName], [IdentitiyNumber], [Gender], [DateOfBirth], [Email], [Password], [CellPhone], [HomePhone], [SecurityQuestion], [Answer], [PlaceOfBirth], [MotherName], [FatherName], [Deleted], [Picture]) VALUES (7, N'Ferhat', N'Yılmaz', 560982213874, N'Male', CAST(0x000083A000000000 AS DateTime), N'ferht@gmail.com', N's', 4567976547, 7359093645, N'En sevdiğin Pokomon', N'Balbazaar', N'Konya', N' ', N' ', 0, N' ')
INSERT [dbo].[Patient] ([PatientID], [FirstName], [LastName], [IdentitiyNumber], [Gender], [DateOfBirth], [Email], [Password], [CellPhone], [HomePhone], [SecurityQuestion], [Answer], [PlaceOfBirth], [MotherName], [FatherName], [Deleted], [Picture]) VALUES (8, N'Ferhat', N'Yılmaz', 560982213874, N'Male', CAST(0x000083A000000000 AS DateTime), N'ferht@gmail.com', N'1234566', 4567976547, 7359093645, N'En sevdiğin Pokomon', N'Balbazaar', N'Konya', N' ', N' ', 0, N' ')
SET IDENTITY_INSERT [dbo].[Patient] OFF
/****** Object:  Table [dbo].[Clinic]    Script Date: 10/08/2016 15:33:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clinic](
	[ClinicID] [int] IDENTITY(1,1) NOT NULL,
	[ClinicBranch] [nvarchar](50) NOT NULL,
	[TimeRange] [int] NOT NULL,
	[StartTime] [datetime] NOT NULL,
	[EndTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Clinic] PRIMARY KEY CLUSTERED 
(
	[ClinicID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clinic] ON
INSERT [dbo].[Clinic] ([ClinicID], [ClinicBranch], [TimeRange], [StartTime], [EndTime]) VALUES (1, N'Iç Hastalıkları', 10, CAST(0x0000A6980083D600 AS DateTime), CAST(0x0000A698010FE960 AS DateTime))
INSERT [dbo].[Clinic] ([ClinicID], [ClinicBranch], [TimeRange], [StartTime], [EndTime]) VALUES (2, N'KBB', 15, CAST(0x0000A6980083D600 AS DateTime), CAST(0x0000A698010FE960 AS DateTime))
INSERT [dbo].[Clinic] ([ClinicID], [ClinicBranch], [TimeRange], [StartTime], [EndTime]) VALUES (3, N'Yoğun Bakım', 10, CAST(0x0000A6980083D600 AS DateTime), CAST(0x0000A698010FE960 AS DateTime))
INSERT [dbo].[Clinic] ([ClinicID], [ClinicBranch], [TimeRange], [StartTime], [EndTime]) VALUES (4, N'Çocuk Hastalıkları', 10, CAST(0x0000A6980083D600 AS DateTime), CAST(0x0000A698010FE960 AS DateTime))
SET IDENTITY_INSERT [dbo].[Clinic] OFF
/****** Object:  Table [dbo].[City]    Script Date: 10/08/2016 15:33:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[CityID] [int] IDENTITY(1,1) NOT NULL,
	[CityName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[City] ON
INSERT [dbo].[City] ([CityID], [CityName]) VALUES (1, N'Istanbul')
INSERT [dbo].[City] ([CityID], [CityName]) VALUES (2, N's')
INSERT [dbo].[City] ([CityID], [CityName]) VALUES (3, N'Ankara')
SET IDENTITY_INSERT [dbo].[City] OFF
/****** Object:  Table [dbo].[Tittle]    Script Date: 10/08/2016 15:33:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tittle](
	[TittleID] [int] IDENTITY(1,1) NOT NULL,
	[TittleName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tittle] PRIMARY KEY CLUSTERED 
(
	[TittleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Tittle] ON
INSERT [dbo].[Tittle] ([TittleID], [TittleName]) VALUES (1, N'Uzman Doktor')
INSERT [dbo].[Tittle] ([TittleID], [TittleName]) VALUES (2, N'Profösör')
INSERT [dbo].[Tittle] ([TittleID], [TittleName]) VALUES (3, N'Doçent')
INSERT [dbo].[Tittle] ([TittleID], [TittleName]) VALUES (4, N'Doçent Yardımcısı')
INSERT [dbo].[Tittle] ([TittleID], [TittleName]) VALUES (5, N'Pratisyen')
SET IDENTITY_INSERT [dbo].[Tittle] OFF
/****** Object:  Table [dbo].[PatientLogin]    Script Date: 10/08/2016 15:33:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientLogin](
	[UserID] [int] NOT NULL,
	[IdentitiyNumber] [bigint] NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PatientLogin] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[PatientLogin] ([UserID], [IdentitiyNumber], [Password]) VALUES (1, 12345678910, N'123456')
INSERT [dbo].[PatientLogin] ([UserID], [IdentitiyNumber], [Password]) VALUES (4, 12345678510, N'564787')
/****** Object:  View [dbo].[vW_GetPatient]    Script Date: 10/08/2016 15:33:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vW_GetPatient]
AS
Select PatientID,FirstName+' '+LastName [FullName], IdentitiyNumber,Gender,DateOfBirth,Email,Password,CellPhone,HomePhone,SecurityQuestion,Answer,PlaceOfBirth,MotherName,FatherName From Patient Where Deleted=0
WITH CHECK OPTION
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 10/08/2016 15:33:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[DoctorID] [int] IDENTITY(1,1) NOT NULL,
	[DoctorFirstName] [nvarchar](50) NOT NULL,
	[DoctorLastName] [nvarchar](50) NOT NULL,
	[TittleID] [int] NOT NULL,
	[ClinicID] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Doctor] PRIMARY KEY CLUSTERED 
(
	[DoctorID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Doctor] ON
INSERT [dbo].[Doctor] ([DoctorID], [DoctorFirstName], [DoctorLastName], [TittleID], [ClinicID], [Deleted]) VALUES (2, N'Yiğit', N'Taş', 1, 2, 0)
INSERT [dbo].[Doctor] ([DoctorID], [DoctorFirstName], [DoctorLastName], [TittleID], [ClinicID], [Deleted]) VALUES (3, N'Serkan', N'Soydam', 2, 3, 0)
INSERT [dbo].[Doctor] ([DoctorID], [DoctorFirstName], [DoctorLastName], [TittleID], [ClinicID], [Deleted]) VALUES (4, N'Ayça', N'Calayır', 4, 1, 1)
INSERT [dbo].[Doctor] ([DoctorID], [DoctorFirstName], [DoctorLastName], [TittleID], [ClinicID], [Deleted]) VALUES (5, N'Muhittin', N'Mu', 1, 2, 0)
SET IDENTITY_INSERT [dbo].[Doctor] OFF
/****** Object:  StoredProcedure [dbo].[sp_AddPatient]    Script Date: 10/08/2016 15:33:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_AddPatient]
@FirtsName nvarchar(50),
@LastName nvarchar(50),
@IdentityNumber bigint,
@Gender nvarchar(5),
@DateOfBirth datetime,
@Email nvarchar(50),
@Password nvarchar(50),
@CellPhone bigint,
@HomePhone bigint,
@SecurityQuestion nvarchar(50),
@Answer nvarchar(50),
@PlaceOfBirth nvarchar(50)=' ',
@MotherName nvarchar(50)=' ',
@FatherName nvarchar(50)=' ',
@Picture nvarchar(50)=' ',
@Deleted bit =0
AS
BEGIN
Insert into Patient (FirstName,LastName,IdentitiyNumber,Gender,DateOfBirth,Email,Password,CellPhone,HomePhone,SecurityQuestion,Answer,PlaceOfBirth,MotherName,FatherName,Picture,Deleted) Values(@FirtsName,@LastName,@IdentityNumber,@Gender,@DateOfBirth,@Email,@Password,@CellPhone,@HomePhone,@SecurityQuestion,@Answer,@PlaceOfBirth,@MotherName,@FatherName,@Picture,@Deleted)
END
GO
/****** Object:  Table [dbo].[Town]    Script Date: 10/08/2016 15:33:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Town](
	[TownID] [int] IDENTITY(1,1) NOT NULL,
	[TownName] [nvarchar](50) NOT NULL,
	[CityID] [int] NOT NULL,
 CONSTRAINT [PK_Town] PRIMARY KEY CLUSTERED 
(
	[TownID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Town] ON
INSERT [dbo].[Town] ([TownID], [TownName], [CityID]) VALUES (1, N'Bakırköy', 1)
INSERT [dbo].[Town] ([TownID], [TownName], [CityID]) VALUES (2, N'Kadıköy', 1)
INSERT [dbo].[Town] ([TownID], [TownName], [CityID]) VALUES (3, N'Karşıyaka', 2)
INSERT [dbo].[Town] ([TownID], [TownName], [CityID]) VALUES (4, N'Bornova', 2)
INSERT [dbo].[Town] ([TownID], [TownName], [CityID]) VALUES (5, N'Kızılay', 3)
SET IDENTITY_INSERT [dbo].[Town] OFF
/****** Object:  View [dbo].[vW_GetDeletedPatient]    Script Date: 10/08/2016 15:33:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[vW_GetDeletedPatient]
AS
Select PatientID,FirstName+' '+LastName [FullName], IdentitiyNumber,Gender,DateOfBirth,Email,Password,CellPhone,HomePhone,SecurityQuestion,Answer,PlaceOfBirth,MotherName,FatherName From Patient Where Deleted=1
WITH CHECK OPTION
GO
/****** Object:  StoredProcedure [dbo].[sp_GetPatientID]    Script Date: 10/08/2016 15:33:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[sp_GetPatientID]
@PatientId int
AS
BEGIN
SELECT*FROM [vW_GetPatient] where PatientID=@PatientId
END
GO
/****** Object:  Table [dbo].[Hospital]    Script Date: 10/08/2016 15:33:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hospital](
	[HospitalID] [int] IDENTITY(1,1) NOT NULL,
	[HospitalName] [nvarchar](50) NOT NULL,
	[TownID] [int] NOT NULL,
 CONSTRAINT [PK_Hospital] PRIMARY KEY CLUSTERED 
(
	[HospitalID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Hospital] ON
INSERT [dbo].[Hospital] ([HospitalID], [HospitalName], [TownID]) VALUES (1, N'Doktor Sadi Konuk', 1)
INSERT [dbo].[Hospital] ([HospitalID], [HospitalName], [TownID]) VALUES (2, N'Balta Limanı Araştırma Hastanesi', 1)
INSERT [dbo].[Hospital] ([HospitalID], [HospitalName], [TownID]) VALUES (3, N'Numune Hastanesi', 2)
INSERT [dbo].[Hospital] ([HospitalID], [HospitalName], [TownID]) VALUES (4, N'Acıbadem Medipol Hastanesi', 2)
SET IDENTITY_INSERT [dbo].[Hospital] OFF
/****** Object:  Table [dbo].[Appointment]    Script Date: 10/08/2016 15:33:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment](
	[AppointmentID] [int] IDENTITY(1,1) NOT NULL,
	[PatientID] [int] NOT NULL,
	[DoctorID] [int] NOT NULL,
	[AppointmentDate] [datetime] NOT NULL,
	[AppointmentTime] [datetime] NOT NULL,
	[AppointmentStatus] [bit] NOT NULL,
 CONSTRAINT [PK_Appointment] PRIMARY KEY CLUSTERED 
(
	[AppointmentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Appointment] ON
INSERT [dbo].[Appointment] ([AppointmentID], [PatientID], [DoctorID], [AppointmentDate], [AppointmentTime], [AppointmentStatus]) VALUES (5, 1, 2, CAST(0x0000A69800000000 AS DateTime), CAST(0x0000A698011826C0 AS DateTime), 0)
INSERT [dbo].[Appointment] ([AppointmentID], [PatientID], [DoctorID], [AppointmentDate], [AppointmentTime], [AppointmentStatus]) VALUES (7, 4, 3, CAST(0x0000A69C00000000 AS DateTime), CAST(0x0000A69800F73140 AS DateTime), 0)
INSERT [dbo].[Appointment] ([AppointmentID], [PatientID], [DoctorID], [AppointmentDate], [AppointmentTime], [AppointmentStatus]) VALUES (8, 6, 2, CAST(0x0000A69C00000000 AS DateTime), CAST(0x0000A69C00D63BC0 AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Appointment] OFF
/****** Object:  Table [dbo].[HospitalClinic]    Script Date: 10/08/2016 15:33:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HospitalClinic](
	[HospitalID] [int] NOT NULL,
	[ClinicID] [int] NOT NULL,
 CONSTRAINT [PK_HospitalClinic] PRIMARY KEY CLUSTERED 
(
	[HospitalID] ASC,
	[ClinicID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[HospitalClinic] ([HospitalID], [ClinicID]) VALUES (1, 1)
INSERT [dbo].[HospitalClinic] ([HospitalID], [ClinicID]) VALUES (1, 2)
INSERT [dbo].[HospitalClinic] ([HospitalID], [ClinicID]) VALUES (1, 4)
INSERT [dbo].[HospitalClinic] ([HospitalID], [ClinicID]) VALUES (2, 1)
INSERT [dbo].[HospitalClinic] ([HospitalID], [ClinicID]) VALUES (3, 2)
INSERT [dbo].[HospitalClinic] ([HospitalID], [ClinicID]) VALUES (3, 4)
INSERT [dbo].[HospitalClinic] ([HospitalID], [ClinicID]) VALUES (4, 1)
INSERT [dbo].[HospitalClinic] ([HospitalID], [ClinicID]) VALUES (4, 3)
/****** Object:  StoredProcedure [dbo].[sp_AddAppointment]    Script Date: 10/08/2016 15:33:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[sp_AddAppointment]
(
@PatientId int,
@DoctorId int,
@AppointmentDate datetime,
@AppointmentTime datetime,
@AppointmentStatus bit=1
)
AS
BEGIN
insert into Appointment (PatientID,DoctorID,AppointmentDate,AppointmentTime,AppointmentStatus) values(@PatientId,@DoctorId,@AppointmentDate,@AppointmentTime,1)
END
GO
/****** Object:  View [dbo].[vW_GetAppointment]    Script Date: 10/08/2016 15:33:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[vW_GetAppointment]
AS
select AppointmentID,pati.PatientID,pati.FirstName + ' ' + pati.LastName [PatientFullName],doc.DoctorID,DoctorFirstName+ ' '+doc.DoctorLastName [DoctorFullName] ,AppointmentDate,AppointmentTime from Appointment apo
inner join Patient pati on pati.PatientID=apo.PatientID
inner join Doctor doc on doc.DoctorID=apo.DoctorID
    where AppointmentStatus=0
WITH CHECK OPTION
GO
/****** Object:  View [dbo].[vW_GetHospitalDetails]    Script Date: 10/08/2016 15:33:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[vW_GetHospitalDetails]
AS
SELECT  c.CityID [CityID],c.CityName [CityName],t.TownID [TownID],t.TownName [TownName],h.HospitalID [HospitalID],h.HospitalName [HospitalName],cli.ClinicBranch [ClinicBranch],cli.ClinicID [ClinicID],cli.EndTime [ClinicEndTime],cli.StartTime [ClinicStartTime],cli.TimeRange [ClinicTimeRange],doc.Deleted [DoctorDeleted],doc.DoctorFirstName [DoctorFirstName], doc.DoctorLastName [DoctorLastName],doc.DoctorID [DoctorID],tit.TittleID [TittleID],tit.TittleName [TittleName] from City c
join Town t ON t.CityID = c.CityID
join Hospital h on h.TownID = t.TownID
join HospitalClinic hc on hc.HospitalID = h.HospitalID
join Clinic cli on cli.ClinicID = hc.ClinicID
join Doctor doc on doc.ClinicID = cli.ClinicID
join Tittle tit on tit.TittleID = doc.TittleID
with check option
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAppointmentID]    Script Date: 10/08/2016 15:33:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[sp_GetAppointmentID]
@AppointmentID int
AS
BEGIN
SELECT *FROM vW_GetAppointment where AppointmentID=@AppointmentID
END
GO
/****** Object:  ForeignKey [FK_PatientLogin_Patient]    Script Date: 10/08/2016 15:33:51 ******/
ALTER TABLE [dbo].[PatientLogin]  WITH CHECK ADD  CONSTRAINT [FK_PatientLogin_Patient] FOREIGN KEY([UserID])
REFERENCES [dbo].[Patient] ([PatientID])
GO
ALTER TABLE [dbo].[PatientLogin] CHECK CONSTRAINT [FK_PatientLogin_Patient]
GO
/****** Object:  ForeignKey [FK_Doctor_Clinic]    Script Date: 10/08/2016 15:33:52 ******/
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Clinic] FOREIGN KEY([ClinicID])
REFERENCES [dbo].[Clinic] ([ClinicID])
GO
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [FK_Doctor_Clinic]
GO
/****** Object:  ForeignKey [FK_Doctor_Tittle]    Script Date: 10/08/2016 15:33:52 ******/
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Tittle] FOREIGN KEY([TittleID])
REFERENCES [dbo].[Tittle] ([TittleID])
GO
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [FK_Doctor_Tittle]
GO
/****** Object:  ForeignKey [FK_Town_City]    Script Date: 10/08/2016 15:33:55 ******/
ALTER TABLE [dbo].[Town]  WITH CHECK ADD  CONSTRAINT [FK_Town_City] FOREIGN KEY([CityID])
REFERENCES [dbo].[City] ([CityID])
GO
ALTER TABLE [dbo].[Town] CHECK CONSTRAINT [FK_Town_City]
GO
/****** Object:  ForeignKey [FK_Hospital_Town]    Script Date: 10/08/2016 15:33:55 ******/
ALTER TABLE [dbo].[Hospital]  WITH CHECK ADD  CONSTRAINT [FK_Hospital_Town] FOREIGN KEY([TownID])
REFERENCES [dbo].[Town] ([TownID])
GO
ALTER TABLE [dbo].[Hospital] CHECK CONSTRAINT [FK_Hospital_Town]
GO
/****** Object:  ForeignKey [FK_Appointment_Doctor]    Script Date: 10/08/2016 15:33:55 ******/
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Doctor] FOREIGN KEY([DoctorID])
REFERENCES [dbo].[Doctor] ([DoctorID])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Doctor]
GO
/****** Object:  ForeignKey [FK_Appointment_Patient]    Script Date: 10/08/2016 15:33:55 ******/
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Patient] FOREIGN KEY([PatientID])
REFERENCES [dbo].[Patient] ([PatientID])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Patient]
GO
/****** Object:  ForeignKey [FK_HospitalClinic_Clinic]    Script Date: 10/08/2016 15:33:55 ******/
ALTER TABLE [dbo].[HospitalClinic]  WITH CHECK ADD  CONSTRAINT [FK_HospitalClinic_Clinic] FOREIGN KEY([ClinicID])
REFERENCES [dbo].[Clinic] ([ClinicID])
GO
ALTER TABLE [dbo].[HospitalClinic] CHECK CONSTRAINT [FK_HospitalClinic_Clinic]
GO
/****** Object:  ForeignKey [FK_HospitalClinic_Hospital]    Script Date: 10/08/2016 15:33:55 ******/
ALTER TABLE [dbo].[HospitalClinic]  WITH CHECK ADD  CONSTRAINT [FK_HospitalClinic_Hospital] FOREIGN KEY([HospitalID])
REFERENCES [dbo].[Hospital] ([HospitalID])
GO
ALTER TABLE [dbo].[HospitalClinic] CHECK CONSTRAINT [FK_HospitalClinic_Hospital]
GO
