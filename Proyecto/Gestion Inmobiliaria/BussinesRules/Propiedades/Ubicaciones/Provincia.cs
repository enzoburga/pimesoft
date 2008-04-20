using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades.Ubicaciones
{
    public class Provincia
    {

        public Provincia() { }

        private int idProvincia;
        private string nombre;
        private int idPais;
        private bool esDefault;

        public int IdProvincia
        {
            get { return idProvincia; }
            set { idProvincia = value; }
        }
       

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        

        public int IdPais
        {
            get { return idPais; }
            set { idPais = value; }
        }
        
        

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


    public class Provincias : List<Provincia>
    {
        public void RecuperarTodas(Pais Pais)
        {
            Clear();

            Provincia p = new Provincia();
            p.EsDefault = true;
            p.IdPais = p.IdPais;
            p.IdProvincia = 1;
            p.Nombre = "Gran Buenos Aires";
            Add(p);

            p = new Provincia();
            p.EsDefault = false;
            p.IdPais = p.IdPais;
            p.IdProvincia = 1;
            p.Nombre = "Capital Federal";
            Add(p);

            p = new Provincia();
            p.EsDefault = false;
            p.IdPais = p.IdPais;
            p.IdProvincia = 1;
            p.Nombre = "Córdoba";
            Add(p);

        }
    
    
    }
}
