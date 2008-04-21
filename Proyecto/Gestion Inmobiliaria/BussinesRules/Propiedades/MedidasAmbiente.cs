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
                    ambiente.Ancho = dr.GetDecimal(dr.GetOrdinal("Ancho"));
                    ambiente.Largo = dr.GetDecimal(dr.GetOrdinal("Largo"));
                    ambiente.NombreAmbiente = dr.GetString(dr.GetOrdinal("Ambiente"));
                    ambiente.TipoDePiso = new TipoDePiso();
                    ambiente.TipoDePiso.IdTipoPiso = dr.GetInt32(dr.GetOrdinal("IdTipoPiso"));
                    ambiente.TipoDePiso.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                    Add(ambiente);
                }
            }
        }



    }
}
