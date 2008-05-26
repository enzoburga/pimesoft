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
            DataSet.DSFichaPropiedadv2 ds = new GI.Reportes.DataSet.DSFichaPropiedadv2();
            int index = 0;

            #region Propiedad - Generales

            DataSet.DSFichaPropiedadv2.PropiedadRow row_propiedad = ds.Propiedad.NewPropiedadRow();

            row_propiedad.Direccion = propiedad.Direccion.ToStringReporte();
            row_propiedad.Codigo = propiedad.Codigo;
            row_propiedad.Operacion = (propiedad is GI.BR.Propiedades.Venta) ? "Venta" : "Alquiler";
            row_propiedad.Localizacion = propiedad.Ubicacion.Barrio.ToString() + " - " + propiedad.Ubicacion.Localidad.ToString() + " - " + propiedad.Ubicacion.Provincia.ToString();
            row_propiedad.Ambientes = propiedad.Ambiente.ToString();
            row_propiedad.TipoUnidad = propiedad.TipoPropiedad.Descripcion;
            row_propiedad.Ubicacion = propiedad.Orientacion.ToString();
            /* FALTA COMPLETAR LA ANTIGUEDAD */
            row_propiedad.Estado = propiedad.EnumEstado.ToString();
            row_propiedad.Precio = propiedad.ValorPublicacion.Moneda.ToString() + " " + propiedad.ValorPublicacion.Importe.ToString("##,###,###.##");
            row_propiedad.Observaciones = propiedad.Observaciones;
            
            GI.BR.Propiedades.Galeria.Foto fachada=null;
            if ((fachada = propiedad.GaleriaFotos.GetFotoFachada) != null)
            {
                /* FALTA COLOCAR FOTO FACHADA */
            }

            ds.Propiedad.Rows.Add(row_propiedad);



            #endregion

            #region Propiedad - Superficies

            DataSet.DSFichaPropiedadv2.SuperficiesRow row_superficies = ds.Superficies.NewSuperficiesRow();
            index = 1;

            if (propiedad.MedidasPropiedad.MetrosCubiertos > 0)
            {
                row_superficies["SupNombre" + index] = "Metros Cubiertos";
                row_superficies["Sup" + index] = propiedad.MedidasPropiedad.MetrosCubiertos.ToString();
                ++index;
            }
            if (propiedad.MedidasPropiedad.MetrosSemicubiertos > 0)
            {
                row_superficies["SupNombre" + index] = "Metros Semicubiertos";
                row_superficies["Sup" + index] = propiedad.MedidasPropiedad.MetrosSemicubiertos.ToString();
                ++index;
            }
            if (propiedad.MedidasPropiedad.MetrosLibres > 0)
            {
                row_superficies["SupNombre" + index] = "Metros Libres";
                row_superficies["Sup" + index] = propiedad.MedidasPropiedad.MetrosLibres.ToString();
            }

            ds.Superficies.Rows.Add(row_superficies);

            #endregion



            return ds;
        }
    }
}
