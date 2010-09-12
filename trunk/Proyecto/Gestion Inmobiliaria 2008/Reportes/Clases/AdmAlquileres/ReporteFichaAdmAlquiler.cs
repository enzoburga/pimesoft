using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Reportes.Clases.AdmAlquileres
{
    public class ReporteFichaAdmAlquiler : ReporteAbs
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
            DataSet.DSFichaAdmAlquiler ds = new GI.Reportes.DataSet.DSFichaAdmAlquiler();
            Managers.ManagerGeneral mngGeneral = new GI.Reportes.Managers.ManagerGeneral();

            #region Imagenes Encabezado y pie

            DataSet.DSFichaAdmAlquiler.EncabezadosRow row_encabezado = ds.Encabezados.NewEncabezadosRow();
            GI.BR.Reportes.ParametrosReportes param = new GI.BR.Reportes.ParametrosReportes();
            param.Recuperar();
            if (param.Encabezado != null)
                row_encabezado.Encabezado = mngGeneral.ConvertBitmapToArray(param.Encabezado, System.Drawing.Imaging.ImageFormat.Jpeg);
            if (param.PiePagina != null)
                row_encabezado.PiePagina = mngGeneral.ConvertBitmapToArray(param.PiePagina, System.Drawing.Imaging.ImageFormat.Jpeg);
            ds.Encabezados.Rows.Add(row_encabezado);

            #endregion

            #region Encabezado
            DataSet.DSFichaAdmAlquiler.EncabezadoRow rowEncabezado = ds.Encabezado.NewEncabezadoRow();

            rowEncabezado.Titulo = titulo;
            rowEncabezado.CodigoPropiedad = admAlquiler.Alquiler.Codigo;

            if (admAlquiler.Contacto == null)
                rowEncabezado.Contacto = "Sin Definir";
            else
                rowEncabezado.Contacto = admAlquiler.Contacto.ToString();

            rowEncabezado.Direccion = admAlquiler.Alquiler.Direccion.ToString();

            if(admAlquiler.Alquiler.Propietario == null)
                rowEncabezado.Propietario = "Sin Definir";
            else
                rowEncabezado.Propietario = admAlquiler.Alquiler.Propietario.ToString();

            ds.Encabezado.AddEncabezadoRow(rowEncabezado); 
            #endregion

            #region Contrato Vigente
            DataSet.DSFichaAdmAlquiler.ContratoVigenteRow rowContrato = ds.ContratoVigente.NewContratoVigenteRow();
            rowContrato.Deposito = admAlquiler.ContratoVigente.Deposito.ToString();
            rowContrato.DiaCobro = admAlquiler.ContratoVigente.DiaCobro.ToString();
            rowContrato.FechaInicio = admAlquiler.ContratoVigente.FechaInicio;

            if (admAlquiler.ContratoVigente.Inquilino != null)
                rowContrato.Inquilino = admAlquiler.ContratoVigente.Inquilino.ToString();
            else
                rowContrato.Inquilino = "Sin Definir";

            rowContrato.FechaVencimiento = admAlquiler.ContratoVigente.FechaVencimiento;

            if (admAlquiler.ContratoVigente.Observaciones == "")
                rowContrato.Observaciones = "- Sin Observaciones -";
            else
                rowContrato.Observaciones = admAlquiler.ContratoVigente.Observaciones;
            ds.ContratoVigente.AddContratoVigenteRow(rowContrato); 
            #endregion

            #region Valores Renta
            DataSet.DSFichaAdmAlquiler.ValoresRentaRow rowValorRenta;
            foreach (GI.BR.AdmAlquileres.ValorRenta vr in admAlquiler.ContratoVigente.ValoresRenta)
            {
                rowValorRenta = ds.ValoresRenta.NewValoresRentaRow();
                rowValorRenta.Desde = (System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(vr.MesVigenciaDesde)).ToUpper() + " - " + vr.AnioVigenciaDesde.ToString();
                rowValorRenta.Hasta = (System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(vr.MesVigenciaHasta)).ToUpper() + " - " + vr.AnioVigenciaHasta.ToString();
                rowValorRenta.Monto = vr.Monto.ToString();

                ds.ValoresRenta.AddValoresRentaRow(rowValorRenta);

            } 
            #endregion

            #region Pagos
            DataSet.DSFichaAdmAlquiler.PagosRow rowPago;

            GI.BR.AdmAlquileres.Pagos pagos = new GI.BR.AdmAlquileres.Pagos();
            pagos.RecuperarPorContrato(admAlquiler.ContratoVigente);
            foreach (GI.BR.AdmAlquileres.Pago p in pagos)
            {
                rowPago = ds.Pagos.NewPagosRow();
                rowPago.FechaPago = p.FechaPago;
                rowPago.Monto = p.Importe.ToString();
                rowPago.RentaCancelada = (System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(p.MesCancelado)).ToUpper() + " - " + p.AnioPagado.ToString();

                ds.Pagos.AddPagosRow(rowPago);
            } 
            #endregion

            return ds;
        }
    }
}
