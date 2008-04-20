using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades.Ubicaciones
{
    public class Barrio
    {
        public Barrio()
        { 
        
        }

        private int idBarrio;

        public int IdBarrio
        {
            get { return idBarrio; }
            set { idBarrio = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private int idLocalidad;

        public int IdLocalidad
        {
            get { return idLocalidad; }
            set { idLocalidad = value; }
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


    public class Barrios : List<Barrio>
    {

        public void RecuperarTodos()
        {
            throw new Exception("Metodo no Implementado");
        }

        public void RecuperarTodos(Localidad Localidad)
        {
            Clear();

            Barrio b = new Barrio();
            b.EsDefault = true;
            b.IdBarrio = 1;
            b.IdLocalidad = Localidad.IdLocalidad;
            b.Nombre = "Vicente López";
            Add(b);

            b = new Barrio();
            b.EsDefault = true;
            b.IdBarrio = 1;
            b.IdLocalidad = Localidad.IdLocalidad;
            b.Nombre = "Olivos";
            Add(b);

            b = new Barrio();
            b.EsDefault = true;
            b.IdBarrio = 1;
            b.IdLocalidad = Localidad.IdLocalidad;
            b.Nombre = "Florida M";
            Add(b);

            b = new Barrio();
            b.EsDefault = true;
            b.IdBarrio = 1;
            b.IdLocalidad = Localidad.IdLocalidad;
            b.Nombre = "Florida B";
            Add(b);


        }
        
    }
}
