using System;
using System.Collections.Generic;
using System.Text;

namespace GI.DA
{
    public class AdmAlquileresData
    {
        public bool Guardar(int IdPropiedad, int IdContacto)
        {
            if (0 == IdContacto)
                return 0 < AccesoDatos.InsertarRegistro(
                   "AdmAlquiler_Guardar",
                   new object[] { IdPropiedad, System.DBNull.Value },
                   new string[] { "@IdPropiedad", "@IdContacto" });
            else
                return 0 < AccesoDatos.InsertarRegistro(
                   "AdmAlquiler_Guardar",
                   new object[] { IdPropiedad, IdContacto },
                   new string[] { "@IdPropiedad", "@IdContacto" });


        }

        public bool Actualizar(int IdPropiedad, int IdContacto)
        {
            if (0 == IdContacto)
                return 0 < AccesoDatos.InsertarRegistro(
                   "AdmAlquiler_Actualizar",
                   new object[] { IdPropiedad, System.DBNull.Value },
                   new string[] { "@IdPropiedad", "@IdContacto" });
            else
                return 0 < AccesoDatos.InsertarRegistro(
                   "AdmAlquiler_Actualizar",
                   new object[] { IdPropiedad, IdContacto },
                   new string[] { "@IdPropiedad", "@IdContacto" });
        }
    }
}
