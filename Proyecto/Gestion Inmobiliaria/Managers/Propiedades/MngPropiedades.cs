using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Managers.Propiedades
{


    /// <summary>
    /// Manager Propiedades clientes windows.
    /// </summary>
    public class MngPropiedades
    {


        public bool GuardarPropiedad(GI.BR.Propiedades.Propiedad p)
        {
           
            p.IdPropiedad = GI.BR.Propiedades.Propiedad.RecuperarProxIdPropiedad();
            if (!p.Guardar()) return false;

            //Crearmos la transaccion de la propiedad.

            if (!p.EsOtraInmobiliaria)
            {
                GI.BR.Propiedades.Tranasacciones.TransaccionPropiedad trans = new GI.BR.Propiedades.Tranasacciones.TransaccionPropiedad();
                trans.Activa = true;
                trans.Fecha = DateTime.Now;
                trans.IdPropiedad = p.IdPropiedad;
                trans.TipoTransaccion = GI.BR.Propiedades.Tranasacciones.EnumTipoTransaccion.Crear;
                trans.TypePropopiedad = p.GetType().ToString();

                trans.Crear();
            }

            return true;
        }

        public bool ActualizarPropiedad(GI.BR.Propiedades.Propiedad p)
        {
            //Actualizamos la propiedad

            if (!p.Actualizar())
                return false;

            //si la propiedad tenia una transaccion pendiente la dejamos, sino creamos una
            GI.BR.Propiedades.Tranasacciones.TransaccionPropiedad trans = null;

            if (!p.EsOtraInmobiliaria)
            {
                trans = GI.BR.Propiedades.Tranasacciones.TransaccionPropiedad.RecuperarActiva(p);
                if (trans == null)
                {

                    trans = new GI.BR.Propiedades.Tranasacciones.TransaccionPropiedad();
                    trans.Activa = true;
                    trans.Fecha = DateTime.Now;
                    trans.IdPropiedad = p.IdPropiedad;
                    trans.TipoTransaccion = GI.BR.Propiedades.Tranasacciones.EnumTipoTransaccion.Modificar;
                    trans.TypePropopiedad = p.GetType().ToString();

                    trans.Crear();
                }
            }

            return true;


        }





        public GI.BR.Propiedades.Propiedades RecuperarPropiedades(Type Type, string Calle, int Numero)
        {
            GI.BR.Propiedades.Propiedades propiedades = new GI.BR.Propiedades.Propiedades();
            
            if (Type.ToString() == "GI.BR.Propiedades.Venta")
            {
                propiedades.RecuperarPropiedadesVentaPorDireccion(Calle, Numero);
            }
            else if (Type.ToString() == "GI.BR.Propiedades.Alquiler")
            {
                propiedades.RecuperarPropiedadesAlquileresPorDireccion(Calle, Numero);
            }
            
            
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
            else if (Type.ToString() == "GI.BR.Propiedades.Alquiler")
            {
                if (Tipo == null && Estado == null)
                    propiedades.RecuperarPropiedadesAlquileres();
                else if (Estado != null && Tipo != null)
                    propiedades.RecuperarPropiedadesAlquileres(Estado, Tipo);
                else if (Estado != null)
                    propiedades.RecuperarPropiedadesAlquileres(Estado);
                else
                    propiedades.RecuperarPropiedadesAlquileres(Tipo);
            }




            return AplicarFiltros(propiedades, Ambientes, Ubicacion, ValorDesde, ValorHasta);

        
        }


        public GI.BR.Propiedades.Propiedades RecuperarPropiedades(Type Type, GI.BR.Propiedades.TipoPropiedad Tipo,
            GI.BR.Propiedades.EstadoPropiedad Estado, GI.BR.Propiedades.Ambiente Ambientes,
            GI.BR.Propiedades.UbicacionesCollection Ubicaciones, GI.BR.Valor ValorDesde, GI.BR.Valor ValorHasta)
        {
            GI.BR.Propiedades.Propiedades propiedades = new GI.BR.Propiedades.Propiedades();
            foreach (GI.BR.Propiedades.Ubicacion u in Ubicaciones)
            {
                propiedades.AddRange(RecuperarPropiedades(Type, Tipo,
                    Estado, Ambientes,
                    u, ValorDesde, ValorHasta));
            }

            return propiedades;

        }

        /// <summary>
        /// genera una copia de una propiedad
        /// </summary>
        /// <param name="PropiedadOrigen">Propiedad de la cual se va a copiar</param>
        /// <param name="TipoPropiedadDestino">Tipo de clase de la propiedad destino (Venta o Alquiler)</param>
        /// <returns></returns>
        public GI.BR.Propiedades.Propiedad CopiarPropiedad(GI.BR.Propiedades.Propiedad PropiedadOrigen, Type TipoPropiedadDestino)
        {
            try
            {
                GI.BR.Propiedades.Propiedad PropiedadDestino = null;

                if (TipoPropiedadDestino == typeof(GI.BR.Propiedades.Venta))
                    PropiedadDestino = new GI.BR.Propiedades.Venta();
                else
                    PropiedadDestino = new GI.BR.Propiedades.Alquiler();

                PropiedadOrigen.Copiar(PropiedadDestino);


                if (!GuardarPropiedad(PropiedadDestino))
                    throw new Exception();

                MngGaleriaFotos mngFotos = new MngGaleriaFotos();
                
                foreach (GI.BR.Propiedades.Galeria.Foto f in PropiedadOrigen.GaleriaFotos)
                {
                    mngFotos.AgregarFotoAGaleria(f.Imagen, f.Descripcion, f.EsFachada, PropiedadDestino);    
                }



                return PropiedadDestino;
            }
            catch
            {
                return null;
            }

        
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
