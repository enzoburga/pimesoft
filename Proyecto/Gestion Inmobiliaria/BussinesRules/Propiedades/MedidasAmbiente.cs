using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class MedidasAmbiente : List<MedidaAmbiente>
    {
        public MedidasAmbiente()
        { }


        public void RecuperarPorPropiedad(Propiedad p)
        {
            Clear();
            MedidaAmbiente ambiente;
            using (System.Data.IDataReader dr = new DA.PropiedadesData().RecuperarMedidasAmbientesPorPropiedad(p.IdPropiedad))
            {
                while (dr.Read())
                {
                    ambiente = new MedidaAmbiente();
                    ambiente.IdMedidaAmbiente = dr.GetInt32(dr.GetOrdinal("IdAmbiente"));
                    ambiente.Ancho = dr.GetDecimal(dr.GetOrdinal("Ancho"));
                    ambiente.Largo = dr.GetDecimal(dr.GetOrdinal("Largo"));
                    ambiente.NombreAmbiente = dr.GetString(dr.GetOrdinal("Ambiente"));
                    ambiente.TipoDePiso = new TipoDePiso();
                    ambiente.TipoDePiso.IdTipoPiso = dr.GetInt32(dr.GetOrdinal("IdTipoPiso"));
                    ambiente.TipoDePiso.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));

                    ambiente.TipoAmbiente = new TipoAmbiente();
                    if (dr.IsDBNull(dr.GetOrdinal("idtipoambiente")))
                    {
                        ambiente.TipoAmbiente.Codigo = 0;
                        ambiente.TipoAmbiente.IdTipoAmbiente = 0;
                        ambiente.TipoDePiso.Nombre = "Otros";
                    }
                    else
                    {
                        ambiente.TipoAmbiente.Codigo = dr.GetInt32(dr.GetOrdinal("codigo")); ;
                        ambiente.TipoAmbiente.IdTipoAmbiente = dr.GetInt32(dr.GetOrdinal("idtipoambiente")); ;
                        ambiente.TipoAmbiente.Nombre = dr.GetString(dr.GetOrdinal("NombretipoAmbiente"));
                    }


                    Add(ambiente);
                }
            }
        }



    }
}
