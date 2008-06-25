using System;
using System.Data;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace WebApplication
{
    /// <summary>
    /// Summary description for PropiedadesServicioSinc
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class PropiedadesServicioSinc : System.Web.Services.WebService
    {



        [WebMethod]
        public bool ActualizarPropiedad(GI.BR.Propiedades.Propiedad Propiedad)
        {
            return new GI.Managers.Propiedades.MngPropiedadesWeb().ActualizarPropiedad(Propiedad);
        }

        [WebMethod]
        public bool IngresarPropiedad(GI.BR.Propiedades.Propiedad Propiedad)
        {

            return new GI.Managers.Propiedades.MngPropiedadesWeb().GuardarPropiedad(Propiedad);

        }

        [WebMethod]
        public bool AgregarFotoAGaleria(GI.BR.Propiedades.Galeria.Foto Foto, int IdPropiedad)
        {
            GI.BR.Propiedades.Propiedad p = new GI.BR.Propiedades.Venta();
            p.IdPropiedad = IdPropiedad;

            System.IO.MemoryStream ms = new System.IO.MemoryStream(Foto.FotoByteArray);
            Foto.Imagen = new System.Drawing.Bitmap(ms);

            return new GI.Managers.Propiedades.MngPropiedadesWeb().AgregarFotoAGaleria(Foto, p);

        }

        [WebMethod]
        public bool EliminarFotoPropiedad(int IdFoto)
        {



            new GI.Managers.Propiedades.MngPropiedadesWeb().EliminarFotoGaleria(IdFoto);
            return true;
        
        }

    }
}
