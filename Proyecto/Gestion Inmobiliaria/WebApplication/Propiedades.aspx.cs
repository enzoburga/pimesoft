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
                

            DataList1.DataSource = CreateDataSource();
            DataList1.DataBind();
            }
        }

        ICollection CreateDataSource()
        {
            Managers.mngImagenesPropiedades mngImagenes = new WebApplication.Managers.mngImagenesPropiedades();
 
            DataTable dt = new DataTable();
            DataRow dr;

            dt.Columns.Add(new DataColumn("Imagen", typeof(string)));
            dt.Columns.Add(new DataColumn("Detalles", typeof(string)));
            dt.Columns.Add(new DataColumn("Link", typeof(string)));

            CtrlBuscadorPropiedades1.cargarPropiedades();

            GI.BR.Propiedades.Propiedades propiedades = (GI.BR.Propiedades.Propiedades)Session["Propiedades"];

            LinkButton lb;
            foreach (GI.BR.Propiedades.Propiedad p in propiedades)
            {
                dr = dt.NewRow();
                dr[0] = mngImagenes.GetPathImagenChica(p.GaleriaFotos.GetFotoFachada, p.IdPropiedad);
                dr[1] = p.Observaciones;
                dr[2] = "http://www.google.com";
                dt.Rows.Add(dr);
            }

            DataView dv = new DataView(dt);
            return dv;
        }

        private void lb_Click(object sender, EventArgs e)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        
    }
}
