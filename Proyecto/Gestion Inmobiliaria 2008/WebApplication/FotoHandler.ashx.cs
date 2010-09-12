using System;
using System.IO;
using System.Web;
using System.Drawing;
using System.Drawing.Imaging;
using System.Configuration;
public class FotoHandler : IHttpHandler
{
    public void ProcessRequest(HttpContext context)
    {
        int _width = 0;
        int _height = 0;
        int idPropiedad = 0;
        int idFoto = 0;
        string _path = String.Empty;

        if (context.Request["IdPropiedad"] != null)
            idPropiedad = Int32.Parse(context.Request["IdPropiedad"]);

        if (context.Request["IdFoto"] != null)
            idFoto = Int32.Parse(context.Request["IdFoto"]);

        if (context.Request["width"] != null)
            _width = Int32.Parse(context.Request["width"]);

        if (context.Request["height"] != null)
            _height = Int32.Parse(context.Request["height"]);

        // get path for 'no thumbnail' image if you want one


        string sNoThumbPath = AppDomain.CurrentDomain.BaseDirectory+"imagenes/imagen_nodisponible.jpg";

        // map requested path

        _path = sNoThumbPath;

        Bitmap thumbBitmap = null;

        //Recupero la propiedad.
        if (idPropiedad != 0 && idFoto != 0)
        {
            GI.BR.Propiedades.PropiedadFactory pf = new GI.BR.Propiedades.PropiedadFactory();
            GI.BR.Propiedades.Propiedad propiedad = pf.GetPropiedad(idPropiedad);

            

            //Recupero la foto solicitada.
            foreach (GI.BR.Propiedades.Galeria.Foto f in propiedad.GaleriaFotos)
            {
                if (f.IdFoto == idFoto)
                {
                    thumbBitmap = f.Imagen;
                    break;
                }
            }
        }

        if (thumbBitmap == null)
        {
            thumbBitmap = new Bitmap(sNoThumbPath);
        }


        GI.Managers.Propiedades.MngGaleriaFotos mngGaleria = new GI.Managers.Propiedades.MngGaleriaFotos();

        thumbBitmap = mngGaleria.ResizeFromStream(thumbBitmap, _width, _height);
        context.Response.ContentType = "image/Jpeg";
        thumbBitmap.Save(context.Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg);

    }


    public bool IsReusable
    {
        get { return true; }
    }
}
