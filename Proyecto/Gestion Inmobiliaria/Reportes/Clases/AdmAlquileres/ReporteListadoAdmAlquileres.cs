using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Reportes.Clases.AdmAlquileres
{
    public class ReporteListadoAdmAlquileres : ReporteAbs
    {
        private GI.BR.AdmAlquileres.AdmAlquileres admAlquileres;
        private string titulo;

        public ReporteListadoAdmAlquileres(string Titulo, GI.BR.AdmAlquileres.AdmAlquileres AdmAlquileres)
            : base()
        {
            admAlquileres = AdmAlquileres;
            titulo = Titulo;
        }

        protected override CrystalDecisions.CrystalReports.Engine.ReportClass ClaseReporte
        {
            get { return new Reportes.Reporte_ListadoAdmAlquileres(); }
        }

        protected override System.Data.DataSet GetDatosReporte()
        {
            DataSet.DSListadoAdmAlquileres ds = new GI.Reportes.DataSet.DSListadoAdmAlquileres();


            DataSet.DSListadoAdmAlquileres.EncabezadoRow rowEncabezado = ds.Encabezado.NewEncabezadoRow();

            rowEncabezado.TituloReporte = titulo;

            ds.Encabezado.Rows.Add(rowEncabezado);


            DataSet.DSListadoAdmAlquileres.DetallesRow rowDetalles = null;

            foreach (GI.BR.AdmAlquileres.AdmAlquiler a in admAlquileres)
            {
                rowDetalles = ds.Detalles.NewDetallesRow();

                rowDetalles.DiaCobro = a.ContratoVigente.DiaCobro;
                rowDetalles.DireccionPropiedad = "CARGAR PROP POR ID";//c.Alquiler.Direccion.ToString();
                rowDetalles.FechaInicio = a.ContratoVigente.FechaInicio;
                rowDetalles.FechaVencimiento = a.ContratoVigente.FechaVencimiento;
                GI.BR.Valor monto = a.ContratoVigente.GetMonto(DateTime.Today.Month, DateTime.Today.Year);
                if (monto != null)
                    rowDetalles.Monto = monto.ToString();
                else
                    rowDetalles.Monto = "------";
                rowDetalles.NombreContacto = a.Contacto.ToString();
                if (a.ContratoVigente.Inquilino == null)
                    rowDetalles.NombreInquilino = "No hay Inquilino.";
                else
                    rowDetalles.NombreInquilino = a.ContratoVigente.Inquilino.ToString();

                ds.Detalles.Rows.Add(rowDetalles);
            }


            return ds;
        }
    }
}
