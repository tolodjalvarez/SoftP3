USE [master]
GO
/****** Object:  Database [SoftPT3]    Script Date: 27/2/2016 10:59:15 a. m. ******/
CREATE DATABASE [SoftPT3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SoftPT3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\SoftPT3.mdf' , SIZE = 6144KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SoftPT3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\SoftPT3_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SoftPT3] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SoftPT3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SoftPT3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SoftPT3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SoftPT3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SoftPT3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SoftPT3] SET ARITHABORT OFF 
GO
ALTER DATABASE [SoftPT3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SoftPT3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SoftPT3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SoftPT3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SoftPT3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SoftPT3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SoftPT3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SoftPT3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SoftPT3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SoftPT3] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SoftPT3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SoftPT3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SoftPT3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SoftPT3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SoftPT3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SoftPT3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SoftPT3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SoftPT3] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SoftPT3] SET  MULTI_USER 
GO
ALTER DATABASE [SoftPT3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SoftPT3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SoftPT3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SoftPT3] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [SoftPT3] SET DELAYED_DURABILITY = DISABLED 
GO
USE [SoftPT3]
GO
/****** Object:  Table [dbo].[Articulos]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Articulos](
	[CodArt] [int] IDENTITY(1,1) NOT NULL,
	[DescArt] [varchar](100) NOT NULL,
	[PrecioVenta] [decimal](18, 2) NOT NULL,
	[Existencia] [int] NOT NULL,
	[Entrada] [int] NOT NULL,
	[Salida] [int] NOT NULL,
	[IdCategoria] [int] NOT NULL,
	[Ubicacion] [varchar](100) NOT NULL,
	[Maximo] [int] NOT NULL,
	[Minimo] [int] NOT NULL,
	[CostUnitario] [decimal](18, 2) NOT NULL,
	[Proveedor] [int] NOT NULL,
 CONSTRAINT [PK_Articulos] PRIMARY KEY CLUSTERED 
(
	[CodArt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categoria](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[IdClient] [int] IDENTITY(1,1) NOT NULL,
	[NombCliente] [varchar](100) NOT NULL,
	[ApelliCliente] [varchar](100) NOT NULL,
	[Telefono] [varchar](100) NULL,
	[Celular] [varchar](100) NOT NULL,
	[Email] [varchar](100) NULL,
	[Cedula] [varchar](100) NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
	[Nacionalidad] [varchar](100) NOT NULL,
	[RNC] [varchar](100) NULL,
	[Fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[IdClient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Compania]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Compania](
	[IdComp] [int] IDENTITY(1,1) NOT NULL,
	[NombComp] [varchar](100) NOT NULL,
	[RNC] [varchar](100) NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
	[Telefono] [varchar](100) NOT NULL,
	[WebSite] [varchar](100) NOT NULL,
	[Pais] [varchar](100) NOT NULL,
	[NCF] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Compania] PRIMARY KEY CLUSTERED 
(
	[IdComp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CXC]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CXC](
	[IdCuenta] [int] IDENTITY(1,1) NOT NULL,
	[NombCliente] [varchar](100) NOT NULL,
	[Cedula] [varchar](100) NOT NULL,
	[RNC] [varchar](100) NULL,
	[NCF] [varchar](100) NULL,
	[Telefono] [varchar](100) NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
	[CodArt] [int] NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Precio] [decimal](18, 2) NOT NULL,
	[MontPendiente] [decimal](18, 2) NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
	[FechActual] [datetime] NOT NULL,
	[FechLimite] [datetime] NOT NULL,
	[Descuento] [decimal](18, 2) NOT NULL,
	[ITBIS] [decimal](18, 2) NOT NULL,
	[Impuesto] [decimal](18, 2) NOT NULL,
	[Existencia] [int] NOT NULL,
	[IdCliente] [int] NOT NULL,
	[Usuario] [varchar](100) NOT NULL,
	[MontPagado] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_CXC] PRIMARY KEY CLUSTERED 
(
	[IdCuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CXP]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CXP](
	[IdRegistro] [int] IDENTITY(1,1) NOT NULL,
	[IdProveedor] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Compania] [varchar](100) NOT NULL,
	[NCF] [varchar](100) NOT NULL,
	[Telefono] [varchar](100) NOT NULL,
	[CodArt] [int] NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[FechLimite] [date] NOT NULL,
	[MontPagado] [decimal](18, 2) NOT NULL,
	[MontPendiente] [decimal](18, 2) NOT NULL,
	[FechActual] [datetime] NOT NULL,
	[Usuario] [varchar](100) NOT NULL,
 CONSTRAINT [PK_CXP_1] PRIMARY KEY CLUSTERED 
(
	[IdRegistro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleado](
	[CodEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[NombEmpleado] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[CodEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Factura](
	[NoFactura] [int] IDENTITY(1,1) NOT NULL,
	[FechActual] [datetime] NOT NULL,
	[Cliente] [varchar](50) NOT NULL,
	[CodArt] [int] NOT NULL,
	[DescArt] [varchar](100) NOT NULL,
	[Precio] [decimal](18, 2) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[SubTotal] [decimal](18, 2) NOT NULL,
	[Impuesto] [decimal](18, 2) NOT NULL,
	[Descuento] [decimal](18, 2) NOT NULL,
	[TotalFacturado] [decimal](18, 2) NOT NULL,
	[IdComp] [int] NOT NULL,
	[CodEmp] [int] NOT NULL,
	[TipoDePago] [varchar](100) NOT NULL,
	[Monto] [decimal](18, 2) NOT NULL,
	[Cambio] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[NoFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FacturaVenta]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FacturaVenta](
	[NoFactura] [int] IDENTITY(1,1) NOT NULL,
	[CodCliente] [int] NULL,
	[CodProducto] [int] NOT NULL,
	[PrecioUnitario] [decimal](18, 2) NOT NULL,
	[TipoPago] [varchar](100) NULL,
	[Cantidad] [int] NOT NULL,
	[Descuento] [decimal](18, 2) NOT NULL,
	[ITBIS] [decimal](18, 2) NOT NULL,
	[SubTotal] [decimal](18, 2) NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
	[Cambio] [decimal](18, 2) NULL,
	[Fecha] [datetime] NOT NULL,
	[Impuesto] [decimal](18, 2) NOT NULL,
	[Efectivo] [decimal](18, 2) NULL,
	[RNC] [varchar](100) NOT NULL,
	[NCF] [varchar](100) NOT NULL,
	[Existencia] [int] NOT NULL,
	[CodEmpleado] [int] NOT NULL,
 CONSTRAINT [PK_FacturaVenta] PRIMARY KEY CLUSTERED 
(
	[NoFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proveedor](
	[IdProveedor] [int] IDENTITY(1,1) NOT NULL,
	[NombProveedor] [varchar](100) NOT NULL,
	[Telefono] [varchar](100) NOT NULL,
	[RNC] [varchar](100) NOT NULL,
	[Pais] [varchar](100) NOT NULL,
	[Ciudad] [varchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Proveedor_1] PRIMARY KEY CLUSTERED 
(
	[IdProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Apellido] [varchar](100) NOT NULL,
	[Cedula] [varchar](100) NULL,
	[Direccion] [varchar](100) NULL,
	[Telefono] [varchar](100) NULL,
	[Usuario] [varchar](100) NULL,
	[Password] [varchar](100) NOT NULL,
	[Tipo] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Articulos]  WITH CHECK ADD  CONSTRAINT [FK_Articulos_Proveedor] FOREIGN KEY([Proveedor])
REFERENCES [dbo].[Proveedor] ([IdProveedor])
GO
ALTER TABLE [dbo].[Articulos] CHECK CONSTRAINT [FK_Articulos_Proveedor]
GO
ALTER TABLE [dbo].[Articulos]  WITH CHECK ADD  CONSTRAINT [FK_IdCategoria] FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[Categoria] ([Id])
GO
ALTER TABLE [dbo].[Articulos] CHECK CONSTRAINT [FK_IdCategoria]
GO
ALTER TABLE [dbo].[FacturaVenta]  WITH CHECK ADD  CONSTRAINT [fk_CodCliente] FOREIGN KEY([CodCliente])
REFERENCES [dbo].[Clientes] ([IdClient])
GO
ALTER TABLE [dbo].[FacturaVenta] CHECK CONSTRAINT [fk_CodCliente]
GO
ALTER TABLE [dbo].[FacturaVenta]  WITH CHECK ADD  CONSTRAINT [fk_CodEmpleado] FOREIGN KEY([CodEmpleado])
REFERENCES [dbo].[Empleado] ([CodEmpleado])
GO
ALTER TABLE [dbo].[FacturaVenta] CHECK CONSTRAINT [fk_CodEmpleado]
GO
ALTER TABLE [dbo].[FacturaVenta]  WITH CHECK ADD  CONSTRAINT [fk_CodProducto] FOREIGN KEY([CodProducto])
REFERENCES [dbo].[Articulos] ([CodArt])
GO
ALTER TABLE [dbo].[FacturaVenta] CHECK CONSTRAINT [fk_CodProducto]
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FArticulo_Actualizar]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FArticulo_Actualizar]
	@CodArt int,
	@DescArt varchar(100),
	@PrecioVenta decimal (18,2),
	@PrecioCompra decimal(18,2),
	@Existencia int,
	@Entrada int,
	@Salida int,
	@IdCategoria int,
	@Ubacacion varchar(100),
	@DescCategoria varchar(100),
	@CostUnitario decimal(18,2),
	@Maximo int,
	@Minimo int


	
AS
BEGIN
 update Articulos set  DescArt= @DescArt, PrecioVenta=@PrecioVenta, Existencia=@Existencia, Entrada=@Entrada, Salida=@Salida, 
        IdCategoria=@IdCategoria, @DescCategoria=@DescCategoria, Ubicacion=@Ubacacion, Maximo=@Maximo, Minimo=@Minimo, 
		CostUnitario=@CostUnitario
		
		 where CodArt=@CodArt
 select @@ROWCOUNT as CantidadAfectada
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FArticulo_All]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Data_FArticulo_All]
AS
BEGIN
	select    Articulos.CodArt as CodArticulo, Articulos.DescArt as DescripcionArt,
	          Articulos.PrecioVenta, Articulos.Existencia, 
	          Articulos.Entrada,     Articulos.Salida, Articulos.IdCategoria,
			  Articulos.Ubicacion,    Articulos.Maximo, Articulos.Minimo, Articulos.CostUnitario

		FROM	  Categoria INNER JOIN
		       Articulos ON Categoria.Id = Articulos.IdCategoria

			 

				 
END



GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FArticulo_Borrar]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FArticulo_Borrar] 
	

	@CodArt int
	
AS
BEGIN
 delete from Articulos where CodArt=@CodArt
 select @@ROWCOUNT as CantidadAfectada
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FArticulo_Insert]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FArticulo_Insert]
	(
	  @IdCategoria int,
	  @DescArt varchar(50),
	  @PrecioVenta decimal(18,2),
	  @Existencia int,
	  @Entrada int,
	  @Salida int,
	  @Ubicacion varchar (500),
	  @Maximo int,
	  @Minimo int,
	  @CostUnitario decimal(18,2)
	 

	)
AS

insert into Articulos (IdCategoria,DescArt,PrecioVenta,Existencia, Entrada,Salida,
            Ubicacion,Maximo,Minimo, CostUnitario)

values (@IdCategoria,@DescArt,@PrecioVenta,@Existencia, @Entrada,@Salida,
           @Ubicacion,@Maximo,@Minimo, @CostUnitario)

Select @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FCategoria_Actualizar]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE  [dbo].[usp_Data_FCategoria_Actualizar]
	
	(
@Id int,
@Descripcion varchar (100)

)
As

update Categoria set Descripcion=@Descripcion where Id = @Id
select @@ROWCOUNT as cantidad
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FCategoria_Borrar]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Data_FCategoria_Borrar]

@Id int
AS
BEGIN
	delete from Categoria where Id=@Id
	select @@ROWCOUNT as CantidadAfectada
END
	

GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FCategoria_GetAll]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Data_FCategoria_GetAll]
AS
BEGIN
	select Id, Descripcion from Categoria

   
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FCategoria_Insert]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Data_FCategoria_Insert]

(
@Descripcion varchar (100)

)
As
insert into Categoria (Descripcion) values (@Descripcion)
select @@IDENTITY
	

GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FCliente_Actualizar]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Data_FCliente_Actualizar]
	
	(
@IdClient int,
@NombCliente varchar (100),
@ApelliCliente varchar (100),
@RNC varchar (100),
@Telefono varchar (100),
@Celular varchar (100),
@Email varchar (100),
@Cedula varchar (100),
@Direccion varchar(100),
@Nacionalidad varchar(100),
@Fecha DateTime
)
As

update Clientes set NombCliente=@NombCliente,ApelliCliente=@ApelliCliente,RNC=@RNC, Telefono =@Telefono,Celular=@Celular,Email=@Email,Cedula=@Cedula,
Direccion=@Direccion,Nacionalidad=@Nacionalidad, Fecha=@Fecha where IdClient = @IdClient
select @@ROWCOUNT as cantidad
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FCliente_Borrar]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Data_FCliente_Borrar]
	@IdClient int
AS
BEGIN
	delete from Clientes where IdClient=@IdClient
	select @@ROWCOUNT as CantidadAfectada
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FCliente_GetTodo]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Data_FCliente_GetTodo]

	AS
BEGIN
	select IdClient, NombCliente, ApelliCliente,RNC, Telefono, Celular, Email, Cedula, Direccion, Nacionalidad, Fecha
	 from Clientes

   
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FCliente_Insert]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FCliente_Insert]

(
@NombCliente varchar (100),
@ApelliCliente varchar (100),
@RNC varchar (100),
@Telefono varchar (100),
@Celular varchar (100),
@Email varchar (100),
@Cedula varchar (100),
@Direccion varchar(100),
@Nacionalidad varchar(100),
@Fecha datetime
)
As
insert into Clientes ( NombCliente, ApelliCliente,RNC, Telefono, Celular, Email, Cedula, Direccion, Nacionalidad, Fecha)
	values (@NombCliente, @ApelliCliente, @RNC, @Telefono, @Celular, @Email, @Cedula, @Direccion, @Nacionalidad, @Fecha)
select @@IDENTITY

GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FCompania_Borrar]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FCompania_Borrar] 
	
	@IdComp int
AS
BEGIN
	delete from Compania where IdComp=@IdComp
	select @@ROWCOUNT as CantidadAfectada
END

GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FCompania_GetTodo]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FCompania_GetTodo]

	AS
BEGIN
select IdComp, NombComp, RNC, Direccion, Telefono, WebSite, Pais, NCF from Compania
END


GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FCompania_Insert]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FCompania_Insert]
	(
@NombComp varchar (100),
@RNC varchar (100),
@Direccion varchar (100), 
@Telefono varchar (100),
@WebSite varchar (100),
@Pais varchar (100),
@NCF varchar (100)
)
As
insert into Compania(NombComp, RNC, Direccion, Telefono, WebSite, Pais,NCF) values (@NombComp,@RNC,@Direccion,@Telefono,@WebSite,@Pais,@NCF)
select @@IDENTITY

GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FCxC_Actualizar]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FCxC_Actualizar]

(
@Existencia int,
@Salida int,
@CodArt int
)
As

update Articulos set Existencia=@Existencia,Salida=@Salida where CodArt = @CodArt
select @@ROWCOUNT as cantidad


GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FCxC_All]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FCxC_All]
	
	AS
BEGIN
	select IdCuenta, NombCliente, Cedula, RNC, Telefono, Direccion, CodArt, Cantidad, Precio, FechLimite,
	 MontPagado, MontPendiente, Total, FechActual from CxC

   
END

GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FCxC_Borrar]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FCxC_Borrar]

@IdCuenta int
AS
BEGIN
	delete from CxC where IdCuenta=@IdCuenta
	select @@ROWCOUNT as CantidadAfectada
END



GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FCxC_Insert]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FCxC_Insert]
	
	(
@NombCliente varchar (100),
@Cedula varchar (100),
@RNC varchar (100),
@Telefono varchar (100),
@Direccion varchar(100),
@CodArt int,
@Cantidad int,
@Precio decimal(18,2),
@FechLimite Date,
@MontPagado decimal(18,2),
@MontPendiente decimal (18,2),
@Total decimal (18,2),
@FechActual datetime
)
As
insert into CxC( NombCliente,Cedula, RNC, Telefono,Direccion,CodArt, 
                 Cantidad, Precio, FechLimite, MontPagado, MontPendiente, Total, FechActual)
	values (@NombCliente,@Cedula, @RNC, @Telefono,@Direccion, @CodArt, @Cantidad,@Precio, @FechLimite, @MontPagado, @MontPendiente, @Total, @FechActual)
	select @@IDENTITY

GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FCxP_Actualizar]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FCxP_Actualizar]

(
@IdProveedor varchar(50),
@Compania varchar (100),
@NCF varchar (100),
@Telefono varchar (100),
@Descripcion varchar(100),
@Cantidad int,
@FechLimite Date,
@MontPagado decimal(18,2),
@MontPendiente decimal (18,2),
@FechActual datetime
)
As

update CxP set Compania=@Compania,NCF=@NCF, Telefono =@Telefono,
Descripcion=@Descripcion, Cantidad=@Cantidad, FechLimite=@FechLimite, MontPagado=@MontPagado,MontPendiente=@MontPendiente,FechActual=@FechActual where IdProveedor = @IdProveedor
select @@ROWCOUNT as cantidad


GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FCxP_All]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_Data_FCxP_All]

AS
BEGIN
	select IdRegistro, IdProveedor, Nombre, Compania, NCF, Telefono, CodArt, Descripcion, Cantidad, FechLimite, MontPagado, MontPendiente, FechActual, Usuario from CxP

   
END

GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FCxP_Borrar]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FCxP_Borrar]

@IdProveedor varchar(50)
AS
BEGIN
	delete from CxP where IdProveedor=@IdProveedor
	select @@ROWCOUNT as CantidadAfectada
END


GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FCxP_Insert]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FCxP_Insert]

(
@Compania varchar (100),
@NCF varchar (100),
@Telefono varchar (100),
@IdProveedor int,
@Descripcion varchar(100),
@Nombre varchar(100),
@Cantidad int,
@FechLimite Date,
@MontPagado decimal(18,2),
@MontPendiente decimal (18,2),
@CodArt int,
@FechActual datetime,
@Usuario varchar(100)
)
As
insert into CxP(IdProveedor, Nombre, Compania, NCF, Telefono, CodArt, Descripcion, Cantidad, FechLimite, MontPagado, MontPendiente, FechActual, Usuario )
	values (@IdProveedor,@Nombre, @Compania, @NCF,@Telefono, @CodArt, @Descripcion,@Cantidad, @FechLimite,@MontPagado, @MontPendiente,  @FechActual, @Usuario)
	select @@IDENTITY

GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FEmpleado_Actualizar]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FEmpleado_Actualizar]

(
@CodEmpleado int,
@Nombre varchar (100)

)
As

update Empleado set Nombre=@Nombre where CodEmpleado = @CodEmpleado
select @@ROWCOUNT as cantidad


GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FEmpleado_Borrar]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FEmpleado_Borrar]

	@CodEmpleado int
AS
BEGIN
	delete from Empleado where CodEmpleado=@CodEmpleado
	select @@ROWCOUNT as CantidadAfectada
END


GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FEmpleado_GetAll]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FEmpleado_GetAll]

AS
BEGIN
	select CodEmpleado, Nombre from Empleado

   
END



GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FEmpleado_Insert]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FEmpleado_Insert]

(
@Nombre varchar (100)

)
As
insert into Empleado(Nombre) values (@Nombre)
select @@IDENTITY

GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FFactura_Actualizar]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FFactura_Actualizar]

@NoFactura int,
@FechActual DateTime,
@Cliente varchar(100), 
@CodArt int, 
@DescArt varchar (100), 
@Precio decimal(18,2), 
@Cantidad int, 
@SubTotal decimal (18,2), 
@Impuesto decimal (18,2), 
@Descuento decimal (18,2), 
@TotalFacturado decimal(18,2), 
@IdComp int, 
@CodEmp varchar(100),
@TipoDePago varchar (100),
@Monto decimal(18,2),
@Cambio decimal(18,2)
AS
BEGIN
	update Factura set FechActual=@FechActual, Cliente = @Cliente, CodArt =@CodArt, DescArt =@DescArt, 
	Precio =@Precio, Cantidad=@Cantidad , SubTotal = @SubTotal, Impuesto =@Impuesto, Descuento =@Descuento,
	 TotalFacturado = @TotalFacturado, IdComp = @IdComp, CodEmp= @CodEmp, TipoDePago=@TipoDePago, Monto = @Monto,
	Cambio = @Cambio
	where NoFactura = @NoFactura
	
	select @@ROWCOUNT as CantidadAfectada
END


GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FFactura_Borrar]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FFactura_Borrar]

@NoFactura int

AS
BEGIN
	delete from Factura where NoFactura= @NoFactura
	select @@ROWCOUNT as CantidadAfectada
END


GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FFactura_GetTodo]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FFactura_GetTodo]

AS
BEGIN
	SELECT        dbo.Factura.NoFactura, dbo.Factura.IdComp, dbo.Compania.NombComp, dbo.Factura.FechActual, dbo.Factura.CodEmp, 
	              dbo.Compania.RNC, dbo.Compania.Telefono, dbo.Compania.WebSite, dbo.Compania.NCF, dbo.Factura.Cliente, 
                  dbo.Factura.CodArt, dbo.Factura.DescArt, dbo.Factura.Precio, dbo.Factura.Cantidad, dbo.Factura.SubTotal,
			      dbo.Factura.Impuesto, dbo.Factura.Descuento, dbo.Factura.TotalFacturado, dbo.Factura.TipoDePago,
				  dbo.Factura.Monto, dbo.Factura.Cambio

FROM            dbo.Compania INNER JOIN
                         dbo.Factura ON dbo.Compania.IdComp = dbo.Factura.IdComp
END


GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FFactura_Insert]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FFactura_Insert]

@FechActual DateTime,
@Cliente varchar(100), 
@CodArt int, 
@DescArt varchar (100), 
@Precio decimal(18,2), 
@Cantidad int, 
@SubTotal decimal (18,2), 
@Impuesto decimal (18,2), 
@Descuento decimal (18,2), 
@TotalFacturado decimal(18,2), 
@IdComp int, 
@CodEmp int,
@TipoDePago varchar(100),
@Monto decimal (18,2),
@Cambio decimal(18,2)
AS
BEGIN
	insert into Factura (FechActual, Cliente, CodArt, DescArt, Precio, Cantidad, SubTotal, Impuesto, Descuento,
	 TotalFacturado, IdComp, CodEmp, TipoDePago, Monto,Cambio)

	values (@FechActual, @Cliente, @CodArt, @DescArt, @Precio, @Cantidad, @SubTotal, @Impuesto, @Descuento, 
	@TotalFacturado, @IdComp, @CodEmp, @TipoDePago, @Monto, @Cambio )
	
	select @@IDENTITY
END

GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FFacturaVenta_Actualizar]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FFacturaVenta_Actualizar]


@CodProducto int,
@Salida int,
@Existencia int


AS
BEGIN
	update Articulos set Existencia = @Existencia, Salida = @Salida
	where CodArt =@CodProducto
	
	select @@ROWCOUNT as CantidadAfectada
END

GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FFacturaVenta_Borrar]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FFacturaVenta_Borrar]

@NoFactura int

AS
BEGIN
	delete from FacturaVenta where NoFactura= @NoFactura
	select @@ROWCOUNT as CantidadAfectada
END


GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FFacturaVenta_GetTodo]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FFacturaVenta_GetTodo]

AS
BEGIN
	SELECT     Fecha, NombCliente, CodCliente, CodProducto , DescProducto, 
	PrecioUnitario , Cantidad, SubTotal , Impuesto , Descuento,
	 Total , ITBIS , Efectivo, TipoPago, NombEmpleado , RNC, NCF, 
	Cambio, Existencia  

FROM           FacturaVenta
                        
END

GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FFacturaVenta_Insert]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FFacturaVenta_Insert]

@NoFactura int,
@Fecha DateTime,
@NombCliente varchar(100), 
@CodCliente int, 
@CedCliente varchar(100),
@CodProducto int,
@DescProducto varchar(100),
@PrecioUnitario decimal(18,2), 
@Cantidad int, 
@SubTotal decimal (18,2), 
@Impuesto decimal (18,2), 
@Descuento decimal (18,2), 
@ITBIS decimal(18,2),
@Total decimal(18,2), 
@Efectivo decimal(18,2), 
@NombEmpleado varchar(100),
@TipoPago varchar(100),
@Cambio decimal(18,2),
@RNC varchar(100),
@NCF varchar (100),
@Existencia int
AS
BEGIN
	insert into FacturaVenta (Fecha, NombCliente, CodCliente, CodProducto,DescProducto, 
	PrecioUnitario, Cantidad ,SubTotal,Impuesto, Descuento,
	 Total,ITBIS, Efectivo, TipoPago, NombEmpleado,RNC,NCF,
	 Cambio, Existencia )

	values (@Fecha, @NombCliente, @CodCliente, @CodProducto,@DescProducto, 
	@PrecioUnitario, @Cantidad ,@SubTotal,@Impuesto, @Descuento,
	 @Total,@ITBIS, @Efectivo, @TipoPago, @NombEmpleado,@RNC,@NCF,
	 @Cambio, @Existencia )
	
	select @@IDENTITY
END

GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FLogin_ValidarLogin]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FLogin_ValidarLogin]

@Usuario varchar (100),
	@Password varchar (100)
AS
BEGIN
	select Id, Nombre, Apellido, Cedula, Direccion, Telefono, Usuario, Password, Tipo from Usuarios where Usuario = @Usuario and Password = @Password
END

GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FProveedor_Actualizar]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FProveedor_Actualizar]

(

@IdProveedor int,
@NombProveedor varchar (100),
@Telefono varchar (100),
@RNC varchar (100),
@Pais varchar (100),
@Ciudad varchar (100),
@Email varchar (100)
)
As

update Proveedor set  NombProveedor=@NombProveedor, Telefono=@Telefono,RNC=@RNC,
Pais=@Pais,Ciudad=@Ciudad,Email=@Email  where IdProveedor=@IdProveedor
select @@ROWCOUNT as cantidad


GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FProveedor_Borrar]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FProveedor_Borrar]

@IdProveedor int
AS
BEGIN
	delete from Proveedor where IdProveedor=@IdProveedor
	select @@ROWCOUNT as CantidadAfectada
END

GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FProveedor_GetAll]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FProveedor_GetAll]


AS
BEGIN
	select IdProveedor, NombProveedor, Telefono,RNC,Pais, Ciudad, Email from Proveedor

   
END


GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FProveedor_Insert]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FProveedor_Insert]
(
@IdProveedor int,
@NombProveedor varchar (100),
@Telefono varchar (100),
@RNC varchar (100),
@Pais varchar (100),
@Ciudad varchar (100),
@Email varchar (100)

)
As
insert into Proveedor(IdProveedor,NombProveedor, Telefono,RNC,Pais,Ciudad, Email)
	values (@IdProveedor, @NombProveedor, @Telefono, @RNC,@Pais, @Ciudad, @Email)
select @@IDENTITY

GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FUsuario_Insert]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Data_FUsuario_Insert]

(
   
   @Nombre varchar(100),
   @Apellido varchar(100),
   @Cedula varchar(100),
   @Direccion varchar (100),
   @Telefono varchar(100),
   @Usuario varchar (100),
   @Password varchar (100),
   @Tipo varchar (100)
)
AS
insert into Usuarios (Nombre,Apellido,Cedula,Direccion,Telefono,Usuario, Password,Tipo)

values (@Nombre,@Apellido,@Cedula,@Direccion,@Telefono,@Usuario, @Password,@Tipo)

select @@IDENTITY

GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FUsuarios_Actualizar]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[usp_Data_FUsuarios_Actualizar]

   @Id int,
   @Nombre varchar(100),
   @Apellido varchar(100),
   @Cedula varchar(100),
   @Direccion varchar (100),
   @Telefono varchar(100),
   @Usuario varchar (100),
   @Password varchar (100),
   @Tipo varchar (100)

AS
BEGIN
  update Usuarios set Nombre = @Nombre, Apellido = @Apellido, Cedula= @Cedula, Direccion = @Direccion, Telefono = @Telefono, Usuario = @Usuario,
                      Password = @Password, Tipo = @Tipo
	where Id = @Id
select @@ROWCOUNT as CantidadAfectada
END

GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FUsuarios_Borrar]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_Data_FUsuarios_Borrar]

  @Id int
	
AS
BEGIN
 delete from Usuarios where Id = @Id
 select @@ROWCOUNT as CantidadAfectada
END



GO
/****** Object:  StoredProcedure [dbo].[usp_Data_FUsuarios_GetAll]    Script Date: 27/2/2016 10:59:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[usp_Data_FUsuarios_GetAll]

AS 
BEGIN
  select Id, Nombre, Apellido, Cedula, Direccion, Telefono, Usuario, Password, Tipo
    from Usuarios
	END

GO
USE [master]
GO
ALTER DATABASE [SoftPT3] SET  READ_WRITE 
GO
