create PROCEDURE dbo.Eventos_GenerarEventos 

AS


-- Visitas

insert into eventos (FechaGeneracion, Descripcion, fechaVencimiento, Activo, IdRelacion, IdTipoEvento)
(select getdate(), 'Visita Propiedad ' + cast(IdPropiedad as varchar), FechaHora, 1, IdVisita, 2 from visitasPropiedad 
WHERE realizada=0 and conAlarma=1 and dateadd(day, -1, FechaHora) <= getdate()
and idVisita not in (select idRelacion from eventos where idTipoEvento=2))

-- Cumpleaños

insert into eventos (FechaGeneracion, Descripcion, fechaVencimiento, Activo, IdRelacion, IdTipoEvento)
(select getdate(), 'Recordatorio de cumpleaños cliente ' + Nombres + ' ' + Apellido, getdate(), 1, IdCliente, 1 from clientes where day(fechaNacimiento)=day(getdate()) and
							month(FechaNacimiento)=month(getdate())
		and idcliente not in (select idrelacion from eventos where idTipoevento=1
				and MONTH(fechaVencimiento) = MONTH(getdate()) AND day(fechaVencimiento)=day(getdate()) ))

-- Sincronizacion

insert into eventos (FechaGeneracion, Descripcion, fechaVencimiento, Activo, IdRelacion, IdTipoEvento)
(select getdate(), 'Propiedad ' + cast(p.IdPropiedad as varchar) + ' pendiente de sincronización.', null, 1, t.idtransaccion, 4 from transaccion t, transaccionesPropiedad p where t.activa = 1 
and t.idtransaccion=p.idtransaccion and t.idtransaccion not in
(select idRelacion from Eventos where idtipoevento = 4))

insert into eventos (FechaGeneracion, Descripcion, fechaVencimiento, Activo, IdRelacion, IdTipoEvento)
(select getdate(), 'Foto de Propiedad ' + cast(p.IdPropiedad as varchar) + ' pendiente de sincronización.', null, 1, t.idtransaccion, 4 from transaccion t, transaccionesFoto p where t.activa = 1 
and t.idtransaccion=p.idtransaccion and t.idtransaccion not in
(select idRelacion from Eventos where idtipoevento = 4))

