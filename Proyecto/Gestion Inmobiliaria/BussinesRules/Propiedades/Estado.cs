using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class Estado
    {

        private int idEstado;

        public int IdEstado
        {
            get { return idEstado; }
            set { idEstado = value; }
        }
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public override string ToString()
        {
            return Descripcion.ToString();
        }



    }



    public class Estados : List<Estado>
    {
        public void RecuperarTodos()
        {
            Estado e;

            e = new Estado();
            e.IdEstado = 1;
            e.Descripcion = "A Estrenar";
            Add(e);


            e = new Estado();
            e.IdEstado = 1;
            e.Descripcion = "Reciclado";
            Add(e);

            e = new Estado();
            e.IdEstado = 1;
            e.Descripcion = "Bueno";
            Add(e);

            e = new Estado();
            e.IdEstado = 1;
            e.Descripcion = "Regular";
            Add(e);


            e = new Estado();
            e.IdEstado = 1;
            e.Descripcion = "Malo";
            Add(e);

            e = new Estado();
            e.IdEstado = 1;
            e.Descripcion = "A reciclar";
            Add(e);

            e = new Estado();
            e.IdEstado = 1;
            e.Descripcion = "No Especifica";
            Add(e);
        
        }
    
    
    }
}
