using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace GI.BR.Pedidos
{
    public class Pedidos: List<Pedido>
    {
        public void RecuperarPedidosTodos()
        {
            using (IDataReader dr = new GI.DA.PedidosData().RecuperarPedidosTodos())
            {
                GI.BR.Pedidos.Pedido pedido;
                this.Clear();
                while (dr.Read())
                {
                    pedido = new Pedido();
                    pedido.fill(dr);
                    this.Add(pedido);
                }
            }
        }

        public void RecuperarPedidos(GI.BR.Propiedades.EstadoPropiedad Estado, GI.BR.Propiedades.TipoPropiedad Tipo)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void RecuperarPedidos(GI.BR.Propiedades.EstadoPropiedad Estado)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void RecuperarPedidos(GI.BR.Propiedades.TipoPropiedad Tipo)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void RecuperarPedidosPorContacto(string Nombres)
        {
            using (IDataReader dr = new GI.DA.PedidosData().RecuperarPedidosPorNombreContacto(Nombres))
            {
                GI.BR.Pedidos.Pedido pedido;
                this.Clear();
                while (dr.Read())
                {
                    pedido = new Pedido();
                    pedido.fill(dr);
                    this.Add(pedido);
                }
            }
        }
    }
}
