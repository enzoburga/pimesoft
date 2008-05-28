using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR
{
    public class InmobiliariasExternas : List<InmobiliariaExterna>
    {



        public void RecuperarTodas()
        {
            Clear();
            InmobiliariaExterna i;
            using (System.Data.IDataReader dr = new DA.InmobiliariasData().RecuperarTodas())
            {
                while (dr.Read())
                {
                    i = new InmobiliariaExterna();
                    i.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                    i.PersonaResponsable = dr.GetString(dr.GetOrdinal("Contacto"));
                    i.Telefono = dr.GetString(dr.GetOrdinal("Telefono"));
                    i.IdInmobiliaria = dr.GetInt32(dr.GetOrdinal("IdInmobiliaria"));

                    Add(i);
                }
            
            }


        }

    }
}
