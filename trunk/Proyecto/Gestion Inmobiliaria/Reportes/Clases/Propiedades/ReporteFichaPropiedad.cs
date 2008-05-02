using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Reportes.Clases.Propiedades
{
    public class ReporteFichaPropiedad : ReporteAbs
    {

        public ReporteFichaPropiedad(GI.BR.Propiedades.Propiedad Propiedad)
            : base()
        {

        }

        protected override CrystalDecisions.CrystalReports.Engine.ReportClass ClaseReporte
        {
            get { return new Reportes.Reporte_FichaPropiedad(); }
        }

        protected override System.Data.DataSet GetDatosReporte()
        {
            return new System.Data.DataSet();
        }
    }
}
