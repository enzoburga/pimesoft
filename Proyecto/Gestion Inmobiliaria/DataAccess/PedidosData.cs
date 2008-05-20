using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace GI.DA
{
    public class PedidosData
    {
  

        public bool Actualizar(
            int IdPedido,
            Nullable<decimal> CantidadAmbientesFinal,
            Nullable<decimal> CantidadAmbientesInicial,
            Nullable<int> IdCategoria,
            int IdCliente,
            Nullable<int> Disposicion,
            Nullable<int> EnumEstado,
            Nullable<bool> EsAptoProfesional,
            Nullable<int> IdEstadoPropiedad,
            Type EstadoPropiedad,
            int MetrosConstruiblesFinal,
            int MetrosConstruiblesInicial,
            int MetrosCubiertosFinal,
            int MetrosCubiertosInicial,
            int MetrosTerrenoFinal,
            int MetrosTerrenoInicial,
            Nullable<int> IdTipoPropiedad,
            Nullable<int> TipoZona,
            Nullable<int> IdBarrio,
            Nullable<int> IdLocalidad,
            Nullable<int> IdPais,
            Nullable<int> IdProvincia,
            Nullable<decimal> ImporteFinal,
            Nullable<decimal> ImporteInicial,
            Nullable<int> IdMoneda,
            string observaciones,
            bool activo)
        {

            object cantidadAmbientesFinal = CantidadAmbientesFinal;
            if (null == CantidadAmbientesFinal)
                cantidadAmbientesFinal = System.DBNull.Value;

            object cantidadAmbientesInicial = CantidadAmbientesInicial;
            if (null == CantidadAmbientesInicial)
                cantidadAmbientesInicial = System.DBNull.Value;

            object idCategoria = IdCategoria;
            if (!IdCategoria.HasValue)
                idCategoria = System.DBNull.Value;

            object disposicion = Disposicion;
            if (!Disposicion.HasValue)
                disposicion = System.DBNull.Value;

            object enumEstado = EnumEstado;
            if (!EnumEstado.HasValue)
                enumEstado = System.DBNull.Value;

            object esAptoProfesional = EsAptoProfesional;
            if (!EsAptoProfesional.HasValue)
                esAptoProfesional = System.DBNull.Value;

            object idEstadoPropiedad = IdEstadoPropiedad;
            if (!IdEstadoPropiedad.HasValue)
                idEstadoPropiedad = System.DBNull.Value;

            object metrosConstruiblesFinal = MetrosConstruiblesFinal;
            if (0 == MetrosConstruiblesFinal)
                metrosConstruiblesFinal = System.DBNull.Value;

            object metrosCubiertosFinal = MetrosCubiertosFinal;
            if (0 == MetrosCubiertosFinal)
                metrosCubiertosFinal = System.DBNull.Value;

            object metrosTerrenoFinal = MetrosTerrenoFinal;
            if (0 == MetrosTerrenoFinal)
                metrosTerrenoFinal = System.DBNull.Value;

            object idTipoPropiedad = IdTipoPropiedad;
            if (!IdTipoPropiedad.HasValue)
                idTipoPropiedad = System.DBNull.Value;

            object tipoZona = TipoZona;
            if (!TipoZona.HasValue)
                tipoZona = System.DBNull.Value;

            object importeFinal = ImporteFinal;
            if (!ImporteFinal.HasValue)
                importeFinal = System.DBNull.Value;

            object importeInicial = ImporteInicial;
            if (!ImporteInicial.HasValue)
                importeInicial = System.DBNull.Value;

            object idMoneda = IdMoneda;
            if (!IdMoneda.HasValue)
                idMoneda = System.DBNull.Value;

            object idBarrio = IdBarrio;
            if (!IdBarrio.HasValue)
                idBarrio = System.DBNull.Value;

            object idLocalidad = IdLocalidad;
            if (!IdLocalidad.HasValue)
                idLocalidad = System.DBNull.Value;

            object idPais = IdPais;
            if (!IdPais.HasValue)
                idPais = System.DBNull.Value;

            object idProvincia = IdProvincia;
            if (!IdProvincia.HasValue)
                idProvincia = System.DBNull.Value;
            
            
            return AccesoDatos.ActualizarRegistro(
                "Pedido_Actualizar",
                new object[] {   
                    IdPedido,
                    cantidadAmbientesFinal,
                    cantidadAmbientesInicial,
                    idCategoria,
                    IdCliente,
                    disposicion,
                    enumEstado,
                    esAptoProfesional,
                    idEstadoPropiedad,
                    EstadoPropiedad.ToString(),
                    metrosConstruiblesFinal, MetrosConstruiblesInicial,
                    metrosCubiertosFinal, MetrosCubiertosInicial,
                    metrosTerrenoFinal, MetrosTerrenoInicial,
                    idTipoPropiedad,
                    tipoZona,
                    idBarrio,
                    idLocalidad,
                    idPais,
                    idProvincia,
                    importeFinal,
                    importeInicial,
                    idMoneda,
                    observaciones,
                    activo},
                new string[] {    
                    "@IdPedido",
                    "@CantidadAmbientesFinal",
                    "@CantidadAmbientesInicial",
                    "@IdCategoria",
                    "@IdCliente",
                    "@Disposicion",
                    "@EnumEstado",
                    "@EsAptoProfesional",
                    "@IdEstadoPropiedad",
                    "@EstadoPropiedad",
                    "@MetrosConstruiblesFinal",
                    "@MetrosConstruiblesInicial",
                    "@MetrosCubiertosFinal", 
                    "@MetrosCubiertosInicial",
                    "@MetrosTerrenoFinal", 
                    "@MetrosTerrenoInicial",
                    "@IdTipoPropiedad",
                    "@TipoZona",
                    "@IdBarrio",
                    "@IdLocalidad",
                    "@IdPais",
                    "@IdProvincia",
                    "@ImporteFinal",
                    "@ImporteInicial",
                    "@IdMoneda",
                    "@Observaciones",
                    "@Activo"});
        }

        public int Guardar(
            Nullable<decimal> CantidadAmbientesFinal,
            Nullable<decimal> CantidadAmbientesInicial,
            Nullable<int> IdCategoria,
            int IdCliente,
            Nullable<int> Disposicion,
            Nullable<int> EnumEstado,
            Nullable<bool> EsAptoProfesional,
            Nullable<int> IdEstadoPropiedad,
            Type EstadoPropiedad,
            int MetrosConstruiblesFinal,
            int MetrosConstruiblesInicial,
            int MetrosCubiertosFinal,
            int MetrosCubiertosInicial,
            int MetrosTerrenoFinal,
            int MetrosTerrenoInicial,
            Nullable<int> IdTipoPropiedad,
            Nullable<int> TipoZona,
            Nullable<int> IdBarrio,
            Nullable<int> IdLocalidad,
            Nullable<int> IdPais,
            Nullable<int> IdProvincia,
            Nullable<decimal> ImporteFinal,
            Nullable<decimal> ImporteInicial,
            Nullable<int> IdMoneda,
            string observaciones,
            bool activo)
        {

            object cantidadAmbientesFinal = CantidadAmbientesFinal;
            if (null == CantidadAmbientesFinal)
                cantidadAmbientesFinal = System.DBNull.Value;

            object cantidadAmbientesInicial = CantidadAmbientesInicial;
            if (null == CantidadAmbientesInicial)
                cantidadAmbientesInicial = System.DBNull.Value;

            object idCategoria = IdCategoria;
            if (!IdCategoria.HasValue)
                idCategoria = System.DBNull.Value;

            object disposicion = Disposicion;
            if (!Disposicion.HasValue)
                disposicion = System.DBNull.Value;

            object enumEstado = EnumEstado;
            if (!EnumEstado.HasValue)
                enumEstado = System.DBNull.Value;

            object esAptoProfesional = EsAptoProfesional;
            if (!EsAptoProfesional.HasValue)
                esAptoProfesional = System.DBNull.Value;

            object idEstadoPropiedad = IdEstadoPropiedad;
            if (!IdEstadoPropiedad.HasValue)
                idEstadoPropiedad = System.DBNull.Value;

            object metrosConstruiblesFinal = MetrosConstruiblesFinal;
            if (0 == MetrosConstruiblesFinal)
                metrosConstruiblesFinal = System.DBNull.Value;

            object metrosCubiertosFinal = MetrosCubiertosFinal;
            if (0 == MetrosCubiertosFinal)
                metrosCubiertosFinal = System.DBNull.Value;

            object metrosTerrenoFinal = MetrosTerrenoFinal;
            if (0 == MetrosTerrenoFinal)
                metrosTerrenoFinal = System.DBNull.Value;

            object idTipoPropiedad = IdTipoPropiedad;
            if (!IdTipoPropiedad.HasValue)
                idTipoPropiedad = System.DBNull.Value;

            object tipoZona = TipoZona;
            if (!TipoZona.HasValue)
                tipoZona = System.DBNull.Value;

            object importeFinal = ImporteFinal;
            if (!ImporteFinal.HasValue)
                importeFinal = System.DBNull.Value;

            object importeInicial = ImporteInicial;
            if (!ImporteInicial.HasValue)
                importeInicial = System.DBNull.Value;

            object idMoneda = IdMoneda;
            if (!IdMoneda.HasValue)
                idMoneda = System.DBNull.Value;

            object idBarrio = IdBarrio;
            if (!IdBarrio.HasValue)
                idBarrio = System.DBNull.Value;

            object idLocalidad = IdLocalidad;
            if (!IdLocalidad.HasValue)
                idLocalidad = System.DBNull.Value;

            object idPais = IdPais;
            if (!IdPais.HasValue)
                idPais = System.DBNull.Value;

            object idProvincia = IdProvincia;
            if (!IdProvincia.HasValue)
                idProvincia = System.DBNull.Value;


            return AccesoDatos.InsertarRegistro(
                "Pedido_Guardar",
                new object[] {   
                    cantidadAmbientesFinal,
                    cantidadAmbientesInicial,
                    idCategoria,
                    IdCliente,
                    disposicion,
                    enumEstado,
                    esAptoProfesional,
                    idEstadoPropiedad,
                    EstadoPropiedad.ToString(),
                    metrosConstruiblesFinal, MetrosConstruiblesInicial,
                    metrosCubiertosFinal, MetrosCubiertosInicial,
                    metrosTerrenoFinal, MetrosTerrenoInicial,
                    idTipoPropiedad,
                    tipoZona,
                    idBarrio,
                    idLocalidad,
                    idPais,
                    idProvincia,
                    importeFinal,
                    importeInicial,
                    idMoneda,
                    observaciones,
                    activo},
                new string[] {    
                    "@CantidadAmbientesFinal",
                    "@CantidadAmbientesInicial",
                    "@IdCategoria",
                    "@IdCliente",
                    "@Disposicion",
                    "@EnumEstado",
                    "@EsAptoProfesional",
                    "@IdEstadoPropiedad",
                    "@EstadoPropiedad",
                    "@MetrosConstruiblesFinal",
                    "@MetrosConstruiblesInicial",
                    "@MetrosCubiertosFinal", 
                    "@MetrosCubiertosInicial",
                    "@MetrosTerrenoFinal", 
                    "@MetrosTerrenoInicial",
                    "@IdTipoPropiedad",
                    "@TipoZona",
                    "@IdBarrio",
                    "@IdLocalidad",
                    "@IdPais",
                    "@IdProvincia",
                    "@ImporteFinal",
                    "@ImporteInicial",
                    "@IdMoneda",
                    "@Observaciones",
                    "@Activo"});
        }

        public IDataReader RecuperarPedidosTodos()
        {
            return AccesoDatos.RecuperarDatos("Pedidos_RecuperarTodos",
                new object[] { },
                new string[] { });
        }

        public IDataReader RecuperarPedidosPorNombreContacto(string Nombres)
        {
            return AccesoDatos.RecuperarDatos("Pedidos_RecuperarPorNombreContacto",
                 new object[] { Nombres},
                 new string[] { "@Cadena"});
        }
    }
}
