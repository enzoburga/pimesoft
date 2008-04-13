using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades.Ubicaciones
{
    public class Localidad
    {
        public Localidad()
        { }

        private int idLocalidad;

        public int IdLocalidad
        {
            get { return idLocalidad; }
            set { idLocalidad = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private int idProvincia;

        public int IdProvincia
        {
            get { return idProvincia; }
            set { idProvincia = value; }
        }

        private bool esDefault;

        public bool EsDefault
        {
            get { return esDefault; }
            set { esDefault = value; }
        }


        public override string ToString()
        {
            return Nombre.ToString();
        }
    }

    public class Localidades : List<Localidad>
    {

        public void RecuperarTodas(Provincia Provincia)
        {
            Clear();

            Localidad l = new Localidad();
            l.EsDefault = true;
            l.IdLocalidad = 1;
            l.IdProvincia = Provincia.IdProvincia;
            l.Nombre = "Vicente López";
            Add(l);

            l = new Localidad();
            l.EsDefault = true;
            l.IdLocalidad = 1;
            l.IdProvincia = Provincia.IdProvincia;
            l.Nombre = "San Isidro";
            Add(l);

            l = new Localidad();
            l.EsDefault = true;
            l.IdLocalidad = 1;
            l.IdProvincia = Provincia.IdProvincia;
            l.Nombre = "Tigre";
            Add(l);




        }
    
    }


}
