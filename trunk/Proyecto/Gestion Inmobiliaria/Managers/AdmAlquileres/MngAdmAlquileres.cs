using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Managers.AdmAlquileres
{
    public class MngAdmAlquileres
    {
        public GI.BR.AdmAlquileres.AdmAlquileres RecuperarAdmAlquileres(string Calle, int Numero, bool IncluirVencidos)
        {
            GI.BR.AdmAlquileres.AdmAlquileres admAlquileres = new GI.BR.AdmAlquileres.AdmAlquileres();
            admAlquileres.RecuperarAdmAlquileresPorDireccion(Calle, Numero);
            return AplicarFiltros(admAlquileres, null, null, null, null, IncluirVencidos); ;
        }

        public GI.BR.AdmAlquileres.AdmAlquileres RecuperarAdmAlquileres(GI.BR.Propiedades.TipoPropiedad Tipo,
                    GI.BR.Propiedades.EstadoPropiedad Estado, GI.BR.Propiedades.Ambiente Ambientes,
                    GI.BR.Propiedades.Ubicacion Ubicacion, GI.BR.Valor ValorDesde, GI.BR.Valor ValorHasta, bool IncluirVencidos)
        {


            GI.BR.AdmAlquileres.AdmAlquileres admAlquileres = new GI.BR.AdmAlquileres.AdmAlquileres();

                if (Tipo == null && Estado == null)
                    admAlquileres.RecuperarAdmAlquileresTodos();
                else if (Estado != null && Tipo != null)
                    admAlquileres.RecuperarAdmAlquileres(Estado, Tipo);
                else if (Estado != null)
                    admAlquileres.RecuperarAdmAlquileres(Estado);
                else
                    admAlquileres.RecuperarAdmAlquileres(Tipo);


            return AplicarFiltros(admAlquileres, Ambientes, Ubicacion, ValorDesde, ValorHasta,IncluirVencidos);


        }




        private GI.BR.AdmAlquileres.AdmAlquileres AplicarFiltros(GI.BR.AdmAlquileres.AdmAlquileres admAlquileres, GI.BR.Propiedades.Ambiente Ambientes,
                    GI.BR.Propiedades.Ubicacion Ubicacion, GI.BR.Valor ValorDesde, GI.BR.Valor ValorHasta, bool IncluirVencidos)
        {
            GI.BR.AdmAlquileres.AdmAlquileres filtro = new GI.BR.AdmAlquileres.AdmAlquileres();

            foreach (GI.BR.AdmAlquileres.AdmAlquiler adm in admAlquileres)
            {


                if (Ubicacion != null)
                {
                    if (Ubicacion.Pais != null)
                    {
                        if (adm.Alquiler.Ubicacion.Pais.IdPais != Ubicacion.Pais.IdPais)
                            continue;
                    }
                    if (Ubicacion.Provincia != null)
                    {
                        if (adm.Alquiler.Ubicacion.Provincia.IdProvincia != Ubicacion.Provincia.IdProvincia)
                            continue;
                    }



                    if (Ubicacion.Localidad != null)
                    {
                        if (adm.Alquiler.Ubicacion.Localidad.IdLocalidad != Ubicacion.Localidad.IdLocalidad)
                            continue;
                    }

                    if (Ubicacion.Barrio != null)
                    {
                        if (adm.Alquiler.Ubicacion.Barrio.IdBarrio != Ubicacion.Barrio.IdBarrio)
                            continue;
                    }
                }




                if (Ambientes != null)
                {
                    if (Ambientes.CantidadAmbientes != adm.Alquiler.CantidadAmbientes)
                        continue;
                }


                if (ValorDesde != null)
                {
                    if (adm.Alquiler.ValorPublicacion.Moneda.IdMoneda != ValorDesde.Moneda.IdMoneda || adm.Alquiler.ValorPublicacion.Importe < ValorDesde.Importe)
                        continue;
                }

                if (ValorHasta != null)
                {
                    if (adm.Alquiler.ValorPublicacion.Moneda.IdMoneda != ValorHasta.Moneda.IdMoneda || adm.Alquiler.ValorPublicacion.Importe > ValorHasta.Importe)
                        continue;
                }

                if (!IncluirVencidos)
                {
                    if (adm.ContratoVigente.FechaCancelacion.HasValue)
                        if (adm.ContratoVigente.FechaCancelacion.Value < DateTime.Today)
                            continue;
                    if (adm.ContratoVigente.FechaVencimiento < DateTime.Today)
                        continue;
                }

                filtro.Add(adm);
            }
            return filtro;
        }


        public GI.BR.AdmAlquileres.AdmAlquileres RecuperarAdmAlquileresPorInquilinos(string Nombres, bool IncluirVencidos)
        {
            GI.BR.AdmAlquileres.AdmAlquileres admAlquileres = new GI.BR.AdmAlquileres.AdmAlquileres();
            admAlquileres.RecuperarAdmAlquileresPorNombreInquilino(Nombres);
            return AplicarFiltros(admAlquileres,null,null,null,null,IncluirVencidos);
        }

        public GI.BR.AdmAlquileres.AdmAlquileres RecuperarAdmAlquileresPorCodigoPropiedad(string CodigoPropiedad, bool IncluirVencidos)
        {
            GI.BR.AdmAlquileres.AdmAlquileres admAlquileres = new GI.BR.AdmAlquileres.AdmAlquileres();
            admAlquileres.RecuperarAdmAlquileresPorCodigoPropiedad(CodigoPropiedad);
            return AplicarFiltros(admAlquileres,null,null,null,null,IncluirVencidos);;
        }
    }
}
