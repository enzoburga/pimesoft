
create PROCEDURE [dbo].[Pedidos_RecuperarPorId] 
(
	@IdPedido int
)
AS
SELECT p.[IdPedido]
      ,p.[CantidadAmbientesFinal]
      ,p.[CantidadAmbientesInicial]
      ,p.[IdCategoria]
      ,p.[IdCliente]
      ,p.[Disposicion]
      ,p.[EnumEstado]
      ,p.[EsAptoProfesional]
      ,p.[IdEstadoPropiedad]
      ,p.[EstadoPropiedad]
      ,p.[MetrosConstruiblesFinal]
      ,p.[MetrosConstruiblesInicial]
      ,p.[MetrosCubiertosFinal]
      ,p.[MetrosCubiertosInicial]
      ,p.[MetrosTerrenoFinal]
      ,p.[MetrosTerrenoInicial]
      ,p.[IdTipoPropiedad]
      ,p.[TipoZona]
      ,p.[IdBarrio]
      ,p.[IdLocalidad]
      ,p.[IdPais]
      ,p.[IdProvincia]
      ,p.[ImporteFinal]
      ,p.[ImporteInicial]
      ,p.[IdMoneda]
	  ,p.Observaciones
	  ,p.Activo
	  ,p.FechaAlta
	  ,cat.Nombre as NombreCategoria
  FROM Pedidos p, CategoriasPropiedad cat
where cat.IdCategoria =* p.IdCategoria and p.IdPedido = @IdPedido



/********************************************************************/

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON


