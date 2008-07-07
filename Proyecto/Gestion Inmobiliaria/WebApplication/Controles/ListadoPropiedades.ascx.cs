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

namespace WebApplication.Controles
{
    public partial class ListadoPropiedades : System.Web.UI.UserControl
    {

        string strPaginacion = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected string GetPaginacion()
        {
            return (strPaginacion);
        }

        private ICollection CreateDataSource(GI.BR.Propiedades.Propiedades propiedades)
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
            dt.Columns.Add(new DataColumn("Codigo", typeof(string)));
            dt.Columns.Add(new DataColumn("Reservado", typeof(string)));

            if (propiedades != null)
            {
                foreach (GI.BR.Propiedades.Propiedad p in propiedades)
                {
                    dr = dt.NewRow();
                    dr[0] = mngImagenes.GetPathThumbnailListado(p.GaleriaFotos.GetFotoFachada, p.IdPropiedad);
                    dr[1] = p.Observaciones;
                    dr[2] = "Ficha.aspx?Propiedad=" + p.IdPropiedad.ToString();
                    dr[3] = p.Direccion.ToStringReporte();
                    dr[4] = p.Ubicacion.Localidad.ToString() + " - " + p.Ubicacion.Barrio.ToString();
                    if (p.PublicarSinPrecio)
                        dr[5] = "<a href='mailto:info@pime.com.ar'>Consultar</a>";
                    else
                        dr[5] = p.ValorPublicacion.ToString();
                    dr[6] = p.Codigo.ToString();

                    if (p.Estado != null)
                    {
                        if (p.Estado.Descripcion == "Reservado")
                            dr[7] = "<br>Reservado</br>";
                        else
                            dr[7] = "";
                    }
                    dt.Rows.Add(dr);
                }
            }

            DataView dv = new DataView(dt);

            return dv;
        }

        public void CargarListado(bool resetearPaginador, GI.BR.Propiedades.Propiedades propiedades)
        {
            if (propiedades != null)
            {
                if (propiedades.Count == 0)
                    lMensaje.Text = "No se han encontrado propiedades que se ajunten al criterio de búsqueda.";

                #region cargar listado y paginador
                PagedDataSource objPds = new PagedDataSource();
                objPds.DataSource = ((DataView)CreateDataSource(propiedades)).Table.DefaultView;
                objPds.AllowPaging = true;
                objPds.PageSize = 5;

                int CurPage;

                if (Request.QueryString["IDP"] != null && !resetearPaginador)
                    CurPage = Convert.ToInt32(Request.QueryString["IDP"]);
                else
                    CurPage = 1;

                objPds.CurrentPageIndex = CurPage - 1;
                strPaginacion = "";

                if (propiedades.Count > 0)
                {

                    if (!objPds.IsFirstPage)
                        strPaginacion = "<a href='" + GetCurrentPageName() + "?IDP=" + Convert.ToString(CurPage - 1) + "' >&lt;&lt; anterior</a>";

                    if (objPds.PageCount > 0)
                        strPaginacion += "<span > (página " + CurPage.ToString() + " de " + objPds.PageCount.ToString() + ")</span> ";

                    if (objPds.PageCount > 1)
                        if (!objPds.IsLastPage)
                            strPaginacion += "<a href='" + GetCurrentPageName() + "?IDP=" + Convert.ToString(CurPage + 1) + "' >siguiente &gt;&gt;</a>";
                }
                DataList1.DataSource = objPds;
                DataList1.DataBind();
                #endregion
            }
        }

        public string GetCurrentPageName()
        {
            string sPath = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
            System.IO.FileInfo oInfo = new System.IO.FileInfo(sPath);
            string sRet = oInfo.Name;
            return sRet;
        } 
    }
}