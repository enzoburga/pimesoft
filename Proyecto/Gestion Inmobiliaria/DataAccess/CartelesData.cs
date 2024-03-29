using System;
using System.Collections.Generic;
using System.Text;

namespace GI.DA
{
    public class CartelesData
    {
        public int Guardar(bool Activo, int Alto, int Ancho, DateTime FechaAlta, DateTime FechaVencimiento, int IdPropiedad, Type type, int IdUbicacionCartel)
        {


            return AccesoDatos.InsertarRegistro(
                "Carteles_Guardar",
                new object[] { Activo, Alto, Ancho, FechaAlta, FechaVencimiento, IdPropiedad, type.ToString(), IdUbicacionCartel },
                new string[] { "@Activo", "@Alto", "@Ancho", "@FechaAlta", "@FechaVencimiento", "@IdPropiedad", "@TipoCartel", "@IdUbicacionCartel" });
        }

        public bool Actualizar(int IdCartel, bool Activo, int Alto, int Ancho, DateTime FechaAlta, DateTime FechaVencimiento, int IdPropiedad, Type type, int IdUbicacionCartel)
        {


            return AccesoDatos.ActualizarRegistro(
                "Carteles_Actualizar",
                new object[] { IdCartel, Activo, Alto, Ancho, FechaAlta, FechaVencimiento, IdPropiedad, type.ToString(), IdUbicacionCartel },
                new string[] { "@IdCartel", "@Activo", "@Alto", "@Ancho", "@FechaAlta", "@FechaVencimiento", "@IdPropiedad", "@TipoCartel", "@IdUbicacionCartel" });

        }

        public System.Data.IDataReader RecuperarTodos()
        {
            return AccesoDatos.RecuperarDatos(
                "Carteles_RecuperarTodos",
                new object[] { },
                new string[] { });
        }

        public System.Data.IDataReader RecuperarPorPropiedad(int IdPropiedad)
        {
            return AccesoDatos.RecuperarDatos(
                "Carteles_RecuperarPorPropiedad",
                new object[] { IdPropiedad },
                new string[] { "@IdPropiedad" });
        }
    }
}
