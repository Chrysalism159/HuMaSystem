USE [master]
GO
/****** Object:  Database [HuMaDatabase]    Script Date: 6/3/2023 12:02:24 PM ******/
CREATE DATABASE [HuMaDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HuMaDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\HuMaDatabase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HuMaDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\HuMaDatabase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [HuMaDatabase] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HuMaDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HuMaDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HuMaDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HuMaDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HuMaDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HuMaDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [HuMaDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HuMaDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HuMaDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HuMaDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HuMaDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HuMaDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HuMaDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HuMaDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HuMaDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HuMaDatabase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HuMaDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HuMaDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HuMaDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HuMaDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HuMaDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HuMaDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HuMaDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HuMaDatabase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HuMaDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [HuMaDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HuMaDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HuMaDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HuMaDatabase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HuMaDatabase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HuMaDatabase] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [HuMaDatabase] SET QUERY_STORE = ON
GO
ALTER DATABASE [HuMaDatabase] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [HuMaDatabase]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 6/3/2023 12:02:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[UserName] [nchar](10) NOT NULL,
	[Password] [nchar](10) NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeTbl]    Script Date: 6/3/2023 12:02:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeTbl](
	[EmID] [nvarchar](10) NOT NULL,
	[EmName] [nvarchar](50) NOT NULL,
	[EmAdd] [nvarchar](100) NOT NULL,
	[EmGender] [nvarchar](10) NOT NULL,
	[EmCollage] [nvarchar](10) NOT NULL,
	[EmPhone] [nvarchar](10) NOT NULL,
	[EmPosition] [nvarchar](20) NOT NULL,
	[EmDoB] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([UserName], [Password]) VALUES (N'Admin     ', N'admin     ')
INSERT [dbo].[Account] ([UserName], [Password]) VALUES (N'Admin123  ', N'admin     ')
GO
INSERT [dbo].[EmployeeTbl] ([EmID], [EmName], [EmAdd], [EmGender], [EmCollage], [EmPhone], [EmPosition], [EmDoB]) VALUES (N'1', N'1', N'1', N'Female', N'GHT', N'1', N'Fresher Developer', N'3/10/2023')
INSERT [dbo].[EmployeeTbl] ([EmID], [EmName], [EmAdd], [EmGender], [EmCollage], [EmPhone], [EmPosition], [EmDoB]) VALUES (N'2', N'3', N'2', N'Male', N'BSM', N'2', N'Senior Developer', N'3/26/2023')
GO
/****** Object:  StoredProcedure [dbo].[CheckLogin]    Script Date: 6/3/2023 12:02:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CheckLogin] 
@Username nvarchar(20),
@Password nvarchar(20)
as
begin
    if exists (select * from Account where UserName = @Username and Password = @Password)
        select 1 as code
    else if exists(select * from Account where UserName = @Username and Password != @Password) 
        select 0 as code
    else select 2 as code
end
GO
USE [master]
GO
ALTER DATABASE [HuMaDatabase] SET  READ_WRITE 
GO
