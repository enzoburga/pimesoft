create PROCEDURE dbo.Reportes_GuardarParametros 
(
	@Encabezado image,
	@PiePagina image
)

AS

delete from Reportes


insert into Reportes values (@Encabezado, @PiePagina)

select @@ROWCOUNT


