using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR
{
    public class Inmobiliaria
    {
        public Inmobiliaria()
        { }

        private int idInmobiliaria;
        private string descripcion;
        private string personaResponsable;
        private string nombre;
        private Propiedades.Direccion direccion;
        private string telefono;
        private string fax;

        public int IdInmobiliaria
        {
            get { return idInmobiliaria; }
            set { idInmobiliaria = value; }
        }
       

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        

        public string PersonaResponsable
        {
            get { return personaResponsable; }
            set { personaResponsable = value; }
        }
        

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        

        public Propiedades.Direccion Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        

        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }



        public static Inmobiliaria GetInmobiliaria()
        {
            Inmobiliaria i = new Inmobiliaria();
            i.nombre = "PIME Negocios Inmobiliarios";

            return i;
        }






    }
}
