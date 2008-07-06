using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace WebApplication
{
    public partial class PedidoEnviado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GI.BR.Pedidos.Pedido pedido = (GI.BR.Pedidos.Pedido)Session["Pedido"];

            GI.Managers.Pedidos.MngPedidos mng = new GI.Managers.Pedidos.MngPedidos();
            if (IsPostBack)
            {
                ListadoPropiedades1.CargarListado(true, mng.GetPropiedadesSinOfrecer(pedido));
            }
            else
            {
                ListadoPropiedades1.CargarListado(false, mng.GetPropiedadesSinOfrecer(pedido));
            }
        }
    }
}
