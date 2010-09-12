using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class TiposAmbiente : List<TipoAmbiente>
    {

        public void RecuperarTodos()
        {
            Clear();

            TipoAmbiente ambiente;
            using (System.Data.IDataReader dr = new DA.PropiedadesData().RecuperarTiposDeAmbiente())
            {
                while (dr.Read())
                {
                    ambiente = new TipoAmbiente();

                    ambiente.Codigo=dr.GetInt32(dr.GetOrdinal("Codigo"));
                    ambiente.IdTipoAmbiente=dr.GetInt32(dr.GetOrdinal("Idtipoambiente"));
                    ambiente.Nombre=dr.GetString(dr.GetOrdinal("Nombre"));


                    Add(ambiente);
                }
            }
        
        }


    }
}
