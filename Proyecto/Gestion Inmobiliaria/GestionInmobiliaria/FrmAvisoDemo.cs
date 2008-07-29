using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI
{
    public partial class FrmAvisoDemo : Form
    {
        public FrmAvisoDemo()
        {
            InitializeComponent();
        }

        private void FrmAvisoDemo_Load(object sender, EventArgs e)
        {
            lMensaje.Text = "Esta es una versiónn de prueba."+Environment.NewLine;
            lMensaje.Text += "Quedan " + Framework.Seguridad.MngSeguridadDemo.GetInstancia.DiasParaVencimiento+" días de prueba." + Environment.NewLine;
            if (Framework.Seguridad.MngSeguridadDemo.GetInstancia.DiasParaVencimiento == 0)
                lMensaje.Text += "Podrá seguir utilizando PimeSoft pero en modo solo lectura." + Environment.NewLine;

            lMensaje.Text += "Si desea adquirir este producto contactese a soporte@pimesoft.com.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}