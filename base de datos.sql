USE [master]
GO
/****** Object:  Database [cafecito]    Script Date: 29/10/2023 13:55:19 ******/
CREATE DATABASE [cafecito]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'cafecito', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\cafecito.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'cafecito_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\cafecito_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [cafecito] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [cafecito].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [cafecito] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [cafecito] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [cafecito] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [cafecito] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [cafecito] SET ARITHABORT OFF 
GO
ALTER DATABASE [cafecito] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [cafecito] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [cafecito] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [cafecito] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [cafecito] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [cafecito] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [cafecito] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [cafecito] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [cafecito] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [cafecito] SET  ENABLE_BROKER 
GO
ALTER DATABASE [cafecito] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [cafecito] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [cafecito] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [cafecito] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [cafecito] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [cafecito] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [cafecito] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [cafecito] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [cafecito] SET  MULTI_USER 
GO
ALTER DATABASE [cafecito] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [cafecito] SET DB_CHAINING OFF 
GO
ALTER DATABASE [cafecito] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [cafecito] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [cafecito] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [cafecito] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [cafecito] SET QUERY_STORE = OFF
GO
USE [cafecito]
GO
/****** Object:  User [vendedor]    Script Date: 29/10/2023 13:55:19 ******/
CREATE USER [vendedor] FOR LOGIN [vendedor] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [administrador]    Script Date: 29/10/2023 13:55:19 ******/
CREATE USER [administrador] FOR LOGIN [administrador] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [administrador]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [administrador]
GO
/****** Object:  Table [dbo].[bebidas]    Script Date: 29/10/2023 13:55:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bebidas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](255) NOT NULL,
	[Precio] [decimal](10, 2) NOT NULL,
	[ID_Cafes] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipos_de_cafe]    Script Date: 29/10/2023 13:55:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipos_de_cafe](
	[ID_Cafe] [int] IDENTITY(1,1) NOT NULL,
	[Cuerpo] [varchar](50) NOT NULL,
	[Aroma] [varchar](50) NOT NULL,
	[Acidez] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Cafe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 29/10/2023 13:55:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[ID] [int] NOT NULL,
	[usuario] [varchar](255) NOT NULL,
	[password] [numeric](4, 0) NOT NULL,
	[rol] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ventas]    Script Date: 29/10/2023 13:55:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ventas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Bebida] [int] NOT NULL,
	[ID_TipoCafe] [int] NOT NULL,
	[FechaVenta] [datetime] NOT NULL,
	[PrecioTotal] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[bebidas] ON 

INSERT [dbo].[bebidas] ([ID], [Nombre], [Precio], [ID_Cafes]) VALUES (1, N'Moka', CAST(20.99 AS Decimal(10, 2)), 1)
INSERT [dbo].[bebidas] ([ID], [Nombre], [Precio], [ID_Cafes]) VALUES (2, N'Latte', CAST(35.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[bebidas] ([ID], [Nombre], [Precio], [ID_Cafes]) VALUES (3, N'Americano', CAST(40.00 AS Decimal(10, 2)), 3)
SET IDENTITY_INSERT [dbo].[bebidas] OFF
GO
SET IDENTITY_INSERT [dbo].[tipos_de_cafe] ON 

INSERT [dbo].[tipos_de_cafe] ([ID_Cafe], [Cuerpo], [Aroma], [Acidez]) VALUES (1, N'Cuerpo 1', N'Aroma 1', N'Acidez 1')
INSERT [dbo].[tipos_de_cafe] ([ID_Cafe], [Cuerpo], [Aroma], [Acidez]) VALUES (2, N'Cuerpo 2', N'Aroma 2', N'Acidez 2')
INSERT [dbo].[tipos_de_cafe] ([ID_Cafe], [Cuerpo], [Aroma], [Acidez]) VALUES (3, N'Cuerpo 3', N'Aroma 3', N'Acidez 3')
SET IDENTITY_INSERT [dbo].[tipos_de_cafe] OFF
GO
INSERT [dbo].[usuarios] ([ID], [usuario], [password], [rol]) VALUES (1, N'usuario1', CAST(1234 AS Numeric(4, 0)), N'Cliente')
INSERT [dbo].[usuarios] ([ID], [usuario], [password], [rol]) VALUES (2, N'usuario2', CAST(5678 AS Numeric(4, 0)), N'Cliente')
INSERT [dbo].[usuarios] ([ID], [usuario], [password], [rol]) VALUES (3, N'admin', CAST(0 AS Numeric(4, 0)), N'Administrador')
GO
SET IDENTITY_INSERT [dbo].[ventas] ON 

INSERT [dbo].[ventas] ([ID], [ID_Bebida], [ID_TipoCafe], [FechaVenta], [PrecioTotal]) VALUES (22, 1, 1, CAST(N'2023-10-29T13:05:04.567' AS DateTime), CAST(20.99 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[ventas] OFF
GO
ALTER TABLE [dbo].[bebidas]  WITH CHECK ADD  CONSTRAINT [FK_Bebidas_TiposDeCafe] FOREIGN KEY([ID_Cafes])
REFERENCES [dbo].[tipos_de_cafe] ([ID_Cafe])
GO
ALTER TABLE [dbo].[bebidas] CHECK CONSTRAINT [FK_Bebidas_TiposDeCafe]
GO
ALTER TABLE [dbo].[ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Bebidas] FOREIGN KEY([ID_Bebida])
REFERENCES [dbo].[bebidas] ([ID])
GO
ALTER TABLE [dbo].[ventas] CHECK CONSTRAINT [FK_Ventas_Bebidas]
GO
ALTER TABLE [dbo].[ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_TiposDeCafe] FOREIGN KEY([ID_TipoCafe])
REFERENCES [dbo].[tipos_de_cafe] ([ID_Cafe])
GO
ALTER TABLE [dbo].[ventas] CHECK CONSTRAINT [FK_Ventas_TiposDeCafe]
GO
/****** Object:  StoredProcedure [dbo].[VerificarCredenciales]    Script Date: 29/10/2023 13:55:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VerificarCredenciales]
    @NombreUsuario VARCHAR(50),
    @Contraseña numeric(4),
    @Rol VARCHAR(50) OUTPUT
AS
BEGIN
    DECLARE @UsuarioID INT

    SELECT @UsuarioID = ID, @Rol = rol
    FROM Usuarios
    WHERE usuario = @NombreUsuario AND password = @Contraseña

    IF @UsuarioID IS NOT NULL
    BEGIN
        -- Inicio de sesión exitoso
        SELECT 'Inicio de sesión exitoso' AS Mensaje
    END
    ELSE
    BEGIN
        -- Inicio de sesión fallido
        SELECT 'Inicio de sesión fallido' AS Mensaje
    END
END
GO
USE [master]
GO
ALTER DATABASE [cafecito] SET  READ_WRITE 
GO
