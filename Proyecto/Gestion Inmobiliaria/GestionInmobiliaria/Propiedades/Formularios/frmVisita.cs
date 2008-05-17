using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades.Formularios
{
    public partial class frmVisita : Form
    {
        public frmVisita()
        {
            InitializeComponent();
            inicializar();
        }


        private void inicializar()
        {
            GI.BR.Propiedades.TiemposAlarmaFactory tiempos = new GI.BR.Propiedades.TiemposAlarmaFactory();
            foreach (GI.BR.Propiedades.TiempoAlarma t in tiempos.RecuperarTodos())
            {
                cbAviso.Items.Add(t);
            }

            cbAviso.SelectedIndex = 0;
        }
    }
}