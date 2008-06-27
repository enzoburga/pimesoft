
INSERT INTO [dbo].[CategoriasPropiedad] ( [IdCategoria], [Nombre] ) VALUES(  1, 'Vivienda' )
go
INSERT INTO [dbo].[CategoriasPropiedad] ( [IdCategoria], [Nombre] ) VALUES(  2, 'Comercial' )
go
INSERT INTO [dbo].[CategoriasPropiedad] ( [IdCategoria], [Nombre] ) VALUES(  3, 'Especial' )
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



INSERT INTO [dbo].[Monedas] ( [IdMoneda], [Nombre], [Simbolo] ) VALUES(  1, 'Pesos', '$' )
go
INSERT INTO [dbo].[Monedas] ( [IdMoneda], [Nombre], [Simbolo] ) VALUES(  2, 'Dolares', 'USD' )
go
INSERT INTO [dbo].[Monedas] ( [IdMoneda], [Nombre], [Simbolo] ) VALUES(  3, 'Euros', '£' )
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

