using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class TipoDePiso
    {

        public TipoDePiso()
        { 
        
        }

        private int idTipoPiso;
        private string nombre;


        

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int IdTipoPiso
        {
            get { return idTipoPiso; }
            set { idTipoPiso = value; }
        }


        public override string ToString()
        {
            return Nombre;
        }



    }
}
