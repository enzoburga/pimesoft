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
