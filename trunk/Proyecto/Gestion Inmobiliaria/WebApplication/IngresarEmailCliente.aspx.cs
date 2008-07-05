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
    public partial class IngresarEmailCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bAceptar_Click(object sender, ImageClickEventArgs e)
        {
            if (tbConfirmar.Text.ToLower() != tbEmail.Text.ToLower())
                lError.Text = "Verifique las direcciones de Email, deben ser identicas.";
            else
            {
                GI.Managers.Clientes.mngClientes mng = new GI.Managers.Clientes.mngClientes();
                GI.BR.Clientes.ClientePedido cp = mng.RecuperarClientePedidoPorEmail(tbEmail.Text);
                if (cp == null)
                {
                    Session["Email"] = tbEmail.Text;
                    Response.Redirect("AltaClientePedido.aspx");
                }
                else
                {
                    Session["ClientePedido"] = cp;
                    Response.Redirect("Pedido.aspx");
                }

                //recupero cliente por email.
                //si lo encuentro red a cargarpedido
                //sino a cargar cliente.
            }
        }
    }
}
