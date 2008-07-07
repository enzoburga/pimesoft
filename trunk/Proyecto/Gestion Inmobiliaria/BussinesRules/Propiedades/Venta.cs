using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    [Serializable]
    public class Venta : Propiedad
    {



        public override bool Guardar()
        {

            if (!base.Guardar())
                return false;

            return new DA.PropiedadesData().InsertarPropiedadesEnVenta(base.IdPropiedad);



        }

        public override void RecuperarPorId(int IdPropiedad)
        {
            GI.DA.PropiedadesData data = new GI.DA.PropiedadesData();
            using (System.Data.IDataReader dr = data.RecuperarVentaPorId(IdPropiedad))
            {
                if (dr.Read())
                    CargarPropiedad(dr);
            }
            this.cargado = true;

        }

        public override EstadoPropiedad Estado
        {
            get
            {
                return EstadoPropiedadFlyweigthFactory.GetInstancia(typeof(Venta)).GetEstado(base.Estado.IdEstadoPropiedad);
            }
            set
            {
                base.Estado = value;
            }
        }
        
    }
}
