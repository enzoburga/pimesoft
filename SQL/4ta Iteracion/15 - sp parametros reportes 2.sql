USE [InmobiliariaDbProduccion]
GO
/****** Objeto:  StoredProcedure [dbo].[Reportes_RecuperarParametros]    Fecha de la secuencia de comandos: 07/06/2008 18:44:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Reportes_RecuperarParametros] 


AS


select top 1 encabezado, piePagina from Reportes
