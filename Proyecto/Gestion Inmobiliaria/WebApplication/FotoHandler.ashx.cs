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
        else
        {
            { idPropiedad = 30; }
        }
        if (context.Request["IdFoto"] != null)
            idFoto = Int32.Parse(context.Request["IdFoto"]);
        else
        {
            { idFoto = 30; }
        }
        if (context.Request["width"] != null)
            _width = Int32.Parse(context.Request["width"]);
        else
        {
            { _width = 30; }
        }
        if (context.Request["height"] != null)
            _height = Int32.Parse(context.Request["height"]);
        else
        {
            { _height = 30; }
        }
        // get path for 'no thumbnail' image if you want one
        string sNoThumbPath = "imagenes/imagen_nodisponible.jpg";

        // map requested path

        _path = sNoThumbPath;

        //Recupero la propiedad.
        GI.BR.Propiedades.PropiedadFactory pf = new GI.BR.Propiedades.PropiedadFactory();
        GI.BR.Propiedades.Propiedad propiedad = pf.GetPropiedad(idPropiedad);

        Bitmap thumbBitmap = null;

        //Recupero la foto solicitada.
        foreach(GI.BR.Propiedades.Galeria.Foto f in propiedad.GaleriaFotos)
        {
            if (f.IdFoto == idFoto)
            {
                thumbBitmap = f.Imagen;
                break;
            }
        }
        
        if (thumbBitmap == null)
        {
            thumbBitmap = new Bitmap(sNoThumbPath);
        }

        if (context.Request["thumb"] != null && context.Request["thumb"] == "no")
        {
            thumbBitmap.Save(context.Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
        else
        {

            thumbBitmap = (Bitmap)thumbBitmap.GetThumbnailImage(_width, _height,
                     new System.Drawing.Image.GetThumbnailImageAbort(ThumbCallback), IntPtr.Zero);
            context.Response.ContentType = "image/Jpeg";
            thumbBitmap.Save(context.Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }

  public bool ThumbCallback() { return false; }   
    
    public bool IsReusable
    {
        get { return true; }
    }
}
