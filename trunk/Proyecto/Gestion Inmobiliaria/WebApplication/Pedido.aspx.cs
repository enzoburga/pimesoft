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
    public partial class Pedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["ClientePedido"] == null)
                Response.Redirect("IngresarEmailCliente.aspx");

            GI.BR.Clientes.Cliente cliente = (GI.BR.Clientes.Cliente)Session["ClientePedido"];

            lNombres.Text = cliente.ToString();
            lEmail.Text = cliente.Email;



        }

        protected void bEnviarPedido_Click(object sender, ImageClickEventArgs e)
        {          

            GI.Managers.Pedidos.MngPedidosWeb mngPedidoWeb = new GI.Managers.Pedidos.MngPedidosWeb();
            if (mngPedidoWeb.CrearPedidoWeb(CtrlPedido1.GetPedido))
            {
                Session["ClientePedido"] = null;
                Response.Redirect("PedidoEnviado.aspx");
            }
            else
                lError.Text = "Ocurrió un error al enviar el pedido.";

        }

        



    }
}
