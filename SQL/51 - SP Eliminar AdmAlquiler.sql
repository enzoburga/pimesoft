
GO
/****** Object:  StoredProcedure [dbo].[AdmAlquiler_Eliminar]    Script Date: 05/03/2008 01:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AdmAlquiler_Eliminar] 

	(
	@IdPropiedad int
	)
AS
delete from admAlquileres where idpropiedad = @IdPropiedad
