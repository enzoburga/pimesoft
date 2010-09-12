using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades.Formularios
{
    public partial class FrmSeleccionTipoPropiedad : Form
    {
        public FrmSeleccionTipoPropiedad()
        {
            InitializeComponent();


            cbTipo.Items.Add("Venta");
            cbTipo.Items.Add("Alquiler");
            cbTipo.SelectedIndex = 0;


        }


        public System.Type TipoPropiedadSeleccionada
        {
            get
            {
                if (cbTipo.SelectedItem == "Venta")
                {
                    return typeof(GI.BR.Propiedades.Venta);
                }
                else
                {
                    return typeof(GI.BR.Propiedades.Alquiler);
                }
            
            }
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
    }
}