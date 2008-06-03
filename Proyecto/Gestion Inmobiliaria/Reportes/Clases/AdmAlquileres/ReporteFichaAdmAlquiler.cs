using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Reportes.Clases.AdmAlquileres
{
    public class ReporteFichaAdmAlquiler:ReporteAbs
    {
        private GI.BR.AdmAlquileres.AdmAlquiler admAlquiler;
        private string titulo;

        public ReporteFichaAdmAlquiler(string Titulo, GI.BR.AdmAlquileres.AdmAlquiler AdmAlquiler)
            : base()
        {
            admAlquiler = AdmAlquiler;
            titulo = Titulo;
        }

        protected override CrystalDecisions.CrystalReports.Engine.ReportClass ClaseReporte
        {
            get { return new Reportes.Reporte_FichaAdmAlquiler(); }
        }

        protected override System.Data.DataSet GetDatosReporte()
        {
            return null;
        }
    }
}
