USE [master]
GO
/****** Object:  Database [Facturacion]    Script Date: 11/6/2020 1:29:01 PM ******/
CREATE DATABASE [Facturacion]
 CONTAINMENT = NONE use  Facturacion
 ON  PRIMARY 
( NAME = N'Facturacion', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.DENIYYEL\MSSQL\DATA\Facturacion.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Facturacion_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.DENIYYEL\MSSQL\DATA\Facturacion_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Facturacion] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Facturacion].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Facturacion] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Facturacion] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Facturacion] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Facturacion] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Facturacion] SET ARITHABORT OFF 
GO
ALTER DATABASE [Facturacion] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Facturacion] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Facturacion] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Facturacion] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Facturacion] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Facturacion] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Facturacion] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Facturacion] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Facturacion] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Facturacion] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Facturacion] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Facturacion] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Facturacion] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Facturacion] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Facturacion] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Facturacion] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Facturacion] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Facturacion] SET RECOVERY FULL 
GO
ALTER DATABASE [Facturacion] SET  MULTI_USER 
GO
ALTER DATABASE [Facturacion] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Facturacion] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Facturacion] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Facturacion] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Facturacion] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Facturacion', N'ON'
GO
ALTER DATABASE [Facturacion] SET QUERY_STORE = OFF
GO
USE [Facturacion]
GO
/****** Object:  Table [dbo].[Articulos]    Script Date: 11/6/2020 1:29:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulos](
	[idArticulo] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](80) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[CostoUnitario] [numeric](8, 2) NOT NULL,
	[PrecioUnitario] [numeric](8, 2) NOT NULL,
	[Estado] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idArticulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 11/6/2020 1:29:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON 
CREATE TABLE [dbo].[Clientes](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[NombreComercial] [varchar](30) NOT NULL,
	[Cédula] [varchar](13) NOT NULL,
	[Estado] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CondicionPago]    Script Date: 11/6/2020 1:29:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CondicionPago](
	[IdCondicionPago] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](80) NOT NULL,
	[CantidadDias] [int] NOT NULL,
	[Estado] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCondicionPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 11/6/2020 1:29:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[IdFactura] [int] IDENTITY(1,1) NOT NULL,
	[FormaPago] [int] NOT NULL,
	[IdVendedores] [int] NOT NULL,
	[IdCliente] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Comentario] [varchar](60) NOT NULL,
	[idArticulo] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[PrecioUnitario] [numeric](8, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 11/6/2020 1:29:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Idusuario] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Contrasena] [varchar](50) NOT NULL,
	[Estado] [char](1) NOT NULL,
	[Rol] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Idusuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vendedores]    Script Date: 11/6/2020 1:29:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vendedores](
	[IdVendedores] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[PorcientoComision] [numeric](8, 2) NOT NULL,
	[Estado] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdVendedores] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Articulos] ON 

INSERT [dbo].[Articulos] ([idArticulo], [Descripcion], [Cantidad], [CostoUnitario], [PrecioUnitario], [Estado]) VALUES (2, N'Casco de bici', 15, CAST(1100.00 AS Numeric(8, 2)), CAST(1500.00 AS Numeric(8, 2)), N'Disponible')
INSERT [dbo].[Articulos] ([idArticulo], [Descripcion], [Cantidad], [CostoUnitario], [PrecioUnitario], [Estado]) VALUES (5, N'Samsung Galaxy S4', 40, CAST(10000.00 AS Numeric(8, 2)), CAST(12000.00 AS Numeric(8, 2)), N'Agotado')
SET IDENTITY_INSERT [dbo].[Articulos] OFF
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([IdCliente], [NombreComercial], [Cédula], [Estado]) VALUES (1, N'Daniel', N'000-0000000-0', N'Activo')
INSERT [dbo].[Clientes] ([IdCliente], [NombreComercial], [Cédula], [Estado]) VALUES (4, N'Felipe', N'000-0000000-0', N'Activo')
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[CondicionPago] ON 

INSERT [dbo].[CondicionPago] ([IdCondicionPago], [Descripcion], [CantidadDias], [Estado]) VALUES (1, N'Crédito', 10, N'Disponible')
INSERT [dbo].[CondicionPago] ([IdCondicionPago], [Descripcion], [CantidadDias], [Estado]) VALUES (4, N'Efectivo', 12, N'Disponible')
SET IDENTITY_INSERT [dbo].[CondicionPago] OFF
GO
INSERT [dbo].[Usuarios] ([Idusuario], [Nombre], [Contrasena], [Estado], [Rol]) VALUES (N'bmontano', N'Brayan Montaño', N'1f2a4ccb316d87da96a05b0f530ad880', N'L', N'Usuario')
INSERT [dbo].[Usuarios] ([Idusuario], [Nombre], [Contrasena], [Estado], [Rol]) VALUES (N'dhernandez', N'Daniel Hernandez', N'1f2a4ccb316d87da96a05b0f530ad880', N'A', N'Admin')
INSERT [dbo].[Usuarios] ([Idusuario], [Nombre], [Contrasena], [Estado], [Rol]) VALUES (N'epena', N'Emmanuel Peña', N'1f2a4ccb316d87da96a05b0f530ad880', N'A', N'Usuario')
INSERT [dbo].[Usuarios] ([Idusuario], [Nombre], [Contrasena], [Estado], [Rol]) VALUES (N'kmartinez', N'Katherine Martinez', N'1f2a4ccb316d87da96a05b0f530ad880', N'I', N'Usuario')
INSERT [dbo].[Usuarios] ([Idusuario], [Nombre], [Contrasena], [Estado], [Rol]) VALUES ('Admin', 'JP', '5058f1af8388633f609cadb75a75dc9d', 'A', 'Admin')
GO
SET IDENTITY_INSERT [dbo].[vendedores] ON 

INSERT [dbo].[vendedores] ([IdVendedores], [Nombre], [PorcientoComision], [Estado]) VALUES (3, N'Daniel', CAST(15.00 AS Numeric(8, 2)), N'Activo')
SET IDENTITY_INSERT [dbo].[vendedores] OFF
GO
ALTER TABLE [dbo].[Articulos] ADD  DEFAULT ((0)) FOR [CostoUnitario]
GO
ALTER TABLE [dbo].[Articulos] ADD  DEFAULT ((0)) FOR [PrecioUnitario]
GO
ALTER TABLE [dbo].[Factura] ADD  DEFAULT ((0)) FOR [PrecioUnitario]
GO
ALTER TABLE [dbo].[vendedores] ADD  DEFAULT ((0)) FOR [PorcientoComision]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD FOREIGN KEY([FormaPago])
REFERENCES [dbo].[CondicionPago] ([IdCondicionPago])
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD FOREIGN KEY([idArticulo])
REFERENCES [dbo].[Articulos] ([idArticulo])
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Clientes] ([IdCliente])
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD FOREIGN KEY([IdVendedores])
REFERENCES [dbo].[vendedores] ([IdVendedores])
GO
USE [master]
GO
ALTER DATABASE [Facturacion] SET  READ_WRITE 
select * from usuarios

drop database Facturacion