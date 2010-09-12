using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace GI.DA
{
    public class InmobiliariasData
    {

        public IDataReader RecuperarTodas()
        {
            return AccesoDatos.RecuperarDatos("InmobiliariaExterna_RecuperarTodas", new object[] { }, new string[] { });
        }


        public int CrearInmobiliariaExterna(string Nombre, string Telefono, string Contacto)
        {
            return AccesoDatos.InsertarRegistro(
                "InmobiliariaExterna_Insertar",
                new object[] { Nombre, Telefono, Contacto },
                new string[] { "@Nombre", "@Telefono", "@Contacto" });
        
        
        }

        public bool ActualizarInmobiliariaExterna(int IdInmobiliaria, string Nombre, string Telefono, string Contacto)
        {
            return AccesoDatos.ActualizarRegistro(
                "InmobiliariaExterna_Actualizar",
                new object[] { IdInmobiliaria, Nombre, Telefono, Contacto },
                new string[] { "@IdInmobiliaria", "@Nombre", "@Telefono", "@Contacto" });
        }

        public IDataReader RecuperarDatosInmobiliaria()
        {
            return AccesoDatos.RecuperarDatos("Inmobiliaria_RecuperarDatos", new object[] { }, new string[] { });
        
        }

        public bool ActualizarInmobiliaria(string Nombre, string Calle, string CodigoPostal, string Depto, int Numero, string Piso, string Fax, string Telefono, string DireccionWeb)
        {


            return AccesoDatos.ActualizarRegistro(
                "Inmobiliaria_ActualizarDatos",
                new object[] { Nombre, Calle, CodigoPostal, Depto, Numero, Piso, Fax, Telefono, DireccionWeb },
                new string[] { "@Nombre", "@Calle", "@CodigoPostal", "@Depto", "@Numero", "@Piso", "@Fax", "@Telefono", "@DireccionWeb" });
            
        }

    }
}
