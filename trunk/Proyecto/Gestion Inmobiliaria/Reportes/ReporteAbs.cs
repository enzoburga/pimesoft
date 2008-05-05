using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace GI.Reportes
{
    public abstract class ReporteAbs
    {

        protected abstract CrystalDecisions.CrystalReports.Engine.ReportClass ClaseReporte
        {
            get;
        }

        protected abstract System.Data.DataSet GetDatosReporte();


        public virtual System.IO.Stream GetStreamReporte(ExportFormatType Formato)
        {

            ReportDocument reportDocument = new ReportDocument();
            string path = Path.Combine(Path.Combine(Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory), "Reportes\\"), ClaseReporte.ResourceName);
            reportDocument.Load(path);
            reportDocument.SetDataSource(GetDatosReporte());


            return reportDocument.ExportToStream(Formato);           

        }
        


        public virtual CrystalDecisions.CrystalReports.Engine.ReportDocument GetReporte()
        {

            ReportDocument reportDocument = new ReportDocument();
            string path = Path.Combine(Path.Combine(Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory), "Reportes\\"), ClaseReporte.ResourceName);
            reportDocument.Load(path);
            reportDocument.SetDataSource(GetDatosReporte());
            
            return reportDocument;

        }

    }
}
