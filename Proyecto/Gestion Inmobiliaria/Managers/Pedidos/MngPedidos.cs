using System;
using System.Collections.Generic;
using System.Text;
using GI.BR.Propiedades;

namespace GI.Managers.Pedidos
{
    public class MngPedidos
    {

        #region Metodos Publicos

        public GI.BR.Propiedades.Propiedades GetPropiedadesOfrecidas(GI.BR.Pedidos.Pedido pedido)
        {
            return new GI.BR.Propiedades.Propiedades();
        }

        public GI.BR.Propiedades.Propiedades GetPropiedadesSinOfrecer(GI.BR.Pedidos.Pedido pedido)
        {
            return new GI.BR.Propiedades.Propiedades();
        }




        private GI.BR.Propiedades.Propiedades AplicarFiltrosPropiedades(GI.BR.Propiedades.Propiedades propiedades, GI.BR.Propiedades.Ambiente Ambientes,
                    GI.BR.Propiedades.Ubicacion Ubicacion, GI.BR.Valor ValorDesde, GI.BR.Valor ValorHasta, Type tipo)
        {
            GI.BR.Propiedades.Propiedades filtro = new GI.BR.Propiedades.Propiedades();

            foreach (GI.BR.Propiedades.Propiedad p in propiedades)
            {


            //    if (Ubicacion != null)
            //    {
            //        if (Ubicacion.Pais != null && p.Ubicacion.Pais != null)
            //        {
            //            if (p.Ubicacion.Pais.IdPais != Ubicacion.Pais.IdPais)
            //                continue;
            //        }
            //        if (Ubicacion.Provincia != null && p.Ubicacion.Provincia != null)
            //        {
            //            if (p.Ubicacion.Provincia.IdProvincia != Ubicacion.Provincia.IdProvincia)
            //                continue;
            //        }



            //        if (Ubicacion.Localidad != null && p.Ubicacion.Localidad != null)
            //        {
            //            if (p.Ubicacion.Localidad.IdLocalidad != Ubicacion.Localidad.IdLocalidad)
            //                continue;
            //        }

            //        if (Ubicacion.Barrio != null && p.Ubicacion.Barrio != null)
            //        {
            //            if (p.Ubicacion.Barrio.IdBarrio != Ubicacion.Barrio.IdBarrio)
            //                continue;
            //        }
            //    }


            //    if (Ambientes != null)
            //    {
            //        if (Ambientes.CantidadAmbientes < p.CantidadAmbientesInicial.CantidadAmbientes || Ambientes.CantidadAmbientes > p.CantidadAmbientesFinal.CantidadAmbientes)
            //            continue;
            //    }


            //    if (ValorDesde != null)
            //    {
            //        if(p.Moneda != null)
            //            if (p.Moneda.IdMoneda != ValorDesde.Moneda.IdMoneda || p.ValorFinal < ValorDesde.Importe)
            //                continue;
            //    }

            //    if (ValorHasta != null)
            //    {
            //        if (p.Moneda != null)
            //            if (p.Moneda.IdMoneda != ValorHasta.Moneda.IdMoneda || p.ValorInicial > ValorHasta.Importe)
            //                continue;
            //    }

            //    if (p.EstadoPropiedad != tipo)
            //        continue;

                filtro.Add(p);
            }
            return filtro;
        }


        public GI.BR.Pedidos.Pedidos AplicarFiltrosPedidos(GI.BR.Pedidos.Pedidos pedidos, Type tipo, bool IncluirHistóricos)
        {
            GI.BR.Pedidos.Pedidos filtro = new GI.BR.Pedidos.Pedidos();

            foreach (GI.BR.Pedidos.Pedido p in pedidos)
            {
                if (!IncluirHistóricos)
                    if (!p.Activo)
                        continue;

                if(tipo != null)
                    if (p.EstadoPropiedad != tipo)
                        continue;

                filtro.Add(p);
            }

            return filtro;

        }

        public GI.BR.Pedidos.Pedidos RecuperarPedidosPorContacto(string Nombres , Type tipo, bool IncluirHistóricos)
        {
            GI.BR.Pedidos.Pedidos pedidos = new GI.BR.Pedidos.Pedidos();
            pedidos.RecuperarPedidosPorContacto(Nombres);
            return AplicarFiltrosPedidos(pedidos, tipo,IncluirHistóricos);
        }

        #endregion
    }
}
