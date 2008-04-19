using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades
{
    public partial class FrmListadoPropiedades : Framework.Seguridad.FrmGISeguridad
    {

        private Type tipo;

        public FrmListadoPropiedades()
        {
            InitializeComponent();
            
        }

        public FrmListadoPropiedades(Type Tipo) : this()
        {
            tipo = Tipo;

            switch (Tipo.ToString())
            {
                case "GI.BR.Propiedades.Alquiler":
                    {
                        Text = "Propiedades en Alquiler";
                        break;
                    }
                case "GI.BR.Propiedades.Venta":
                    {
                        Text = "Propiedades en Venta";
                        break;
                    }
            }

            Inicializar();
        }


        private void Inicializar()
        {


            #region Tipo de Propiedad
            cbTipoPropiedad.Items.Add("Seleccione opción...");


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

        #region Eventos


        private void bBuscar_Click_1(object sender, EventArgs e)
        {
            GI.Managers.Propiedades.MngPropiedades mngPropiedades = new GI.Managers.Propiedades.MngPropiedades();
            GI.BR.Propiedades.Propiedades props = mngPropiedades.RecuperarPropiedades(null, null, null, null);

            lvPropiedades.BeginUpdate();
            lvPropiedades.Items.Clear();
            ListViewItem i;
            foreach (GI.BR.Propiedades.Propiedad p in props)
            {
                i = new ListViewItem();
                i.Text = p.Codigo.ToString();
                i.SubItems.Add(p.TipoPropiedad.ToString());
                i.SubItems.Add(p.Estado.Descripcion);
                i.SubItems.Add("3");
                i.SubItems.Add(p.Moneda.Simbolo + " " + p.ValorPublicacion.ToString("N"));
                i.SubItems.Add("Vicente López");
                i.SubItems.Add("Florida");
                if (p.EsOtraInmobiliaria)
                    i.ForeColor = System.Drawing.Color.Blue;

                i.Tag = p;

                lvPropiedades.Items.Add(i);
            }


            lvPropiedades.EndUpdate();

        }

        private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPais.SelectedIndex > 0) return;

            GI.BR.Propiedades.Ubicaciones.Pais Pais = (GI.BR.Propiedades.Ubicaciones.Pais)cbPais.SelectedItem;
            GI.BR.Propiedades.Ubicaciones.Provincias Provincias = new GI.BR.Propiedades.Ubicaciones.Provincias();
            Provincias.RecuperarTodas(Pais);

            cbProvincia.Items.Clear();
            cbLocalidad.Items.Clear();
            cbBarrio.Items.Clear();
            cbProvincia.Items.Add("Seleccione opción...");
            foreach (GI.BR.Propiedades.Ubicaciones.Provincia p in Provincias)
                cbProvincia.Items.Add(p);
            cbProvincia.SelectedIndex = 0;
        }

        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProvincia.SelectedIndex <= 0) return;

            GI.BR.Propiedades.Ubicaciones.Provincia Provincia = (GI.BR.Propiedades.Ubicaciones.Provincia)cbProvincia.SelectedItem;
            GI.BR.Propiedades.Ubicaciones.Localidades Localidades = new GI.BR.Propiedades.Ubicaciones.Localidades();
            Localidades.RecuperarTodas(Provincia);

            cbLocalidad.Items.Clear();
            cbBarrio.Items.Clear();

            cbLocalidad.Items.Add("Seleccione opción...");
            foreach (GI.BR.Propiedades.Ubicaciones.Localidad l in Localidades)
                cbLocalidad.Items.Add(l);
            cbLocalidad.SelectedIndex = 0;
        }

        private void cbLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLocalidad.SelectedIndex <= 0) return;



            GI.BR.Propiedades.Ubicaciones.Localidad Localidad = (GI.BR.Propiedades.Ubicaciones.Localidad)cbLocalidad.SelectedItem;
            GI.BR.Propiedades.Ubicaciones.Barrios Barrios = new GI.BR.Propiedades.Ubicaciones.Barrios();
            Barrios.RecuperarTodos(Localidad);

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

        private void lvPropiedades_DoubleClick(object sender, EventArgs e)
        {
            if (lvPropiedades.SelectedItems.Count == 1)
            {
                frmFichaPropiedad frmFicha = new frmFichaPropiedad();
                frmFicha.Propiedad = (GI.BR.Propiedades.Propiedad)lvPropiedades.SelectedItems[0].Tag;
                frmFicha.SoloLectura = true;
                frmFicha.ShowDialog();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.lvPropiedades_DoubleClick(null, null);
        }

        private void editarFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFichaPropiedad frmFicha = new frmFichaPropiedad();
            frmFicha.Propiedad = (GI.BR.Propiedades.Propiedad)lvPropiedades.SelectedItems[0].Tag;
            frmFicha.SoloLectura = false;
            frmFicha.ShowDialog();
        }

        #endregion




    }
}