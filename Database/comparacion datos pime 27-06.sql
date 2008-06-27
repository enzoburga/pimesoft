--------------------------------------------------------------------------------
-- Embarcadero Change Manager Synchronization Script
-- FILE                : Sync.pime.com.ar.06_27_2008.03_37_15.sql
-- DATE                : 6/27/2008 03:37:15
-- 
-- SOURCE DATASOURCE   : servidor-conces
-- TARGET DATASOURCE   : pime.com.ar
--------------------------------------------------------------------------------
SET XACT_ABORT ON

BEGIN TRANSACTION


USE [inmobiliariadb]
go
ALTER TABLE dbo.AdmAlquileres
    DROP CONSTRAINT FK_AdmAlquileres_Alquileres
go
ALTER TABLE dbo.AdmAlquileres
    DROP CONSTRAINT FK_AdmAlquileres_Propietarios
go
ALTER TABLE dbo.Alquileres
    DROP CONSTRAINT FK_Alquileres_Propiedades
go
ALTER TABLE dbo.Barrios
    DROP CONSTRAINT FK_Barrios_Localidades
go
ALTER TABLE dbo.Carteles
    DROP CONSTRAINT FK_Carteles_Propiedades
go
ALTER TABLE dbo.Carteles
    DROP CONSTRAINT FK_Carteles_UbicacionesCartel
go
ALTER TABLE dbo.Clientes
    DROP CONSTRAINT FK_Clientes_Barrios
go
ALTER TABLE dbo.Clientes
    DROP CONSTRAINT FK_Clientes_Localidades
go
ALTER TABLE dbo.Clientes
    DROP CONSTRAINT FK_Clientes_Paises
go
ALTER TABLE dbo.Clientes
    DROP CONSTRAINT FK_Clientes_Provincias
go
ALTER TABLE dbo.ClientesPedido
    DROP CONSTRAINT FK_ClientesPedido_ClientesPedido
go
ALTER TABLE dbo.Contratos
    DROP CONSTRAINT FK_Contratos_AdmAlquileres
go
ALTER TABLE dbo.Contratos
    DROP CONSTRAINT FK_Contratos_Contratos
go
ALTER TABLE dbo.Contratos
    DROP CONSTRAINT FK_Contratos_Inquilinos
go
ALTER TABLE dbo.Contratos
    DROP CONSTRAINT FK_Contratos_Monedas1
go
ALTER TABLE dbo.EventoVisita
    DROP CONSTRAINT FK_EventoVisita_Eventos
go
ALTER TABLE dbo.EventoVisita
    DROP CONSTRAINT FK_EventoVisita_VisitasPropiedad
go
ALTER TABLE dbo.GaleriaFotos
    DROP CONSTRAINT FK_GaleriaFotos_Propiedades
go
ALTER TABLE dbo.Inquilinos
    DROP CONSTRAINT FK_Inquilinos_Clientes
go
ALTER TABLE dbo.Llamados
    DROP CONSTRAINT FK_Llamados_Propiedades
go
ALTER TABLE dbo.Localidades
    DROP CONSTRAINT FK_Localidades_Provincias
go
ALTER TABLE dbo.MedidasAmbientesPropiedad
    DROP CONSTRAINT FK_MedidasAmbientesPropiedad_Propiedades
go
ALTER TABLE dbo.MedidasAmbientesPropiedad
    DROP CONSTRAINT FK_MedidasAmbientesPropiedad_TiposAmbiente
go
ALTER TABLE dbo.MedidasAmbientesPropiedad
    DROP CONSTRAINT FK_MedidasAmbientesPropiedad_TiposDePiso
go
ALTER TABLE dbo.NotasPropiedad
    DROP CONSTRAINT FK_NotasPropiedad_Propiedades
go
ALTER TABLE dbo.Pagos
    DROP CONSTRAINT FK_Pagos_Contratos
go
ALTER TABLE dbo.Pagos
    DROP CONSTRAINT FK_Pagos_Monedas
go
ALTER TABLE dbo.Pedidos
    DROP CONSTRAINT FK_Pedidos_Barrios
go
ALTER TABLE dbo.Pedidos
    DROP CONSTRAINT FK_Pedidos_CategoriasPropiedad
go
ALTER TABLE dbo.Pedidos
    DROP CONSTRAINT FK_Pedidos_ClientesPedido
go
ALTER TABLE dbo.Pedidos
    DROP CONSTRAINT FK_Pedidos_EstadosPropiedad
go
ALTER TABLE dbo.Pedidos
    DROP CONSTRAINT FK_Pedidos_Localidades
go
ALTER TABLE dbo.Pedidos
    DROP CONSTRAINT FK_Pedidos_Monedas1
go
ALTER TABLE dbo.Pedidos
    DROP CONSTRAINT FK_Pedidos_Paises
go
ALTER TABLE dbo.Pedidos
    DROP CONSTRAINT FK_Pedidos_Pedidos
go
ALTER TABLE dbo.Pedidos
    DROP CONSTRAINT FK_Pedidos_Provincias
go
ALTER TABLE dbo.Pedidos
    DROP CONSTRAINT FK_Pedidos_TiposPropiedad
go
ALTER TABLE dbo.Propiedades
    DROP CONSTRAINT FK_Propiedades_Barrios
go
ALTER TABLE dbo.Propiedades
    DROP CONSTRAINT FK_Propiedades_Clientes
go
ALTER TABLE dbo.Propiedades
    DROP CONSTRAINT FK_Propiedades_EstadosPropiedad
go
ALTER TABLE dbo.Propiedades
    DROP CONSTRAINT FK_Propiedades_InmobiliariasExternas
go
ALTER TABLE dbo.Propiedades
    DROP CONSTRAINT FK_Propiedades_Localidades
go
ALTER TABLE dbo.Propiedades
    DROP CONSTRAINT FK_Propiedades_Monedas
go
ALTER TABLE dbo.Propiedades
    DROP CONSTRAINT FK_Propiedades_Monedas1
go
ALTER TABLE dbo.Propiedades
    DROP CONSTRAINT FK_Propiedades_Paises
go
ALTER TABLE dbo.Propiedades
    DROP CONSTRAINT FK_Propiedades_Provincias
go
ALTER TABLE dbo.Propiedades
    DROP CONSTRAINT FK_Propiedades_TiposPropiedad
go
ALTER TABLE dbo.PropiedadesOfrecidasXPedido
    DROP CONSTRAINT FK_PropiedadesOfrecidasXPedido_Pedidos
go
ALTER TABLE dbo.PropiedadesOfrecidasXPedido
    DROP CONSTRAINT FK_PropiedadesOfrecidasXPedido_Propiedades
go
ALTER TABLE dbo.Propietarios
    DROP CONSTRAINT FK_Propietarios_Clientes
go
ALTER TABLE dbo.Provincias
    DROP CONSTRAINT FK_Provincias_Paises
go
ALTER TABLE dbo.Publicaciones
    DROP CONSTRAINT FK_Publicaciones_Monedas
go
ALTER TABLE dbo.Publicaciones
    DROP CONSTRAINT FK_Publicaciones_Propiedades
go
ALTER TABLE dbo.Tasaciones
    DROP CONSTRAINT FK_Tasaciones_Monedas
go
ALTER TABLE dbo.Tasaciones
    DROP CONSTRAINT FK_Tasaciones_Monedas1
go
ALTER TABLE dbo.Tasaciones
    DROP CONSTRAINT FK_Tasaciones_Propiedades
go
ALTER TABLE dbo.TiposPropiedad
    DROP CONSTRAINT FK_TiposPropiedad_CategoriasPropiedad
go
ALTER TABLE dbo.Transaccion
    DROP CONSTRAINT FK_Transaccion_TipoTransaccion
go
ALTER TABLE dbo.Transaccion
    DROP CONSTRAINT FK_Transaccion_TransaccionesPropiedad
go
ALTER TABLE dbo.TransaccionesFoto
    DROP CONSTRAINT FK_TransaccionesFoto_Propiedades
go
ALTER TABLE dbo.TransaccionesFoto
    DROP CONSTRAINT FK_TransaccionesFoto_Transaccion
go
ALTER TABLE dbo.TransaccionesPropiedad
    DROP CONSTRAINT FK_TransaccionesPropiedad_Propiedades
go
ALTER TABLE dbo.TransaccionesPropiedad
    DROP CONSTRAINT FK_TransaccionesPropiedad_Transaccion
go
ALTER TABLE dbo.ValoresRenta
    DROP CONSTRAINT FK_ValoresRenta_Contratos
go
ALTER TABLE dbo.ValoresRenta
    DROP CONSTRAINT FK_ValoresRenta_Monedas
go
ALTER TABLE dbo.Ventas
    DROP CONSTRAINT FK_Ventas_Propiedades
go
ALTER TABLE dbo.VisitasPropiedad
    DROP CONSTRAINT FK_VisitasPropiedad_Propiedades
go
INSERT INTO [dbo].[AdmAlquileres] ( [IdPropiedad], [IdContacto] ) VALUES(  66, NULL )
go
INSERT INTO [dbo].[AdmAlquileres] ( [IdPropiedad], [IdContacto] ) VALUES(  67, NULL )
go
INSERT INTO [dbo].[AdmAlquileres] ( [IdPropiedad], [IdContacto] ) VALUES(  71, NULL )
go
INSERT INTO [dbo].[AdmAlquileres] ( [IdPropiedad], [IdContacto] ) VALUES(  78, 21 )
go
INSERT INTO [dbo].[AdmAlquileres] ( [IdPropiedad], [IdContacto] ) VALUES(  83, 39 )
go
INSERT INTO [dbo].[AdmAlquileres] ( [IdPropiedad], [IdContacto] ) VALUES(  84, 47 )
go
INSERT INTO [dbo].[Alquileres] ( [IdPropiedad] ) VALUES(  36 )
go
INSERT INTO [dbo].[Alquileres] ( [IdPropiedad] ) VALUES(  65 )
go
INSERT INTO [dbo].[Alquileres] ( [IdPropiedad] ) VALUES(  66 )
go
INSERT INTO [dbo].[Alquileres] ( [IdPropiedad] ) VALUES(  67 )
go
INSERT INTO [dbo].[Alquileres] ( [IdPropiedad] ) VALUES(  71 )
go
INSERT INTO [dbo].[Alquileres] ( [IdPropiedad] ) VALUES(  72 )
go
INSERT INTO [dbo].[Alquileres] ( [IdPropiedad] ) VALUES(  78 )
go
INSERT INTO [dbo].[Alquileres] ( [IdPropiedad] ) VALUES(  79 )
go
INSERT INTO [dbo].[Alquileres] ( [IdPropiedad] ) VALUES(  83 )
go
INSERT INTO [dbo].[Alquileres] ( [IdPropiedad] ) VALUES(  84 )
go
INSERT INTO [dbo].[Alquileres] ( [IdPropiedad] ) VALUES(  92 )
go
INSERT INTO [dbo].[Alquileres] ( [IdPropiedad] ) VALUES(  95 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  1, 'Vicente Lopez', 1, 1 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  2, 'Villa Marteli', 0, 1 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  3, 'Florida M.', 0, 1 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  4, 'Florida B.', 0, 1 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  5, 'Munro', 0, 1 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  6, 'Olivos', 0, 1 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  7, 'La Lucila', 0, 1 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  8, 'Carapachay', 0, 1 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  9, 'Villa Adelina', 0, 1 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  10, 'Acassuso', 0, 3 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  11, 'San Isidro', 0, 3 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  12, 'Boulogne', 0, 3 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  13, 'Beccar', 0, 3 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  14, 'Martinez', 0, 3 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  15, 'Villa Adelina', 0, 3 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  16, 'Don Torcuaro', 0, 18 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  17, 'Tigre', 0, 18 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  18, 'General Pacheco', 0, 18 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  19, 'El Talar', 0, 18 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  20, 'Benavídez', 0, 18 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  21, 'Dique Lujan', 0, 18 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  22, 'Nordelta', 0, 18 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  23, 'Ricardo Rojas', 0, 18 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  24, 'Rincón de Milberg', 0, 18 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  25, 'Troncos del Talar', 0, 18 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  26, 'Delta', 0, 18 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  27, 'San Fernando', 0, 15 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  28, 'Victoria', 0, 15 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  29, 'Virreyes', 0, 15 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  30, 'Islas', 0, 15 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  31, 'Bº El Cazador', 0, 19 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  32, 'San Martín', 0, 16 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  33, 'Jose León Suarez', 0, 16 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  34, 'Villa Ballester', 0, 16 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  35, 'Olivos Roche', 0, 1 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  36, 'San Bernardo', 0, 26 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  37, 'Mar de Ajó', 0, 26 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  38, 'La Lucila', 0, 26 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  39, 'Miramar', 0, 27 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  40, 'Santos Lugares', 0, 29 )
go
SET IDENTITY_INSERT [dbo].[Carteles] ON
go
INSERT INTO [dbo].[Carteles] ( [IdCartel], [IdPropiedad], [Activo], [Ancho], [Alto], [FechaAlta], [FechaVencimiento], [TipoCartel], [IdUbicacionCartel] ) VALUES(  1, 62, 1, 100, 70, '2008-06-04 00:00:00.0', '2008-06-04 00:00:00.0', 'GI.BR.Propiedades.Venta', 2 )
go
INSERT INTO [dbo].[Carteles] ( [IdCartel], [IdPropiedad], [Activo], [Ancho], [Alto], [FechaAlta], [FechaVencimiento], [TipoCartel], [IdUbicacionCartel] ) VALUES(  2, 62, 1, 100, 70, '2008-05-01 00:00:00.0', '2008-06-05 00:00:00.0', 'GI.BR.Propiedades.Venta', 2 )
go
INSERT INTO [dbo].[Carteles] ( [IdCartel], [IdPropiedad], [Activo], [Ancho], [Alto], [FechaAlta], [FechaVencimiento], [TipoCartel], [IdUbicacionCartel] ) VALUES(  3, 62, 1, 100, 70, '2008-05-01 00:00:00.0', '2008-06-05 00:00:00.0', 'GI.BR.Propiedades.Venta', 2 )
go
INSERT INTO [dbo].[Carteles] ( [IdCartel], [IdPropiedad], [Activo], [Ancho], [Alto], [FechaAlta], [FechaVencimiento], [TipoCartel], [IdUbicacionCartel] ) VALUES(  4, 52, 1, 120, 80, '2008-05-01 00:00:00.0', '2008-06-05 00:00:00.0', 'GI.BR.Propiedades.Venta', 2 )
go
INSERT INTO [dbo].[Carteles] ( [IdCartel], [IdPropiedad], [Activo], [Ancho], [Alto], [FechaAlta], [FechaVencimiento], [TipoCartel], [IdUbicacionCartel] ) VALUES(  5, 82, 1, 120, 80, '2008-03-01 00:00:00.0', '2008-06-05 00:00:00.0', 'GI.BR.Propiedades.Venta', 2 )
go
INSERT INTO [dbo].[Carteles] ( [IdCartel], [IdPropiedad], [Activo], [Ancho], [Alto], [FechaAlta], [FechaVencimiento], [TipoCartel], [IdUbicacionCartel] ) VALUES(  6, 35, 1, 120, 80, '2007-07-03 00:00:00.0', '2008-12-05 00:00:00.0', 'GI.BR.Propiedades.Venta', 2 )
go
INSERT INTO [dbo].[Carteles] ( [IdCartel], [IdPropiedad], [Activo], [Ancho], [Alto], [FechaAlta], [FechaVencimiento], [TipoCartel], [IdUbicacionCartel] ) VALUES(  7, 79, 1, 120, 80, '2008-05-31 00:00:00.0', '2008-06-10 00:00:00.0', 'GI.BR.Propiedades.Alquiler', 2 )
go
INSERT INTO [dbo].[Carteles] ( [IdCartel], [IdPropiedad], [Activo], [Ancho], [Alto], [FechaAlta], [FechaVencimiento], [TipoCartel], [IdUbicacionCartel] ) VALUES(  8, 35, 1, 50, 70, '2007-07-03 00:00:00.0', '2008-12-05 00:00:00.0', 'GI.BR.Propiedades.Venta', 4 )
go
INSERT INTO [dbo].[Carteles] ( [IdCartel], [IdPropiedad], [Activo], [Ancho], [Alto], [FechaAlta], [FechaVencimiento], [TipoCartel], [IdUbicacionCartel] ) VALUES(  9, 53, 1, 50, 70, '2006-04-10 00:00:00.0', '2008-06-10 00:00:00.0', 'GI.BR.Propiedades.Venta', 4 )
go
INSERT INTO [dbo].[Carteles] ( [IdCartel], [IdPropiedad], [Activo], [Ancho], [Alto], [FechaAlta], [FechaVencimiento], [TipoCartel], [IdUbicacionCartel] ) VALUES(  10, 44, 1, 50, 70, '2008-01-10 00:00:00.0', '2008-06-10 00:00:00.0', 'GI.BR.Propiedades.Venta', 4 )
go
SET IDENTITY_INSERT [dbo].[Carteles] OFF
go
INSERT INTO [dbo].[CategoriasPropiedad] ( [IdCategoria], [Nombre] ) VALUES(  1, 'Vivienda' )
go
INSERT INTO [dbo].[CategoriasPropiedad] ( [IdCategoria], [Nombre] ) VALUES(  2, 'Comercial' )
go
INSERT INTO [dbo].[CategoriasPropiedad] ( [IdCategoria], [Nombre] ) VALUES(  3, 'Especial' )
go
SET IDENTITY_INSERT [dbo].[Clientes] ON
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  1, 'Viviana', 'Duran', '', 0, '4794-3432', '4797-1885', '155-036-0596', 'Hija de Flia. Duran, pacientes de Dr. Biaggi/Marta.
Esposo: Franco Cel: 153-162-3639

Vendieron 3 amb. en Corrientes y Maipu.', NULL, '', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  2, 'Rita', 'Frahne', '', 0, '4765-7249', '', '156-510-3732', 'Paciente dr. Biaggi/Marta.
Propietaria depto 3 amb. alquiler. Roca 1702 6ºA', NULL, 'rfrahne@hotmail.com', 'Dean Funes', 1981, '', '', '', 'Francia', 'Italia', 4, 1, 1, 1 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  3, 'Gladys', 'Rossini', '', 0, '', '', '154-526-5655', 'Ginecologa. Flia. Merino
Propietaria depto. Haedo y Av. maipu, 3 amb, en alquiler.

Hermana y copropietaria: Ethel Liliana Rossini ', NULL, 'gladysnrossini@yahoo.com.ar', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  4, 'Sr.', 'Pino', '', 0, '4795-8073', '', '', 'Propietario Casa Tasada. Urquiza 2378 Florida M.', NULL, '', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  5, 'Sr.', 'Pino', '', 0, '4795-8073', '', '', 'Propietario Casa Tasada. Urquiza 2378 Florida M.', '2008-06-02 00:00:00.0', '', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  6, 'Veronica', '', '', 0, '', '', '154-401-0465', 'pedido x telefono', NULL, '', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  7, 'Nicolas', '', '', 0, '5788-0292', '', '153-153-9495', '', NULL, '', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  8, 'Catherine', '', '', 0, '4797-4814', '', '', '', NULL, '', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  9, 'Maria Isabel ', 'Reyes', '', 0, '', '', '153-183-1358', 'Puede ser llamar a Ignacio Baronsse 4797-1028', NULL, 'mariaireyes@hotmail.com', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  10, 'Paola', '', '', 0, '', '', '156-467-7457', 'Llamo x 25 de mayo y maipu 1595', '2008-06-03 00:00:00.0', '', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  11, 'Gisela', '', '', 0, '', '', '155-249-8984', '', '2008-06-03 00:00:00.0', '', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  12, 'Hebe', '', '', 0, '', '5218-4856 int.12', '155-375-2959', 'vio maipu 1595 y quintana 800
ofreci maipu 3025 a 92.000', NULL, '', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  13, 'Guillermina', '', '', 0, '', '', '155-017-5731', '', NULL, '', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  14, 'Natalia', 'Ochoa', '', 0, '4799-5982', '', '', '', NULL, '', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  15, 'Maria de los Angeles', '', '', 0, '4767-8014', '', '155-958-1586', '', NULL, '', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  16, 'Cristina', '', '', 0, '4521-5642', '', '', 'Esposo 155-142-1386', NULL, '', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  17, 'Enrique', 'Berthet', '', 0, '', '', '155-923-1305', 'Amigo de Rodolfo Hentchel', NULL, '', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  18, 'Alejandra', 'Cosentino', '', 0, '4791-5011', '', '', '', NULL, '', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  19, 'Erika', '', '', 0, '4795-6405', '', '155-118-1023', 'Propietaria PH en alquiler lavalle 2290.
Intermediaria de las props. en Escobar', NULL, '', 'Lavalle', 2290, '', '', '', 'Juan B. Justo', 'Ayacucho', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  20, 'Nancy', '', '', 0, '4703-1596', '', '', '', NULL, '', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  21, 'Mariana', '', '', 0, '4797-1289', '', '154-096-6157', 'Propietaria de deposito en alquiler en Haedo 3541- Florida B.', NULL, '', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  22, 'Fernando', '', '', 0, '', '', '155-247-9868', 'Yerno de Susana --- Propietaria de depto en Maipu 3025 - 11ºB - Olivos
Susana: 4794-8736 / 155-982-9834

Depto a nombre de sus hijas:
Maria Cecilia San Miguel / Mariela San Miguel', NULL, '', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  23, 'Florencia', 'Mouriño', '', 0, '4522-7558', '', '156-283-4024', 'Esposa de Francisco Ochoa.
Vendió LLerena 3056 Capital
Compra Ruben Dario 4474 Munro', NULL, 'mfmourino@yahoo.com.ar', 'Llerena', 3056, '', '', '', 'Andonaegui', '', NULL, 3, 1, 28 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  24, 'Francisco', 'Ulloa', '', 0, '', '', '155-690-4601', 'Esposo de Florencia mouriño
Vendió LLerena 3056 Capital
Compra Ruben Dario 4474 Munro', NULL, '', 'Llerena', 3056, '', '', '', '', '', NULL, 3, 1, 28 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  25, 'Angelica', 'Spada', '', 0, '4791-1295', '', '', 'Propietaria PH Quintana 876.
Compra depto. 3 ambientes en Maipu 1500.

Hija, Monica: 4796-0357 / 156-6026', NULL, '', 'Quintana', 876, '4', '', '1602', 'Güemes', 'Melo', 3, 1, 1, 1 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  26, 'Ana', 'Garcia', '', 0, '4756-2254', '', '156-171-4673', 'Esposo de Eduardo 
Propietarios Ruben Dario 4474 - Munro
Compran Entre Rios 3959 - Olivos (Tizado)', NULL, 'anav.garcia@yahoo.com', 'Ruben Dario', 4474, '', '', '', '', '', 5, 1, 1, 1 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  27, 'Eduardo', '', '', 0, '4756-2254', '4008-2068', '156-159-5894', 'Esposo de Ana Garcia.
Propietarios Ruben Dario 4474 - Munro
Compran Entre Rios 3959 - Olivos (Tizado)', NULL, '', 'Ruben Dario', 4474, '', '', '', '', '', 5, 1, 1, 1 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  28, 'Ines', 'Vallejos', '', 0, '4790-4172', '', '', 'Propietaria de Pedro Goyena 4118 Olivos 1º piso.

Paciente de Dr. Biaggi / Marta', NULL, '', 'Pedro goyena', 4118, '', '1', '', '', '', 6, 1, 1, 1 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  29, 'Mariana', 'Litta', '', 0, '4791-5724', '4327-1308', '153-193-1111', 'Amiga de Jose.

Esposa de Hernan Carlos Garcia (156-304-4444)
Vende depto. 4 amb. en Valle Grande 1506 6ºA Florida', NULL, 'mlitta2001@yahoo.com.ar', 'Valle Grande', 1506, 'A', '6', '1602', 'Av. San Martin', '', 3, 1, 1, 1 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  30, 'Elza', '', '', 0, '4797-8469', '', '', 'Propietaria de A Alvarez 2435 Florida M.

Hija: Natacha: 155-412-3930 / (casa) 4797-8469 - (trabajo) 4372-9664', NULL, '', 'A. Alvarez', 2435, '', '', '1602', 'Sarmiento', 'Ohiggins', 3, 1, 1, 1 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  31, 'Margarita', 'Pardo', '', 0, '4799-4344', '', '154-940-8220', 'Esposa de Luis Valentini

Vende Bermudez 3189 Olivos
Compra Depto ern  VAlle Grande 1506 6ºA Florida M. (Litta)', NULL, '', 'Bermudez', 3189, '', '', '', 'Ohiggins', '', 6, 1, 1, 1 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  32, 'Luis', 'Valentini', '', 0, '4799-4344', '', '', 'Esposo de Margarita Pardo

Vende Bermudez 3189 Olivos
Compra Depto ern  VAlle Grande 1506 6ºA Florida M. (Litta)', NULL, '', 'Bermudez', 3189, '', '', '1636', 'Ohiggins', '', 6, 1, 1, 1 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  33, 'Karina', 'Alvarez', '', 0, '4791-3940', '', '156-645-1511', 'Propietaria de casa Lavalle 2387 - Florida M.', NULL, '', 'Urquiza', 2233, '', '', '1602', 'Ayacucho', 'España', 3, 1, 1, 1 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  34, 'Susana', '', '', 0, '4790-8393', '', '154-536-4242', 'Propietaria de Casa Quintana 3264 Olivos.
Tasó Silvia Berrade. 
Quiere depto de 3 ambientes cuando venda su casa.', NULL, '', 'Quintana', 3264, '', '', '', 'Borges', '', 6, 1, 1, 1 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  35, 'Marta', '', '', 0, '4709-3533', '', '155-150-3105', 'Propietaria casa Pintor Gutierrez 270 (Barrio Parque) Villa Martelli', NULL, '', 'Pintor Gutierrez', 270, '', '', '', '', '', 2, 1, 1, 1 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  36, 'Malia', 'Garmendia', '', 0, '4791-7831', '', '', 'Propietaria de Chalet en Madero 665 Vicente lopez.

Ella ofrecio la propiedad en la oficina en agosto de 2006.
Vimos la casa con ella y el marido presentes.', NULL, '', 'Madero', 665, '', '', '1638', 'Lavalle ', 'Las Heras', 1, 1, 1, 1 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  37, 'Laura', 'Longo', '', 0, '4797-3949', '4760-0694', '155-563-1460', 'EX Esposa de Eduardo Radanyi
Local Av San Martin 3240 Florida B. (4760-0694/5760)', NULL, '', 'Av. Maipú', 1551, 'B', '3', '1636', 'Arenales', 'Av. San martin', 1, 1, 1, 1 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  38, 'Juan ', 'Altamirano', '', 0, '', '4718-2537', '155-228-2939', 'Socio Constructora/Fideicomiso de obra JUAN B JUSTO 653 FLORIDA M.

Socio de Osvaldo Curzi 4761-4654 / 155-919-6915', NULL, 'jmaltamirano@easytradegroup.com', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  39, 'Christian', 'Schmee', '', 0, '', '4804-2115/6', '155-795-4821', 'Propietario de Depto. Riucardo Gutierrez 965 1º B (ALQUILADO)', NULL, 'christian@uramerica.co.uk', '', 0, '', '', '', '', '', 6, 1, 1, 1 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  40, 'Alberto', 'Vazquez', '', 0, '', '4791-9754', '', 'Empleado Los 4 Hnos. Unidos

Propietario (60%) propiedad Liniers 248 Florida M.
hijos de primos el 40% restante.
En sucesion finalizada junio 2008', NULL, '', 'A.Alvarez', 2345, '', '', '1602', 'Sarmiento', 'Juan B. Justo', 3, 1, 1, 1 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  41, 'Noe', 'Arquitecto', '', 0, '470-7848', '', '', '', NULL, '', '', 0, '', '', '', '', '', 6, 1, 1, 1 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  42, 'Haydee', '', '', 0, '4760-1450', '', '', 'Propietaria de Santa Rosa 2780 Florida M.
Paciente de Dr. Biaggi / Marta

Madre de Viviana Duran (ex. Corrientes 1463- olivos)', NULL, '', 'Santa rosa ', 2780, '', '', '1602', 'Warnes', 'Valle Grande', 3, 1, 1, 1 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  43, 'Mirta Beatriz', 'Rubino', '11633555', 0, '4711-9281', '', '155-514-8545', 'Dirección donde alquila.', NULL, '', 'Ricardo Gutierrez', 965, 'B', '1', '1636', 'est. Borges (Tren de la Costa)', '', 6, 1, 1, 1 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  44, 'Guido', '', '', 0, '', '', '153-164-5709', '', NULL, '', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  45, 'Marta', '', '', 0, '4796-4412', '', '155-143-6130', 'Propietaria dúplex Avellaneda 1793 - Florida

Hija: Florencia', NULL, '', 'Avellaneda', 1793, '', '', '1602', 'Irigoyen', 'Libertad', 3, 1, 1, 1 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  46, 'Paula', '', '', 0, '4811-9780', '', '', 'LLAMAR X LA TARDE', NULL, '', '', 0, '', '', '', '', '', NULL, NULL, 1, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  47, 'Mirta Beatriz', 'Brambati', '5444690', 1, '4759-0818', '', '', 'Propietaria de depto 1 1/2 amb. en Maipu 1585', NULL, '', 'Pelagio Luna', 2339, '', '', '', '', '', 40, 1, 1, 29 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  48, 'Maria de la Paz', 'Fernandez', '', 0, '4795-2576', '', '', 'Tiene credito para inquilinos de Bco. Nación', NULL, '', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  49, 'Mercedez', '', '', 0, '4796-2063', '', '', 'Propietario sr. Jorge Luis Puente (Sucesión)

Otro contacto posible, sra. Patricia Puente 4799-6521', NULL, '', 'Av. Maipú', 1595, 'C', '12', '1636', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  50, 'Ana', '', '', 0, '4741-1544', '', '', 'cuñada q vive en Juan B Justo 3692: Mercedez 4790-4140', NULL, '', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  51, 'Darío', '', '', 0, '4791-8519', '', '156-649-2937', 'esposa: Carla 156-649-2935', NULL, '', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  52, 'Hector', '', '', 0, '4761-4692', '', '', 'Hijo Claudio 4797-9020 (local)
es quien esta alquilando en este momento el local de Maipu 1209', NULL, '', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  53, 'Susana', '', '', 0, '4760-8246', '', '', 'Paciente Dr. Biaggi / Marta
Propietarios de Rosetti 1142 y Vergara 3044 en Florioda M.', NULL, '', 'Rosetti', 1142, '', '', '1602', '', '', 3, 1, 1, 1 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  54, 'Ana Laura', 'Lloberas', '30706033', 0, '.', '', '', 'Inquilina depto España 1667 4ºC Florida M. de Roberto Pirsztuk', NULL, '', 'José Ingenieros', 4950, '', '', '', '', '', 5, 1, 1, 1 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  55, 'Roberto', 'Pirsztuk', '', 0, '', '4791-9754', '', 'Tío de Jose, propietario de depto. España 1667 4º C Florida M.', NULL, '', 'A. Alvarez', 2345, '', '', '', 'Sarmiento', 'Juan B. Justo', 3, 1, 1, 1 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  56, 'Vanina', '', '', 0, '', '', '156-791-4848', '', NULL, 'vaninazallocco@hotmail.com', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  57, 'Natalia', '', '', 0, '4903-3251', '', '1559616331', '', NULL, '', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  58, 'Pablo Fabián', 'Ciaglia', '18057478', 0, '4568-8620', '4795-0345', '155-951-9660', 'Esposa: Soledad', NULL, '', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  59, 'Alejando', '', '', 0, '4837-0904', '', '153-153-9193', 'quiere PH, No depto. 2/3 amb.', NULL, '', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  60, 'Alejandro', '', '', 0, '4837-0904', '', '1531539193', '', NULL, '', '', 0, '', '', '', '', '', NULL, 1, 1, 1 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  61, 'Javier', 'Irsius', '', 0, '4760-6582', '', '155-177-7557', '', NULL, '', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  62, 'Andrea', '', '', 0, '4793-6085', '', '', '', '2008-06-19 00:00:00.0', '', '', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  63, 'Adriana', 'Marcuzzi de Bonafina', '', 0, '471-7017', '', '154-176-9135', '', '2008-06-21 00:00:00.0', '', 'Arenales 1359', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  64, 'Adriana', 'Marcuzzi de Bonafina', '', 0, '471-7017', '', '154-176+9135', '', '2008-06-21 00:00:00.0', '', 'Arenales 1359', 0, '', '', '', '', '', NULL, NULL, NULL, NULL )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  65, 'Adriana', 'Marcuzzi de Bonafina', '', 0, '4791-7017', '', '154-176-9135', 'Busqueda de depto appto profesional en Maipú y Arenales Hasta $ 1000, Puede COMPRAR TAMBIEN', '2008-06-21 00:00:00.0', '', 'Arenales ', 1359, '', '', '', 'Maipú', '', NULL, 1, 1, 1 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  66, 'Gilda ', 'Moltrasi', '24938776', 0, '4554-8994', '', '155-840-2605', 'Propietari del depto. 2 amb. en Venta misma dirección donde vive.', NULL, '', 'Ciudad de la Paz', 347, 'A', '3', '', 'Jorge Newbery', 'Matienzo', NULL, 3, 1, 24 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  67, 'Diego Carlos', 'Carron', '26632865', 0, '', '4515-0131', '155-493-0585', 'Alquila depto. que figura en direccion.', NULL, '', 'Av. maipu', 1589, 'C', '9', '', 'Arenales', 'Av. San Martin', 3, 1, 1, 1 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  68, 'Maria Eugenia', 'Gonzalez Russo', '29855975', 0, '4718-2459', '', '', 'Novio Juan: 155-849-8291

Dirección en donde alquilan.', NULL, '', 'Av. San Martin', 2049, 'D', '2', '1602', 'Liniers', 'Jose M. Paz', 3, 1, 1, 1 )
go
INSERT INTO [dbo].[Clientes] ( [IdCliente], [Nombres], [Apellido], [NroDocumento], [TipoDocumento], [TelefonoParticular], [TelefonoTrabajo], [TelefonoCelular], [Observaciones], [FechaNacimiento], [Email], [Calle], [Numero], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [IdBarrio], [IdProvincia], [IdPais], [IdLocalidad] ) VALUES(  69, 'Martha Ofelia', 'Mora', '4443762', 1, '4760-3870', '', '', 'MAMA DE JOSE (PIME)', '1942-07-04 11:10:22.0', '', 'Ohiggins', 660, '', '', '', 'Lavalle', 'Las Heras', 3, 1, 1, 1 )
go
SET IDENTITY_INSERT [dbo].[Clientes] OFF
go
INSERT INTO [dbo].[ClientesPedido] ( [IdCliente] ) VALUES(  6 )
go
INSERT INTO [dbo].[ClientesPedido] ( [IdCliente] ) VALUES(  7 )
go
INSERT INTO [dbo].[ClientesPedido] ( [IdCliente] ) VALUES(  8 )
go
INSERT INTO [dbo].[ClientesPedido] ( [IdCliente] ) VALUES(  9 )
go
INSERT INTO [dbo].[ClientesPedido] ( [IdCliente] ) VALUES(  10 )
go
INSERT INTO [dbo].[ClientesPedido] ( [IdCliente] ) VALUES(  11 )
go
INSERT INTO [dbo].[ClientesPedido] ( [IdCliente] ) VALUES(  12 )
go
INSERT INTO [dbo].[ClientesPedido] ( [IdCliente] ) VALUES(  13 )
go
INSERT INTO [dbo].[ClientesPedido] ( [IdCliente] ) VALUES(  14 )
go
INSERT INTO [dbo].[ClientesPedido] ( [IdCliente] ) VALUES(  15 )
go
INSERT INTO [dbo].[ClientesPedido] ( [IdCliente] ) VALUES(  16 )
go
INSERT INTO [dbo].[ClientesPedido] ( [IdCliente] ) VALUES(  17 )
go
INSERT INTO [dbo].[ClientesPedido] ( [IdCliente] ) VALUES(  18 )
go
INSERT INTO [dbo].[ClientesPedido] ( [IdCliente] ) VALUES(  20 )
go
INSERT INTO [dbo].[ClientesPedido] ( [IdCliente] ) VALUES(  44 )
go
INSERT INTO [dbo].[ClientesPedido] ( [IdCliente] ) VALUES(  46 )
go
INSERT INTO [dbo].[ClientesPedido] ( [IdCliente] ) VALUES(  48 )
go
INSERT INTO [dbo].[ClientesPedido] ( [IdCliente] ) VALUES(  51 )
go
INSERT INTO [dbo].[ClientesPedido] ( [IdCliente] ) VALUES(  56 )
go
INSERT INTO [dbo].[ClientesPedido] ( [IdCliente] ) VALUES(  57 )
go
INSERT INTO [dbo].[ClientesPedido] ( [IdCliente] ) VALUES(  58 )
go
INSERT INTO [dbo].[ClientesPedido] ( [IdCliente] ) VALUES(  59 )
go
INSERT INTO [dbo].[ClientesPedido] ( [IdCliente] ) VALUES(  60 )
go
INSERT INTO [dbo].[ClientesPedido] ( [IdCliente] ) VALUES(  62 )
go
INSERT INTO [dbo].[ClientesPedido] ( [IdCliente] ) VALUES(  63 )
go
INSERT INTO [dbo].[ClientesPedido] ( [IdCliente] ) VALUES(  64 )
go
INSERT INTO [dbo].[ClientesPedido] ( [IdCliente] ) VALUES(  65 )
go
SET IDENTITY_INSERT [dbo].[Contratos] ON
go
INSERT INTO [dbo].[Contratos] ( [IdContrato], [IdInquilino], [IdPropiedad], [FechaInicio], [FechaVencimiento], [MontoDeposito], [IdMonedaDeposito], [DiaVencimientoCuota], [IdContratoAnterior], [FechaCancelacion], [Observaciones], [Vigente] ) VALUES(  5, NULL, 66, '2008-05-14 18:39:22.03', '2008-05-14 18:39:22.03', 0, 1, 0, NULL, NULL, '', 1 )
go
INSERT INTO [dbo].[Contratos] ( [IdContrato], [IdInquilino], [IdPropiedad], [FechaInicio], [FechaVencimiento], [MontoDeposito], [IdMonedaDeposito], [DiaVencimientoCuota], [IdContratoAnterior], [FechaCancelacion], [Observaciones], [Vigente] ) VALUES(  6, NULL, 67, '2008-05-14 18:40:00.407', '2008-05-14 18:40:00.407', 0, 1, 0, NULL, NULL, '', 1 )
go
INSERT INTO [dbo].[Contratos] ( [IdContrato], [IdInquilino], [IdPropiedad], [FechaInicio], [FechaVencimiento], [MontoDeposito], [IdMonedaDeposito], [DiaVencimientoCuota], [IdContratoAnterior], [FechaCancelacion], [Observaciones], [Vigente] ) VALUES(  7, NULL, 71, '2008-05-14 18:40:20.673', '2008-05-14 18:40:20.673', 0, 1, 0, NULL, NULL, '', 1 )
go
INSERT INTO [dbo].[Contratos] ( [IdContrato], [IdInquilino], [IdPropiedad], [FechaInicio], [FechaVencimiento], [MontoDeposito], [IdMonedaDeposito], [DiaVencimientoCuota], [IdContratoAnterior], [FechaCancelacion], [Observaciones], [Vigente] ) VALUES(  8, 43, 83, '2008-05-01 00:00:00.0', '2010-05-31 00:00:00.0', 2000, 1, 10, NULL, NULL, '', 1 )
go
INSERT INTO [dbo].[Contratos] ( [IdContrato], [IdInquilino], [IdPropiedad], [FechaInicio], [FechaVencimiento], [MontoDeposito], [IdMonedaDeposito], [DiaVencimientoCuota], [IdContratoAnterior], [FechaCancelacion], [Observaciones], [Vigente] ) VALUES(  9, 67, 84, '2008-05-15 00:00:00.0', '2010-06-15 00:00:00.0', 950, 1, 10, NULL, NULL, '', 1 )
go
INSERT INTO [dbo].[Contratos] ( [IdContrato], [IdInquilino], [IdPropiedad], [FechaInicio], [FechaVencimiento], [MontoDeposito], [IdMonedaDeposito], [DiaVencimientoCuota], [IdContratoAnterior], [FechaCancelacion], [Observaciones], [Vigente] ) VALUES(  10, NULL, 78, '2008-06-24 00:00:00.0', '2008-06-24 00:00:00.0', 0, 1, 0, NULL, NULL, '', 1 )
go
SET IDENTITY_INSERT [dbo].[Contratos] OFF
go
INSERT INTO [dbo].[EstadosPropiedad] ( [IdEstadoPropiedad], [Nombre], [TipoClasePropiedad] ) VALUES(  1, 'En Venta', 'GI.BR.Propiedades.Venta' )
go
INSERT INTO [dbo].[EstadosPropiedad] ( [IdEstadoPropiedad], [Nombre], [TipoClasePropiedad] ) VALUES(  2, 'Reservado', 'GI.BR.Propiedades.Venta' )
go
INSERT INTO [dbo].[EstadosPropiedad] ( [IdEstadoPropiedad], [Nombre], [TipoClasePropiedad] ) VALUES(  3, 'Vendido', 'GI.BR.Propiedades.Venta' )
go
INSERT INTO [dbo].[EstadosPropiedad] ( [IdEstadoPropiedad], [Nombre], [TipoClasePropiedad] ) VALUES(  4, 'Tasación', 'GI.BR.Propiedades.Venta' )
go
INSERT INTO [dbo].[EstadosPropiedad] ( [IdEstadoPropiedad], [Nombre], [TipoClasePropiedad] ) VALUES(  5, 'Historico', 'GI.BR.Propiedades.Venta' )
go
INSERT INTO [dbo].[EstadosPropiedad] ( [IdEstadoPropiedad], [Nombre], [TipoClasePropiedad] ) VALUES(  6, 'En Alquiler', 'GI.BR.Propiedades.Alquiler' )
go
INSERT INTO [dbo].[EstadosPropiedad] ( [IdEstadoPropiedad], [Nombre], [TipoClasePropiedad] ) VALUES(  7, 'Reservado', 'GI.BR.Propiedades.Alquiler' )
go
INSERT INTO [dbo].[EstadosPropiedad] ( [IdEstadoPropiedad], [Nombre], [TipoClasePropiedad] ) VALUES(  8, 'Alquilado', 'GI.BR.Propiedades.Alquiler' )
go
INSERT INTO [dbo].[EstadosPropiedad] ( [IdEstadoPropiedad], [Nombre], [TipoClasePropiedad] ) VALUES(  9, 'Historico', 'GI.BR.Propiedades.Alquiler' )
go
INSERT INTO [dbo].[EstadosPropiedad] ( [IdEstadoPropiedad], [Nombre], [TipoClasePropiedad] ) VALUES(  10, 'Suspendido', 'GI.BR.Propiedades.Venta' )
go
INSERT INTO [dbo].[EstadosPropiedad] ( [IdEstadoPropiedad], [Nombre], [TipoClasePropiedad] ) VALUES(  11, 'Suspendido', 'GI.BR.Propiedades.Alquiler' )
go
SET IDENTITY_INSERT [dbo].[GaleriaFotos] ON
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  21, 34, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  22, 35, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  23, 34, 0, 'living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  24, 34, 0, 'dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  25, 34, 0, 'dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  26, 34, 0, 'lavadero' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  27, 34, 0, 'baño' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  28, 34, 0, 'vista' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  29, 35, 0, 'Living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  31, 35, 0, 'Comedor' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  32, 35, 0, 'Living-Comedor' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  33, 35, 0, 'Dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  34, 35, 0, 'Jardín' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  35, 35, 0, 'Patio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  36, 36, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  37, 36, 0, 'living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  38, 36, 0, 'living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  39, 36, 0, 'Cocina-Comedor' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  40, 36, 0, 'dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  41, 36, 0, 'Baño completo' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  42, 36, 0, 'Balcón' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  43, 37, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  44, 37, 0, 'planta' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  45, 37, 0, 'vista' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  46, 37, 0, 'vista' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  47, 37, 0, 'vista' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  48, 37, 0, 'dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  49, 37, 0, 'frente calle' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  50, 37, 0, 'edificio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  51, 38, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  52, 38, 0, 'living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  53, 38, 0, 'cocina' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  54, 38, 0, 'dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  55, 38, 0, 'baño' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  56, 38, 0, 'vista 1' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  57, 38, 0, 'vista 2' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  58, 38, 0, 'edificio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  59, 40, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  60, 40, 0, 'Comedor diario' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  61, 40, 0, 'Cocina' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  62, 40, 0, 'Baño completo' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  63, 41, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  64, 42, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  65, 42, 0, 'Living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  66, 42, 0, 'Living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  67, 42, 0, 'Cocina' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  68, 42, 0, 'Dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  69, 42, 0, 'dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  70, 42, 0, 'Pasillo' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  71, 42, 0, 'Patio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  72, 43, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  74, 43, 0, 'Living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  75, 43, 0, 'Comedor' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  76, 43, 0, 'Cocina Comedor' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  77, 43, 0, 'Jardín' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  78, 43, 0, 'frente' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  79, 43, 0, 'pileta' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  80, 43, 0, 'Patio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  81, 44, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  82, 44, 0, 'Living Comedor' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  83, 44, 0, 'Comdor diario' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  84, 44, 0, 'Cocina' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  85, 44, 0, 'Dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  86, 44, 0, 'Dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  87, 44, 0, 'Dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  88, 44, 0, 'Baño completo' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  89, 44, 0, 'Lavadero' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  90, 44, 0, 'Patio Terraza' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  91, 44, 0, 'Balcón' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  92, 45, 0, 'Living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  93, 45, 0, 'Living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  94, 45, 0, 'Estar' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  95, 45, 0, 'Cocina Comedor' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  96, 45, 0, 'Dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  97, 45, 0, 'Dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  98, 45, 0, 'Dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  99, 45, 0, 'Toilette' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  100, 45, 0, 'Baño completo' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  101, 48, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  102, 48, 0, 'Living Comedor' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  103, 48, 0, 'Living Comedor' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  104, 48, 0, 'Comdor diario' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  105, 48, 0, 'Dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  106, 48, 0, 'Dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  107, 48, 0, 'Playroom' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  108, 48, 0, 'Playroom' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  109, 48, 0, 'Baño c/antebaño' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  110, 49, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  111, 49, 0, 'Frente' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  112, 49, 0, 'Patio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  113, 49, 0, 'Jardín' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  114, 49, 0, 'Cocina' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  115, 49, 0, 'Dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  116, 49, 0, 'Baño completo' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  117, 49, 0, 'Dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  118, 49, 0, 'Dependencia' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  119, 50, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  120, 50, 0, 'Casa 3 ambientes' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  121, 50, 0, 'Casa 2 ambientes' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  122, 50, 0, 'Frente' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  123, 50, 0, 'Pileta' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  124, 46, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  125, 46, 0, 'Lote' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  126, 51, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  127, 51, 0, 'Frente' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  128, 52, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  129, 52, 0, 'Living comedor' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  130, 52, 0, 'Living comedor' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  131, 52, 0, 'Cocina comedor' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  132, 52, 0, 'Dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  133, 52, 0, 'Dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  134, 52, 0, 'Playroom' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  135, 52, 0, 'Baño c/hidroamasaje' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  136, 52, 0, 'Jardín' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  137, 52, 0, 'Jardín' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  138, 53, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  139, 54, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  140, 55, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  141, 55, 0, 'Frente' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  142, 57, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  143, 57, 0, 'Living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  144, 57, 0, 'Living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  145, 57, 0, 'Cocina' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  146, 57, 0, 'Comedor diario' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  147, 57, 0, 'Dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  148, 57, 0, 'Baño en suite c/yacuzzi' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  149, 57, 0, 'Dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  150, 57, 0, 'Dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  151, 57, 0, 'Quincho' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  152, 57, 0, 'Jardín c/piscina' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  153, 58, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  154, 58, 0, 'Living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  155, 58, 0, 'Living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  156, 58, 0, 'Comedor diario' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  157, 58, 0, 'Dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  158, 58, 0, 'Dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  159, 58, 0, 'Patio terraza' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  160, 58, 0, 'Jardín c/piscina' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  161, 59, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  162, 59, 0, 'frente' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  164, 59, 0, 'Lateral' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  165, 59, 0, 'Fondo' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  166, 61, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  167, 61, 0, 'Edificio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  168, 61, 0, 'Living ' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  169, 61, 0, 'Cocina' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  170, 61, 0, 'dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  171, 61, 0, 'Baño completo' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  172, 61, 0, 'Living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  173, 61, 0, 'Balcón' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  174, 62, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  175, 62, 0, 'Edificio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  176, 62, 0, 'Living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  177, 62, 0, 'Living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  178, 62, 0, 'Cocina' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  179, 62, 0, 'Dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  180, 62, 0, 'Baño completo' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  181, 62, 0, 'Vista balcón' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  182, 62, 0, 'Vista living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  183, 62, 0, 'Cocheras' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  184, 61, 0, 'Vista' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  185, 61, 0, 'Cocheras' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  186, 63, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  187, 66, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  188, 66, 0, 'Living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  189, 66, 0, 'Living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  190, 66, 0, 'Cocina' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  191, 66, 0, 'Dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  192, 66, 0, 'Baño completo' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  193, 68, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  194, 68, 0, 'Living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  195, 68, 0, 'Cocina comedor' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  196, 68, 0, 'Dormitorio c/placard' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  197, 68, 0, 'Dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  198, 68, 0, 'Dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  199, 68, 0, 'Hall de distribución P.A.' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  201, 68, 0, 'Lavadero' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  202, 68, 0, 'Baño completo' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  203, 68, 0, 'Terraza' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  204, 69, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  205, 69, 0, 'Living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  206, 69, 0, 'Cocina' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  207, 69, 0, 'Dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  208, 69, 0, 'Baño' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  209, 69, 0, 'Vista' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  210, 69, 0, 'Vista' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  211, 70, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  212, 70, 0, '3º cuerpo' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  213, 70, 0, 'Living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  214, 70, 0, 'Living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  215, 70, 0, 'Cocina' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  217, 70, 0, 'Vista al Río' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  218, 70, 0, 'Vista a la ciudad' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  219, 71, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  220, 72, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  221, 72, 0, 'Entrada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  222, 72, 0, 'Jardín/Quincho/Garage' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  223, 72, 0, 'Fondo' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  224, 74, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  225, 74, 0, 'Contrafrente' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  226, 74, 0, 'Living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  227, 74, 0, 'Living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  228, 74, 0, 'Cocina' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  229, 74, 0, 'Dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  230, 74, 0, 'Baño' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  231, 74, 0, 'Vista' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  232, 74, 0, 'Vista' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  233, 74, 0, 'Vista' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  234, 76, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  235, 47, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  236, 47, 0, 'comedor' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  237, 47, 0, 'living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  238, 47, 0, 'estar' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  239, 47, 0, 'estar' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  240, 47, 0, 'pasillo' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  241, 47, 0, 'cocina' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  242, 47, 0, 'cocina' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  243, 47, 0, 'cocina' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  244, 47, 0, 'Comedor diario' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  245, 47, 0, 'Baño' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  246, 47, 0, 'Baño' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  247, 47, 0, 'Jardín' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  248, 56, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  249, 56, 0, 'Living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  250, 56, 0, 'Cocina comedor' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  251, 56, 0, 'Living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  252, 56, 0, 'Salon / Quincho' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  253, 56, 0, 'Jardin' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  255, 81, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  256, 81, 0, 'Living Comedor' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  257, 81, 0, 'Cocina' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  258, 81, 0, 'Dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  259, 81, 0, 'Dormitorio c/placard' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  260, 81, 0, 'Baño completo' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  261, 81, 0, 'Edificio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  262, 82, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  263, 79, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  264, 79, 0, 'Living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  265, 79, 0, 'Cocina' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  266, 79, 0, 'Pasillo' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  267, 79, 0, 'Dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  268, 79, 0, 'Dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  269, 79, 0, 'Baño completo' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  270, 79, 0, 'Vista Balcón' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  271, 79, 0, 'Vista balcón' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  272, 79, 0, 'Vista ' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  273, 79, 0, 'Lavadero' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  274, 83, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  275, 83, 0, 'Edificio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  276, 83, 0, 'Living ' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  277, 83, 0, 'Cocina' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  278, 83, 0, 'dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  279, 83, 0, 'Baño completo' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  280, 83, 0, 'Living' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  281, 83, 0, 'Balcón' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  282, 83, 0, 'Vista' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  283, 83, 0, 'Cocheras' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  284, 39, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  285, 84, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  286, 86, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  287, 90, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  288, 97, 1, 'Fachada' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  289, 97, 0, 'Palier' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  290, 97, 0, 'Living Comedor' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  291, 97, 0, 'Living Comedor' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  292, 97, 0, 'Cocina' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  293, 97, 0, 'Cocina' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  294, 97, 0, 'Pasillo' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  295, 97, 0, 'Dormitorio' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  296, 97, 0, 'Living - Cocina' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  297, 97, 0, 'Baño' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  298, 97, 0, 'Balcón' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  299, 97, 0, 'Cochera cubierta' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  300, 97, 0, 'Piscina' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  301, 97, 0, 'Parrilla' )
go
--The following columns were excluded due to unsupported datatypes: [Foto]
INSERT INTO [dbo].[GaleriaFotos] ( [IdFoto], [IdPropiedad], [EsFachada], [Descripcion] ) VALUES(  302, 95, 0, 'Cocina' )
go
SET IDENTITY_INSERT [dbo].[GaleriaFotos] OFF
go
SET IDENTITY_INSERT [dbo].[InmobiliariasExternas] ON
go
INSERT INTO [dbo].[InmobiliariasExternas] ( [IdInmobiliaria], [Nombre], [Telefono], [Contacto] ) VALUES(  1, 'Berrade Propiedades', '4794-8857', 'Silvia / Juan / Iabel' )
go
INSERT INTO [dbo].[InmobiliariasExternas] ( [IdInmobiliaria], [Nombre], [Telefono], [Contacto] ) VALUES(  2, 'Berrade Propiedades', '4794-8857', 'Silvia / Juan / Isabel' )
go
INSERT INTO [dbo].[InmobiliariasExternas] ( [IdInmobiliaria], [Nombre], [Telefono], [Contacto] ) VALUES(  3, 'Elcano & Geremia', '4791-2844', 'Fabio / Esteban' )
go
INSERT INTO [dbo].[InmobiliariasExternas] ( [IdInmobiliaria], [Nombre], [Telefono], [Contacto] ) VALUES(  4, 'Administracion Malaver', '4796-7559', 'Alberto' )
go
INSERT INTO [dbo].[InmobiliariasExternas] ( [IdInmobiliaria], [Nombre], [Telefono], [Contacto] ) VALUES(  5, 'Illarietti Propiedades', '4796-9676', 'Diego Illarietti' )
go
INSERT INTO [dbo].[InmobiliariasExternas] ( [IdInmobiliaria], [Nombre], [Telefono], [Contacto] ) VALUES(  6, 'Tizado (Vte Lopez)', '4797-0770', 'Nadia / Veronica Aschieri' )
go
INSERT INTO [dbo].[InmobiliariasExternas] ( [IdInmobiliaria], [Nombre], [Telefono], [Contacto] ) VALUES(  7, 'Frias Baquero', '4797-7001', 'Lidia de Baquero' )
go
INSERT INTO [dbo].[InmobiliariasExternas] ( [IdInmobiliaria], [Nombre], [Telefono], [Contacto] ) VALUES(  8, 'Bezruk', '4793-8505', 'Carlos Bezruk / Claudio' )
go
INSERT INTO [dbo].[InmobiliariasExternas] ( [IdInmobiliaria], [Nombre], [Telefono], [Contacto] ) VALUES(  9, 'Silvia Cragno', '4791-0361', 'Ariel' )
go
INSERT INTO [dbo].[InmobiliariasExternas] ( [IdInmobiliaria], [Nombre], [Telefono], [Contacto] ) VALUES(  10, 'Bucafusco', '4794-5579', 'Blanca' )
go
INSERT INTO [dbo].[InmobiliariasExternas] ( [IdInmobiliaria], [Nombre], [Telefono], [Contacto] ) VALUES(  11, 'Mariela Folino', '4796-7813', 'Anibal' )
go
INSERT INTO [dbo].[InmobiliariasExternas] ( [IdInmobiliaria], [Nombre], [Telefono], [Contacto] ) VALUES(  12, 'Gaudiero Bianco', '4796-3575', 'Sergio Gaudiero' )
go
INSERT INTO [dbo].[InmobiliariasExternas] ( [IdInmobiliaria], [Nombre], [Telefono], [Contacto] ) VALUES(  13, 'La Salle propiedades', '4796-2222', 'Alberto Calzetta' )
go
INSERT INTO [dbo].[InmobiliariasExternas] ( [IdInmobiliaria], [Nombre], [Telefono], [Contacto] ) VALUES(  14, 'Picasso', '4796-3090', 'Graciela' )
go
INSERT INTO [dbo].[InmobiliariasExternas] ( [IdInmobiliaria], [Nombre], [Telefono], [Contacto] ) VALUES(  15, 'Bez Propiedades', '4799-8428', 'Graciela' )
go
INSERT INTO [dbo].[InmobiliariasExternas] ( [IdInmobiliaria], [Nombre], [Telefono], [Contacto] ) VALUES(  16, 'Zlata', '4791-9697', '.' )
go
INSERT INTO [dbo].[InmobiliariasExternas] ( [IdInmobiliaria], [Nombre], [Telefono], [Contacto] ) VALUES(  17, 'Oduch', '4790-8585', 'Liliana / Osvaldo Oduch' )
go
INSERT INTO [dbo].[InmobiliariasExternas] ( [IdInmobiliaria], [Nombre], [Telefono], [Contacto] ) VALUES(  18, 'Syr', '4796-9393', 'Federico' )
go
INSERT INTO [dbo].[InmobiliariasExternas] ( [IdInmobiliaria], [Nombre], [Telefono], [Contacto] ) VALUES(  19, 'Lopez Fernandez', '4791-7700', '.' )
go
INSERT INTO [dbo].[InmobiliariasExternas] ( [IdInmobiliaria], [Nombre], [Telefono], [Contacto] ) VALUES(  20, 'Carlos Castaño', '4795-9494', '.' )
go
INSERT INTO [dbo].[InmobiliariasExternas] ( [IdInmobiliaria], [Nombre], [Telefono], [Contacto] ) VALUES(  21, 'Castaño Propiedades', '4795-2245', '.' )
go
INSERT INTO [dbo].[InmobiliariasExternas] ( [IdInmobiliaria], [Nombre], [Telefono], [Contacto] ) VALUES(  22, 'Carmelo', '4797-9656', 'Omar Carmelo / Federico' )
go
INSERT INTO [dbo].[InmobiliariasExternas] ( [IdInmobiliaria], [Nombre], [Telefono], [Contacto] ) VALUES(  23, 'Hector Castaño', '4797-2400', 'Claudio' )
go
INSERT INTO [dbo].[InmobiliariasExternas] ( [IdInmobiliaria], [Nombre], [Telefono], [Contacto] ) VALUES(  24, 'Azara propiedades', '4795-4999 / 4797-4686', '.' )
go
INSERT INTO [dbo].[InmobiliariasExternas] ( [IdInmobiliaria], [Nombre], [Telefono], [Contacto] ) VALUES(  25, 'Cáneva', '4790-5594', 'Fabiana' )
go
INSERT INTO [dbo].[InmobiliariasExternas] ( [IdInmobiliaria], [Nombre], [Telefono], [Contacto] ) VALUES(  26, 'Geremia', '4756-5248 / 4762-5459', 'Esteban' )
go
INSERT INTO [dbo].[InmobiliariasExternas] ( [IdInmobiliaria], [Nombre], [Telefono], [Contacto] ) VALUES(  27, 'Aued', '4796-3900', 'Beatriz' )
go
INSERT INTO [dbo].[InmobiliariasExternas] ( [IdInmobiliaria], [Nombre], [Telefono], [Contacto] ) VALUES(  28, 'Ruiz Propiedades', '4797-4422', 'Federico' )
go
INSERT INTO [dbo].[InmobiliariasExternas] ( [IdInmobiliaria], [Nombre], [Telefono], [Contacto] ) VALUES(  29, 'Manzano', '4796-0356', 'Roberto Manzano' )
go
SET IDENTITY_INSERT [dbo].[InmobiliariasExternas] OFF
go
INSERT INTO [dbo].[Inquilinos] ( [IdCliente] ) VALUES(  43 )
go
INSERT INTO [dbo].[Inquilinos] ( [IdCliente] ) VALUES(  54 )
go
INSERT INTO [dbo].[Inquilinos] ( [IdCliente] ) VALUES(  67 )
go
INSERT INTO [dbo].[Inquilinos] ( [IdCliente] ) VALUES(  68 )
go
SET IDENTITY_INSERT [dbo].[Llamados] ON
go
--The following columns were excluded due to unsupported datatypes: [Comentarios]
INSERT INTO [dbo].[Llamados] ( [IdLlamado], [FechaHora], [Contacto], [Telefono], [IdPropiedad] ) VALUES(  1, '2008-05-16 18:05:45.0', 'Cecilia', '155-338-4949', 62 )
go
--The following columns were excluded due to unsupported datatypes: [Comentarios]
INSERT INTO [dbo].[Llamados] ( [IdLlamado], [FechaHora], [Contacto], [Telefono], [IdPropiedad] ) VALUES(  2, '2008-06-04 18:06:56.0', 'Carlos', '4799-6249', 62 )
go
SET IDENTITY_INSERT [dbo].[Llamados] OFF
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  1, 'Vicente Lopez', 1, 1 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  3, 'San Isidro', 0, 1 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  4, 'Avellaneda', 0, 1 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  5, 'Ezeiza', 0, 1 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  6, 'Ituzaingó', 0, 1 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  7, 'La Matanza', 0, 1 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  8, 'Lanús', 0, 1 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  9, 'Lomas de Zamora', 0, 1 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  10, 'Merlo', 0, 1 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  11, 'Moreno', 0, 1 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  12, 'Morón', 0, 1 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  13, 'Pilar', 0, 1 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  14, 'Quilmes', 0, 1 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  15, 'San Fernando', 0, 1 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  16, 'San Martín', 0, 1 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  17, 'San Miguel', 0, 1 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  18, 'Tigre', 0, 1 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  19, 'Escobar', 0, 1 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  20, 'Barrio Norte', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  21, 'Saavedra', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  22, 'Nuñez', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  23, 'Coghlan', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  24, 'Belgrano', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  25, 'Palermo', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  26, 'Partido de la Costa', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  27, 'Gral. Albarado', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  28, 'Villa Urquiza', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  29, '3 de Febrero', 0, 1 )
go
SET IDENTITY_INSERT [dbo].[MedidasAmbientesPropiedad] ON
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  16, 2.50, 2.00, 'Cocina', 1, 34, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  17, 3.90, 3.10, 'Dormitorio c/placard', 2, 34, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  18, 2.90, 2.90, 'Dormitorio c/placard', 1, 34, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  19, 2.30, 1.60, 'Baño completo', 1, 34, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  20, 4.60, 3.90, 'Living', 2, 34, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  21, 1.00, 1.00, 'Lavadero', 1, 34, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  22, 8.70, 4.00, 'Living-Comedor', 1, 35, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  23, 2.40, 2.50, 'Cocina', 1, 35, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  24, 3.70, 2.80, 'Comedor Diario', 1, 35, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  25, 4.00, 3.00, 'Dormitorio en suite', 3, 35, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  26, 3.90, 2.70, 'Dormitorio c/vestidor', 3, 35, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  27, 5.20, 2.30, 'Dormitorio c/placard', 3, 35, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  28, 1.80, 1.10, 'Toilette', 1, 35, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  29, 2.60, 2.10, 'Baño Suite', 1, 35, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  30, 2.10, 1.30, 'Lavadero', 1, 35, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  31, 5.00, 2.50, 'Garage', 1, 35, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  32, 6.00, 7.00, 'Jardín c/piscina', 1, 35, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  33, 3.00, 5.30, 'Quincho', 2, 35, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  34, 5.10, 3.00, 'Living', 7, 36, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  35, 3.40, 2.50, 'Cocina-Comedor', 2, 36, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  36, 5.10, 3.00, 'Dormitorio c/placard', 7, 36, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  37, 2.50, 1.60, 'Baño completo', 2, 36, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  38, 4.50, 0.90, 'Balcón', 1, 36, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  39, 3.60, 5.40, 'Living-Comedor', 1, 37, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  40, 4.30, 1.50, 'Cocina', 1, 37, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  41, 1.60, 1.50, 'Cyber', 1, 37, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  42, 2.50, 1.60, 'Baño completo', 2, 37, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  43, 3.30, 3.80, 'dormitorio', 1, 37, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  44, 3.30, 1.50, 'Balcón c/parrilla', 1, 37, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  45, 1.60, 1.50, 'Toilette', 1, 37, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  46, 3.80, 2.80, 'Living', 3, 38, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  47, 4.20, 2.50, 'Comedor', 3, 38, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  48, 4.20, 2.00, 'Cocina Comedor', 2, 38, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  49, 3.70, 2.80, 'Dormitorio c/placard', 3, 38, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  50, 3.20, 2.60, 'Dormitorio c/placard', 3, 38, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  51, 2.30, 1.50, 'Baño Completo', 2, 38, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  52, 5.00, 1.10, 'Balcon corrdio', 2, 38, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  53, 4.40, 3.20, 'Living', 2, 40, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  54, 3.50, 2.00, 'Cocina', 2, 40, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  55, 3.00, 2.80, 'Comedor diario', 2, 40, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  56, 4.40, 3.20, 'Dormitorio c/placard', 2, 40, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  57, 4.00, 4.00, 'Dormitorio', 2, 40, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  58, 4.00, 2.00, 'Entrepiso', 5, 40, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  59, 6.60, 2.90, 'Living', 3, 41, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  60, 2.80, 2.20, 'Cocina', 2, 41, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  61, 2.80, 1.70, 'Comedor Diario', 2, 41, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  62, 3.80, 2.80, 'Dormitorio c/placard', 4, 41, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  63, 2.90, 2.80, 'Dormitorio c/placard', 4, 41, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  64, 6.00, 1.10, 'Balcón', 2, 41, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  65, 6.60, 4.10, 'Living', 3, 42, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  66, 3.50, 2.30, 'Cocina Comedor', 2, 42, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  67, 4.10, 3.10, 'Dormitorio c/placard', 3, 42, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  68, 3.10, 3.50, 'Dormitorio c/placard', 3, 42, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  69, 4.00, 3.90, 'Living', 2, 43, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  70, 5.80, 2.60, 'Comedor', 2, 43, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  71, 3.20, 3.00, 'Cocina Comedor', 2, 43, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  72, 4.00, 3.40, 'Dormitorio', 4, 43, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  73, 3.20, 3.00, 'Dormitorio c/placard', 4, 43, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  74, 2.90, 1.50, 'Baño completo', 2, 43, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  75, 6.90, 4.60, 'Patio', 12, 43, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  76, 1.70, 2.40, 'Lavadero', 2, 43, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  77, 1.70, 2.50, 'Cuarto de Herramientas', 2, 43, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  78, 8.70, 18.00, 'Jardín c/pileta', 1, 43, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  79, 2.00, 2.00, 'Sótano', 6, 43, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  81, 3.30, 3.30, 'Cocina Comedor', 2, 44, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  82, 3.30, 3.20, 'Dormitorio c/placard', 3, 44, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  83, 3.20, 2.30, 'Dormitorio c/placard', 3, 44, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  84, 3.20, 2.80, 'Dormitorio c/placard', 3, 44, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  85, 1.50, 1.90, 'Baño completo', 2, 44, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  86, 1.30, 1.20, 'Toilette', 2, 44, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  87, 1.80, 1.40, 'Lavadero Cubierto', 2, 44, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  88, 8.00, 2.10, 'Terraza', 12, 44, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  89, 3.10, 7.20, 'Living Comedor', 8, 45, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  90, 2.80, 2.80, 'Cocina Comedor', 2, 45, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  91, 4.20, 2.80, 'Dormitorio c/placard', 4, 45, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  92, 3.00, 2.60, 'Dormitorio c/placard', 4, 45, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  93, 3.30, 2.70, 'Dormitorio c/placard', 4, 45, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  94, 1.90, 1.60, 'Baño completo', 2, 45, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  95, 0.90, 1.90, 'Toilette', 2, 45, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  96, 2.70, 3.20, 'Estar', 8, 45, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  97, 2.00, 1.60, 'Lavadero', 2, 45, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  98, 3.10, 1.20, 'Balcón', 2, 45, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  99, 2.60, 1.20, 'Balcón', 2, 45, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  100, 3.50, 3.50, 'Living', 12, 47, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  101, 4.00, 3.50, 'Comedor', 3, 47, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  102, 1.30, 2.40, 'Porche', 1, 47, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  103, 3.90, 3.50, 'Cocina', 2, 47, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  104, 3.50, 2.00, 'Comedor Diario', 2, 47, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  105, 3.50, 2.90, 'Dormitorio P.B', 3, 47, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  106, 3.70, 2.40, 'Dormitorio', 2, 47, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  107, 3.40, 2.40, 'Dormitorio', 2, 47, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  108, 3.00, 2.00, 'Vestido P.B.', 1, 47, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  109, 2.40, 1.60, 'Baño P.B.', 2, 47, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  110, 2.40, 1.60, 'Baño P.A.', 2, 47, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  111, 2.40, 1.30, 'Escritorio', 1, 47, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  112, 4.60, 3.70, 'PLayroom', 1, 47, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  113, 1.00, 3.50, 'Baulera', 1, 47, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  114, 7.30, 2.70, 'Jardín al fondo', 1, 47, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  115, 7.40, 2.00, 'Patio al frente', 1, 47, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  116, 3.80, 5.80, 'LivingComedor', 3, 48, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  117, 3.80, 2.90, 'Cocina Comedor', 2, 48, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  118, 3.00, 3.10, 'Dormitorio c/placard', 2, 48, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  119, 3.10, 3.20, 'Dormitorio c/placard', 2, 48, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  120, 1.40, 1.00, 'Toilette', 2, 48, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  121, 1.10, 2.30, 'Baño completo', 2, 48, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  122, 3.90, 8.80, 'Playroom', 3, 48, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  123, 3.80, 4.00, 'Patio', 12, 48, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  124, 2.50, 5.20, 'Cochera', 1, 48, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  125, 3.60, 5.00, 'Living comedor', 2, 49, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  126, 3.40, 2.80, 'Cocina', 2, 49, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  127, 3.40, 4.00, 'Dormitorio', 2, 49, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  128, 2.60, 3.00, 'Dormitorio', 1, 49, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  129, 1.70, 2.40, 'Baño completo', 2, 49, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  130, 1.70, 3.30, 'Patio', 12, 49, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  131, 2.60, 3.00, 'Dependencia', 2, 49, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  132, 10.00, 10.00, 'Parque', 1, 49, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  133, 3.00, 6.00, 'Garage cubierto', 1, 49, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  134, 3.00, 6.00, 'Garage cubierto', 1, 49, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  135, 0.00, 0.00, 'Terraza', 12, 49, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  136, 4.90, 3.20, 'Living (casa 1)', 1, 50, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  137, 4.80, 3.40, 'Cocina (casa 1)', 1, 50, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  138, 3.80, 3.20, 'Dormitorio (Casa 1)', 1, 50, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  139, 3.40, 3.20, 'Dormitorio (Casa 1)', 1, 50, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  140, 2.30, 1.70, 'Baño (Casa 1)', 1, 50, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  141, 6.60, 5.50, 'Cocina Comedor (Casa 2)', 1, 50, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  142, 2.10, 1.90, 'Baño  (Casa 2)', 1, 50, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  143, 6.60, 5.50, 'Dormitorio en P.A. (Casa 2)', 1, 50, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  144, 2.10, 1.90, 'Baño en P.B  (Casa 2)', 1, 50, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  145, 5.40, 3.30, 'Living', 2, 51, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  146, 3.40, 5.10, 'Comedor', 2, 51, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  147, 2.80, 2.80, 'Cocina', 2, 51, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  148, 3.20, 3.20, 'Dormitorio c/placard', 2, 51, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  149, 3.90, 2.70, 'Dormitorio c/placard', 2, 51, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  150, 4.00, 2.70, 'Dormitorio c/placard', 2, 51, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  151, 5.00, 2.70, 'Altillo', 7, 51, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  152, 10.00, 8.00, 'Parque', 1, 51, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  153, 10.00, 20.00, 'Terraza', 6, 51, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  154, 4.70, 9.20, 'Living Comedor', 3, 52, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  155, 4.70, 3.60, 'Cocina comedor', 2, 52, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  156, 4.60, 4.20, 'Dormitorio c/placard', 3, 52, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  157, 5.70, 3.60, 'Dormitorio en suite', 3, 52, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  158, 4.00, 3.00, 'Dormitorio c/placard', 3, 52, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  159, 3.10, 2.10, 'Dormitorio c/placard', 3, 52, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  160, 7.30, 3.70, 'Playroom', 7, 52, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  161, 1.60, 1.30, 'Toilette', 2, 52, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  162, 1.80, 2.10, 'Baño completo', 2, 52, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  163, 1.80, 2.10, 'Baño en suite c/hidromasajes', 2, 52, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  164, 1.60, 1.00, 'Lavadero', 2, 52, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  165, 8.70, 5.90, 'Parque c/pileta', 1, 52, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  166, 3.60, 5.70, 'Garage', 2, 52, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  167, 0.00, 0.00, 'Baulera', 1, 52, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  168, 9.00, 4.00, 'Living', 5, 53, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  169, 5.50, 3.30, 'Comedor', 5, 53, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  170, 5.50, 4.00, 'Cocina Comedor', 2, 53, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  171, 2.00, 3.00, 'Baño en P.B.', 2, 53, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  172, 5.00, 4.00, 'Dormitorio en suite', 2, 53, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  173, 4.00, 3.00, 'Dormitorio c/placard', 6, 53, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  174, 4.00, 3.00, 'Dormitorio c/placard', 6, 53, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  175, 2.50, 2.00, 'Dormitorio', 6, 53, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  176, 4.00, 3.00, 'Altillo', 7, 53, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  177, 2.00, 3.00, 'Baño en P.A.', 2, 53, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  178, 6.00, 3.00, 'Patio', 12, 53, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  179, 8.70, 18.00, 'Parque', 1, 53, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  180, 5.00, 4.00, 'Terraza', 12, 53, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  181, 4.00, 2.50, 'Entrepiso', 7, 53, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  182, 5.40, 4.50, 'Living', 3, 56, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  183, 2.50, 5.80, 'Comedor diario', 2, 56, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  184, 2.00, 4.60, 'Cocina', 2, 56, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  185, 3.50, 3.20, 'Dormitorio en P.B.', 3, 56, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  186, 4.00, 3.80, 'Dormitorio c/placard', 4, 56, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  187, 4.00, 3.80, 'Dormitorio c/placard', 4, 56, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  188, 3.50, 1.60, 'Baño completo', 2, 56, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  189, 3.00, 1.80, 'Baño completo', 2, 56, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  190, 3.90, 2.60, 'Dormitorio', 4, 56, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  191, 8.70, 7.70, 'Parque', 1, 56, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  192, 8.70, 7.00, 'SUM', 12, 56, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  193, 2.60, 7.00, 'Garage', 12, 56, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  194, 6.40, 4.00, 'Living', 3, 57, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  195, 3.50, 5.00, 'Cocina', 2, 57, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  196, 3.70, 5.00, 'Comedor diario', 2, 57, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  197, 4.90, 3.10, 'Dormitorio', 4, 57, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  198, 3.40, 3.10, 'Dormitorio', 4, 57, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  199, 3.60, 2.40, 'Dormitorio', 4, 57, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  200, 6.00, 4.00, 'Playroom', 1, 57, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  201, 2.60, 3.20, 'Baño en suite c/yacuzzi', 2, 57, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  202, 2.40, 1.60, 'Baño en suite', 2, 57, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  203, 2.40, 1.60, 'Baño en suite', 2, 57, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  204, 2.00, 1.20, 'Toilette', 2, 57, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  205, 16.00, 6.00, 'Parque c/piscina', 1, 57, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  206, 4.00, 9.00, 'Quincho', 2, 57, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  207, 7.00, 4.00, 'Piscina', 1, 57, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  208, 7.50, 6.60, 'Living', 1, 59, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  209, 8.00, 8.00, 'Living comedor', 1, 59, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  210, 4.90, 4.50, 'Cocina', 2, 59, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  211, 3.40, 3.00, 'Dormitorio en P.B', 1, 59, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  212, 6.30, 4.80, 'Dormitorio en P.B', 1, 59, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  213, 3.40, 3.50, 'Dormitorio en P.B', 1, 59, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  214, 3.40, 3.50, 'Dormitorio en P.B', 1, 59, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  215, 5.50, 6.60, 'Garage', 1, 59, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  216, 6.90, 4.30, 'Dormitorio en P.A.', 1, 59, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  217, 6.90, 4.30, 'Dormitorio en P.A.', 1, 59, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  218, 1.80, 1.80, 'Sauna', 1, 59, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  219, 18.00, 14.00, 'Salón de Reuniones', 3, 59, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  220, 8.40, 6.60, 'Playroom', 3, 59, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  221, 7.00, 16.00, 'Piscina', 1, 59, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  222, 6.40, 3.50, 'Living Comedor', 13, 61, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  223, 6.60, 3.50, 'Dormitorio', 13, 61, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  224, 3.40, 2.40, 'Balcón (2º dormitorio)', 13, 61, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  225, 2.20, 4.20, 'Cocina ', 13, 61, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  226, 2.40, 1.60, 'Baño completo', 2, 61, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  227, 1.50, 1.50, 'Toilette', 2, 61, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  228, 3.50, 8.10, 'Living', 13, 62, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  229, 4.10, 2.10, 'Cocina', 13, 62, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  230, 3.20, 4.20, 'Dormitorio', 13, 62, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  231, 2.20, 1.60, 'Baño completo', 2, 62, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  232, 1.50, 1.50, 'Toilette', 2, 62, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  233, 7.00, 3.30, 'Living Comedor', 1, 63, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  234, 3.00, 3.00, 'Dormitorio c/placard', 1, 63, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  235, 4.00, 4.00, 'Dormitorio c/placard', 1, 63, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  236, 4.20, 2.90, 'Living', 2, 66, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  237, 3.40, 2.00, 'Cocina Comedor', 2, 66, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  238, 3.90, 2.80, 'Dormitorio', 2, 66, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  239, 1.50, 2.90, 'Baño completo', 2, 66, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  240, 1.20, 2.90, 'Balcón', 2, 66, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  241, 4.00, 8.00, 'Living', 3, 67, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  242, 2.40, 4.00, 'Cocina', 2, 67, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  243, 3.50, 3.00, 'Dormitorio', 3, 67, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  244, 3.00, 3.00, 'Dormitorio', 3, 67, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  245, 0.00, 0.00, 'Baño completo', 2, 67, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  246, 0.00, 0.00, 'Toilette', 2, 67, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  247, 0.00, 0.00, 'Lavadero', 2, 67, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  248, 6.00, 1.00, 'Balcón', 2, 67, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  249, 5.80, 6.90, 'Living Comedor', 9, 68, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  250, 2.60, 7.90, 'Cocina Comedor', 2, 68, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  251, 3.20, 3.90, 'Dormitorio', 3, 68, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  252, 3.00, 2.60, 'Dormitorio', 3, 68, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  253, 4.20, 2.60, 'Dormitorio', 3, 68, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  254, 0.90, 1.30, 'Toilette', 2, 68, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  255, 2.50, 2.30, 'Baño completo', 2, 68, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  256, 10.00, 5.80, 'Altillo', 7, 68, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  257, 2.20, 2.60, 'Lavadero', 2, 68, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  258, 2.60, 5.70, 'Cochera', 2, 68, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  259, 1.60, 1.00, 'Toilette', 2, 68, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  260, 5.60, 3.40, 'Terraza', 12, 68, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  261, 3.60, 3.40, 'Jardín de invierno', 12, 68, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  262, 2.80, 4.80, 'Living', 3, 69, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  263, 1.60, 2.00, 'Cocina', 2, 69, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  264, 2.80, 2.90, 'Dormitorio c/placard', 4, 69, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  265, 1.00, 1.60, 'Baño completo', 2, 69, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  266, 0.70, 1.90, 'Pasillo', 3, 69, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  267, 2.90, 10.00, 'Living Comedor', 3, 70, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  268, 1.50, 2.80, 'Cocina', 2, 70, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  269, 1.50, 1.80, 'Baño completo', 2, 70, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  270, 2.90, 1.00, 'Balcón', 2, 70, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  271, 4.00, 8.00, 'Living Comedor', 2, 72, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  272, 3.50, 3.50, 'Cocina Comedor', 2, 72, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  273, 3.00, 4.00, 'Dormitorio c/placard', 2, 72, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  274, 6.00, 4.00, 'Dormitorio c/placard', 2, 72, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  275, 2.50, 2.00, 'Dependencia', 2, 72, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  276, 5.70, 3.70, 'Living', 4, 73, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  277, 4.50, 3.20, 'Comedor', 4, 73, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  278, 4.00, 4.40, 'Cocina comedor', 2, 73, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  279, 3.50, 3.20, 'Dormitorio c/placard', 5, 73, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  280, 3.30, 3.20, 'Dormitorio c/placard', 5, 73, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  281, 3.10, 3.40, 'Dormitorio c/placard', 5, 73, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  282, 1.20, 1.20, 'Toilette', 2, 73, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  283, 2.50, 1.50, 'Baño completo', 2, 73, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  284, 2.00, 1.00, 'Lavadero', 2, 73, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  285, 3.20, 2.00, 'Escritorio', 1, 73, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  286, 2.50, 2.00, 'Hall de distribución P.A.', 1, 73, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  287, 3.50, 3.00, 'Patio', 1, 73, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  288, 8.70, 6.00, 'Jardín', 1, 73, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  289, 8.70, 2.80, 'Quincho', 1, 73, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  290, 2.20, 10.00, 'Cochera', 12, 73, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  291, 4.00, 4.50, 'Terraza', 1, 73, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  292, 2.80, 5.30, 'Living', 3, 74, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  293, 1.70, 3.20, 'Cocina', 2, 74, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  294, 2.90, 3.50, 'Dormitorio', 4, 74, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  295, 2.10, 1.10, 'Baño completo', 2, 74, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  296, 1.30, 1.20, 'Lavadero', 2, 74, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  297, 5.50, 1.00, 'Balcón corrido', 1, 74, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  298, 2.70, 4.40, 'Living', 7, 75, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  299, 4.20, 3.90, 'Comedor', 7, 75, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  300, 3.00, 3.40, 'Cocina', 2, 75, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  301, 3.90, 3.90, 'Dormitorio c/placard', 1, 75, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  302, 3.90, 4.00, 'Dormitorio c/placard', 1, 75, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  303, 3.20, 2.80, 'Dormitorio c/placard', 1, 75, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  304, 2.20, 2.30, 'Dormitorio c/placard', 1, 75, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  305, 0.90, 1.90, 'Toilette', 2, 75, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  306, 2.50, 1.40, 'Baño completo', 2, 75, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  307, 2.80, 3.20, 'Baño completo', 2, 75, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  308, 3.90, 3.30, 'Escritorio', 1, 75, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  309, 1.20, 1.30, 'Toilette', 2, 75, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  310, 10.40, 13.50, 'Parque', 1, 75, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  311, 3.20, 1.50, 'Balcón', 1, 75, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  312, 2.70, 6.40, 'Cochera', 1, 75, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  313, 4.00, 5.20, 'Living Comedor', 1, 77, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  314, 2.80, 4.00, 'Cocina', 1, 77, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  315, 3.30, 3.40, 'Dormitorio c/placard', 1, 77, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  316, 2.90, 2.60, 'Dormitorio c/placard', 1, 77, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  317, 1.80, 1.90, 'Baño completo', 1, 77, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  318, 4.00, 1.00, 'Balcón', 1, 77, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  319, 5.50, 15.00, 'Depósito', 6, 78, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  320, 2.20, 4.70, 'Depósito', 6, 78, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  321, 2.00, 1.00, 'Baño', 1, 78, NULL )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  323, 3.25, 5.00, '', 3, 81, 5 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  324, 2.00, 3.80, '', 2, 81, 1 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  325, 2.50, 2.80, '', 3, 81, 3 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  326, 2.85, 3.20, '', 4, 81, 3 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  327, 2.00, 1.50, '', 2, 81, 2 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  328, 2.95, 5.25, '', 3, 79, 5 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  329, 1.45, 3.55, '', 2, 79, 1 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  330, 3.00, 2.95, '', 3, 79, 3 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  331, 2.85, 3.00, '', 3, 79, 3 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  332, 1.50, 2.15, '', 2, 79, 2 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  333, 0.85, 2.00, '', 2, 79, 13 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  340, 2.20, 4.80, '', 2, 84, 1 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  341, 4.90, 4.60, '', 3, 84, 5 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  342, 3.25, 6.25, '', 3, 44, 5 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  343, 3.20, 5.60, '', 1, 90, 5 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  344, 3.20, 3.00, '', 1, 90, 1 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  345, 5.00, 3.20, 'Comedor', 1, 90, 16 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  346, 3.50, 3.50, '', 1, 90, 3 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  347, 4.00, 3.40, '', 1, 90, 4 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  348, 3.50, 3.70, '', 1, 90, 4 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  349, 4.05, 7.00, '', 3, 86, 5 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  350, 2.90, 3.20, '', 1, 86, 1 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  351, 3.40, 4.00, '', 1, 86, 3 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  352, 4.20, 3.10, '', 1, 86, 3 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  353, 4.20, 3.00, '', 1, 86, 3 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  354, 3.00, 2.80, 'Escritorio', 1, 86, 16 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  355, 3.00, 9.00, 'Playroom', 1, 86, 16 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  356, 10.00, 25.00, 'Jardín', 1, 86, 16 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  357, 3.10, 7.30, '', 1, 85, 5 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  358, 3.10, 3.00, '', 1, 85, 3 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  359, 3.00, 3.10, '', 1, 85, 3 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  360, 4.40, 1.80, '', 1, 85, 1 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  361, 2.00, 1.00, '', 1, 85, 13 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  362, 3.00, 1.00, 'Balcón', 1, 85, 16 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  363, 4.00, 16.00, 'Planta', 1, 92, 16 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  364, 4.00, 16.00, 'Subsuelo', 1, 92, 16 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  365, 3.00, 3.00, 'Entrepiso', 7, 92, 16 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  366, 4.75, 4.95, '', 8, 97, 5 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  367, 2.25, 2.45, '', 8, 97, 1 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  368, 2.90, 3.35, '', 8, 97, 3 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  369, 1.95, 1.80, '', 2, 97, 2 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  370, 2.20, 1.50, '', 2, 97, 8 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  371, 2.66, 3.10, '', 9, 88, 1 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  372, 1.50, 1.90, '', 2, 88, 2 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  374, 5.25, 6.73, '', 3, 88, 5 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  375, 1.00, 1.10, '', 2, 88, 9 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  376, 2.00, 3.10, '', 9, 88, 12 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  377, 1.30, 1.20, '', 9, 88, 15 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  378, 3.10, 3.00, '', 3, 88, 3 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  379, 3.00, 4.10, '', 3, 88, 3 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  380, 3.03, 3.00, '', 3, 88, 3 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  381, 0.00, 0.00, '', 6, 88, 6 )
go
INSERT INTO [dbo].[MedidasAmbientesPropiedad] ( [IdAmbiente], [Ancho], [Largo], [Ambiente], [IdTipoPiso], [IdPropiedad], [IdTipoAmbiente] ) VALUES(  382, 0.00, 0.00, '', 9, 88, 13 )
go
SET IDENTITY_INSERT [dbo].[MedidasAmbientesPropiedad] OFF
go
INSERT INTO [dbo].[Monedas] ( [IdMoneda], [Nombre], [Simbolo] ) VALUES(  1, 'Pesos', '$' )
go
INSERT INTO [dbo].[Monedas] ( [IdMoneda], [Nombre], [Simbolo] ) VALUES(  2, 'Dolares', 'USD' )
go
INSERT INTO [dbo].[Monedas] ( [IdMoneda], [Nombre], [Simbolo] ) VALUES(  3, 'Euros', '£' )
go
SET IDENTITY_INSERT [dbo].[NotasPropiedad] ON
go
--The following columns were excluded due to unsupported datatypes: [Nota]
INSERT INTO [dbo].[NotasPropiedad] ( [IdNota], [IdPropiedad], [Fecha] ) VALUES(  1, 62, '2008-06-02 18:37:45.577' )
go
--The following columns were excluded due to unsupported datatypes: [Nota]
INSERT INTO [dbo].[NotasPropiedad] ( [IdNota], [IdPropiedad], [Fecha] ) VALUES(  2, 62, '2008-06-02 18:54:39.377' )
go
--The following columns were excluded due to unsupported datatypes: [Nota]
INSERT INTO [dbo].[NotasPropiedad] ( [IdNota], [IdPropiedad], [Fecha] ) VALUES(  4, 43, '2008-06-02 19:31:03.97' )
go
--The following columns were excluded due to unsupported datatypes: [Nota]
INSERT INTO [dbo].[NotasPropiedad] ( [IdNota], [IdPropiedad], [Fecha] ) VALUES(  5, 34, '2008-06-02 19:34:34.327' )
go
--The following columns were excluded due to unsupported datatypes: [Nota]
INSERT INTO [dbo].[NotasPropiedad] ( [IdNota], [IdPropiedad], [Fecha] ) VALUES(  6, 87, '2008-06-06 18:56:25.97' )
go
--The following columns were excluded due to unsupported datatypes: [Nota]
INSERT INTO [dbo].[NotasPropiedad] ( [IdNota], [IdPropiedad], [Fecha] ) VALUES(  7, 88, '2008-06-06 19:06:09.797' )
go
--The following columns were excluded due to unsupported datatypes: [Nota]
INSERT INTO [dbo].[NotasPropiedad] ( [IdNota], [IdPropiedad], [Fecha] ) VALUES(  8, 89, '2008-06-07 12:59:01.953' )
go
--The following columns were excluded due to unsupported datatypes: [Nota]
INSERT INTO [dbo].[NotasPropiedad] ( [IdNota], [IdPropiedad], [Fecha] ) VALUES(  9, 92, '2008-06-11 12:19:12.11' )
go
--The following columns were excluded due to unsupported datatypes: [Nota]
INSERT INTO [dbo].[NotasPropiedad] ( [IdNota], [IdPropiedad], [Fecha] ) VALUES(  10, 94, '2008-06-11 15:15:27.173' )
go
--The following columns were excluded due to unsupported datatypes: [Nota]
INSERT INTO [dbo].[NotasPropiedad] ( [IdNota], [IdPropiedad], [Fecha] ) VALUES(  11, 69, '2008-06-11 16:31:32.813' )
go
--The following columns were excluded due to unsupported datatypes: [Nota]
INSERT INTO [dbo].[NotasPropiedad] ( [IdNota], [IdPropiedad], [Fecha] ) VALUES(  12, 82, '2008-06-11 16:33:26.767' )
go
--The following columns were excluded due to unsupported datatypes: [Nota]
INSERT INTO [dbo].[NotasPropiedad] ( [IdNota], [IdPropiedad], [Fecha] ) VALUES(  13, 53, '2008-06-11 16:35:23.127' )
go
--The following columns were excluded due to unsupported datatypes: [Nota]
INSERT INTO [dbo].[NotasPropiedad] ( [IdNota], [IdPropiedad], [Fecha] ) VALUES(  14, 39, '2008-06-11 16:41:48.28' )
go
--The following columns were excluded due to unsupported datatypes: [Nota]
INSERT INTO [dbo].[NotasPropiedad] ( [IdNota], [IdPropiedad], [Fecha] ) VALUES(  15, 82, '2008-06-11 16:43:23.377' )
go
--The following columns were excluded due to unsupported datatypes: [Nota]
INSERT INTO [dbo].[NotasPropiedad] ( [IdNota], [IdPropiedad], [Fecha] ) VALUES(  16, 75, '2008-06-11 16:45:05.563' )
go
--The following columns were excluded due to unsupported datatypes: [Nota]
INSERT INTO [dbo].[NotasPropiedad] ( [IdNota], [IdPropiedad], [Fecha] ) VALUES(  17, 53, '2008-06-11 16:46:52.297' )
go
--The following columns were excluded due to unsupported datatypes: [Nota]
INSERT INTO [dbo].[NotasPropiedad] ( [IdNota], [IdPropiedad], [Fecha] ) VALUES(  18, 53, '2008-06-11 16:50:34.577' )
go
--The following columns were excluded due to unsupported datatypes: [Nota]
INSERT INTO [dbo].[NotasPropiedad] ( [IdNota], [IdPropiedad], [Fecha] ) VALUES(  19, 53, '2008-06-11 16:50:53.22' )
go
--The following columns were excluded due to unsupported datatypes: [Nota]
INSERT INTO [dbo].[NotasPropiedad] ( [IdNota], [IdPropiedad], [Fecha] ) VALUES(  20, 34, '2008-06-13 20:05:45.047' )
go
--The following columns were excluded due to unsupported datatypes: [Nota]
INSERT INTO [dbo].[NotasPropiedad] ( [IdNota], [IdPropiedad], [Fecha] ) VALUES(  21, 34, '2008-06-13 20:06:22.093' )
go
--The following columns were excluded due to unsupported datatypes: [Nota]
INSERT INTO [dbo].[NotasPropiedad] ( [IdNota], [IdPropiedad], [Fecha] ) VALUES(  22, 66, '2008-06-24 15:56:31.127' )
go
SET IDENTITY_INSERT [dbo].[NotasPropiedad] OFF
go
SET IDENTITY_INSERT [dbo].[Pagos] ON
go
INSERT INTO [dbo].[Pagos] ( [IdPago], [IdContrato], [Importe], [IdMoneda], [Anulado], [FechaPago], [MesCancelado], [FechaAlta], [AnioPagado] ) VALUES(  2, 8, 2000, 1, 0, '2008-04-26 17:11:29.0', 5, '2008-06-04 00:00:00.0', 2008 )
go
INSERT INTO [dbo].[Pagos] ( [IdPago], [IdContrato], [Importe], [IdMoneda], [Anulado], [FechaPago], [MesCancelado], [FechaAlta], [AnioPagado] ) VALUES(  3, 8, 2000, 1, 0, '2008-06-04 17:11:53.03', 6, '2008-06-04 00:00:00.0', 2008 )
go
SET IDENTITY_INSERT [dbo].[Pagos] OFF
go
INSERT INTO [dbo].[Paises] ( [IdPais], [Nombre], [Default] ) VALUES(  1, 'Argentina', 1 )
go
SET IDENTITY_INSERT [dbo].[Pedidos] ON
go
INSERT INTO [dbo].[Pedidos] ( [IdPedido], [CantidadAmbientesFinal], [CantidadAmbientesInicial], [IdCategoria], [IdCliente], [Disposicion], [EnumEstado], [EsAptoProfesional], [IdEstadoPropiedad], [EstadoPropiedad], [MetrosConstruiblesFinal], [MetrosConstruiblesInicial], [MetrosCubiertosFinal], [MetrosCubiertosInicial], [MetrosTerrenoFinal], [MetrosTerrenoInicial], [IdTipoPropiedad], [TipoZona], [IdBarrio], [IdLocalidad], [IdPais], [IdProvincia], [ImporteFinal], [ImporteInicial], [IdMoneda], [Observaciones], [Activo], [FechaAlta] ) VALUES(  1, 4.0, 3.0, 1, 6, NULL, NULL, NULL, 1, 'GI.BR.Propiedades.Venta', NULL, 0, NULL, 0, NULL, 0, NULL, NULL, NULL, 1, 1, 1, 75000, 60000, 2, 'PH con patio chico, 2 dormitorios', 1, '2008-06-03 00:00:00.0' )
go
INSERT INTO [dbo].[Pedidos] ( [IdPedido], [CantidadAmbientesFinal], [CantidadAmbientesInicial], [IdCategoria], [IdCliente], [Disposicion], [EnumEstado], [EsAptoProfesional], [IdEstadoPropiedad], [EstadoPropiedad], [MetrosConstruiblesFinal], [MetrosConstruiblesInicial], [MetrosCubiertosFinal], [MetrosCubiertosInicial], [MetrosTerrenoFinal], [MetrosTerrenoInicial], [IdTipoPropiedad], [TipoZona], [IdBarrio], [IdLocalidad], [IdPais], [IdProvincia], [ImporteFinal], [ImporteInicial], [IdMoneda], [Observaciones], [Activo], [FechaAlta] ) VALUES(  2, NULL, NULL, 1, 7, NULL, NULL, NULL, 1, 'GI.BR.Propiedades.Venta', NULL, 0, NULL, 0, NULL, 0, NULL, NULL, NULL, 1, 1, 1, 110000, 90000, 2, 'PH 3 amb..
Vio PH quintana 800, tiene 2 ambientes p/vender.', 0, '2008-06-03 00:00:00.0' )
go
INSERT INTO [dbo].[Pedidos] ( [IdPedido], [CantidadAmbientesFinal], [CantidadAmbientesInicial], [IdCategoria], [IdCliente], [Disposicion], [EnumEstado], [EsAptoProfesional], [IdEstadoPropiedad], [EstadoPropiedad], [MetrosConstruiblesFinal], [MetrosConstruiblesInicial], [MetrosCubiertosFinal], [MetrosCubiertosInicial], [MetrosTerrenoFinal], [MetrosTerrenoInicial], [IdTipoPropiedad], [TipoZona], [IdBarrio], [IdLocalidad], [IdPais], [IdProvincia], [ImporteFinal], [ImporteInicial], [IdMoneda], [Observaciones], [Activo], [FechaAlta] ) VALUES(  3, NULL, NULL, 1, 8, NULL, NULL, NULL, 1, 'GI.BR.Propiedades.Venta', NULL, 0, NULL, 0, NULL, 0, 1, NULL, NULL, 1, 1, 1, 95000, 85000, 2, 'DEPTO 3 AMBIENTES C/COCHERA Y BALCÓN.', 0, '2008-06-03 00:00:00.0' )
go
INSERT INTO [dbo].[Pedidos] ( [IdPedido], [CantidadAmbientesFinal], [CantidadAmbientesInicial], [IdCategoria], [IdCliente], [Disposicion], [EnumEstado], [EsAptoProfesional], [IdEstadoPropiedad], [EstadoPropiedad], [MetrosConstruiblesFinal], [MetrosConstruiblesInicial], [MetrosCubiertosFinal], [MetrosCubiertosInicial], [MetrosTerrenoFinal], [MetrosTerrenoInicial], [IdTipoPropiedad], [TipoZona], [IdBarrio], [IdLocalidad], [IdPais], [IdProvincia], [ImporteFinal], [ImporteInicial], [IdMoneda], [Observaciones], [Activo], [FechaAlta] ) VALUES(  4, 3.0, 2.0, 1, 9, NULL, NULL, NULL, 1, 'GI.BR.Propiedades.Venta', NULL, 0, NULL, 0, NULL, 0, 1, NULL, NULL, 1, 1, 1, 95000, 80000, 2, '2/3 amb. apto credito Banco Nacion', 1, '2008-06-03 00:00:00.0' )
go
INSERT INTO [dbo].[Pedidos] ( [IdPedido], [CantidadAmbientesFinal], [CantidadAmbientesInicial], [IdCategoria], [IdCliente], [Disposicion], [EnumEstado], [EsAptoProfesional], [IdEstadoPropiedad], [EstadoPropiedad], [MetrosConstruiblesFinal], [MetrosConstruiblesInicial], [MetrosCubiertosFinal], [MetrosCubiertosInicial], [MetrosTerrenoFinal], [MetrosTerrenoInicial], [IdTipoPropiedad], [TipoZona], [IdBarrio], [IdLocalidad], [IdPais], [IdProvincia], [ImporteFinal], [ImporteInicial], [IdMoneda], [Observaciones], [Activo], [FechaAlta] ) VALUES(  5, 3.0, 3.0, 1, 10, NULL, NULL, NULL, 1, 'GI.BR.Propiedades.Venta', NULL, 0, NULL, 0, NULL, 0, 1, NULL, NULL, 1, 1, 1, 80000, 70000, 2, '', 1, '2008-06-03 00:00:00.0' )
go
INSERT INTO [dbo].[Pedidos] ( [IdPedido], [CantidadAmbientesFinal], [CantidadAmbientesInicial], [IdCategoria], [IdCliente], [Disposicion], [EnumEstado], [EsAptoProfesional], [IdEstadoPropiedad], [EstadoPropiedad], [MetrosConstruiblesFinal], [MetrosConstruiblesInicial], [MetrosCubiertosFinal], [MetrosCubiertosInicial], [MetrosTerrenoFinal], [MetrosTerrenoInicial], [IdTipoPropiedad], [TipoZona], [IdBarrio], [IdLocalidad], [IdPais], [IdProvincia], [ImporteFinal], [ImporteInicial], [IdMoneda], [Observaciones], [Activo], [FechaAlta] ) VALUES(  6, 3.0, 3.0, 1, 12, NULL, NULL, NULL, 1, 'GI.BR.Propiedades.Venta', NULL, 0, NULL, 0, NULL, 0, NULL, NULL, NULL, 1, 1, 1, 86000, 75000, 2, '', 1, '2008-06-03 00:00:00.0' )
go
INSERT INTO [dbo].[Pedidos] ( [IdPedido], [CantidadAmbientesFinal], [CantidadAmbientesInicial], [IdCategoria], [IdCliente], [Disposicion], [EnumEstado], [EsAptoProfesional], [IdEstadoPropiedad], [EstadoPropiedad], [MetrosConstruiblesFinal], [MetrosConstruiblesInicial], [MetrosCubiertosFinal], [MetrosCubiertosInicial], [MetrosTerrenoFinal], [MetrosTerrenoInicial], [IdTipoPropiedad], [TipoZona], [IdBarrio], [IdLocalidad], [IdPais], [IdProvincia], [ImporteFinal], [ImporteInicial], [IdMoneda], [Observaciones], [Activo], [FechaAlta] ) VALUES(  7, 3.0, 2.0, 1, 13, NULL, NULL, NULL, 6, 'GI.BR.Propiedades.Alquiler', NULL, 0, NULL, 0, NULL, 0, 1, NULL, NULL, 1, 1, 1, 1500, NULL, 1, 'Pedido alquiler 2/3 ambientes.
depto / PH

buena garantia, pero no demostración ingresos, trabaja independiente.', 1, '2008-06-03 00:00:00.0' )
go
INSERT INTO [dbo].[Pedidos] ( [IdPedido], [CantidadAmbientesFinal], [CantidadAmbientesInicial], [IdCategoria], [IdCliente], [Disposicion], [EnumEstado], [EsAptoProfesional], [IdEstadoPropiedad], [EstadoPropiedad], [MetrosConstruiblesFinal], [MetrosConstruiblesInicial], [MetrosCubiertosFinal], [MetrosCubiertosInicial], [MetrosTerrenoFinal], [MetrosTerrenoInicial], [IdTipoPropiedad], [TipoZona], [IdBarrio], [IdLocalidad], [IdPais], [IdProvincia], [ImporteFinal], [ImporteInicial], [IdMoneda], [Observaciones], [Activo], [FechaAlta] ) VALUES(  8, 3.0, 3.0, 1, 14, NULL, NULL, NULL, 6, 'GI.BR.Propiedades.Alquiler', NULL, 0, NULL, 0, NULL, 0, 1, NULL, NULL, 1, 1, 1, NULL, NULL, NULL, 'Pedido casa o depto. 3 amb.', 1, '2008-06-03 00:00:00.0' )
go
INSERT INTO [dbo].[Pedidos] ( [IdPedido], [CantidadAmbientesFinal], [CantidadAmbientesInicial], [IdCategoria], [IdCliente], [Disposicion], [EnumEstado], [EsAptoProfesional], [IdEstadoPropiedad], [EstadoPropiedad], [MetrosConstruiblesFinal], [MetrosConstruiblesInicial], [MetrosCubiertosFinal], [MetrosCubiertosInicial], [MetrosTerrenoFinal], [MetrosTerrenoInicial], [IdTipoPropiedad], [TipoZona], [IdBarrio], [IdLocalidad], [IdPais], [IdProvincia], [ImporteFinal], [ImporteInicial], [IdMoneda], [Observaciones], [Activo], [FechaAlta] ) VALUES(  9, 3.0, 3.0, 1, 15, NULL, NULL, NULL, 1, 'GI.BR.Propiedades.Venta', NULL, 0, NULL, 0, NULL, 0, 1, NULL, NULL, 1, 1, 1, 85000, 75000, 2, '3 amb. queria ver maipu 1595', 1, '2008-06-03 00:00:00.0' )
go
INSERT INTO [dbo].[Pedidos] ( [IdPedido], [CantidadAmbientesFinal], [CantidadAmbientesInicial], [IdCategoria], [IdCliente], [Disposicion], [EnumEstado], [EsAptoProfesional], [IdEstadoPropiedad], [EstadoPropiedad], [MetrosConstruiblesFinal], [MetrosConstruiblesInicial], [MetrosCubiertosFinal], [MetrosCubiertosInicial], [MetrosTerrenoFinal], [MetrosTerrenoInicial], [IdTipoPropiedad], [TipoZona], [IdBarrio], [IdLocalidad], [IdPais], [IdProvincia], [ImporteFinal], [ImporteInicial], [IdMoneda], [Observaciones], [Activo], [FechaAlta] ) VALUES(  10, 4.0, 3.0, 1, 16, NULL, NULL, NULL, 1, 'GI.BR.Propiedades.Venta', NULL, 0, NULL, 0, NULL, 0, 7, NULL, NULL, 1, 1, 1, 170000, NULL, 2, 'casa 2 dorm. con fondo.
apto credito, ya señaron su casa en mayo 2008.

llamar despues 16hs.', 0, '2008-06-03 00:00:00.0' )
go
INSERT INTO [dbo].[Pedidos] ( [IdPedido], [CantidadAmbientesFinal], [CantidadAmbientesInicial], [IdCategoria], [IdCliente], [Disposicion], [EnumEstado], [EsAptoProfesional], [IdEstadoPropiedad], [EstadoPropiedad], [MetrosConstruiblesFinal], [MetrosConstruiblesInicial], [MetrosCubiertosFinal], [MetrosCubiertosInicial], [MetrosTerrenoFinal], [MetrosTerrenoInicial], [IdTipoPropiedad], [TipoZona], [IdBarrio], [IdLocalidad], [IdPais], [IdProvincia], [ImporteFinal], [ImporteInicial], [IdMoneda], [Observaciones], [Activo], [FechaAlta] ) VALUES(  11, 3.0, 2.0, 1, 17, NULL, NULL, NULL, 1, 'GI.BR.Propiedades.Venta', NULL, 0, NULL, 0, NULL, 0, 1, NULL, 7, 1, 1, 1, 180000, NULL, 2, 'Depto 2/3 ambientes. 
sobre libertador, entre tren de la costa y parana.
vista al rio, piso entre 4 y 10.

Amigo de Hentchel', 1, '2008-06-03 00:00:00.0' )
go
INSERT INTO [dbo].[Pedidos] ( [IdPedido], [CantidadAmbientesFinal], [CantidadAmbientesInicial], [IdCategoria], [IdCliente], [Disposicion], [EnumEstado], [EsAptoProfesional], [IdEstadoPropiedad], [EstadoPropiedad], [MetrosConstruiblesFinal], [MetrosConstruiblesInicial], [MetrosCubiertosFinal], [MetrosCubiertosInicial], [MetrosTerrenoFinal], [MetrosTerrenoInicial], [IdTipoPropiedad], [TipoZona], [IdBarrio], [IdLocalidad], [IdPais], [IdProvincia], [ImporteFinal], [ImporteInicial], [IdMoneda], [Observaciones], [Activo], [FechaAlta] ) VALUES(  12, 3.0, 3.0, 1, 18, NULL, NULL, NULL, 1, 'GI.BR.Propiedades.Venta', NULL, 0, NULL, 0, NULL, 0, 1, NULL, NULL, 1, 1, 1, 80000, NULL, 2, 'busqueda depto. u$s 80.000 con gastos incluidos.', 1, '2008-06-03 00:00:00.0' )
go
INSERT INTO [dbo].[Pedidos] ( [IdPedido], [CantidadAmbientesFinal], [CantidadAmbientesInicial], [IdCategoria], [IdCliente], [Disposicion], [EnumEstado], [EsAptoProfesional], [IdEstadoPropiedad], [EstadoPropiedad], [MetrosConstruiblesFinal], [MetrosConstruiblesInicial], [MetrosCubiertosFinal], [MetrosCubiertosInicial], [MetrosTerrenoFinal], [MetrosTerrenoInicial], [IdTipoPropiedad], [TipoZona], [IdBarrio], [IdLocalidad], [IdPais], [IdProvincia], [ImporteFinal], [ImporteInicial], [IdMoneda], [Observaciones], [Activo], [FechaAlta] ) VALUES(  13, 3.0, 3.0, 1, 20, NULL, NULL, NULL, 1, 'GI.BR.Propiedades.Venta', NULL, 0, NULL, 0, NULL, 0, 1, NULL, NULL, 1, 1, 1, 85000, NULL, 2, 'Depto. 3 amb sobre Maipu o Libertador.
Florida/Vte lopez hasta la quinta presidencial.
mas de 60m2.', 1, '2008-06-03 00:00:00.0' )
go
INSERT INTO [dbo].[Pedidos] ( [IdPedido], [CantidadAmbientesFinal], [CantidadAmbientesInicial], [IdCategoria], [IdCliente], [Disposicion], [EnumEstado], [EsAptoProfesional], [IdEstadoPropiedad], [EstadoPropiedad], [MetrosConstruiblesFinal], [MetrosConstruiblesInicial], [MetrosCubiertosFinal], [MetrosCubiertosInicial], [MetrosTerrenoFinal], [MetrosTerrenoInicial], [IdTipoPropiedad], [TipoZona], [IdBarrio], [IdLocalidad], [IdPais], [IdProvincia], [ImporteFinal], [ImporteInicial], [IdMoneda], [Observaciones], [Activo], [FechaAlta] ) VALUES(  14, NULL, NULL, 2, 44, NULL, NULL, NULL, 6, 'GI.BR.Propiedades.Alquiler', NULL, 0, NULL, 0, NULL, 0, 14, NULL, NULL, 1, 1, 1, 1700, NULL, 1, 'Local p/ Delivery de comidas. 30m2 o mas.', 1, '2008-06-05 00:00:00.0' )
go
INSERT INTO [dbo].[Pedidos] ( [IdPedido], [CantidadAmbientesFinal], [CantidadAmbientesInicial], [IdCategoria], [IdCliente], [Disposicion], [EnumEstado], [EsAptoProfesional], [IdEstadoPropiedad], [EstadoPropiedad], [MetrosConstruiblesFinal], [MetrosConstruiblesInicial], [MetrosCubiertosFinal], [MetrosCubiertosInicial], [MetrosTerrenoFinal], [MetrosTerrenoInicial], [IdTipoPropiedad], [TipoZona], [IdBarrio], [IdLocalidad], [IdPais], [IdProvincia], [ImporteFinal], [ImporteInicial], [IdMoneda], [Observaciones], [Activo], [FechaAlta] ) VALUES(  15, 3.0, 3.0, 1, 46, NULL, NULL, NULL, 6, 'GI.BR.Propiedades.Alquiler', NULL, 0, NULL, 0, NULL, 0, 2, NULL, 3, 1, 1, 1, 1600, NULL, 1, 'PH, no depto.
Zona Florida /Vte. Lopez', 1, '2008-06-05 00:00:00.0' )
go
INSERT INTO [dbo].[Pedidos] ( [IdPedido], [CantidadAmbientesFinal], [CantidadAmbientesInicial], [IdCategoria], [IdCliente], [Disposicion], [EnumEstado], [EsAptoProfesional], [IdEstadoPropiedad], [EstadoPropiedad], [MetrosConstruiblesFinal], [MetrosConstruiblesInicial], [MetrosCubiertosFinal], [MetrosCubiertosInicial], [MetrosTerrenoFinal], [MetrosTerrenoInicial], [IdTipoPropiedad], [TipoZona], [IdBarrio], [IdLocalidad], [IdPais], [IdProvincia], [ImporteFinal], [ImporteInicial], [IdMoneda], [Observaciones], [Activo], [FechaAlta] ) VALUES(  16, NULL, NULL, 1, 48, NULL, NULL, NULL, 1, 'GI.BR.Propiedades.Venta', NULL, 0, NULL, 0, NULL, 0, 2, NULL, NULL, 1, 1, 1, 55000, NULL, 2, 'PH en Florida M o B, Olivos, puede ser Capital.
PH chico, no hay mucho requerimiento.

Es para no perder el credito.', 1, '2008-06-06 00:00:00.0' )
go
INSERT INTO [dbo].[Pedidos] ( [IdPedido], [CantidadAmbientesFinal], [CantidadAmbientesInicial], [IdCategoria], [IdCliente], [Disposicion], [EnumEstado], [EsAptoProfesional], [IdEstadoPropiedad], [EstadoPropiedad], [MetrosConstruiblesFinal], [MetrosConstruiblesInicial], [MetrosCubiertosFinal], [MetrosCubiertosInicial], [MetrosTerrenoFinal], [MetrosTerrenoInicial], [IdTipoPropiedad], [TipoZona], [IdBarrio], [IdLocalidad], [IdPais], [IdProvincia], [ImporteFinal], [ImporteInicial], [IdMoneda], [Observaciones], [Activo], [FechaAlta] ) VALUES(  17, 6.0, 3.0, 1, 51, NULL, NULL, NULL, 1, 'GI.BR.Propiedades.Venta', NULL, 0, 250, 150, NULL, 0, 8, NULL, 3, 1, 1, 1, 200000, 170000, 2, 'Pedido de casa o Chalet en Florida M.
Oferto por casa A. Alvarez 2239 y Olga no vendio.
Oferto por casa en Chacabuco al 1300 (Kopas) y no vendieron.

Puede ser un duplex de no menos de 5mts. de ancho.

Darío 4791-8519 / 156-649-2937
Carla 156-649-2935', 1, '2008-06-10 00:00:00.0' )
go
INSERT INTO [dbo].[Pedidos] ( [IdPedido], [CantidadAmbientesFinal], [CantidadAmbientesInicial], [IdCategoria], [IdCliente], [Disposicion], [EnumEstado], [EsAptoProfesional], [IdEstadoPropiedad], [EstadoPropiedad], [MetrosConstruiblesFinal], [MetrosConstruiblesInicial], [MetrosCubiertosFinal], [MetrosCubiertosInicial], [MetrosTerrenoFinal], [MetrosTerrenoInicial], [IdTipoPropiedad], [TipoZona], [IdBarrio], [IdLocalidad], [IdPais], [IdProvincia], [ImporteFinal], [ImporteInicial], [IdMoneda], [Observaciones], [Activo], [FechaAlta] ) VALUES(  18, 2.0, 2.0, 1, 56, NULL, NULL, NULL, 1, 'GI.BR.Propiedades.Venta', NULL, 0, NULL, 0, NULL, 0, 1, NULL, NULL, 1, 1, 1, 77000, NULL, 2, 'Pedido 2 ambientes de maipu a Libertador.
Nuñez, La Lucila.', 1, '2008-06-12 00:00:00.0' )
go
INSERT INTO [dbo].[Pedidos] ( [IdPedido], [CantidadAmbientesFinal], [CantidadAmbientesInicial], [IdCategoria], [IdCliente], [Disposicion], [EnumEstado], [EsAptoProfesional], [IdEstadoPropiedad], [EstadoPropiedad], [MetrosConstruiblesFinal], [MetrosConstruiblesInicial], [MetrosCubiertosFinal], [MetrosCubiertosInicial], [MetrosTerrenoFinal], [MetrosTerrenoInicial], [IdTipoPropiedad], [TipoZona], [IdBarrio], [IdLocalidad], [IdPais], [IdProvincia], [ImporteFinal], [ImporteInicial], [IdMoneda], [Observaciones], [Activo], [FechaAlta] ) VALUES(  19, NULL, NULL, 1, 57, NULL, NULL, NULL, 1, 'GI.BR.Propiedades.Venta', NULL, 0, NULL, 0, NULL, 0, 7, NULL, NULL, 1, 1, 1, 140000, NULL, 2, 'Puede ser tambien Florida M, Olivos.
', 1, '2008-06-13 00:00:00.0' )
go
INSERT INTO [dbo].[Pedidos] ( [IdPedido], [CantidadAmbientesFinal], [CantidadAmbientesInicial], [IdCategoria], [IdCliente], [Disposicion], [EnumEstado], [EsAptoProfesional], [IdEstadoPropiedad], [EstadoPropiedad], [MetrosConstruiblesFinal], [MetrosConstruiblesInicial], [MetrosCubiertosFinal], [MetrosCubiertosInicial], [MetrosTerrenoFinal], [MetrosTerrenoInicial], [IdTipoPropiedad], [TipoZona], [IdBarrio], [IdLocalidad], [IdPais], [IdProvincia], [ImporteFinal], [ImporteInicial], [IdMoneda], [Observaciones], [Activo], [FechaAlta] ) VALUES(  20, NULL, NULL, 1, 59, NULL, NULL, NULL, 1, 'GI.BR.Propiedades.Venta', NULL, 0, NULL, 0, NULL, 0, 2, NULL, NULL, 1, 1, 1, 80000, 70000, 2, 'PH NO DEPTO.

2/3 amb. en Vte Lopez. Olivos. Zona cerca via del bajo.', 1, '2008-06-17 00:00:00.0' )
go
INSERT INTO [dbo].[Pedidos] ( [IdPedido], [CantidadAmbientesFinal], [CantidadAmbientesInicial], [IdCategoria], [IdCliente], [Disposicion], [EnumEstado], [EsAptoProfesional], [IdEstadoPropiedad], [EstadoPropiedad], [MetrosConstruiblesFinal], [MetrosConstruiblesInicial], [MetrosCubiertosFinal], [MetrosCubiertosInicial], [MetrosTerrenoFinal], [MetrosTerrenoInicial], [IdTipoPropiedad], [TipoZona], [IdBarrio], [IdLocalidad], [IdPais], [IdProvincia], [ImporteFinal], [ImporteInicial], [IdMoneda], [Observaciones], [Activo], [FechaAlta] ) VALUES(  21, NULL, NULL, 2, 62, NULL, NULL, NULL, 6, 'GI.BR.Propiedades.Alquiler', NULL, 0, NULL, 0, NULL, 0, 14, NULL, 1, 1, 1, 1, 2000, NULL, 1, '', 1, '2008-06-19 00:00:00.0' )
go
SET IDENTITY_INSERT [dbo].[Pedidos] OFF
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  34, 3.0, '', 1, 1, 8, 22, 1, 1, 1, 6, 'Av. Maipú', 3025, 'B', '11', '1636', 'Pelliza', '', 87000, 2, 92000, 2, 0, 62.00, 0.00, 0.00, 0.00, 0.00, 0.00, 'Norte', 1, 0, 2, 1, 3, 0, 11, 3, 2, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  35, 4.0, '', 7, 1, 6, 30, 1, 1, 1, 3, 'Agustin Alvarez', 2435, '', '', '1602', 'D.F. Sarmiento', 'Ohiggins', 132000, 2, 132000, 2, 0, 163.00, 0.00, 70.00, 242.50, 28.00, 8.70, 'Sur', 3, 1, 3, 1, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  36, 2.0, '', 2, 6, 3, 30, 1, 1, 1, 3, 'Lavalle', 2290, '', '1', '1602', 'Juan B. Justo', 'Ayacucho', 0, 1, 1200, 1, 0, 43.00, 0.00, 0.00, 0.00, 0.00, 0.00, 'Norte', 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  37, 2.0, '', 1, 1, 1, 38, 1, 1, 1, 3, 'Juan B. Justo', 653, '', '1', '1602', 'Lavalle', 'Las Heras', 0, 1, 71000, 2, 0, 56.00, 5.00, 0.00, 0.00, 0.00, 0.00, '', 2, 0, 1, 1, 2, 0, 3, 4, 1, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  38, 3.0, '', 1, 3, 6, NULL, 1, 1, 1, 1, 'Av. Maipú', 1595, 'B', '3', '1638', 'Libertad', 'Av. San Martín', 0, 1, 75000, 2, 0, 57.00, 0.00, 6.00, 0.00, 0.00, 0.00, 'Noroste', 1, 0, 2, 1, 1, 0, 19, 5, 3, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  39, 1.0, '', 11, 1, 1, 40, 1, 1, 1, 3, 'Liniers', 248, '', '', '1602', 'Laprida', 'Aristobulo del Valle', 0, 2, 145000, 2, 0, 0.00, 0.00, 0.00, 449.50, 51.90, 8.70, 'Este', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, '0,6', '1', 'R1', 450, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  40, 3.5, '', 2, 3, 3, 23, 1, 1, 1, 1, 'Llerena', 3025, '', 'PB', '', 'Andonaegui', 'Barzana', 85000, 2, 89500, 2, 0, 80.00, 0.00, 95.00, 0.00, 0.00, 0.00, 'Norte', 1, 0, 2, 1, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  41, 3.0, '', 1, 10, 3, NULL, 1, 1, 1, 1, 'Av. Maipú', 1585, 'B', '14', '1638', 'Arenales', 'Av. San Martín', 0, 2, 90000, 2, 0, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, '', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  42, 3.0, '', 2, 3, 3, 25, 1, 1, 1, 3, 'Quintana', 876, '4', '', '1602', 'Melo', 'Güemes', 92000, 2, 95000, 2, 0, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, '', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  43, 3.0, '', 7, 3, 8, 26, 1, 1, 1, 5, 'Rubén Darío', 4474, '', '', '', 'Rivadavia', 'Armenia', 95000, 1, 99000, 2, 0, 90.00, 0.00, 187.00, 300.00, 34.60, 8.70, 'Norte', 1, 2, 2, 1, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  44, 4.0, '', 2, 10, 8, 28, 1, 1, 1, 6, 'Pedro Goyena', 4118, 'A', '1', '1636', 'Bouchard', 'Mariano Moreno', 98000, 1, 102000, 2, 0, 96.00, 7.00, 15.00, 0.00, 0.00, 0.00, 'Este', 2, 0, 3, 1, 1, 0, 3, 1, 0, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  45, 4.0, '', 1, 3, 3, 4, 1, 1, 1, 3, 'Valle Grande', 1506, 'A', '6', '1602', 'Av. San Martín', 'Arenales', 0, 1, 105000, 2, 0, 91.00, 10.00, 0.00, 0.00, 0.00, 0.00, 'Sur', 2, 0, 3, 1, 1, 0, 10, 6, 2, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  46, 3.0, '', 12, 1, 3, NULL, 1, 1, 19, 31, 'Becquert', 460, '', '', '', '', '', 0, 1, 115000, 2, 0, 120.00, 0.00, 2600.00, 2700.00, 0.00, 0.00, 'Oeste', 1, 0, 2, 1, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  47, 6.0, '', 2, 1, 8, NULL, 1, 1, 1, 35, 'F. Felix de Amador', 2365, '2', 'PB', '1636', 'España', 'Jose M. Paz', 119000, 2, 125000, 2, 0, 148.90, 3.10, 52.80, 145.29, 16.70, 8.70, 'Sudeste', 2, 0, 3, 2, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 15, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  48, 4.0, '', 9, 1, 3, 45, 1, 1, 1, 3, 'Avellaneda', 1793, '', '', '1602', 'H. Irigoyen', 'Libertad', 130000, 1, 130000, 2, 1, 110.00, 0.00, 40.00, 0.00, 0.00, 0.00, 'Oeste', 3, 1, 2, 3, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 7, 2, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  49, 4.0, '', 7, 1, 3, NULL, 1, 1, 1, 6, 'San Lorenzo', 2695, '', '', '1636', 'España', '', 0, 1, 135000, 2, 0, 163.00, 0.00, 107.00, 0.00, 18.00, 13.00, 'Sudoeste', 2, 2, 3, 2, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  50, 4.5, '', 12, 1, 3, NULL, 1, 1, 19, 31, 'Becquert', 443, '', '', '', 'Quiroga', '', 125000, 2, 140000, 2, 0, 170.00, 0.00, 4900.00, 5074.70, 87.20, 58.00, 'Oeste', 3, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, NULL, NULL, NULL )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  51, 4.0, '', 7, 3, 3, 31, 1, 1, 1, 6, 'Bermudez', 3189, '', '', '1636', 'Ohiggins', '', 135000, 2, 140000, 2, 0, 172.00, 0.00, 80.00, 300.00, 30.00, 10.00, 'Sur', 2, 2, 3, 3, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  52, 6.0, '', 7, 1, 8, 33, 1, 1, 1, 3, 'Lavalle', 2387, '', '', '1602', 'D.F.Sarmiento', 'Juan B. Justo', 170000, 2, 185000, 2, 0, 195.00, 0.00, 65.00, 0.00, 20.00, 8.70, 'Sur', 3, 1, 4, 3, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  53, 5.0, '', 7, 10, 3, NULL, 1, 1, 1, 3, 'Agustín Alvarez', 2239, '', '', '1602', 'Juan B. Justo', 'Ayacucho', 0, 1, 185000, 2, 0, 245.00, 0.00, 180.00, 348.00, 40.00, 8.70, 'Sur', 3, 3, 4, 3, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  54, 6.0, '', 14, 1, 8, NULL, 1, 1, 1, 6, 'Ugarte', 2605, '', '1 y 2', '1636', 'Juan B. justo', '', 0, 1, 200000, 2, 0, 380.00, 0.00, 0.00, 0.00, 17.30, 8.70, 'Sudeste', 2, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  55, 1.0, '', 19, 1, 8, 37, 1, 1, 1, 4, 'Av. San Martín', 3240, '', '', '', 'Panamericana', 'Estanislao del Campo', 0, 1, 550000, 2, 0, 997.00, 193.00, 0.00, 399.00, 46.00, 8.70, 'Norte', 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  56, 5.0, '', 7, 1, 8, 34, 1, 1, 1, 6, 'Quintana', 3264, '', '', '1636', 'Borges', '', 185000, 2, 220000, 2, 0, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, '', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  57, 5.0, '', 7, 1, 8, 35, 1, 1, 1, 2, 'Pintor Gutierrez', 270, '', '', '', '', '', 0, 1, 300000, 2, 0, 315.00, 0.00, 300.00, 480.00, 24.00, 20.00, 'Este', 4, 2, 3, 2, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  58, 5.0, '', 7, 1, 3, 36, 1, 1, 1, 1, 'Madero', 665, '', '', '1636', 'Lavalle', 'Las Heras', 0, 1, 420000, 2, 0, 345.00, 0.00, 150.00, 300.00, 35.00, 8.70, 'Oeste', 5, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  59, 10.0, '', 7, 1, 8, NULL, 1, 1, 19, 31, 'Kenedy', 460, '', '', '', '', '', 0, 1, 1500000, 2, 0, 770.00, 198.00, 12000.00, 12666.00, 116.00, 110.00, 'Este', 6, 2, 6, 2, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  60, 1.0, '', 11, 10, 7, NULL, 1, 1, 1, 1, 'Laprida', 973, '', '', '', 'Av. Cordoba', 'Cabrera', 0, 1, 1350000, 2, 0, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, '', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  61, 2.0, '', 1, 1, 1, 41, 1, 1, 1, 6, 'Ricardo Gutierrez', 965, 'B', '1', '1636', '', '', 0, 2, 118000, 2, 0, 73.00, 0.00, 0.00, 0.00, 0.00, 0.00, 'Sudoeste', 2, 1, 1, 1, 2, 0, 3, 2, 1, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  62, 2.0, '', 1, 1, 1, 41, 1, 1, 1, 6, 'Ricardo Gutierrez', 965, 'A', '3', '1636', '', '', 0, 1, 124000, 2, 0, 68.00, 0.00, 0.00, 0.00, 0.00, 0.00, 'Sudeste', 2, 1, 1, 1, 1, 0, 3, 2, 1, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  63, 3.0, '', 1, 1, 8, NULL, 1, 1, 1, 3, 'Hipolito Irigoyen', 1486, 'B', '1', '1602', 'Av. Maipú', 'Quintana', 0, 1, 110000, 2, 0, 75.00, 0.00, 0.00, 0.00, 0.00, 0.00, 'Norte', 1, 1, 2, 1, 1, 0, 6, 0, 2, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  64, 5.0, '', 7, 4, 3, NULL, 1, 1, 1, 1, 'Arenales', 1435, '', '', '1636', 'Av. Maipú', '25 de Mayo', 0, 1, 175000, 2, 0, 120.00, 0.00, 60.00, 246.00, 23.40, 10.50, 'Sur', 2, 1, 2, 1, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  65, 3.0, '', 2, 11, 6, NULL, 1, 1, 1, 3, 'Las Heras', 1820, '', '1', '1602', 'Caseros', 'Santa María', 1000, 1, 1150, 1, 0, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 'Norte', 1, 0, 2, 1, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  66, 2.0, '', 1, 8, 8, 69, 1, 1, 1, 3, 'Av. San Martín', 2049, 'D', '2', '1602', 'Liniers', 'Jose M. Paz', 1100, 1, 1100, 1, 0, 43.00, 4.00, 0.00, 0.00, 0.00, 0.00, 'Noroeste', 1, 1, 1, 1, 3, 0, 8, 5, 1, 1, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  67, 3.0, '', 1, 8, 3, 3, 1, 1, 1, 3, 'Haedo', 1505, 'B', '6', '1602', 'esq. Av. Maipú', '', 1200, 1, 1300, 1, 0, 68.00, 6.00, 0.00, 0.00, 0.00, 0.00, 'Este', 2, 0, 2, 1, 1, 0, 0, 0, 2, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  68, 4.0, '', 7, 5, 3, 42, 1, 1, 1, 3, 'Santa Rosa', 2780, '', '', '1602', 'Ohiggins', 'Warnes', 0, 1, 210000, 2, 0, 190.00, 0.00, 170.00, 250.00, 25.00, 10.00, 'Norte', 3, 2, 3, 3, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  69, 1.0, '', 1, 5, 3, NULL, 1, 1, 1, 6, 'Juan de Garay', 2411, 'F', '7', '1638', 'Ugarte', 'Entre Rios', 0, 1, 47000, 2, 0, 33.00, 0.00, 0.00, 0.00, 0.00, 0.00, 'Este', 1, 0, 1, 1, 2, 0, 0, 0, 2, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  70, 1.0, '', 1, 5, 3, NULL, 1, 1, 1, 3, 'Av. Maipú', 1864, '5', '17', '1602', 'H. Irigoyen', 'Italia', 49000, 2, 52000, 2, 0, 38.00, 0.00, 0.00, 0.00, 0.00, 0.00, 'Este', 1, 0, 0, 1, 1, 1, 0, 0, 2, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  71, 2.0, '', 1, 8, 1, 55, 1, 1, 1, 3, 'España', 1667, 'C', '4', '1602', 'Arenales', 'Libertad', 800, 1, 900, 1, 0, 42.00, 6.00, 0.00, 0.00, 0.00, 0.00, 'Oeste', 1, 0, 1, 1, 1, 0, 6, 3, 1, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  72, 3.5, '', 8, 9, 1, NULL, 1, 2, 26, 37, 'J. M. Rosas', 515, '', '', '', 'Catamarca', 'Bme. Mitre', 0, 1, 7000, 1, 0, 110.00, 0.00, 90.00, 0.00, 0.00, 0.00, 'Sur', 2, 2, 2, 2, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, NULL, NULL, NULL )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  73, 5.0, '', 7, 4, 3, 5, 1, 1, 1, 3, 'Urquiza', 2378, '', '', '1602', 'Juan B. Justo', 'Ayacucho', 0, 1, 220000, 2, 0, 208.00, 0.00, 0.00, 0.00, 27.50, 8.70, 'Norte', 2, 2, 3, 2, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  74, 2.0, '', 1, 3, 3, 37, 1, 1, 1, 1, 'Av. Maipú', 1595, 'E', '10', '1636', 'esq. Arenales', '', 64000, 2, 69000, 2, 0, 45.00, 0.00, 5.50, 0.00, 0.00, 0.00, 'Este', 1, 0, 1, 1, 2, 0, 19, 4, 3, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  75, 6.0, '', 7, 4, 3, NULL, 1, 1, 1, 1, '25 de Mayo', 1747, '', '', '1636', 'Libertad', 'H. Irigoyen', 0, 1, 307000, 2, 0, 256.00, 0.00, 160.00, 302.00, 30.00, 10.40, 'Oeste', 4, 1, 4, 2, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  76, 2.0, '', 1, 1, 3, NULL, 1, 1, 1, 3, 'Hipolito Irigoyen', 1486, '', '5', '1602', 'Av. Maipú', 'Quintana', 0, 1, 68000, 2, 1, 45.00, 0.00, 0.00, 0.00, 0.00, 0.00, '', 1, 0, 1, 1, 3, 0, 6, 6, 1, 0, 0, '', '', '', 0, 0, 3, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  77, 3.0, '', 1, 4, 3, NULL, 1, 1, 1, 3, 'Arenales', 1502, '3', '2', '', 'esq. Av. Maipú', '', 70000, 2, 74000, 2, 0, 58.80, 4.20, 0.00, 0.00, 0.00, 0.00, 'Este', 1, 0, 2, 1, 1, 0, 0, 0, 0, 0, 0, '', '', '', 0, NULL, NULL, NULL )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  78, 1.0, '', 22, 6, 3, 21, 1, 1, 1, 4, 'Haedo', 3541, '', '', '', 'Estanislao del Campo', 'B. de Irigoyen', 1300, 1, 1500, 1, 0, 96.00, 0.00, 0.00, 0.00, 15.00, 5.50, 'Sur', 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  79, 3.0, '', 1, 6, 8, 2, 1, 1, 1, 3, 'Roca', 1702, 'A', '6', '1602', 'Avellaneda', '', 1500, 1, 1600, 1, 0, 60.00, 0.00, 2.00, 0.00, 0.00, 0.00, 'Norte', 2, 0, 2, 1, 1, 0, 9, 2, 1, 0, 0, '', '', '', 0, 25, NULL, 190.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  81, 3.0, '', 1, 5, 3, 1, 1, 1, 1, 6, 'Corrientes', 1467, 'H', '2', '', 'Av. Maipú', 'Cordoba', 60000, 2, 64000, 2, 0, 59.00, 4.00, 0.00, 0.00, 0.00, 0.00, 'Norte', 1, 0, 2, 1, 4, 0, 0, 0, 2, 0, 0, '', '', '', 0, 25, NULL, 170.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  82, 1.0, '', 11, 2, 6, NULL, 1, 1, 1, 3, 'Santa Rosa', 2022, '', '', '1602', 'Liniers', 'Chacabuco', 0, 2, 120000, 2, 0, 0.00, 0.00, 0.00, 199.18, 23.00, 8.66, 'Norte', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, '0,6', '1', 'R1', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  83, 2.0, '', 1, 8, 1, NULL, 1, 1, 1, 6, 'Ricardo Gutierrez', 965, 'B', '1', '1636', '', '', 0, 1, 2000, 1, 0, 73.00, 0.00, 0.00, 0.00, 0.00, 0.00, 'Sudoeste', 2, 1, 1, 1, 2, 0, 3, 2, 1, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  84, 1.5, '', 1, 8, 3, 47, 1, 1, 1, 1, 'Av. Maipu', 1585, 'C', '9', '1636', 'San Martin', 'Arenales', 0, 1, 1000, 1, 0, 36.00, 0.00, 0.00, 0.00, 0.00, 0.00, 'Sur', 1, 0, 0, 1, 4, 0, 0, 0, 0, 0, 0, '', '', '', 0, 35, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  85, 3.0, '', 1, 1, 8, NULL, 1, 1, 1, 1, 'Maipú', 1855, '', '', '1636', 'Irigoyen', 'Italia', 98000, 2, 110000, 2, 1, 65.00, 0.00, 0.00, 0.00, 0.00, 0.00, 'Este', 1, 1, 2, 1, 2, 0, 0, 0, 3, 0, 0, '', '', '', 0, 26, 27, 300.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  86, 6.0, '', 7, 1, 3, NULL, 1, 1, 1, 3, 'Melo', 2347, '', '', '1602', 'Ayacucho', 'Juan B. Justo', 0, 2, 215000, 2, 0, 189.00, 0.00, 250.00, 455.00, 45.50, 10.00, 'Sur', 0, 3, 3, 2, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  87, 2.0, '', 1, 4, 4, 49, 1, 1, 1, 1, 'Av. Maipú ', 1595, 'C', '12', '1636', 'Arenales', 'Av. San Martín', 58000, 2, 62000, 2, 0, 41.00, 7.00, 0.00, 0.00, 0.00, 0.00, 'Norte', 1, 0, 1, 1, 1, 1, 19, 5, 3, 0, 0, '', '', '', 0, 40, NULL, 160.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  88, 4.5, '', 1, 1, 3, 49, 1, 1, 1, 1, 'Uribelarrea', 481, 'B', '7', '', 'Av. Libertador', 'M. Uribelarrea', 180000, 2, 188000, 2, 0, 98.00, 0.00, 0.00, 0.00, 0.00, 0.00, 'Sur', 3, 1, 3, 1, 1, 0, 0, 2, 2, 0, 0, '', '', '', 0, 35, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  89, 1.0, '', 2, 4, 3, 50, 1, 1, 1, 6, 'Juan B. Justo', 3692, '', '', '', 'Bermudez', 'Jose ingenieros', 0, 2, 0, 2, 0, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, '', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  90, 5.0, '', 7, 1, 3, NULL, 1, 1, 1, 3, 'Rosetti', 458, '', '', '1602', 'Agustin Alvarez', 'Alsina', 0, 2, 200000, 2, 1, 300.00, 0.00, 260.00, 476.30, 55.00, 8.66, 'Este', 4, 2, 3, 3, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, 28, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  91, 3.0, '', 7, 1, 3, NULL, 1, 1, 1, 3, 'Vergara', 2531, '', '', '', 'Sarmiento', 'Ohiggins', 0, 2, 162000, 2, 1, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, '', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, 29, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  92, 2.0, '', 14, 9, 3, 52, 1, 1, 1, 1, 'Av. Maipú', 1209, '', '', '', 'Roca', 'Urquiza', 2500, 1, 3000, 1, 0, 88.00, 0.00, 0.00, 44.00, 11.00, 4.00, 'Oeste', 1, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  93, 4.0, '', 7, 4, 6, 53, 1, 1, 1, 3, 'Vergara', 3044, '', '', '1602', '', '', 0, 2, 0, 2, 0, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, '', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  94, 5.0, '', 7, 4, 8, 53, 1, 1, 1, 3, 'Rosetti', 1142, '', '', '1602', '', '', 390000, 2, 420000, 2, 0, 360.00, 0.00, 0.00, 0.00, 0.00, 0.00, 'Este', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, NULL, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  95, 3.0, '', 1, 6, 8, 61, 1, 1, 1, 1, 'Manuel Ugarte', 2350, 'A', '4', '', 'Av. Cabildo', 'Vuelta de Obligado', 0, 1, 2200, 1, 0, 59.00, 3.00, 0.00, 0.00, 0.00, 0.00, 'Norte', 1, 1, 2, 1, 1, 0, 9, 2, 2, 1, 0, '', '', '', 0, 5, NULL, 480.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  96, 1.0, '', 1, 1, 1, NULL, 1, 1, 1, 6, 'D.F. Sarmiento', 2463, '', '', '', 'Ugarte', 'Amador', 0, 2, 189000, 2, 1, 143.00, 0.00, 100.00, 0.00, 0.00, 0.00, '', 0, 0, 3, 3, 0, 0, 0, 0, 0, 0, 0, '', '', '', 0, 0, 6, 0.00 )
go
--The following columns were excluded due to unsupported datatypes: [Observaciones]
INSERT INTO [dbo].[Propiedades] ( [IdPropiedad], [CantidadAmbientes], [Codigo], [IdTipoPropiedad], [IdEstadoPropiedad], [EnumEstadoProp], [IdPropietario], [IdPais], [IdProvincia], [IdLocalidad], [IdBarrio], [Calle], [NumeroPostal], [Depto], [Piso], [CodigoPostal], [CalleEntre1], [CalleEntre2], [ValorMercadoImporte], [ValorMercadoMoneda], [ValorPublicacionImporte], [ValorPublicacionMoneda], [EsOtraInmobiliaria], [MetrosCubiertos], [MetrosSemicubiertos], [MetrosLibres], [TerrenoMetros], [TerrenoFondo], [TerrenosFrente], [Orientacion], [CantidadBanos], [CantidadCocheras], [CantidadDomritorios], [CantidadPlantas], [IdDepartamentoDisposicion], [EsAptoProfesional], [DeptoCantidadPisos], [DeptoDepartamentosPorPiso], [CantidadAscensores], [CantidadAscensoresServicio], [IdTipoZona], [Fos], [Fot], [Zonificacion], [MetrosContruibles], [Antiguedad], [IdInmobiliariaExterna], [ValorExpensas] ) VALUES(  97, 2.0, '', 1, 1, 8, 66, 1, 1, 1, 1, 'Ciudad de la Paz', 347, 'A', '3', '', 'Jorge Newbery', 'Matienzo', 92000, 2, 97000, 2, 0, 47.00, 3.30, 0.00, 0.00, 0.00, 0.00, 'Oeste', 1, 1, 1, 1, 1, 1, 7, 2, 1, 0, 0, '', '', '', 0, 2, NULL, 250.00 )
go
INSERT INTO [dbo].[PropiedadesOfrecidasXPedido] ( [IdPedido], [IdPropiedad] ) VALUES(  2, 44 )
go
INSERT INTO [dbo].[PropiedadesOfrecidasXPedido] ( [IdPedido], [IdPropiedad] ) VALUES(  2, 63 )
go
INSERT INTO [dbo].[PropiedadesOfrecidasXPedido] ( [IdPedido], [IdPropiedad] ) VALUES(  2, 85 )
go
INSERT INTO [dbo].[PropiedadesOfrecidasXPedido] ( [IdPedido], [IdPropiedad] ) VALUES(  3, 34 )
go
INSERT INTO [dbo].[PropiedadesOfrecidasXPedido] ( [IdPedido], [IdPropiedad] ) VALUES(  4, 34 )
go
INSERT INTO [dbo].[PropiedadesOfrecidasXPedido] ( [IdPedido], [IdPropiedad] ) VALUES(  8, 79 )
go
INSERT INTO [dbo].[PropiedadesOfrecidasXPedido] ( [IdPedido], [IdPropiedad] ) VALUES(  10, 35 )
go
INSERT INTO [dbo].[PropiedadesOfrecidasXPedido] ( [IdPedido], [IdPropiedad] ) VALUES(  17, 52 )
go
INSERT INTO [dbo].[PropiedadesOfrecidasXPedido] ( [IdPedido], [IdPropiedad] ) VALUES(  18, 37 )
go
INSERT INTO [dbo].[PropiedadesOfrecidasXPedido] ( [IdPedido], [IdPropiedad] ) VALUES(  18, 76 )
go
INSERT INTO [dbo].[PropiedadesOfrecidasXPedido] ( [IdPedido], [IdPropiedad] ) VALUES(  19, 35 )
go
INSERT INTO [dbo].[PropiedadesOfrecidasXPedido] ( [IdPedido], [IdPropiedad] ) VALUES(  19, 49 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  1 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  2 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  3 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  4 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  5 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  19 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  21 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  22 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  23 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  24 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  25 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  26 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  27 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  28 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  29 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  30 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  31 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  32 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  33 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  34 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  35 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  36 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  37 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  38 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  39 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  40 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  41 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  42 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  45 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  47 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  49 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  50 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  52 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  53 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  55 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  61 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  66 )
go
INSERT INTO [dbo].[Propietarios] ( [IdCliente] ) VALUES(  69 )
go
INSERT INTO [dbo].[Provincias] ( [IdProvincia], [Nombre], [Default], [IdPais] ) VALUES(  1, 'Gran Buenos Aires', 1, 1 )
go
INSERT INTO [dbo].[Provincias] ( [IdProvincia], [Nombre], [Default], [IdPais] ) VALUES(  2, 'Buenos Aires', 0, 1 )
go
INSERT INTO [dbo].[Provincias] ( [IdProvincia], [Nombre], [Default], [IdPais] ) VALUES(  3, 'Capital Federal', 0, 1 )
go
INSERT INTO [dbo].[Provincias] ( [IdProvincia], [Nombre], [Default], [IdPais] ) VALUES(  4, 'Córdoba', 0, 1 )
go
INSERT INTO [dbo].[Provincias] ( [IdProvincia], [Nombre], [Default], [IdPais] ) VALUES(  5, 'Santa Fé', 0, 1 )
go
INSERT INTO [dbo].[Provincias] ( [IdProvincia], [Nombre], [Default], [IdPais] ) VALUES(  6, 'Mendoza', 0, 1 )
go
INSERT INTO [dbo].[Provincias] ( [IdProvincia], [Nombre], [Default], [IdPais] ) VALUES(  7, 'Tucumán', 0, 1 )
go
INSERT INTO [dbo].[Provincias] ( [IdProvincia], [Nombre], [Default], [IdPais] ) VALUES(  8, 'Entre Rios', 0, 1 )
go
INSERT INTO [dbo].[Provincias] ( [IdProvincia], [Nombre], [Default], [IdPais] ) VALUES(  9, 'Salta', 0, 1 )
go
INSERT INTO [dbo].[Provincias] ( [IdProvincia], [Nombre], [Default], [IdPais] ) VALUES(  10, 'Misiones', 0, 1 )
go
INSERT INTO [dbo].[Provincias] ( [IdProvincia], [Nombre], [Default], [IdPais] ) VALUES(  11, 'Chaco', 0, 1 )
go
INSERT INTO [dbo].[Provincias] ( [IdProvincia], [Nombre], [Default], [IdPais] ) VALUES(  12, 'Corrientes', 0, 1 )
go
INSERT INTO [dbo].[Provincias] ( [IdProvincia], [Nombre], [Default], [IdPais] ) VALUES(  13, 'Santiago del Estero', 0, 1 )
go
INSERT INTO [dbo].[Provincias] ( [IdProvincia], [Nombre], [Default], [IdPais] ) VALUES(  14, 'Jujuy', 0, 1 )
go
INSERT INTO [dbo].[Provincias] ( [IdProvincia], [Nombre], [Default], [IdPais] ) VALUES(  15, 'San Juan', 0, 1 )
go
INSERT INTO [dbo].[Provincias] ( [IdProvincia], [Nombre], [Default], [IdPais] ) VALUES(  16, 'Rio Negro', 0, 1 )
go
INSERT INTO [dbo].[Provincias] ( [IdProvincia], [Nombre], [Default], [IdPais] ) VALUES(  17, 'Formosa', 0, 1 )
go
INSERT INTO [dbo].[Provincias] ( [IdProvincia], [Nombre], [Default], [IdPais] ) VALUES(  18, 'Neuquén', 0, 1 )
go
INSERT INTO [dbo].[Provincias] ( [IdProvincia], [Nombre], [Default], [IdPais] ) VALUES(  19, 'Chubut', 0, 1 )
go
INSERT INTO [dbo].[Provincias] ( [IdProvincia], [Nombre], [Default], [IdPais] ) VALUES(  20, 'San Luis', 0, 1 )
go
INSERT INTO [dbo].[Provincias] ( [IdProvincia], [Nombre], [Default], [IdPais] ) VALUES(  21, 'Catamarca', 0, 1 )
go
INSERT INTO [dbo].[Provincias] ( [IdProvincia], [Nombre], [Default], [IdPais] ) VALUES(  22, 'La Rioja', 0, 1 )
go
INSERT INTO [dbo].[Provincias] ( [IdProvincia], [Nombre], [Default], [IdPais] ) VALUES(  23, 'La Pampa', 0, 1 )
go
INSERT INTO [dbo].[Provincias] ( [IdProvincia], [Nombre], [Default], [IdPais] ) VALUES(  24, 'Santa Cruz', 0, 1 )
go
INSERT INTO [dbo].[Provincias] ( [IdProvincia], [Nombre], [Default], [IdPais] ) VALUES(  25, 'Tierra del Fuego', 0, 1 )
go
INSERT INTO [dbo].[Smtp] ( [AutenticacionSmtp], [Email], [Host], [Nombre], [Password], [Puerto], [SSL], [UserName] ) VALUES(  1, 'info@pime.com.ar', 'mail.pime.com.ar', 'Pime Negocios Inmobiliarios', 'pime1647', 25, 0, 'info@pime.com.ar                                  ' )
go
SET IDENTITY_INSERT [dbo].[sysdiagrams] ON
go
INSERT INTO [dbo].[sysdiagrams] ( [diagram_id], [name], [principal_id], [version], [definition] ) VALUES(  1, 'Diagrama', 1, 1, 0xd0cf11e0a1b11ae1000000000000000000000000000000003e000300feff0900060000000000000000000000010000000100000000000000001000002f00000001000000feffffff0000000000000000fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffdffffff31000000030000000400000005000000060000000700000008000000090000000a0000000b0000000c000000feffffff0e0000000f000000100000001100000012000000130000001400000015000000160000001700000018000000190000001a0000001b0000001c0000001d0000001e0000001f000000200000002100000022000000230000002400000025000000260000002700000028000000290000002a0000002b0000002c0000002d0000002e000000fefffffffeffffff4d000000feffffff330000003400000035000000360000003700000038000000390000003a0000003b0000003c0000003d0000003e0000003f000000400000004100000042000000430000004400000045000000460000004700000048000000490000004a0000004b0000004c000000feffffff4e0000004f000000feffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff52006f006f007400200045006e00740072007900000000000000000000000000000000000000000000000000000000000000000000000000000000000000000016000500ffffffffffffffff0200000000000000000000000000000000000000000000000000000000000000f02607fc4daac80130000000c0060000000000006600000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000004000201ffffffffffffffffffffffff00000000000000000000000000000000000000000000000000000000000000000000000002000000be140000000000006f000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000040002010100000004000000ffffffff0000000000000000000000000000000000000000000000000000000000000000000000000d0000008842000000000000010043006f006d0070004f0062006a0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000012000201ffffffffffffffffffffffff000000000000000000000000000000000000000000000000000000000000000000000000000000005f00000000000000000430000a1e100c05000080460000000f00ffff46000000007d0000004a00003e4b0000e0dc0000971b0100dfcdffff02350000de805b10f195d011b0a000aa00bdcb5c000008003000000000020000030000003c006b0000000900000000000000d9e6b0e91c81d011ad5100a0c90f573970e24e46c7fdd211974300105a994f8d61cdd34fade5d311903d00c04f79f83100002800430000000000000053444dd2011fd1118e63006097d2df48e89985508adfd111a2d0006097c4de2400002800430000000000000051444dd2011fd1118e63006097d2df48e66bb69f5cb2cf11baa800aa00a2043042000000cc13000000c2010000007400a5090000070000804500000062000000018000004b000080436f6e74726f6c00c13d00003cc5000052656c616369f36e2027464b5f47616c65726961466f746f735f50726f70696564616465732720656e747265202750726f7069656461646573272079202747616c65726961466f746f73270000006c00a50900000700008042000000620000000180000041000080436f6e74726f6c0048b8ffff0881000052656c616369f36e2027464b5f496e7175696c696e6f735f436c69656e7465732720656e7472652027436c69656e7465732720792027496e7175696c696e6f732700000000006c00a5090000070000803f000000620000000180000043000080436f6e74726f6c0035f8fffffd63000052656c616369f36e2027464b5f50726f70696564616465735f436c69656e7465732720656e7472652027436c69656e746573272079202750726f7069656461646573270000007000a5090000070000803d000000620000000180000045000080436f6e74726f6c0041ecffff263d000052656c616369f36e2027464b5f50726f706965746172696f735f436c69656e7465732720656e7472652027436c69656e746573272079202750726f706965746172696f7327d1235500006c00a5090000070000803a000000620000000180000041000080436f6e74726f6c0089edffff0481000052656c616369f36e2027464b5f436c69656e7465735f50726f76696e636961732720656e747265202750726f76696e636961732720792027436c69656e74657327696f7300006400a50900000700008038000000620000000180000039000080436f6e74726f6c004befffff0481000052656c616369f36e2027464b5f436c69656e7465735f5061697365732720656e74726520275061697365732720792027436c69656e7465732700650000006c00a50900000700008036000000620000000180000043000080436f6e74726f6c00c7d0ffff0481000052656c616369f36e2027464b5f436c69656e7465735f4c6f63616c6964616465732720656e74726520274c6f63616c6964616465732720792027436c69656e746573277300006400a5090000070000803400000062000000018000003b000080436f6e74726f6c00f7e9ffff0481000052656c616369f36e2027464b5f436c69656e7465735f42617272696f732720656e747265202742617272696f732720792027436c69656e746573270000006c00a5090000090000802f00000062000000018000003f000080436f6e74726f6c3437000000953c0000d02b000052656c616369f36e2027464b5f56656e7461735f50726f70696564616465732720656e747265202750726f7069656461646573272079202756656e746173270000009400a5090000090000802a000000620000000180000065000080436f6e74726f6c34320000004c5a0000f577000052656c616369f36e2027464b5f4d656469646173416d6269656e74657350726f7069656461645f5469706f7344655069736f2720656e74726520275469706f7344655069736f27207920274d656469646173416d6269656e74657350726f7069656461642700000000009400a50900000900008028000000620000000180000065000080436f6e74726f6c3430000000814600000389000052656c616369f36e2027464b5f4d656469646173416d6269656e74657350726f7069656461645f50726f70696564616465732720656e747265202750726f706965646164657327207920274d656469646173416d6269656e74657350726f7069656461642700000000007000a50900000900008024000000620000000180000042000080436f6e74726f6c3336000000e32e000038c5000052656c616369f36e2027464b5f50726f70696564616465735f4d6f6e65646173312720656e74726520274d6f6e65646173272079202750726f706965646164657327277300007000a50900000900008022000000620000000180000041000080436f6e74726f6c3334000000212d000038c5000052656c616369f36e2027464b5f50726f70696564616465735f4d6f6e656461732720656e74726520274d6f6e65646173272079202750726f70696564616465732727277300007000a50900000900008020000000620000000180000041000080436f6e74726f6c333200000094f2ffffb987000052656c616369f36e2027464b5f50726f70696564616465735f42617272696f732720656e747265202742617272696f73272079202750726f70696564616465732727277300007800a5090000090000801e000000620000000180000049000080436f6e74726f6c333000000064d9ffffff8c000052656c616369f36e2027464b5f50726f70696564616465735f4c6f63616c6964616465732720656e74726520274c6f63616c696461646573272079202750726f70696564616465732773270000007400a5090000090000801c000000620000000180000047000080436f6e74726f6c3238000000c40b00003d8b000052656c616369f36e2027464b5f50726f70696564616465735f50726f76696e636961732720656e747265202750726f76696e63696173272079202750726f7069656461646573275500006c00a5090000090000801a00000062000000018000003f000080436f6e74726f6c3236000000162900007b89000052656c616369f36e2027464b5f50726f70696564616465735f5061697365732720656e7472652027506169736573272079202750726f7069656461646573270000008000a50900000900008018000000620000000180000053000080436f6e74726f6c323400000014290000c18e000052656c616369f36e2027464b5f50726f70696564616465735f45737461646f7350726f7069656461642720656e747265202745737461646f7350726f706965646164272079202750726f7069656461646573270000007c00a5090000090000801600000062000000018000004f000080436f6e74726f6c323200000058200000452a000052656c616369f36e2027464b5f50726f70696564616465735f5469706f7350726f7069656461642720656e74726520275469706f7350726f706965646164272079202750726f7069656461646573270000007000a50900000900008013000000620000000180000041000080436f6e74726f6c313900000064d9ffff5490000052656c616369f36e2027464b5f42617272696f735f4c6f63616c6964616465732720656e74726520274c6f63616c696461646573272079202742617272696f732764616400007400a50900000900008010000000620000000180000047000080436f6e74726f6c313600000064d9ffffa4b7000052656c616369f36e2027464b5f4c6f63616c6964616465735f50726f76696e636961732720656e747265202750726f76696e6369617327207920274c6f63616c696461646573275500006c00a5090000090000800d00000062000000018000003d000080436f6e74726f6c3133000000c40b00002ca4000052656c616369f36e2027464b5f50726f76696e636961735f5061697365732720656e7472652027506169736573272079202750726f76696e636961732773270000008800a5090000080000800600000062000000018000005f000080436f6e74726f6c36e32a00007a25000052656c616369f36e2027464b5f5469706f7350726f7069656461645f43617465676f7269617350726f7069656461642720656e747265202743617465676f7269617350726f70696564616427207920275469706f7350726f706965646164270000007400a50900000900008031000000620000000180000047000080436f6e74726f6c343900000081460000218b000052656c616369f36e2027464b5f416c7175696c657265735f50726f70696564616465732720656e747265202750726f70696564616465732720792027416c7175696c65726573275500002c00b50100000900008007000000310000007d000000028000004444534c6162656c37000000333300009f24000000002c00b50100000a00008014000000310000005f000000028000004444534c6162656c32300000a7e1ffffb3b5000000002c00b50100000a000080110000003100000065000000028000004444534c6162656c3137000014d2ffffe5b6000000002c00b50100000a0000800e000000310000005b000000028000004444534c6162656c3134000075070000b3af000000002c00b50100000a00008017000000310000006d000000028000004444534c6162656c3233000067280000f631000000002c00b50100000a000080190000003100000071000000028000004444534c6162656c323500000330000046c6000000002c00b50100000a0000801b000000310000005d000000028000004444534c6162656c32370000e72d00005397000000002c00b50100000a0000801d0000003100000065000000028000004444534c6162656c323900009b2e000098b1000000002c00b50100000a0000801f0000003100000067000000028000004444534c6162656c33310000e428000074ce000000002c00b50100000a00008021000000310000005f000000028000004444534c6162656c33330000281900007e92000000002c00b50100000a00008023000000310000005f000000028000004444534c6162656c33350000833c0000a1e8000000002c00b50100000a000080250000003100000061000000028000004444534c6162656c33370000453e00009ee8000000002c00b50100000a000080290000003100000083000000028000004444534c6162656c34310000124d0000a58b000000002c00b50100000a0000802b0000003100000083000000028000004444534c6162656c343300003a400000ee7f000000002c00b50100000a00008030000000310000005d000000028000004444534c6162656c34380000db3e0000e030000000002c00b50100000a000080320000003100000065000000028000004444534c6162656c35300000784f0000a691000000003c00a50900000800008002000000b8020000008000001300008053636847726964326f350000d221000043617465676f7269617350726f7069656461640000003c00a50900000800008001000000ba0200000080000014000080536368477269643140b1ffff080700004c6963656e63696173506f725465726d696e616c00003800a50900000800008003000000ae020000008000000e000080536368477269643363170000192100005469706f7350726f706965646164000000003800a50900000800008008000000b2020000008000001000008053636847726964382b1200001bda000045737461646f7350726f70696564616400003400a5090000090000800b0000009e02000000800000060000805363684772696431316f706950160000e79f0000506169736573643100003800a5090000090000800c000000a6020000008000000a0000805363684772696431326f706920fdffff8bb4000050726f76696e63696173706900003800a5090000090000800f000000a8020000008000000b000080536368477269643135737069c0caffff53c700004c6f63616c6964616465736900003400a50900000900008012000000a00200000080000007000080536368477269643138657369f0e3ffff1f8d000042617272696f733100003000a50900000800008009000000a0020000008000000700008053636847726964398426000055eb00004d6f6e656461733900004800a50900000900008027000000c402000000800000190000805363684772696433396573690d5100000c8400004d656469646173416d6269656e74657350726f70696564616400000000003800a5090000090000800a000000a8020000008000000b000080536368477269643130657369af530000827200005469706f7344655069736f6900003400a5090000090000802d0000009e0200000080000006000080536368477269643435736f699f5100006727000056656e746173643400003800a5090000090000802e000000a6020000008000000a000080536368477269643436736f690d5100003c9a0000416c7175696c657265736f6900003800a5090000090000801500000088020000008000000b000080536368477269643231736f69a03300005e50000050726f70696564616465736900003000a50900000700008033000000a20200000080000008000080536368477269643920e2ffffb2470000436c69656e74657300002800b50100000700008035000000310000005900000002800000436f6e74726f6c73f1edffffd189000000002800b50100000700008037000000310000006100000002800000436f6e74726f6c730dd3ffff2999000000002800b50100000700008039000000310000005700000002800000436f6e74726f6c73e21000001f88000000002800b5010000070000803b000000310000005f00000002800000436f6e74726f6c736d0500005b8f000000003400a5090000070000803c000000aa020000008000000c000080536368477269647301e3ffff5c36000050726f706965746172696f7300002800b5010000070000803e000000310000006300000002800000436f6e74726f6c7387eeffff1841000000002800b50100000700008040000000310000006100000002800000436f6e74726f6c73b0feffff4366000000003400a50900000700008041000000a6020000008000000a000080536368477269647340b1ffff1f8d0000496e7175696c696e6f736f7300002800b50100000700008043000000310000005f00000002800000436f6e74726f6c73b9c4ffff6b87000000003400a50900000700008044000000aa020000008000000c00008053636847726964730243000055eb000047616c65726961466f746f7300002800b50100000700008046000000310000006900000002800000436f6e74726f6c730740000007e700000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000004000b00583f0000f3c70000583f000010e90000cc4b000010e90000cc4b000055eb00000000000002000000f0f0f000000000000000000000000000000000000100000046000000000000000740000007e700001c1000005801000045000000010004000b00bee9ffffbf830000bee9ffff7289000074b9ffff7289000074b9ffff1f8d00000200000002000000f0f0f00000000000000000000000000000000000010000004300000000000000b9c4ffff6b8700000d0c00005801000034000000010004000b0061f9ffff94650000842c000094650000842c000072870000a0330000728700000000000002000000f0f0f00000000000000000000000000000000000010000004000000000000000b0feffff43660000a10d00005801000008000000010004000b00d8edffffb2470000d8edffffe33f00008dedffffe33f00008dedffff523e00000200000002000000f0f0f00000000000000000000000000000000000010000003e0000000000000087eeffff18410000680d00005801000032000000010004000b00be0400008bb40000be040000da8a000004efffffda8a000004efffffbf8300000000000002000000f0f0f00000000000000000000000000000000000010000003b000000000000006d0500005b8f0000630c00005801000032000000010004000b0046200000e79f000046200000268a0000c6f0ffff268a0000c6f0ffffbf8300000000000002000000f0f0f00000000000000000000000000000000000010000003900000000000000e21000001f8800005d0a00005801000032000000010004000b005ed2ffff53c700005ed2ffff268a000080ebffff268a000080ebffffbf8300000000000002000000f0f0f000000000000000000000000000000000000100000037000000000000000dd3ffff299900002e0d00005801000032000000010004000b008eebffff1f8d00008eebffffda8a000042edffffda8a000042edffffbf8300000000000002000000f0f0f00000000000000000000000000000000000010000003500000000000000f1edffffd1890000b40a00005801000032000000010004000b002c3e00005e5000002c3e0000412f0000ff5a0000412f0000ff5a0000fc2c00000200000002000000f0f0f00000000000000000000000000000000000010000003000000000000000db3e0000e03000005e0e0000a701000032000000000004000b00e35b0000ac7a0000e35b00007b8200002f5c00007b8200002f5c00000c8400000000000002000000f0f0f00000000000000000000000000000000000010000002b000000000000003a400000ee7f0000fa1a0000a701000032000000000004000b00ad470000f68a0000c94e0000f68a0000c94e00007e8a00000d5100007e8a00000000000002000000f0f0f00000000000000000000000000000000000010000002900000000000000124d0000a58b0000491b0000a701000032000000000004000b007a30000055eb00007a30000010e90000963d000010e90000963d0000f3c700000000000002000000f0f0f00000000000000000000000000000000000010000002500000000000000453e00009ee8000054100000a701000022000000000004000b00b82e000055eb0000b82e00005ce80000d43b00005ce80000d43b0000f3c700000000000002000000f0f0f00000000000000000000000000000000000010000002300000000000000833c0000a1e800009b0f0000a701000022000000000004000b00c0f3ffffcf910000842c0000cf910000842c000034890000a0330000348900000000000002000000f0f0f00000000000000000000000000000000000010000002100000000000000281900007e9200005e0e0000a701000033000000000004000b0090daffffc5cd0000a02e0000c5cd0000a02e00007a8e0000a03300007a8e00000000000002000000f0f0f00000000000000000000000000000000000010000001f00000000000000e428000074ce00000e110000a701000033000000000004000b00f00c0000d1b90000ec2d0000d1b90000ec2d0000b88c0000a0330000b88c00000000000002000000f0f0f00000000000000000000000000000000000010000001d000000000000009b2e000098b100003a100000a701000032000000000004000b00422a0000c3a50000382d0000c3a50000382d0000f68a0000a0330000f68a00000000000002000000f0f0f00000000000000000000000000000000000010000001b00000000000000e72d000053970000f40d0000a701000032000000000004000b00402a000035de0000542f000035de0000542f00003c900000a03300003c9000000000000002000000f0f0f000000000000000000000000000000000000100000019000000000000000330000046c60000e1140000a701000022000000000004000b00ef210000fc2c0000ef210000412f00006a3c0000412f00006a3c00005e5000000000000002000000f0f0f0000000000000000000000000000000000001000000170000000000000067280000f631000054130000a701000032000000000004000b0090daffff41ca0000f8e0ffff41ca0000f8e0ffffcf910000f0e3ffffcf9100000000000002000000f0f0f00000000000000000000000000000000000010000001400000000000000a7e1ffffb3b50000d90d0000a70100002a000000000004000b0020fdffff3bb90000ace1ffff3bb90000ace1ffff03cc000090daffff03cc00000000000002000000f0f0f0000000000000000000000000000000000001000000110000000000000014d2ffffe5b60000b60f0000a701000032000000000004000b0050160000c3a50000c0140000c3a50000c01400000fb80000f00c00000fb800000000000002000000f0f0f00000000000000000000000000000000000010000000e0000000000000075070000b3af00009c0c0000a701000032000000000004000b006f35000018270000df33000018270000df330000f52600000f2c0000f52600000000000002000000f0f0f00000000000000000000000000000000000010000000700000000000000333300009f24000064180000a70100001f000000000004000b00ad470000b88c0000c94e0000b88c0000c94e000018a000000d51000018a000000200000002000000f0f0f00000000000000000000000000000000000010000003200000000000000784f0000a6910000eb0f0000a70100003200000000000002000064180000a7010000020000000000050000800800008001000000150001000000900144420100065461686f6d61250046004b005f005400690070006f007300500072006f007000690065006400610064005f00430061007400650067006f007200690061007300500072006f0070006900650064006100640000020000d90d0000a7010000020000000000050000800800008001000000150001000000900144420100065461686f6d61160046004b005f00420061007200720069006f0073005f004c006f00630061006c0069006400610064006500730000020000b60f0000a7010000020000000000050000800800008001000000150001000000900144420100065461686f6d61190046004b005f004c006f00630061006c006900640061006400650073005f00500072006f00760069006e006300690061007300000200009c0c0000a7010000020000000000050000800800008001000000150001000000900144420100065461686f6d61140046004b005f00500072006f00760069006e0063006900610073005f005000610069007300650073000002000054130000a7010000020000000000050000800800008001000000150001000000900144420100065461686f6d611d0046004b005f00500072006f00700069006500640061006400650073005f005400690070006f007300500072006f0070006900650064006100640000020000e1140000a7010000020000000000050000800800008001000000150001000000900144420100065461686f6d611f0046004b005f00500072006f00700069006500640061006400650073005f00450073007400610064006f007300500072006f0070006900650064006100640000020000f40d0000a7010000020000000000050000800800008001000000150001000000900144420100065461686f6d61150046004b005f00500072006f00700069006500640061006400650073005f00500061006900730065007300000200003a100000a7010000020000000000050000800800008001000000150001000000900144420100065461686f6d61190046004b005f00500072006f00700069006500640061006400650073005f00500072006f00760069006e006300690061007300000200000e110000a7010000020000000000050000800800008001000000150001000000900144420100065461686f6d611a0046004b005f00500072006f00700069006500640061006400650073005f004c006f00630061006c00690064006100640065007300000200005e0e0000a7010000020000000000050000800800008001000000150001000000900144420100065461686f6d61160046004b005f00500072006f00700069006500640061006400650073005f00420061007200720069006f007300000200009b0f0000a7010000020000000000050000800800008001000000150001000000900144420100065461686f6d61160046004b005f00500072006f00700069006500640061006400650073005f004d006f006e0065006400610073000002000054100000a7010000020000000000050000800800008001000000150001000000900144420100065461686f6d61170046004b005f00500072006f00700069006500640061006400650073005f004d006f006e006500640061007300310000020000491b0000a7010000020000000000050000800800008001000000150001000000900144420100065461686f6d61280046004b005f004d0065006400690064006100730041006d006200690065006e00740065007300500072006f007000690065006400610064005f00500072006f007000690065006400610064006500730000020000fa1a0000a7010000020000000000050000800800008001000000150001000000900144420100065461686f6d61280046004b005f004d0065006400690064006100730041006d006200690065006e00740065007300500072006f007000690065006400610064005f005400690070006f007300440065005000690073006f00000200005e0e0000a7010000020000000000050000800800008001000000150001000000900144420100065461686f6d61150046004b005f00560065006e007400610073005f00500072006f007000690065006400610064006500730000020000eb0f0000a7010000020000000000050000800800008001000000150001000000900144420100065461686f6d61190046004b005f0041006c007100750069006c0065007200650073005f00500072006f00700069006500640061006400650073002143341208000000d0120000700a0000785634120700000014010000430061007400650067006f007200690061007300500072006f0070006900650064006100640000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000f000000060ffffff0100000005000000540000002c0000002c0000002c000000340000000000000000000000b82b00004a180000010000002d0100000d0000000c000000070000001c0100007206000046050000d0020000840300007602000008070000460500002a03000046050000ae060000920400000000000001000000d0120000700a000000000000020000000200000002000000020000001c010000610800000000000001000000d00f0000ca02000000000000000000000000000002000000020000001c010000720600000100000000000000d00f0000ca02000000000000000000000000000002000000020000001c010000720600000000000000000000842500004a18000000000000000000000d00000004000000040000001c010000720600009e070000b004000078563412040000007000000001000000010000000b000000000000000100000002000000030000000400000005000000060000000700000008000000090000000a00000004000000640062006f00000014000000430061007400650067006f007200690061007300500072006f0070006900650064006100640000002143341208000000310f0000710a00007856341207000000140100004c006900630065006e00630069006100730050006f0072005400650072006d0069006e0061006c0000001c201d20222013201420dc02222161013a2053019d007e017801a000a100a200a300a400a500a600a700a800a900aa00ab00ac00ad00ae00af00b000b100b200b300b400b500b600b700b800b900ba00bb00bc00bd00be00bf00c000c100c200c300c400c500c600c700c800c900ca00cb00cc00cd00ce00cf00d000d100d200d300d400d500d600d700d800d900da00db00dc00dd00de00df00e000e100e200e300e400e500e600e700e800e900ea00eb00ec00ed00ee00ef00f000f100f200f300f4000000f000000060ffffff0100000005000000540000002c0000002c0000002c0000003400000000000000000000005b3c000035250000010000002d0100000d0000000c000000070000001c0100007206000046050000d0020000840300007602000008070000460500002a03000046050000ae060000920400000000000001000000310f0000710a000000000000030000000300000002000000020000001c010000ec0400000000000001000000d00f0000ca02000000000000000000000000000002000000020000001c010000720600000100000000000000d00f0000ca02000000000000000000000000000002000000020000001c010000720600000000000000000000842500004a18000000000000000000000d00000004000000040000001c010000720600009e070000b004000078563412040000007200000001000000010000000b000000000000000100000002000000030000000400000005000000060000000700000008000000090000000a00000004000000640062006f000000150000004c006900630065006e00630069006100730050006f0072005400650072006d0069006e0061006c0000002143341208000000ac140000e30b00007856341207000000140100005400690070006f007300500072006f007000690065006400610064000000ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff0100000000000000fdffffff00000000000000006853300200000000000000000000e10000000000685330020000e7000000000000000000feffffff00000000000000006853300200000000f000000060ffffff0100000005000000540000002c0000002c0000002c000000340000000000000000000000b82b00004a180000010000002d0100000d0000000c000000070000001c0100007206000046050000d0020000840300007602000008070000460500002a03000046050000ae060000920400000000000001000000ac140000e30b000000000000030000000300000002000000020000001c0100006f0900000000000001000000d00f0000ca02000000000000000000000000000002000000020000001c010000720600000100000000000000d00f0000ca02000000000000000000000000000002000000020000001c010000720600000000000000000000842500004a18000000000000000000000d00000004000000040000001c010000720600009e070000b004000078563412040000006600000001000000010000000b000000000000000100000002000000030000000400000005000000060000000700000008000000090000000a00000004000000640062006f0000000f0000005400690070006f007300500072006f007000690065006400610064000000214334120800000015180000da070000785634120700000014010000450073007400610064006f007300500072006f007000690065006400610064000000650066006200380062007d0000005c005c003f005c00530054004f005200410047004500230056006f006c0075006d006500230031002600330030006100390036003500390038002600300026005300690067006e0061007400750072006500460042003700320046004200370032004f006600660073006500740037004500300030004c0065006e0067007400680037004600390046003300380043003000300023007b00350033006600350036003300300064002d0062003600620066002d0031003100640030002d000000f000000060ffffff0100000005000000540000002c0000002c0000002c000000340000000000000000000000b82b00004a180000010000002d0100000d0000000c000000070000001c0100007206000046050000d0020000840300007602000008070000460500002a03000046050000ae06000092040000000000000100000015180000da07000000000000030000000300000002000000020000001c0100005f0a00000000000001000000d00f0000ca02000000000000000000000000000002000000020000001c010000720600000100000000000000d00f0000ca02000000000000000000000000000002000000020000001c010000720600000000000000000000842500004a18000000000000000000000d00000004000000040000001c010000720600009e070000b004000078563412040000006a00000001000000010000000b000000000000000100000002000000030000000400000005000000060000000700000008000000090000000a00000004000000640062006f00000011000000450073007400610064006f007300500072006f0070006900650064006100640000002143341208000000f2130000440b00007856341207000000140100005000610069007300650073000000ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff52006f006f007400200045006e00740072007900000000000000000000000000000000000000000000000000000000000000000000000000000000000000000016000500ffffffffffffffffffffffff00000000f000000060ffffff0100000005000000540000002c0000002c0000002c000000340000000000000000000000b82b00004a180000010000002d0100000d0000000c000000070000001c0100007206000046050000d0020000840300007602000008070000460500002a03000046050000ae060000920400000000000001000000f2130000440b000000000000020000000200000002000000020000001c010000060900000000000001000000d00f0000ca02000000000000000000000000000002000000020000001c010000720600000100000000000000d00f0000ca02000000000000000000000000000002000000020000001c010000720600000000000000000000842500004a18000000000000000000000d00000004000000040000001c010000720600009e070000b004000078563412040000005600000001000000010000000b000000000000000100000002000000030000000400000005000000060000000700000008000000090000000a00000004000000640062006f0000000700000050006100690073006500730000002143341208000000d00f000068090000785634120700000014010000500072006f00760069006e006300690061007300000000004c006900630065006e00630069006100730050006f0072005400650072006d0069006e0061006c00000008000000640062006f0000000002260028000000430061007400650067006f007200690061007300500072006f00700069006500640061006400000008000000640062006f000000000226001e0000005400690070006f007300500072006f00700069006500640061006400000008000000640062006f0000000002260022000000450073007400610064006f007300500072006f00700069006500640061006400000008000000640062000000f000000060ffffff0100000005000000540000002c0000002c0000002c000000340000000000000000000000b82b00004a180000010000002d0100000d0000000c000000070000001c0100007206000046050000d0020000840300007602000008070000460500002a03000046050000ae060000920400000000000001000000d00f00006809000000000000040000000400000002000000020000001c010000af0500000000000001000000d00f0000ca02000000000000000000000000000002000000020000001c010000720600000100000000000000d00f0000ca02000000000000000000000000000002000000020000001c010000720600000000000000000000842500004a18000000000000000000000d00000004000000040000001c010000720600009e070000b004000078563412040000005e00000001000000010000000b000000000000000100000002000000030000000400000005000000060000000700000008000000090000000a00000004000000640062006f0000000b000000500072006f00760069006e00630069006100730000002143341208000000d00f0000680900007856341207000000140100004c006f00630061006c0069006400610064006500730000004c006900630065006e00630069006100730050006f0072005400650072006d0069006e0061006c00000008000000640062006f0000000002260028000000430061007400650067006f007200690061007300500072006f00700069006500640061006400000008000000640062006f000000000226001e0000005400690070006f007300500072006f00700069006500640061006400000008000000640062006f0000000002260022000000450073007400610064006f007300500072006f00700069006500640061006400000008000000640062000000f000000060ffffff0100000005000000540000002c0000002c0000002c000000340000000000000000000000b82b00004a180000010000002d0100000d0000000c000000070000001c0100007206000046050000d0020000840300007602000008070000460500002a03000046050000ae060000920400000000000001000000d00f00006809000000000000040000000400000002000000020000001c010000ae0600000000000001000000d00f0000ca02000000000000000000000000000002000000020000001c010000720600000100000000000000d00f0000ca02000000000000000000000000000002000000020000001c010000720600000000000000000000842500004a18000000000000000000000d00000004000000040000001c010000720600009e070000b004000078563412040000006000000001000000010000000b000000000000000100000002000000030000000400000005000000060000000700000008000000090000000a00000004000000640062006f0000000c0000004c006f00630061006c0069006400610064006500730000002143341208000000d00f000068090000785634120700000014010000420061007200720069006f0073000000000226002a0000004c006900630065006e00630069006100730050006f0072005400650072006d0069006e0061006c00000008000000640062006f0000000002260028000000430061007400650067006f007200690061007300500072006f00700069006500640061006400000008000000640062006f000000000226001e0000005400690070006f007300500072006f00700069006500640061006400000008000000640062006f0000000002260022000000450073007400610064006f007300500072006f00700069006500640061006400000008000000640062000000f000000060ffffff0100000005000000540000002c0000002c0000002c000000340000000000000000000000b82b00004a180000010000002d0100000d0000000c000000070000001c0100007206000046050000d0020000840300007602000008070000460500002a03000046050000ae060000920400000000000001000000d00f00006809000000000000040000000400000002000000020000001c010000af0500000000000001000000d00f0000ca02000000000000000000000000000002000000020000001c010000720600000100000000000000d00f0000ca02000000000000000000000000000002000000020000001c010000720600000000000000000000842500004a18000000000000000000000d00000004000000040000001c010000720600009e070000b004000078563412040000005800000001000000010000000b000000000000000100000002000000030000000400000005000000060000000700000008000000090000000a00000004000000640062006f00000008000000420061007200720069006f007300000021433412080000001e1300002a0800007856341207000000140100004d006f006e0065006400610073000000ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff52006f006f007400200045006e00740072007900000000000000000000000000000000000000000000000000000000000000000000000000000000000000000016000500ffffffffffffffffffffffff00000000f000000060ffffff0100000005000000540000002c0000002c0000002c000000340000000000000000000000b82b00004a180000010000002d0100000d0000000c000000070000001c0100007206000046050000d0020000840300007602000008070000460500002a03000046050000ae0600009204000000000000010000001e1300002a08000000000000030000000300000002000000020000001c0100008f0700000000000001000000d00f0000ca02000000000000000000000000000002000000020000001c010000720600000100000000000000d00f0000ca02000000000000000000000000000002000000020000001c010000720600000000000000000000842500004a18000000000000000000000d00000004000000040000001c010000720600009e070000b004000078563412040000005800000001000000010000000b000000000000000100000002000000030000000400000005000000060000000700000008000000090000000a00000004000000640062006f000000080000004d006f006e0065006400610073000000214334120800000003160000d00c00007856341207000000140100004d0065006400690064006100730041006d006200690065006e00740065007300500072006f007000690065006400610064000000dc02222161013a2053019d007e017801a000a100a200a300a400a500a600a700a800a900aa00ab00ac00ad00ae00af00b000b100b200b300b400b500b600b700b800b900ba00bb00bc00bd00be00bf00c000c100c200c300c400c500c600c700c800c900ca00cb00cc00cd00ce00cf00d000d100d200d300d400d500d600d700d800d900da00db00dc00dd00de00df00e000e100e200e300e400e500e600e700e800e900ea00eb00ec00ed00ee00ef00f000f100f200f300f4000000f000000060ffffff0100000005000000540000002c0000002c0000002c000000340000000000000000000000b82b00004a180000010000002d0100000d0000000c000000070000001c0100007206000046050000d0020000840300007602000008070000460500002a03000046050000ae06000092040000000000000100000003160000d00c000000000000060000000600000002000000020000001c010000330900000000000001000000d00f0000ca02000000000000000000000000000002000000020000001c010000720600000100000000000000d00f0000ca02000000000000000000000000000002000000020000001c010000720600000000000000000000842500004a18000000000000000000000d00000004000000040000001c010000720600009e070000b004000078563412040000007c00000001000000010000000b000000000000000100000002000000030000000400000005000000060000000700000008000000090000000a00000004000000640062006f0000001a0000004d0065006400690064006100730041006d006200690065006e00740065007300500072006f0070006900650064006100640000002143341208000000be1000002a0800007856341207000000140100005400690070006f007300440065005000690073006f000000ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff52006f006f007400200045006e00740072007900000000000000000000000000000000000000000000000000000000000000000000000000000000000000000016000500ffffffffffffffffffffffff00000000f000000060ffffff0100000005000000540000002c0000002c0000002c000000340000000000000000000000b82b00004a180000010000002d0100000d0000000c000000070000001c0100007206000046050000d0020000840300007602000008070000460500002a03000046050000ae060000920400000000000001000000be1000002a08000000000000020000000200000002000000020000001c010000350700000000000001000000d00f0000ca02000000000000000000000000000002000000020000001c010000720600000100000000000000d00f0000ca02000000000000000000000000000002000000020000001c010000720600000000000000000000842500004a18000000000000000000000d00000004000000040000001c010000720600009e070000b004000078563412040000006000000001000000010000000b000000000000000100000002000000030000000400000005000000060000000700000008000000090000000a00000004000000640062006f0000000c0000005400690070006f007300440065005000690073006f00000021433412080000004b12000095050000785634120700000014010000560065006e0074006100730000000000000226002a0000004c006900630065006e00630069006100730050006f0072005400650072006d0069006e0061006c00000008000000640062006f0000000002260028000000430061007400650067006f007200690061007300500072006f00700069006500640061006400000008000000640062006f000000000226001e0000005400690070006f007300500072006f00700069006500640061006400000008000000640062006f0000000002260022000000450073007400610064006f007300500072006f00700069006500640061006400000008000000640062000000f000000060ffffff0100000005000000540000002c0000002c0000002c000000340000000000000000000000b82b00004a180000010000002d0100000d0000000c000000070000001c0100007206000046050000d0020000840300007602000008070000460500002a03000046050000ae0600009204000000000000010000004b1200009505000000000000010000000100000002000000020000001c010000160800000000000001000000d00f0000ca02000000000000000000000000000002000000020000001c010000720600000100000000000000d00f0000ca02000000000000000000000000000002000000020000001c010000720600000000000000000000842500004a18000000000000000000000d00000004000000040000001c010000720600009e070000b004000078563412040000005600000001000000010000000b000000000000000100000002000000030000000400000005000000060000000700000008000000090000000a00000004000000640062006f00000007000000560065006e0074006100730000002143341208000000b60f0000930b000078563412070000001401000041006c007100750069006c006500720065007300000030206001392052018d007d018f009000182019201c201d20222013201420dc02222161013a2053019d007e017801a000a100a200a300a400a500a600a700a800a900aa00ab00ac00ad00ae00af00b000b100b200b300b400b500b600b700b800b900ba00bb00bc00bd00be00bf00c000c100c200c300c400c500c600c700c800c900ca00cb00cc00cd00ce00cf00d000d100d200d300d400d500d600d700d800d900da00db00dc00dd00de00df00e000e100e200e300e400e500e600e700e800e900ea00eb00ec00ed00ee00ef00f000f100f200f300f4000000f000000060ffffff0100000005000000540000002c0000002c0000002c000000340000000000000000000000b82b00004a180000010000002d0100000d0000000c000000070000001c0100007206000046050000d0020000840300007602000008070000460500002a03000046050000ae060000920400000000000001000000b60f0000930b000000000000010000000100000002000000020000001c0100009f0600000000000001000000d00f0000ca02000000000000000000000000000002000000020000001c010000720600000100000000000000d00f0000ca02000000000000000000000000000002000000020000001c010000720600000000000000000000842500004a18000000000000000000000d00000004000000040000001c010000720600009e070000b004000078563412040000005e00000001000000010000000b000000000000000100000002000000030000000400000005000000060000000700000008000000090000000a00000004000000640062006f0000000b00000041006c007100750069006c006500720065007300000021433412080000000d14000095770000785634120700000014010000500072006f00700069006500640061006400650073000000bd00be00bf00c000c100c200c300c400c500c600c700c800c900ca00cb00cc00cd00ce00cf00d000d100d200d300d400d500d600d700d800d900da00db00dc00dd00de00df00e000e100e200e300e400e500e600e700e800e900ea00eb00ec00ed00ee00ef00f000f100f200f300f400f500f600f700f800f900fa00fb00fc00fd00fe00ff007000b000b000b000b000b000b000b000b000b000b000b000b000b000b000b000b000b000b000b000b000b000b000b000b000b000b000b000b000b000b000b000b00030004000400080006000b00070000000f000000060ffffff0100000005000000540000002c0000002c0000002c000000340000000000000000000000c7360000873e0000010000002d0100000d0000000c000000070000001c0100003408000046050000d0020000840300007602000008070000460500002a03000046050000ae0600009204000000000000010000000d14000095770000000000002e0000000c00000002000000020000001c010000150900000000000001000000d00f0000ca02000000000000000000000000000002000000020000001c010000720600000100000000000000d00f0000ca02000000000000000000000000000002000000020000001c010000720600000000000000000000a82300007952000001000000000000000d00000004000000040000001c010000ac080000ec04000074040000785634120400000040000000010000000100000003000000000000000c0000000b00000004000000640062006f0000000c000000500072006f007000690065006400610064006500730000002143341208000000411700000d3c000078563412070000001401000043006c00690065006e00740065007300000030bb3404b34b2b050577dc163e7700000000010000000000000000000100fffffe7f030000000200000000000600060f0000ff3f0fa034db12000b67ad760b67ad76f4db1200f84487022c67ad76000000000010000000000100fffffe7f03000000020000004a02000000000000e800000060db12003f84e77900003000000000005e84e779fd6b2c40f4db1200010000000000000029abe77923abe7790000030098db1200ec9a317affffffff5e84e7791084e7790000300000000000e00000006d83e77998248e028a83e779396b2c40f4db1200010000000000000000000000000000000100000005000000540000002c0000002c0000002c000000340000000000000000000000a7290000dd230000000000002d0100000d0000000c000000070000001c010000f708000053070000d00200008403000076020000dd040000460500002a03000046050000ae060000920400000000000001000000411700000d3c000000000000160000000c00000002000000020000001c010000e60a00000000000001000000f2130000660f000000000000050000000500000002000000020000001c010000f70800000100000000000000f21300000804000000000000000000000000000002000000020000001c010000f7080000000000000000000055320000dd23000000000000000000000d00000004000000040000001c010000f70800009b0a00008106000078563412040000005a00000001000000010000000b000000000000000100000002000000030000000400000005000000060000000700000008000000090000000a00000004000000640062006f0000000900000043006c00690065006e00740065007300000000020000b40a000058010000020000000000ffffff000800008001000000150001000000900144420100065461686f6d61130046004b005f0043006c00690065006e007400650073005f00420061007200720069006f007300000200002e0d000058010000020000000000ffffff000800008001000000150001000000900144420100065461686f6d61170046004b005f0043006c00690065006e007400650073005f004c006f00630061006c00690064006100640065007300000200005d0a000058010000020000000000ffffff000800008001000000150001000000900144420100065461686f6d61120046004b005f0043006c00690065006e007400650073005f0050006100690073006500730000020000630c000058010000020000000000ffffff000800008001000000150001000000900144420100065461686f6d61160046004b005f0043006c00690065006e007400650073005f00500072006f00760069006e00630069006100730021433412080000007f150000f6070000785634120700000014010000500072006f0070006900650074006100720069006f0073000000720061006d002000460069006c00650073002f004d006900630072006f0073006f00660074002000560069007300750061006c002000530074007500640069006f00200038002f0043006f006d006d006f006e0037002f004900440045002f0065006e002f004d006900630072006f0073006f00660074002e00560069007300750061006c00530074007500640069006f002e00760073007000470072006900640043006f006e00740072006f006c002e007200650073006f00750072006300650073002f004d006900630072006f0073006f00000000000000000000000100000005000000540000002c0000002c0000002c000000340000000000000000000000a729000039160000000000002d010000070000000c000000070000001c010000f708000053070000d00200008403000076020000dd040000460500002a03000046050000ae0600009204000000000000010000007f150000f607000000000000010000000100000002000000020000001c010000e70900000000000001000000f21300004e06000000000000010000000100000002000000020000001c010000f70800000100000000000000f21300000804000000000000000000000000000002000000020000001c010000f7080000000000000000000055320000dd23000000000000000000000d00000004000000040000001c010000f70800009b0a00008106000078563412040000006200000001000000010000000b000000000000000100000002000000030000000400000005000000060000000700000008000000090000000a00000004000000640062006f0000000d000000500072006f0070006900650074006100720069006f007300000000020000680d000058010000020000000000ffffff000800008001000000150001000000900144420100065461686f6d61180046004b005f00500072006f0070006900650074006100720069006f0073005f0043006c00690065006e0074006500730000020000a10d000058010000020000000000ffffff000800008001000000150001000000900144420100065461686f6d61170046004b005f00500072006f00700069006500640061006400650073005f0043006c00690065006e007400650073002143341208000000201000008a0a000078563412070000001401000049006e007100750069006c0069006e006f0073000000730069006f006e003d0032002e0030002e0030002e0030002c002000430075006c0074007500720065003d006e00650075007400720061006c002c0020005000750062006c00690063004b006500790054006f006b0065006e003d0062003700370061003500630035003600310039003300340065003000380039000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000100000005000000540000002c0000002c0000002c000000340000000000000000000000ab17000027170000000000002d010000070000000c000000070000001c01000083040000b1030000d0020000840300007602000076020000460500002a03000046050000ae060000920400000000000001000000201000008a0a000000000000010000000100000002000000020000001c010000db0600000000000001000000670c00008306000000000000010000000100000002000000020000001c010000830400000100000000000000670c00002204000000000000000000000000000002000000020000001c010000830400000000000000000000021c00006a25000000000000000000000d00000004000000040000001c01000083040000550500004803000078563412040000005e00000001000000010000000b000000000000000100000002000000030000000400000005000000060000000700000008000000090000000a00000004000000640062006f0000000b00000049006e007100750069006c0069006e006f0073000000000200000d0c000058010000020000000000ffffff000800008001000000150001000000900144420100065461686f6d61160046004b005f0049006e007100750069006c0069006e006f0073005f0043006c00690065006e007400650073002143341208000000c71100003a100000785634120700000014010000470061006c00650072006900610046006f0074006f0073000000630404bd63040000003800000000040000000000000028bd630404000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000ffffffff020000000000000002000000010000000300000000000000b4e81200dadadada00000000040000005e84e779000000000000000000000000000000000000000098bd630498bd63040000000000000000ffffffff00000000000000000000000000000000bcbd6304bcbd630400000000c8bd6304c8bd630400000000000000000000000000000000000000000100000005000000540000002c0000002c0000002c000000340000000000000000000000ae2d00002b270000000000002d0100000d0000000c000000070000001c010000bc07000054060000d00200008403000076020000cc060000460500002a03000046050000ae060000920400000000000001000000c71100003a10000000000000050000000500000002000000020000001c010000cb0700000000000001000000c7110000ed03000000000000000000000000000002000000020000001c010000bc0700000100000000000000c7110000ed03000000000000000000000000000002000000020000001c010000bc0700000000000000000000072c0000de20000000000000000000000d00000004000000040000001c010000bc07000024090000a005000078563412040000006200000001000000010000000b000000000000000100000002000000030000000400000005000000060000000700000008000000090000000a00000004000000640062006f0000000d000000470061006c00650072006900610046006f0074006f0073000000000200001c10000058010000020000000000ffffff000800008001000000150001000000900144420100065461686f6d611b0046004b005f00470061006c00650072006900610046006f0074006f0073005f00500072006f00700069006500640061006400650073000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000fefffffffeffffff0400000005000000060000000700000008000000090000000a0000000b0000000c0000000d0000000e0000000f00000010000000110000001200000013000000140000001500000016000000170000001800000019000000fefffffffeffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff0100feff030a0000ffffffff00000000000000000000000000000000170000004d6963726f736f66742044445320466f726d20322e300010000000456d626564646564204f626a6563740000000000f439b2710000000000000000000000000030002c0031003600350030002c00310032002c0031003900350030002c003100010003000000000000000c0000000b0000004e61bc0000000000000000000000000000000000d002000006002800000041006300740069007600650054006100dbe6b0e91c81d011ad5100a0c90f573900000200c0cf01fc4daac8010202000010484500000000000000000000000000000000009e0100004400610074006100200053006f0075007200630065003d0045004d0049004c0049004f004d004f00560049004c00480050005c00530051004c0045005800500052004500530053003b0049006e0069007400690061006c00200043006100740061006c006f0067003d0049006e006d006f00620069006c0069006100720069006100440062003b0049006e00740065006700720061007400650064002000530065006300750072006900740079003d0054007200750065003b004d0075006c007400690070006c00650041006300740069007600650052006500730075006c00740053006500740073003d00460061006c00730065003b005000610063006b0065007400200053000300440064007300530074007200650061006d000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000160002000300000006000000ffffffff00000000000000000000000000000000000000000000000000000000000000000000000032000000523400000000000053006300680065006d00610020005500440056002000440065006600610075006c0074000000000000000000000000000000000000000000000000000000000026000200ffffffffffffffffffffffff000000000000000000000000000000000000000000000000000000000000000000000000020000001600000000000000440053005200450046002d0053004300480045004d0041002d0043004f004e00540045004e0054005300000000000000000000000000000000000000000000002c0002010500000007000000ffffffff00000000000000000000000000000000000000000000000000000000000000000000000003000000920500000000000053006300680065006d00610020005500440056002000440065006600610075006c007400200050006f007300740020005600360000000000000000000000000036000200ffffffffffffffffffffffff0000000000000000000000000000000000000000000000000000000000000000000000001a00000012000000000000000c000000dfcdffff023500000100260000007300630068005f006c006100620065006c0073005f00760069007300690062006c0065000000010000000b00000006000000000000000000000000000000000000006400000000000000000000000000000000000000000000000000010000000100000000000000000000000000000000000000d00200000600280000004100630074006900760065005400610062006c00650056006900650077004d006f006400650000000100000008000400000031000000200000005400610062006c00650056006900650077004d006f00640065003a00300000000100000008003a00000034002c0030002c003200380034002c0030002c0031003600350030002c0031002c0031003300350030002c0035002c0031003800300030000000200000005400610062006c00650056006900650077004d006f00640065003a00310000000100000008001e00000032002c0030002c003200380034002c0030002c0031003200360030000000200000005400610062006c00650056006900650077004d006f00640065003a00320000000100000008001e00000032002c0030002c003200380034002c0030002c0031003600350030000000200000005400610062006c00650056006900650077004d006f00640065003a00330000000100000008001e00000032002c0030002c003200380034002c0030002c0031003600350030000000200000005400610062006c00650056006900650077004d006f00640065003a00340000000100000008003e00000034002c0030002c003200380034002c0030002c0031003600350030002c00310032002c0031003900350030002c00310031002c0031003200300030000000020000000200000000000000000000000000000000000000d00200000600280000004100630074006900760065005400610062006c00650056006900650077004d006f006400650000000100000008000400000031000000200000005400610062006c00650056006900650077004d006f00640065003a00300000000100000008003a00000034002c0030002c003200380034002c0030002c0031003600350030002c0031002c0031003300350030002c0035002c0031003800300030000000200000005400610062006c00650056006900650077004d006f00640065003a00310000000100000008001e00000032002c0030002c003200380034002c0030002c0032003100340035000000200000005400610062006c00650056006900650077004d006f00640065003a00320000000100000008001e00000032002c0030002c003200380034002c0030002c0031003600350030000000200000005400610062006c00650056006900650077004d006f00640065003a00330000000100000008001e00000032002c0030002c003200380034002c0030002c0031003600350030000000200000005400610062006c00650056006900650077004d006f00640065003a00340000000100000008003e00000034002c0030002c003200380034002c0030002c0031003600350030002c00310032002c0031003900350030002c00310031002c0031003200300030000000030000000300000000000000000000000000000000000000d00200000600280000004100630074006900760065005400610062006c00650056006900650077004d006f006400650000000100000008000400000031000000200000005400610062006c00650056006900650077004d006f00640065003a00300000000100000008003a00000034002c0030002c003200380034002c0030002c0031003600350030002c0031002c0031003300350030002c0035002c0031003800300030000000200000005400610062006c00650056006900650077004d006f00640065003a00310000000100000008001e00000032002c0030002c003200380034002c0030002c0032003400310035000000200000005400610062006c00650056006900650077004d006f00640065003a00320000000100000008001e00000032002c0030002c003200380034002c0030002c0031003600350030000000200000005400610062006c00650056006900650077004d006f00640065003a00330000000100000008001e00000032002c0030002c003200380034002c0030002c0031003600350030000000200000005400610062006c00650056006900650077004d006f00640065003a00340000000100000008003e00000034002c0030002c003200380034002c0030002c0031003600350030002c00310032002c0031003900350030002c00310031002c00310032003000300000000600000006000000000000005c00000001002d0001000000640062006f00000046004b005f005400690070006f007300500072006f007000690065006400610064005f00430061007400650067006f007200690061007300500072006f0070006900650064006100640000000200000000000000c00200000000070000000700000006000000080000000129b905a075bb050000000000000000a5070000000000080000000800000000000000000000000000000000000000d00200000600280000004100630074006900760065005400610062006c00650056006900650077004d006f006400650000000100000008000400000031000000200000005400610062006c00650056006900650077004d006f00640065003a00300000000100000008003a00000034002c0030002c003200380034002c0030002c0031003600350030002c0031002c0031003300350030002c0035002c0031003800300030000000200000005400610062006c00650056006900650077004d006f00640065003a00310000000100000008001e00000032002c0030002c003200380034002c0030002c0032003600350035000000200000005400610062006c00650056006900650077004d006f00640065003a00320000000100000008001e00000032002c0030002c003200380034002c0030002c0031003600350030000000200000005400610062006c00650056006900650077004d006f00640065003a00330000000100000008001e00000032002c0030002c003200380034002c0030002c0031003600350030000000200000005400610062006c00650056006900650077004d006f00640065003a00340000000100000008003e00000034002c0030002c003200380034002c0030002c0031003600350030002c00310032002c0031003900350030002c00310031002c0031003200300030000000090000000900000000000000000000000000000000000000d00200000600280000004100630074006900760065005400610062006c00650056006900650077004d006f006400650000000100000008000400000031000000200000005400610062006c00650056006900650077004d006f00640065003a00300000000100000008003a00000034002c0030002c003200380034002c0030002c0031003600350030002c0031002c0031003300350030002c0035002c0031003800300030000000200000005400610062006c00650056006900650077004d006f00640065003a00310000000100000008001e00000032002c0030002c003200380034002c0030002c0031003900330035000000200000005400610062006c00650056006900650077004d006f00640065003a00320000000100000008001e00000032002c0030002c003200380034002c0030002c0031003600350030000000200000005400610062006c00650056006900650077004d006f00640065003a00330000000100000008001e00000032002c0030002c003200380034002c0030002c0031003600350030000000200000005400610062006c00650056006900650077004d006f00640065003a00340000000100000008003e00000034002c0030002c003200380034002c0030002c0031003600350030002c00310032002c0031003900350030002c00310031002c00310032003000300000000a0000000a00000000000000000000000000000000000000d00200000600280000004100630074006900760065005400610062006c00650056006900650077004d006f006400650000000100000008000400000031000000200000005400610062006c00650056006900650077004d006f00640065003a00300000000100000008003a00000034002c0030002c003200380034002c0030002c0031003600350030002c0031002c0031003300350030002c0035002c0031003800300030000000200000005400610062006c00650056006900650077004d006f00640065003a00310000000100000008001e00000032002c0030002c003200380034002c0030002c0031003800340035000000200000005400610062006c00650056006900650077004d006f00640065003a00320000000100000008001e00000032002c0030002c003200380034002c0030002c0031003600350030000000200000005400610062006c00650056006900650077004d006f00640065003a00330000000100000008001e00000032002c0030002c003200380034002c0030002c0031003600350030000000200000005400610062006c00650056006900650077004d006f00640065003a00340000000100000008003e00000034002c0030002c003200380034002c0030002c0031003600350030002c00310032002c0031003900350030002c00310031002c00310032003000300000000b0000000b00000000000000000000000000000000000000d00200000600280000004100630074006900760065005400610062006c00650056006900650077004d006f006400650000000100000008000400000031000000200000005400610062006c00650056006900650077004d006f00640065003a00300000000100000008003a00000034002c0030002c003200380034002c0030002c0031003600350030002c0031002c0031003300350030002c0035002c0031003800300030000000200000005400610062006c00650056006900650077004d006f00640065003a00310000000100000008001e00000032002c0030002c003200380034002c0030002c0032003300310030000000200000005400610062006c00650056006900650077004d006f00640065003a00320000000100000008001e00000032002c0030002c003200380034002c0030002c0031003600350030000000200000005400610062006c00650056006900650077004d006f00640065003a00330000000100000008001e00000032002c0030002c003200380034002c0030002c0031003600350030000000200000005400610062006c00650056006900650077004d006f00640065003a00340000000100000008003e00000034002c0030002c003200380034002c0030002c0031003600350030002c00310032002c0031003900350030002c00310031002c00310032003000300000000c0000000c00000000000000000000000000000000000000d00200000600280000004100630074006900760065005400610062006c00650056006900650077004d006f006400650000000100000008000400000031000000200000005400610062006c00650056006900650077004d006f00640065003a00300000000100000008003a00000034002c0030002c003200380034002c0030002c0031003600350030002c0031002c0031003300350030002c0035002c0031003800300030000000200000005400610062006c00650056006900650077004d006f00640065003a00310000000100000008001e00000032002c0030002c003200380034002c0030002c0031003400350035000000200000005400610062006c00650056006900650077004d006f00640065003a00320000000100000008001e00000032002c0030002c003200380034002c0030002c0031003600350030000000200000005400610062006c00650056006900650077004d006f00640065003a00330000000100000008001e00000032002c0030002c003200380034002c0030002c0031003600350030000000200000005400610062006c00650056006900650077004d006f00640065003a00340000000100000008003e00000034002c0030002c003200380034002c0030002c0031003600350030002c00310032002c0031003900350030002c00310031002c00310032003000300000000d0000000d000000000000003a0000000102000001000000640062006f00000046004b005f00500072006f00760069006e0063006900610073005f0050006100690073006500730000000200000000000000c002000000000e0000000e0000000d000000080000000129b90530d5b8050000000000000000a50700000000000f0000000f00000000000000000000000000000000000000d00200000600280000004100630074006900760065005400610062006c00650056006900650077004d006f006400650000000100000008000400000031000000200000005400610062006c00650056006900650077004d006f00640065003a00300000000100000008003a00000034002c0030002c003200380034002c0030002c0031003600350030002c0031002c0031003300350030002c0035002c0031003800300030000000200000005400610062006c00650056006900650077004d006f00640065003a00310000000100000008001e00000032002c0030002c003200380034002c0030002c0031003700310030000000200000005400610062006c00650056006900650077004d006f00640065003a00320000000100000008001e00000032002c0030002c003200380034002c0030002c0031003600350030000000200000005400610062006c00650056006900650077004d006f00640065003a00330000000100000008001e00000032002c0030002c003200380034002c0030002c0031003600350030000000200000005400610062006c00650056006900650077004d006f00640065003a00340000000100000008003e00000034002c0030002c003200380034002c0030002c0031003600350030002c00310032002c0031003900350030002c00310031002c0031003200300030000000100000001000000000000000440000000101cf7501000000640062006f00000046004b005f004c006f00630061006c006900640061006400650073005f00500072006f00760069006e00630069006100730000000200000000000000c00200000000110000001100000010000000080000000129b905f0d4b8050000000000000000a5070000000000120000001200000000000000000000000000000000000000d00200000600280000004100630074006900760065005400610062006c00650056006900650077004d006f006400650000000100000008000400000031000000200000005400610062006c00650056006900650077004d006f00640065003a00300000000100000008003a00000034002c0030002c003200380034002c0030002c0031003600350030002c0031002c0031003300350030002c0035002c0031003800300030000000200000005400610062006c00650056006900650077004d006f00640065003a00310000000100000008001e00000032002c0030002c003200380034002c0030002c0031003400350035000000200000005400610062006c00650056006900650077004d006f00640065003a00320000000100000008001e00000032002c0030002c003200380034002c0030002c0031003600350030000000200000005400610062006c00650056006900650077004d006f00640065003a00330000000100000008001e00000032002c0030002c003200380034002c0030002c0031003600350030000000200000005400610062006c00650056006900650077004d006f00640065003a00340000000100000008003e00000034002c0030002c003200380034002c0030002c0031003600350030002c00310032002c0031003900350030002c00310031002c00310032003000300000001300000013000000000000003e0000000102000001000000640062006f00000046004b005f00420061007200720069006f0073005f004c006f00630061006c0069006400610064006500730000000200000000000000c00200000000140000001400000013000000080000000129b905b0d4b8050000000000000000a5070000000000150000001500000000000000000000000000000000000000d00200000600280000004100630074006900760065005400610062006c00650056006900650077004d006f006400650000000100000008000400000031000000200000005400610062006c00650056006900650077004d006f00640065003a00300000000100000008003a00000034002c0030002c003200380034002c0030002c0032003100300030002c0031002c0031003300350030002c0035002c0031003800300030000000200000005400610062006c00650056006900650077004d006f00640065003a00310000000100000008001e00000032002c0030002c003200380034002c0030002c0032003300320035000000200000005400610062006c00650056006900650077004d006f00640065003a00320000000100000008001e00000032002c0030002c003200380034002c0030002c0031003600350030000000200000005400610062006c00650056006900650077004d006f00640065003a00330000000100000008001e00000032002c0030002c003200380034002c0030002c0031003600350030000000200000005400610062006c00650056006900650077004d006f00640065003a00340000000100000008003e00000034002c0030002c003200380034002c0030002c0032003200320030002c00310032002c0031003200360030002c00310031002c00310031003400300000001600000016000000000000004c0000000101bf0901000000640062006f00000046004b005f00500072006f00700069006500640061006400650073005f005400690070006f007300500072006f0070006900650064006100640000000200000000000000c00200000000170000001700000016000000080000000129b90570d4b8050000000000000000a50700000000001800000018000000000000005000000001ff635901000000640062006f00000046004b005f00500072006f00700069006500640061006400650073005f00450073007400610064006f007300500072006f0070006900650064006100640000000200000000000000c00200000000190000001900000018000000080000000129b90530d4b8050000000000000000a50700000000001a0000001a000000000000003c0000000101000001000000640062006f00000046004b005f00500072006f00700069006500640061006400650073005f0050006100690073006500730000000200000000000000c002000000001b0000001b0000001a000000080000000129b905f0d3b8050000000000000000a50700000000001c0000001c00000000000000440000000101cf7501000000640062006f00000046004b005f00500072006f00700069006500640061006400650073005f00500072006f00760069006e00630069006100730000000200000000000000c002000000001d0000001d0000001c000000080000000129b905b0d3b8050000000000000000a50700000000001e0000001e00000000000000460000000101cf7501000000640062006f00000046004b005f00500072006f00700069006500640061006400650073005f004c006f00630061006c0069006400610064006500730000000200000000000000c002000000001f0000001f0000001e000000080000000129b90570d3b8050000000000000000a50700000000002000000020000000000000003e0000000102000001000000640062006f00000046004b005f00500072006f00700069006500640061006400650073005f00420061007200720069006f00730000000200000000000000c00200000000210000002100000020000000080000000129b90530d3b8050000000000000000a50700000000002200000022000000000000003e0000000101000001000000640062006f00000046004b005f00500072006f00700069006500640061006400650073005f004d006f006e00650064006100730000000200000000000000c00200000000230000002300000022000000080000000129b905f0d2b8050000000000000000a5070000000000240000002400000000000000400000000102000001000000640062006f00000046004b005f00500072006f00700069006500640061006400650073005f004d006f006e006500640061007300310000000200000000000000c00200000000250000002500000024000000080000000129b905b0d2b8050000000000000000a5070000000000270000002700000000000000000000000000000000000000d00200000600280000004100630074006900760065005400610062006c00650056006900650077004d006f006400650000000100000008000400000031000000200000005400610062006c00650056006900650077004d006f00640065003a00300000000100000008003a00000034002c0030002c003200380034002c0030002c0031003600350030002c0031002c0031003300350030002c0035002c0031003800300030000000200000005400610062006c00650056006900650077004d006f00640065003a00310000000100000008001e00000032002c0030002c003200380034002c0030002c0032003300350035000000200000005400610062006c00650056006900650077004d006f00640065003a00320000000100000008001e00000032002c0030002c003200380034002c0030002c0031003600350030000000200000005400610062006c00650056006900650077004d006f00640065003a00330000000100000008001e00000032002c0030002c003200380034002c0030002c0031003600350030000000200000005400610062006c00650056006900650077004d006f00640065003a00340000000100000008003e00000034002c0030002c003200380034002c0030002c0031003600350030002c00310032002c0031003900350030002c00310031002c0031003200300030000000280000002800000000000000620000000101000001000000640062006f00000046004b005f004d0065006400690064006100730041006d006200690065006e00740065007300500072006f007000690065006400610064005f00500072006f007000690065006400610064006500730000000200000000000000c00200000000290000002900000028000000080000000129b90570d2b8050000000000000000a50700000000002a0000002a00000000000000620000000101000001000000640062006f00000046004b005f004d0065006400690064006100730041006d006200690065006e00740065007300500072006f007000690065006400610064005f005400690070006f007300440065005000690073006f0000000200000000000000c002000000002b0000002b0000002a000000080000000129b90530d2b8050000000000000000a50700000000002d0000002d00000000000000000000000000000000000000d00200000600280000004100630074006900760065005400610062006c00650056006900650077004d006f006400650000000100000008000400000031000000200000005400610062006c00650056006900650077004d006f00640065003a00300000000100000008003a00000034002c0030002c003200380034002c0030002c0031003600350030002c0031002c0031003300350030002c0035002c0031003800300030000000200000005400610062006c00650056006900650077004d006f00640065003a00310000000100000008001e00000032002c0030002c003200380034002c0030002c0032003000370030000000200000005400610062006c00650056006900650077004d006f00640065003a00320000000100000008001e00000032002c0030002c003200380034002c0030002c0031003600350030000000200000005400610062006c00650056006900650077004d006f00640065003a00330000000100000008001e00000032002c0030002c003200380034002c0030002c0031003600350030000000200000005400610062006c00650056006900650077004d006f00640065003a00340000000100000008003e00000034002c0030002c003200380034002c0030002c0031003600350030002c00310032002c0031003900350030002c00310031002c00310032003000300000002e0000002e00000000000000000000000000000000000000d00200000600280000004100630074006900760065005400610062006c00650056006900650077004d006f006400650000000100000008000400000031000000200000005400610062006c00650056006900650077004d006f00640065003a00300000000100000008003a00000034002c0030002c003200380034002c0030002c0031003600350030002c0031002c0031003300350030002c0035002c0031003800300030000000200000005400610062006c00650056006900650077004d006f00640065003a00310000000100000008001e00000032002c0030002c003200380034002c0030002c0031003600390035000000200000005400610062006c00650056006900650077004d006f00640065003a00320000000100000008001e00000032002c0030002c003200380034002c0030002c0031003600350030000000200000005400610062006c00650056006900650077004d006f00640065003a00330000000100000008001e00000032002c0030002c003200380034002c0030002c0031003600350030000000200000005400610062006c00650056006900650077004d006f00640065003a00340000000100000008003e00000034002c0030002c003200380034002c0030002c0031003600350030002c00310032002c0031003900350030002c00310031002c00310032003000300000002f0000002f000000000000003c0000000102000001000000640062006f00000046004b005f00560065006e007400610073005f00500072006f007000690065006400610064006500730000000200000002000000c0020000000030000000300000002f000000080000000129b905f0d1b8050000000000000000a5070000000000310000003100000000000000440000000101cf7501000000640062006f00000046004b005f0041006c007100750069006c0065007200650073005f00500072006f007000690065006400610064006500730000000200000002000000c00200000000320000003200000031000000080000000129b9054890b8050000000000000000a5070000000000330000003300000000000000000000000000000000000000d00200000600280000004100630074006900760065005400610062006c00650056006900650077004d006f006400650000000100000008000400000031000000200000005400610062006c00650056006900650077004d006f00640065003a00300000000100000008003a00000034002c0030002c003200380034002c0030002c0032003200390035002c0031002c0031003800370035002c0035002c0031003200340035000000200000005400610062006c00650056006900650077004d006f00640065003a00310000000100000008001e00000032002c0030002c003200380034002c0030002c0032003700390030000000200000005400610062006c00650056006900650077004d006f00640065003a00320000000100000008001e00000032002c0030002c003200380034002c0030002c0032003200390035000000200000005400610062006c00650056006900650077004d006f00640065003a00330000000100000008001e00000032002c0030002c003200380034002c0030002c0032003200390035000000200000005400610062006c00650056006900650077004d006f00640065003a00340000000100000008003e00000034002c0030002c003200380034002c0030002c0032003200390035002c00310032002c0032003700310035002c00310031002c0031003600360035000000340000003400000000000000380000000100a80901000000640062006f00000046004b005f0043006c00690065006e007400650073005f00420061007200720069006f00730000000000000000000000c40200000000350000003500000034000000080000000129b905b0d1b8050000000000000000ad070000000000360000003600000000000000400000000102000001000000640062006f00000046004b005f0043006c00690065006e007400650073005f004c006f00630061006c0069006400610064006500730000000000000000000000c40200000000370000003700000036000000080000000129b9058890b8050000000000000000ad070000000000380000003800000000000000360000000100a80901000000640062006f00000046004b005f0043006c00690065006e007400650073005f0050006100690073006500730000000000000000000000c40200000000390000003900000038000000080000000129b90570d1b8050000000000000000ad0700000000003a0000003a000000000000003e0000000102000001000000640062006f00000046004b005f0043006c00690065006e007400650073005f00500072006f00760069006e00630069006100730000000000000000000000c402000000003b0000003b0000003a000000080000000129b90530d1b8050000000000000000ad0700000000003c0000003c00000000000000000000000000000000000000d00200000600280000004100630074006900760065005400610062006c00650056006900650077004d006f006400650000000100000008000400000031000000200000005400610062006c00650056006900650077004d006f00640065003a00300000000100000008003a00000034002c0030002c003200380034002c0030002c0032003200390035002c0031002c0031003800370035002c0035002c0031003200340035000000200000005400610062006c00650056006900650077004d006f00640065003a00310000000100000008001e00000032002c0030002c003200380034002c0030002c0032003500330035000000200000005400610062006c00650056006900650077004d006f00640065003a00320000000100000008001e00000032002c0030002c003200380034002c0030002c0032003200390035000000200000005400610062006c00650056006900650077004d006f00640065003a00330000000100000008001e00000032002c0030002c003200380034002c0030002c0032003200390035000000200000005400610062006c00650056006900650077004d006f00640065003a00340000000100000008003e00000034002c0030002c003200380034002c0030002c0032003200390035002c00310032002c0032003700310035002c00310031002c00310036003600350000003d0000003d00000000000000420000000100cf7501000000640062006f00000046004b005f00500072006f0070006900650074006100720069006f0073005f0043006c00690065006e0074006500730000000000000000000000c402000000003e0000003e0000003d000000080000000129b905f0d0b8050000000000000000ad0700000000003f0000003f00000000000000400000000101000001000000640062006f00000046004b005f00500072006f00700069006500640061006400650073005f0043006c00690065006e0074006500730000000000000000000000c4020000000040000000400000003f000000080000000129b905b0d0b8050000000000000000ad070000000000410000004100000000000000000000000000000000000000d00200000600280000004100630074006900760065005400610062006c00650056006900650077004d006f006400650000000100000008000400000031000000200000005400610062006c00650056006900650077004d006f00640065003a00300000000100000008003600000034002c0030002c003200380034002c0030002c0031003100350035002c0031002c003900340035002c0035002c003600330030000000200000005400610062006c00650056006900650077004d006f00640065003a00310000000100000008001e00000032002c0030002c003200380034002c0030002c0031003700350035000000200000005400610062006c00650056006900650077004d006f00640065003a00320000000100000008001e00000032002c0030002c003200380034002c0030002c0031003100350035000000200000005400610062006c00650056006900650077004d006f00640065003a00330000000100000008001e00000032002c0030002c003200380034002c0030002c0031003100350035000000200000005400610062006c00650056006900650077004d006f00640065003a00340000000100000008003c00000034002c0030002c003200380034002c0030002c0031003100350035002c00310032002c0031003300360035002c00310031002c0038003400300000004200000042000000000000003e0000000102000001000000640062006f00000046004b005f0049006e007100750069006c0069006e006f0073005f0043006c00690065006e0074006500730000000000000000000000c40200000000430000004300000042000000080000000127b90570d0b8050000000000000000ad070000000000440000004400000000000000000000000000000000000000d00200000600280000004100630074006900760065005400610062006c00650056006900650077004d006f006400650000000100000008000400000031000000200000005400610062006c00650056006900650077004d006f00640065003a00300000000100000008003a00000034002c0030002c003200380034002c0030002c0031003900380030002c0031002c0031003600320030002c0035002c0031003700340030000000200000005400610062006c00650056006900650077004d006f00640065003a00310000000100000008001e00000032002c0030002c003200380034002c0030002c0031003900390035000000200000005400610062006c00650056006900650077004d006f00640065003a00320000000100000008001e00000032002c0030002c003200380034002c0030002c0031003900380030000000200000005400610062006c00650056006900650077004d006f00640065003a00330000000100000008001e00000032002c0030002c003200380034002c0030002c0031003900380030000000200000005400610062006c00650056006900650077004d006f00640065003a00340000000100000008003e00000034002c0030002c003200380034002c0030002c0031003900380030002c00310032002c0032003300340030002c00310031002c0031003400340030000000450000004500000000000000480000000100cf7501000000640062006f00000046004b005f00470061006c00650072006900610046006f0074006f0073005f00500072006f007000690065006400610064006500730000000000000000000000c4020000000046000000460000004500000008000000013aab09283ba7090000000000000000ad0f0000010000780000000600000002000000030000004e00000057000000160000000300000015000000230000001c0000001800000008000000150000005d0000001a0100002200000009000000150000001a0000001b00000024000000090000001500000020000000210000002a0000000a000000270000001b000000240000000d0000000b0000000c000000540000003f0000001a0000000b000000150000005500000008010000380000000b000000330000002000000031000000100000000c0000000f00000042000000430000001c0000000c00000015000000450000000e0100003a0000000c00000033000000180000002b000000130000000f000000120000003d000000420000001e0000000f000000150000004900000014010000360000000f00000033000000180000001f00000020000000120000001500000043000000020100003400000012000000330000001800000025000000450000001500000044000000270000001c000000280000001500000027000000090100005c0000002f000000150000002d000000220000001f00000031000000150000002e0000000f01000046000000420000003300000041000000190000001a0000003d000000330000003c00000026000000230000003f0000003300000015000000b1000000fc00000000000000000000000000000000000000000000000000000000000000000000000000b3000000920444648b4cd1118b70080036b11a03240000001400000000000000a10202000000000000000000000000000000000000000000ffffffff500072006f0064007500630074006f00720065007300000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000b4000000920444648b4cd1118b70080036b11a03160000001400000000000000a10202000000000000000000000000000000000000000000ffffffff45006400690074006f007200000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000069007a0065003d0034003000390036003b004100700070006c00690063006100740069006f006e0020004e0061006d0065003d0022004d006900630072006f0073006f00660074002000530051004c00200053006500720076006500720020004d0061006e006100670065006d0065006e0074002000530074007500640069006f00200045007800700072006500730073002200000000800500120000004400690061006700720061006d0061000000000226001600000049006e007100750069006c0069006e006f007300000008000000640062006f000000000226001a000000500072006f0070006900650074006100720069006f007300000008000000640062006f000000000226001200000043006c00690065006e00740065007300000008000000640062006f000000000226001600000041006c007100750069006c006500720065007300000008000000640062006f000000000226000e000000560065006e00740061007300000008000000640062006f00000000022600340000004d0065006400690064006100730041006d006200690065006e00740065007300500072006f00700069006500640061006400000008000000640062006f0000000002260018000000500072006f0070006900650064006100640065007300000008000000640062006f0000000002260010000000420061007200720069006f007300000008000000640062006f00000000022600180000004c006f00630061006c00690064006100640065007300000008000000640062006f0000000002260016000000500072006f00760069006e006300690061007300000008000000640062006f000000000226000e000000500061006900730065007300000008000000640062006f00000000022600180000005400690070006f007300440065005000690073006f00000008000000640062006f00000000022600100000004d006f006e006500640061007300000008000000640062006f0000000002260022000000450073007400610064006f007300500072006f00700069006500640061006400000008000000640062006f000000000226001e0000005400690070006f007300500072006f00700069006500640061006400000008000000640062006f0000000002260028000000430061007400650067006f007200690061007300500072006f00700069006500640061006400000008000000640062006f000000000226002a0000004c006900630065006e00630069006100730050006f0072005400650072006d0069006e0061006c00000008000000640062006f000000000224001a000000470061006c00650072006900610046006f0074006f007300000008000000640062006f00000001000000d68509b3bb6bf2459ab8371664f0327008004e0000007b00390031003500310030003600300038002d0038003800300039002d0034003000320030002d0038003800390037002d004600420041003000350037004500320032004400350034007d0000000000000000000000000000000000000000000000000000000000000000000000000000000000ba0000004c58e0e3010003000000000000000c0000000b000000000000000000a10202000000000000000000000000000000000000000000ffffffff4e006f006d0062007200650073002000430043004f00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000bb0000004c58e0e388b75a4abb207f5a44c9acdd030000001400000000000000a10202000000000000000000000000000000000000000000ffffffff44006900720065006300630069006f006e006500730020004300430000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000062885214 )
go
SET IDENTITY_INSERT [dbo].[sysdiagrams] OFF
go
SET IDENTITY_INSERT [dbo].[Tasaciones] ON
go
--The following columns were excluded due to unsupported datatypes: [Comentarios]
INSERT INTO [dbo].[Tasaciones] ( [IdTasacion], [IdPropiedad], [Fecha], [ImporteValorReal], [ImporteValorPublicacion], [IdMonedaValorReal], [IdMonedaValorPublicacion] ) VALUES(  1, 81, '2007-01-24 09:59:14.0', 64000.00, 67000.00, 2, 2 )
go
--The following columns were excluded due to unsupported datatypes: [Comentarios]
INSERT INTO [dbo].[Tasaciones] ( [IdTasacion], [IdPropiedad], [Fecha], [ImporteValorReal], [ImporteValorPublicacion], [IdMonedaValorReal], [IdMonedaValorPublicacion] ) VALUES(  2, 82, '2006-10-01 10:10:09.0', 90000.00, 90000.00, 2, 2 )
go
--The following columns were excluded due to unsupported datatypes: [Comentarios]
INSERT INTO [dbo].[Tasaciones] ( [IdTasacion], [IdPropiedad], [Fecha], [ImporteValorReal], [ImporteValorPublicacion], [IdMonedaValorReal], [IdMonedaValorPublicacion] ) VALUES(  3, 82, '2007-12-01 10:12:42.0', 0.00, 120000.00, 2, 2 )
go
--The following columns were excluded due to unsupported datatypes: [Comentarios]
INSERT INTO [dbo].[Tasaciones] ( [IdTasacion], [IdPropiedad], [Fecha], [ImporteValorReal], [ImporteValorPublicacion], [IdMonedaValorReal], [IdMonedaValorPublicacion] ) VALUES(  4, 81, '2007-07-02 10:22:07.0', 62000.00, 64000.00, 2, 2 )
go
--The following columns were excluded due to unsupported datatypes: [Comentarios]
INSERT INTO [dbo].[Tasaciones] ( [IdTasacion], [IdPropiedad], [Fecha], [ImporteValorReal], [ImporteValorPublicacion], [IdMonedaValorReal], [IdMonedaValorPublicacion] ) VALUES(  5, 79, '2007-05-24 10:37:36.0', 1500.00, 1600.00, 1, 1 )
go
--The following columns were excluded due to unsupported datatypes: [Comentarios]
INSERT INTO [dbo].[Tasaciones] ( [IdTasacion], [IdPropiedad], [Fecha], [ImporteValorReal], [ImporteValorPublicacion], [IdMonedaValorReal], [IdMonedaValorPublicacion] ) VALUES(  6, 53, '2006-06-28 11:05:12.0', 148000.00, 152000.00, 2, 2 )
go
--The following columns were excluded due to unsupported datatypes: [Comentarios]
INSERT INTO [dbo].[Tasaciones] ( [IdTasacion], [IdPropiedad], [Fecha], [ImporteValorReal], [ImporteValorPublicacion], [IdMonedaValorReal], [IdMonedaValorPublicacion] ) VALUES(  7, 70, '2007-05-22 11:27:15.0', 49000.00, 52000.00, 2, 2 )
go
--The following columns were excluded due to unsupported datatypes: [Comentarios]
INSERT INTO [dbo].[Tasaciones] ( [IdTasacion], [IdPropiedad], [Fecha], [ImporteValorReal], [ImporteValorPublicacion], [IdMonedaValorReal], [IdMonedaValorPublicacion] ) VALUES(  8, 73, '2007-06-16 11:30:39.0', 195000.00, 220000.00, 2, 2 )
go
--The following columns were excluded due to unsupported datatypes: [Comentarios]
INSERT INTO [dbo].[Tasaciones] ( [IdTasacion], [IdPropiedad], [Fecha], [ImporteValorReal], [ImporteValorPublicacion], [IdMonedaValorReal], [IdMonedaValorPublicacion] ) VALUES(  9, 35, '2007-07-07 11:34:51.0', 138000.00, 132000.00, 2, 2 )
go
--The following columns were excluded due to unsupported datatypes: [Comentarios]
INSERT INTO [dbo].[Tasaciones] ( [IdTasacion], [IdPropiedad], [Fecha], [ImporteValorReal], [ImporteValorPublicacion], [IdMonedaValorReal], [IdMonedaValorPublicacion] ) VALUES(  10, 74, '2007-07-14 11:37:55.0', 52000.00, 55000.00, 2, 2 )
go
--The following columns were excluded due to unsupported datatypes: [Comentarios]
INSERT INTO [dbo].[Tasaciones] ( [IdTasacion], [IdPropiedad], [Fecha], [ImporteValorReal], [ImporteValorPublicacion], [IdMonedaValorReal], [IdMonedaValorPublicacion] ) VALUES(  11, 42, '2007-08-29 11:46:31.0', 92000.00, 99000.00, 2, 2 )
go
--The following columns were excluded due to unsupported datatypes: [Comentarios]
INSERT INTO [dbo].[Tasaciones] ( [IdTasacion], [IdPropiedad], [Fecha], [ImporteValorReal], [ImporteValorPublicacion], [IdMonedaValorReal], [IdMonedaValorPublicacion] ) VALUES(  12, 43, '2007-12-15 16:31:09.0', 92000.00, 99000.00, 2, 2 )
go
--The following columns were excluded due to unsupported datatypes: [Comentarios]
INSERT INTO [dbo].[Tasaciones] ( [IdTasacion], [IdPropiedad], [Fecha], [ImporteValorReal], [ImporteValorPublicacion], [IdMonedaValorReal], [IdMonedaValorPublicacion] ) VALUES(  13, 44, '2008-01-14 16:39:30.0', 98000.00, 102000.00, 2, 2 )
go
--The following columns were excluded due to unsupported datatypes: [Comentarios]
INSERT INTO [dbo].[Tasaciones] ( [IdTasacion], [IdPropiedad], [Fecha], [ImporteValorReal], [ImporteValorPublicacion], [IdMonedaValorReal], [IdMonedaValorPublicacion] ) VALUES(  14, 84, '2008-05-10 10:49:29.0', 700.00, 1000.00, 1, 1 )
go
--The following columns were excluded due to unsupported datatypes: [Comentarios]
INSERT INTO [dbo].[Tasaciones] ( [IdTasacion], [IdPropiedad], [Fecha], [ImporteValorReal], [ImporteValorPublicacion], [IdMonedaValorReal], [IdMonedaValorPublicacion] ) VALUES(  15, 89, '2008-06-06 13:00:00.0', 178000.00, 0.00, 2, 2 )
go
--The following columns were excluded due to unsupported datatypes: [Comentarios]
INSERT INTO [dbo].[Tasaciones] ( [IdTasacion], [IdPropiedad], [Fecha], [ImporteValorReal], [ImporteValorPublicacion], [IdMonedaValorReal], [IdMonedaValorPublicacion] ) VALUES(  16, 92, '2008-03-20 12:18:01.0', 2500.00, 3000.00, 1, 1 )
go
--The following columns were excluded due to unsupported datatypes: [Comentarios]
INSERT INTO [dbo].[Tasaciones] ( [IdTasacion], [IdPropiedad], [Fecha], [ImporteValorReal], [ImporteValorPublicacion], [IdMonedaValorReal], [IdMonedaValorPublicacion] ) VALUES(  17, 97, '2008-06-21 11:37:50.0', 92000.00, 97000.00, 2, 2 )
go
SET IDENTITY_INSERT [dbo].[Tasaciones] OFF
go
SET IDENTITY_INSERT [dbo].[TiposAmbiente] ON
go
INSERT INTO [dbo].[TiposAmbiente] ( [IdTipoambiente], [Nombre], [Codigo] ) VALUES(  1, 'Cocina', 10001 )
go
INSERT INTO [dbo].[TiposAmbiente] ( [IdTipoambiente], [Nombre], [Codigo] ) VALUES(  2, 'Baño', 10002 )
go
INSERT INTO [dbo].[TiposAmbiente] ( [IdTipoambiente], [Nombre], [Codigo] ) VALUES(  3, 'Dormitorio', 10003 )
go
INSERT INTO [dbo].[TiposAmbiente] ( [IdTipoambiente], [Nombre], [Codigo] ) VALUES(  4, 'Dormitorio en suite', 10004 )
go
INSERT INTO [dbo].[TiposAmbiente] ( [IdTipoambiente], [Nombre], [Codigo] ) VALUES(  5, 'Living', 10005 )
go
INSERT INTO [dbo].[TiposAmbiente] ( [IdTipoambiente], [Nombre], [Codigo] ) VALUES(  6, 'Cochera', 10006 )
go
INSERT INTO [dbo].[TiposAmbiente] ( [IdTipoambiente], [Nombre], [Codigo] ) VALUES(  7, 'Terraza', 10007 )
go
INSERT INTO [dbo].[TiposAmbiente] ( [IdTipoambiente], [Nombre], [Codigo] ) VALUES(  8, 'Balcón', 10008 )
go
INSERT INTO [dbo].[TiposAmbiente] ( [IdTipoambiente], [Nombre], [Codigo] ) VALUES(  9, 'Toilette', 10009 )
go
INSERT INTO [dbo].[TiposAmbiente] ( [IdTipoambiente], [Nombre], [Codigo] ) VALUES(  10, 'Biblioteca', 10010 )
go
INSERT INTO [dbo].[TiposAmbiente] ( [IdTipoambiente], [Nombre], [Codigo] ) VALUES(  11, 'Estudio', 10011 )
go
INSERT INTO [dbo].[TiposAmbiente] ( [IdTipoambiente], [Nombre], [Codigo] ) VALUES(  12, 'Cuarto de Servicio', 10012 )
go
INSERT INTO [dbo].[TiposAmbiente] ( [IdTipoambiente], [Nombre], [Codigo] ) VALUES(  13, 'Lavadero', 10013 )
go
INSERT INTO [dbo].[TiposAmbiente] ( [IdTipoambiente], [Nombre], [Codigo] ) VALUES(  14, 'Comedor diario', 10014 )
go
INSERT INTO [dbo].[TiposAmbiente] ( [IdTipoambiente], [Nombre], [Codigo] ) VALUES(  15, 'Baño de Servicio', 10015 )
go
INSERT INTO [dbo].[TiposAmbiente] ( [IdTipoambiente], [Nombre], [Codigo] ) VALUES(  16, 'Otros', 0 )
go
SET IDENTITY_INSERT [dbo].[TiposAmbiente] OFF
go
INSERT INTO [dbo].[TiposDePiso] ( [IdTipoPiso], [Nombre] ) VALUES(  1, 'No especifica' )
go
INSERT INTO [dbo].[TiposDePiso] ( [IdTipoPiso], [Nombre] ) VALUES(  2, 'Ceramicos' )
go
INSERT INTO [dbo].[TiposDePiso] ( [IdTipoPiso], [Nombre] ) VALUES(  3, 'Parquet' )
go
INSERT INTO [dbo].[TiposDePiso] ( [IdTipoPiso], [Nombre] ) VALUES(  4, 'Alfombra' )
go
INSERT INTO [dbo].[TiposDePiso] ( [IdTipoPiso], [Nombre] ) VALUES(  5, 'Pinotea' )
go
INSERT INTO [dbo].[TiposDePiso] ( [IdTipoPiso], [Nombre] ) VALUES(  6, 'Cemento Alisado' )
go
INSERT INTO [dbo].[TiposDePiso] ( [IdTipoPiso], [Nombre] ) VALUES(  7, 'Madera' )
go
INSERT INTO [dbo].[TiposDePiso] ( [IdTipoPiso], [Nombre] ) VALUES(  8, 'Flotante' )
go
INSERT INTO [dbo].[TiposDePiso] ( [IdTipoPiso], [Nombre] ) VALUES(  9, 'Mosaicos' )
go
INSERT INTO [dbo].[TiposDePiso] ( [IdTipoPiso], [Nombre] ) VALUES(  10, 'Mármol' )
go
INSERT INTO [dbo].[TiposDePiso] ( [IdTipoPiso], [Nombre] ) VALUES(  11, 'Granito' )
go
INSERT INTO [dbo].[TiposDePiso] ( [IdTipoPiso], [Nombre] ) VALUES(  12, 'Baldosas' )
go
INSERT INTO [dbo].[TiposDePiso] ( [IdTipoPiso], [Nombre] ) VALUES(  13, 'Porcelanato' )
go
INSERT INTO [dbo].[TiposDePiso] ( [IdTipoPiso], [Nombre] ) VALUES(  1001, 'Sin especificar' )
go
INSERT INTO [dbo].[TiposPropiedad] ( [IdTipoPropiedad], [Nombre], [IdCategoria] ) VALUES(  1, 'Departamento', 1 )
go
INSERT INTO [dbo].[TiposPropiedad] ( [IdTipoPropiedad], [Nombre], [IdCategoria] ) VALUES(  2, 'PH ', 1 )
go
INSERT INTO [dbo].[TiposPropiedad] ( [IdTipoPropiedad], [Nombre], [IdCategoria] ) VALUES(  7, 'Casa', 1 )
go
INSERT INTO [dbo].[TiposPropiedad] ( [IdTipoPropiedad], [Nombre], [IdCategoria] ) VALUES(  8, 'Chalet', 1 )
go
INSERT INTO [dbo].[TiposPropiedad] ( [IdTipoPropiedad], [Nombre], [IdCategoria] ) VALUES(  9, 'Duplex', 1 )
go
INSERT INTO [dbo].[TiposPropiedad] ( [IdTipoPropiedad], [Nombre], [IdCategoria] ) VALUES(  10, 'Triplex', 1 )
go
INSERT INTO [dbo].[TiposPropiedad] ( [IdTipoPropiedad], [Nombre], [IdCategoria] ) VALUES(  11, 'Terreno', 1 )
go
INSERT INTO [dbo].[TiposPropiedad] ( [IdTipoPropiedad], [Nombre], [IdCategoria] ) VALUES(  12, 'Quinta', 1 )
go
INSERT INTO [dbo].[TiposPropiedad] ( [IdTipoPropiedad], [Nombre], [IdCategoria] ) VALUES(  13, 'Oficina', 2 )
go
INSERT INTO [dbo].[TiposPropiedad] ( [IdTipoPropiedad], [Nombre], [IdCategoria] ) VALUES(  14, 'Local', 2 )
go
INSERT INTO [dbo].[TiposPropiedad] ( [IdTipoPropiedad], [Nombre], [IdCategoria] ) VALUES(  15, 'Cochera', 2 )
go
INSERT INTO [dbo].[TiposPropiedad] ( [IdTipoPropiedad], [Nombre], [IdCategoria] ) VALUES(  16, 'Fondo de Comercio', 2 )
go
INSERT INTO [dbo].[TiposPropiedad] ( [IdTipoPropiedad], [Nombre], [IdCategoria] ) VALUES(  17, 'Galpón', 2 )
go
INSERT INTO [dbo].[TiposPropiedad] ( [IdTipoPropiedad], [Nombre], [IdCategoria] ) VALUES(  18, 'Campo', 2 )
go
INSERT INTO [dbo].[TiposPropiedad] ( [IdTipoPropiedad], [Nombre], [IdCategoria] ) VALUES(  19, 'Edificio', 3 )
go
INSERT INTO [dbo].[TiposPropiedad] ( [IdTipoPropiedad], [Nombre], [IdCategoria] ) VALUES(  20, 'Hotel', 3 )
go
INSERT INTO [dbo].[TiposPropiedad] ( [IdTipoPropiedad], [Nombre], [IdCategoria] ) VALUES(  21, 'Otro', 3 )
go
INSERT INTO [dbo].[TiposPropiedad] ( [IdTipoPropiedad], [Nombre], [IdCategoria] ) VALUES(  22, 'Depósito', 2 )
go
INSERT INTO [dbo].[TipoTransaccion] ( [IdTipoTrans], [Descripcion] ) VALUES(  1, 'Crear' )
go
INSERT INTO [dbo].[TipoTransaccion] ( [IdTipoTrans], [Descripcion] ) VALUES(  2, 'Modificar' )
go
INSERT INTO [dbo].[TipoTransaccion] ( [IdTipoTrans], [Descripcion] ) VALUES(  3, 'Eliminar' )
go
INSERT INTO [dbo].[UbicacionesCartel] ( [IdUbicacionCartel], [Descripcion] ) VALUES(  1, 'Sin Definir' )
go
INSERT INTO [dbo].[UbicacionesCartel] ( [IdUbicacionCartel], [Descripcion] ) VALUES(  2, 'Frente' )
go
INSERT INTO [dbo].[UbicacionesCartel] ( [IdUbicacionCartel], [Descripcion] ) VALUES(  3, 'ContraFrente' )
go
INSERT INTO [dbo].[UbicacionesCartel] ( [IdUbicacionCartel], [Descripcion] ) VALUES(  4, 'Poste' )
go
SET IDENTITY_INSERT [dbo].[ValoresRenta] ON
go
INSERT INTO [dbo].[ValoresRenta] ( [IdValorRenta], [IdContrato], [IdMoneda], [Importe], [AnioDesde], [AnioHasta], [MesDesde], [MesHasta] ) VALUES(  3, 8, 1, 2000, 2008, 2009, 5, 5 )
go
INSERT INTO [dbo].[ValoresRenta] ( [IdValorRenta], [IdContrato], [IdMoneda], [Importe], [AnioDesde], [AnioHasta], [MesDesde], [MesHasta] ) VALUES(  4, 9, 1, 950, 2008, 2008, 6, 7 )
go
SET IDENTITY_INSERT [dbo].[ValoresRenta] OFF
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  34 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  35 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  37 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  38 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  39 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  40 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  41 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  42 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  43 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  44 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  45 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  46 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  47 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  48 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  49 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  50 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  51 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  52 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  53 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  54 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  55 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  56 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  57 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  58 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  59 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  60 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  61 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  62 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  63 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  64 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  68 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  69 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  70 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  73 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  74 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  75 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  76 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  77 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  81 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  82 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  85 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  86 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  87 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  88 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  89 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  90 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  91 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  93 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  94 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  96 )
go
INSERT INTO [dbo].[Ventas] ( [IdPropiedad] ) VALUES(  97 )
go
SET IDENTITY_INSERT [dbo].[VisitasPropiedad] ON
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  1, 9000000000, '2007-01-12 11:30:57.0', 1, 'Sandra', '47662108', 0, 69 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  2, 9000000000, '2007-01-13 11:30:11.0', 1, 'sandra', '4766-2108', 0, 69 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  3, 9000000000, '2007-01-16 19:00:02.0', 1, 'Hugo', '155-455-3879', 0, 69 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  4, 9000000000, '2007-01-17 19:30:41.0', 1, 'Rosario', '4799-3756', 0, 69 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  5, 9000000000, '2007-01-19 12:00:13.0', 1, 'Carolina', '154-095-9083/4760-8859', 0, 69 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  6, 9000000000, '2007-01-27 12:00:55.0', 1, 'Javier (Bez propiedades)', '', 0, 82 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  9, 9000000000, '2007-01-31 17:30:14.0', 1, 'Susana Iglesias', '', 0, 68 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  10, 9000000000, '2007-01-31 18:20:23.0', 1, 'Maria Victoria', '156-157-1703', 0, 68 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  11, 9000000000, '2007-01-31 19:15:51.0', 1, 'Sol', '155-343-1294', 0, 68 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  12, 9000000000, '2007-02-03 14:00:29.0', 1, 'Maqui (LAMARCA)', '4792-0453 / 156-800-3930', 0, 51 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  13, 9000000000, '2007-02-12 11:30:24.0', 1, 'Delia', '4826-6406/155-374-0065', 0, 53 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  14, 9000000000, '2007-02-14 18:00:29.0', 1, 'Javier (BEZ)', '', 0, 82 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  15, 9000000000, '2007-02-14 18:00:52.0', 1, 'Ana', '', 0, 82 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  16, 9000000000, '2007-02-24 19:00:55.0', 1, 'Marcelo', '155-308-7573', 0, 53 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  17, 9000000000, '2007-03-03 12:30:15.0', 1, 'Estela', '4554-0734', 0, 53 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  18, 9000000000, '2007-03-15 17:00:59.0', 1, 'Eugenia', '4795-8002', 0, 67 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  19, 9000000000, '2007-03-16 12:30:28.0', 1, 'Juan Manuel', '4783-4329', 0, 67 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  20, 9000000000, '2007-03-17 15:30:54.0', 1, 'Manuel', '155-569-3190/4731-6332', 0, 67 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  21, 9000000000, '2007-03-17 15:00:33.0', 1, 'Pilar', '156-601-6151', 0, 67 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  22, 9000000000, '2007-03-23 14:50:34.0', 1, 'Eve', '4799-7823/4794-8417', 0, 68 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  23, 9000000000, '2007-03-27 11:00:02.0', 1, 'Marta', '4711-0792/155-981-6398', 0, 53 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  24, 9000000000, '2007-04-07 12:00:45.0', 1, 'Azara Propiedades', '', 0, 53 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  25, 9000000000, '2007-04-21 13:30:07.0', 1, 'Alicia', '4795-4219/156-442-9278', 0, 53 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  26, 9000000000, '2007-04-26 17:00:47.0', 1, 'Lucila', '4791-9697/6785', 0, 53 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  27, 9000000000, '2007-04-27 16:00:46.0', 1, 'Maria del Carmen', '154-992-0217/4791-9998', 0, 68 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  28, 9000000000, '2007-04-28 15:45:54.0', 1, 'Juanita', '', 0, 53 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  29, 9000000000, '2007-04-28 16:00:21.0', 1, 'Marcela', '', 0, 53 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  30, 9000000000, '2007-05-05 15:00:18.0', 1, 'Malena', '155-044-4390', 0, 81 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  31, 9000000000, '2007-04-11 12:00:57.0', 1, 'Marina', '4760-6810', 0, 53 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  32, 9000000000, '2007-05-12 16:00:31.0', 1, 'Nancy', '4761-7281', 0, 53 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  33, 9000000000, '2007-05-15 13:00:01.0', 1, 'Veronica', '4730-3571', 0, 68 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  34, 9000000000, '2007-06-07 14:30:55.0', 1, 'Cristian', '4726-3291', 0, 56 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  35, 9000000000, '2007-06-13 15:00:56.0', 1, 'Mariel', '154-998-7005', 0, 56 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  36, 9000000000, '2007-07-06 16:00:02.0', 1, 'Juan Carlos', '4797-8469', 0, 70 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  37, 9000000000, '2007-07-14 10:30:11.0', 1, 'Florencia', '155-764-8425', 0, 35 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  38, 9000000000, '2007-07-28 11:00:59.0', 1, 'Erminda', '', 0, 68 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  39, 9000000000, '2007-07-28 12:00:41.0', 1, 'Eduardo', '', 0, 35 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  40, 9000000000, '2007-07-28 12:15:02.0', 1, 'Mass Prop.', '', 0, 35 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  41, 9000000000, '2007-07-01 14:30:39.0', 1, 'Abro prop.', '4794-9925', 0, 51 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  42, 9000000000, '2007-08-18 11:30:06.0', 1, 'Natalia', '156-653-7558', 0, 35 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  43, 9000000000, '2007-08-25 12:15:54.0', 1, 'Valeria', '4797-6660/154-043-6314', 0, 74 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  44, 9000000000, '2007-08-27 12:00:27.0', 1, 'Monica', '4796-0357', 0, 74 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  45, 9000000000, '2007-08-01 16:30:28.0', 1, 'Paula', '4837-9370', 0, 74 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  46, 9000000000, '2007-09-07 15:30:19.0', 1, 'Ana María', '4795-2895', 0, 76 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  47, 9000000000, '2007-09-05 16:30:57.0', 1, 'Blanca', '', 0, 74 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  48, 9000000000, '2007-09-12 15:30:28.0', 1, 'Cristina', '', 0, 56 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  49, 9000000000, '2007-09-15 11:00:46.0', 1, 'Horacio', '', 0, 81 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  50, 9000000000, '2007-09-20 16:30:29.0', 0, 'Olga (A.Alvarez)', '', 0, 42 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  51, 9000000000, '2007-09-22 11:30:11.0', 1, 'Hector', '4796-9306', 0, 74 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  52, 9000000000, '2007-09-24 19:00:06.0', 1, 'Hector Pera', '', 0, 74 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  53, 9000000000, '2007-09-27 11:00:55.0', 1, 'Claudio', '4793-7131', 0, 74 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  54, 9000000000, '2007-09-27 18:00:27.0', 1, 'Gisella', '', 0, 74 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  55, 9000000000, '2007-09-29 13:15:12.0', 1, 'Rosana', '', 0, 35 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  56, 9000000000, '2007-10-06 11:00:57.0', 1, 'Marisa', '', 0, 42 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  57, 9000000000, '2007-10-06 12:00:37.0', 1, 'María', '155-185-9005', 0, 42 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  58, 9000000000, '2007-10-27 11:00:49.0', 1, 'Anibal', '154-565-8198', 0, 42 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  59, 9000000000, '2007-10-30 13:00:22.0', 1, 'Veronica', '', 0, 35 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  60, 9000000000, '2007-11-03 11:15:45.0', 1, 'Lucila', '', 0, 35 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  61, 9000000000, '2007-11-10 11:00:32.0', 1, 'Marian', '156-547-4022', 0, 35 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  62, 9000000000, '2007-11-10 12:30:58.0', 1, 'Lucia', '4863-6660', 0, 35 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  63, 9000000000, '2007-11-10 13:00:30.0', 1, 'Elisa', '154-033-3559/4791-9629', 0, 35 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  64, 9000000000, '2007-11-10 13:30:48.0', 1, 'Marina', '4981-8322/155312-5373', 0, 35 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  65, 9000000000, '2007-11-15 16:00:19.0', 1, 'Claudio', '155-249-9651', 0, 42 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  66, 9000000000, '2007-11-15 15:00:47.0', 1, 'Gabriel', '4773-7500', 0, 56 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  67, 9000000000, '2007-11-15 10:00:17.0', 1, 'Fernando', '156-093-6607', 0, 35 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  68, 9000000000, '2007-11-17 10:50:01.0', 1, 'Maria Jose', '155-016-7135/4796-1601', 0, 42 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  69, 9000000000, '2007-11-23 08:45:43.0', 1, 'Sonia', '155-048-2657', 0, 51 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  70, 9000000000, '2007-11-24 09:45:38.0', 1, 'Alejandra', '155-493-0341', 0, 53 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  71, 9000000000, '2007-11-24 10:00:21.0', 1, 'Lucia', '', 0, 34 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  72, 9000000000, '2007-11-24 10:30:42.0', 1, 'Ana María', '4797-1137', 0, 34 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  73, 9000000000, '2007-11-24 15:30:41.0', 1, 'Sonia', '', 0, 51 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  74, 9000000000, '2007-11-28 15:20:27.0', 1, 'Fernando', '156-093-6607', 0, 82 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  75, 9000000000, '2007-12-01 12:20:03.0', 1, 'Maria Jose', '4796-1601', 0, 42 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  76, 9000000000, '2007-12-05 18:00:42.0', 1, 'Pablo', '156-478-5038', 0, 53 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  77, 9000000000, '2007-02-07 17:30:24.0', 1, 'Mirta', '4763-6720', 0, 34 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  78, 9000000000, '2007-12-07 17:00:51.0', 1, 'Nieves', '4797-4961', 0, 42 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  79, 9000000000, '2007-12-08 10:30:16.0', 1, 'Maria jose', '4796-1601', 0, 42 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  80, 9000000000, '2007-12-08 11:00:55.0', 1, 'Ana', '4756-2254', 0, 53 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  81, 9000000000, '2007-12-08 10:30:33.0', 1, 'Ana', '4756-2254', 0, 56 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  82, 9000000000, '2007-12-10 14:00:00.0', 1, 'Liliana', '155-016-2880', 0, 51 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  83, 9000000000, '2007-12-14 15:00:32.0', 1, 'Paula', '155-963-6510', 0, 35 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  84, 9000000000, '2007-12-19 16:30:46.0', 1, 'Miriam', '', 0, 34 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  85, 9000000000, '2007-12-20 17:45:23.0', 1, 'Osvaldo', '', 0, 34 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  86, 9000000000, '2007-12-21 20:30:44.0', 1, 'Miguel', '', 0, 51 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  87, 9000000000, '2007-12-28 18:00:22.0', 1, 'Daniel', '154-414-7355', 0, 42 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  88, 9000000000, '2008-01-12 10:30:09.0', 1, 'Marcelo', '', 0, 35 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  89, 9000000000, '2008-01-12 16:00:49.0', 1, 'Laura', '155-837-1472', 0, 48 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  90, 9000000000, '2008-01-15 18:15:27.0', 1, 'Micaela', '153-187-1420', 0, 66 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  91, 9000000000, '2008-01-16 17:30:00.0', 1, 'Dario', '4791-8519', 0, 53 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  92, 9000000000, '2008-01-17 11:00:23.0', 1, 'Juan', '155-849-8291', 0, 66 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  93, 9000000000, '2008-11-17 12:15:37.0', 1, 'Nancy', '4756-5319', 0, 43 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  94, 9000000000, '2008-01-18 19:00:28.0', 1, 'Diego', '4798-0970', 0, 56 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  95, 9000000000, '2008-01-21 17:00:07.0', 1, 'Graciela', '4718-0966', 0, 51 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  96, 9000000000, '2008-01-21 19:45:12.0', 1, 'Mercedez ', '154-084-2442', 0, 35 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  97, 9000000000, '2008-01-25 19:00:51.0', 1, 'Mariana', '156-949-4494', 0, 48 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  98, 9000000000, '2008-01-29 09:30:49.0', 1, 'Alina', '4795-8903', 0, 82 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  99, 9000000000, '2008-02-01 10:00:24.0', 1, 'Soledad', '155-185-1782', 0, 51 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  100, 9000000000, '2008-02-07 20:00:04.0', 1, 'Soledad', '', 0, 51 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  101, 9000000000, '2008-02-18 19:00:24.0', 1, 'Florencia Mouriño', '156-283-4024', 0, 43 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  102, 9000000000, '2008-02-21 19:00:01.0', 1, 'Andrea', '153-140-3299', 0, 43 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  104, 9000000000, '2008-02-22 17:30:29.0', 1, 'Sra. Mayo', '4799-9152', 0, 62 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  105, 9000000000, '2008-02-23 10:30:00.0', 1, 'Edgardo', '156-566-0316', 0, 35 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  106, 9000000000, '2008-02-23 13:00:31.0', 1, 'Magdalena', '155-229-6187/4788-2358', 0, 35 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  107, 9000000000, '2008-02-23 15:00:06.0', 1, 'Maria', '153-168-0267', 0, 48 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  108, 9000000000, '2008-02-27 10:30:45.0', 1, 'Cecilia', '156-564-2324', 0, 35 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  109, 9000000000, '2008-02-27 18:30:14.0', 1, 'Cristian', '156-690-2756', 0, 34 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  110, 9000000000, '2008-03-01 14:30:01.0', 1, 'Maria Laura', '4795-4559', 0, 44 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  111, 9000000000, '2008-03-05 15:30:47.0', 1, 'Mirta', '4763-6720', 0, 34 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  112, 9000000000, '2008-02-08 12:00:33.0', 1, 'Ana Gracia', '', 0, 53 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  113, 9000000000, '2008-03-11 18:30:06.0', 1, 'Cecilia', '156-564-2324', 0, 53 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  114, 9000000000, '2008-03-18 17:00:19.0', 1, 'Marlene', '', 0, 53 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  115, 9000000000, '2008-03-28 12:30:31.0', 1, 'Gabriela', '155-009-5725', 0, 83 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  116, 9000000000, '2008-03-29 11:00:27.0', 1, 'Patricia', '155-751-1781', 0, 35 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  117, 9000000000, '2008-03-29 11:30:47.0', 1, 'Silvina', '155-754-1174', 0, 35 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  118, 9000000000, '2008-04-04 16:30:44.0', 1, 'Margarita', '', 0, 45 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  119, 9000000000, '2008-04-05 13:00:31.0', 1, 'Valeria', '154-406-1890', 0, 35 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  120, 9000000000, '2008-04-08 11:30:49.0', 1, 'Nicolas', '153-153-9495', 0, 42 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  121, 9000000000, '2008-04-09 18:15:54.0', 1, 'Dina', '155-060-4181', 0, 75 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  122, 9000000000, '2008-04-09 18:30:46.0', 1, 'Leonora', '156-482-3322', 0, 75 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  123, 9000000000, '2008-04-10 16:30:19.0', 1, 'Mirta', '155-514-8545', 0, 83 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  124, 9000000000, '2008-04-11 09:30:38.0', 1, 'Marina', '4797-0760', 0, 75 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  125, 9000000000, '2008-04-11 16:45:07.0', 1, 'Martin', '4733-0101', 0, 35 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  126, 9000000000, '2008-04-12 10:30:49.0', 1, 'Paola', '156-467-7457', 0, 38 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  127, 9000000000, '2008-04-12 10:00:25.0', 1, 'Paola', '156-467-7457', 0, 75 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  128, 9000000000, '2008-04-12 13:30:57.0', 1, 'Patricia', '155-751-2825', 0, 35 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  129, 9000000000, '2008-04-14 18:15:39.0', 1, 'Dina', '', 0, 75 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  130, 9000000000, '2008-04-14 18:45:14.0', 1, 'Miguel', '155-891-0804', 0, 75 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  131, 9000000000, '2008-04-15 17:00:50.0', 1, 'Adriana', '155-563-3747', 0, 75 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  132, 9000000000, '2008-04-16 13:00:49.0', 1, 'Carlos', '156-820-9602', 0, 55 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  133, 9000000000, '2008-04-16 18:00:32.0', 1, 'Jimena', '156-951-6565', 0, 34 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  134, 9000000000, '2008-04-19 10:30:27.0', 0, 'Hebe', '155-375-2959', 0, 38 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  135, 9000000000, '2008-04-19 13:00:23.0', 1, 'Sabrina', '155-752-6789', 0, 38 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  136, 9000000000, '2008-04-21 18:00:24.0', 1, 'Rosalia', '4794-8866', 0, 62 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  137, 9000000000, '2008-04-22 12:00:51.0', 1, 'Veronica', '156-877-7778', 0, 42 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  138, 9000000000, '2008-04-22 14:30:31.0', 1, 'Mariela / Pablo', '155-006-8557', 0, 35 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  139, 9000000000, '2008-04-23 18:30:06.0', 1, 'Guillermo', '4797-7675', 0, 36 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  140, 9000000000, '2008-04-25 13:30:38.0', 1, 'Ivana', '155-595-2798', 0, 36 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  141, 9000000000, '2008-04-26 10:20:22.0', 1, 'Luciana', '156-171-5614', 0, 42 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  142, 9000000000, '2008-04-26 11:15:18.0', 1, 'Hebe', '155-375-2959', 0, 42 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  143, 9000000000, '2008-04-26 13:15:07.0', 1, 'Santiago', '156-243-9623', 0, 36 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  144, 9000000000, '2008-04-26 13:45:44.0', 1, 'Javier', '155-994-6603', 0, 36 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  145, 9000000000, '2008-04-26 16:30:21.0', 1, 'Sabrina', '156-658-4132', 0, 44 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  146, 9000000000, '2008-04-28 17:30:59.0', 1, 'Lorena', '156-855-6119', 0, 36 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  147, 9000000000, '2008-04-28 18:00:35.0', 1, 'Dario / Ana', '', 0, 52 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  148, 9000000000, '2008-04-29 13:00:28.0', 1, 'Mariano', '4580-9666', 0, 36 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  149, 9000000000, '2008-04-30 11:00:54.0', 1, 'Verónica', '4796-0697', 0, 42 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  150, 9000000000, '2008-05-02 17:30:19.0', 1, 'Agustín', '155-878-6908', 0, 42 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  151, 9000000000, '2008-05-03 09:30:07.0', 1, 'Diego', '155-886-2787', 0, 36 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  152, 9000000000, '2008-05-03 09:45:31.0', 1, 'Miguel Monetti', '156-996-9676', 0, 36 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  153, 9000000000, '2008-05-03 10:30:04.0', 1, 'julio', '4863-4849', 0, 48 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  154, 9000000000, '2008-05-03 12:45:35.0', 0, 'Lucila', '', 0, 42 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  155, 9000000000, '2008-05-03 13:00:01.0', 1, 'Martín Roman', '154-917-2046', 0, 42 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  156, 9000000000, '2008-05-03 17:00:41.0', 1, 'Jose Luis', '155-829-3421', 0, 52 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  157, 9000000000, '2008-05-06 16:30:24.0', 1, 'Emilio', '155-640-7915', 0, 52 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  158, 9000000000, '2008-05-08 16:00:08.0', 1, 'Mariela', '155-006-8557', 0, 52 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  159, 9000000000, '2008-05-10 10:30:08.0', 1, 'Diego', '154-917-6230', 0, 63 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  160, 9000000000, '2008-05-12 17:00:06.0', 1, 'Roberto Bonifacio', '', 0, 39 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  161, 9000000000, '2008-05-14 16:00:56.0', 1, 'Alejandro', '155-047-5318', 0, 36 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  162, 9000000000, '2008-05-19 16:20:37.0', 1, 'Marta', '4791-8194', 0, 52 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  163, 9000000000, '2008-05-20 16:30:16.0', 1, 'Silvia', '4790-7647', 0, 62 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  164, 9000000000, '2008-05-24 12:00:51.0', 1, 'Alejandra/Luciano', '4797-4749', 0, 36 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  165, 9000000000, '2008-05-29 15:30:26.0', 1, 'Liliana Marquez', '156-127-8053/4856-9476', 0, 52 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  166, 9000000000, '2008-05-29 16:30:27.0', 1, 'Fabiana', '', 0, 44 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  167, 9000000000, '2008-05-30 19:30:24.0', 1, 'Alejandra', '156-279-6336/4812-6820', 0, 34 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  168, 9000000000, '2008-05-31 16:00:14.0', 1, 'Marcelo', '156-353-9001', 0, 52 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  169, 9000000000, '2008-05-31 15:00:43.0', 1, 'Ivana', '154-471-7548', 0, 52 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  170, 9000000000, '2008-05-01 14:00:15.0', 1, 'Manuel', '4779-1001', 0, 35 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  171, 9000000000, '2008-05-31 14:30:44.0', 1, 'Gabriela', '156-708-0747', 0, 35 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  172, 9000000000, '2008-05-31 15:00:04.0', 1, 'Ivana', '154-471-7548', 0, 35 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  173, 9000000000, '2008-05-29 10:48:06.0', 1, 'Diego Carron', '155-493-0585 / 4515-0131', 0, 84 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  174, 9000000000, '2008-06-07 11:30:06.0', 1, 'Camila', '155-338-2566', 0, 48 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  175, 9000000000, '2008-06-09 12:00:17.0', 1, 'Guillermina', '155-017-5731', 0, 79 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  176, 9000000000, '2008-06-11 18:00:21.0', 1, 'Claudia', '154-025-992', 0, 79 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  177, 9000000000, '2008-06-14 12:30:37.0', 1, 'Natalia', '1559616331', 0, 35 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  178, 72000000000, '2008-06-14 13:00:06.0', 0, 'Natalia', '1559616331', 0, 49 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  179, 9000000000, '2008-06-14 10:00:29.0', 0, 'Fabio Elcano', '', 0, 62 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  180, 9000000000, '2008-06-12 17:00:21.0', 1, 'Hernan', '155-093-7374', 0, 62 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  181, 9000000000, '2008-06-14 12:00:03.0', 1, 'Deborah', '4795-8798', 1, 48 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  182, 9000000000, '2008-06-14 15:30:29.0', 1, 'Estela', '4799-6211', 0, 62 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  183, 9000000000, '2008-06-17 11:00:08.0', 1, 'Leticia', '155-182-2379', 0, 36 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  184, 9000000000, '2008-06-19 16:30:16.0', 1, 'Hugo Bolsan', '4795-3638', 0, 78 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  185, 9000000000, '2008-06-17 17:00:16.0', 1, 'Maria José', '155-626-0273 / 4700-1681', 0, 79 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  186, 9000000000, '2008-06-17 17:15:05.0', 1, 'Santiago', '156-539-3544', 0, 79 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  187, 9000000000, '2008-06-19 17:30:21.0', 1, 'Marcela', '154-414-5327', 0, 52 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  188, 9000000000, '2008-06-20 15:00:57.0', 1, 'Lucila', '154-034-2689 / 4961-8163', 0, 52 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  189, 9000000000, '2008-06-20 15:00:50.0', 1, 'Lucila', '154-034-2689 / 4961-8163', 0, 35 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  190, 9000000000, '2008-06-23 17:00:52.0', 0, 'Melisa', '156-299-0047', 0, 36 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  191, 9000000000, '2008-06-23 17:20:23.0', 1, 'Analia', '4794-0538', 0, 36 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  192, 9000000000, '2008-06-26 17:00:58.0', 1, 'Sr. Lubel', '154-997-8260', 0, 36 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  193, 9000000000, '2008-06-24 16:45:05.0', 1, 'Marcelo', '4799-9003', 0, 52 )
go
--The following columns were excluded due to unsupported datatypes: [Comentario]
INSERT INTO [dbo].[VisitasPropiedad] ( [IdVisita], [TimpoAlarma], [FechaHora], [Realizada], [Visita], [Telefono], [ConAlarma], [IdPropiedad] ) VALUES(  194, 9000000000, '2008-06-26 17:30:20.0', 1, 'Jaquelina', '156-391-9926', 0, 79 )
go
SET IDENTITY_INSERT [dbo].[VisitasPropiedad] OFF
go

USE [inmobiliariadb]
go
ALTER TABLE dbo.AdmAlquileres
    ADD CONSTRAINT FK_AdmAlquileres_Alquileres
    FOREIGN KEY (IdPropiedad)
    REFERENCES dbo.Alquileres (IdPropiedad)
go
ALTER TABLE dbo.AdmAlquileres
    ADD CONSTRAINT FK_AdmAlquileres_Propietarios
    FOREIGN KEY (IdContacto)
    REFERENCES dbo.Propietarios (IdCliente)
go
ALTER TABLE dbo.Alquileres
    ADD CONSTRAINT FK_Alquileres_Propiedades
    FOREIGN KEY (IdPropiedad)
    REFERENCES dbo.Propiedades (IdPropiedad)
go
ALTER TABLE dbo.Barrios
    ADD CONSTRAINT FK_Barrios_Localidades
    FOREIGN KEY (IdLocalidad)
    REFERENCES dbo.Localidades (IdLocalidad)
go
ALTER TABLE dbo.Carteles
    ADD CONSTRAINT FK_Carteles_Propiedades
    FOREIGN KEY (IdPropiedad)
    REFERENCES dbo.Propiedades (IdPropiedad)
go
ALTER TABLE dbo.Carteles
    ADD CONSTRAINT FK_Carteles_UbicacionesCartel
    FOREIGN KEY (IdUbicacionCartel)
    REFERENCES dbo.UbicacionesCartel (IdUbicacionCartel)
go
ALTER TABLE dbo.Clientes
    ADD CONSTRAINT FK_Clientes_Barrios
    FOREIGN KEY (IdBarrio)
    REFERENCES dbo.Barrios (IdBarrio)
go
ALTER TABLE dbo.Clientes
    ADD CONSTRAINT FK_Clientes_Localidades
    FOREIGN KEY (IdLocalidad)
    REFERENCES dbo.Localidades (IdLocalidad)
go
ALTER TABLE dbo.Clientes
    ADD CONSTRAINT FK_Clientes_Paises
    FOREIGN KEY (IdPais)
    REFERENCES dbo.Paises (IdPais)
go
ALTER TABLE dbo.Clientes
    ADD CONSTRAINT FK_Clientes_Provincias
    FOREIGN KEY (IdProvincia)
    REFERENCES dbo.Provincias (IdProvincia)
go
ALTER TABLE dbo.ClientesPedido
    ADD CONSTRAINT FK_ClientesPedido_ClientesPedido
    FOREIGN KEY (IdCliente)
    REFERENCES dbo.Clientes (IdCliente)
go
ALTER TABLE dbo.Contratos
    ADD CONSTRAINT FK_Contratos_AdmAlquileres
    FOREIGN KEY (IdPropiedad)
    REFERENCES dbo.AdmAlquileres (IdPropiedad)
go
ALTER TABLE dbo.Contratos
    ADD CONSTRAINT FK_Contratos_Contratos
    FOREIGN KEY (IdContratoAnterior)
    REFERENCES dbo.Contratos (IdContrato)
go
ALTER TABLE dbo.Contratos
    ADD CONSTRAINT FK_Contratos_Inquilinos
    FOREIGN KEY (IdInquilino)
    REFERENCES dbo.Inquilinos (IdCliente)
go
ALTER TABLE dbo.Contratos
    ADD CONSTRAINT FK_Contratos_Monedas1
    FOREIGN KEY (IdMonedaDeposito)
    REFERENCES dbo.Monedas (IdMoneda)
go
ALTER TABLE dbo.EventoVisita
    ADD CONSTRAINT FK_EventoVisita_Eventos
    FOREIGN KEY (IdEvento)
    REFERENCES dbo.Eventos (IdEvento)
go
ALTER TABLE dbo.EventoVisita
    ADD CONSTRAINT FK_EventoVisita_VisitasPropiedad
    FOREIGN KEY (IdVisita)
    REFERENCES dbo.VisitasPropiedad (IdVisita)
go
ALTER TABLE dbo.GaleriaFotos
    ADD CONSTRAINT FK_GaleriaFotos_Propiedades
    FOREIGN KEY (IdPropiedad)
    REFERENCES dbo.Propiedades (IdPropiedad)
go
ALTER TABLE dbo.Inquilinos
    ADD CONSTRAINT FK_Inquilinos_Clientes
    FOREIGN KEY (IdCliente)
    REFERENCES dbo.Clientes (IdCliente)
go
ALTER TABLE dbo.Llamados
    ADD CONSTRAINT FK_Llamados_Propiedades
    FOREIGN KEY (IdPropiedad)
    REFERENCES dbo.Propiedades (IdPropiedad)
go
ALTER TABLE dbo.Localidades
    ADD CONSTRAINT FK_Localidades_Provincias
    FOREIGN KEY (IdProvincia)
    REFERENCES dbo.Provincias (IdProvincia)
go
ALTER TABLE dbo.MedidasAmbientesPropiedad
    ADD CONSTRAINT FK_MedidasAmbientesPropiedad_Propiedades
    FOREIGN KEY (IdPropiedad)
    REFERENCES dbo.Propiedades (IdPropiedad)
go
ALTER TABLE dbo.MedidasAmbientesPropiedad
    ADD CONSTRAINT FK_MedidasAmbientesPropiedad_TiposAmbiente
    FOREIGN KEY (IdTipoAmbiente)
    REFERENCES dbo.TiposAmbiente (IdTipoambiente)
go
ALTER TABLE dbo.MedidasAmbientesPropiedad
    ADD CONSTRAINT FK_MedidasAmbientesPropiedad_TiposDePiso
    FOREIGN KEY (IdTipoPiso)
    REFERENCES dbo.TiposDePiso (IdTipoPiso)
go
ALTER TABLE dbo.NotasPropiedad
    ADD CONSTRAINT FK_NotasPropiedad_Propiedades
    FOREIGN KEY (IdPropiedad)
    REFERENCES dbo.Propiedades (IdPropiedad)
go
ALTER TABLE dbo.Pagos
    ADD CONSTRAINT FK_Pagos_Contratos
    FOREIGN KEY (IdContrato)
    REFERENCES dbo.Contratos (IdContrato)
go
ALTER TABLE dbo.Pagos
    ADD CONSTRAINT FK_Pagos_Monedas
    FOREIGN KEY (IdMoneda)
    REFERENCES dbo.Monedas (IdMoneda)
go
ALTER TABLE dbo.Pedidos
    ADD CONSTRAINT FK_Pedidos_Barrios
    FOREIGN KEY (IdBarrio)
    REFERENCES dbo.Barrios (IdBarrio)
go
ALTER TABLE dbo.Pedidos
    ADD CONSTRAINT FK_Pedidos_CategoriasPropiedad
    FOREIGN KEY (IdCategoria)
    REFERENCES dbo.CategoriasPropiedad (IdCategoria)
go
ALTER TABLE dbo.Pedidos
    ADD CONSTRAINT FK_Pedidos_ClientesPedido
    FOREIGN KEY (IdCliente)
    REFERENCES dbo.ClientesPedido (IdCliente)
go
ALTER TABLE dbo.Pedidos
    ADD CONSTRAINT FK_Pedidos_EstadosPropiedad
    FOREIGN KEY (IdEstadoPropiedad)
    REFERENCES dbo.EstadosPropiedad (IdEstadoPropiedad)
go
ALTER TABLE dbo.Pedidos
    ADD CONSTRAINT FK_Pedidos_Localidades
    FOREIGN KEY (IdLocalidad)
    REFERENCES dbo.Localidades (IdLocalidad)
go
ALTER TABLE dbo.Pedidos
    ADD CONSTRAINT FK_Pedidos_Monedas1
    FOREIGN KEY (IdMoneda)
    REFERENCES dbo.Monedas (IdMoneda)
go
ALTER TABLE dbo.Pedidos
    ADD CONSTRAINT FK_Pedidos_Paises
    FOREIGN KEY (IdPais)
    REFERENCES dbo.Paises (IdPais)
go
ALTER TABLE dbo.Pedidos
    ADD CONSTRAINT FK_Pedidos_Pedidos
    FOREIGN KEY (IdPedido)
    REFERENCES dbo.Pedidos (IdPedido)
go
ALTER TABLE dbo.Pedidos
    ADD CONSTRAINT FK_Pedidos_Provincias
    FOREIGN KEY (IdProvincia)
    REFERENCES dbo.Provincias (IdProvincia)
go
ALTER TABLE dbo.Pedidos
    ADD CONSTRAINT FK_Pedidos_TiposPropiedad
    FOREIGN KEY (IdTipoPropiedad)
    REFERENCES dbo.TiposPropiedad (IdTipoPropiedad)
go
ALTER TABLE dbo.Propiedades
    ADD CONSTRAINT FK_Propiedades_Barrios
    FOREIGN KEY (IdBarrio)
    REFERENCES dbo.Barrios (IdBarrio)
go
ALTER TABLE dbo.Propiedades
    ADD CONSTRAINT FK_Propiedades_Clientes
    FOREIGN KEY (IdPropietario)
    REFERENCES dbo.Clientes (IdCliente)
go
ALTER TABLE dbo.Propiedades
    ADD CONSTRAINT FK_Propiedades_EstadosPropiedad
    FOREIGN KEY (IdEstadoPropiedad)
    REFERENCES dbo.EstadosPropiedad (IdEstadoPropiedad)
go
ALTER TABLE dbo.Propiedades
    ADD CONSTRAINT FK_Propiedades_InmobiliariasExternas
    FOREIGN KEY (IdInmobiliariaExterna)
    REFERENCES dbo.InmobiliariasExternas (IdInmobiliaria)
go
ALTER TABLE dbo.Propiedades
    ADD CONSTRAINT FK_Propiedades_Localidades
    FOREIGN KEY (IdLocalidad)
    REFERENCES dbo.Localidades (IdLocalidad)
go
ALTER TABLE dbo.Propiedades
    ADD CONSTRAINT FK_Propiedades_Monedas
    FOREIGN KEY (ValorMercadoMoneda)
    REFERENCES dbo.Monedas (IdMoneda)
go
ALTER TABLE dbo.Propiedades
    ADD CONSTRAINT FK_Propiedades_Monedas1
    FOREIGN KEY (ValorPublicacionMoneda)
    REFERENCES dbo.Monedas (IdMoneda)
go
ALTER TABLE dbo.Propiedades
    ADD CONSTRAINT FK_Propiedades_Paises
    FOREIGN KEY (IdPais)
    REFERENCES dbo.Paises (IdPais)
go
ALTER TABLE dbo.Propiedades
    ADD CONSTRAINT FK_Propiedades_Provincias
    FOREIGN KEY (IdProvincia)
    REFERENCES dbo.Provincias (IdProvincia)
go
ALTER TABLE dbo.Propiedades
    ADD CONSTRAINT FK_Propiedades_TiposPropiedad
    FOREIGN KEY (IdTipoPropiedad)
    REFERENCES dbo.TiposPropiedad (IdTipoPropiedad)
go
ALTER TABLE dbo.PropiedadesOfrecidasXPedido
    ADD CONSTRAINT FK_PropiedadesOfrecidasXPedido_Pedidos
    FOREIGN KEY (IdPedido)
    REFERENCES dbo.Pedidos (IdPedido)
go
ALTER TABLE dbo.PropiedadesOfrecidasXPedido
    ADD CONSTRAINT FK_PropiedadesOfrecidasXPedido_Propiedades
    FOREIGN KEY (IdPropiedad)
    REFERENCES dbo.Propiedades (IdPropiedad)
go
ALTER TABLE dbo.Propietarios
    ADD CONSTRAINT FK_Propietarios_Clientes
    FOREIGN KEY (IdCliente)
    REFERENCES dbo.Clientes (IdCliente)
go
ALTER TABLE dbo.Provincias
    ADD CONSTRAINT FK_Provincias_Paises
    FOREIGN KEY (IdPais)
    REFERENCES dbo.Paises (IdPais)
go
ALTER TABLE dbo.Publicaciones
    ADD CONSTRAINT FK_Publicaciones_Monedas
    FOREIGN KEY (IdMoneda)
    REFERENCES dbo.Monedas (IdMoneda)
go
ALTER TABLE dbo.Publicaciones
    ADD CONSTRAINT FK_Publicaciones_Propiedades
    FOREIGN KEY (IdPropiedad)
    REFERENCES dbo.Propiedades (IdPropiedad)
go
ALTER TABLE dbo.Tasaciones
    ADD CONSTRAINT FK_Tasaciones_Monedas
    FOREIGN KEY (IdMonedaValorReal)
    REFERENCES dbo.Monedas (IdMoneda)
go
ALTER TABLE dbo.Tasaciones
    ADD CONSTRAINT FK_Tasaciones_Monedas1
    FOREIGN KEY (IdMonedaValorPublicacion)
    REFERENCES dbo.Monedas (IdMoneda)
go
ALTER TABLE dbo.Tasaciones
    ADD CONSTRAINT FK_Tasaciones_Propiedades
    FOREIGN KEY (IdPropiedad)
    REFERENCES dbo.Propiedades (IdPropiedad)
go
ALTER TABLE dbo.TiposPropiedad
    ADD CONSTRAINT FK_TiposPropiedad_CategoriasPropiedad
    FOREIGN KEY (IdCategoria)
    REFERENCES dbo.CategoriasPropiedad (IdCategoria)
go
ALTER TABLE dbo.Transaccion
    ADD CONSTRAINT FK_Transaccion_TipoTransaccion
    FOREIGN KEY (TipoTransaccion)
    REFERENCES dbo.TipoTransaccion (IdTipoTrans)
go
ALTER TABLE dbo.Transaccion
    ADD CONSTRAINT FK_Transaccion_TransaccionesPropiedad
    FOREIGN KEY (IdTransaccion)
    REFERENCES dbo.TransaccionesPropiedad (IdTransaccion)
go
ALTER TABLE dbo.TransaccionesFoto
    ADD CONSTRAINT FK_TransaccionesFoto_Propiedades
    FOREIGN KEY (IdPropiedad)
    REFERENCES dbo.Propiedades (IdPropiedad)
go
ALTER TABLE dbo.TransaccionesFoto
    ADD CONSTRAINT FK_TransaccionesFoto_Transaccion
    FOREIGN KEY (IdTransaccion)
    REFERENCES dbo.Transaccion (IdTransaccion)
go
ALTER TABLE dbo.TransaccionesPropiedad
    ADD CONSTRAINT FK_TransaccionesPropiedad_Propiedades
    FOREIGN KEY (IdPropiedad)
    REFERENCES dbo.Propiedades (IdPropiedad)
go
ALTER TABLE dbo.TransaccionesPropiedad
    ADD CONSTRAINT FK_TransaccionesPropiedad_Transaccion
    FOREIGN KEY (IdTransaccion)
    REFERENCES dbo.Transaccion (IdTransaccion)
go
ALTER TABLE dbo.ValoresRenta
    ADD CONSTRAINT FK_ValoresRenta_Contratos
    FOREIGN KEY (IdContrato)
    REFERENCES dbo.Contratos (IdContrato)
go
ALTER TABLE dbo.ValoresRenta
    ADD CONSTRAINT FK_ValoresRenta_Monedas
    FOREIGN KEY (IdMoneda)
    REFERENCES dbo.Monedas (IdMoneda)
go
ALTER TABLE dbo.Ventas
    ADD CONSTRAINT FK_Ventas_Propiedades
    FOREIGN KEY (IdPropiedad)
    REFERENCES dbo.Propiedades (IdPropiedad)
go
ALTER TABLE dbo.VisitasPropiedad
    ADD CONSTRAINT FK_VisitasPropiedad_Propiedades
    FOREIGN KEY (IdPropiedad)
    REFERENCES dbo.Propiedades (IdPropiedad)
go
IF @@TRANCOUNT > 0
	COMMIT TRANSACTION
ELSE
	print 'Transaction was rolled back due to an error'
