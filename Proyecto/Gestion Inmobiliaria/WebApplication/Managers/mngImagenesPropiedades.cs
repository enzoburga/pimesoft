using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace WebApplication.Managers
{
    public class mngImagenesPropiedades
    {
        public string GetPathThumbnail(GI.BR.Propiedades.Galeria.Foto foto, int idPropiedad)
        {
            return @"ThumbnailHandler.ashx?ImgFilePath=" + GetPathImagen(foto,idPropiedad) + "&width=220&height=220";
        }

        public string GetPathImagen(GI.BR.Propiedades.Galeria.Foto foto, int idPropiedad)
        {
            if (foto == null)
                return @"imagenes\imagen_nodisponible.jpg";

            if (!System.IO.Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"imagenes\"))
                System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"imagenes\");

            string pathFoto = @"imagenes\" + idPropiedad.ToString() + "_" + foto.IdFoto.ToString() + ".jpg";


            if (!System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory + pathFoto))
            {
                //Achico la imagen 450x450.
                GI.Managers.Propiedades.MngGaleriaFotos mngGaleria = new GI.Managers.Propiedades.MngGaleriaFotos();

                foto.Imagen.Save(AppDomain.CurrentDomain.BaseDirectory + pathFoto);
            }            

            return pathFoto;

        }
    }
}
