using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace GI.BR
{
    public class Clientes : List<Cliente>
    {
        public void RecuperarPropietarios(string nombre)
        {
            Propietario p = new Propietario();

            p.Apellido = "Ledesma";
            p.Email = "asd@asd";
            p.FechaNacimiento = DateTime.Today;
            p.IdCliente = 1;
            p.Nombres = "Daniel";
            p.NroDocumento = "30611080";
            p.Observaciones = "NADA";
            p.TelefonoCelular = 123452;
            p.TelefonoParticular = 12345234;
            p.TelefonoTrabajo = 12345890;
            p.TipoDocumento = GI.BR.General.enumTipoDocumento.DNI;
            p.Ubicacion = new GI.BR.Propiedades.Ubicacion();
            p.Ubicacion.Barrio = new GI.BR.Propiedades.Ubicaciones.Barrio();
            p.Ubicacion.Barrio.IdBarrio = 1;
            p.Ubicacion.Localidad = new GI.BR.Propiedades.Ubicaciones.Localidad();
            p.Ubicacion.Localidad.IdLocalidad = 1;
            p.Ubicacion.Pais = new GI.BR.Propiedades.Ubicaciones.Pais();
            p.Ubicacion.Pais.IdPais = 1;
            p.Ubicacion.Provincia = new GI.BR.Propiedades.Ubicaciones.Provincia();
            p.Ubicacion.Provincia.IdProvincia = 1;
            p.Direccion = new GI.BR.Propiedades.Direccion();
            p.Direccion.Calle = "San Jose";
            p.Direccion.CalleEntre1 = "Lonardi";
            p.Direccion.CalleEntre2 = "Guido";
            p.Direccion.CodigoPostal = "1643";
            p.Direccion.Numero = 2241;
            p.Direccion.Piso = "PB";
            p.Direccion.Depto = "A";
            this.Add(p);

            //GI.DA.ClientesData cd = new GI.DA.ClientesData();
            //using (IDataReader dr = cd.RecuperarPropietarios(nombre))
            //{
            //    while (dr.Read())
            //    {
            //        this.Add(GetPropietario(dr));
            //    }
            //}
        }

        private Cliente GetPropietario(IDataReader dr)
        {
            Propietario p = new Propietario();
            fillCliente(dr, p);
            return p;
        }

        private void fillCliente(IDataReader dr, Cliente p)
        {
            p.Apellido = dr.GetString(dr.GetOrdinal("Apellido"));
            p.Email = dr.GetString(dr.GetOrdinal("Email"));
            p.FechaNacimiento = dr.GetDateTime(dr.GetOrdinal("FechaNacimiento"));
            p.IdCliente = dr.GetInt32(dr.GetOrdinal("IdCliente"));
            p.Nombres = dr.GetString(dr.GetOrdinal("Nombres"));
            p.NroDocumento = dr.GetString(dr.GetOrdinal("NroDocumento"));
            p.Observaciones = dr.GetString(dr.GetOrdinal("Observaciones"));
            p.TelefonoCelular = dr.GetInt32(dr.GetOrdinal("TelefonoCelular"));
            p.TelefonoParticular = dr.GetInt32(dr.GetOrdinal("TelefonoParticular"));
            p.TelefonoTrabajo = dr.GetInt32(dr.GetOrdinal("TelefonoTrabajo"));
            p.TipoDocumento = (GI.BR.General.enumTipoDocumento)dr.GetInt32(dr.GetOrdinal("TipoDocumento"));
            p.Ubicacion = new GI.BR.Propiedades.Ubicacion();
            p.Ubicacion.Barrio = new GI.BR.Propiedades.Ubicaciones.Barrio();
            p.Ubicacion.Barrio.IdBarrio = dr.GetInt32(dr.GetOrdinal("IdBarrio"));
            p.Ubicacion.Localidad = new GI.BR.Propiedades.Ubicaciones.Localidad();
            p.Ubicacion.Localidad.IdLocalidad = dr.GetInt32(dr.GetOrdinal("IdLocalidad"));
            p.Ubicacion.Pais = new GI.BR.Propiedades.Ubicaciones.Pais();
            p.Ubicacion.Pais.IdPais = dr.GetInt32(dr.GetOrdinal("IdPais"));
            p.Ubicacion.Provincia = new GI.BR.Propiedades.Ubicaciones.Provincia();
            p.Ubicacion.Provincia.IdProvincia = dr.GetInt32(dr.GetOrdinal("IdProvincia"));
            p.Direccion = new GI.BR.Propiedades.Direccion();
            p.Direccion.Calle = dr.GetString(dr.GetOrdinal("Calle"));
            p.Direccion.CalleEntre1 = dr.GetString(dr.GetOrdinal("CalleEntre1"));
            p.Direccion.CalleEntre2 = dr.GetString(dr.GetOrdinal("CalleEntre2"));
            p.Direccion.CodigoPostal = dr.GetString(dr.GetOrdinal("CodigoPostal"));
            p.Direccion.Numero = dr.GetInt32(dr.GetOrdinal("Numero"));
            p.Direccion.Piso = dr.GetString(dr.GetOrdinal("Piso"));
            p.Direccion.Depto = dr.GetString(dr.GetOrdinal("Depto"));
        }
    }
}
