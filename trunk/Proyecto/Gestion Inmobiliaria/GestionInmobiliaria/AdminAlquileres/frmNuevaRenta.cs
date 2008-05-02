using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.AdminAlquileres
{
    public partial class frmNuevaRenta : Form
    {
        private GI.BR.AdmAlquileres.ValorRenta valorRenta;

        public GI.BR.AdmAlquileres.ValorRenta ValorRenta
        {
            get { return valorRenta; }
            set { valorRenta = value; }
        }
        private GI.BR.AdmAlquileres.ValoresRenta valores;

        public GI.BR.AdmAlquileres.ValoresRenta Valores
        {
            get { return valores; }
            set { valores = value; }
        }

        public frmNuevaRenta()
        {
            InitializeComponent();
        }
    }
}