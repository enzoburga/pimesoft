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

        public override GI.BR.Propiedades.Propiedad GetPropiedad()
        {
            Propiedad.EsAptoProfesional = chAptoProfesional.Checked;

            return Propiedad;
        }

        protected override void Inicializar()
        {
            cbDisposicion.Items.Add(GI.BR.Propiedades.DepartamentoDisposicion.SinDefinir);
            cbDisposicion.Items.Add(GI.BR.Propiedades.DepartamentoDisposicion.Frente);
            cbDisposicion.Items.Add(GI.BR.Propiedades.DepartamentoDisposicion.Contrafrente);
            cbDisposicion.Items.Add(GI.BR.Propiedades.DepartamentoDisposicion.Interno);
            cbDisposicion.Items.Add(GI.BR.Propiedades.DepartamentoDisposicion.Lateral);
            cbDisposicion.SelectedIndex = 0;


            cbTipoZona.Items.Add(GI.BR.Propiedades.TipoZona.SinDefinir);
             cbTipoZona.Items.Add(GI.BR.Propiedades.TipoZona.Comercial);
             cbTipoZona.Items.Add(GI.BR.Propiedades.TipoZona.Industrial);
             cbTipoZona.Items.Add(GI.BR.Propiedades.TipoZona.Residencial);
             cbTipoZona.SelectedIndex = 0;

             cbOrientacion.Items.Add("");
             cbOrientacion.Items.Add("Este");
             cbOrientacion.Items.Add("Noreste");
             cbOrientacion.Items.Add("Norte");
             cbOrientacion.Items.Add("Noroeste");
             cbOrientacion.Items.Add("Oeste");
             cbOrientacion.Items.Add("Sudeste");
             cbOrientacion.Items.Add("Sur");
             cbOrientacion.SelectedIndex = 0;



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
                Propiedad.TipoZona = GI.BR.Propiedades.TipoZona.SinDefinir;
            }

            chAptoProfesional.Checked = Propiedad.EsAptoProfesional;
            medidaPropiedadBindingSource.Add(Propiedad.MedidasPropiedad);
            medidasTerrenoBindingSource.Add(Propiedad.MedidasTerreno);
            propiedadBindingSource.Add(Propiedad);
  


        }

        private void Propiedad_onCambioTipoPropiedad(GI.BR.Propiedades.TipoPropiedad Tipo)
        {
            cbDisposicion.Enabled = false;
            chAptoProfesional.Enabled = false;
            textBoxCantidadPisos.Enabled = false;
            textBoxDepertamanetosPorPiso.Enabled = false;
            textBoxAscensores.Enabled = false;
            textBoxAscensoresServicio.Enabled = false;
            textBoxValorExpensas.Enabled = false;

            cbDisposicion.SelectedIndex = 0;
            chAptoProfesional.Checked = false;
            textBoxCantidadPisos.Text = "0";
            textBoxDepertamanetosPorPiso.Text = "0";
            textBoxAscensores.Text = "0";
            textBoxAscensoresServicio.Text = "0";

            cbTipoZona.Enabled = false;
            textBoxFOS.Enabled = false;
            textBoxFOT.Enabled = false;
            textBoxMetrosConstruibles.Enabled = false;
            textBoxZonificacion.Enabled = false;

            cbTipoZona.SelectedIndex = 0;
            textBoxFOS.Text = "";
            textBoxFOT.Text = "";
            textBoxMetrosConstruibles.Text = "0";
            textBoxZonificacion.Text = "";
            textBoxValorExpensas.Text = "0";

            if (Tipo.IdTipoPropiedad == 1)
            {
                cbDisposicion.Enabled = true;
                chAptoProfesional.Enabled = true;
                textBoxCantidadPisos.Enabled = true;
                textBoxDepertamanetosPorPiso.Enabled = true;
                textBoxAscensores.Enabled = true;
                textBoxAscensoresServicio.Enabled = true;
                textBoxValorExpensas.Enabled = true;
            }


            if (Tipo.IdTipoPropiedad==11 || Tipo.IdTipoPropiedad==18)
            {
                cbTipoZona.Enabled = true;
                textBoxFOS.Enabled = true;
                textBoxFOT.Enabled = true;
                textBoxMetrosConstruibles.Enabled = true;
                textBoxZonificacion.Enabled = true;
            
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

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFrente_TextChanged(object sender, EventArgs e)
        {
            calcularSuperficie();
        }

        private void textBoxFondo_TextChanged(object sender, EventArgs e)
        {
            calcularSuperficie();
        }


        private void calcularSuperficie()
        {
            decimal fondo = 0;
            decimal frente = 0;
            Decimal.TryParse(textBoxFondo.Text, out fondo);
            Decimal.TryParse(textBoxFrente.Text, out frente);

            Propiedad.MedidasTerreno.Metros = fondo * frente;
            
        }
    }
}
