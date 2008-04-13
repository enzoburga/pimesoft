using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class CategoriaPropiedad
    {

        public CategoriaPropiedad() { }


        private int idCategoria;
        private string nombre;
        private TiposPropiedad tiposPropiedad;

        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }
        

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        

        public TiposPropiedad TiposPropiedad
        {
            get { return tiposPropiedad; }
            set { tiposPropiedad = value; }
        }


        public override string ToString()
        {
            return Nombre;
        }
     


    }
}
