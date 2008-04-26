using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades
{
    public partial class TabDetalles : TabContenidoPropiedad
    {
        public TabDetalles()
        {
            InitializeComponent();
        }


        protected override void Inicializar()
        {
            cbDisposicion.Items.Add(GI.BR.Propiedades.DepartamentoDisposicion.SinDefinir);
            cbDisposicion.Items.Add(GI.BR.Propiedades.DepartamentoDisposicion.Frente);
            cbDisposicion.Items.Add(GI.BR.Propiedades.DepartamentoDisposicion.Contrafrente);
            cbDisposicion.Items.Add(GI.BR.Propiedades.DepartamentoDisposicion.Interno);
            cbDisposicion.Items.Add(GI.BR.Propiedades.DepartamentoDisposicion.Lateral);
            cbDisposicion.SelectedIndex = 0;

        }

        protected override void CargarPropiedad()
        {

            Propiedad.onCambioTipoPropiedad += new GI.BR.Propiedades.DelegateCambioTipoPropiedad(Propiedad_onCambioTipoPropiedad);
            Propiedad_onCambioTipoPropiedad(Propiedad.TipoPropiedad);

            if (Propiedad.IdPropiedad == 0)
            {
                Propiedad.MedidasTerreno = new GI.BR.Propiedades.MedidasTerreno();
                Propiedad.MedidasPropiedad = new GI.BR.Propiedades.MedidaPropiedad();
                Propiedad.Disposicion = GI.BR.Propiedades.DepartamentoDisposicion.SinDefinir;
            }

            medidaPropiedadBindingSource.Add(Propiedad.MedidasPropiedad);
            medidasTerrenoBindingSource.Add(Propiedad.MedidasTerreno);
  


        }

        private void Propiedad_onCambioTipoPropiedad(GI.BR.Propiedades.TipoPropiedad Tipo)
        {
            cbDisposicion.Enabled = false;
            chAptoProfesional.Enabled = false;
            textBoxCantidadPisos.Enabled = false;
            textBoxDepertamanetosPorPiso.Enabled = false;
            textBoxAscensores.Enabled = false;
            textBoxAscensoresServicio.Enabled = false;

            cbDisposicion.SelectedIndex = 0;
            chAptoProfesional.Checked = false;
            textBoxCantidadPisos.Text = "0";
            textBoxDepertamanetosPorPiso.Text = "0";
            textBoxAscensores.Text = "0";
            textBoxAscensoresServicio.Text = "0";

            if (Tipo.IdTipoPropiedad == 1)
            {
                cbDisposicion.Enabled = true;
                chAptoProfesional.Enabled = true;
                textBoxCantidadPisos.Enabled = true;
                textBoxDepertamanetosPorPiso.Enabled = true;
                textBoxAscensores.Enabled = true;
                textBoxAscensoresServicio.Enabled = true;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TabDetalles_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
