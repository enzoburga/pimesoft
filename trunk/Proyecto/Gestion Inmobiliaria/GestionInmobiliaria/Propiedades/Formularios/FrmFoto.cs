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

        public GI.BR.Propiedades.Galeria.Foto GetFoto
        {
            get { return Foto; }
        }
        public FrmFoto()
        {
            InitializeComponent();
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
            if (mng.AgregarFotoAGaleria(Foto, propiedad))
            {
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
    }
}