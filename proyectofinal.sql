USE [master]
GO
/****** Object:  Database [final]    Script Date: 12/12/2023 10:54:21 p. m. ******/
CREATE DATABASE [final]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'final', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\final.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'final_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\final_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [final] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [final].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [final] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [final] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [final] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [final] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [final] SET ARITHABORT OFF 
GO
ALTER DATABASE [final] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [final] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [final] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [final] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [final] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [final] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [final] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [final] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [final] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [final] SET  DISABLE_BROKER 
GO
ALTER DATABASE [final] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [final] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [final] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [final] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [final] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [final] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [final] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [final] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [final] SET  MULTI_USER 
GO
ALTER DATABASE [final] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [final] SET DB_CHAINING OFF 
GO
ALTER DATABASE [final] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [final] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [final] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [final] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [final] SET QUERY_STORE = ON
GO
ALTER DATABASE [final] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [final]
GO
/****** Object:  Table [dbo].[Carreras]    Script Date: 12/12/2023 10:54:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carreras](
	[Id] [int] NOT NULL,
	[cod_facultad] [varchar](2) NULL,
	[cod_carrera] [varchar](2) NULL,
	[carrera] [varchar](75) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Distrito]    Script Date: 12/12/2023 10:54:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Distrito](
	[Id] [int] NOT NULL,
	[cod_provincia] [varchar](2) NULL,
	[cod_distrito] [varchar](2) NULL,
	[distrito] [varchar](75) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estudiante]    Script Date: 12/12/2023 10:54:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiante](
	[cedula] [varchar](15) NULL,
	[nombre] [varchar](30) NULL,
	[apellido] [varchar](30) NULL,
	[direccion] [varchar](50) NULL,
	[celular] [varchar](8) NULL,
	[correo] [varchar](50) NULL,
	[cod_facultad] [varchar](2) NULL,
	[cod_carrera] [varchar](2) NULL,
	[indice_academico] [decimal](4, 2) NULL,
	[sexo] [char](1) NULL,
	[estatus] [char](1) NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facultad]    Script Date: 12/12/2023 10:54:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facultad](
	[Id] [int] NOT NULL,
	[cod_facultad] [varchar](2) NULL,
	[nombre_facultad] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[profesor]    Script Date: 12/12/2023 10:54:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[profesor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](4) NULL,
	[cedula] [varchar](15) NULL,
	[nombre] [varchar](30) NULL,
	[apellido] [varchar](30) NULL,
	[direccion] [varchar](50) NULL,
	[celular] [varchar](8) NULL,
	[correo] [varchar](50) NULL,
	[cod_provincia] [varchar](2) NULL,
	[cod_distrito] [varchar](2) NULL,
	[salario_base] [decimal](10, 2) NULL,
	[estatus] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 12/12/2023 10:54:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincia](
	[Id] [int] NOT NULL,
	[codigo] [varchar](2) NULL,
	[nombre_provincia] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD CHECK  (([estatus]='I' OR [estatus]='A'))
GO
ALTER TABLE [dbo].[profesor]  WITH CHECK ADD CHECK  (([estatus]='I' OR [estatus]='A'))
GO
/****** Object:  StoredProcedure [dbo].[ObtenerNombreEstudiante]    Script Date: 12/12/2023 10:54:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerNombreEstudiante]
    @Cedula NVARCHAR(15)
AS
BEGIN
SELECT nombre,apellido,correo From Estudiante
WHERE cedula = @Cedula;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarEstudiante]    Script Date: 12/12/2023 10:54:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ActualizarEstudiante]
    @cedula VARCHAR(15),
    @nombre VARCHAR(30),
    @apellido VARCHAR(30),
    @direccion VARCHAR(50),
    @celular VARCHAR(8),
    @correo VARCHAR(50),
	@indice_academico DECIMAL(4, 2),
	@sexo CHAR(1),
	@carrera VARCHAR(75),
    @facultad VARCHAR(50)
AS
BEGIN
    -- Verificar que la cédula proporcionada existe en la base de datos
    IF NOT EXISTS (SELECT 1 FROM Estudiante WHERE cedula = @cedula)
    BEGIN
        PRINT 'La cédula proporcionada no existe en la base de datos.'
        RETURN;
    END

    -- Actualizar la información del estudiante excepto la cédula
    UPDATE Estudiante
    SET nombre = ISNULL(@nombre, nombre),
        apellido = ISNULL(@apellido, apellido),
        direccion = ISNULL(@direccion, direccion),
        celular = ISNULL(@celular, celular),
        correo = ISNULL(@correo, correo),
        indice_academico = ISNULL(@indice_academico, indice_academico),
        sexo = ISNULL(@sexo, sexo),
        cod_carrera = ISNULL((SELECT cod_carrera FROM Carreras WHERE carrera = @carrera), cod_carrera),
        cod_facultad = ISNULL((SELECT cod_facultad FROM Facultad WHERE nombre_facultad = @facultad), cod_facultad)
    WHERE cedula = @cedula;

    PRINT 'Información del estudiante actualizada correctamente.';
END

exec dbo.sp_ActualizarEstudiante
GO
/****** Object:  StoredProcedure [dbo].[sp_Actualizarprofesor]    Script Date: 12/12/2023 10:54:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_Actualizarprofesor]
	@codigo VARCHAR(4),
    @cedula VARCHAR(15),
    @nombre VARCHAR(30),
    @apellido VARCHAR(30),
    @direccion VARCHAR(50),
    @celular VARCHAR(8),
    @correo VARCHAR(50),
	@salario DECIMAL(10, 2),
	@Provincia VARCHAR(50),
    @Distrito VARCHAR(75)
AS
BEGIN
    -- Verificar que el codigo proporcionado existe en la base de datos
    IF NOT EXISTS (SELECT 1 FROM profesor WHERE codigo = @codigo)
    BEGIN
        PRINT 'El codigo proporcionado no existe en la base de datos.'
        RETURN;
    END

    -- Actualizar la información del profesor excepto el codigo
    UPDATE Profesor
    SET cedula = ISNULL(@cedula, cedula),
		nombre = ISNULL(@nombre, nombre),
        apellido = ISNULL(@apellido, apellido),
        direccion = ISNULL(@direccion, direccion),
        celular = ISNULL(@celular, celular),
        correo = ISNULL(@correo, correo),
        salario_base = ISNULL(@salario, salario_base),
        cod_distrito = ISNULL((SELECT cod_distrito FROM Distrito WHERE distrito = @Distrito), cod_distrito),
        cod_provincia = ISNULL((SELECT codigo FROM Provincia WHERE nombre_provincia = @Provincia), codigo)
    WHERE codigo = @codigo;

    PRINT 'Información del profesor actualizada correctamente.';
END

exec dbo.sp_Actualizarprofesor
GO
/****** Object:  StoredProcedure [dbo].[sp_AgregarEstudiante]    Script Date: 12/12/2023 10:54:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AgregarEstudiante]
    @cedula VARCHAR(15),
    @nombre VARCHAR(30),
    @apellido VARCHAR(30),
    @direccion VARCHAR(50),
    @celular VARCHAR(8),
    @correo VARCHAR(50),
	@indice_academico decimal(4,2),
	@sexo CHAR(1),
	@carrera VARCHAR(75),
    @facultad VARCHAR(50)
AS
BEGIN
	DECLARE @codigo_facultad VARCHAR(2)
    DECLARE @cod_carrera VARCHAR(2)
	DECLARE @Miestatus CHAR(1);
    SET @Miestatus = 'A'

    -- Obtener el ID de la facultad
    SELECT @codigo_facultad = cod_facultad FROM Facultad WHERE nombre_facultad = @facultad

    -- Obtener el ID de la carrera
    SELECT @cod_carrera = cod_carrera FROM Carreras WHERE carrera = @carrera

    INSERT INTO Estudiante (cedula, nombre, apellido, direccion, celular, correo, cod_facultad, cod_carrera, indice_academico, sexo, estatus)
    VALUES (@cedula, @nombre, @apellido, @direccion, @celular, @correo, @codigo_facultad, @cod_carrera, @indice_academico, @sexo, @Miestatus)
END
exec dbo.sp_AgregarEstudiante
GO
/****** Object:  StoredProcedure [dbo].[sp_Agregarprofesor]    Script Date: 12/12/2023 10:54:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_Agregarprofesor]
	@codigo VARCHAR(4),
    @cedula VARCHAR(15),
    @nombre VARCHAR(30),
    @apellido VARCHAR(30),
    @direccion VARCHAR(50),
    @celular VARCHAR(8),
    @correo VARCHAR(50),
	@salario decimal(10,2),
	@Provincia VARCHAR(50),
    @distrito VARCHAR(75)
AS
BEGIN
	DECLARE @codigo_provincia VARCHAR(2)
    DECLARE @cod_distrito VARCHAR(2)
	DECLARE @Miestatus CHAR(1);
    SET @Miestatus = 'A'

    -- Obtener el ID de la facultad
    SELECT @codigo_provincia = codigo FROM Provincia WHERE nombre_provincia = @Provincia

    -- Obtener el ID de la carrera
    SELECT @cod_distrito= cod_distrito FROM Distrito WHERE distrito = @distrito

    INSERT INTO profesor (codigo, cedula, nombre, apellido, direccion, celular, correo, cod_provincia, cod_distrito, salario_base, estatus)
    VALUES (@codigo,@cedula, @nombre, @apellido, @direccion, @celular, @correo, @codigo_provincia, @cod_distrito, @salario, @Miestatus)
END
exec dbo.sp_Agregarprofesor
GO
/****** Object:  StoredProcedure [dbo].[sp_Carrera_Listar]    Script Date: 12/12/2023 10:54:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_Carrera_Listar]
as
select carrera from Carreras

exec sp_Carrera_Listar
GO
/****** Object:  StoredProcedure [dbo].[sp_Distritos_Listar]    Script Date: 12/12/2023 10:54:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_Distritos_Listar]
as
select distrito from Distrito

exec sp_Distritos_Listar
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarEstudiantePorCedula]    Script Date: 12/12/2023 10:54:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_EliminarEstudiantePorCedula]
    @cedula VARCHAR(15)
AS
BEGIN
    DELETE FROM Estudiante WHERE cedula = @cedula
End
exec dbo.sp_EliminarEstudiantePorCedula
GO
/****** Object:  StoredProcedure [dbo].[sp_Eliminarprofesorporcodigo]    Script Date: 12/12/2023 10:54:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_Eliminarprofesorporcodigo]
    @codigo VARCHAR(4)
AS
BEGIN
    DELETE FROM profesor WHERE codigo = @codigo
End
exec dbo.sp_Eliminarprofesorporcodigo
GO
/****** Object:  StoredProcedure [dbo].[sp_estudiante_Buscar]    Script Date: 12/12/2023 10:54:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_estudiante_Buscar]
@cedula char(15)
as
SELECT
        e.cedula,
        e.nombre,
        e.apellido,
		e.direccion,
		e.celular,
		e.correo,
		e.indice_academico,
		e.sexo,
        f.nombre_facultad AS Facultad,
        c.carrera AS Carrera
    FROM
        Estudiante AS e
    INNER JOIN
        Facultad AS f ON e.cod_facultad = f.cod_facultad
    INNER JOIN
        Carreras AS c ON e.cod_carrera = c.cod_carrera AND e.cod_facultad = f.cod_facultad
    WHERE
        e.cedula = @cedula;
exec dbo.sp_estudiante_Buscar
GO
/****** Object:  StoredProcedure [dbo].[sp_estudiante_Listar]    Script Date: 12/12/2023 10:54:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_estudiante_Listar]
@orden as char(30) = null
as
SELECT e.cedula,
	   e.nombre,
	   e.apellido,
	   f.nombre_facultad AS Facultad,
	   c.carrera AS Carrera
FROM 
Estudiante AS e
INNER JOIN 
Facultad AS f ON e.cod_facultad = f.cod_facultad
INNER JOIN 
Carreras AS c ON e.cod_carrera = c.cod_carrera AND e.cod_facultad = f.cod_facultad
ORDER BY
	case
	when @orden = 'cedula' then e.cedula
	when @orden = 'nombre' then e.nombre
	when @orden = 'apellido' then e.apellido
	else e.apellido
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_Facultad_Listar]    Script Date: 12/12/2023 10:54:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_Facultad_Listar]
as
select nombre_facultad from Facultad

exec sp_Facultad_Listar
GO
/****** Object:  StoredProcedure [dbo].[sp_ordenarapel]    Script Date: 12/12/2023 10:54:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[sp_ordenarapel]
as
select cedula,nombre,apellido,direccion,celular,correo,cod_facultad,cod_carrera,indice_academico,sexo,estatus from Estudiante order by apellido
exec dbo.sp_ordenarapel
GO
/****** Object:  StoredProcedure [dbo].[sp_ordenarapelprof]    Script Date: 12/12/2023 10:54:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[sp_ordenarapelprof]
as
select codigo,cedula,nombre,apellido,direccion,celular,correo,cod_provincia,cod_distrito,salario_base,estatus from Profesor order by apellido
exec dbo.sp_ordenarapelprof
GO
/****** Object:  StoredProcedure [dbo].[sp_ordenarcedu]    Script Date: 12/12/2023 10:54:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[sp_ordenarcedu]
as
select cedula,nombre,apellido,direccion,celular,correo,cod_facultad,cod_carrera,indice_academico,sexo,estatus from Estudiante order by cedula
exec dbo.sp_ordenarcedu
GO
/****** Object:  StoredProcedure [dbo].[sp_ordenarceduprof]    Script Date: 12/12/2023 10:54:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[sp_ordenarceduprof]
as
select codigo,cedula,nombre,apellido,direccion,celular,correo,cod_provincia,cod_distrito,salario_base,estatus from Profesor order by cedula
exec dbo.sp_ordenarceduprof
GO
/****** Object:  StoredProcedure [dbo].[sp_ordenarnombre]    Script Date: 12/12/2023 10:54:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[sp_ordenarnombre]
as
select cedula,nombre,apellido,direccion,celular,correo,cod_facultad,cod_carrera,indice_academico,sexo,estatus from Estudiante order by nombre
exec dbo.sp_ordenarnombre
GO
/****** Object:  StoredProcedure [dbo].[sp_ordenarnombreprof]    Script Date: 12/12/2023 10:54:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[sp_ordenarnombreprof]
as
select codigo,cedula,nombre,apellido,direccion,celular,correo,cod_provincia,cod_distrito,salario_base,estatus from Profesor order by nombre ASC
exec dbo.sp_ordenarnombreprof
GO
/****** Object:  StoredProcedure [dbo].[sp_profesor_Buscar]    Script Date: 12/12/2023 10:54:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_profesor_Buscar]
@codigo char(4)
as
SELECT
		p.codigo,
        p.cedula,
        p.nombre,
        p.apellido,
		p.direccion,
		p.celular,
		p.correo,
		p.salario_base,
        v.nombre_provincia AS Provincia,
        d.distrito AS Distrito
    FROM
        profesor AS p
    INNER JOIN
        Provincia AS v ON p.cod_provincia = v.codigo
    INNER JOIN
        Distrito AS d ON p.cod_distrito = d.cod_distrito AND p.cod_provincia = v.codigo
    WHERE
        p.codigo = @codigo

exec dbo.sp_profesor_Buscar
GO
/****** Object:  StoredProcedure [dbo].[sp_profesor_Listar]    Script Date: 12/12/2023 10:54:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_profesor_Listar]
@orden as char(30) = null
as
SELECT p.codigo,
	   p.nombre,
	   p.apellido,
	   v.nombre_provincia AS Provincia,
	   d.distrito AS Distrito
FROM 
profesor AS p
INNER JOIN 
Provincia AS v ON p.cod_provincia = v.codigo
INNER JOIN 
Distrito AS d ON p.cod_distrito = d.cod_distrito AND p.cod_provincia = v.codigo
ORDER BY
	case
	when @orden = 'cedula' then p.codigo
	when @orden = 'nombre' then p.nombre
	when @orden = 'apellido' then p.apellido
	else p.apellido
	end
exec dbo.sp_profesor_Listar
GO
/****** Object:  StoredProcedure [dbo].[sp_Provincia_Listar]    Script Date: 12/12/2023 10:54:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_Provincia_Listar]
as
select nombre_provincia from provincia

exec sp_Provincia_Listar
GO
USE [master]
GO
ALTER DATABASE [final] SET  READ_WRITE 
GO
