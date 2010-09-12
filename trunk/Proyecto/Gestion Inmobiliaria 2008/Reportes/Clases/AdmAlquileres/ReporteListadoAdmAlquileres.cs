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

            Managers.ManagerGeneral mngGeneral = new GI.Reportes.Managers.ManagerGeneral();

            #region Imagenes Encabezado y pie

            DataSet.DSListadoAdmAlquileres.EncabezadosRow row_encabezado = ds.Encabezados.NewEncabezadosRow();
            GI.BR.Reportes.ParametrosReportes param = new GI.BR.Reportes.ParametrosReportes();
            param.Recuperar();
            if (param.Encabezado != null)
                row_encabezado.Encabezado = mngGeneral.ConvertBitmapToArray(param.Encabezado, System.Drawing.Imaging.ImageFormat.Jpeg);
            if (param.PiePagina != null)
                row_encabezado.PiePagina = mngGeneral.ConvertBitmapToArray(param.PiePagina, System.Drawing.Imaging.ImageFormat.Jpeg);
            ds.Encabezados.Rows.Add(row_encabezado);

            #endregion

            DataSet.DSListadoAdmAlquileres.EncabezadoRow rowEncabezado = ds.Encabezado.NewEncabezadoRow();

            rowEncabezado.TituloReporte = titulo;

            ds.Encabezado.Rows.Add(rowEncabezado);


            DataSet.DSListadoAdmAlquileres.DetallesRow rowDetalles = null;

            foreach (GI.BR.AdmAlquileres.AdmAlquiler a in admAlquileres)
            {
                rowDetalles = ds.Detalles.NewDetallesRow();

                rowDetalles.DiaCobro = a.ContratoVigente.DiaCobro;
                rowDetalles.DireccionPropiedad = a.Alquiler.Direccion.ToString();
                rowDetalles.FechaInicio = a.ContratoVigente.FechaInicio;
                rowDetalles.FechaVencimiento = a.ContratoVigente.FechaVencimiento;
                GI.BR.Valor monto = a.ContratoVigente.GetMonto(DateTime.Today.Month, DateTime.Today.Year);
                if (monto != null)
                    rowDetalles.Monto = monto.ToString();
                else
                    rowDetalles.Monto = "------";

                if(a.Contacto == null)
                    rowDetalles.NombreContacto = "------";
                else
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
