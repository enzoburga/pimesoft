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
        public string GetPathThumbnailListado(GI.BR.Propiedades.Galeria.Foto foto, int idPropiedad)
        {
            if (foto == null)
                return @"FotoHandler.ashx?&width=220&height=220";

            return @"FotoHandler.ashx?IdFoto=" + foto.IdFoto.ToString() + "&IdPropiedad=" + idPropiedad.ToString() + "&width=220&height=220";
        }

        public string GetPathThumbnailFicha(GI.BR.Propiedades.Galeria.Foto foto, int idPropiedad)
        {
            if (foto == null)
                return @"FotoHandler.ashx?&width=110&height=110";

            return @"FotoHandler.ashx?IdFoto=" + foto.IdFoto.ToString() + "&IdPropiedad=" + idPropiedad.ToString() + "&width=110&height=110";
        }

        public string GetPathImagen(GI.BR.Propiedades.Galeria.Foto foto, int idPropiedad)
        {

            if (foto == null)
                return @"FotoHandler.ashx?&width=350&height=350";

            return @"FotoHandler.ashx?IdFoto=" + foto.IdFoto.ToString() + "&IdPropiedad=" + idPropiedad.ToString() + "&width=350&height=350";

        }
    }
}
