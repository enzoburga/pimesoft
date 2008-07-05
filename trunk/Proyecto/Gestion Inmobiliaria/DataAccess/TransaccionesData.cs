using System;
using System.Collections.Generic;
using System.Text;

namespace GI.DA
{
    public class TransaccionesData
    {

        public bool DesactivarTransaccion(int IdTransaccion)
        {
            return AccesoDatos.ActualizarRegistro(
                "Transaccion_Desactivar",
                new object[] { IdTransaccion },
                new string[] { "@IdTransaccion" });
        }

        public System.Data.IDataReader RecuperarTransaccionPropiedadActiva(int IdPropiedad)
        {
            return AccesoDatos.RecuperarDatos(
                "Transacciones_RecuperarActivaPorPropiedad",
                new object[] { IdPropiedad },
                new string[] { "@IdPropiedad" });
        }


        public int CrearTransaccionPedido(int IdPedido, int IdTipoTrans, DateTime Fecha)
        {

            return AccesoDatos.InsertarRegistro(
                "Transaccion_CrearTransPedido",
                new object[] { IdPedido, IdTipoTrans, Fecha },
                new string[] { "@IdPedido", "@IdTipoTrans", "@Fecha" });
        }

        public int CrearTransaccionFoto(int IdPropiedad, int IdTipoTrans, DateTime Fecha, int IdFoto)
        {
            return AccesoDatos.InsertarRegistro(
                "Transaccion_CrearTransFoto",
                new object[] { IdPropiedad, IdTipoTrans, Fecha, IdFoto },
                new string[] { "@IdPropiedad", "@IdTipoTrans", "@Fecha", "@IdFoto" });
        }

        public int CrearTransaccionPropiedad(int IdPropiedad, int IdTipoTrans, DateTime Fecha, string TypePropopiedad)
        {
            return AccesoDatos.InsertarRegistro(
                "Transaccion_CrearTransPropiedad",
                new object[] { IdPropiedad, IdTipoTrans, Fecha, TypePropopiedad },
                new string[] { "@IdPropiedad", "@IdTipoTrans", "@Fecha", "@TypePropopiedad" });
        }


        public System.Data.IDataReader RecuperarTransaccionesFotoPendientes()
        {
            return AccesoDatos.RecuperarDatos(
                "Transacciones_RecuperarTransaccionesPropiedadesFotoPendientes",
                new object[] { },
                new string[] { });
        }

        public System.Data.IDataReader RecuperarTransaccionesFotoPendientes(int IdPropiedad)
        {
            return AccesoDatos.RecuperarDatos(
                "Transacciones_RecuperarTransaccionesPropiedadesFotoPendientesPorProp",
                 new object[] { IdPropiedad },
                new string[] { "@IdPropiedad" });
        }

        public System.Data.IDataReader RecuperarTransaccionesPropiedadesPendientes()
        {
            return AccesoDatos.RecuperarDatos(
                "Transacciones_RecuperarTransaccionesPropiedadesPendientes",
                new object[] { },
                new string[] { });
        }

        public System.Data.IDataReader RecuperarTransaccionesPropiedadesPendientes(int IdPropiedad)
        {
            return AccesoDatos.RecuperarDatos(
                "Transacciones_RecuperarTransaccionesPropiedadesPendientesPorProp",
                new object[] { IdPropiedad },
                new string[] { "@IdPropiedad" });
        }

    }
}
