using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades
{
    public partial class FrmListadoPropiedadesEnAlquiler : FrmListadoPropiedades
    {
        public FrmListadoPropiedadesEnAlquiler()
            : base(typeof(GI.BR.Propiedades.Alquiler))
        {
            InitializeComponent();

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    
    }
}