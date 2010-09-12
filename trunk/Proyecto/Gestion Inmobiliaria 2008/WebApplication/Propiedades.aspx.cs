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
    public partial class Propiedades : System.Web.UI.Page
    {
        string strPaginacion = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            ListadoPropiedades1.CargarListado(false, (GI.BR.Propiedades.Propiedades)Session["Propiedades"]);
        }  
      
        protected void ibBuscar_Click(object sender, ImageClickEventArgs e)
        {
            CtrlBuscadorPropiedades1.cargarPropiedades();
            ListadoPropiedades1.CargarListado(true, (GI.BR.Propiedades.Propiedades)Session["Propiedades"]);           
        }

        
    }
}
