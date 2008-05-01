using System;
using System.Collections.Generic;
using System.Text;

namespace GI.DA
{
    public class PagosData
    {
        public System.Data.IDataReader RecuperarPorContrato(int IdContrato)
        {
            return AccesoDatos.RecuperarDatos(
                "Pagos_RecuperarPorContrato",
                new object[] {IdContrato },
                new string[] {"@IdContrato" });
        }
    }
}
