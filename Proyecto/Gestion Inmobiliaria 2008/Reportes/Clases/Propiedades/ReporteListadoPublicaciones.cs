using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Reportes.Clases.Propiedades
{
    public class ReporteListadoPublicaciones : ReporteAbs
    {
        private GI.BR.Propiedades.Propiedad propiedad;

        public ReporteListadoPublicaciones(GI.BR.Propiedades.Propiedad Propiedad)
            : base()
        {

            propiedad = Propiedad;

        }



        protected override CrystalDecisions.CrystalReports.Engine.ReportClass ClaseReporte
        {
            get { return new GI.Reportes.Reportes.Reporte_Propiedad_Anexo(); }
        }

        protected override System.Data.DataSet GetDatosReporte()
        {

            DataSet.DSPropiedadAnexo ds = new GI.Reportes.DataSet.DSPropiedadAnexo();

            DataSet.DSPropiedadAnexo.EncabezadoRow row_encabezado = ds.Encabezado.NewEncabezadoRow();

            row_encabezado.Cliente = propiedad.Propietario == null ? "" : propiedad.Propietario.ToString();
            row_encabezado.CodigoPropiedad = propiedad.Codigo;
            row_encabezado.Direccion = propiedad.Direccion.ToString() + " " + propiedad.Ubicacion.Barrio.ToString();
            row_encabezado.Operacion = propiedad is GI.BR.Propiedades.Venta ? propiedad.TipoPropiedad + " en Venta" : propiedad.TipoPropiedad + " en Alquiler";

            row_encabezado.NombreListado = "Listado de Publicaciones";

            row_encabezado.Operacion = propiedad is GI.BR.Propiedades.Venta ? propiedad.TipoPropiedad.Descripcion + " en Venta" : propiedad.TipoPropiedad.Descripcion + " en Alquiler";

            ds.Encabezado.Rows.Add(row_encabezado);

            GI.BR.Propiedades.Publicaciones publicaciones = new GI.BR.Propiedades.Publicaciones();
            publicaciones.Recuperar(propiedad);

            DataSet.DSPropiedadAnexo.DatosRow row = null;

            foreach (GI.BR.Propiedades.Publicacion p in publicaciones)
            {
                row = ds.Datos.NewDatosRow();

                row.Fecha = p.Fecha.ToShortDateString();
                row.Detalle = "" + p.Medio + ". " + p.Detalles;

                row.Estado = p.ValorPublicacion.ToString();
                
                ds.Datos.Rows.Add(row);
            
            
            }



            return ds;
        }
    }
}
