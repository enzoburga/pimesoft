using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades.Formularios
{
    public partial class FrmFoto : Form
    {


        private GI.BR.Propiedades.Propiedad propiedad;
        private GI.BR.Propiedades.Galeria.Foto Foto;
        GI.BR.Propiedades.MedidaAmbiente medida;

        public GI.BR.Propiedades.Galeria.Foto GetFoto
        {
            get { return Foto; }
        }
        public FrmFoto()
        {
            InitializeComponent();


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


            medida = new GI.BR.Propiedades.MedidaAmbiente();
            medida.TipoAmbiente = (GI.BR.Propiedades.TipoAmbiente)cbTipoAmbiente.SelectedItem;
            medida.TipoDePiso = (GI.BR.Propiedades.TipoDePiso)cbTipoPiso.SelectedItem;



            medidaAmbienteBindingSource.Add(medida);
        }


        public FrmFoto(GI.BR.Propiedades.Propiedad p)
            : this()
        {

            propiedad = p;
        }

        private void checkBoxEsFechada_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEsFechada.Checked)
            {
                textBoxNombre.ReadOnly = true;
                textBoxNombre.Text = "Fachada";
            }
            else
            {
                textBoxNombre.ReadOnly = false;
                textBoxNombre.Text = "";
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (openFileDialog.FileName == "")
            {
                Framework.General.GIMsgBox.Show("Debe seleccionar una imagen", GI.Framework.General.enumTipoMensaje.Error);
                return;
            }

            if (textBoxNombre.Text == "")
            {
                Framework.General.GIMsgBox.Show("Debe ingresar un descripción", GI.Framework.General.enumTipoMensaje.Error);
                return;
            }

            

            Foto = new GI.BR.Propiedades.Galeria.Foto();
            Foto.Descripcion = textBoxNombre.Text;
            Foto.EsFachada = checkBoxEsFechada.Checked;
            Foto.Imagen = new Bitmap(textBoxUrlFoto.Text);


            GI.Managers.Propiedades.MngGaleriaFotos mng = new GI.Managers.Propiedades.MngGaleriaFotos();
            if ((Foto = mng.AgregarFotoAGaleria(new Bitmap(textBoxUrlFoto.Text), textBoxNombre.Text, checkBoxEsFechada.Checked, propiedad)) != null)
            {

                if (checkBoxCargarambiente.Checked)
                {
                    propiedad.Medidas.Add(medida);
                    propiedad.Actualizar();
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                Framework.General.GIMsgBox.Show("No se posible guardar la foto. Verifique los datos ingresados.", GI.Framework.General.enumTipoMensaje.Error);
            }

            
        }

        private void bExaminar_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxUrlFoto.Text = openFileDialog.FileName;

            }
        }

        private void checkBoxCargarambiente_CheckedChanged(object sender, EventArgs e)
        {
            cbTipoAmbiente.Enabled = checkBoxCargarambiente.Checked;
            cbTipoPiso.Enabled = checkBoxCargarambiente.Checked;
            textBoxAlto.Enabled = checkBoxCargarambiente.Checked;
            textBoxAmbiente.Enabled = checkBoxCargarambiente.Checked && ((GI.BR.Propiedades.TipoAmbiente)cbTipoAmbiente.SelectedItem).Codigo == 0;
            textBoxAncho.Enabled = checkBoxCargarambiente.Checked; 
            
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