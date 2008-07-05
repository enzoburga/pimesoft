using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades.Tranasacciones
{
    public class TransaccionPedido : Transaccion
    {

        public TransaccionPedido()
            : base()
        { 
            
        }

        private int idPedido;
        private BR.Pedidos.Pedido pedido;

        public BR.Pedidos.Pedido Pedido
        {
            get 
            {
                if (pedido == null && IdPedido > 0)
                {
                    pedido = new GI.BR.Pedidos.Pedido();
                    pedido.RecuperarPorId(IdPedido);
                }
                return pedido; 
            }
            set { pedido = value; }
        }


        public int IdPedido
        {
            get { return idPedido; }
            set { idPedido = value; }
        }


        public override bool Crear()
        {
            IdTransaccion = new DA.TransaccionesData().CrearTransaccionPedido(IdPedido, (int)TipoTransaccion, Fecha);
            return IdTransaccion > 0;
        }
    }
}
