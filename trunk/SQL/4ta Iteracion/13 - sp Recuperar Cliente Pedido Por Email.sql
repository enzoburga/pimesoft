set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go

alter PROCEDURE [dbo].[ClientePedido_RecuperarPorEmail] 
	
	(
	@email nvarchar(50)
	)
	
AS
SELECT c.[Nombres]
      ,c.[Apellido]
      ,c.[IdCliente]
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
  FROM [dbo].[Clientes] c, ClientesPedido cp
  Where Email like '%'+@email+'%' and c.idcliente = cp.idcliente
