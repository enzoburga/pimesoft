using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Seguridad
{
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private GI.BR.Seguridad.Usuario usuario;


        public GI.BR.Seguridad.Usuario Usuario
        {
            get { return usuario; }
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {

            GI.BR.Seguridad.Usuario Usr = GI.BR.Seguridad.Usuario.GetUsuario(textBoxUsuario.Text, textBoxPassword.Text);
            
            usuario = Usr;


            DialogResult = DialogResult.OK;
            Close();


        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            //bAceptar.Focus();
        }
    }
}