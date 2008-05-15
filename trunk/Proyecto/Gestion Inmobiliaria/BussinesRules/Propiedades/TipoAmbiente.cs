using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class TipoAmbiente
    {
        public TipoAmbiente()
        { }

        private int idTipoAmbiente;
        private string nombre;

        public int IdTipoAmbiente
        {
            get { return idTipoAmbiente; }
            set { idTipoAmbiente = value; }
        }
        

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public override string ToString()
        {
            return Nombre;
        }
 



    }
}
