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
    public partial class ctrlPedido : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                #region Tipo Operacion

                ListItem liOper;
                liOper = new ListItem();
                liOper.Value = "GI.BR.Propiedades.Venta";
                liOper.Text = "Ventas";
                ddlTipoOperacion.Items.Add(liOper);

                liOper = new ListItem();
                liOper.Value = "GI.BR.Propiedades.Alquiler";
                liOper.Text = "Alquileres";
                ddlTipoOperacion.Items.Add(liOper);

                ddlTipoOperacion.SelectedIndex = 0;

                #endregion

                #region Ambientes

                GI.BR.Propiedades.Ambientes ambientes = new GI.BR.Propiedades.Ambientes();
                ambientes.RecuperarTodos();

                ListItem liAmbientes = new ListItem("Sin Definir", "0");

                ddlAmbientesDesde.Items.Add(liAmbientes);
                ddlAmbientesHasta.Items.Add(liAmbientes);
                foreach (GI.BR.Propiedades.Ambiente a in ambientes)
                {
                    liAmbientes = new ListItem();
                    liAmbientes.Text = a.ToString();
                    liAmbientes.Value = a.CantidadAmbientes.ToString();

                    ddlAmbientesDesde.Items.Add(liAmbientes);
                    ddlAmbientesHasta.Items.Add(liAmbientes);
                }

                ddlAmbientesDesde.SelectedIndex = 0;
                ddlAmbientesHasta.SelectedIndex = 0;
                #endregion

                #region Categorias

                ddlCategoria.Items.Clear();
                ListItem liCate = new ListItem("Sin Definir", "0");
                ddlCategoria.Items.Add(liCate);
                GI.BR.Propiedades.CategoriasPropiedad Categorias = new GI.BR.Propiedades.CategoriasPropiedad();
                Categorias.RecuperarTodas();

                foreach (GI.BR.Propiedades.CategoriaPropiedad c in GI.BR.Propiedades.CategoriaPropiedadFlyweigthFactory.GetInstancia.GetCategorias)
                {
                    liCate = new ListItem();
                    liCate.Text = c.ToString();
                    liCate.Value = c.IdCategoria.ToString();
                    ddlCategoria.Items.Add(liCate);
                }

                ddlCategoria.SelectedIndex = 0;

                #endregion

                #region Tipo de Propiedad

                ListItem liTipo = new ListItem("Sin Definir", "0");
                ddlTipoPropiedad.Items.Add(liTipo);

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




                GI.BR.Propiedades.Ubicaciones.Pais pais = GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetPaises().GetDefault;
                if (pais != null)
                {
                    ddlPais.Items.FindByValue(pais.IdPais.ToString()).Selected = true;
                    CargarComboProvincias(pais.IdPais);
                }
                else
                {
                    ddlPais.SelectedIndex = 0;
                    CargarComboProvincias(0);
                }

                #endregion
            }
        }

        #region Eventos

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

        protected void ddlCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboTipoPropiedad(int.Parse(ddlCategoria.SelectedValue));
        }

        #endregion

        #region Getters
        private GI.BR.Monedas.Moneda getMoneda()
        {
            if(tbValorDesde.Text != "" || tbValorHasta.Text != "")
                return GI.BR.Monedas.MonedasFlyweigthFactory.GetInstancia.GetMoneda(int.Parse(ddlMoneda.SelectedValue));
            return null;
        }

        private int getMetros(string text)
        {
            if (text == "")
                return 0;

            return int.Parse(text);
        }

        private GI.BR.Propiedades.Ambiente getAmbientesDesde()
        {
            if (ddlAmbientesDesde.SelectedValue == "0")
                return null;
            GI.BR.Propiedades.Ambiente ambientes = new GI.BR.Propiedades.Ambiente();
            ambientes.CantidadAmbientes = decimal.Parse(ddlAmbientesDesde.SelectedValue);

            return ambientes;

        }

        private GI.BR.Propiedades.Ambiente getAmbientesHasta()
        {
            if (ddlAmbientesHasta.SelectedValue == "0")
                return null;
            GI.BR.Propiedades.Ambiente ambientes = new GI.BR.Propiedades.Ambiente();
            ambientes.CantidadAmbientes = decimal.Parse(ddlAmbientesHasta.SelectedValue);

            return ambientes;

        }

        private GI.BR.Propiedades.TipoPropiedad getTipoPropiedad()
        {
            if (ddlTipoPropiedad.SelectedValue == "0")
                return null;
            return GI.BR.Propiedades.TiposPropiedadFlyweightFactory.GetInstancia.GetTipoPropiedad(int.Parse(ddlTipoPropiedad.SelectedValue));
        }

        private decimal getValor(string text)
        {
            if (text == "")
                return 0;

            return decimal.Parse(text);

        }

        private GI.BR.Propiedades.CategoriaPropiedad getCategoria()
        {
            if (ddlCategoria.SelectedValue == "0")
                return null;

            return GI.BR.Propiedades.CategoriaPropiedadFlyweigthFactory.GetInstancia.GetCategoria(int.Parse(ddlCategoria.SelectedValue));


        }
        #endregion



        #region Cargar Combos
        private void CargarComboTipoPropiedad(int idCategoria)
        {
            ddlTipoPropiedad.Items.Clear();
            ListItem liTipo = new ListItem("Sin Definir", "0");
            ddlTipoPropiedad.Items.Add(liTipo);

            if (idCategoria != 0)
            {
                foreach (GI.BR.Propiedades.TipoPropiedad t in GI.BR.Propiedades.TiposPropiedadFlyweightFactory.GetInstancia.GetTipoPropiedadPorCategoria(idCategoria))
                {
                    liTipo = new ListItem();
                    liTipo.Value = t.IdTipoPropiedad.ToString();
                    liTipo.Text = t.ToString();
                    ddlTipoPropiedad.Items.Add(liTipo);
                }
            }

            ddlTipoPropiedad.SelectedIndex = 0;
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

            GI.BR.Propiedades.Ubicaciones.Provincia provincia = GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetProvincias(IdPais).GetDefault;

            if (provincia != null)
            {
                ddlProvincia.Items.FindByValue(provincia.IdProvincia.ToString()).Selected = true;
                CargarComboLocalidades(provincia.IdProvincia);
            }
            else
            {
                ddlProvincia.SelectedIndex = 0;
                CargarComboLocalidades(0);
            }
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

            GI.BR.Propiedades.Ubicaciones.Localidad localidad = GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetLocalidades(IdProvincia).GetDefault;

            if (localidad != null)
            {
                ddlLocalidad.Items.FindByValue(localidad.IdLocalidad.ToString()).Selected = true;
                CargarComboBarrios(localidad.IdLocalidad);
            }
            else
            {
                ddlLocalidad.SelectedIndex = 0;
                CargarComboBarrios(0);
            }
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

            GI.BR.Propiedades.Ubicaciones.Barrio barrio = GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetBarrios(IdLocalidad).GetDefault;

            if (barrio != null)
            {
                ddlBarrio.Items.FindByValue(barrio.IdBarrio.ToString()).Selected = true;
            }
            else
            {
                ddlBarrio.SelectedIndex = 0;
            }
        }

        #endregion

        public GI.BR.Pedidos.Pedido GetPedido
        {
            get 
            {
                GI.BR.Pedidos.Pedido pedido = new GI.BR.Pedidos.Pedido();
                pedido.ClientePedido = (GI.BR.Clientes.ClientePedido)Session["ClientePedido"];

                GI.BR.Propiedades.Ubicacion ubicacion = new GI.BR.Propiedades.Ubicacion();
                ubicacion.Barrio = GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetBarrio(int.Parse(ddlBarrio.SelectedValue));
                ubicacion.Localidad = GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetLocalidad(int.Parse(ddlLocalidad.SelectedValue));
                ubicacion.Provincia = GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetProvincia(int.Parse(ddlProvincia.SelectedValue));
                ubicacion.Pais = GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetPais(int.Parse(ddlPais.SelectedValue));

                Type tipoOperacion = null;

                if (ddlTipoOperacion.SelectedValue == "GI.BR.Propiedades.Alquiler")
                    tipoOperacion = typeof(GI.BR.Propiedades.Alquiler);
                else
                    tipoOperacion = typeof(GI.BR.Propiedades.Venta);

                pedido.EstadoPropiedad = tipoOperacion;

                pedido.ValorInicial = getValor(tbValorDesde.Text);
                pedido.ValorFinal = getValor(tbValorHasta.Text);

                pedido.MetrosCubiertosFinal = getMetros(tbMetrosCubiertosMax.Text);
                pedido.MetrosCubiertosInicial = getMetros(tbMetrosCubiertosMin.Text);

                pedido.MetrosTerrenoFinal = getMetros(tbMetrosTerrenoMax.Text);
                pedido.MetrosTerrenoInicial = getMetros(tbMetrosTerrenoMin.Text);

                pedido.TipoPropiedad = getTipoPropiedad();

                pedido.CantidadAmbientesFinal = getAmbientesHasta();
                pedido.CantidadAmbientesInicial = getAmbientesDesde();

                pedido.Moneda = getMoneda();

                pedido.Categoria = getCategoria();

                pedido.FechaAlta = DateTime.Now;

                pedido.Ubicacion = ubicacion;
                pedido.Observaciones = "";

                return pedido;
            }
        }
    }
}