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

        public int IdInmobiliaria
        {
            get { return idInmobiliaria; }
            set { idInmobiliaria = value; }
        }
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private string personaResponsable;

        public string PersonaResponsable
        {
            get { return personaResponsable; }
            set { personaResponsable = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private Propiedades.Direccion direccion;

        public Propiedades.Direccion Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        private string fax;

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
