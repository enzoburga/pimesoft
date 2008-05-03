using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Reportes.Clases.Propiedades
{
    public class ReporteFichaPropiedad : ReporteAbs
    {

        GI.BR.Propiedades.Propiedad propiedad;
        public ReporteFichaPropiedad(GI.BR.Propiedades.Propiedad p)
        {
            propiedad = p;
        }


        protected override CrystalDecisions.CrystalReports.Engine.ReportClass ClaseReporte
        {
            get { return new GI.Reportes.Reportes.Reporte_FichaPropiedad(); }
        }

        protected override System.Data.DataSet GetDatosReporte()
        {
            DataSet.DSFichaPropiedad ds = new GI.Reportes.DataSet.DSFichaPropiedad();

            DataSet.DSFichaPropiedad.PropiedadRow row = ds.Propiedad.NewPropiedadRow();
            row.Codigo = propiedad.Codigo;
            row.IdPropiedad = 1;

            ds.Propiedad.Rows.Add(row);


            return ds;
        }
    }
}
