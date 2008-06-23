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
    public partial class Ficha : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Label1.Text = GetPropiedadSeleccionada.Observaciones;
            
        }

        private GI.BR.Propiedades.Propiedad GetPropiedadSeleccionada
        {
            get
            {
                int idPropiedad = int.Parse(HttpContext.Current.Request.QueryString["Propiedad"].ToString());
                GI.BR.Propiedades.Propiedades propiedades = (GI.BR.Propiedades.Propiedades)Session["Propiedades"]; 
                foreach (GI.BR.Propiedades.Propiedad p in propiedades)
                {
                    if (p.IdPropiedad == idPropiedad)
                        return p;
                }

                throw new Exception("Propiedad no encontrada en la sesion.");
            }
        }
    }
}
