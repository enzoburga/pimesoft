using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace GI.DA
{
    public class UbicacionesData
    {



        public IDataReader RecuperarPaises()
        {
            return AccesoDatos.RecuperarDatos("Paises_RecuperarTodos", new object[] { }, new string[] { });
        }
        public IDataReader RecuperarProvincias()
        {
            return AccesoDatos.RecuperarDatos("Provincias_RecuperarTodas", new object[] { }, new string[] { });
        }
        public IDataReader RecuperarLocalidades()
        {
            return AccesoDatos.RecuperarDatos("Localidades_RecuperarTodas", new object[] { }, new string[] { });
        }
        public IDataReader RecuperarBarrios()
        {
            return AccesoDatos.RecuperarDatos("Barrios_RecuperarTodos", new object[] { }, new string[] { });
        }

    }
}
