using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class MedidaAmbiente
    {

        public MedidaAmbiente()
        { 
        
        }

        private decimal ancho;
        private decimal largo;
        private string nombreAmbiente;
        private TipoDePiso tipoDePiso;

        public decimal Ancho
        {
            get { return ancho; }
            set { ancho = value; }
        }
        


        public decimal Largo
        {
            get { return largo; }
            set { largo = value; }
        }
        
        public string NombreAmbiente
        {
            get { return nombreAmbiente; }
            set { nombreAmbiente = value; }
        }
        

        public TipoDePiso TipoDePiso
        {
            get { return tipoDePiso; }
            set { tipoDePiso = value; }
        }



    }
}
