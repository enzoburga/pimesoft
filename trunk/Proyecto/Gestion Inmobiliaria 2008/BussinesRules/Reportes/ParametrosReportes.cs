using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GI.BR.Reportes
{
    public class ParametrosReportes
    {

        public ParametrosReportes() { }



        private System.Drawing.Bitmap encabezado;
        private System.Drawing.Bitmap piePagina;

        public System.Drawing.Bitmap PiePagina
        {
            get { return piePagina; }
            set { piePagina = value; }
        }

        public System.Drawing.Bitmap Encabezado
        {
            get { return encabezado; }
            set { encabezado = value; }
        }




        public void Recuperar()
        {

            using (System.Data.IDataReader dr = new DA.ParametrosReportesData().RecuperarParametrosReporte())
            {
                System.IO.MemoryStream ms;
                System.IO.MemoryStream ms1;
                if (dr.Read())
                {
                    ms = new System.IO.MemoryStream((byte[])dr.GetValue(dr.GetOrdinal("Encabezado")));
                    if (ms.Length > 0)
                        this.Encabezado = new System.Drawing.Bitmap(ms);


                    ms1 = new System.IO.MemoryStream((byte[])dr.GetValue(dr.GetOrdinal("PiePagina")));
                    if (ms1.Length > 0)
                        this.PiePagina = new System.Drawing.Bitmap(ms1);



                }
            }



        
        }


        public void Guardar()
        {
            try
            {
                byte[] imgBytes = new byte[] {};
                byte[] imgBytes2 = new byte[] {};
                

                using (MemoryStream ms1 = new MemoryStream()) 
                using (MemoryStream ms = new MemoryStream())
                {
                    if (encabezado != null)
                    {
                        encabezado.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        imgBytes = ms.GetBuffer();
                        encabezado.Dispose();
                        ms.Close();
                    }

                    if (piePagina != null)
                    {
                        piePagina.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
                        imgBytes2 = ms1.GetBuffer();
                        piePagina.Dispose();
                        ms1.Close();
                    }

                    new DA.ParametrosReportesData().GuardarParametrosReporte(
                        imgBytes, imgBytes2);


                    
                }

            }
            catch (Exception ex)
            {

                //return false;
            }
        }




    }
}
