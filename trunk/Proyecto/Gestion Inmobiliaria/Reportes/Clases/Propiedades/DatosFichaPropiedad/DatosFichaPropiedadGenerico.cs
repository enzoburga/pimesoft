using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Reportes.Clases.Propiedades
{
    internal class DatosFichaPropiedadGenerico : DatosFichaPropiedad
    {



        public override GI.Reportes.DataSet.DSFichaPropiedadv2 GetDataSet(GI.BR.Propiedades.Propiedad Propiedad)
        {
            Managers.ManagerGeneral mngGeneral = new GI.Reportes.Managers.ManagerGeneral();
            DataSet.DSFichaPropiedadv2 ds = new GI.Reportes.DataSet.DSFichaPropiedadv2();
            int index = 0;

            #region Propiedad - Generales

            DataSet.DSFichaPropiedadv2.PropiedadRow row_propiedad = ds.Propiedad.NewPropiedadRow();

            row_propiedad.Direccion = Propiedad.Direccion.ToStringReporte();
            row_propiedad.Codigo = Propiedad.Codigo;
            row_propiedad.Operacion = (Propiedad is GI.BR.Propiedades.Venta) ? "Venta" : "Alquiler";
            row_propiedad.Localizacion = Propiedad.Ubicacion.Barrio.ToString() + " - " + Propiedad.Ubicacion.Localidad.ToString() + " - " + Propiedad.Ubicacion.Provincia.ToString();
            row_propiedad.Ambientes = Propiedad.Ambiente.ToString();
            row_propiedad.TipoUnidad = Propiedad.TipoPropiedad.Descripcion;
            row_propiedad.Ubicacion = Propiedad.Orientacion.ToString();

            row_propiedad.Antiguedad = Propiedad.Antiguedad == 0 ? "A Estrenar" : Propiedad.Antiguedad.ToString() + " años";

            row_propiedad.Estado = Propiedad.EnumEstado.ToString();
            row_propiedad.Precio = Propiedad.ValorPublicacion.Moneda.ToString() + " " + Propiedad.ValorPublicacion.Importe.ToString("##,###,###.##");
            row_propiedad.Observaciones = Propiedad.Observaciones;

            GI.BR.Propiedades.Galeria.Foto fachada = null;
            if ((fachada = Propiedad.GaleriaFotos.GetFotoFachada) != null)
            {
                /* FALTA COLOCAR FOTO FACHADA */
                row_propiedad.Fachada = mngGeneral.ConvertBitmapToArray(fachada.Imagen, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            else
            {
                row_propiedad.Fachada = new byte[1];
            }

            ds.Propiedad.Rows.Add(row_propiedad);



            #endregion

            #region Propiedad - Superficies

            DataSet.DSFichaPropiedadv2.SuperficiesRow row_superficies = ds.Superficies.NewSuperficiesRow();
            index = 1;

            if (Propiedad.MedidasPropiedad.MetrosCubiertos > 0)
            {
                row_superficies["SupNombre" + index] = "Metros Cubiertos:";
                row_superficies["Sup" + index] = Propiedad.MedidasPropiedad.MetrosCubiertos.ToString();
                ++index;
            }
            if (Propiedad.MedidasPropiedad.MetrosSemicubiertos > 0)
            {
                row_superficies["SupNombre" + index] = "Metros Semicubiertos:";
                row_superficies["Sup" + index] = Propiedad.MedidasPropiedad.MetrosSemicubiertos.ToString();
                ++index;
            }
            if (Propiedad.MedidasPropiedad.MetrosLibres > 0)
            {
                row_superficies["SupNombre" + index] = "Metros Libres:";
                row_superficies["Sup" + index] = Propiedad.MedidasPropiedad.MetrosLibres.ToString();
            }

            ds.Superficies.Rows.Add(row_superficies);

            #endregion

            #region Datos Principales

            index = 1;
            DataSet.DSFichaPropiedadv2.CaracteristicasPrincipalesRow row_principales = ds.CaracteristicasPrincipales.NewCaracteristicasPrincipalesRow();

            if (Propiedad.Disposicion != GI.BR.Propiedades.DepartamentoDisposicion.SinDefinir)
            {
                row_principales["Campo" + index] = "Disposición:";
                row_principales["Valor" + index] = Propiedad.Disposicion.ToString();
                ++index;
            }

            row_principales["Campo" + index] = "Dormitorios:";
            row_principales["Valor" + index] = Propiedad.CantidadDormitorios.ToString();
            ++index;

            ds.CaracteristicasPrincipales.Rows.Add(row_principales);


            #endregion


            #region Region I

            
            DataSet.DSFichaPropiedadv2.Region1Row row_region_1 = ds.Region1.NewRegion1Row();

            row_region_1.NombreRegion = "Lote";

            if (Propiedad.MedidasTerreno.Metros > 0)
            {
                row_region_1.Campo1 = "Frente:";
                row_region_1.Valor1 = Propiedad.MedidasTerreno.Frente.ToString() + " m";

                row_region_1.Campo2 = "Fondo:";
                row_region_1.Valor2 = Propiedad.MedidasTerreno.Fondo.ToString() + " m";


                row_region_1.Campo3 = "Metros:";
                row_region_1.Valor3 = Propiedad.MedidasTerreno.Metros.ToString() + " m2";



            }



            


            ds.Region1.Rows.Add(row_region_1);

            #endregion

            #region Region II

            DataSet.DSFichaPropiedadv2.Region2Row row_region_2 = ds.Region2.NewRegion2Row();

            row_region_2.NombreRegion = "Servicios";
            ds.Region2.Rows.Add(row_region_2);

            #endregion

            #region Region III

            DataSet.DSFichaPropiedadv2.Region3Row row_region_3 = ds.Region3.NewRegion3Row();

            row_region_3.NombreRegion = "Unidad";

            if (Propiedad.CantidadCocheras > 0)
            {
                row_region_3.Campo1 = "Cochera";
                row_region_3.Valor1 = "Si";
            }

            ds.Region3.Rows.Add(row_region_3);

            #endregion

            #region Region IV

            DataSet.DSFichaPropiedadv2.Region4Row row_region_4 = ds.Region4.NewRegion4Row();
            index = 1;

            foreach (GI.BR.Propiedades.MedidaAmbiente ambiente in Propiedad.Medidas)
            {
                if (ambiente.TipoAmbiente.Codigo != 10008 &&
                        ambiente.TipoAmbiente.Codigo != 10007 &&
                        ambiente.TipoAmbiente.Codigo != 10001 &&
                        ambiente.TipoAmbiente.Codigo != 10014 &&
                        ambiente.TipoAmbiente.Codigo != 10015)
                {
                    row_region_4["Campo" + index] = ambiente.ToString() + ":";
                    row_region_4["Valor" + index] = ambiente.Ancho.ToString() + " x " + ambiente.Largo.ToString();
                    index++;


                }
            }


            row_region_4.NombreRegion = "Detalles Ambientes";
            ds.Region4.Rows.Add(row_region_4);


            #endregion

            #region Region V


            DataSet.DSFichaPropiedadv2.Region5Row row_region_5 = ds.Region5.NewRegion5Row();
            index = 1;

            foreach (GI.BR.Propiedades.MedidaAmbiente ambiente in Propiedad.Medidas)
            {
                if (ambiente.TipoAmbiente.Codigo == 10001)
                {
                    row_region_5["Campo" + index] = ambiente.ToString() + ":";
                    row_region_5["Valor" + index] = ambiente.Ancho.ToString() + " x " + ambiente.Largo.ToString();
                    index++;
                    break;
                }
            }

            foreach (GI.BR.Propiedades.MedidaAmbiente ambiente in Propiedad.Medidas)
            {
                if (ambiente.TipoAmbiente.Codigo == 10014)
                {
                    row_region_5["Campo" + index] = ambiente.ToString() + ":";
                    row_region_5["Valor" + index] = ambiente.Ancho.ToString() + " x " + ambiente.Largo.ToString();
                    index++;
                    break;
                }
            }

            foreach (GI.BR.Propiedades.MedidaAmbiente ambiente in Propiedad.Medidas)
            {
                if (ambiente.TipoAmbiente.Codigo == 10015)
                {
                    row_region_5["Campo" + index] = ambiente.ToString() + ":";
                    row_region_5["Valor" + index] = ambiente.Ancho.ToString() + " x " + ambiente.Largo.ToString();
                    index++;
                    break;
                }
            }

            foreach (GI.BR.Propiedades.MedidaAmbiente ambiente in Propiedad.Medidas)
            {
                if (ambiente.TipoAmbiente.Codigo == 10012)
                {
                    row_region_5["Campo" + index] = ambiente.ToString() + ":";
                    row_region_5["Valor" + index] = "Si";
                    index++;
                    break;
                }
            }

            foreach (GI.BR.Propiedades.MedidaAmbiente ambiente in Propiedad.Medidas)
            {
                if (ambiente.TipoAmbiente.Codigo == 10013)
                {
                    row_region_5["Campo" + index] = ambiente.ToString() + ":";
                    row_region_5["Valor" + index] = "Si";
                    index++;
                    break;
                }
            }

            foreach (GI.BR.Propiedades.MedidaAmbiente ambiente in Propiedad.Medidas)
            {
                if (ambiente.TipoAmbiente.Codigo == 10007)
                {
                    row_region_5["Campo" + index] = ambiente.ToString() + ":";
                    row_region_5["Valor" + index] = ambiente.Ancho.ToString() + " x " + ambiente.Largo.ToString();
                    index++;
                    break;
                }
            }

            foreach (GI.BR.Propiedades.MedidaAmbiente ambiente in Propiedad.Medidas)
            {
                if (ambiente.TipoAmbiente.Codigo == 10008)
                {
                    row_region_5["Campo" + index] = ambiente.ToString() + ":";
                    row_region_5["Valor" + index] = ambiente.Ancho.ToString() + " x " + ambiente.Largo.ToString();
                    index++;
                    break;
                }
            }

            row_region_5.NombreRegion = "Área de Servicios";
            ds.Region5.Rows.Add(row_region_5);



            #endregion



            return ds;


        }
    }
}
