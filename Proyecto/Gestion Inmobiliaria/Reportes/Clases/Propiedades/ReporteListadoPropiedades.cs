using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;

namespace GI.Reportes.Clases.Propiedades
{
    public class ReporteListadoPropiedades : ReporteAbs
    {
        private GI.BR.Propiedades.Propiedades propiedades;
        private System.Type tipo;
        public ReporteListadoPropiedades(Type Tipo, GI.BR.Propiedades.Propiedades Propiedades)
            : base()
        {
            propiedades = Propiedades;
            tipo = Tipo;
        }


        protected override CrystalDecisions.CrystalReports.Engine.ReportClass ClaseReporte
        {
            get { return new Reportes.Reporte_ListadoPropiedades(); }
        }

        protected override System.Data.DataSet GetDatosReporte()
        {
            DataSet.DSListadoPropiedades ds = new GI.Reportes.DataSet.DSListadoPropiedades();


            DataSet.DSListadoPropiedades.ParametrosRow rowParam = ds.Parametros.NewParametrosRow();

            if (tipo is GI.BR.Propiedades.Venta)
                rowParam.TipoListado = "Listado de Propiedades en Venta";
            else
                rowParam.TipoListado = "Listado de Propiedades en Alquiler";

            ds.Parametros.Rows.Add(rowParam);

            
            DataSet.DSListadoPropiedades.PropiedadesRow row = null;

            foreach (GI.BR.Propiedades.Propiedad p in propiedades)
            {
                row = ds.Propiedades.NewPropiedadesRow();

                row.Ambientes = p.Ambiente.ToString();
                row.Barrio = p.Ubicacion.Barrio.ToString();
                row.Codigo = p.Codigo.ToString();
                row.Direccion = p.Direccion.ToString();
                row.EstadoPropiedad = p.Estado.ToString();
                row.IdPropiedad = p.IdPropiedad;
                row.Partido = p.Ubicacion.Localidad.ToString();
                row.TipoPropiedad = p.TipoPropiedad.ToString();
                row.Valor = p.ValorPublicacion.ToString();


                ds.Propiedades.Rows.Add(row);
            }


            return ds;
        }
    }
}
