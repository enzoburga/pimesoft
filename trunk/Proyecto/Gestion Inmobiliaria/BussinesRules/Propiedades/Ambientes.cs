using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class Ambiente
    {

        public Ambiente()
        { 
            
        }

        private decimal cantidadAmbientes;

        public decimal CantidadAmbientes
        {
            get { return cantidadAmbientes; }
            set { cantidadAmbientes = value; }
        }

        public override string ToString()
        {
            if (cantidadAmbientes == Convert.ToDecimal( 1.5))
                return "1 1/2";
            if (cantidadAmbientes == Convert.ToDecimal( 2.5))
                return "2 1/2";
            if (cantidadAmbientes == Convert.ToDecimal( 3.5))
                return "3 1/2";
            if (cantidadAmbientes == Convert.ToDecimal(4.5))
                return "4 1/2";

            return cantidadAmbientes.ToString("##");

        }

    }


    public class Ambientes : List<Ambiente>
    {
        public void RecuperarTodos()
        {
            Ambiente amb;

            amb = new Ambiente();
            amb.CantidadAmbientes = 1;
            Add(amb);

            amb = new Ambiente();
            amb.CantidadAmbientes = Convert.ToDecimal( 1.5);
            Add(amb);

            amb = new Ambiente();
            amb.CantidadAmbientes = 2;
            Add(amb);

            amb = new Ambiente();
            amb.CantidadAmbientes = Convert.ToDecimal( 2.5);
            Add(amb);

            amb = new Ambiente();
            amb.CantidadAmbientes = 3;
            Add(amb);

            amb = new Ambiente();
            amb.CantidadAmbientes = Convert.ToDecimal( 3.5);
            Add(amb);

            amb = new Ambiente();
            amb.CantidadAmbientes = 4;
            Add(amb);

            amb = new Ambiente();
            amb.CantidadAmbientes = Convert.ToDecimal( 4.5);
            Add(amb);

            amb = new Ambiente();
            amb.CantidadAmbientes = 5;
            Add(amb);

            amb = new Ambiente();
            amb.CantidadAmbientes = 6;
            Add(amb);

            amb = new Ambiente();
            amb.CantidadAmbientes = 7;
            Add(amb);

            amb = new Ambiente();
            amb.CantidadAmbientes = 8;
            Add(amb);

            amb = new Ambiente();
            amb.CantidadAmbientes = 9;
            Add(amb);

            amb = new Ambiente();
            amb.CantidadAmbientes = 10;
            Add(amb);

            amb = new Ambiente();
            amb.CantidadAmbientes = 11;
            Add(amb);

            amb = new Ambiente();
            amb.CantidadAmbientes = 12;
            Add(amb);

            amb = new Ambiente();
            amb.CantidadAmbientes = 13;
            Add(amb);

            amb = new Ambiente();
            amb.CantidadAmbientes = 14;
            Add(amb);

            amb = new Ambiente();
            amb.CantidadAmbientes = 15;
            Add(amb);






            
        }
    
    
    }
}
