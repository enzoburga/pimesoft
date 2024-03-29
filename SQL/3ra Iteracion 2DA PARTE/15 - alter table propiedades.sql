/*
   domingo, 29 de junio de 200803:52:25 p.m.
   Usuario: sa
   Servidor: EMILIOMOVILHP\SQLEXPRESS
   Base de datos: InmobiliariaDb
   Aplicación: 
*/

/* Para evitar posibles problemas de pérdida de datos, debe revisar esta secuencia de comandos detalladamente antes de ejecutarla fuera del contexto del diseñador de base de datos.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Propiedades ADD
	Jardin bit NULL,
	Patio bit NULL,
	Piscina bit NULL,
	Lavadero bit NULL,
	Dependencia bit NULL,
	Quincho bit NULL,
	Parrilla bit NULL,
	Balcon bit NULL,
	Terraza bit NULL,
	Playroom bit NULL,
	Baulera bit NULL,
	CuartoHerramientas bit NULL
GO
COMMIT
