using System;
using System.Collections.Generic;
using System.Text;

namespace GI.DA
{
    public class ClientesData
    {
        public int GuardarCliente(Nullable<DateTime> FechaNacimiento, string Email, string Apellido, string Nombres, string NroDocumento, string Observaciones, string TelefonoCelular, string TelefonoParticular, string TelefonoTrabajo, int TipoDocumento, int IdBarrio, int IdProvincia, string Calle, string CodigoPostal, string Depto, int Numero, string Piso, string CalleEntre1, string CalleEntre2, int IdPais, int IdLocalidad)
        {
            object fechaNacimiento = FechaNacimiento;
            if (!FechaNacimiento.HasValue)
                fechaNacimiento = System.DBNull.Value;

            object idPais = IdPais;
            if (IdPais == 0)
                idPais = System.DBNull.Value;

            object idProvincia = IdProvincia;
            if (IdProvincia == 0)
                idProvincia = System.DBNull.Value;

            object idBarrio = IdBarrio;
            if (IdBarrio == 0)
                idBarrio = System.DBNull.Value;

            object idLocalidad = IdLocalidad;
            if (IdLocalidad == 0)
                idLocalidad = System.DBNull.Value;

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
                   fechaNacimiento,
                   Email,
                   Calle,
                   Numero,
                   Depto,
                   Piso,
                   CodigoPostal,
                   CalleEntre1,
                   CalleEntre2,
                   idBarrio,
                   idProvincia,
                   idPais,
                   idLocalidad },
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

        public bool Actualizar(int IdCliente, Nullable<DateTime> FechaNacimiento, string Email, string Apellido, string Nombres, string NroDocumento, string Observaciones, string TelefonoCelular, string TelefonoParticular, string TelefonoTrabajo, int TipoDocumento, int IdBarrio, int IdProvincia, string Calle, string CodigoPostal, string Depto, int Numero, string Piso, string CalleEntre1, string CalleEntre2, int IdPais, int IdLocalidad)
        {
            object fechaNacimiento = FechaNacimiento;
            if (!FechaNacimiento.HasValue)
                fechaNacimiento = System.DBNull.Value;


            object idPais = IdPais;
            if (IdPais == 0)
                idPais = System.DBNull.Value;

            object idProvincia = IdProvincia;
            if (IdProvincia == 0)
                idProvincia = System.DBNull.Value;

            object idBarrio = IdBarrio;
            if (IdBarrio == 0)
                idBarrio = System.DBNull.Value;

            object idLocalidad = IdLocalidad;
            if (IdLocalidad == 0)
                idLocalidad = System.DBNull.Value;

            return AccesoDatos.ActualizarRegistro(
               "Cliente_Actualizar",
               new object[] { 
                   IdCliente,
                   Nombres ,
                   Apellido,
                   NroDocumento,
                   TipoDocumento,
                   TelefonoParticular,
                   TelefonoTrabajo,
                   TelefonoCelular,
                   Observaciones,
                   fechaNacimiento,
                   Email,
                   Calle,
                   Numero,
                   Depto,
                   Piso,
                   CodigoPostal,
                   CalleEntre1,
                   CalleEntre2,
                   idBarrio,
                   idProvincia,
                   idPais,
                   idLocalidad },
               new string[] { 
                   "@IdCliente",
                   "@Nombres" ,
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


        public System.Data.IDataReader RecuperarPropietarios(string nombre)
        {
            return AccesoDatos.RecuperarDatos(
                "Propietarios_RecuperarPorNombre",
                new object[] { nombre},
                new string[] { "@Cadena"});
        }


        public System.Data.IDataReader RecuperarPropietarios()
        {
            return AccesoDatos.RecuperarDatos(
                "Propietarios_RecuperarTodos",
                new object[] { },
                new string[] { });
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
        
        public bool GuardarInquilino(int IdInquilino)
        {
            return 0 < AccesoDatos.InsertarRegistro(
                "Inquilino_Guardar",
                new object[] { IdInquilino },
                new string[] { "@IdInquilino" });
        }

        public System.Data.IDataReader RecuperarInquilinos(string Nombres)
        {
            return AccesoDatos.RecuperarDatos(
                "Inquilinos_RecuperarPorNombre",
                new object[] { Nombres },
                new string[] { "@Cadena" });
        }

        public System.Data.IDataReader RecuperarInquilinos()
        {
            return AccesoDatos.RecuperarDatos(
                "Inquilinos_RecuperarTodos",
                new object[] { },
                new string[] { });
        }

        public bool GuardarClientePedido(int IdClientePedido)
        {
            return 0 < AccesoDatos.InsertarRegistro(
                "ClientePedido_Guardar",
                new object[] { IdClientePedido },
                new string[] { "@IdClientePedido" });
        }

        public System.Data.IDataReader RecuperarClientesPedido(string Nombres)
        {
            return AccesoDatos.RecuperarDatos(
                "ClientesPedido_RecuperarPorNombre",
                new object[] { Nombres },
                new string[] { "@Cadena" });
        }

        public System.Data.IDataReader RecuperarClientesPedido()
        {
            return AccesoDatos.RecuperarDatos(
                "ClientesPedido_RecuperarTodos",
                new object[] {  },
                new string[] {  });
        }

        public System.Data.IDataReader RecuperarDatosClientePorEmail(string email)
        {
            return AccesoDatos.RecuperarDatos(
                "ClientePedido_RecuperarPorEmail",
                new object[] { email },
                new string[] { "@email" });
        }
    }
}
