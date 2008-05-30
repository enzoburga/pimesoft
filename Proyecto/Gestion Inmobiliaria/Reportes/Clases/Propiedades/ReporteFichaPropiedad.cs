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
            get { return new GI.Reportes.Reportes.Reporte_FichaPropiedad_v2(); }
        }






        protected override System.Data.DataSet GetDatosReporte()
        {

            AbstractFactoryDatosFicha factory = new AbstractFactoryDatosFicha();
            DatosFichaPropiedad datos = factory.GetDatosFichaPropiedad(propiedad.TipoPropiedad);

            return datos.GetDataSet(propiedad);


        }









    }
}
