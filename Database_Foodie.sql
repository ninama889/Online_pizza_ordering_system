CREATE DATABASE FoodieDB

USE FoodieDB

CREATE TABLE [Users](
	[UserId] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Email] [varchar] (50) NULL UNIQUE,
	[Password] [varchar] (50) NULL,
	[Mobile] [varchar] (50) NULL,
	[Address] [varchar](max) NULL,
	[CreatedDate] [datetime] NULL
)

CREATE TABLE [Contact](
	[ContactId] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Subject] [varchar](50) NULL,
	[Message] [varchar](max) NULL,
	[CreatedDate] [datetime] NULL
)

CREATE TABLE [Categories](
	[CategoryId] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[ImageUrl] [varchar] (max) NULL,
	[IsActive] [bit] NULL,
	[CreatedDate] [datetime] NULL
)

CREATE TABLE [Products](
	[ProductId] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Description] [varchar] (max) NULL,
	[Price] [decimal] (18,2) NULL,
	[Quantity][int] NULL,
	[ImageUrl] [varchar] (max) NULL,
	[CategoryId] [int] NULL, --FK
	[IsActive] [bit] NULL,
	[CreatedDate] [datetime] NULL
)

CREATE TABLE [Carts](
	[CartId] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL, --FK
	[Quantity] [int] NULL,
	[UserId] [int] NULL, --FK
)

CREATE TABLE [Orders](
	[OrderDetailsId] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[OrderNo][varchar](max) NULL,
	[ProductId] [int] NULL, --FK
	[Quantity] [int] NULL,
	[UserId] [int] NULL, --FK
	[Status] [varchar](50) NULL,
	[PaymentId][int] NULL , --FK
	[OrderDate] [datetime] NULL,
)
CREATE TABLE [Payment](
	[PaymentId] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Name][varchar](50) NULL,
	[CardNo] [varchar](50) NULL,
	[ExpiryDate] [varchar](50) NULL,
	[CVVNo] [int] NULL, 
	[Address] [varchar](max) NULL,
	[PaymentMode][varchar](50) NULL ,
)