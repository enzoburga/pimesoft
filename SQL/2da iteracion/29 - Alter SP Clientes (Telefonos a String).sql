set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go


ALTER PROCEDURE [dbo].[Cliente_Actualizar]
	
	(
	@IdCliente int,
	@Nombres nvarchar(50),
	@Apellido nvarchar(50),
	@NroDocumento nvarchar(20),
	@TipoDocumento int,
	@TelefonoParticular nvarchar(50),
	@TelefonoTrabajo nvarchar(50),
	@TelefonoCelular nvarchar(50),
	@Observaciones nvarchar(200),
	@FechaNacimiento datetime,
	@Email nvarchar(50),
	@Calle nvarchar(50),
	@Numero int,
	@Depto  nvarchar(2),
	@Piso nvarchar(2),
	@CodigoPostal nvarchar(50),
	@CalleEntre1 nvarchar(50),
	@CalleEntre2 nvarchar(50),
	@IdBarrio int,
	@IdProvincia int,
	@IdPais int,
	@IdLocalidad int
	)
	
AS
UPDATE Clientes
SET
           [Nombres] = @Nombres
           ,[Apellido] = @Apellido
           ,[NroDocumento] = @NroDocumento
           ,[TipoDocumento] = @TipoDocumento
           ,[TelefonoParticular] = @TelefonoParticular
           ,[TelefonoTrabajo] = @TelefonoTrabajo
           ,[TelefonoCelular] = @TelefonoCelular
           ,[Observaciones] = @Observaciones
           ,[FechaNacimiento] = @FechaNacimiento
           ,[Email] = @Email
           ,[Calle] = @Calle
           ,[Numero] = @Numero
           ,[Depto] = @Depto
           ,[Piso] = @Piso
           ,[CodigoPostal] = @CodigoPostal
           ,[CalleEntre1] = @CalleEntre1
           ,[CalleEntre2] = @CalleEntre2
           ,[IdBarrio] = @IdBarrio
           ,[IdProvincia] = @IdProvincia
           ,[IdPais] = @IdPais
           ,[IdLocalidad] = @IdLocalidad
WHERE IdCliente = @IdCliente
	
SELECT @@ROWCOUNT

/********************************************************************/

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go

ALTER PROCEDURE [dbo].[Cliente_Guardar] 
	
	(
	@Nombres nvarchar(50),
	@Apellido nvarchar(50),
	@NroDocumento nvarchar(20),
	@TipoDocumento int,
	@TelefonoParticular nvarchar(50),
	@TelefonoTrabajo nvarchar(50),
	@TelefonoCelular nvarchar(50),
	@Observaciones nvarchar(200),
	@FechaNacimiento datetime,
	@Email nvarchar(50),
	@Calle nvarchar(50),
	@Numero int,
	@Depto  nvarchar(2),
	@Piso nvarchar(2),
	@CodigoPostal nvarchar(50),
	@CalleEntre1 nvarchar(50),
	@CalleEntre2 nvarchar(50),
	@IdBarrio int,
	@IdProvincia int,
	@IdPais int,
	@IdLocalidad int
	)
	
AS
INSERT INTO Clientes
           ([Nombres]
           ,[Apellido]
           ,[NroDocumento]
           ,[TipoDocumento]
           ,[TelefonoParticular]
           ,[TelefonoTrabajo]
           ,[TelefonoCelular]
           ,[Observaciones]
           ,[FechaNacimiento]
           ,[Email]
           ,[Calle]
           ,[Numero]
           ,[Depto]
           ,[Piso]
           ,[CodigoPostal]
           ,[CalleEntre1]
           ,[CalleEntre2]
           ,[IdBarrio]
           ,[IdProvincia]
           ,[IdPais]
           ,[IdLocalidad])
     VALUES
           (	
			@Nombres,
			@Apellido ,
			@NroDocumento,
			@TipoDocumento ,
			@TelefonoParticular,
			@TelefonoTrabajo ,
			@TelefonoCelular ,
			@Observaciones ,
			@FechaNacimiento ,
			@Email ,
			@Calle ,
			@Numero ,
			@Depto  ,
			@Piso,
			@CodigoPostal ,
			@CalleEntre1 ,
			@CalleEntre2 ,
			@IdBarrio ,
			@IdProvincia ,
			@IdPais ,
			@IdLocalidad 
	)
SELECT @@IDENTITY


