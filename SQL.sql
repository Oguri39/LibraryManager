USE [master]
GO
/****** Object:  Database [Library]    Script Date: 14/11/2022 23:36:18 PM ******/
CREATE DATABASE [Library]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Library', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Library.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Library_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Library_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Library] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Library].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Library] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Library] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Library] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Library] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Library] SET ARITHABORT OFF 
GO
ALTER DATABASE [Library] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Library] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Library] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Library] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Library] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Library] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Library] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Library] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Library] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Library] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Library] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Library] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Library] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Library] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Library] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Library] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Library] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Library] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Library] SET  MULTI_USER 
GO
ALTER DATABASE [Library] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Library] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Library] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Library] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Library] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Library] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Library] SET QUERY_STORE = OFF
GO
USE [Library]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 14/11/2022 23:36:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Author](
	[AuthorId] [int] IDENTITY(1,1) NOT NULL,
	[AuthorName] [nchar](30) NULL,
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AuthorHasBooks]    Script Date: 14/11/2022 23:36:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuthorHasBooks](
	[AuthorHasBooksId] [int] IDENTITY(1,1) NOT NULL,
	[AuthorId] [int] NOT NULL,
	[BookId] [int] NOT NULL,
 CONSTRAINT [PK_AuthorHasBooks] PRIMARY KEY CLUSTERED 
(
	[AuthorHasBooksId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 14/11/2022 23:36:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[BookId] [int] IDENTITY(1,1) NOT NULL,
	[BookName] [nchar](200) NOT NULL,
	[BookNumberOfPages] [int] NULL,
	[BookProductDate] [datetime] NULL,
	[BookNumberOfCopies] [int] NULL,
	[BookDescription] [text] NULL,
	[BookFee] [float] NULL,
	[BookImage] [nchar](300) NULL,
	[BookIsNew] [int] NULL,
	[BookIsDeleted] [int] NOT NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookHasGenre]    Script Date: 14/11/2022 23:36:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookHasGenre](
	[BookHasGenreId] [int] IDENTITY(1,1) NOT NULL,
	[BookId] [int] NOT NULL,
	[GenreId] [int] NOT NULL,
 CONSTRAINT [PK_BookHasGenre] PRIMARY KEY CLUSTERED 
(
	[BookHasGenreId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BorrowReciept]    Script Date: 14/11/2022 23:36:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BorrowReciept](
	[BorrowRecieptId] [int] IDENTITY(1,1) NOT NULL,
	[BorrowRecieptBorrowedDate] [nchar](100) NOT NULL,
	[BorrowRecieptDeadline] [nchar](100) NOT NULL,
	[BorrowRecieptQuantity] [int] NOT NULL,
	[BorrowRecieptIsReturned] [int] NOT NULL,
	[BookId] [int] NOT NULL,
	[UserId] [int] NULL,
 CONSTRAINT [PK_BorrowReciept] PRIMARY KEY CLUSTERED 
(
	[BorrowRecieptId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genre]    Script Date: 14/11/2022 23:36:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genre](
	[GenreId] [int] IDENTITY(1,1) NOT NULL,
	[GenreName] [nchar](30) NULL,
 CONSTRAINT [PK_Genre] PRIMARY KEY CLUSTERED 
(
	[GenreId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentRecord]    Script Date: 14/11/2022 23:36:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentRecord](
	[PaymentRecordId] [int] IDENTITY(1,1) NOT NULL,
	[BorrowRecieptId] [int] NOT NULL,
	[PaymentRecordDateRecieve] [date] NOT NULL,
	[PaymentRecordRecieved] [float] NOT NULL,
 CONSTRAINT [PK_PaymentRecord] PRIMARY KEY CLUSTERED 
(
	[PaymentRecordId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profile]    Script Date: 14/11/2022 23:36:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profile](
	[ProfileId] [int] IDENTITY(1,1) NOT NULL,
	[ProfileFirstName] [nchar](30) NULL,
	[ProfileLastName] [nchar](30) NULL,
	[ProfileSchoolId] [nchar](20) NULL,
	[ProfileAddress] [nchar](200) NULL,
	[ProfilePhoneNumber] [nchar](20) NULL,
	[ProfileEmail] [nchar](30) NULL,
 CONSTRAINT [PK_Profile] PRIMARY KEY CLUSTERED 
(
	[ProfileId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publisher]    Script Date: 14/11/2022 23:36:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publisher](
	[PublisherId] [int] IDENTITY(1,1) NOT NULL,
	[PublisherName] [nchar](30) NULL,
 CONSTRAINT [PK_Publisher] PRIMARY KEY CLUSTERED 
(
	[PublisherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PublisherHasBooks]    Script Date: 14/11/2022 23:36:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PublisherHasBooks](
	[PublisherHasBooksId] [int] IDENTITY(1,1) NOT NULL,
	[PublisherId] [int] NOT NULL,
	[BookId] [int] NOT NULL,
 CONSTRAINT [PK_PublisherHasBooks] PRIMARY KEY CLUSTERED 
(
	[PublisherHasBooksId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 14/11/2022 23:36:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nchar](30) NOT NULL,
	[UserRoles] [int] NOT NULL,
	[UserPassword] [nvarchar](150) NOT NULL,
	[ProfileId] [int] NULL,
	[UserApproved] [int] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserHasBorrowReciept]    Script Date: 14/11/2022 23:36:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserHasBorrowReciept](
	[UserHasBorrowRecieptId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[BorrowRecieptId] [int] NOT NULL,
	[UserHasBorrowRecieptIsAskingForCheck] [int] NOT NULL,
 CONSTRAINT [PK_UserHasBorrowReciept] PRIMARY KEY CLUSTERED 
(
	[UserHasBorrowRecieptId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Author] ON 

INSERT [dbo].[Author] ([AuthorId], [AuthorName]) VALUES (1, N'Stephen King                  ')
INSERT [dbo].[Author] ([AuthorId], [AuthorName]) VALUES (2, N'Ernest Hemingway              ')
INSERT [dbo].[Author] ([AuthorId], [AuthorName]) VALUES (3, N'Leo Tolstoy                   ')
INSERT [dbo].[Author] ([AuthorId], [AuthorName]) VALUES (4, N'Ken Follett                   ')
INSERT [dbo].[Author] ([AuthorId], [AuthorName]) VALUES (5, N'Lewis Carroll                 ')
INSERT [dbo].[Author] ([AuthorId], [AuthorName]) VALUES (6, N'George Saunders               ')
INSERT [dbo].[Author] ([AuthorId], [AuthorName]) VALUES (7, N'Erik Larson                   ')
INSERT [dbo].[Author] ([AuthorId], [AuthorName]) VALUES (8, N'James Partterson              ')
SET IDENTITY_INSERT [dbo].[Author] OFF
GO
SET IDENTITY_INSERT [dbo].[AuthorHasBooks] ON 

INSERT [dbo].[AuthorHasBooks] ([AuthorHasBooksId], [AuthorId], [BookId]) VALUES (1, 1, 1)
INSERT [dbo].[AuthorHasBooks] ([AuthorHasBooksId], [AuthorId], [BookId]) VALUES (2, 1, 2)
INSERT [dbo].[AuthorHasBooks] ([AuthorHasBooksId], [AuthorId], [BookId]) VALUES (3, 2, 5)
INSERT [dbo].[AuthorHasBooks] ([AuthorHasBooksId], [AuthorId], [BookId]) VALUES (4, 5, 5)
INSERT [dbo].[AuthorHasBooks] ([AuthorHasBooksId], [AuthorId], [BookId]) VALUES (8, 3, 7)
INSERT [dbo].[AuthorHasBooks] ([AuthorHasBooksId], [AuthorId], [BookId]) VALUES (9, 6, 7)
INSERT [dbo].[AuthorHasBooks] ([AuthorHasBooksId], [AuthorId], [BookId]) VALUES (10, 3, 8)
INSERT [dbo].[AuthorHasBooks] ([AuthorHasBooksId], [AuthorId], [BookId]) VALUES (11, 6, 8)
INSERT [dbo].[AuthorHasBooks] ([AuthorHasBooksId], [AuthorId], [BookId]) VALUES (20, 3, 12)
INSERT [dbo].[AuthorHasBooks] ([AuthorHasBooksId], [AuthorId], [BookId]) VALUES (21, 6, 12)
INSERT [dbo].[AuthorHasBooks] ([AuthorHasBooksId], [AuthorId], [BookId]) VALUES (22, 8, 12)
SET IDENTITY_INSERT [dbo].[AuthorHasBooks] OFF
GO
SET IDENTITY_INSERT [dbo].[Book] ON 

INSERT [dbo].[Book] ([BookId], [BookName], [BookNumberOfPages], [BookProductDate], [BookNumberOfCopies], [BookDescription], [BookFee], [BookImage], [BookIsNew], [BookIsDeleted]) VALUES (1, N'The Stand                                                                                                                                                                                               ', 823, CAST(N'1978-10-03T00:00:00.000' AS DateTime), 3000, N'The Stand is a post-apocalyptic dark fantasy novel written by American author Stephen King and first published in 1978 by Doubleday. The plot centers on a deadly pandemic of weaponized influenza and its aftermath, in which the few surviving humans gather into factions that are each led by a personification of either good or evil and seem fated to clash with each other. King started writing the story in February 1975,[1] seeking to create an epic in the spirit of The Lord of the Rings. The book was difficult for him to write because of the large number of characters and storylines.', 300000, NULL, 1, 0)
INSERT [dbo].[Book] ([BookId], [BookName], [BookNumberOfPages], [BookProductDate], [BookNumberOfCopies], [BookDescription], [BookFee], [BookImage], [BookIsNew], [BookIsDeleted]) VALUES (2, N'Fairy Tale                                                                                                                                                                                              ', 608, CAST(N'2022-09-06T00:00:00.000' AS DateTime), 1400, N'Fairy Tale is a dark fantasy novel by American author Stephen King, published on September 6, 2022 by Scribner.[1][2] The novel follows Charlie Reade, a 17-year-old who inherits keys to a hidden, otherworldly realm, and finds himself leading the battle between forces of good and evil.', 400000, NULL, 0, 0)
INSERT [dbo].[Book] ([BookId], [BookName], [BookNumberOfPages], [BookProductDate], [BookNumberOfCopies], [BookDescription], [BookFee], [BookImage], [BookIsNew], [BookIsDeleted]) VALUES (5, N'MyBook                                                                                                                                                                                                  ', 123, CAST(N'2022-11-16T01:36:20.000' AS DateTime), 123, N'123', 111222333, N'                                                                                                                                                                                                                                                                                                            ', 1, 0)
INSERT [dbo].[Book] ([BookId], [BookName], [BookNumberOfPages], [BookProductDate], [BookNumberOfCopies], [BookDescription], [BookFee], [BookImage], [BookIsNew], [BookIsDeleted]) VALUES (6, N'new_bookName                                                                                                                                                                                            ', 1123123, CAST(N'1900-01-02T00:00:00.000' AS DateTime), 112312, N'new_bookDescription', 1123123, N'                                                                                                                                                                                                                                                                                                            ', 1, 0)
INSERT [dbo].[Book] ([BookId], [BookName], [BookNumberOfPages], [BookProductDate], [BookNumberOfCopies], [BookDescription], [BookFee], [BookImage], [BookIsNew], [BookIsDeleted]) VALUES (7, N'Test                                                                                                                                                                                                    ', 123, CAST(N'2022-11-13T01:39:35.030' AS DateTime), 123, N'111111', 1111111, N'                                                                                                                                                                                                                                                                                                            ', 1, 0)
INSERT [dbo].[Book] ([BookId], [BookName], [BookNumberOfPages], [BookProductDate], [BookNumberOfCopies], [BookDescription], [BookFee], [BookImage], [BookIsNew], [BookIsDeleted]) VALUES (8, N'Test                                                                                                                                                                                                    ', 123, CAST(N'2022-11-13T01:39:35.030' AS DateTime), 123, N'111111', 1111111, N'                                                                                                                                                                                                                                                                                                            ', 1, 0)
INSERT [dbo].[Book] ([BookId], [BookName], [BookNumberOfPages], [BookProductDate], [BookNumberOfCopies], [BookDescription], [BookFee], [BookImage], [BookIsNew], [BookIsDeleted]) VALUES (9, N'Test                                                                                                                                                                                                    ', 123, CAST(N'2022-11-13T01:39:35.030' AS DateTime), 123, N'111111', 1111111, N'                                                                                                                                                                                                                                                                                                            ', 1, 1)
INSERT [dbo].[Book] ([BookId], [BookName], [BookNumberOfPages], [BookProductDate], [BookNumberOfCopies], [BookDescription], [BookFee], [BookImage], [BookIsNew], [BookIsDeleted]) VALUES (10, N'Test                                                                                                                                                                                                    ', 123, CAST(N'2022-11-13T01:39:35.030' AS DateTime), 123, N'111111adasd', 1111111, N'                                                                                                                                                                                                                                                                                                            ', 1, 1)
INSERT [dbo].[Book] ([BookId], [BookName], [BookNumberOfPages], [BookProductDate], [BookNumberOfCopies], [BookDescription], [BookFee], [BookImage], [BookIsNew], [BookIsDeleted]) VALUES (11, N'Test                                                                                                                                                                                                    ', 123, CAST(N'2022-11-13T01:39:35.030' AS DateTime), 123, N'111111adasd', 1111111, N'                                                                                                                                                                                                                                                                                                            ', 1, 1)
INSERT [dbo].[Book] ([BookId], [BookName], [BookNumberOfPages], [BookProductDate], [BookNumberOfCopies], [BookDescription], [BookFee], [BookImage], [BookIsNew], [BookIsDeleted]) VALUES (12, N'abc                                                                                                                                                                                                     ', 123, CAST(N'2022-11-13T01:45:10.647' AS DateTime), 123, N'hajdhahdsjas', 123, N'                                                                                                                                                                                                                                                                                                            ', 0, 1)
SET IDENTITY_INSERT [dbo].[Book] OFF
GO
SET IDENTITY_INSERT [dbo].[BookHasGenre] ON 

INSERT [dbo].[BookHasGenre] ([BookHasGenreId], [BookId], [GenreId]) VALUES (1, 1, 3)
INSERT [dbo].[BookHasGenre] ([BookHasGenreId], [BookId], [GenreId]) VALUES (2, 1, 2)
INSERT [dbo].[BookHasGenre] ([BookHasGenreId], [BookId], [GenreId]) VALUES (3, 1, 1)
INSERT [dbo].[BookHasGenre] ([BookHasGenreId], [BookId], [GenreId]) VALUES (4, 2, 3)
INSERT [dbo].[BookHasGenre] ([BookHasGenreId], [BookId], [GenreId]) VALUES (5, 2, 4)
INSERT [dbo].[BookHasGenre] ([BookHasGenreId], [BookId], [GenreId]) VALUES (6, 2, 23)
INSERT [dbo].[BookHasGenre] ([BookHasGenreId], [BookId], [GenreId]) VALUES (7, 5, 8)
INSERT [dbo].[BookHasGenre] ([BookHasGenreId], [BookId], [GenreId]) VALUES (8, 5, 14)
INSERT [dbo].[BookHasGenre] ([BookHasGenreId], [BookId], [GenreId]) VALUES (11, 7, 8)
INSERT [dbo].[BookHasGenre] ([BookHasGenreId], [BookId], [GenreId]) VALUES (12, 7, 14)
INSERT [dbo].[BookHasGenre] ([BookHasGenreId], [BookId], [GenreId]) VALUES (13, 8, 8)
INSERT [dbo].[BookHasGenre] ([BookHasGenreId], [BookId], [GenreId]) VALUES (14, 8, 14)
INSERT [dbo].[BookHasGenre] ([BookHasGenreId], [BookId], [GenreId]) VALUES (23, 12, 9)
INSERT [dbo].[BookHasGenre] ([BookHasGenreId], [BookId], [GenreId]) VALUES (24, 12, 11)
SET IDENTITY_INSERT [dbo].[BookHasGenre] OFF
GO
SET IDENTITY_INSERT [dbo].[BorrowReciept] ON 

INSERT [dbo].[BorrowReciept] ([BorrowRecieptId], [BorrowRecieptBorrowedDate], [BorrowRecieptDeadline], [BorrowRecieptQuantity], [BorrowRecieptIsReturned], [BookId], [UserId]) VALUES (1, N'2/10/2022                                                                                           ', N'2/11/2022                                                                                           ', 1, 0, 1, 4)
INSERT [dbo].[BorrowReciept] ([BorrowRecieptId], [BorrowRecieptBorrowedDate], [BorrowRecieptDeadline], [BorrowRecieptQuantity], [BorrowRecieptIsReturned], [BookId], [UserId]) VALUES (2, N'2/9/2022                                                                                            ', N'2/10/2022                                                                                           ', 1, 1, 2, 4)
INSERT [dbo].[BorrowReciept] ([BorrowRecieptId], [BorrowRecieptBorrowedDate], [BorrowRecieptDeadline], [BorrowRecieptQuantity], [BorrowRecieptIsReturned], [BookId], [UserId]) VALUES (3, N'10/9/2022                                                                                           ', N'20/12/2022                                                                                          ', 1, 0, 2, 4)
INSERT [dbo].[BorrowReciept] ([BorrowRecieptId], [BorrowRecieptBorrowedDate], [BorrowRecieptDeadline], [BorrowRecieptQuantity], [BorrowRecieptIsReturned], [BookId], [UserId]) VALUES (4, N'11/9/2020                                                                                           ', N'14/9/2020                                                                                           ', 1, 0, 1, 4)
INSERT [dbo].[BorrowReciept] ([BorrowRecieptId], [BorrowRecieptBorrowedDate], [BorrowRecieptDeadline], [BorrowRecieptQuantity], [BorrowRecieptIsReturned], [BookId], [UserId]) VALUES (5, N'11/9/2020                                                                                           ', N'14/9/2020                                                                                           ', 1, 0, 1, 4)
INSERT [dbo].[BorrowReciept] ([BorrowRecieptId], [BorrowRecieptBorrowedDate], [BorrowRecieptDeadline], [BorrowRecieptQuantity], [BorrowRecieptIsReturned], [BookId], [UserId]) VALUES (6, N'01/11/2022                                                                                          ', N'04/03/2023                                                                                          ', 1, 0, 1, 4)
INSERT [dbo].[BorrowReciept] ([BorrowRecieptId], [BorrowRecieptBorrowedDate], [BorrowRecieptDeadline], [BorrowRecieptQuantity], [BorrowRecieptIsReturned], [BookId], [UserId]) VALUES (7, N'01/11/2022                                                                                          ', N'01/12/2028                                                                                          ', 1, 0, 1, 4)
INSERT [dbo].[BorrowReciept] ([BorrowRecieptId], [BorrowRecieptBorrowedDate], [BorrowRecieptDeadline], [BorrowRecieptQuantity], [BorrowRecieptIsReturned], [BookId], [UserId]) VALUES (8, N'01/11/2022                                                                                          ', N'21/11/2022                                                                                          ', 1, 0, 1, 4)
INSERT [dbo].[BorrowReciept] ([BorrowRecieptId], [BorrowRecieptBorrowedDate], [BorrowRecieptDeadline], [BorrowRecieptQuantity], [BorrowRecieptIsReturned], [BookId], [UserId]) VALUES (9, N'01/11/2022                                                                                          ', N'04/03/2023                                                                                          ', 1, 0, 2, 3)
INSERT [dbo].[BorrowReciept] ([BorrowRecieptId], [BorrowRecieptBorrowedDate], [BorrowRecieptDeadline], [BorrowRecieptQuantity], [BorrowRecieptIsReturned], [BookId], [UserId]) VALUES (10, N'14/11/2022                                                                                          ', N'22/02/2023                                                                                          ', 1, 1, 6, 3)
INSERT [dbo].[BorrowReciept] ([BorrowRecieptId], [BorrowRecieptBorrowedDate], [BorrowRecieptDeadline], [BorrowRecieptQuantity], [BorrowRecieptIsReturned], [BookId], [UserId]) VALUES (11, N'14/11/2022                                                                                          ', N'16/04/2053                                                                                          ', 1, 0, 1, 3)
SET IDENTITY_INSERT [dbo].[BorrowReciept] OFF
GO
SET IDENTITY_INSERT [dbo].[Genre] ON 

INSERT [dbo].[Genre] ([GenreId], [GenreName]) VALUES (1, N'Fiction                       ')
INSERT [dbo].[Genre] ([GenreId], [GenreName]) VALUES (2, N'Novel                         ')
INSERT [dbo].[Genre] ([GenreId], [GenreName]) VALUES (3, N'Historical                    ')
INSERT [dbo].[Genre] ([GenreId], [GenreName]) VALUES (4, N'Memoir                        ')
INSERT [dbo].[Genre] ([GenreId], [GenreName]) VALUES (5, N'Fantasy                       ')
INSERT [dbo].[Genre] ([GenreId], [GenreName]) VALUES (6, N'Dystopian                     ')
INSERT [dbo].[Genre] ([GenreId], [GenreName]) VALUES (7, N'Science                       ')
INSERT [dbo].[Genre] ([GenreId], [GenreName]) VALUES (8, N'Action                        ')
INSERT [dbo].[Genre] ([GenreId], [GenreName]) VALUES (9, N'Adventure                     ')
INSERT [dbo].[Genre] ([GenreId], [GenreName]) VALUES (10, N'Mystery                       ')
INSERT [dbo].[Genre] ([GenreId], [GenreName]) VALUES (11, N'Horror                        ')
INSERT [dbo].[Genre] ([GenreId], [GenreName]) VALUES (12, N'Romance                       ')
INSERT [dbo].[Genre] ([GenreId], [GenreName]) VALUES (13, N'Biography                     ')
INSERT [dbo].[Genre] ([GenreId], [GenreName]) VALUES (14, N'Travel                        ')
INSERT [dbo].[Genre] ([GenreId], [GenreName]) VALUES (15, N'Essays                        ')
INSERT [dbo].[Genre] ([GenreId], [GenreName]) VALUES (16, N'Humor                         ')
INSERT [dbo].[Genre] ([GenreId], [GenreName]) VALUES (17, N'Guide                         ')
INSERT [dbo].[Genre] ([GenreId], [GenreName]) VALUES (18, N'Religion                      ')
INSERT [dbo].[Genre] ([GenreId], [GenreName]) VALUES (23, N'Humanities & Social Sciences  ')
INSERT [dbo].[Genre] ([GenreId], [GenreName]) VALUES (24, N'Parenting & Families          ')
INSERT [dbo].[Genre] ([GenreId], [GenreName]) VALUES (25, N'new_genre_edit                ')
SET IDENTITY_INSERT [dbo].[Genre] OFF
GO
SET IDENTITY_INSERT [dbo].[PaymentRecord] ON 

INSERT [dbo].[PaymentRecord] ([PaymentRecordId], [BorrowRecieptId], [PaymentRecordDateRecieve], [PaymentRecordRecieved]) VALUES (1, 10, CAST(N'2022-11-14' AS Date), 1123123)
SET IDENTITY_INSERT [dbo].[PaymentRecord] OFF
GO
SET IDENTITY_INSERT [dbo].[Profile] ON 

INSERT [dbo].[Profile] ([ProfileId], [ProfileFirstName], [ProfileLastName], [ProfileSchoolId], [ProfileAddress], [ProfilePhoneNumber], [ProfileEmail]) VALUES (1, N'Trung                         ', N'Tran                          ', N'19103100069         ', N'Ha Noi                                                                                                                                                                                                  ', N'0123456789          ', N'oguri.takeshi39@gmail.com     ')
INSERT [dbo].[Profile] ([ProfileId], [ProfileFirstName], [ProfileLastName], [ProfileSchoolId], [ProfileAddress], [ProfilePhoneNumber], [ProfileEmail]) VALUES (2, N'Quang                         ', N'Can                           ', N'19103100157         ', N'Ha Noi                                                                                                                                                                                                  ', N'9876543210          ', NULL)
INSERT [dbo].[Profile] ([ProfileId], [ProfileFirstName], [ProfileLastName], [ProfileSchoolId], [ProfileAddress], [ProfilePhoneNumber], [ProfileEmail]) VALUES (3, N'Thuy                          ', N'Do                            ', N'19103100048         ', N'Ha Noi                                                                                                                                                                                                  ', N'5896321470          ', N'123                           ')
SET IDENTITY_INSERT [dbo].[Profile] OFF
GO
SET IDENTITY_INSERT [dbo].[Publisher] ON 

INSERT [dbo].[Publisher] ([PublisherId], [PublisherName]) VALUES (1, N'Harper Collins                ')
INSERT [dbo].[Publisher] ([PublisherId], [PublisherName]) VALUES (2, N'Simon & Schuster              ')
INSERT [dbo].[Publisher] ([PublisherId], [PublisherName]) VALUES (3, N'Macmillan                     ')
INSERT [dbo].[Publisher] ([PublisherId], [PublisherName]) VALUES (4, N'Hachette                      ')
INSERT [dbo].[Publisher] ([PublisherId], [PublisherName]) VALUES (5, N'Penguin Random House          ')
SET IDENTITY_INSERT [dbo].[Publisher] OFF
GO
SET IDENTITY_INSERT [dbo].[PublisherHasBooks] ON 

INSERT [dbo].[PublisherHasBooks] ([PublisherHasBooksId], [PublisherId], [BookId]) VALUES (1, 1, 1)
INSERT [dbo].[PublisherHasBooks] ([PublisherHasBooksId], [PublisherId], [BookId]) VALUES (2, 2, 2)
INSERT [dbo].[PublisherHasBooks] ([PublisherHasBooksId], [PublisherId], [BookId]) VALUES (3, 2, 7)
INSERT [dbo].[PublisherHasBooks] ([PublisherHasBooksId], [PublisherId], [BookId]) VALUES (4, 4, 7)
INSERT [dbo].[PublisherHasBooks] ([PublisherHasBooksId], [PublisherId], [BookId]) VALUES (5, 2, 8)
INSERT [dbo].[PublisherHasBooks] ([PublisherHasBooksId], [PublisherId], [BookId]) VALUES (6, 4, 8)
SET IDENTITY_INSERT [dbo].[PublisherHasBooks] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserId], [UserName], [UserRoles], [UserPassword], [ProfileId], [UserApproved]) VALUES (1, N'admin                         ', 3, N'admin', 0, 1)
INSERT [dbo].[User] ([UserId], [UserName], [UserRoles], [UserPassword], [ProfileId], [UserApproved]) VALUES (2, N'trung                         ', 2, N'123', 1, 1)
INSERT [dbo].[User] ([UserId], [UserName], [UserRoles], [UserPassword], [ProfileId], [UserApproved]) VALUES (3, N'quang                         ', 1, N'123', 2, 1)
INSERT [dbo].[User] ([UserId], [UserName], [UserRoles], [UserPassword], [ProfileId], [UserApproved]) VALUES (4, N'thuy                          ', 1, N'321', 3, 1)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
SET IDENTITY_INSERT [dbo].[UserHasBorrowReciept] ON 

INSERT [dbo].[UserHasBorrowReciept] ([UserHasBorrowRecieptId], [UserId], [BorrowRecieptId], [UserHasBorrowRecieptIsAskingForCheck]) VALUES (2, 4, 2, 0)
INSERT [dbo].[UserHasBorrowReciept] ([UserHasBorrowRecieptId], [UserId], [BorrowRecieptId], [UserHasBorrowRecieptIsAskingForCheck]) VALUES (3, 4, 3, 0)
INSERT [dbo].[UserHasBorrowReciept] ([UserHasBorrowRecieptId], [UserId], [BorrowRecieptId], [UserHasBorrowRecieptIsAskingForCheck]) VALUES (4, 4, 4, 0)
INSERT [dbo].[UserHasBorrowReciept] ([UserHasBorrowRecieptId], [UserId], [BorrowRecieptId], [UserHasBorrowRecieptIsAskingForCheck]) VALUES (5, 4, 5, 0)
INSERT [dbo].[UserHasBorrowReciept] ([UserHasBorrowRecieptId], [UserId], [BorrowRecieptId], [UserHasBorrowRecieptIsAskingForCheck]) VALUES (6, 4, 6, 0)
INSERT [dbo].[UserHasBorrowReciept] ([UserHasBorrowRecieptId], [UserId], [BorrowRecieptId], [UserHasBorrowRecieptIsAskingForCheck]) VALUES (7, 4, 7, 0)
INSERT [dbo].[UserHasBorrowReciept] ([UserHasBorrowRecieptId], [UserId], [BorrowRecieptId], [UserHasBorrowRecieptIsAskingForCheck]) VALUES (8, 4, 8, 0)
INSERT [dbo].[UserHasBorrowReciept] ([UserHasBorrowRecieptId], [UserId], [BorrowRecieptId], [UserHasBorrowRecieptIsAskingForCheck]) VALUES (11, 3, 11, 1)
SET IDENTITY_INSERT [dbo].[UserHasBorrowReciept] OFF
GO
ALTER TABLE [dbo].[Book] ADD  CONSTRAINT [DF_Book_BookIsNew]  DEFAULT ((0)) FOR [BookIsNew]
GO
ALTER TABLE [dbo].[Book] ADD  CONSTRAINT [DF_Book_BookIsDeleted]  DEFAULT ((0)) FOR [BookIsDeleted]
GO
ALTER TABLE [dbo].[BorrowReciept] ADD  CONSTRAINT [DF_BorrowReciept_BorrowRecieptQuantity]  DEFAULT ((0)) FOR [BorrowRecieptQuantity]
GO
ALTER TABLE [dbo].[BorrowReciept] ADD  CONSTRAINT [DF_BorrowReciept_BorrowRecieptReturned]  DEFAULT ((0)) FOR [BorrowRecieptIsReturned]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_UserRoles]  DEFAULT ((0)) FOR [UserRoles]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_UserApproved]  DEFAULT ((0)) FOR [UserApproved]
GO
ALTER TABLE [dbo].[UserHasBorrowReciept] ADD  CONSTRAINT [DF_UserHasBorrowReciept_UserHasBorrowRecieptIsAskingForCheck]  DEFAULT ((0)) FOR [UserHasBorrowRecieptIsAskingForCheck]
GO
USE [master]
GO
ALTER DATABASE [Library] SET  READ_WRITE 
GO
