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
    public partial class ctrlBuscadorPropiedades : System.Web.UI.UserControl
    {
        private GI.BR.Propiedades.Propiedades propiedades;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                #region Combo Tipo Operacion
                ListItem liOperacionVenta = new ListItem();
                liOperacionVenta.Text = "Venta";
                liOperacionVenta.Value = "GI.BR.Propiedades.Venta";

                ddlTipoPropiedad.Items.Add(liOperacionVenta);

                ListItem liOperacionAlquiler = new ListItem();
                liOperacionAlquiler.Text = "Alquiler";
                liOperacionAlquiler.Value = "GI.BR.Propiedades.Alquiler";
                ddlTipoPropiedad.Items.Add(liOperacionAlquiler);

                ddlTipoPropiedad.SelectedIndex = 0;
                #endregion

                #region Ambientes

                GI.BR.Propiedades.Ambientes ambientes = new GI.BR.Propiedades.Ambientes();
                ambientes.RecuperarTodos();
                ListItem liAmbientes;
                ddlAmbientes.Items.Add("Sin Definir");
                foreach (GI.BR.Propiedades.Ambiente a in ambientes)
                {
                    liAmbientes = new ListItem();
                    liAmbientes.Text = a.ToString();
                    liAmbientes.Value = a.CantidadAmbientes.ToString();

                    ddlAmbientes.Items.Add(liAmbientes);
                }

                #endregion

                #region Monedas
                ListItem liMoneda;
                foreach (GI.BR.Monedas.Moneda m in GI.BR.Monedas.MonedasFlyweigthFactory.GetInstancia.GetMonedas)
                {
                    liMoneda = new ListItem();
                    liMoneda.Value = m.IdMoneda.ToString();
                    liMoneda.Text = m.ToString();

                    ddlMoneda.Items.Add(liMoneda);
                }

                #endregion


                #region Paises

                ListItem liPaises = new ListItem();
                liPaises.Text = "Sin Definir";
                liPaises.Value = "0";
                ddlPais.Items.Add(liPaises);
                foreach (GI.BR.Propiedades.Ubicaciones.Pais p in GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetPaises())
                {
                    liPaises = new ListItem();
                    liPaises.Value = p.IdPais.ToString();
                    liPaises.Text = p.ToString();

                    ddlPais.Items.Add(liPaises);
                }

                ddlPais.SelectedIndex = 0;
                CargarComboProvincias(0);

                #endregion
            }

        }

        private void CargarComboProvincias(int IdPais)
        {
            ddlProvincia.Items.Clear();
            ListItem liProvincia = new ListItem();
            liProvincia.Text = "Sin Definir";
            liProvincia.Value = "0";
            ddlProvincia.Items.Add(liProvincia);

            if (IdPais != 0)
            {

                foreach (GI.BR.Propiedades.Ubicaciones.Provincia p in GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetProvincias(IdPais))
                {
                    liProvincia = new ListItem();
                    liProvincia.Value = p.IdProvincia.ToString();
                    liProvincia.Text = p.ToString();

                    ddlProvincia.Items.Add(liProvincia);
                }
            }
            ddlProvincia.SelectedIndex = 0;
            CargarComboLocalidades(0);
        }

        private void CargarComboLocalidades(int IdProvincia)
        {
            ddlLocalidad.Items.Clear();
            ListItem liLocalidad = new ListItem();
            liLocalidad.Text = "Sin Definir";
            liLocalidad.Value = "0";
            ddlLocalidad.Items.Add(liLocalidad);

            if (IdProvincia != 0)
            {

                foreach (GI.BR.Propiedades.Ubicaciones.Localidad l in GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetLocalidades(IdProvincia))
                {
                    liLocalidad = new ListItem();
                    liLocalidad.Value = l.IdLocalidad.ToString();
                    liLocalidad.Text = l.ToString();

                    ddlLocalidad.Items.Add(liLocalidad);
                }
            }
            ddlLocalidad.SelectedIndex = 0;
            CargarComboBarrios(0);
        }

        private void CargarComboBarrios(int IdLocalidad)
        {
            ddlBarrio.Items.Clear();
            ListItem liBarrio = new ListItem();
            liBarrio.Text = "Sin Definir";
            liBarrio.Value = "0";
            ddlBarrio.Items.Add(liBarrio);

            if (IdLocalidad != 0)
            {

                foreach (GI.BR.Propiedades.Ubicaciones.Barrio b in GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetBarrios(IdLocalidad))
                {
                    liBarrio = new ListItem();
                    liBarrio.Value = b.IdBarrio.ToString();
                    liBarrio.Text = b.ToString();

                    ddlBarrio.Items.Add(liBarrio);
                }
            }
            ddlBarrio.SelectedIndex = 0;  
        }

        protected void ibBuscar_Click(object sender, ImageClickEventArgs e)
        {
            GI.Managers.Propiedades.MngPropiedades mngPropiedades = new GI.Managers.Propiedades.MngPropiedades();
            
        }

        protected void ddlPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboProvincias(int.Parse(ddlPais.SelectedValue));
        }

        protected void ddlProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboLocalidades(int.Parse(ddlProvincia.SelectedValue));
        }

        protected void ddlLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboBarrios(int.Parse(ddlLocalidad.SelectedValue));
        }
    }
}