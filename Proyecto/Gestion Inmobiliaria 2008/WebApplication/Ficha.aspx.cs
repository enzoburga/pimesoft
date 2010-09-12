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
            Managers.mngImagenesPropiedades mngImagen = new WebApplication.Managers.mngImagenesPropiedades();

            GI.Reportes.DataSet.DSFichaPropiedadv2 dsFicha = new GI.Reportes.Clases.Propiedades.ReporteFichaPropiedad(GetPropiedadSeleccionada).GetDatasetFichaWeb();


            #region Caracteristicas Propiedad
            GI.Reportes.DataSet.DSFichaPropiedadv2.PropiedadRow pRow = dsFicha.Propiedad[0];
            lDireccion.Text = pRow.Direccion;
            lOperacion.Text = pRow.Operacion;
            lLocalizacion.Text = pRow.Localizacion;
            lAmbientes.Text = pRow.Ambientes;
            lTipoUnidad.Text = pRow.TipoUnidad;
            lOrientacion.Text = pRow.Ubicacion;
            lAntiguedad.Text = pRow.Antiguedad;
            lEstado.Text = pRow.Estado;

            if (GetPropiedadSeleccionada.PublicarSinPrecio)
                lPrecio.Text = "<a href='mailto:" + ConfigurationManager.AppSettings["email"].ToString() + "'>Consultar</a>";
            else
                lPrecio.Text = pRow.Precio;

            lObservaciones.Text = pRow.Observaciones;
            lCodigo.Text = pRow.Codigo;
            #endregion

            #region Superficies
            GI.Reportes.DataSet.DSFichaPropiedadv2.SuperficiesRow sRow = dsFicha.Superficies[0];
            if(!sRow.IsSupNombre1Null())
                lNombSup1.Text = sRow.SupNombre1;
            if (!sRow.IsSupNombre2Null())
                lNombSup2.Text = sRow.SupNombre2;
            if (!sRow.IsSupNombre3Null())
                lNombSup3.Text = sRow.SupNombre3;
            if (!sRow.IsSup1Null())
                lSup1.Text = sRow.Sup1;
            if (!sRow.IsSup2Null())
                lSup2.Text = sRow.Sup2;
            if (!sRow.IsSup3Null())
                lSup3.Text = sRow.Sup3;
            #endregion

            #region Region 1

            GI.Reportes.DataSet.DSFichaPropiedadv2.Region1Row r1Row = dsFicha.Region1[0];

            lTituloDetalles1.Text = r1Row.NombreRegion.ToUpper();
            if (!r1Row.IsCampo1Null())
                r1c1.Text = r1Row.Campo1;

            if (!r1Row.IsCampo2Null())
                r1c2.Text = r1Row.Campo2;

            if (!r1Row.IsCampo3Null())
                r1c3.Text = r1Row.Campo3;

            if (!r1Row.IsCampo4Null())
                r1c4.Text = r1Row.Campo4;

            if (!r1Row.IsCampo5Null())
                r1c5.Text = r1Row.Campo5;

            if (!r1Row.IsCampo6Null())
                r1c6.Text = r1Row.Campo6;

            if (!r1Row.IsCampo7Null())
                r1c7.Text = r1Row.Campo7;

            if (!r1Row.IsCampo8Null())
                r1c8.Text = r1Row.Campo8;

            if (!r1Row.IsCampo9Null())
                r1c9.Text = r1Row.Campo9;

            if (!r1Row.IsValor1Null())
                r1v1.Text = r1Row.Valor1;

            if (!r1Row.IsValor2Null())
                r1v2.Text = r1Row.Valor2;

            if (!r1Row.IsValor3Null())
                r1v3.Text = r1Row.Valor3;

            if (!r1Row.IsValor4Null())
                r1v4.Text = r1Row.Valor4;

            if (!r1Row.IsValor5Null())
                r1v5.Text = r1Row.Valor5;

            if (!r1Row.IsValor6Null())
                r1v6.Text = r1Row.Valor6;

            if (!r1Row.IsValor7Null())
                r1v7.Text = r1Row.Valor7;

            if (!r1Row.IsValor8Null())
                r1v8.Text = r1Row.Valor8;

            if (!r1Row.IsValor9Null())
                r1v9.Text = r1Row.Valor9;

            #endregion

            #region Region 2 (Ambientes)

            GI.Reportes.DataSet.DSFichaPropiedadv2.Region4Row r2Row = dsFicha.Region4[0];

            if (!r2Row.IsCampo1Null())
                r2c1.Text = r2Row.Campo1;

            if (!r2Row.IsCampo2Null())
                r2c2.Text = r2Row.Campo2;

            if (!r2Row.IsCampo3Null())
                r2c3.Text = r2Row.Campo3;

            if (!r2Row.IsCampo4Null())
                r2c4.Text = r2Row.Campo4;

            if (!r2Row.IsCampo5Null())
                r2c5.Text = r2Row.Campo5;

            if (!r2Row.IsCampo6Null())
                r2c6.Text = r2Row.Campo6;

            if (!r2Row.IsCampo7Null())
                r2c7.Text = r2Row.Campo7;

            if (!r2Row.IsCampo8Null())
                r2c8.Text = r2Row.Campo8;

            if (!r2Row.IsCampo9Null())
                r2c9.Text = r2Row.Campo9;

            if (!r2Row.IsCampo10Null())
                r2c10.Text = r2Row.Campo10;

            if (!r2Row.IsCampo11Null())
                r2c11.Text = r2Row.Campo11;

            if (!r2Row.IsCampo12Null())
                r2c12.Text = r2Row.Campo12;

            if (!r2Row.IsCampo13Null())
                r2c13.Text = r2Row.Campo13;

            if (!r2Row.IsCampo14Null())
                r2c14.Text = r2Row.Campo14;

            if (!r2Row.IsCampo15Null())
                r2c15.Text = r2Row.Campo15;

            if (!r2Row.IsCampo16Null())
                r2c16.Text = r2Row.Campo16;

            if (!r2Row.IsCampo17Null())
                r2c17.Text = r2Row.Campo17;

            if (!r2Row.IsCampo18Null())
                r2c18.Text = r2Row.Campo18;





            if (!r2Row.IsValor2Null())
                r2v1.Text = r2Row.Valor1;

            if (!r2Row.IsValor2Null())
                r2v2.Text = r2Row.Valor2;

            if (!r2Row.IsValor3Null())
                r2v3.Text = r2Row.Valor3;

            if (!r2Row.IsValor4Null())
                r2v4.Text = r2Row.Valor4;

            if (!r2Row.IsValor5Null())
                r2v5.Text = r2Row.Valor5;

            if (!r2Row.IsValor6Null())
                r2v6.Text = r2Row.Valor6;

            if (!r2Row.IsValor7Null())
                r2v7.Text = r2Row.Valor7;

            if (!r2Row.IsValor8Null())
                r2v8.Text = r2Row.Valor8;

            if (!r2Row.IsValor9Null())
                r2v9.Text = r2Row.Valor9;

            if (!r2Row.IsValor10Null())
                r2v10.Text = r2Row.Valor10;

            if (!r2Row.IsValor11Null())
                r2v11.Text = r2Row.Valor11;

            if (!r2Row.IsValor12Null())
                r2v12.Text = r2Row.Valor12;

            if (!r2Row.IsValor13Null())
                r2v13.Text = r2Row.Valor13;

            if (!r2Row.IsValor14Null())
                r2v14.Text = r2Row.Valor14;

            if (!r2Row.IsValor15Null())
                r2v15.Text = r2Row.Valor15;

            if (!r2Row.IsValor16Null())
                r2v16.Text = r2Row.Valor16;

            if (!r2Row.IsValor17Null())
                r2v17.Text = r2Row.Valor17;

            if (!r2Row.IsValor18Null())
                r2v18.Text = r2Row.Valor18;

            #endregion

            iFachada.ImageUrl = mngImagen.GetPathImagen(GetFoto(), GetPropiedadSeleccionada.IdPropiedad);


            #region Galeria

            DataList1.DataSource = CreateDataSource();
            DataList1.DataBind();

            #endregion


        }

        private GI.BR.Propiedades.Galeria.Foto GetFoto()
        {
            if(Request.QueryString["IdFoto"] == null)
                return GetPropiedadSeleccionada.GaleriaFotos.GetFotoFachada;
            else
                return GetPropiedadSeleccionada.GaleriaFotos.GetFotoPorId(int.Parse((Request.QueryString["IdFoto"].ToString())));
        }

        private ICollection CreateDataSource()
        {
            Managers.mngImagenesPropiedades mngImagenes = new WebApplication.Managers.mngImagenesPropiedades();

            DataTable dt = new DataTable();
            DataRow dr;

            dt.Columns.Add(new DataColumn("Thumbnail", typeof(string)));
            dt.Columns.Add(new DataColumn("Link", typeof(string)));


            if (GetPropiedadSeleccionada != null)
            {
                
                foreach (GI.BR.Propiedades.Galeria.Foto f in GetPropiedadSeleccionada.GaleriaFotos)
                {
                    dr = dt.NewRow();
                    dr[0] = mngImagenes.GetPathThumbnailFicha(f, GetPropiedadSeleccionada.IdPropiedad);
                    dr[1] = "Ficha.aspx?IdFoto="+f.IdFoto.ToString()+"&Propiedad="+GetPropiedadSeleccionada.IdPropiedad.ToString();                        
                    //mngImagenes.GetPathImagen(f, GetPropiedadSeleccionada.IdPropiedad);
                    dt.Rows.Add(dr);
                }

                if (dt.Rows.Count != 0)                    
                    lSinFotos.Text = "";
            }

            DataView dv = new DataView(dt);

            return dv;
        }

        private GI.BR.Propiedades.Propiedad propiedadSel = null;
        private GI.BR.Propiedades.Propiedad GetPropiedadSeleccionada
        {
            get
            {
                if (propiedadSel == null)
                {
                    int idPropiedad = int.Parse(HttpContext.Current.Request.QueryString["Propiedad"].ToString());
                    GI.BR.Propiedades.PropiedadFactory pf = new GI.BR.Propiedades.PropiedadFactory();

                    propiedadSel = pf.GetPropiedad(idPropiedad);

                    if(propiedadSel == null)
                        throw new Exception("Propiedad no encontrada");
                }               

                return propiedadSel;                
            }
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            int a = 1;
        }
    }
}
