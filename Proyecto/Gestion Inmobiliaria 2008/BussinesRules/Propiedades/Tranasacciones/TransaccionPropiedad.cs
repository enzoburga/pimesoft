using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades.Tranasacciones
{
    public class TransaccionPropiedad : Transaccion
    {
        public TransaccionPropiedad()
            : base()
        { 
        
        }


        private int idPropiedad;
        private Propiedad propiedad;
        private string typePropopiedad;

        public string TypePropopiedad
        {
            get { return typePropopiedad; }
            set { typePropopiedad = value; }
        }

        public Propiedad Propiedad
        {
            get 
            {
                if (propiedad == null && idPropiedad > 0)
                {
                    if (typePropopiedad == "GI.BR.Propiedades.Venta")
                    {
                        propiedad = new Venta();
                        propiedad.IdPropiedad = idPropiedad;
                        propiedad.RecuperarPorId(idPropiedad);
                    }
                    else if (typePropopiedad == "GI.BR.Propiedades.Alquiler")
                    {
                        propiedad = new Alquiler();
                        propiedad.IdPropiedad = idPropiedad;
                        propiedad.RecuperarPorId(idPropiedad);                    
                    }
                }

                return propiedad; 
            }
            set { propiedad = value; }
        }

        public int IdPropiedad
        {
            get { return idPropiedad; }
            set { idPropiedad = value; }
        }


        public static TransaccionPropiedad RecuperarActiva(Propiedad p)
        {
            TransaccionPropiedad trans = null;

            using (System.Data.IDataReader dr = new DA.TransaccionesData().RecuperarTransaccionPropiedadActiva(p.IdPropiedad))
            {
                if (dr.Read())
                {
                    trans = new TransaccionPropiedad();
                    trans.Activa = true;
                    trans.Fecha = dr.GetDateTime(dr.GetOrdinal("Fecha"));
                    trans.IdPropiedad = p.IdPropiedad;
                    trans.IdTransaccion = dr.GetInt32(dr.GetOrdinal("IdTransaccion"));
                    trans.Propiedad = p;
                    trans.TipoTransaccion = (EnumTipoTransaccion)dr.GetInt32(dr.GetOrdinal("TipoTransaccion"));
                    trans.TypePropopiedad = dr.GetString(dr.GetOrdinal("TypePropopiedad"));
                }
            }


            return trans;
            
        }

        public override bool Crear()
        {
            IdTransaccion = new DA.TransaccionesData().CrearTransaccionPropiedad(IdPropiedad, (int)TipoTransaccion, Fecha, TypePropopiedad);

            return IdTransaccion > 0;
        }
    }
}
