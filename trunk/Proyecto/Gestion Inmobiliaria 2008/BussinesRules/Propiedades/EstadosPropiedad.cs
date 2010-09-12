using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace GI.BR.Propiedades
{
    public class EstadosPropiedad : List<EstadoPropiedad>
    {

        public void RecuperarEstados(Type Tipo)
        {
            Clear();
            EstadoPropiedad estado;
            using (IDataReader dr = new GI.DA.PropiedadesData().RecuperarEstadoPropiedad(Tipo.ToString()))
            {
                while (dr.Read())
                {
                    estado = new EstadoPropiedad();
                    estado.Descripcion = dr.GetString(dr.GetOrdinal("Nombre"));
                    estado.IdEstadoPropiedad = dr.GetInt32(dr.GetOrdinal("IdEstadoPropiedad"));
                    Add(estado);
                
                }
            }


        }


    }
}
