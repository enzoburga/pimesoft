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
        public string GetPathImagenChica(GI.BR.Propiedades.Galeria.Foto foto, int idPropiedad)
        {
            if (foto == null)
                return AppDomain.CurrentDomain.BaseDirectory + @"imagenes\imagen_nodisponible.jpg";

            if(!System.IO.Directory.Exists(AppDomain.CurrentDomain.BaseDirectory+@"imagenes\"))
                System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"imagenes\");

            string pathFoto = @"imagenes\" + idPropiedad.ToString() + "_" + foto.IdFoto.ToString() + "_Chica.jpg";


            if (!System.IO.File.Exists(pathFoto))
            {
                //Achico la imagen 450x450.
                GI.Managers.Propiedades.MngGaleriaFotos mngGaleria = new GI.Managers.Propiedades.MngGaleriaFotos();
                mngGaleria.ResizeFromStream(foto.Imagen, 220, 220).Save(AppDomain.CurrentDomain.BaseDirectory + pathFoto);
            }
            return pathFoto;

        }
    }
}
