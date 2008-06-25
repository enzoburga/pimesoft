using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades.Tranasacciones
{
    public class TransaccionFotoPropiedad: Transaccion
    {
        public TransaccionFotoPropiedad()
            : base()
        { 
        
        }

        private int idPropiedad;
        private int idFoto;
        private GI.BR.Propiedades.Galeria.Foto foto;

        public GI.BR.Propiedades.Galeria.Foto Foto
        {
            get
            {
                if (foto == null && idFoto > 0)
                {
                    foto = new GI.BR.Propiedades.Galeria.Foto();
                    foto.RecuperarPorId(idFoto);
                }

                return foto; 
            }
            set { foto = value; }
        }

        public int IdFoto
        {
            get { return idFoto; }
            set { idFoto = value; }
        }

        public int IdPropiedad
        {
            get { return idPropiedad; }
            set { idPropiedad = value; }
        }




        public override bool Crear()
        {
            IdTransaccion = new DA.TransaccionesData().CrearTransaccionFoto(IdPropiedad, (int)TipoTransaccion, Fecha, IdFoto);

            return IdTransaccion > 0;
        }




    }
}
