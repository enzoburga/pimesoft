using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    [Serializable]
    public class TipoAmbiente
    {
        public TipoAmbiente()
        { }

        private int idTipoAmbiente;
        private string nombre;
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

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
