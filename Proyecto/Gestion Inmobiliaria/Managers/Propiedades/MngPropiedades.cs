using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Managers.Propiedades
{
    public class MngPropiedades
    {



        public GI.BR.Propiedades.Propiedades RecuperarPropiedades(Type Type, GI.BR.Propiedades.TipoPropiedad Tipo,
                    GI.BR.Propiedades.EstadoPropiedad Estado,
                    GI.BR.Propiedades.Ubicacion Ubicacion)
        {


            GI.BR.Propiedades.Propiedades Propiedades = new GI.BR.Propiedades.Propiedades();
            GI.BR.Propiedades.Propiedad p;

            p = new GI.BR.Propiedades.Venta();
            p.Codigo = "P-0001";
            p.Direccion = new GI.BR.Propiedades.Direccion();
            p.Direccion.Calle = "Agustin Alvarez";
            p.Direccion.CodigoPostal = "1602";
            p.Direccion.Depto = "2";
            p.Direccion.Numero = 2578;
            p.Direccion.Piso="PB";

            p.EsOtraInmobiliaria = false;
            p.Estado = new GI.BR.Propiedades.EstadoPropiedad();
            p.Estado.IdEstadoPropiedad = 1;
            p.Estado.Descripcion = "En venta";
            p.IdPropiedad = 1;
            
            
            
            
            p.Observaciones = "detalles de obs de la propiedad";
            p.Propietario = new GI.BR.Propietario();
            p.TipoPropiedad = new GI.BR.Propiedades.TipoPropiedad();
            p.Ubicacion = new GI.BR.Propiedades.Ubicacion();
            p.Ubicacion.Barrio = new GI.BR.Propiedades.Ubicaciones.Barrio();
            p.Ubicacion.Localidad = new GI.BR.Propiedades.Ubicaciones.Localidad();
            p.Ubicacion.Pais = new GI.BR.Propiedades.Ubicaciones.Pais();

            p.ValorPublicacion = new GI.BR.Valor();
            p.ValorPublicacion.Moneda = new GI.BR.Monedas.Moneda();
            p.ValorPublicacion.Moneda.Simbolo = "USD";
            p.ValorPublicacion.Importe = 50000;

            Propiedades.Add(p);


            p = new GI.BR.Propiedades.Venta();

            p.ValorPublicacion = new GI.BR.Valor();
            p.ValorPublicacion.Moneda = new GI.BR.Monedas.Moneda();
            p.ValorPublicacion.Moneda.Simbolo = "USD";
            p.ValorPublicacion.Importe = 50000;


            p.Codigo = "P-0001";
            p.Direccion = new GI.BR.Propiedades.Direccion();
            p.Direccion.Calle = "Agustin Alvarez";
            p.Direccion.CodigoPostal = "1602";
            p.Direccion.Depto = "2";
            p.Direccion.Numero = 2578;
            p.Direccion.Piso = "PB";

            p.EsOtraInmobiliaria = true;
            p.Estado = new GI.BR.Propiedades.EstadoPropiedad();
            p.Estado.IdEstadoPropiedad = 1;
            p.Estado.Descripcion = "En venta";
            p.IdPropiedad = 1;
           
            p.Observaciones = "detalles de obs de la propiedad";
            p.Propietario = new GI.BR.Propietario();
            p.TipoPropiedad = new GI.BR.Propiedades.TipoPropiedad();
            p.Ubicacion = new GI.BR.Propiedades.Ubicacion();
            p.Ubicacion.Barrio = new GI.BR.Propiedades.Ubicaciones.Barrio();
            p.Ubicacion.Localidad = new GI.BR.Propiedades.Ubicaciones.Localidad();
            p.Ubicacion.Pais = new GI.BR.Propiedades.Ubicaciones.Pais();
           

            Propiedades.Add(p);

            return Propiedades;

        
        }






    }
}
