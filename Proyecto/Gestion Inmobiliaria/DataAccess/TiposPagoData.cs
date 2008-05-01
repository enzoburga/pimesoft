using System;
using System.Collections.Generic;
using System.Text;

namespace GI.DA
{
    public class TiposPagoData
    {
        public System.Data.IDataReader RecuperarTodos()
        { 
            return AccesoDatos.RecuperarDatos(
                "TiposPago_RecuperarTodos",
                new object[] {},
                new string[]{});
            
        }
    }
}
