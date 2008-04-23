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
            p.llenar(dr);
            return p;
        }
    }
}
