using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Pedidos
{
    public partial class frmBuscarPedidos : Form,GI.Framework.Interfaces.IBuscador
    {
        private Type tipo;
        private GI.BR.Pedidos.Pedidos pedidos;
        GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory uff = GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia;



        public frmBuscarPedidos(Type tipoPropiedad)
        {
            InitializeComponent();
            this.tipo = tipoPropiedad;
            Inicializar();

            bBuscar.Focus();            
        }


        public GI.BR.Pedidos.Pedidos Pedidos
        {
            get { return pedidos; }
           
        }
        
        private void Inicializar()
        {

            GI.BR.Monedas.Monedas monedas = new GI.BR.Monedas.Monedas();
            monedas.RecuperarTodas();
            foreach (GI.BR.Monedas.Moneda m in monedas)
                cbMonedaReal.Items.Add(m);

            cbMonedaReal.SelectedIndex = 0;

            #region Tipo de Propiedad
            cbTipoPropiedad.Items.Add("Seleccione opción...");
            GI.BR.Propiedades.TiposPropiedad tiposPropiedad = new GI.BR.Propiedades.TiposPropiedad();
            tiposPropiedad.RecuperarTodos();
            foreach (GI.BR.Propiedades.TipoPropiedad tipoProp in tiposPropiedad)
            {
                cbTipoPropiedad.Items.Add(tipoProp);
            }


            cbTipoPropiedad.SelectedIndex = 0;
            #endregion

            #region Ambientes
            GI.BR.Propiedades.Ambientes ambientes = new GI.BR.Propiedades.Ambientes();
            ambientes.RecuperarTodos();
            cbAmbientes.Items.Add("Seleccione opción...");
            foreach (GI.BR.Propiedades.Ambiente a in ambientes)
                cbAmbientes.Items.Add(a);
            cbAmbientes.SelectedIndex = 0;
            #endregion

            #region Localidad
            GI.BR.Propiedades.Ubicaciones.Paises Paises = new GI.BR.Propiedades.Ubicaciones.Paises();
            Paises.RecuperarTodos();
            foreach (GI.BR.Propiedades.Ubicaciones.Pais p in Paises)
            {
                cbPais.Items.Add(p);
                if (p.EsDefault)
                    cbPais.SelectedItem = p;
            }
            #endregion

            #region Estados

            GI.BR.Propiedades.EstadosPropiedad Estados = new GI.BR.Propiedades.EstadosPropiedad();
            Estados.RecuperarEstados(tipo);
            cbEstadoPropiedad.Items.Add("Seleccione opción...");
            foreach (GI.BR.Propiedades.EstadoPropiedad estado in Estados)
            {
                cbEstadoPropiedad.Items.Add(estado);

            }
            cbEstadoPropiedad.SelectedIndex = 0;



            #endregion

        }

        private void cbPais_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbPais.SelectedIndex > 0) return;

            GI.BR.Propiedades.Ubicaciones.Pais Pais = (GI.BR.Propiedades.Ubicaciones.Pais)cbPais.SelectedItem;
            GI.BR.Propiedades.Ubicaciones.Provincias Provincias = uff.GetProvincias(Pais.IdPais);


            cbProvincia.Items.Clear();
            cbLocalidad.Items.Clear();
            cbBarrio.Items.Clear();
            cbProvincia.Items.Add("Seleccione opción...");
            foreach (GI.BR.Propiedades.Ubicaciones.Provincia p in Provincias)
                cbProvincia.Items.Add(p);
            cbProvincia.SelectedIndex = 0;
        }

        private void cbProvincia_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbProvincia.SelectedIndex <= 0) return;

            GI.BR.Propiedades.Ubicaciones.Provincia Provincia = (GI.BR.Propiedades.Ubicaciones.Provincia)cbProvincia.SelectedItem;
            GI.BR.Propiedades.Ubicaciones.Localidades Localidades = uff.GetLocalidades(Provincia.IdProvincia);

            cbLocalidad.Items.Clear();
            cbBarrio.Items.Clear();

            cbLocalidad.Items.Add("Seleccione opción...");
            foreach (GI.BR.Propiedades.Ubicaciones.Localidad l in Localidades)
                cbLocalidad.Items.Add(l);
            cbLocalidad.SelectedIndex = 0;
        }

        private void cbLocalidad_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbLocalidad.SelectedIndex <= 0) return;



            GI.BR.Propiedades.Ubicaciones.Localidad Localidad = (GI.BR.Propiedades.Ubicaciones.Localidad)cbLocalidad.SelectedItem;
            GI.BR.Propiedades.Ubicaciones.Barrios Barrios = uff.GetBarrios(Localidad.IdLocalidad);

            cbBarrio.Items.Clear();
            cbBarrio.Items.Add("Seleccione opción...");
            foreach (GI.BR.Propiedades.Ubicaciones.Barrio b in Barrios)
                cbBarrio.Items.Add(b);
            cbBarrio.SelectedIndex = 0;
        }

        private void cbBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBarrio.SelectedIndex <= 0) return;
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            GI.Managers.Pedidos.MngPedidos mngPedidos = new GI.Managers.Pedidos.MngPedidos();

            #region Por Ubicación

            if (tabControlTiposDeBusqueda.SelectedIndex == 0)
            {

                GI.BR.Propiedades.TipoPropiedad TipoProp = null;
                GI.BR.Propiedades.Ubicacion Ubicacion = new GI.BR.Propiedades.Ubicacion();
                GI.BR.Propiedades.Ambiente Ambiente = null;
                GI.BR.Propiedades.EstadoPropiedad Estado = null;
                GI.BR.Valor ValorDesde = null;
                GI.BR.Valor ValorHasta = null;
                if (cbTipoPropiedad.SelectedIndex > 0)
                    TipoProp = (GI.BR.Propiedades.TipoPropiedad)cbTipoPropiedad.SelectedItem;

                if (cbPais.SelectedIndex > 0)
                    Ubicacion.Pais = (GI.BR.Propiedades.Ubicaciones.Pais)cbPais.SelectedItem;
                if (cbProvincia.SelectedIndex > 0)
                    Ubicacion.Provincia = (GI.BR.Propiedades.Ubicaciones.Provincia)cbProvincia.SelectedItem;
                if (cbLocalidad.SelectedIndex > 0)
                    Ubicacion.Localidad = (GI.BR.Propiedades.Ubicaciones.Localidad)cbLocalidad.SelectedItem;
                if (cbBarrio.SelectedIndex > 0)
                    Ubicacion.Barrio = (GI.BR.Propiedades.Ubicaciones.Barrio)cbBarrio.SelectedItem;

                if (cbAmbientes.SelectedIndex > 0)
                    Ambiente = (GI.BR.Propiedades.Ambiente)cbAmbientes.SelectedItem;

                if (cbEstadoPropiedad.SelectedIndex > 0)
                    Estado = (GI.BR.Propiedades.EstadoPropiedad)cbEstadoPropiedad.SelectedItem;

                decimal importeDesde = 0;
                if (decimal.TryParse(textBoxValorDesde.Text, out importeDesde))
                {
                    ValorDesde = new GI.BR.Valor();
                    ValorDesde.Importe = importeDesde;
                    ValorDesde.Moneda = (GI.BR.Monedas.Moneda)cbMonedaReal.SelectedItem;

                }

                decimal importeHasta = 0;
                if (decimal.TryParse(textBoxValorHasta.Text, out importeHasta))
                {
                    ValorHasta = new GI.BR.Valor();
                    ValorHasta.Importe = importeHasta;
                    ValorHasta.Moneda = (GI.BR.Monedas.Moneda)cbMonedaReal.SelectedItem;

                }

                pedidos = mngPedidos.RecuperarPedidos(TipoProp, Estado, Ambiente, Ubicacion, ValorDesde, ValorHasta, tipo);


            }
            #endregion



            #region Por Contacto

            if (tabControlTiposDeBusqueda.SelectedIndex == 1)
            {

                pedidos = mngPedidos.RecuperarPedidosPorContacto(tbNombresInquilinos.Text, tipo);
            }

            #endregion

            if (this.pedidos.Count == 0)
            {
                GI.Framework.General.GIMsgBox.ShowNoSeEncontraronDatos();
                return;
            }


            this.DialogResult = DialogResult.OK;
            this.Close();



        }

        #region IBuscador Members

        public List<object> GetObjetosEncontrados()
        {
            List<object> lista = new List<object>();
            lista.AddRange(this.pedidos.ToArray());
            return lista;
        }

        public void SetTipoBusqueda(Type tipoObjeto)
        {
        }

        public DialogResult MostrarBuscador()
        {
            return this.ShowDialog();
        }

        #endregion

        
    }
}