using System;
using System.Collections.Generic;
using System.Text;

namespace GI.DA
{
    public class ClientesData
    {
        public int GuardarCliente(DateTime FechaNacimiento, string Email, string Apellido, string Nombres, string NroDocumento, string Observaciones, int TelefonoCelular, int TelefonoParticular, int TelefonoTrabajo, int TipoDocumento, int IdBarrio, int IdProvincia, string Calle, string CodigoPostal, string Depto, int Numero, string Piso, string CalleEntre1, string CalleEntre2, int IdPais, int IdLocalidad)
        {
            return AccesoDatos.InsertarRegistro(
               "Cliente_Guardar",
               new object[] { 
                   Nombres ,
                   Apellido,
                   NroDocumento,
                   TipoDocumento,
                   TelefonoParticular,
                   TelefonoTrabajo,
                   TelefonoCelular,
                   Observaciones,
                   FechaNacimiento,
                   Email,
                   Calle,
                   Numero,
                   Depto,
                   Piso,
                   CodigoPostal,
                   CalleEntre1,
                   CalleEntre2,
                   IdBarrio,
                   IdProvincia,
                   IdPais,
                   IdLocalidad },
               new string[] { "@Nombres" ,
                   "@Apellido",
                   "@NroDocumento",
                   "@TipoDocumento",
                   "@TelefonoParticular",
                   "@TelefonoTrabajo",
                   "@TelefonoCelular",
                   "@Observaciones",
                   "@FechaNacimiento",
                   "@Email",
                   "@Calle",
                   "@Numero",
                   "@Depto",
                   "@Piso",
                   "@CodigoPostal",
                   "@CalleEntre1",
                   "@CalleEntre2",
                   "@IdBarrio",
                   "@IdProvincia",
                   "@IdPais",
                   "@IdLocalidad" });
        }

        public bool Actualizar(int IdCliente, DateTime FechaNacimiento, string Email, string Apellido, string Nombres, string NroDocumento, string Observaciones, int TelefonoCelular, int TelefonoParticular, int TelefonoTrabajo, int TipoDocumento, int IdBarrio, int IdProvincia, string Calle, string CodigoPostal, string Depto, int Numero, string Piso, string CalleEntre1, string CalleEntre2, int IdPais, int IdLocalidad)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public bool Eliminar(int IdCliente)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public System.Data.IDataReader RecuperarPropietarios(string nombre)
        {
            return AccesoDatos.RecuperarDatos(
                "Propietarios_RecuperarPorNombre",
                new object[] { nombre},
                new string[] { "@Nombre"});
        }

        public System.Data.IDataReader RecuperarDatosClientePorId(int IdCliente)
        {
            return AccesoDatos.RecuperarDatos(
                "Cliente_RecuperarPorId",
                new object[] { IdCliente },
                new string[] { "@IdCliente" });
        }

        public bool GuardarPropietario(int IdPropietario)
        {
            return 0 < AccesoDatos.InsertarRegistro(
                "Propietario_Guardar",
                new object[] { IdPropietario },
                new string[] { "@IdPropietario" });
        }

        public bool ActualizarPropietario(int p)
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}
