ALTER PROCEDURE dbo.Cliente_RecuperarPorId 
	
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
  FROM [Pime].[dbo].[Clientes]
  Where [IdCliente] = @IdCliente

