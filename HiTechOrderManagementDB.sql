USE [master]
GO
/****** Object:  Database [HiTechOrderManagementDB]    Script Date: 22-04-2024 16:44:53 ******/
CREATE DATABASE [HiTechOrderManagementDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HiTechOrderManagementDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\HiTechOrderManagementDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HiTechOrderManagementDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\HiTechOrderManagementDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [HiTechOrderManagementDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HiTechOrderManagementDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HiTechOrderManagementDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HiTechOrderManagementDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HiTechOrderManagementDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HiTechOrderManagementDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HiTechOrderManagementDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [HiTechOrderManagementDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HiTechOrderManagementDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HiTechOrderManagementDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HiTechOrderManagementDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HiTechOrderManagementDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HiTechOrderManagementDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HiTechOrderManagementDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HiTechOrderManagementDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HiTechOrderManagementDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HiTechOrderManagementDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HiTechOrderManagementDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HiTechOrderManagementDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HiTechOrderManagementDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HiTechOrderManagementDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HiTechOrderManagementDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HiTechOrderManagementDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HiTechOrderManagementDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HiTechOrderManagementDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HiTechOrderManagementDB] SET  MULTI_USER 
GO
ALTER DATABASE [HiTechOrderManagementDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HiTechOrderManagementDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HiTechOrderManagementDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HiTechOrderManagementDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HiTechOrderManagementDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HiTechOrderManagementDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [HiTechOrderManagementDB] SET QUERY_STORE = OFF
GO
USE [HiTechOrderManagementDB]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 22-04-2024 16:44:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[AuthorId] [int] IDENTITY(88888,1) NOT NULL,
	[FirstName] [nchar](30) NOT NULL,
	[LastName] [nchar](30) NOT NULL,
	[Email] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED 
(
	[AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookAuthor]    Script Date: 22-04-2024 16:44:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookAuthor](
	[BookAuthorId] [int] IDENTITY(7171,1) NOT NULL,
	[AuthorId] [int] NOT NULL,
	[ISBN] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_BookAuthor] PRIMARY KEY CLUSTERED 
(
	[BookAuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookOrders]    Script Date: 22-04-2024 16:44:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookOrders](
	[BookOrderId] [int] IDENTITY(71717,1) NOT NULL,
	[ISBN] [nvarchar](15) NOT NULL,
	[OrderId] [int] NOT NULL,
 CONSTRAINT [PK_BookOrders] PRIMARY KEY CLUSTERED 
(
	[BookOrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 22-04-2024 16:44:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[ISBN] [nvarchar](15) NOT NULL,
	[BookTitle] [nchar](70) NOT NULL,
	[UnitPrice] [float] NOT NULL,
	[YearPublished] [int] NOT NULL,
	[QOH] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[PublisherId] [int] NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 22-04-2024 16:44:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] IDENTITY(2121,1) NOT NULL,
	[CategoryName] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 22-04-2024 16:44:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] IDENTITY(555,1) NOT NULL,
	[FirstName] [nchar](25) NOT NULL,
	[LastName] [nchar](25) NOT NULL,
	[Street] [nchar](50) NOT NULL,
	[City] [nchar](50) NOT NULL,
	[PostalCode] [nchar](7) NOT NULL,
	[PhoneNumber] [nchar](15) NOT NULL,
	[FaxNumber] [nchar](15) NOT NULL,
	[CreditLimit] [nchar](15) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 22-04-2024 16:44:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeId] [int] IDENTITY(11111,1) NOT NULL,
	[FirstName] [nchar](30) NOT NULL,
	[LastName] [nchar](30) NOT NULL,
	[PhoneNumber] [nchar](20) NOT NULL,
	[Email] [nchar](30) NOT NULL,
	[StatusId] [int] NOT NULL,
	[JobId] [int] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jobs]    Script Date: 22-04-2024 16:44:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jobs](
	[JobId] [int] IDENTITY(201,1) NOT NULL,
	[JobTitle] [nchar](30) NOT NULL,
	[Description] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Jobs] PRIMARY KEY CLUSTERED 
(
	[JobId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 22-04-2024 16:44:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [int] IDENTITY(9988,1) NOT NULL,
	[OrderType] [nvarchar](20) NOT NULL,
	[TotalAmount] [decimal](18, 0) NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[OrderStatus] [nvarchar](15) NOT NULL,
	[OrderQuantity] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publishers]    Script Date: 22-04-2024 16:44:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publishers](
	[PublisherId] [int] IDENTITY(9001,1) NOT NULL,
	[PublisherName] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Publishers] PRIMARY KEY CLUSTERED 
(
	[PublisherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 22-04-2024 16:44:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[StatusId] [int] IDENTITY(1001,1) NOT NULL,
	[State] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[StatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 22-04-2024 16:44:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(2222,1) NOT NULL,
	[Password] [nchar](20) NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[StatusId] [int] NOT NULL,
	[EmployeeId] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Authors] ON 

INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName], [Email]) VALUES (88888, N'Harsharan                     ', N'Kaur                          ', N'harsh22@gmail.com                                 ')
INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName], [Email]) VALUES (88889, N'John                          ', N'Geller                        ', N'john44@yahho.com                                  ')
SET IDENTITY_INSERT [dbo].[Authors] OFF
GO
SET IDENTITY_INSERT [dbo].[BookAuthor] ON 

INSERT [dbo].[BookAuthor] ([BookAuthorId], [AuthorId], [ISBN]) VALUES (7171, 88888, N'1-873-87652-8')
INSERT [dbo].[BookAuthor] ([BookAuthorId], [AuthorId], [ISBN]) VALUES (7172, 88889, N'1-873-87652-8')
SET IDENTITY_INSERT [dbo].[BookAuthor] OFF
GO
SET IDENTITY_INSERT [dbo].[BookOrders] ON 

INSERT [dbo].[BookOrders] ([BookOrderId], [ISBN], [OrderId]) VALUES (71717, N'1-873-87652-8', 9990)
INSERT [dbo].[BookOrders] ([BookOrderId], [ISBN], [OrderId]) VALUES (71718, N'1-873-87652-8', 9990)
SET IDENTITY_INSERT [dbo].[BookOrders] OFF
GO
INSERT [dbo].[Books] ([ISBN], [BookTitle], [UnitPrice], [YearPublished], [QOH], [CategoryId], [PublisherId]) VALUES (N'1-873-87652-8', N'Java Programming                                                      ', 30, 1999, 50, 2121, 9001)
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (2121, N'Computer Science                                  ')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (2122, N'Biology                                           ')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (2123, N'History                                           ')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (2124, N'Horror                                            ')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerId], [FirstName], [LastName], [Street], [City], [PostalCode], [PhoneNumber], [FaxNumber], [CreditLimit]) VALUES (555, N'Rohn                     ', N'Geller                   ', N'1763 Du Fort                                      ', N'Montreal                                          ', N'H2D 3S1', N'(438)332-1234  ', N'1-234-555-1254 ', N'$ 10000        ')
INSERT [dbo].[Customers] ([CustomerId], [FirstName], [LastName], [Street], [City], [PostalCode], [PhoneNumber], [FaxNumber], [CreditLimit]) VALUES (556, N'Henry                    ', N'Rao                      ', N'1224 St Catherene                                 ', N'Montreal                                          ', N'H5H 4B8', N'(438)123-7654  ', N'1-234-222-1234 ', N'$ 20000        ')
INSERT [dbo].[Customers] ([CustomerId], [FirstName], [LastName], [Street], [City], [PostalCode], [PhoneNumber], [FaxNumber], [CreditLimit]) VALUES (558, N'Marry                    ', N'Geller                   ', N'1233 Du Fort                                      ', N'Montreal                                          ', N'H3H 4B8', N'(436)654-1234  ', N'1-873-333-2334 ', N'$ 3546         ')
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [PhoneNumber], [Email], [StatusId], [JobId]) VALUES (11111, N'Harsharan                     ', N'kaur                          ', N'(438)753-1667       ', N'harsh23@gmail.com             ', 1002, 203)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [PhoneNumber], [Email], [StatusId], [JobId]) VALUES (11112, N'Henry                         ', N'Brown                         ', N'(438)888-1897       ', N'henrybrown25@yahoo.com        ', 1001, 204)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [PhoneNumber], [Email], [StatusId], [JobId]) VALUES (11113, N'Harpreet                      ', N'Kaur                          ', N'(438)123-1234       ', N'har22@gmail.com               ', 1002, 203)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [PhoneNumber], [Email], [StatusId], [JobId]) VALUES (11117, N'July                          ', N'Brown                         ', N'(438)333-9876       ', N'july44@gmail.com              ', 1002, 206)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [PhoneNumber], [Email], [StatusId], [JobId]) VALUES (11121, N'Thomas                        ', N'Moore                         ', N'(438)123-9988       ', N'thomas22@gmail.com            ', 1001, 206)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [PhoneNumber], [Email], [StatusId], [JobId]) VALUES (11122, N'Peter                         ', N'Wang                          ', N'(438)432-1928       ', N'peter33@gmail.com             ', 1001, 208)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [PhoneNumber], [Email], [StatusId], [JobId]) VALUES (11123, N'Mary                          ', N'Brown                         ', N'(438)765-1234       ', N'mary99@yahoo.com              ', 1001, 209)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [PhoneNumber], [Email], [StatusId], [JobId]) VALUES (11124, N'Jennifer                      ', N'Bouchard                      ', N'(438)812-7124       ', N'jennifer876@yahoo.com         ', 1001, 209)
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[Jobs] ON 

INSERT [dbo].[Jobs] ([JobId], [JobTitle], [Description]) VALUES (203, N'Assistant Manager             ', N'Assist the Manager                                ')
INSERT [dbo].[Jobs] ([JobId], [JobTitle], [Description]) VALUES (204, N'MIS Manager                   ', N'Maintain the Employee and User Data               ')
INSERT [dbo].[Jobs] ([JobId], [JobTitle], [Description]) VALUES (206, N'Sales Manager                 ', N'Maintain the Customer Records                     ')
INSERT [dbo].[Jobs] ([JobId], [JobTitle], [Description]) VALUES (208, N'Inventory Controller          ', N'Maintains the Inventory System                    ')
INSERT [dbo].[Jobs] ([JobId], [JobTitle], [Description]) VALUES (209, N'Order Clerk                   ', N'Maintans the Book Orders                          ')
SET IDENTITY_INSERT [dbo].[Jobs] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderId], [OrderType], [TotalAmount], [OrderDate], [OrderStatus], [OrderQuantity], [CustomerId]) VALUES (9990, N'Phone', CAST(500 AS Decimal(18, 0)), CAST(N'2024-04-20T13:25:31.000' AS DateTime), N'Shipped', 100, 555)
INSERT [dbo].[Orders] ([OrderId], [OrderType], [TotalAmount], [OrderDate], [OrderStatus], [OrderQuantity], [CustomerId]) VALUES (9991, N'Email', CAST(400 AS Decimal(18, 0)), CAST(N'2024-04-04T13:39:06.000' AS DateTime), N'Processing', 70, 556)
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Publishers] ON 

INSERT [dbo].[Publishers] ([PublisherId], [PublisherName]) VALUES (9001, N'Premier Press                                     ')
INSERT [dbo].[Publishers] ([PublisherId], [PublisherName]) VALUES (9002, N'Wrox                                              ')
INSERT [dbo].[Publishers] ([PublisherId], [PublisherName]) VALUES (9003, N'Murach                                            ')
INSERT [dbo].[Publishers] ([PublisherId], [PublisherName]) VALUES (9004, N'WWWR                                              ')
INSERT [dbo].[Publishers] ([PublisherId], [PublisherName]) VALUES (9006, N'XXXYZ                                             ')
SET IDENTITY_INSERT [dbo].[Publishers] OFF
GO
SET IDENTITY_INSERT [dbo].[Status] ON 

INSERT [dbo].[Status] ([StatusId], [State]) VALUES (1001, N'Active                                            ')
INSERT [dbo].[Status] ([StatusId], [State]) VALUES (1002, N'In-Active                                         ')
INSERT [dbo].[Status] ([StatusId], [State]) VALUES (1003, N'                                                  ')
SET IDENTITY_INSERT [dbo].[Status] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [Password], [DateCreated], [DateModified], [StatusId], [EmployeeId]) VALUES (2223, N'Thomas@22           ', CAST(N'2024-03-19T15:30:00.000' AS DateTime), CAST(N'2024-03-19T15:30:00.000' AS DateTime), 1001, 11121)
INSERT [dbo].[Users] ([UserId], [Password], [DateCreated], [DateModified], [StatusId], [EmployeeId]) VALUES (2225, N'Henry@25            ', CAST(N'2024-03-19T15:30:00.000' AS DateTime), CAST(N'2024-03-19T15:30:00.000' AS DateTime), 1001, 11112)
INSERT [dbo].[Users] ([UserId], [Password], [DateCreated], [DateModified], [StatusId], [EmployeeId]) VALUES (2235, N'Peter@33            ', CAST(N'2024-04-17T00:00:00.000' AS DateTime), CAST(N'2023-04-17T00:00:00.000' AS DateTime), 1001, 11122)
INSERT [dbo].[Users] ([UserId], [Password], [DateCreated], [DateModified], [StatusId], [EmployeeId]) VALUES (2237, N'MaryBrown@99        ', CAST(N'2024-04-17T00:00:00.000' AS DateTime), CAST(N'2024-04-17T00:00:00.000' AS DateTime), 1001, 11123)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[BookAuthor]  WITH CHECK ADD  CONSTRAINT [FK_BookAuthor_Authors] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[Authors] ([AuthorId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BookAuthor] CHECK CONSTRAINT [FK_BookAuthor_Authors]
GO
ALTER TABLE [dbo].[BookAuthor]  WITH CHECK ADD  CONSTRAINT [FK_BookAuthor_Books] FOREIGN KEY([ISBN])
REFERENCES [dbo].[Books] ([ISBN])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BookAuthor] CHECK CONSTRAINT [FK_BookAuthor_Books]
GO
ALTER TABLE [dbo].[BookOrders]  WITH CHECK ADD  CONSTRAINT [FK_BookOrders_Books] FOREIGN KEY([ISBN])
REFERENCES [dbo].[Books] ([ISBN])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BookOrders] CHECK CONSTRAINT [FK_BookOrders_Books]
GO
ALTER TABLE [dbo].[BookOrders]  WITH CHECK ADD  CONSTRAINT [FK_BookOrders_Orders] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([OrderId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BookOrders] CHECK CONSTRAINT [FK_BookOrders_Orders]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Categories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Categories]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Publishers] FOREIGN KEY([PublisherId])
REFERENCES [dbo].[Publishers] ([PublisherId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Publishers]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Jobs] FOREIGN KEY([JobId])
REFERENCES [dbo].[Jobs] ([JobId])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Jobs]
GO
ALTER TABLE [dbo].[Employees]  WITH NOCHECK ADD  CONSTRAINT [FK_Employees_Status] FOREIGN KEY([StatusId])
REFERENCES [dbo].[Status] ([StatusId])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Status]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Employees] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([EmployeeId])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Employees]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Status] FOREIGN KEY([StatusId])
REFERENCES [dbo].[Status] ([StatusId])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Status]
GO
USE [master]
GO
ALTER DATABASE [HiTechOrderManagementDB] SET  READ_WRITE 
GO
