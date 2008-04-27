using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Managers.Propiedades
{
    public class MngPropiedades
    {



        public GI.BR.Propiedades.Propiedades RecuperarPropiedades(string Calle, int Numero)
        {
            GI.BR.Propiedades.Propiedades propiedades = new GI.BR.Propiedades.Propiedades();
            propiedades.RecuperarPropiedadesVentaPorDireccion(Calle, Numero);
            return propiedades;
        }

        public GI.BR.Propiedades.Propiedades RecuperarPropiedades(Type Type, GI.BR.Propiedades.TipoPropiedad Tipo,
                    GI.BR.Propiedades.EstadoPropiedad Estado, GI.BR.Propiedades.Ambiente Ambientes,
                    GI.BR.Propiedades.Ubicacion Ubicacion, GI.BR.Valor ValorDesde, GI.BR.Valor ValorHasta)
        {


            GI.BR.Propiedades.Propiedades propiedades = new GI.BR.Propiedades.Propiedades();


            if (Type.ToString() == "GI.BR.Propiedades.Venta")
            {
                if (Tipo == null && Estado == null)
                    propiedades.RecuperarPropiedadesVentas();
                else if (Estado != null && Tipo != null)
                    propiedades.RecuperarPropiedadesVentas(Estado, Tipo);
                else if (Estado != null)
                    propiedades.RecuperarPropiedadesVentas(Estado);
                else
                    propiedades.RecuperarPropiedadesVentas(Tipo);
            }




            return AplicarFiltros(propiedades, Ambientes, Ubicacion, ValorDesde, ValorHasta);

        
        }




        private GI.BR.Propiedades.Propiedades AplicarFiltros(GI.BR.Propiedades.Propiedades Propiedades, GI.BR.Propiedades.Ambiente Ambientes,
                    GI.BR.Propiedades.Ubicacion Ubicacion, GI.BR.Valor ValorDesde, GI.BR.Valor ValorHasta)
        {
            GI.BR.Propiedades.Propiedades filtro = new GI.BR.Propiedades.Propiedades();

            foreach (GI.BR.Propiedades.Propiedad p in Propiedades)
            {



                if (Ubicacion.Pais != null)
                {
                    if (p.Ubicacion.Pais.IdPais != Ubicacion.Pais.IdPais)
                        continue;
                }
                if (Ubicacion.Provincia != null)
                {
                    if (p.Ubicacion.Provincia.IdProvincia != Ubicacion.Provincia.IdProvincia)
                        continue;
                }



                if (Ubicacion.Localidad != null)
                {
                    if (p.Ubicacion.Localidad.IdLocalidad != Ubicacion.Localidad.IdLocalidad)
                        continue;
                }

                if (Ubicacion.Barrio != null)
                {
                    if (p.Ubicacion.Barrio.IdBarrio != Ubicacion.Barrio.IdBarrio)
                        continue;
                }




                if (Ambientes != null)
                {
                    if (Ambientes.CantidadAmbientes != p.CantidadAmbientes)
                        continue;
                }


                if (ValorDesde != null)
                {
                    if (p.ValorPublicacion.Moneda.IdMoneda != ValorDesde.Moneda.IdMoneda || p.ValorPublicacion.Importe < ValorDesde.Importe)
                        continue;
                }

                if (ValorHasta != null)
                {
                    if (p.ValorPublicacion.Moneda.IdMoneda != ValorHasta.Moneda.IdMoneda || p.ValorPublicacion.Importe > ValorHasta.Importe)
                        continue;
                }


                filtro.Add(p);

            }


            return filtro;

        }


        







    }
}
