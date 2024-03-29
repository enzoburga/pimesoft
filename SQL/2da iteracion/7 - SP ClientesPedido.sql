
GO
/****** Object:  StoredProcedure [dbo].[ClientePedido_Guardar]    Script Date: 05/19/2008 00:28:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[ClientePedido_Guardar] 
	
	(
	@IdClientePedido int
	)
	
AS
insert into ClientesPedido (IdCliente) values (@IdClientePedido)
SELECT @@ROWCOUNT

GO
/****** Object:  StoredProcedure [dbo].[ClientesPedido_RecuperarTodos]    Script Date: 05/19/2008 00:29:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[ClientesPedido_RecuperarTodos]
	
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
from ClientesPedido cp , Clientes c
where cp.IdCliente = c.IdCliente
GO
/****** Object:  StoredProcedure [dbo].[ClientesPedido_RecuperarPorNombre]    Script Date: 05/19/2008 00:29:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[ClientesPedido_RecuperarPorNombre]
	
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
from ClientesPedido p , Clientes c
where p.IdCliente = c.IdCliente and (c.Nombres Like '%'+@Cadena+'%' or c.Apellido like '%'+@Cadena+'%')
