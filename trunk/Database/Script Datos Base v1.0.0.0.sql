--------------------------------------------------------------------------------
-- Embarcadero Change Manager Synchronization Script
-- FILE                : Sync.elcanoygeremia.com.ar.07_10_2008.11_13_18.sql
-- DATE                : 7/10/2008 11:13:18
-- 
-- SOURCE DATASOURCE   : pime.com.ar
-- TARGET DATASOURCE   : elcanoygeremia.com.ar
--------------------------------------------------------------------------------
SET XACT_ABORT ON

BEGIN TRANSACTION


USE [inmobiliariadb_eyg]
go
ALTER TABLE dbo.Barrios
    DROP CONSTRAINT FK_Barrios_Localidades
go
ALTER TABLE dbo.Localidades
    DROP CONSTRAINT FK_Localidades_Provincias
go
ALTER TABLE dbo.Provincias
    DROP CONSTRAINT FK_Provincias_Paises
go
ALTER TABLE dbo.TiposPropiedad
    DROP CONSTRAINT FK_TiposPropiedad_CategoriasPropiedad
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
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  10, 'Acassuso', 1, 3 )
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
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  16, 'Don Torcuaro', 1, 18 )
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
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  27, 'San Fernando', 1, 15 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  28, 'Victoria', 0, 15 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  29, 'Virreyes', 0, 15 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  30, 'Islas', 0, 15 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  31, 'Bº El Cazador', 1, 19 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  32, 'San Martín', 1, 16 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  33, 'Jose León Suarez', 0, 16 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  34, 'Villa Ballester', 0, 16 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  35, 'Olivos Roche', 0, 1 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  36, 'San Bernardo', 1, 26 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  37, 'Mar de Ajó', 0, 26 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  38, 'La Lucila', 0, 26 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  39, 'Miramar', 1, 27 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  40, 'Santos Lugares', 0, 29 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  41, 'Munro Oeste', 0, 1 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  42, 'Olivos Golf', 0, 1 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  43, 'Olivos Rugby', 0, 1 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  44, 'V. Martelli - Bº Parque', 0, 1 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  45, 'Lomas de San Isidro', 0, 3 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  46, 'Avellaneda', 1, 4 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  47, 'Cinturón Ecologico', 0, 4 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  48, 'Crucesita', 0, 4 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  49, 'Dock Sud', 0, 4 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  50, 'Gerli', 0, 4 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  51, 'Piñeiro', 0, 4 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  52, 'Sarandi', 0, 4 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  53, 'Villa Dominico', 0, 4 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  54, 'Wilde', 0, 4 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  55, 'Aeropuerto', 1, 5 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  56, 'Ezeiza', 0, 5 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  57, 'Jorge Canning', 0, 5 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  58, 'La Union', 0, 5 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  59, 'Máximo Paz', 0, 5 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  60, 'Spegazzini', 0, 5 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  61, 'Tristán Suarez', 0, 5 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  62, 'Bº San Alberto', 1, 6 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  63, 'Ituzaingó Norte', 0, 6 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  64, 'Ituzaingó Sur', 0, 6 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  65, 'Ituzaingó', 0, 6 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  66, 'Parque Leloir', 0, 6 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  67, 'Villa Irupé', 0, 6 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  68, 'Villa Udaondo', 0, 6 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  69, '20 de junio', 1, 7 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  70, 'Aldo Bonzi', 0, 7 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  71, 'C. Martin Güemes', 0, 7 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  72, 'Ciudad evita', 0, 7 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  73, 'Ciudadela Sur', 0, 7 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  74, 'Gonzalez Catán', 0, 7 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  75, 'Isidro casanova', 0, 7 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  76, 'La Tablada', 0, 7 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  77, 'Laferrere', 0, 7 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  78, 'Lomas del millón', 0, 7 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  79, 'Lomas del Mirador', 0, 7 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  80, 'Puente Escurra', 0, 7 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  81, 'Rafael Castillo Sur', 0, 7 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  82, 'Ramos Mejía', 0, 7 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  83, 'San Justo', 0, 7 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  84, 'Tapiales', 0, 7 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  85, 'Villa Celina', 0, 7 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  86, 'Villa Insuperable', 0, 7 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  87, 'Villa Luzuriaga', 0, 7 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  88, 'Villa Madero', 0, 7 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  89, 'Virrey del Pino', 0, 7 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  90, 'Gerli', 1, 8 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  91, 'Lanus', 0, 8 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  92, 'Lanus Este', 0, 8 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  93, 'Lanus Oeste', 0, 8 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  94, 'Monte chingolo', 0, 8 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  95, 'Remedios de Escalada', 0, 8 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  96, 'Villa Gral. Belgrano', 0, 8 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  97, 'Valentín Alsina', 0, 8 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  98, 'Banfield', 1, 9 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  99, 'Centenario', 0, 9 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  100, 'Fiorito', 0, 9 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  101, 'Lomas de Zamora', 0, 9 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  102, 'Lavallol', 0, 9 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  103, 'Temperley', 0, 9 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  104, 'Turdera', 0, 9 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  105, 'C. Mariano Acosta', 1, 10 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  106, 'Ferrari', 0, 10 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  107, 'Libertad', 0, 10 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  108, 'Merlo', 0, 10 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  109, 'Parque San Martín', 0, 10 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  110, 'Pte. Cascallares', 0, 10 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  111, 'San A. de Padua', 0, 10 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  112, 'Zona rural', 0, 10 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  113, 'B. P. Gaona', 1, 11 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  114, 'Cuartel V', 0, 11 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  115, 'Francisco Alvarez', 0, 11 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  116, 'La Reja', 0, 11 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  117, 'Moreno', 0, 11 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  118, 'Paso del Rey', 0, 11 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  119, 'Trujuy', 0, 11 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  120, 'Villa Malaver', 0, 11 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  121, 'Zona Rural', 0, 11 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  122, 'Castelar', 1, 12 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  123, 'El Palomar', 0, 12 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  124, 'Haedo', 0, 12 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  125, 'Moron', 0, 12 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  126, 'R. Castillo', 0, 12 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  127, 'V. Leon', 0, 12 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  128, 'V. Udaondo', 0, 12 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  129, 'Villa Sarmiento', 0, 12 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  130, 'Bº Astolfi', 1, 13 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  131, 'Bº los Cachorros', 0, 13 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  132, 'Bº  de Vicenso', 0, 13 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  133, 'Bº Rio Lujan', 0, 13 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  134, 'Bº  Solares Norte', 0, 13 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  135, 'Del Viso', 0, 13 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  136, 'Fátima', 0, 13 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  137, 'J. Vucetich', 0, 13 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  138, 'La lonja', 0, 13 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  139, 'Manzanares', 0, 13 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  140, 'Manzone', 0, 13 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  141, 'Mf. Savio Oeste', 0, 13 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  142, 'Pilar', 0, 13 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  143, 'Pte. Derqui', 0, 13 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  144, 'Santa Teresa', 0, 13 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  145, 'Toro', 0, 13 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  146, 'Villa Rosa', 0, 13 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  147, 'Zelaya', 0, 13 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  148, 'Bernal', 1, 14 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  149, 'Don Bosco', 0, 14 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  150, 'Espeleta', 0, 14 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  151, 'Quilmes Este', 0, 14 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  152, 'Quilmes Oeste', 0, 14 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  153, 'Quilmes Sur', 0, 14 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  154, 'San Francisco Solano', 0, 14 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  155, 'Villa La Florida', 0, 14 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  156, 'Punta Chica', 0, 15 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  157, 'Carupa', 0, 15 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  158, 'Santa Clara', 0, 15 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  159, 'Vilas', 0, 15 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  160, 'Ayacucho', 0, 16 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  161, 'Billinghurst', 0, 16 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  162, 'Ciudad Jardin', 0, 16 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  163, 'Gral. Guido', 0, 16 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  164, 'San Andrés ', 0, 16 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  165, 'Villa Alcorta', 0, 16 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  166, 'Malaver', 0, 16 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  167, 'Villa Cnel. Zapiola', 0, 16 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  168, 'Villa Chacabuco', 0, 16 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  169, 'Villa Godoy Cruz', 0, 16 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  170, 'Villa Gral. Las Heras', 0, 16 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  171, 'Villa Gral. Sucre', 0, 16 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  172, 'Villa Granaderos Gra', 0, 16 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  173, 'Villa Gregoria Mator', 0, 16 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  174, 'Villa Libertad', 0, 16 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  175, 'Villa Lynch', 0, 16 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  176, 'Villa M. de Aguado', 0, 16 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  177, 'Villa Maipú', 0, 16 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  178, 'Villa San Lorenzo', 0, 16 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  179, 'Villa Yapeyú', 0, 16 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  180, 'Villa Monteagudo', 0, 16 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  181, 'Bella Vista', 1, 17 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  182, 'C. de Mayo', 0, 17 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  183, 'Muñiz', 0, 17 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  184, 'San Miguel', 0, 17 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  185, 'Islas del Delta', 0, 18 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  186, 'Islas', 0, 18 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  187, 'B. Pacheco', 0, 18 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  188, 'B. El Zorzal', 0, 18 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  189, 'L. Carmelo', 0, 18 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  190, 'L. Tunas', 0, 18 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  191, 'B. Caupá', 0, 18 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  192, 'Ciudad', 0, 18 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  193, 'Villa La Ñata', 0, 18 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  194, 'San Marco', 0, 18 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  195, 'Santa Tersesa', 0, 18 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  196, 'Santa Francisco', 0, 18 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  197, 'San Agustin', 0, 18 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  198, 'San Gabriel', 0, 18 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  199, 'San Benito', 0, 18 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  200, 'San Rafael', 0, 18 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  201, 'La Escondida', 0, 18 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  202, 'Bº San Luis', 0, 19 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  203, 'Bº Aranjuez', 0, 19 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  204, 'Bº Campo Chico', 0, 19 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  205, 'Bº Loma Verde', 0, 19 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  206, 'Bº Náutico', 0, 19 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  207, 'Bº Santa María', 0, 19 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  208, 'Escobar', 0, 19 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  209, 'Garin', 0, 19 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  210, 'Islas del Delta', 0, 19 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  211, 'Loma Verde', 0, 19 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  212, 'Maquinista Savio', 0, 19 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  213, 'Maschwitz', 0, 19 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  214, 'Matheu', 0, 19 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  215, '11 de Septiembre', 1, 29 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  216, 'Ciudad Jardín', 0, 29 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  217, 'M. Coronado', 0, 29 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  218, 'Pablo Podestá', 0, 29 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  219, 'Villa Bosh', 0, 29 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  220, 'Palomar', 0, 29 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  221, 'Caseros', 0, 29 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  222, 'Ciudadela', 0, 29 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  223, 'Churruca', 0, 29 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  224, 'El libertador', 0, 29 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  225, 'Jose Ingenieros', 0, 29 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  226, 'Loma Hermosa', 0, 29 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  227, 'Partido 3 de Febrero', 0, 29 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  228, 'Remedios de Escalada', 0, 29 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  229, 'Saenz Peña', 0, 29 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  231, 'Villa Raffo', 0, 29 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  232, 'Adrogué', 1, 191 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  233, 'Bº San jose', 0, 191 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  234, 'Burzaco', 0, 191 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  235, 'Claypole', 0, 191 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  236, 'Glew', 0, 191 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  237, 'Jose Marmol', 0, 191 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  238, 'Longchamps', 0, 191 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  239, 'Malvinas Argentinas', 0, 191 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  240, 'Ministro Rivadavia', 0, 191 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  241, 'Partido Alte. Bron', 0, 191 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  242, 'Rafael Calzada', 0, 191 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  243, 'San Francisco Solano', 0, 191 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  244, 'Zona Rural', 0, 191 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  245, 'Berazategui', 1, 30 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  246, 'Carlos Sourigues', 0, 30 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  247, 'El Pato', 0, 30 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  248, 'Hudson', 0, 30 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  249, 'Jose M. Gutierrez', 0, 30 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  250, 'Pereyra', 0, 30 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  251, 'Pereyra Iraola', 0, 30 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  252, 'Platanos', 0, 30 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  253, 'Ranelagh', 0, 30 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  254, 'Villa España', 0, 30 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  255, 'Zona Rural', 0, 30 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  256, '9 de Abril', 1, 31 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  257, 'Canning', 0, 31 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  258, 'Ezeiza', 0, 31 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  259, 'El Jaguel', 0, 31 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  260, 'I. Budge', 0, 31 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  261, 'Longchamps', 0, 31 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  262, 'Luis Guillon', 0, 31 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  263, 'Monte Grande', 0, 31 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  264, 'P. San Sebastian', 0, 31 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  265, 'Pda. Union Ferroviaria', 0, 31 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  266, 'Santa Catalina', 0, 31 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  267, 'Bosques', 1, 32 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  268, 'Estanislao Cavalloz', 0, 32 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  269, 'Florencio Varela', 0, 32 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  270, 'Gobernador Julio A.', 0, 32 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  271, 'Ingeniero Juan Allan', 0, 32 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  272, 'La Capilla', 0, 32 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  273, 'La Carolina', 0, 32 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  274, 'Santa Rosa', 0, 32 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  275, 'Villa Brown', 0, 32 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  276, 'Villa San Luis', 0, 32 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  277, 'Villa Vatteone', 0, 32 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  278, 'Hurlingam', 1, 33 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  279, 'Villa Tesei', 0, 33 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  280, 'William Morris', 0, 33 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  281, 'José C. Paz', 1, 34 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  282, 'San Miguel', 0, 34 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  283, 'Tortuguitas', 0, 34 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  284, 'Vucetich', 0, 34 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  285, 'Gran Bourg', 1, 35 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  286, 'Ingeniero Pablo Nogues', 0, 35 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  287, 'Los Polvorines', 0, 35 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  288, 'Sordeaux', 0, 35 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  289, 'Tortuguitas', 0, 35 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  290, 'Villa de Mayo', 0, 35 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  291, 'Recoleta', 1, 20 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  292, 'Belgrano centro', 1, 24 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  293, 'Belgrano Chico', 0, 24 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  294, 'Belgrano R', 0, 24 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  295, 'Barrancas', 0, 24 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  296, 'Las Cañitas', 0, 24 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  297, 'Once', 1, 39 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  298, 'Puerto Madero', 1, 44 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  299, 'Catalinas', 0, 44 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  300, 'Tribunales', 0, 44 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  301, 'Microcentro', 0, 44 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  302, 'Monserrat', 0, 44 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  303, 'Retiro', 0, 44 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  304, 'San Nicolás', 0, 44 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  305, 'Palermo Viejo', 1, 25 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  306, 'Palermo Chico', 0, 25 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  307, 'Botanico', 0, 25 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  308, 'Palermo Hollywood', 0, 25 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  309, 'Palermo Soho', 0, 25 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  310, 'Bº P. Urquiza', 1, 28 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  311, 'P. Chas', 0, 28 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  312, 'Urquiza R.', 0, 28 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  313, 'Aguas Verdes', 0, 26 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  314, 'Costa del Este', 0, 26 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  315, 'Costa Esmeralda', 0, 26 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  316, 'La Lucila', 0, 26 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  317, 'Las Toninas', 0, 26 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  318, 'Mar de Ajó', 0, 26 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  319, 'Mar Azul', 0, 26 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  320, 'Mar del Tuyú', 0, 26 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  321, 'Montecarlo', 0, 26 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  322, 'Nueva Atlantis', 0, 26 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  323, 'Pinar del Sol', 0, 26 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  324, 'San Bernardo', 0, 26 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  325, 'San Clemente del Tuyu', 0, 26 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  326, 'Santa Teresita', 0, 26 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  327, 'Munro Este', 0, 1 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  328, 'Saavedra', 1, 21 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  329, 'Nuñez', 1, 22 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  330, 'Coghlan', 1, 23 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  331, 'Abasto', 1, 36 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  332, 'Agronomia', 1, 37 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  333, 'Almagro', 1, 38 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  334, 'Barracas', 1, 40 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  335, 'Boca', 1, 41 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  336, 'Boedo', 1, 42 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  337, 'Caballito', 1, 43 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  338, 'Colegiales', 1, 45 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  339, 'Congreso', 1, 46 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  340, 'Constitución', 1, 47 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  341, 'Chacarita', 1, 48 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  342, 'Flores', 1, 49 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  343, 'Floresta', 1, 50 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  344, 'Liniers', 1, 51 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  345, 'Mataderos', 1, 52 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  346, 'Parque Centenario', 1, 53 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  347, 'Parque Chacabuco', 1, 54 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  348, 'Parque Patricios', 1, 55 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  349, 'Paternal', 1, 56 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  350, 'Pompeya', 1, 57 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  351, 'San Cristobal', 1, 58 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  352, 'San Telmo', 1, 59 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  353, 'Versailles', 1, 60 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  354, 'Villa Crespo', 1, 61 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  355, 'Villa del Parque', 1, 62 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  356, 'Villa Devoto', 1, 63 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  357, 'Villa Gral. Mitre', 1, 64 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  358, 'Villa lugano', 1, 65 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  359, 'Villa Luro', 1, 66 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  360, 'Villa Ortuzar', 1, 67 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  361, 'Villa Pueyrredón', 1, 68 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  362, 'Villa Real', 1, 69 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  363, 'Riachuelo', 1, 70 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  364, 'Villa Soldati', 1, 71 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  365, 'Adolfo Alsina', 1, 73 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  366, 'Alberti', 1, 74 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  367, 'Arrecifes', 1, 75 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  368, 'Ayacucho', 1, 76 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  369, 'Azul', 1, 77 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  370, 'Bahia Blanca', 1, 78 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  371, 'Balcarce', 1, 79 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  372, 'Baradero', 1, 80 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  373, 'Benito Juarez', 1, 81 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  374, 'Berisso', 1, 82 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  375, 'Bragado', 1, 83 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  376, 'Bolivar', 1, 84 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  377, 'Campana', 1, 85 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  378, 'Cañuelas', 1, 86 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  379, 'Capitan Sarmiento', 1, 87 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  380, 'Carlos Casares', 1, 88 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  381, 'Carlos Tejedor', 1, 89 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  382, 'Carmen de Areco', 1, 90 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  383, 'Castelli', 1, 91 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  384, 'Colon', 1, 92 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  385, 'Brandsen', 1, 93 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  386, 'Coronel Dorrego', 1, 94 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  387, 'Coronel Pringles', 1, 95 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  388, 'Coronel Rosales', 1, 96 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  389, 'Coronel Suarez', 1, 97 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  390, 'Chacabuco', 1, 98 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  391, 'Chascomus', 1, 99 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  392, 'Chivilcoy', 1, 100 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  393, 'Daireaux', 1, 101 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  394, 'Dolores', 1, 102 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  395, 'Ensenada', 1, 103 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  396, 'Exaltación de la Cruz', 1, 104 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  397, 'Florentino Ameghino', 1, 105 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  398, 'General Alvear', 1, 106 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  399, 'General Arenales', 1, 107 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  400, 'General Belgrano', 1, 108 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  401, 'General Lamadrid', 1, 109 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  402, 'General Las heras', 1, 110 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  403, 'General Lavalle', 1, 111 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  404, 'General Madariaga', 1, 112 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  405, 'General Paz', 1, 113 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  406, 'General Pinto', 1, 114 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  407, 'General Pueyrredon', 1, 115 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  408, 'General Rodriguez', 1, 116 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  409, 'General Viamonte', 1, 117 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  410, 'General Villegas', 1, 118 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  411, 'Guamini', 1, 119 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  412, 'Hipolito Irigoyen', 1, 120 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  413, 'Junin', 1, 121 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  414, 'La Plata', 1, 122 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  415, 'Laprida', 1, 123 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  416, 'Las Flores', 1, 124 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  417, 'Leandro N. Alem', 1, 125 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  418, 'Lincoln', 1, 126 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  419, 'Loberia', 1, 127 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  420, 'Lobos', 1, 128 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  421, 'Lujan', 1, 129 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  422, 'Magdalena', 1, 130 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  423, 'Maipú', 1, 131 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  424, 'Mar Chiquita', 1, 132 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  425, 'Marcos Paz', 1, 133 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  426, 'Mercedes', 1, 134 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  427, 'Monte', 1, 135 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  428, 'Monte Hermoso', 1, 136 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  429, 'Navarro', 1, 137 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  430, 'Necochea', 1, 138 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  431, 'Ninguno', 1, 139 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  432, '9 de Julio', 1, 140 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  433, 'Olavarria', 1, 141 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  434, 'Patagones', 1, 142 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  435, 'Pehuajo', 1, 143 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  436, 'Pellegrini', 1, 144 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  437, 'Pergamino', 1, 145 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  438, 'Pila', 1, 146 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  439, 'Puan', 1, 147 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  440, 'Presidente Peron', 1, 148 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  441, 'Punta Indio', 1, 149 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  442, 'Ramallo', 1, 150 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  443, 'Rivadavia', 1, 151 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  444, 'Rojas ', 1, 152 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  445, 'Roque Perez', 1, 153 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  446, 'Saavedra', 1, 154 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  447, 'Saladillo', 1, 155 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  448, 'Salto', 1, 156 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  449, 'Salliquelo', 1, 157 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  450, 'San Andres de Giles', 1, 158 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  451, 'San Antonio de Areco', 1, 159 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  452, 'San Cayetano', 1, 160 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  453, 'San Nicolas', 1, 161 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  454, 'San Pedro', 1, 162 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  455, 'San Vicente', 1, 163 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  456, 'Suipacha', 1, 164 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  457, 'Tandil', 1, 165 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  458, 'Topalque', 1, 166 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  459, 'Toldillo', 1, 167 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  460, 'Tornquist', 1, 168 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  461, 'Trenque Lauquen', 1, 169 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  462, 'Tres Arroyos', 1, 170 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  463, 'Tres Lomas', 1, 171 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  464, '25 de Mayo', 1, 172 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  465, 'Villarino', 1, 173 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  466, 'Zarate', 1, 174 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  467, 'Pinamar', 1, 175 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  468, 'Cariló', 1, 176 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  469, 'Valeria del Mar', 1, 177 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  470, 'Villa Gesell', 1, 178 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  471, 'Mar de las Pampas', 1, 179 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  472, 'Mar Chiquita', 1, 180 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  473, 'Santa Clara', 1, 181 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  474, 'Mar del Plata', 1, 182 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  475, 'Miramar', 1, 183 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  476, 'Mar del Sur', 1, 184 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  477, 'Necochea', 1, 185 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  478, 'San Cayetano', 1, 186 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  479, 'Orense', 1, 187 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  480, 'Claromecó', 1, 188 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  481, 'Monte Hermoso', 1, 189 )
go
INSERT INTO [dbo].[Barrios] ( [IdBarrio], [Nombre], [Default], [IdLocalidad] ) VALUES(  482, 'Chapadmalal', 1, 190 )
go
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
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  20, 'Barrio Norte', 1, 3 )
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
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  26, 'Partido de la Costa', 0, 26 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  27, 'Gral. Albarado', 1, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  28, 'Villa Urquiza', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  29, '3 de Febrero', 0, 1 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  30, 'Berazategui', 0, 1 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  31, 'Esteban Echeverria', 0, 1 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  32, 'Florencio Varela', 0, 1 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  33, 'Hurlingam', 0, 1 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  34, 'José C. Paz', 0, 1 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  35, 'Malvinas Argentinas', 0, 1 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  36, 'Abasto', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  37, 'Agronomia', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  38, 'Almagro', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  39, 'Balbanera', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  40, 'Barracas', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  41, 'Boca', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  42, 'Boedo', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  43, 'Caballito', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  44, 'Centro', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  45, 'Colegiales', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  46, 'Congreso', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  47, 'Constitución', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  48, 'Chacarita', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  49, 'Flores', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  50, 'Floresta', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  51, 'Liniers', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  52, 'Mataderos', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  53, 'Parque Centenario', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  54, 'Parque Chacabuco', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  55, 'Parque Patricios', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  56, 'Paternal', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  57, 'Pompeya', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  58, 'San Cristobal', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  59, 'San Telmo', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  60, 'Versailles', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  61, 'Villa Crespo', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  62, 'Villa del Parque', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  63, 'Villa Devoto', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  64, 'Villa Gral. Mitre', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  65, 'Villa lugano', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  66, 'Villa Luro', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  67, 'Villa Ortuzar', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  68, 'Villa Pueyrredón', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  69, 'Villa Real', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  70, 'Riachuelo', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  71, 'Villa Soldati', 0, 3 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  73, 'Adolfo Alsina', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  74, 'Alberti', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  75, 'Arrecifes', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  76, 'Ayacucho', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  77, 'Azul', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  78, 'Bahia Blanca', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  79, 'Balcarce', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  80, 'Baradero', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  81, 'Benito Juarez', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  82, 'Berisso', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  83, 'Bragado', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  84, 'Bolivar', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  85, 'Campana', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  86, 'Cañuelas', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  87, 'Capitan Sarmiento', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  88, 'Carlos Casares', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  89, 'Carlos Tejedor', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  90, 'Carmen de Areco', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  91, 'Castelli', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  92, 'Colon', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  93, 'Brandsen', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  94, 'Coronel Dorrego', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  95, 'Coronel Pringles', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  96, 'Coronel Rosales', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  97, 'Coronel Suarez', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  98, 'Chacabuco', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  99, 'Chascomus', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  100, 'Chivilcoy', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  101, 'Daireaux', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  102, 'Dolores', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  103, 'Ensenada', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  104, 'Exaltación de la Cruz', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  105, 'Florentino Ameghino', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  106, 'General Alvear', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  107, 'General Arenales', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  108, 'General Belgrano', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  109, 'General Lamadrid', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  110, 'General Las heras', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  111, 'General Lavalle', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  112, 'General Madariaga', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  113, 'General Paz', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  114, 'General Pinto', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  115, 'General Pueyrredon', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  116, 'General Rodriguez', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  117, 'General Viamonte', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  118, 'General Villegas', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  119, 'Guamini', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  120, 'Hipolito Irigoyen', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  121, 'Junin', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  122, 'La Plata', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  123, 'Laprida', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  124, 'Las Flores', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  125, 'Leandro N. Alem', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  126, 'Lincoln', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  127, 'Loberia', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  128, 'Lobos', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  129, 'Lujan', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  130, 'Magdalena', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  131, 'Maipú', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  132, 'Mar Chiquita', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  133, 'Marcos Paz', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  134, 'Mercedes', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  135, 'Monte', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  136, 'Monte Hermoso', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  137, 'Navarro', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  138, 'Necochea', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  139, 'Ninguno', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  140, '9 de Julio', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  141, 'Olavarria', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  142, 'Patagones', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  143, 'Pehuajo', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  144, 'Pellegrini', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  145, 'Pergamino', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  146, 'Pila', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  147, 'Puan', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  148, 'Presidente Peron', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  149, 'Punta Indio', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  150, 'Ramallo', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  151, 'Rivadavia', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  152, 'Rojas ', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  153, 'Roque Perez', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  154, 'Saavedra', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  155, 'Saladillo', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  156, 'Salto', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  157, 'Salliquelo', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  158, 'San Andres de Giles', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  159, 'San Antonio de Areco', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  160, 'San Cayetano', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  161, 'San Nicolas', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  162, 'San Pedro', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  163, 'San Vicente', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  164, 'Suipacha', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  165, 'Tandil', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  166, 'Topalque', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  167, 'Toldillo', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  168, 'Tornquist', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  169, 'Trenque Lauquen', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  170, 'Tres Arroyos', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  171, 'Tres Lomas', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  172, '25 de Mayo', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  173, 'Villarino', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  174, 'Zarate', 0, 2 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  175, 'Pinamar', 1, 26 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  176, 'Cariló', 0, 26 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  177, 'Valeria del Mar', 0, 26 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  178, 'Villa Gesell', 0, 26 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  179, 'Mar de las Pampas', 0, 26 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  180, 'Mar Chiquita', 0, 26 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  181, 'Santa Clara', 0, 26 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  182, 'Mar del Plata', 0, 26 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  183, 'Miramar', 0, 26 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  184, 'Mar del Sur', 0, 26 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  185, 'Necochea', 0, 26 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  186, 'San Cayetano', 0, 26 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  187, 'Orense', 0, 26 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  188, 'Claromecó', 0, 26 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  189, 'Monte Hermoso', 0, 26 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  190, 'Chapadmalal', 0, 26 )
go
INSERT INTO [dbo].[Localidades] ( [IdLocalidad], [Nombre], [Default], [IdProvincia] ) VALUES(  191, 'Almirante Brown', 0, 1 )
go
INSERT INTO [dbo].[Monedas] ( [IdMoneda], [Nombre], [Simbolo] ) VALUES(  1, 'Pesos', '$' )
go
INSERT INTO [dbo].[Monedas] ( [IdMoneda], [Nombre], [Simbolo] ) VALUES(  2, 'Dolares', 'USD' )
go
INSERT INTO [dbo].[Monedas] ( [IdMoneda], [Nombre], [Simbolo] ) VALUES(  3, 'Euros', '£' )
go
INSERT INTO [dbo].[Paises] ( [IdPais], [Nombre], [Default] ) VALUES(  1, 'Argentina', 1 )
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
INSERT INTO [dbo].[Provincias] ( [IdProvincia], [Nombre], [Default], [IdPais] ) VALUES(  26, 'Costa Atlántica', 0, 1 )
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

USE [inmobiliariadb_eyg]
go
ALTER TABLE dbo.Barrios
    ADD CONSTRAINT FK_Barrios_Localidades
    FOREIGN KEY (IdLocalidad)
    REFERENCES dbo.Localidades (IdLocalidad)
go
ALTER TABLE dbo.Localidades
    ADD CONSTRAINT FK_Localidades_Provincias
    FOREIGN KEY (IdProvincia)
    REFERENCES dbo.Provincias (IdProvincia)
go
ALTER TABLE dbo.Provincias
    ADD CONSTRAINT FK_Provincias_Paises
    FOREIGN KEY (IdPais)
    REFERENCES dbo.Paises (IdPais)
go
ALTER TABLE dbo.TiposPropiedad
    ADD CONSTRAINT FK_TiposPropiedad_CategoriasPropiedad
    FOREIGN KEY (IdCategoria)
    REFERENCES dbo.CategoriasPropiedad (IdCategoria)
go
IF @@TRANCOUNT > 0
	COMMIT TRANSACTION
ELSE
	print 'Transaction was rolled back due to an error'
