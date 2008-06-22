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
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                //El control se carga despues, del postback, salgo a buscar las propiedades manualmente.
                CtrlBuscadorPropiedades1.cargarPropiedades();
                GI.BR.Propiedades.Propiedades propiedades = (GI.BR.Propiedades.Propiedades)Session["Propiedades"];
                if (propiedades != null)
                {
                    DataList1.DataSource = propiedades;
                    foreach (GI.BR.Propiedades.Propiedad p in propiedades)
                    {
                        
                    }
                }
            }
        }
    }
}
