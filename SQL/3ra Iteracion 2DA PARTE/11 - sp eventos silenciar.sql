ALTER PROCEDURE dbo.Eventos_SilenciarEvento 
(
	@IdEvento int
)
AS

update eventos set activo = 0 where idEvento=   @IdEvento


select @@ROWCOUNT
