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
        public GI.BR.Propiedades.Propiedades propiedades = new GI.BR.Propiedades.Propiedades();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                #region Combo Tipo Operacion
                ListItem liOperacionVenta = new ListItem();
                liOperacionVenta.Text = "Venta";
                liOperacionVenta.Value = "GI.BR.Propiedades.Venta";

                ddlTipoOperacion.Items.Add(liOperacionVenta);

                ListItem liOperacionAlquiler = new ListItem();
                liOperacionAlquiler.Text = "Alquiler";
                liOperacionAlquiler.Value = "GI.BR.Propiedades.Alquiler";
                ddlTipoOperacion.Items.Add(liOperacionAlquiler);
                
                ddlTipoOperacion.SelectedIndex = 0;
                #endregion

                #region Ambientes

                GI.BR.Propiedades.Ambientes ambientes = new GI.BR.Propiedades.Ambientes();
                ambientes.RecuperarTodos();
                ListItem liAmbientes = new ListItem("Sin Definir","0");
                ddlAmbientes.Items.Add(liAmbientes);
                foreach (GI.BR.Propiedades.Ambiente a in ambientes)
                {
                    liAmbientes = new ListItem();
                    liAmbientes.Text = a.ToString();
                    liAmbientes.Value = a.CantidadAmbientes.ToString();

                    ddlAmbientes.Items.Add(liAmbientes);
                }

                ddlAmbientes.SelectedIndex = 0;
                #endregion

                #region Tipo de Propiedad

                ListItem liTipo;
                foreach (GI.BR.Propiedades.TipoPropiedad t in GI.BR.Propiedades.TiposPropiedadFlyweightFactory.GetInstancia.GetTiposPropiedad)
                {
                    liTipo = new ListItem();
                    liTipo.Value = t.IdTipoPropiedad.ToString();
                    liTipo.Text = t.ToString();

                    ddlTipoPropiedad.Items.Add(liTipo);
                }
                ddlTipoPropiedad.SelectedIndex = 0;

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
                ddlMoneda.SelectedIndex = 0;

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
                //No dispara el evento selected index change, lo disparo a mano .
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
            //No dispara el evento selected index change, lo disparo a mano .
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
            //No dispara el evento selected index change, lo disparo a mano .
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

        public void cargarPropiedades()
        {
            GI.Managers.Propiedades.MngPropiedades mngPropiedades = new GI.Managers.Propiedades.MngPropiedades();

            #region Armo los objetos para pasarle al  manager de busqueda.
            GI.BR.Propiedades.Ubicacion ubicacion = new GI.BR.Propiedades.Ubicacion();
            ubicacion.Barrio = GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetBarrio(int.Parse(ddlBarrio.SelectedValue));
            ubicacion.Localidad = GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetLocalidad(int.Parse(ddlLocalidad.SelectedValue));
            ubicacion.Provincia = GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetProvincia(int.Parse(ddlProvincia.SelectedValue));
            ubicacion.Pais = GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetPais(int.Parse(ddlPais.SelectedValue));

            GI.BR.Propiedades.TipoPropiedad tipoPropiedad = GI.BR.Propiedades.TiposPropiedadFlyweightFactory.GetInstancia.GetTipoPropiedad(int.Parse(ddlTipoPropiedad.SelectedValue));

            Type tipoOperacion = null;

            if (ddlTipoOperacion.SelectedValue == "GI.BR.Propiedades.Alquiler")
                tipoOperacion = typeof(GI.BR.Propiedades.Alquiler);
            else
                tipoOperacion = typeof(GI.BR.Propiedades.Venta);

            GI.BR.Propiedades.EstadoPropiedad estadoPropiedad = GI.BR.Propiedades.EstadoPropiedadFlyweigthFactory.GetInstancia(tipoOperacion).GetEstadoBase();
            GI.BR.Propiedades.EstadoPropiedad estadoPropiedadReservado = GI.BR.Propiedades.EstadoPropiedadFlyweigthFactory.GetInstancia(tipoOperacion).GetEstadoReservado();


            GI.BR.Valor valorDesde = getValor(tbValorDesde.Text, int.Parse(ddlMoneda.SelectedValue));
            GI.BR.Valor valorHasta = getValor(tbValorHasta.Text, int.Parse(ddlMoneda.SelectedValue));
            #endregion

            //Recupero propiedades en venta o alquiler.
            propiedades.AddRange(mngPropiedades.RecuperarPropiedades(tipoOperacion, tipoPropiedad, estadoPropiedad, getAmbientes(), ubicacion, valorDesde, valorHasta));
            //Recupero propiedades reservadas de venta o alquiler.
            propiedades.AddRange(mngPropiedades.RecuperarPropiedades(tipoOperacion, tipoPropiedad, estadoPropiedadReservado, getAmbientes(), ubicacion, valorDesde, valorHasta));

            Session["Propiedades"] = propiedades;
        }

        private GI.BR.Propiedades.Ambiente getAmbientes()
        {
            if (ddlAmbientes.SelectedValue == "0")
                return null;
            GI.BR.Propiedades.Ambiente ambientes = new GI.BR.Propiedades.Ambiente();
            ambientes.CantidadAmbientes = decimal.Parse(ddlAmbientes.SelectedValue);

            return ambientes;

        }

        private GI.BR.Valor getValor(string text, int idMoneda)
        {
            if (text == "")
                return null;

            GI.BR.Valor valor = new GI.BR.Valor();
            valor.Importe = decimal.Parse(text);
            valor.Moneda = GI.BR.Monedas.MonedasFlyweigthFactory.GetInstancia.GetMoneda(idMoneda);

            return valor;

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