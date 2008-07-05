using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Managers.Pedidos
{
    public class MngPedidosWeb
    {


        public bool CrearPedidoWeb(GI.BR.Pedidos.Pedido Pedido)
        {
            if (!Pedido.Guardar())
                return false;


            GI.BR.Propiedades.Tranasacciones.TransaccionPedido trans = new GI.BR.Propiedades.Tranasacciones.TransaccionPedido();
            trans.Activa = true;
            trans.Estado = GI.BR.Propiedades.Tranasacciones.EnumEstadoTrans.Pendiente;
            trans.Fecha = DateTime.Now;
            trans.IdPedido = Pedido.IdPedido;
            trans.TipoTransaccion = GI.BR.Propiedades.Tranasacciones.EnumTipoTransaccion.Crear;
            trans.Crear();


            return true;
        
        
        
        
        
        }



    }
}
