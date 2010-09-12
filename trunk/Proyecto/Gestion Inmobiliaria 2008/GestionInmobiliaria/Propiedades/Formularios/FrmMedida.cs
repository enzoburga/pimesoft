using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades.Formularios
{
    public partial class FrmMedida : Form
    {

        private GI.BR.Propiedades.MedidaAmbiente medida;


        public FrmMedida()
        {
            InitializeComponent();
            Inicializar();
        }



        public GI.BR.Propiedades.MedidaAmbiente Medida
        {
            get { return medida; }
            set 
            {
                medida = value;
                medida.TipoDePiso = (GI.BR.Propiedades.TipoDePiso)cbTipoPiso.SelectedItem;
                medida.TipoAmbiente = (GI.BR.Propiedades.TipoAmbiente)cbTipoAmbiente.SelectedItem;
                medidaAmbienteBindingSource.Add(medida);
            }
        }

        private void Inicializar()
        {
            cbTipoPiso.Items.Clear();
            GI.BR.Propiedades.TiposDePiso tiposPiso = new GI.BR.Propiedades.TiposDePiso();
            tiposPiso.RecuperarTodos();
            foreach (GI.BR.Propiedades.TipoDePiso piso in tiposPiso)
                cbTipoPiso.Items.Add(piso);

            cbTipoPiso.SelectedIndex = 0;


            cbTipoAmbiente.Items.Clear();
            GI.BR.Propiedades.TiposAmbiente tiposAmb = new GI.BR.Propiedades.TiposAmbiente();
            tiposAmb.RecuperarTodos();
            foreach (GI.BR.Propiedades.TipoAmbiente amb in tiposAmb)
                cbTipoAmbiente.Items.Add(amb);
            cbTipoAmbiente.SelectedIndex = 0;
            
        }


        private void bAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cbTipoAmbiente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoAmbiente.SelectedItem == null) return;
            textBoxAmbiente.Text = "";
            GI.BR.Propiedades.TipoAmbiente ta = (GI.BR.Propiedades.TipoAmbiente)cbTipoAmbiente.SelectedItem;
            if (ta.Codigo == 0)
            {
                textBoxAmbiente.Enabled = true;

            }
            else
            {
                textBoxAmbiente.Enabled = false;
                
            }
        }
    }
}