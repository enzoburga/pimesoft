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

            #region Encabezado

            DataSet.DSFichaPropiedadv2.EncabezadosRow row_encabezado = ds.Encabezados.NewEncabezadosRow();
            GI.BR.Reportes.ParametrosReportes param = new GI.BR.Reportes.ParametrosReportes();
            param.Recuperar();
            if (param.Encabezado != null)
                row_encabezado.Encabezado = mngGeneral.ConvertBitmapToArray(param.Encabezado, System.Drawing.Imaging.ImageFormat.Jpeg);
            if (param.PiePagina != null)
                row_encabezado.PiePagina = mngGeneral.ConvertBitmapToArray(param.PiePagina, System.Drawing.Imaging.ImageFormat.Jpeg);
            ds.Encabezados.Rows.Add(row_encabezado);

            
            #endregion

            #region Propiedad - Generales

            DataSet.DSFichaPropiedadv2.PropiedadRow row_propiedad = ds.Propiedad.NewPropiedadRow();

            row_propiedad.Direccion = Propiedad.Direccion.ToStringReporte();
            row_propiedad.Codigo = Propiedad.Codigo;
            row_propiedad.Operacion = (Propiedad is GI.BR.Propiedades.Venta) ? "Venta" : "Alquiler";
            row_propiedad.Localizacion = Propiedad.Ubicacion.Barrio.ToString() + " - " + Propiedad.Ubicacion.Localidad.ToString() + " - " + Propiedad.Ubicacion.Provincia.ToString();
            row_propiedad.Ambientes = Propiedad.Ambiente.ToString();
            row_propiedad.TipoUnidad = Propiedad.TipoPropiedad.Descripcion;
            row_propiedad.Ubicacion = Propiedad.Orientacion.ToString();

            row_propiedad.Antiguedad = Propiedad.Antiguedad == 0 ? "A Estrenar" : Propiedad.Antiguedad.ToString() + " a�os";

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

            row_superficies["SupNombre" + index] = "Metros Cubiertos:";
            row_superficies["Sup" + index] = Propiedad.MedidasPropiedad.MetrosCubiertos.ToString();
            ++index;

            row_superficies["SupNombre" + index] = "Metros Semicubiertos:";
            row_superficies["Sup" + index] = Propiedad.MedidasPropiedad.MetrosSemicubiertos.ToString();
            ++index;

            row_superficies["SupNombre" + index] = "Metros Libres:";
            row_superficies["Sup" + index] = Propiedad.MedidasPropiedad.MetrosLibres.ToString();


            ds.Superficies.Rows.Add(row_superficies);

            #endregion

            #region Datos Principales

            index = 1;
            DataSet.DSFichaPropiedadv2.CaracteristicasPrincipalesRow row_principales = ds.CaracteristicasPrincipales.NewCaracteristicasPrincipalesRow();

            if (Propiedad.Disposicion != GI.BR.Propiedades.DepartamentoDisposicion.SinDefinir)
            {
                row_principales["Campo" + index] = "Disposici�n:";
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

                if (index > 18) break;

                
                    row_region_4["Campo" + index] = ambiente.ToString() + ":";
                    row_region_4["Valor" + index] = ambiente.Ancho.ToString() + " x " + ambiente.Largo.ToString();
                    index++;


                
            }



            row_region_4.NombreRegion = "Detalles Ambientes";
            ds.Region4.Rows.Add(row_region_4);


            #endregion

            #region Region V


            DataSet.DSFichaPropiedadv2.Region5Row row_region_5 = ds.Region5.NewRegion5Row();
            index = 1;


            if (Propiedad.Jardin)
            {
                row_region_5["Campo" + index] = "Jard�n: ";
                row_region_5["Valor" + index] = "Si";
                index++;
            }
            if (Propiedad.Patio)
            {
                row_region_5["Campo" + index] = "Patio: ";
                row_region_5["Valor" + index] = "Si";
                index++;
            }
            if (Propiedad.Piscina)
            {
                row_region_5["Campo" + index] = "Piscina: ";
                row_region_5["Valor" + index] = "Si";
                index++;
            }
            if (Propiedad.Lavadero)
            {
                row_region_5["Campo" + index] = "Lavadero: ";
                row_region_5["Valor" + index] = "Si";
                index++;
            }
            if (Propiedad.Dependencia)
            {
                row_region_5["Campo" + index] = "Dependencia: ";
                row_region_5["Valor" + index] = "Si";
                index++;
            }
            if (Propiedad.Quincho)
            {
                row_region_5["Campo" + index] = "Quincho: ";
                row_region_5["Valor" + index] = "Si";
                index++;
            }
            if (Propiedad.Parrilla)
            {
                row_region_5["Campo" + index] = "Parrilla: ";
                row_region_5["Valor" + index] = "Si";
                index++;
            }
            if (Propiedad.Balcon)
            {
                row_region_5["Campo" + index] = "Balc�n: ";
                row_region_5["Valor" + index] = "Si";
                index++;
            }
            if (Propiedad.Terraza)
            {
                row_region_5["Campo" + index] = "Terraza: ";
                row_region_5["Valor" + index] = "Si";
                index++;
            }
            if (Propiedad.Playroom)
            {
                row_region_5["Campo" + index] = "Playroom: ";
                row_region_5["Valor" + index] = "Si";
                index++;
            }
            if (Propiedad.Baulera)
            {
        row_region_5["Campo" + index] = "Baulera: ";
                row_region_5["Valor" + index] = "Si";
                index++;
            }
            if (Propiedad.CuartoHerraminetas)
            {
                row_region_5["Campo" + index] = "Cuarto de Herramientas: ";
                row_region_5["Valor" + index] = "Si";
                index++;
            }

            if (Propiedad.CantidadCocheras > 0)
            {
                row_region_5.Campo1 = "Cochera";
                row_region_5.Valor1 = "Si";
                index++;
            }


            //foreach (GI.BR.Propiedades.MedidaAmbiente ambiente in Propiedad.Medidas)
            //{
            //    if (ambiente.TipoAmbiente.Codigo == 10001)
            //    {
            //        row_region_5["Campo" + index] = ambiente.ToString() + ":";
            //        row_region_5["Valor" + index] = ambiente.Ancho.ToString() + " x " + ambiente.Largo.ToString();
            //        index++;
            //        break;
            //    }
            //}

            //foreach (GI.BR.Propiedades.MedidaAmbiente ambiente in Propiedad.Medidas)
            //{
            //    if (ambiente.TipoAmbiente.Codigo == 10014)
            //    {
            //        row_region_5["Campo" + index] = ambiente.ToString() + ":";
            //        row_region_5["Valor" + index] = ambiente.Ancho.ToString() + " x " + ambiente.Largo.ToString();
            //        index++;
            //        break;
            //    }
            //}

            //foreach (GI.BR.Propiedades.MedidaAmbiente ambiente in Propiedad.Medidas)
            //{
            //    if (ambiente.TipoAmbiente.Codigo == 10015)
            //    {
            //        row_region_5["Campo" + index] = ambiente.ToString() + ":";
            //        row_region_5["Valor" + index] = ambiente.Ancho.ToString() + " x " + ambiente.Largo.ToString();
            //        index++;
            //        break;
            //    }
            //}

            //foreach (GI.BR.Propiedades.MedidaAmbiente ambiente in Propiedad.Medidas)
            //{
            //    if (ambiente.TipoAmbiente.Codigo == 10012)
            //    {
            //        row_region_5["Campo" + index] = ambiente.ToString() + ":";
            //        row_region_5["Valor" + index] = "Si";
            //        index++;
            //        break;
            //    }
            //}

            //foreach (GI.BR.Propiedades.MedidaAmbiente ambiente in Propiedad.Medidas)
            //{
            //    if (ambiente.TipoAmbiente.Codigo == 10013)
            //    {
            //        row_region_5["Campo" + index] = ambiente.ToString() + ":";
            //        row_region_5["Valor" + index] = "Si";
            //        index++;
            //        break;
            //    }
            //}

            //foreach (GI.BR.Propiedades.MedidaAmbiente ambiente in Propiedad.Medidas)
            //{
            //    if (ambiente.TipoAmbiente.Codigo == 10007)
            //    {
            //        row_region_5["Campo" + index] = ambiente.ToString() + ":";
            //        row_region_5["Valor" + index] = ambiente.Ancho.ToString() + " x " + ambiente.Largo.ToString();
            //        index++;
            //        break;
            //    }
            //}

            //foreach (GI.BR.Propiedades.MedidaAmbiente ambiente in Propiedad.Medidas)
            //{
            //    if (ambiente.TipoAmbiente.Codigo == 10008)
            //    {
            //        row_region_5["Campo" + index] = ambiente.ToString() + ":";
            //        row_region_5["Valor" + index] = ambiente.Ancho.ToString() + " x " + ambiente.Largo.ToString();
            //        index++;
            //        break;
            //    }
            //}

            row_region_5.NombreRegion = "�rea de Servicios";
            ds.Region5.Rows.Add(row_region_5);



            #endregion



            return ds;


        }
    }
}
