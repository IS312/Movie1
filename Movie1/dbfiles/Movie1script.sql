USE [master]
GO
/****** Object:  Database [movie1]    Script Date: 25-11-2020 11.53.05 PM ******/
CREATE DATABASE [movie1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WebSeries', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\WebSeries.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WebSeries_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\WebSeries_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [movie1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [movie1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [movie1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [movie1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [movie1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [movie1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [movie1] SET ARITHABORT OFF 
GO
ALTER DATABASE [movie1] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [movie1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [movie1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [movie1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [movie1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [movie1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [movie1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [movie1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [movie1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [movie1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [movie1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [movie1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [movie1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [movie1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [movie1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [movie1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [movie1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [movie1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [movie1] SET  MULTI_USER 
GO
ALTER DATABASE [movie1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [movie1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [movie1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [movie1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [movie1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [movie1] SET QUERY_STORE = OFF
GO
USE [movie1]
GO
/****** Object:  User [ma]    Script Date: 25-11-2020 11.53.05 PM ******/
CREATE USER [ma] FOR LOGIN [ma] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [ma]
GO
/****** Object:  Table [dbo].[MyMovies]    Script Date: 25-11-2020 11.53.05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MyMovies](
	[MovieID] [int] IDENTITY(1001,1) NOT NULL,
	[Title] [varchar](500) NULL,
	[Year] [varchar](25) NULL,
	[RentalCost] [int] NULL,
	[Genre] [varchar](50) NULL,
	[Rating] [float] NULL,
 CONSTRAINT [PK__Movies__4BD2943AF0411E1B] PRIMARY KEY CLUSTERED 
(
	[MovieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OurCustomers]    Script Date: 25-11-2020 11.53.05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OurCustomers](
	[CustID] [int] IDENTITY(101,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Address] [varchar](max) NULL,
	[Phone] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[CustID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentedMovies]    Script Date: 25-11-2020 11.53.05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentedMovies](
	[RentId] [int] IDENTITY(1,1) NOT NULL,
	[MovieID] [int] NULL,
	[CustID] [int] NULL,
	[RentedDate] [varchar](100) NULL,
	[ReturnDate] [varchar](100) NULL,
 CONSTRAINT [PK__RentedMo__783D47F5A31EEEC8] PRIMARY KEY CLUSTERED 
(
	[RentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[MyMovies] ON 

INSERT [dbo].[MyMovies] ([MovieID], [Title], [Year], [RentalCost], [Genre], [Rating]) VALUES (1001, N'The Call of the Wild', N'2020', 5, N'Adventure, Drama, Family', 6.8)
INSERT [dbo].[MyMovies] ([MovieID], [Title], [Year], [RentalCost], [Genre], [Rating]) VALUES (1002, N'Bloodshot', N'2020', 5, N'Action, Drama, Sci-Fi', 5)
INSERT [dbo].[MyMovies] ([MovieID], [Title], [Year], [RentalCost], [Genre], [Rating]) VALUES (1003, N'Bad Boys for Life', N'2020', 5, N'action, drama', 8.2)
INSERT [dbo].[MyMovies] ([MovieID], [Title], [Year], [RentalCost], [Genre], [Rating]) VALUES (1004, N'Cast Away', N'2000', 2, N'Adventure, Drama, Romance', 7.8)
INSERT [dbo].[MyMovies] ([MovieID], [Title], [Year], [RentalCost], [Genre], [Rating]) VALUES (1006, N'The Longest Yard', N'2005', 2, N'Comedy, Crime, Sport', 6.4)
INSERT [dbo].[MyMovies] ([MovieID], [Title], [Year], [RentalCost], [Genre], [Rating]) VALUES (1007, N'Nothing to Lose', N'1997', 2, N'Action, Adventure, Comedy', 6.2)
INSERT [dbo].[MyMovies] ([MovieID], [Title], [Year], [RentalCost], [Genre], [Rating]) VALUES (1008, N'Batman & Robin', N'1997', 2, N'Action, Sci-Fi', 3.8)
SET IDENTITY_INSERT [dbo].[MyMovies] OFF
GO
SET IDENTITY_INSERT [dbo].[OurCustomers] ON 

INSERT [dbo].[OurCustomers] ([CustID], [Name], [Address], [Phone]) VALUES (101, N'Manpreet', N'California', 65656900)
INSERT [dbo].[OurCustomers] ([CustID], [Name], [Address], [Phone]) VALUES (102, N'Iqbal Singh', N'NZ', 789456)
INSERT [dbo].[OurCustomers] ([CustID], [Name], [Address], [Phone]) VALUES (103, N'Ramandeep Kaur', N'Auckland', 525634577)
INSERT [dbo].[OurCustomers] ([CustID], [Name], [Address], [Phone]) VALUES (104, N'K.L. Rahul', N'willington', 696963215)
INSERT [dbo].[OurCustomers] ([CustID], [Name], [Address], [Phone]) VALUES (105, N'S.K. Singla', N'new york', 662220001)
SET IDENTITY_INSERT [dbo].[OurCustomers] OFF
GO
SET IDENTITY_INSERT [dbo].[RentedMovies] ON 

INSERT [dbo].[RentedMovies] ([RentId], [MovieID], [CustID], [RentedDate], [ReturnDate]) VALUES (1, 1001, 102, N'25-11-2020', N'02-12-2020')
INSERT [dbo].[RentedMovies] ([RentId], [MovieID], [CustID], [RentedDate], [ReturnDate]) VALUES (2, 1006, 102, N'25-11-2020', N'04-12-2020')
INSERT [dbo].[RentedMovies] ([RentId], [MovieID], [CustID], [RentedDate], [ReturnDate]) VALUES (3, 1008, 102, N'25-11-2020', N'28-11-2020')
INSERT [dbo].[RentedMovies] ([RentId], [MovieID], [CustID], [RentedDate], [ReturnDate]) VALUES (4, 1008, 103, N'25-11-2020', N'29-11-2020')
INSERT [dbo].[RentedMovies] ([RentId], [MovieID], [CustID], [RentedDate], [ReturnDate]) VALUES (5, 1007, 103, N'25-11-2020', N'27-11-2020')
INSERT [dbo].[RentedMovies] ([RentId], [MovieID], [CustID], [RentedDate], [ReturnDate]) VALUES (6, 1001, 103, N'25-11-2020', N'27-11-2020')
INSERT [dbo].[RentedMovies] ([RentId], [MovieID], [CustID], [RentedDate], [ReturnDate]) VALUES (7, 1002, 105, N'25-11-2020', N'26-11-2020')
INSERT [dbo].[RentedMovies] ([RentId], [MovieID], [CustID], [RentedDate], [ReturnDate]) VALUES (8, 1008, 104, N'25-11-2020', N'26-11-2020')
SET IDENTITY_INSERT [dbo].[RentedMovies] OFF
GO
/****** Object:  Index [UQ__Customer__5C7E359E51BD5FD7]    Script Date: 25-11-2020 11.53.05 PM ******/
ALTER TABLE [dbo].[OurCustomers] ADD UNIQUE NONCLUSTERED 
(
	[Phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[RentedMovies]  WITH CHECK ADD  CONSTRAINT [FK__RentedMov__CustI__3C69FB99] FOREIGN KEY([CustID])
REFERENCES [dbo].[OurCustomers] ([CustID])
GO
ALTER TABLE [dbo].[RentedMovies] CHECK CONSTRAINT [FK__RentedMov__CustI__3C69FB99]
GO
ALTER TABLE [dbo].[RentedMovies]  WITH CHECK ADD  CONSTRAINT [FK__RentedMov__Movie__3E52440B] FOREIGN KEY([MovieID])
REFERENCES [dbo].[MyMovies] ([MovieID])
GO
ALTER TABLE [dbo].[RentedMovies] CHECK CONSTRAINT [FK__RentedMov__Movie__3E52440B]
GO
/****** Object:  StoredProcedure [dbo].[BorrowMostMoviesSP]    Script Date: 25-11-2020 11.53.05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[BorrowMostMoviesSP]
	as
	SELECT 
    rm.CustID,
	name as CustomerName,
    COUNT(*) occurrences
FROM RentedMovies rm join OurCustomers cc on cc.custid = rm.custid
GROUP BY
    rm.CustID, name
  
HAVING 
    COUNT(*) >1;
GO
/****** Object:  StoredProcedure [dbo].[DeleteCustSP]    Script Date: 25-11-2020 11.53.05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE proc [dbo].[DeleteCustSP](@custId int)
  as
  delete from OurCustomers where custId=@custId
GO
/****** Object:  StoredProcedure [dbo].[MostPopularMoviesSP]    Script Date: 25-11-2020 11.53.05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[MostPopularMoviesSP]
 as
SELECT 
    rm.MovieID,title, COUNT(*) occurrences
FROM RentedMovies rm join MyMovies m on m.movieid = rm.movieid
GROUP BY
    rm.MovieID, title
  
HAVING 
    COUNT(*) >1;
GO
/****** Object:  StoredProcedure [dbo].[RentedMovieSP]    Script Date: 25-11-2020 11.53.05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE proc [dbo].[RentedMovieSP]
  as
  select RentId, name as CustomerName, Address, Title ,RentalCost,RentedDate,ReturnDate
  from RentedMovies rm join OurCustomers c on c.CustID = rm.CustID join MyMovies m on m.MovieID= rm.MovieID
  order by RentedDate desc
GO
/****** Object:  StoredProcedure [dbo].[RentMovieSP]    Script Date: 25-11-2020 11.53.05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[RentMovieSP](@MovieID int,@CustID int,@RentDate varchar(100), @ReturnDate varchar(100))
  as
  insert into RentedMovies(MovieID,CustID,RentedDate,ReturnDate) values(@MovieID,@CustID,@RentDate,@ReturnDate)
GO
/****** Object:  StoredProcedure [dbo].[ReturnMovieSP]    Script Date: 25-11-2020 11.53.05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ReturnMovieSP](@MovieID int,@CustID int)
  as
  delete from RentedMovies where MovieID=@MovieID and CustID= @CustID;
GO
USE [master]
GO
ALTER DATABASE [movie1] SET  READ_WRITE 
GO
