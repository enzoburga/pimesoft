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
            return false;
        }

        [WebMethod]
        public int IngresarPropiedad(GI.BR.Propiedades.Propiedad Propiedad)
        {
        }

    }
}
