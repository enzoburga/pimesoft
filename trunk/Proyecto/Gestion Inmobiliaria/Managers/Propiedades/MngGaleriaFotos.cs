using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace GI.Managers.Propiedades
{
    public class MngGaleriaFotos
    {

        private int MaxSizeHor = 450;
        private int MaxSizeVer = 450;



        public bool EliminarFotoGaleria(GI.BR.Propiedades.Galeria.Foto Foto, GI.BR.Propiedades.Propiedad p)
        { 
        

            // Creamos la transaccion para eliminar la foto.
            // eliminamos la foto

            if (!p.EsOtraInmobiliaria)
            {
                GI.BR.Propiedades.Tranasacciones.TransaccionFotoPropiedad trans = new GI.BR.Propiedades.Tranasacciones.TransaccionFotoPropiedad();
                trans.Activa = true;
                trans.Estado = GI.BR.Propiedades.Tranasacciones.EnumEstadoTrans.Pendiente;
                trans.Fecha = DateTime.Now;
                trans.Foto = Foto;
                trans.IdFoto = Foto.IdFoto;
                trans.IdPropiedad = p.IdPropiedad;
                trans.TipoTransaccion = GI.BR.Propiedades.Tranasacciones.EnumTipoTransaccion.Eliminar;
                trans.Crear();
            }

            return Foto.Eliminar();

        }



        public GI.BR.Propiedades.Galeria.Foto AgregarFotoAGaleria(Bitmap Original, string Nombre, bool EsFachada, GI.BR.Propiedades.Propiedad p)
        {

            // Creamos la foto y generamos la transaccion correspondiente

            try
            {
                GI.BR.Propiedades.Galeria.Foto Foto = new GI.BR.Propiedades.Galeria.Foto();
                Foto.Descripcion = Nombre;
                Foto.EsFachada = EsFachada;
                Foto.Imagen = ResizeFromStream(Original);
                

                if (EsFachada)
                {
                    foreach (GI.BR.Propiedades.Galeria.Foto f in p.GaleriaFotos)
                    {
                        if (f.EsFachada)
                        {
                            EliminarFotoGaleria(f, p);
                            break;
                        }
                    }
                }

                if (!Foto.Guardar(p))
                    throw new Exception();


                if (!p.EsOtraInmobiliaria)
                {
                    GI.BR.Propiedades.Tranasacciones.TransaccionFotoPropiedad trans = new GI.BR.Propiedades.Tranasacciones.TransaccionFotoPropiedad();
                    trans.Activa = true;
                    trans.Estado = GI.BR.Propiedades.Tranasacciones.EnumEstadoTrans.Pendiente;
                    trans.Fecha = DateTime.Now;
                    trans.Foto = Foto;
                    trans.IdFoto = Foto.IdFoto;
                    trans.IdPropiedad = p.IdPropiedad;
                    trans.TipoTransaccion = GI.BR.Propiedades.Tranasacciones.EnumTipoTransaccion.Crear;
                    trans.Crear();
                }

                return Foto;
            }
            catch 
            {
                return null;
            }
        
        
        
        }



        protected Bitmap ResizeFromStream(Bitmap Foto)
        {
            return this.ResizeFromStream(Foto, this.MaxSizeHor, this.MaxSizeVer);
            
        }








        public Bitmap ResizeFromStream(Bitmap Foto, int MaxHorizontal, int MaxVertical)
        {
            int MaxSideSize = 0;
            int intNewWidth = 0;
            int intNewHeight = 0;
            Image imgInput = (Image)Foto;

            //Determine image format
            ImageFormat fmtImageFormat = imgInput.RawFormat;

            //get image original width and height
            int intOldWidth = imgInput.Width;
            int intOldHeight = imgInput.Height;

            //determine if landscape or portrait
            int intMaxSide;

            if (intOldWidth >= intOldHeight)
            {
                intMaxSide = intOldWidth;
                MaxSideSize = MaxHorizontal;
            }
            else
            {
                intMaxSide = intOldHeight;
                MaxSideSize = MaxVertical;
            }


            if (intMaxSide > MaxSideSize)
            {
                //set new width and height
                double dblCoef = MaxSideSize / (double)intMaxSide;
                intNewWidth = Convert.ToInt32(dblCoef * intOldWidth);
                intNewHeight = Convert.ToInt32(dblCoef * intOldHeight);
            }
            else
            {
                intNewWidth = intOldWidth;
                intNewHeight = intOldHeight;
            }
            //create new bitmap
            Bitmap bmpResized = new Bitmap(imgInput, new Size(intNewWidth, intNewHeight));


            return bmpResized;
        }
    }
}
