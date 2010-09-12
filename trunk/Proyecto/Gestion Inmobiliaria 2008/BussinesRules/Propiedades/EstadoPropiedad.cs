using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    [Serializable]
    public class EstadoPropiedad
    {
        public EstadoPropiedad()
        { 
        
        }


        private string descripcion;
        private int idEstadoPropiedad;

        public int IdEstadoPropiedad
        {
            get { return idEstadoPropiedad; }
            set { idEstadoPropiedad = value; }
        }
        

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }


        public override string ToString()
        {
            return Descripcion.ToString();
        }
        


    }
}
