using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class Nota
    {
        public Nota()
        { 
        
        }


        private int idNota;
        private string comentario;
        private DateTime fecha;

        public int IdNota
        {
            get { return idNota; }
            set { idNota = value; }
        }
       

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        

        public string Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }


        public bool Guardar(Propiedad Propiedad)
        {
            return false;
        }

        public bool Actualizar()
        {
            return false;
        }

        public bool Eliminar()
        {
            return false;
        }

    }
}
