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

            row.Ambientes = propiedad.Ambiente.CantidadAmbientes.ToString();
            row.AptoProf = propiedad.EsAptoProfesional ? "Si" : "No";
            row.Ascensores = propiedad.CantidadAscensores.ToString();
            row.AscensoresServicio = propiedad.CantidadAscensoresServicio.ToString();
            row.Banios = propiedad.CantidadBaños.ToString();
            row.CantidadPisos = propiedad.CantidadPisos.ToString();
            row.Cocheras = propiedad.CantidadCocheras.ToString();
            row.DeptosPorPiso = propiedad.DepartamentosPorPiso.ToString();
            row.Detalles = propiedad.Observaciones;
            row.Direccion = propiedad.Direccion.ToStringReporte();
            row.Dormitorios = propiedad.CantidadDormitorios.ToString();
            row.EntreCalles = propiedad.Direccion.CalleEntre1 != "" ? propiedad.Direccion.CalleEntre1 + " y " + propiedad.Direccion.CalleEntre2 : "";
            row.Estado = propiedad.EnumEstado.ToString();
            row.Fondo = propiedad.MedidasTerreno.Fondo.ToString();
            row.FOS = propiedad.Fos;
            row.FOT = propiedad.Fot;
            row.Frente = propiedad.MedidasTerreno.Frente.ToString();
            row.IdPropiedad = propiedad.IdPropiedad;
            row.MetrosConstruibles = propiedad.MetrosConstruibles.ToString();
            row.Operacion = propiedad.TipoPropiedad.Descripcion + " en " + (propiedad.GetType().ToString() == "GI.BR.Propiedades.Venta" ? "Venta" : "Alquiler");
            row.Orientacion = propiedad.Orientacion;
            row.Plantas = propiedad.CantidadPlantas.ToString();
            row.SupCubierta = propiedad.MedidasPropiedad.MetrosCubiertos.ToString();
            row.SupLibre = propiedad.MedidasPropiedad.MetrosLibres.ToString();
            row.SupSemicubierta = propiedad.MedidasPropiedad.MetrosSemicubiertos.ToString();
            row.Terreno = propiedad.MedidasTerreno.Metros.ToString();
            row.TipoZona = propiedad.TipoZona.ToString();
            row.Valor = propiedad.ValorPublicacion.ToString();
            row.Zonificacion = propiedad.Zonificacion;

            GI.BR.Propiedades.Galeria.Foto foto = null;
            if ((foto = propiedad.GaleriaFotos.GetFotoFachada) != null)
            {
                System.IO.MemoryStream stream = new System.IO.MemoryStream();
                foto.Imagen.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                row.FotoFachada = stream.ToArray();
            }



            ds.Propiedad.Rows.Add(row);


            DataSet.DSFichaPropiedad.MedidasRow row2 = ds.Medidas.NewMedidasRow();

            int i = 1;
            foreach (GI.BR.Propiedades.MedidaAmbiente medida in propiedad.Medidas)
            {
                if (i > 8) break;

                row2["Ambiente" + i.ToString()] = medida.NombreAmbiente;
                row2["Medidas" + i.ToString()] = medida.Ancho.ToString() + " X " + medida.Largo.ToString();
                row2["Piso" + i.ToString()] = medida.TipoDePiso.Nombre;

                ++i;
            }


            ds.Medidas.Rows.Add(row2);



            return ds;
        }
    }
}
