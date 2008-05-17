CREATE PROCEDURE dbo.Propiedades_RecuperarVisitas 
(
	@IdPropiedad int
)
AS



SELECT        IdVisita, TimpoAlarma, FechaHora, Realizada, Visita, Telefono, Comentario, ConAlarma, IdPropiedad
FROM            VisitasPropiedad
WHERE        (IdPropiedad = @IdPropiedad)

;

create PROCEDURE dbo.Propiedades_GuardarVisita
(
	@TimpoAlarma bigint,
	@FechaHora datetime,
	@Realizada bit,
	@Visita nvarchar(50),
	@Telefono nvarchar(50),
	@Comentario text,
	@ConAlarma bit,
	@IdPropiedad int
)
AS



insert into VisitasPropiedad (TimpoAlarma, FechaHora, Realizada, Visita, Telefono, Comentario, ConAlarma, IdPropiedad)
values (@TimpoAlarma, @FechaHora, @Realizada, @Visita, @Telefono, @Comentario, @ConAlarma, @IdPropiedad)

select @@identity

;

create PROCEDURE dbo.Propiedades_ActualizarVisita
(
	@TimpoAlarma bigint,
	@FechaHora datetime,
	@Realizada bit,
	@Visita nvarchar(50),
	@Telefono nvarchar(50),
	@Comentario text,
	@ConAlarma bit,
	@IdVisita int
)
AS

update VisitasPropiedad set
TimpoAlarma=@TimpoAlarma, 
FechaHora=@FechaHora, 
Realizada=@Realizada, 
Visita=@Visita, 
Telefono=@Telefono, 
Comentario=@Comentario, 
ConAlarma=@ConAlarma

where IdVisita = @IdVisita

select @@rowcount

;

create PROCEDURE dbo.Propiedades_EliminarVisita
(
	
	@IdVisita int
)
AS

delete from VisitasPropiedad where idvisita=@IdVisita

select @@rowcount

