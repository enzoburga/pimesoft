using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Generales
{
    public partial class FrmSmtpConfig : Form
    {
        public FrmSmtpConfig()
        {
            InitializeComponent();
        }

        private void checkBoxAutenticacion_CheckedChanged(object sender, EventArgs e)
        {
            textBoxUsuario.Text = "";
            textBoxPassword.Text = "";
            textBoxUsuario.Enabled = checkBoxAutenticacion.Checked;
            textBoxPassword.Enabled = checkBoxAutenticacion.Checked;

        }
    }
}