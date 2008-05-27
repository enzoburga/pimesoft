using System;
using System.Collections.Generic;
using System.Text;

namespace GI.DA
{
    public class UbicacionCartelData
    {
        public System.Data.IDataReader RecuperarTodas()
        {
            return AccesoDatos.RecuperarDatos(
                "UbicacionesCartel_RecuperarTodas",
                new object[] { },
                new string[] { });
        }
    }
}
