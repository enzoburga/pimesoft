using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Eventos
{
    public abstract class Evento
    {

        public Evento()
        {
            
        }

        private int idEvento;
        private string descripcion;
        private DateTime fecha;
        private Nullable<DateTime> vencimiento;

        public abstract EnumTipoEvento TipoEvento
        {
            get;
        }

        public Nullable<DateTime> Vencimiento
        {
            get { return vencimiento; }
            set { vencimiento = value; }
        }


        public int IdEvento
        {
            get { return idEvento; }
            set { idEvento = value; }
        }
        
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public abstract void CrearEvento();

        public void Silenciar()
        { }




    }
}
