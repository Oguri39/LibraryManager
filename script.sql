USE [Library]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 17/10/2022 22:03:01 PM ******/
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
/****** Object:  Table [dbo].[AuthorHasBooks]    Script Date: 17/10/2022 22:03:01 PM ******/
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
/****** Object:  Table [dbo].[Book]    Script Date: 17/10/2022 22:03:01 PM ******/
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
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookHasGenre]    Script Date: 17/10/2022 22:03:01 PM ******/
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
/****** Object:  Table [dbo].[BorrowReciept]    Script Date: 17/10/2022 22:03:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BorrowReciept](
	[BorrowRecieptId] [int] IDENTITY(1,1) NOT NULL,
	[BorrowRecieptBorrowedDate] [datetime] NOT NULL,
	[BorrowRecieptDeadline] [datetime] NOT NULL,
	[BorrowRecieptQuantity] [int] NOT NULL,
	[BorrowRecieptReturn] [int] NOT NULL,
	[BookId] [int] NOT NULL,
 CONSTRAINT [PK_BorrowReciept] PRIMARY KEY CLUSTERED 
(
	[BorrowRecieptId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genre]    Script Date: 17/10/2022 22:03:01 PM ******/
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
/****** Object:  Table [dbo].[PaymentRecord]    Script Date: 17/10/2022 22:03:01 PM ******/
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
/****** Object:  Table [dbo].[Profile]    Script Date: 17/10/2022 22:03:01 PM ******/
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
/****** Object:  Table [dbo].[Publisher]    Script Date: 17/10/2022 22:03:01 PM ******/
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
/****** Object:  Table [dbo].[PublisherHasBooks]    Script Date: 17/10/2022 22:03:01 PM ******/
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
/****** Object:  Table [dbo].[User]    Script Date: 17/10/2022 22:03:01 PM ******/
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
/****** Object:  Table [dbo].[UserHasBorrowReciept]    Script Date: 17/10/2022 22:03:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserHasBorrowReciept](
	[UserHasBorrowRecieptId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[BorrowRecieptId] [int] NOT NULL,
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
SET IDENTITY_INSERT [dbo].[AuthorHasBooks] OFF
GO
SET IDENTITY_INSERT [dbo].[Book] ON 

INSERT [dbo].[Book] ([BookId], [BookName], [BookNumberOfPages], [BookProductDate], [BookNumberOfCopies], [BookDescription], [BookFee], [BookImage]) VALUES (1, N'The Stand                                                                                                                                                                                               ', 823, CAST(N'1978-10-03T00:00:00.000' AS DateTime), 3, N'The Stand is a post-apocalyptic dark fantasy novel written by American author Stephen King and first published in 1978 by Doubleday. The plot centers on a deadly pandemic of weaponized influenza and its aftermath, in which the few surviving humans gather into factions that are each led by a personification of either good or evil and seem fated to clash with each other. King started writing the story in February 1975,[1] seeking to create an epic in the spirit of The Lord of the Rings. The book was difficult for him to write because of the large number of characters and storylines.', 300000, NULL)
INSERT [dbo].[Book] ([BookId], [BookName], [BookNumberOfPages], [BookProductDate], [BookNumberOfCopies], [BookDescription], [BookFee], [BookImage]) VALUES (2, N'Fairy Tale                                                                                                                                                                                              ', 608, CAST(N'2022-09-06T00:00:00.000' AS DateTime), 14, N'Fairy Tale is a dark fantasy novel by American author Stephen King, published on September 6, 2022 by Scribner.[1][2] The novel follows Charlie Reade, a 17-year-old who inherits keys to a hidden, otherworldly realm, and finds himself leading the battle between forces of good and evil.', 400000, NULL)
SET IDENTITY_INSERT [dbo].[Book] OFF
GO
SET IDENTITY_INSERT [dbo].[BookHasGenre] ON 

INSERT [dbo].[BookHasGenre] ([BookHasGenreId], [BookId], [GenreId]) VALUES (1, 1, 3)
INSERT [dbo].[BookHasGenre] ([BookHasGenreId], [BookId], [GenreId]) VALUES (2, 1, 2)
INSERT [dbo].[BookHasGenre] ([BookHasGenreId], [BookId], [GenreId]) VALUES (3, 1, 1)
INSERT [dbo].[BookHasGenre] ([BookHasGenreId], [BookId], [GenreId]) VALUES (4, 2, 3)
INSERT [dbo].[BookHasGenre] ([BookHasGenreId], [BookId], [GenreId]) VALUES (5, 2, 4)
INSERT [dbo].[BookHasGenre] ([BookHasGenreId], [BookId], [GenreId]) VALUES (6, 2, 23)
SET IDENTITY_INSERT [dbo].[BookHasGenre] OFF
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
SET IDENTITY_INSERT [dbo].[Genre] OFF
GO
SET IDENTITY_INSERT [dbo].[Profile] ON 

INSERT [dbo].[Profile] ([ProfileId], [ProfileFirstName], [ProfileLastName], [ProfileSchoolId], [ProfileAddress], [ProfilePhoneNumber], [ProfileEmail]) VALUES (1, N'Trung                         ', N'Tran                          ', N'19103100069         ', N'Ha Noi                                                                                                                                                                                                  ', N'0123456789          ', N'oguri.takeshi39@gmail.com     ')
INSERT [dbo].[Profile] ([ProfileId], [ProfileFirstName], [ProfileLastName], [ProfileSchoolId], [ProfileAddress], [ProfilePhoneNumber], [ProfileEmail]) VALUES (2, N'Quang                         ', N'Can                           ', N'19103100157         ', N'Ha Noi                                                                                                                                                                                                  ', N'9876543210          ', NULL)
INSERT [dbo].[Profile] ([ProfileId], [ProfileFirstName], [ProfileLastName], [ProfileSchoolId], [ProfileAddress], [ProfilePhoneNumber], [ProfileEmail]) VALUES (3, N'Thuy                          ', N'Do                            ', N'19103100048         ', N'Ha Noi                                                                                                                                                                                                  ', N'5896321470          ', NULL)
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
SET IDENTITY_INSERT [dbo].[PublisherHasBooks] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserId], [UserName], [UserRoles], [UserPassword], [ProfileId], [UserApproved]) VALUES (1, N'admin                         ', 3, N'admin', 0, 1)
INSERT [dbo].[User] ([UserId], [UserName], [UserRoles], [UserPassword], [ProfileId], [UserApproved]) VALUES (2, N'trung                         ', 2, N'123', 1, 1)
INSERT [dbo].[User] ([UserId], [UserName], [UserRoles], [UserPassword], [ProfileId], [UserApproved]) VALUES (3, N'quang                         ', 1, N'123', 2, 1)
INSERT [dbo].[User] ([UserId], [UserName], [UserRoles], [UserPassword], [ProfileId], [UserApproved]) VALUES (4, N'thuy                          ', 1, N'123', 3, 1)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[BorrowReciept] ADD  CONSTRAINT [DF_BorrowReciept_BorrowRecieptQuantity]  DEFAULT ((0)) FOR [BorrowRecieptQuantity]
GO
ALTER TABLE [dbo].[BorrowReciept] ADD  CONSTRAINT [DF_BorrowReciept_BorrowRecieptReturned]  DEFAULT ((0)) FOR [BorrowRecieptReturn]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_UserRoles]  DEFAULT ((0)) FOR [UserRoles]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_UserApproved]  DEFAULT ((0)) FOR [UserApproved]
GO
