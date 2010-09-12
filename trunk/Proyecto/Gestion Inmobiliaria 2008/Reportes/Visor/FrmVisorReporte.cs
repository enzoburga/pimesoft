using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.Reportes.Visor
{
    public partial class FrmVisorReporte : Form
    {
        public FrmVisorReporte()
        {
            InitializeComponent();
        }

        public FrmVisorReporte(ReporteAbs Reporte)
            : this()
        {
            this.crystalReportViewer.ReportSource = Reporte.GetReporte();

        }


    }
}