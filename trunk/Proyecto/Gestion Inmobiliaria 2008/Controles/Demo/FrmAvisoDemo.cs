using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.Framework.Demo
{
    public partial class FrmAvisoDemo : Form
    {
        public FrmAvisoDemo()
        {
            InitializeComponent();
        }

        private void FrmAvisoDemo_Load(object sender, EventArgs e)
        {
            lMensaje.Text = "Esta es una versi�nn de prueba." + Environment.NewLine + Environment.NewLine;
            lMensaje.Text += "Podr� seguir utilizando el sistema pero sin ingresar nuevos clientes o propiedades." + Environment.NewLine;

            //lMensaje.Text += "Si desea adquirir este producto contactese a soporte@pimesoft.com.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}