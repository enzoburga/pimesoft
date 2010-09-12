using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Pedidos
{
    public partial class TabContenidoPedidos : Framework.Seguridad.ControlGISeguridad
    {
        public TabContenidoPedidos()
        {
            InitializeComponent();
        }

        private GI.BR.Pedidos.Pedido pedido;


        public GI.BR.Pedidos.Pedido Pedido
        {
            get
            {
                return pedido;
            }
            set
            {
                pedido = value;
                Inicializar();
                CargarPedido();
            }
        }

        protected virtual void Inicializar()
        {
            return;
        }

        protected virtual void CargarPedido()
        {
            return;
        }

        public virtual GI.BR.Pedidos.Pedido getPedido()
        {
            return pedido;
        }
    }
}
