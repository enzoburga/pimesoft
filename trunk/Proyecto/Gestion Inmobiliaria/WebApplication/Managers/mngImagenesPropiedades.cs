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
            if (foto == null)
                return @"ThumbnailHandler.ashx?ImgFilePath)=imagenes\imagen_nodisponible.jpg&width=220&height=220";

            return @"FotoHandler.ashx?IdFoto=" + foto.IdFoto.ToString() + "&IdPropiedad=" + idPropiedad.ToString() + "&width=220&height=220";
        }

        public string GetPathImagen(GI.BR.Propiedades.Galeria.Foto foto, int idPropiedad)
        {

            if (foto == null)
                return @"ThumbnailHandler.ashx?ImgFilePath)=imagenes\imagen_nodisponible.jpg&width=450&height=450";

            return @"FotoHandler.ashx?IdFoto=" + foto.IdFoto.ToString() + "&IdPropiedad=" + idPropiedad.ToString() + "&width=450&height=450";

        }
    }
}
