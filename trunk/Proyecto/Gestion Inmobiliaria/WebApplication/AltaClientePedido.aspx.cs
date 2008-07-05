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
    public partial class AltaClientePedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tbEmail.Text = Session["Email"].ToString();
        }

        protected void bContinuar_Click(object sender, ImageClickEventArgs e)
        {

            if (tbTelPersonal.Text == "" && tbTelCelular.Text == "" && tbTelLaboral.Text == "")
            {
                lError.Text = "Debe ingresar al menos un telefono.";
                return;
            }
            
            GI.BR.Clientes.ClientePedido cp = new GI.BR.Clientes.ClientePedido();
            cp.Nombres = tbNombre.Text;
            cp.Apellido = tbApellido.Text;
            cp.Email = tbEmail.Text;
            cp.TelefonoCelular = tbTelCelular.Text;
            cp.TelefonoParticular = tbTelPersonal.Text;
            cp.TelefonoTrabajo = tbTelLaboral.Text;
            cp.NroDocumento = "";
            cp.Observaciones = "";
            cp.Ubicacion = new GI.BR.Propiedades.Ubicacion();
            cp.Direccion = new GI.BR.Propiedades.Direccion();
            

            if (cp.Guardar())
            {
                Session["ClientePedido"] = cp;
                Response.Redirect("Pedido.aspx");
            }
            else
                lError.Text = "Ha ocurrido un error al guardar el cliente pedido.";
        }
    }
}
