using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades.Formularios
{
    public partial class frmNota : Form
    {

        private GI.BR.Propiedades.Propiedad p;
        private GI.BR.Propiedades.Nota n;

        public frmNota()
        {
            InitializeComponent();
        }


        public frmNota(GI.BR.Propiedades.Nota Nota, GI.BR.Propiedades.Propiedad Propiedad) : this()
        {
            n = Nota;
            p = Propiedad;

            lFecha.Text = DateTime.Now.ToShortDateString();
            
            if (n.IdNota > 0)
            {
                lFecha.Text = Nota.Fecha.ToShortDateString();
                textBoxNota.Text = Nota.Comentario;
                textBoxNota.ReadOnly = true;
                bCancelar.Text = "Cerrar";
                bAceptar.Enabled = false;
            }
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (textBoxNota.Text == "")
            {
                Framework.General.GIMsgBox.Show("Debe ingresar una nota", GI.Framework.General.enumTipoMensaje.Error);
                textBoxNota.Focus();
                return;
            }


            n.Fecha = DateTime.Now;
            n.Comentario = textBoxNota.Text;

            if (!n.Guardar(p))
            {
                Framework.General.GIMsgBox.Show("No es posible guardar la nota", GI.Framework.General.enumTipoMensaje.Error);
                textBoxNota.Focus();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();



        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}