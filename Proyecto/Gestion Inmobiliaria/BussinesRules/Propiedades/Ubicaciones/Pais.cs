using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades.Ubicaciones
{
    public class Pais
    {
        public Pais()
        { }

        private int idPais;

        public int IdPais
        {
            get { return idPais; }
            set { idPais = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
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

    public class Paises : List<Pais>
    {

        public void RecuperarTodos()
        {
            Pais p = new Pais();
            p.EsDefault = true;
            p.IdPais = 1;
            p.Nombre = "Argentina";
            Add(p);
        }


    }
}
