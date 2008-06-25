using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    
    [Serializable]
    public class TipoPropiedad
    {
        public TipoPropiedad() { }

        private int idTipoPropiedad;
        private string descripcion;
        private int idCategoria;

        public int IdTipoPropiedad
        {
            get { return idTipoPropiedad; }
            set { idTipoPropiedad = value; }
        }
        

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        

        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }


        public override string ToString()
        {
            return Descripcion;
        }




    }
}
