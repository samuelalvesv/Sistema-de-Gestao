USE [master]
GO
/****** Object:  Database [SIGE]    Script Date: 27/03/2024 20:17:22 ******/
CREATE DATABASE [SIGE]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SIGE', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER01\MSSQL\DATA\SIGE.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SIGE_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER01\MSSQL\DATA\SIGE_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SIGE] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SIGE].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SIGE] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SIGE] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SIGE] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SIGE] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SIGE] SET ARITHABORT OFF 
GO
ALTER DATABASE [SIGE] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SIGE] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SIGE] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SIGE] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SIGE] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SIGE] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SIGE] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SIGE] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SIGE] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SIGE] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SIGE] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SIGE] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SIGE] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SIGE] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SIGE] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SIGE] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SIGE] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SIGE] SET RECOVERY FULL 
GO
ALTER DATABASE [SIGE] SET  MULTI_USER 
GO
ALTER DATABASE [SIGE] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SIGE] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SIGE] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SIGE] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SIGE] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SIGE] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SIGE', N'ON'
GO
ALTER DATABASE [SIGE] SET QUERY_STORE = ON
GO
ALTER DATABASE [SIGE] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [SIGE]
GO
/****** Object:  Table [dbo].[tblCliente]    Script Date: 27/03/2024 20:17:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCliente](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[DataNascimento] [datetime] NOT NULL,
	[Sexo] [bit] NOT NULL,
	[LimiteCompra] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_tblCliente] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[uspClienteAlterar]    Script Date: 27/03/2024 20:17:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- PROCEDIMENTO - CLIENTES - ALTERAR

CREATE PROCEDURE [dbo].[uspClienteAlterar]
	@IdCliente INT,
	@Nome varchar (100),
	@DataNascimento datetime,
	@Sexo bit,
	@LimiteCompra decimal (18,2)
AS
BEGIN
	UPDATE
		tblCliente
	SET
		Nome = @Nome,
		DataNascimento = @DataNascimento,
		Sexo = @Sexo,
		LimiteCompra = @LimiteCompra
	WHERE
		IdCliente = @IdCliente

	SELECT @IdCliente AS Retorno

END
GO
/****** Object:  StoredProcedure [dbo].[uspClienteConsultarPorId]    Script Date: 27/03/2024 20:17:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- PROCEDIMENTO - CLIENTES - CONSULTAR

CREATE PROCEDURE [dbo].[uspClienteConsultarPorId]
	@IdCliente INT

AS
BEGIN

	SELECT
		*
	FROM
		tblCliente
	WHERE
		IdCliente = @IdCliente

END
GO
/****** Object:  StoredProcedure [dbo].[uspClienteConsultarPorNome]    Script Date: 27/03/2024 20:17:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- PROCEDIMENTO - CLIENTES - CONSULTAR

CREATE PROCEDURE [dbo].[uspClienteConsultarPorNome]
	@Nome varchar(100)

AS
BEGIN

	SELECT
		*
	FROM
		tblCliente
	WHERE
		Nome LIKE '%' + @Nome + '%'

END
GO
/****** Object:  StoredProcedure [dbo].[uspClienteExcluir]    Script Date: 27/03/2024 20:17:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- PROCEDIMENTO - CLIENTES - EXCLUIR

CREATE PROCEDURE [dbo].[uspClienteExcluir]
	@IdCliente INT

AS
BEGIN

	DELETE FROM
		tblCliente
	WHERE
		IdCliente = @IdCliente

	SELECT @IdCliente AS Retorno

END
GO
/****** Object:  StoredProcedure [dbo].[uspClienteInserir]    Script Date: 27/03/2024 20:17:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- PROCEDIMENTO - CLIENTES - INSERIR

CREATE PROCEDURE [dbo].[uspClienteInserir]
	@Nome varchar (100),
	@DataNascimento datetime,
	@Sexo bit,
	@LimiteCompra decimal (18,2)
AS
BEGIN
	INSERT INTO tblCliente
	(
	Nome,
	DataNascimento,
	Sexo,
	LimiteCompra
	)
	VALUES
	(
	@Nome,
	@DataNascimento,
	@Sexo,
	@LimiteCompra
	)

	SELECT @@IDENTITY AS Retorno

END
GO
USE [master]
GO
ALTER DATABASE [SIGE] SET  READ_WRITE 
GO
