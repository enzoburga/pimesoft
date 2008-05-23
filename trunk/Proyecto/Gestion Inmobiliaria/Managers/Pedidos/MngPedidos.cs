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
            GI.BR.Propiedades.Propiedades propiedades = new GI.BR.Propiedades.Propiedades();
            switch (pedido.EstadoPropiedad.ToString())
            {
                case "GI.BR.Propiedades.Alquiler": propiedades.RecuperarPropiedadesAlquileresOfrecidas(pedido); break;
                case "GI.BR.Propiedades.Venta": propiedades.RecuperarPropiedadesVentasOfrecidas(pedido); break;
            }

            return propiedades;
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

                if (!CoincidePropiedadPedido(p, pedido))
                    continue;

                filtro.Add(p);
            }
            return filtro;
        }

        private bool CoincidePropiedadPedido(GI.BR.Propiedades.Propiedad propiedad, GI.BR.Pedidos.Pedido pedido)
        {
            if (pedido.CantidadAmbientesFinal != null)
                if (propiedad.CantidadAmbientes > pedido.CantidadAmbientesFinal.CantidadAmbientes)
                    return false;

            if (pedido.CantidadAmbientesInicial != null)
                if (propiedad.CantidadAmbientes < pedido.CantidadAmbientesInicial.CantidadAmbientes)
                    return false;

            if (pedido.Categoria != null && propiedad.Categoria != null)
                if (propiedad.Categoria.IdCategoria != pedido.Categoria.IdCategoria)
                    return false;

            if (pedido.Disposicion != null)
                if (propiedad.Disposicion != pedido.Disposicion.Value)
                    return false;

            if (pedido.EnumEstado != null)
                if (propiedad.EnumEstado != pedido.EnumEstado.Value)
                    return false;

            if (pedido.EsAptoProfesional != null)
                if (propiedad.EsAptoProfesional != pedido.EsAptoProfesional)
                    return false;

            if (pedido.Estado != null && propiedad.Estado != null)
                if (propiedad.Estado.IdEstadoPropiedad != pedido.Estado.IdEstadoPropiedad)
                    return false;

            if (pedido.MetrosConstruiblesFinal > 0)
            {
                if (pedido.MetrosConstruiblesFinal < propiedad.MetrosConstruibles)
                    return false;

                if (pedido.MetrosConstruiblesInicial > propiedad.MetrosConstruibles)
                    return false;
            }

            if (pedido.MetrosCubiertosFinal > 0 && propiedad.MedidasPropiedad != null)
            {
                if (pedido.MetrosCubiertosFinal < propiedad.MedidasPropiedad.MetrosCubiertos)
                    return false;

                if (pedido.MetrosCubiertosInicial > propiedad.MedidasPropiedad.MetrosCubiertos)
                    return false;
            }

            if (pedido.MetrosTerrenoFinal > 0 && propiedad.MedidasTerreno != null)
            {
                if (pedido.MetrosTerrenoFinal < propiedad.MedidasTerreno.Metros)
                    return false;

                if (pedido.MetrosTerrenoInicial > propiedad.MedidasTerreno.Metros)
                    return false;
            }

            if (pedido.Moneda != null && propiedad.ValorPublicacion != null && propiedad.ValorPublicacion.Moneda != null)
            {
                //CONSULTAR VALOR DOLAR POR WEB!!??!?

                if (pedido.Moneda.IdMoneda == propiedad.ValorPublicacion.Moneda.IdMoneda)
                {
                    if (pedido.ValorFinal < propiedad.ValorPublicacion.Importe)
                        return false;

                    if (pedido.ValorInicial > propiedad.ValorPublicacion.Importe)
                        return false;
                }
                else
                    return false;

            }

            if (pedido.TipoPropiedad != null)
                if (pedido.TipoPropiedad.IdTipoPropiedad != propiedad.TipoPropiedad.IdTipoPropiedad)
                    return false;

            if (pedido.TipoZona != null && propiedad.TipoZona != TipoZona.SinDefinir)
                if (propiedad.TipoZona != pedido.TipoZona)
                    return false;

            
            if (pedido.Ubicacion.Pais != null && propiedad.Ubicacion.Pais != null)
            {
                if (pedido.Ubicacion.Pais.IdPais != propiedad.Ubicacion.Pais.IdPais)
                    return false;

                if (pedido.Ubicacion.Provincia != null && propiedad.Ubicacion.Provincia != null)
                {
                    if (pedido.Ubicacion.Provincia.IdProvincia != propiedad.Ubicacion.Provincia.IdProvincia)
                        return false;

                    if (pedido.Ubicacion.Barrio != null && propiedad.Ubicacion.Barrio != null)
                    {
                        if (pedido.Ubicacion.Barrio.IdBarrio != propiedad.Ubicacion.Barrio.IdBarrio)
                            return false;

                        if (pedido.Ubicacion.Localidad != null && propiedad.Ubicacion.Localidad != null)
                            if (pedido.Ubicacion.Localidad.IdLocalidad != propiedad.Ubicacion.Localidad.IdLocalidad)
                                return false;
                    }
                }
            }





            return true;

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


        public GI.BR.Pedidos.Pedidos RecuperarPedidosPorPropiedadSinOfrecer(GI.BR.Propiedades.Propiedad propiedad)
        {
            GI.BR.Pedidos.Pedidos pedidos = new GI.BR.Pedidos.Pedidos();
            pedidos.RecuperarPedidosTodosSinOfrecer(propiedad);
            return AplicarFiltrosPedidosPorPropiedad(propiedad, pedidos,false);
            
        }

        public GI.BR.Pedidos.Pedidos RecuperarPedidosTodos(bool IncluirHistóricos)
        {
            GI.BR.Pedidos.Pedidos pedidos = new GI.BR.Pedidos.Pedidos();
            pedidos.RecuperarPedidosTodos();
            return AplicarFiltrosPedidos(pedidos,null, false);

        }

        private GI.BR.Pedidos.Pedidos AplicarFiltrosPedidosPorPropiedad(GI.BR.Propiedades.Propiedad propiedad, GI.BR.Pedidos.Pedidos pedidos, bool incluirHistoricos)
        {
            GI.BR.Pedidos.Pedidos filtro = new GI.BR.Pedidos.Pedidos();

            foreach (GI.BR.Pedidos.Pedido p in pedidos)
            {
                if (!incluirHistoricos)
                    if (!p.Activo)
                        continue;

                if (p.EstadoPropiedad != propiedad.GetType())
                    continue;

                if (!CoincidePropiedadPedido(propiedad, p))
                    continue;

                filtro.Add(p);
            }
            return filtro;
        }

        #endregion
    }
}
