using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class TiposDePiso : List<TipoDePiso>
    {



        public void RecuperarTodos()
        {
            Clear();
            TipoDePiso piso;
            using (System.Data.IDataReader dr = new DA.PropiedadesData().RecuperarTiposDePiso())
            {
                while (dr.Read())
                {
                    piso = new TipoDePiso();
                    piso.IdTipoPiso = dr.GetInt32(dr.GetOrdinal("IdTipoPiso"));
                    piso.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                    Add(piso);
                }
            }
        
        }
    }
}
