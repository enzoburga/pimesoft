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
            lMensaje.Text = "";
            //Si clickearon en buscar, recupero las propiedades.
            if (IsPostBack)
            {
                CtrlBuscadorPropiedades1.cargarPropiedades();
                if (((GI.BR.Propiedades.Propiedades)Session["Propiedades"]).Count == 0)
                    lMensaje.Text = "No se han encontrado propiedades que se ajunten al criterio de búsqueda.";
                    

            }

            PagedDataSource objPds = new PagedDataSource();
            objPds.DataSource = ((DataView)CreateDataSource()).Table.DefaultView;
            objPds.AllowPaging = true;
            objPds.PageSize = 5;

            int CurPage;

            if (Request.QueryString["IDP"] != null)
                CurPage = Convert.ToInt32(Request.QueryString["IDP"]);
            else
                CurPage = 1;

            objPds.CurrentPageIndex = CurPage - 1;
            strPaginacion = "";

            if (HayPropiedades())
            {

                if (!objPds.IsFirstPage)
                    strPaginacion = "<a href='Propiedades.aspx?IDP=" + Convert.ToString(CurPage - 1) + "' >&lt;&lt; anterior</a>";

                if (objPds.PageCount > 0)
                    strPaginacion += "<span > (página " + CurPage.ToString() + " de " + objPds.PageCount.ToString() + ")</span> ";

                if (objPds.PageCount > 1)
                    if (!objPds.IsLastPage)
                        strPaginacion += "<a href='Propiedades.aspx?IDP=" + Convert.ToString(CurPage + 1) + "' >siguiente &gt;&gt;</a>";
            }
            DataList1.DataSource = objPds;
            DataList1.DataBind();
        }

        private bool HayPropiedades()
        {
            if (Session["Propiedades"] != null && ((GI.BR.Propiedades.Propiedades)Session["Propiedades"]).Count != 0)
                return true;

            return false;
        }

        //
        protected string GetPaginacion()
        {
            return (strPaginacion);
        }

        private ICollection CreateDataSource()
        {
            Managers.mngImagenesPropiedades mngImagenes = new WebApplication.Managers.mngImagenesPropiedades();
 
            DataTable dt = new DataTable();
            DataRow dr;
            
            dt.Columns.Add(new DataColumn("Thumbnail", typeof(string)));
            dt.Columns.Add(new DataColumn("Detalles", typeof(string)));
            dt.Columns.Add(new DataColumn("Link", typeof(string)));
            dt.Columns.Add(new DataColumn("Direccion", typeof(string)));
            dt.Columns.Add(new DataColumn("Ubicacion", typeof(string)));
            dt.Columns.Add(new DataColumn("Valor", typeof(string)));

            //El control se carga despues, del postback, salgo a buscar las propiedades manualmente.
            

            GI.BR.Propiedades.Propiedades propiedades = (GI.BR.Propiedades.Propiedades)Session["Propiedades"];

            if (propiedades != null)
            {
                foreach (GI.BR.Propiedades.Propiedad p in propiedades)
                {
                    dr = dt.NewRow();
                    dr[0] = mngImagenes.GetPathThumbnail(p.GaleriaFotos.GetFotoFachada, p.IdPropiedad);
                    dr[1] = p.Observaciones;
                    dr[2] = "Ficha.aspx?Propiedad=" + p.IdPropiedad.ToString();
                    dr[3] = p.Direccion.ToStringReporte();
                    dr[4] = p.Ubicacion.Localidad.ToString() + " - " + p.Ubicacion.Barrio.ToString();
                    dr[5] = p.ValorPublicacion.ToString();

                    dt.Rows.Add(dr);
                }
            }
            
            DataView dv = new DataView(dt);
            
            return dv;
        }

        
    }
}
