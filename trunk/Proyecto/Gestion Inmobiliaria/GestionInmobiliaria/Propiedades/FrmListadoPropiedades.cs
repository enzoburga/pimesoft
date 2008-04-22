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


        }

        #region Eventos





        private void lvPropiedades_DoubleClick_1(object sender, EventArgs e)
        {
            if (lvPropiedades.SelectedItems.Count == 1)
            {
                frmFichaPropiedad frmFicha = new frmFichaPropiedad();
                frmFicha.Propiedad = (GI.BR.Propiedades.Propiedad)lvPropiedades.SelectedItems[0].Tag;
                frmFicha.SoloLectura = true;
                frmFicha.ShowDialog();
            }
        }

        private void lvPropiedades_DoubleClick(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.lvPropiedades_DoubleClick_1(null, null);
        }

        private void editarFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFichaPropiedad frmFicha = new frmFichaPropiedad();
            frmFicha.Propiedad = (GI.BR.Propiedades.Propiedad)lvPropiedades.SelectedItems[0].Tag;
            frmFicha.SoloLectura = false;
            frmFicha.ShowDialog();
        }

        private void toolStripButtonBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarPropiedades frmBusqueda = new frmBuscarPropiedades(tipo);
            if (frmBusqueda.ShowDialog() == DialogResult.OK)
            {
                lvPropiedades.BeginUpdate();
                lvPropiedades.Items.Clear();
 
                GI.BR.Propiedades.Propiedades propiedades = frmBusqueda.Propiedades;
                ListViewItem item;

                foreach (GI.BR.Propiedades.Propiedad p in propiedades)
                {
                    item = new ListViewItem();

                    item.Text = p.Codigo;
                    item.SubItems.Add(p.TipoPropiedad.ToString());
                    item.SubItems.Add(p.Estado.ToString());
                    item.SubItems.Add(p.CantidadAmbientes.ToString());
                    item.SubItems.Add(p.ValorPublicacion.ToString());
                    item.SubItems.Add(p.Ubicacion.Localidad.ToString());
                    item.SubItems.Add(p.Ubicacion.Barrio.ToString());
                    item.Tag = p;
                    
                    lvPropiedades.Items.Add(item);
                }

                lvPropiedades.EndUpdate();
            }
        }

        #endregion








    }
}