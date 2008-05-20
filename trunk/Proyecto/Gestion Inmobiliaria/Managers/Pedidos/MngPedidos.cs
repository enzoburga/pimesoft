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
            GI.BR.Propiedades.Propiedades propiedades = new GI.BR.Propiedades.Propiedades();
            switch (pedido.EstadoPropiedad.ToString())
            {
                case "GI.BR.Propiedades.Alquiler": propiedades.RecuperarPropiedadesAlquileresSinOfrecer(pedido); break;
                case "GI.BR.Propiedades.Venta": propiedades.RecuperarPropiedadesVentasSinOfrecer(pedido); break;
            }

            return AplicarFiltrosPropiedades(propiedades, pedido);
        }




        private GI.BR.Propiedades.Propiedades AplicarFiltrosPropiedades(GI.BR.Propiedades.Propiedades propiedades, GI.BR.Pedidos.Pedido pedido)
        {
            GI.BR.Propiedades.Propiedades filtro = new GI.BR.Propiedades.Propiedades();

            foreach (GI.BR.Propiedades.Propiedad p in propiedades)
            {

                if (pedido.CantidadAmbientesFinal != null)
                    if (p.CantidadAmbientes > pedido.CantidadAmbientesFinal.CantidadAmbientes)
                        continue;

                if (pedido.CantidadAmbientesInicial != null)
                    if (p.CantidadAmbientes < pedido.CantidadAmbientesInicial.CantidadAmbientes)
                        continue;

                if (pedido.Categoria != null && p.Categoria != null)
                    if (p.Categoria.IdCategoria != pedido.Categoria.IdCategoria)
                        continue;

                if (pedido.Disposicion != null)
                    if (p.Disposicion != pedido.Disposicion.Value)
                        continue;

                if (pedido.EnumEstado != null)
                    if (p.EnumEstado != pedido.EnumEstado.Value)
                        continue;

                if (pedido.EsAptoProfesional != null)
                    if (p.EsAptoProfesional != pedido.EsAptoProfesional)
                        continue;

                if (pedido.Estado != null && p.Estado != null)
                    if (p.Estado.IdEstadoPropiedad != pedido.Estado.IdEstadoPropiedad)
                        continue;

                if(pedido.MetrosConstruiblesFinal > 0)
                    if (pedido.MetrosConstruiblesFinal < p.MetrosConstruibles)
                        continue;

                if (pedido.MetrosConstruiblesInicial > p.MetrosConstruibles)
                    continue;
                
                if(pedido.MetrosCubiertosFinal > 0 && p.MedidasPropiedad != null)
                    if (pedido.MetrosCubiertosFinal< p.MedidasPropiedad.MetrosCubiertos)
                        continue;

                if (pedido.MetrosCubiertosInicial > p.MedidasPropiedad.MetrosCubiertos)
                    continue;

                if (pedido.MetrosTerrenoFinal > 0 && p.MedidasTerreno != null)
                    if (pedido.MetrosTerrenoFinal < p.MedidasTerreno.Metros)
                        continue;

                if (pedido.MetrosTerrenoInicial > p.MedidasTerreno.Metros)
                    continue;

                if (pedido.Moneda != null && p.ValorPublicacion != null && p.ValorPublicacion.Moneda != null)
                { 
                    //CONSULTAR VALOR DOLAR POR WEB!!??!?

                    if (pedido.Moneda.IdMoneda == p.ValorPublicacion.Moneda.IdMoneda)
                    {
                        if (pedido.ValorFinal < p.ValorPublicacion.Importe)
                            continue;

                        if (pedido.ValorInicial > p.ValorPublicacion.Importe)
                            continue;
                    }
                    else
                        continue;

                }

                if (pedido.TipoPropiedad != null)
                    if (pedido.TipoPropiedad.IdTipoPropiedad != p.TipoPropiedad.IdTipoPropiedad)
                        continue;

                if (pedido.TipoZona != null && p.TipoZona != TipoZona.SinDefinir)
                    if (p.TipoZona != pedido.TipoZona)
                        continue;

                if (pedido.Ubicacion.Barrio != null && p.Ubicacion.Barrio != null)
                    if (pedido.Ubicacion.Barrio.IdBarrio != p.Ubicacion.Barrio.IdBarrio)
                        continue;

                if (pedido.Ubicacion.Localidad != null && p.Ubicacion.Localidad != null)
                    if (pedido.Ubicacion.Localidad.IdLocalidad != p.Ubicacion.Localidad.IdLocalidad)
                        continue;

                if (pedido.Ubicacion.Pais != null && p.Ubicacion.Pais != null)
                    if (pedido.Ubicacion.Pais.IdPais != p.Ubicacion.Pais.IdPais)
                        continue;

                if (pedido.Ubicacion.Provincia != null && p.Ubicacion.Provincia != null)
                    if (pedido.Ubicacion.Provincia.IdProvincia != p.Ubicacion.Provincia.IdProvincia)
                        continue;


                filtro.Add(p);
            }
            return filtro;
        }


        private GI.BR.Pedidos.Pedidos AplicarFiltrosPedidos(GI.BR.Pedidos.Pedidos pedidos, Type tipo, bool IncluirHistóricos)
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
