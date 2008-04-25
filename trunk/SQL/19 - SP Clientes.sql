

/***************** CLIENTES RECUPERAR POR ID ************************/
create PROCEDURE dbo.Cliente_RecuperarPorId 
	
	(
	@IdCliente int
	)
	
AS
SELECT [Nombres]
      ,[Apellido]
      ,[IdCliente]
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
      ,[IdLocalidad]
  FROM [dbo].[Clientes]
  Where [IdCliente] = @IdCliente



GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/***************** CLIENTES GUARDAR ************************/
CREATE PROCEDURE [dbo].[Cliente_Guardar] 
	
	(
	@Nombres nvarchar(50),
	@Apellido nvarchar(50),
	@NroDocumento nvarchar(20),
	@TipoDocumento int,
	@TelefonoParticular int,
	@TelefonoTrabajo int,
	@TelefonoCelular int,
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

/***************** CLIENTES ACTUALIZAR ************************/

create PROCEDURE dbo.Cliente_Actualizar
	
	(
	@IdCliente int,
	@Nombres nvarchar(50),
	@Apellido nvarchar(50),
	@NroDocumento nvarchar(20),
	@TipoDocumento int,
	@TelefonoParticular int,
	@TelefonoTrabajo int,
	@TelefonoCelular int,
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

/***************** CLIENTES PROPIETARIO GUARDAR ************************/

create PROCEDURE [dbo].[Propietario_Guardar] 
	
	(
	@IdPropietario int
	)
	
AS
insert into Propietarios (IdCliente) values (@IdPropietario)
SELECT @@IDENTITY

/***************** CLIENTES INQUILINO GUARDAR ************************/

create PROCEDURE dbo.Inquilino_Guardar 
	
	(
	@IdInquilino int
	)
	
AS
insert into Inquilinos (IdCliente) values (@IdInquilino)
SELECT @@IDENTITY

/***************** CLIENTES PROPIETARIO BUSCAR POR NOMBRE ************************/

create PROCEDURE dbo.Propietarios_RecuperarPorNombre 
	
	(
	@Cadena nvarchar(15)
	)
	
AS
select		
			c.[IdCliente]
		   ,c.[Nombres]
           ,c.[Apellido]
           ,c.[NroDocumento]
           ,c.[TipoDocumento]
           ,c.[TelefonoParticular]
           ,c.[TelefonoTrabajo]
           ,c.[TelefonoCelular]
           ,c.[Observaciones]
           ,c.[FechaNacimiento]
           ,c.[Email]
           ,c.[Calle]
           ,c.[Numero]
           ,c.[Depto]
           ,c.[Piso]
           ,c.[CodigoPostal]
           ,c.[CalleEntre1]
           ,c.[CalleEntre2]
           ,c.[IdBarrio]
           ,c.[IdProvincia]
           ,c.[IdPais]
           ,c.[IdLocalidad] 
from Propietarios p , Clientes c
where p.IdCliente = c.IdCliente and (c.Nombres Like '%'+@Cadena+'%' or c.Apellido like '%'+@Cadena+'%')

/***************** CLIENTES PROPIETARIO RECUPERAR TODOS ************************/

create PROCEDURE dbo.Propietarios_RecuperarTodos 
	
AS
select
			c.[IdCliente]
		   ,c.[Nombres]
           ,c.[Apellido]
           ,c.[NroDocumento]
           ,c.[TipoDocumento]
           ,c.[TelefonoParticular]
           ,c.[TelefonoTrabajo]
           ,c.[TelefonoCelular]
           ,c.[Observaciones]
           ,c.[FechaNacimiento]
           ,c.[Email]
           ,c.[Calle]
           ,c.[Numero]
           ,c.[Depto]
           ,c.[Piso]
           ,c.[CodigoPostal]
           ,c.[CalleEntre1]
           ,c.[CalleEntre2]
           ,c.[IdBarrio]
           ,c.[IdProvincia]
           ,c.[IdPais]
           ,c.[IdLocalidad] 
from Propietarios p , Clientes c
where p.IdCliente = c.IdCliente


