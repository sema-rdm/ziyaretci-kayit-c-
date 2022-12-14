USE [master]
GO
/****** Object:  Database [ZiyaretKayit]    Script Date: 24.07.2022 16:16:25 ******/
CREATE DATABASE [ZiyaretKayit]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ZiyaretKayit', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ZiyaretKayit.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ZiyaretKayit_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ZiyaretKayit_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ZiyaretKayit] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ZiyaretKayit].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ZiyaretKayit] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ZiyaretKayit] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ZiyaretKayit] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ZiyaretKayit] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ZiyaretKayit] SET ARITHABORT OFF 
GO
ALTER DATABASE [ZiyaretKayit] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ZiyaretKayit] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ZiyaretKayit] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ZiyaretKayit] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ZiyaretKayit] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ZiyaretKayit] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ZiyaretKayit] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ZiyaretKayit] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ZiyaretKayit] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ZiyaretKayit] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ZiyaretKayit] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ZiyaretKayit] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ZiyaretKayit] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ZiyaretKayit] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ZiyaretKayit] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ZiyaretKayit] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ZiyaretKayit] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ZiyaretKayit] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ZiyaretKayit] SET  MULTI_USER 
GO
ALTER DATABASE [ZiyaretKayit] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ZiyaretKayit] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ZiyaretKayit] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ZiyaretKayit] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ZiyaretKayit] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ZiyaretKayit] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ZiyaretKayit] SET QUERY_STORE = OFF
GO
USE [ZiyaretKayit]
GO
/****** Object:  Table [dbo].[ziyaretci]    Script Date: 24.07.2022 16:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ziyaretci](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[adsoyad] [varchar](50) NULL,
	[unvan] [varchar](50) NULL,
	[adres] [varchar](50) NULL,
	[telefon] [varchar](100) NULL,
	[ziyaretsebebi] [varchar](50) NULL,
	[ziyarettarihi] [varchar](250) NULL,
	[girissaati] [varchar](10) NULL,
	[cikissaati] [varchar](10) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ziyaretci] ON 

INSERT [dbo].[ziyaretci] ([id], [adsoyad], [unvan], [adres], [telefon], [ziyaretsebebi], [ziyarettarihi], [girissaati], [cikissaati]) VALUES (237, N'etrtyr', N'rtyry', N'dfhfghgfhg', N'05530008551', N'Hayırlı olsun', N'20.07.2022', N'21:27:04', N'22:10:00')
INSERT [dbo].[ziyaretci] ([id], [adsoyad], [unvan], [adres], [telefon], [ziyaretsebebi], [ziyarettarihi], [girissaati], [cikissaati]) VALUES (241, N'sdfgd', N'fhfghff', N'jghjgkgk', N'05530008551', N'Yemek yemek', N'20.07.2022', N'21:53:35', N'22:45:00')
INSERT [dbo].[ziyaretci] ([id], [adsoyad], [unvan], [adres], [telefon], [ziyaretsebebi], [ziyarettarihi], [girissaati], [cikissaati]) VALUES (247, N'aaaaa', N'ffgh', N'hfgjghj', N'05530008551', N'Hayırlı olsun', N'20.07.2022', N'21:56:25', N'22:14:00')
INSERT [dbo].[ziyaretci] ([id], [adsoyad], [unvan], [adres], [telefon], [ziyaretsebebi], [ziyarettarihi], [girissaati], [cikissaati]) VALUES (248, N'fggfg', N'gfh', N'hghgjg', N'05555555555', N'Tanışmak', N'24.07.2022', N'14:41:40', N'15:00:00')
INSERT [dbo].[ziyaretci] ([id], [adsoyad], [unvan], [adres], [telefon], [ziyaretsebebi], [ziyarettarihi], [girissaati], [cikissaati]) VALUES (236, N'dfdfd', N'dgdfgf', N'gfhfgh', N'05530008551', N'Tanışmak', N'20.07.2022', N'20:42:59', N'21:10:00')
INSERT [dbo].[ziyaretci] ([id], [adsoyad], [unvan], [adres], [telefon], [ziyaretsebebi], [ziyarettarihi], [girissaati], [cikissaati]) VALUES (233, N'fdfdfg', N'dfgdgd', N'dfgfghfghgfh', N'05530008551', N'Hayırlı olsun', N'20.07.2022', N'20:15:02', N'21:00:00')
INSERT [dbo].[ziyaretci] ([id], [adsoyad], [unvan], [adres], [telefon], [ziyaretsebebi], [ziyarettarihi], [girissaati], [cikissaati]) VALUES (234, N'rytuty', N'yutyu', N'tyutyuıyuı', N'05330903000', N'Diğer', N'20.07.2022', N'14:08:21', N'15:00:00')
INSERT [dbo].[ziyaretci] ([id], [adsoyad], [unvan], [adres], [telefon], [ziyaretsebebi], [ziyarettarihi], [girissaati], [cikissaati]) VALUES (239, N'jljklj', N'jljklj', N'jljkljl', N'05530008551', N'Yemek yemek', N'20.07.2022', N'21:32:20', N'21:54:00')
INSERT [dbo].[ziyaretci] ([id], [adsoyad], [unvan], [adres], [telefon], [ziyaretsebebi], [ziyarettarihi], [girissaati], [cikissaati]) VALUES (240, N'fgfdg', N'fhfgh', N'gfhfjg', N'05555555555', N'Tanışmak', N'20.07.2022', N'21:37:42', N'22:11:00')
SET IDENTITY_INSERT [dbo].[ziyaretci] OFF
GO
USE [master]
GO
ALTER DATABASE [ZiyaretKayit] SET  READ_WRITE 
GO
