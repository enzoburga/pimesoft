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
            cbAviso.Items.Add("15 Minutos");
            cbAviso.Items.Add("30 Minutos");
            cbAviso.Items.Add("45 Minutos");
            cbAviso.Items.Add("1 Hora");
            cbAviso.Items.Add("2 Horas");
            cbAviso.Items.Add("5 Horas");
            cbAviso.Items.Add("1 Día");
            cbAviso.Items.Add("2 Días");

            cbAviso.SelectedIndex = 0;
        }
    }
}