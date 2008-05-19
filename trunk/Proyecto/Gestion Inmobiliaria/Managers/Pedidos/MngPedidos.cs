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


        public GI.BR.Pedidos.Pedidos RecuperarPedidos(GI.BR.Propiedades.TipoPropiedad Tipo,
                    GI.BR.Propiedades.EstadoPropiedad Estado, GI.BR.Propiedades.Ambiente Ambientes,
                    GI.BR.Propiedades.Ubicacion Ubicacion, GI.BR.Valor ValorDesde, GI.BR.Valor ValorHasta, Type tipo)
        {
            GI.BR.Pedidos.Pedidos pedidos = new GI.BR.Pedidos.Pedidos();

            if (Tipo == null && Estado == null)
                pedidos.RecuperarPedidosTodos();
            else if (Estado != null && Tipo != null)
                pedidos.RecuperarPedidos(Estado, Tipo);
            else if (Estado != null)
                pedidos.RecuperarPedidos(Estado);
            else
                pedidos.RecuperarPedidos(Tipo);

            return AplicarFiltros(pedidos, Ambientes, Ubicacion, ValorDesde, ValorHasta, tipo);
        }


        private GI.BR.Pedidos.Pedidos AplicarFiltros(GI.BR.Pedidos.Pedidos pedidos, GI.BR.Propiedades.Ambiente Ambientes,
                    GI.BR.Propiedades.Ubicacion Ubicacion, GI.BR.Valor ValorDesde, GI.BR.Valor ValorHasta, Type tipo)
        {
            GI.BR.Pedidos.Pedidos filtro = new GI.BR.Pedidos.Pedidos();

            foreach (GI.BR.Pedidos.Pedido p in pedidos)
            {


                if (Ubicacion != null)
                {
                    if (Ubicacion.Pais != null && p.Ubicacion.Pais != null)
                    {
                        if (p.Ubicacion.Pais.IdPais != Ubicacion.Pais.IdPais)
                            continue;
                    }
                    if (Ubicacion.Provincia != null && p.Ubicacion.Provincia != null)
                    {
                        if (p.Ubicacion.Provincia.IdProvincia != Ubicacion.Provincia.IdProvincia)
                            continue;
                    }



                    if (Ubicacion.Localidad != null && p.Ubicacion.Localidad != null)
                    {
                        if (p.Ubicacion.Localidad.IdLocalidad != Ubicacion.Localidad.IdLocalidad)
                            continue;
                    }

                    if (Ubicacion.Barrio != null && p.Ubicacion.Barrio != null)
                    {
                        if (p.Ubicacion.Barrio.IdBarrio != Ubicacion.Barrio.IdBarrio)
                            continue;
                    }
                }


                if (Ambientes != null)
                {
                    if (Ambientes.CantidadAmbientes < p.CantidadAmbientesInicial.CantidadAmbientes || Ambientes.CantidadAmbientes > p.CantidadAmbientesFinal.CantidadAmbientes)
                        continue;
                }


                if (ValorDesde != null)
                {
                    if(p.Moneda != null)
                        if (p.Moneda.IdMoneda != ValorDesde.Moneda.IdMoneda || p.ValorFinal < ValorDesde.Importe)
                            continue;
                }

                if (ValorHasta != null)
                {
                    if (p.Moneda != null)
                        if (p.Moneda.IdMoneda != ValorHasta.Moneda.IdMoneda || p.ValorInicial > ValorHasta.Importe)
                            continue;
                }

                if (p.EstadoPropiedad != tipo)
                    continue;

                filtro.Add(p);
            }
            return filtro;
        }


        public GI.BR.Pedidos.Pedidos RecuperarPedidosPorContacto(string Nombres , Type tipo)
        {
            GI.BR.Pedidos.Pedidos pedidos = new GI.BR.Pedidos.Pedidos();
            pedidos.RecuperarPedidosPorContacto(Nombres);
            AplicarFiltros(pedidos, null, null, null, null, tipo);
            return pedidos;
        }

        #endregion
    }
}
