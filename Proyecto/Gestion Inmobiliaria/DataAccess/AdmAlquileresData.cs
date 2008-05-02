using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace GI.DA
{
    public class AdmAlquileresData
    {
        #region Métodos Persistencia
        public bool Guardar(int IdPropiedad, int IdContacto)
        {
            object contacto = IdContacto;

            if (0 == IdContacto)
                contacto = System.DBNull.Value;

            return 0 < AccesoDatos.InsertarRegistro(
               "AdmAlquiler_Guardar",
               new object[] { IdPropiedad, contacto },
               new string[] { "@IdPropiedad", "@IdContacto" });


        }

        public bool Actualizar(int IdPropiedad, int IdContacto)
        {
            object contacto = IdContacto;

            if (0 == IdContacto)
                contacto = System.DBNull.Value;

            return 0 < AccesoDatos.InsertarRegistro(
               "AdmAlquiler_Actualizar",
               new object[] { IdPropiedad, contacto },
               new string[] { "@IdPropiedad", "@IdContacto" });
        } 
        #endregion


        #region Métodos Recuperación

        public IDataReader RecuperarAdmAlquileresPorTipo(int IdTipoPropiedad)
        {
            return AccesoDatos.RecuperarDatos("AdmAlquileres_RecuperarPorTipoPropiedad",
                new object[] { IdTipoPropiedad },
                new string[] { "@IdTipoPropiedad" });
        }

        public IDataReader RecuperarAdmAlquileresPorEstado(int IdEstadoPropiedad)
        {
            return AccesoDatos.RecuperarDatos("AdmAlquileres_RecuperarPorEstadoPropiedad",
                new object[] { IdEstadoPropiedad },
                new string[] { "@IdEstadoPropiedad" });
        }

        public IDataReader RecuperarAdmAlquileres(int IdEstadoPropiedad, int IdTipoPropiedad)
        {
            return AccesoDatos.RecuperarDatos("AdmAlquileres_RecuperarPorEstadoYTipoPropiedad",
                new object[] { IdEstadoPropiedad, IdTipoPropiedad },
                new string[] { "@IdEstadoPropiedad", "@IdTipoPropiedad" });
        }

        public IDataReader RecuperarAdmAlquileresPorDireccion(string Calle, int Numero)
        {
            return AccesoDatos.RecuperarDatos("AdmAlquileres_RecuperarPorDireccion",
                new object[] { Calle, Numero },
                new string[] { "@Calle", "@Numero" });
        }

        public IDataReader RecuperarAdmAlquileresTodos()
        {
            return AccesoDatos.RecuperarDatos("AdmAlquileres_RecuperarTodos",
                new object[] { },
                new string[] { });
        }

        public IDataReader RecuperarAdmAlquileresPorCodigoPropiedad(string Codigo)
        {
            return AccesoDatos.RecuperarDatos("AdmAlquileres_RecuperarPorCodigoPropiedad",
                new object[] { Codigo },
                new string[] { "@IdPropiedad" });
        }

        public IDataReader RecuperarAdmAlquileresPorNombreInquilino(string Nombres)
        {
            return AccesoDatos.RecuperarDatos("AdmAlquileres_RecuperarPorNombreInquilino",
                new object[] { Nombres },
                new string[] { "@Cadena" });
        } 
        #endregion
    }
}
