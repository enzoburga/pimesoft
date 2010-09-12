using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Eventos
{
    public class EventoVisita : Evento
    {
        public EventoVisita()
        { }

        private int idVisita;
        private GI.BR.Propiedades.VisitaPropiedad visita;


        public int IdVisita
        {
            get { return idVisita; }
            set { idVisita = value; }
        }
        
        public GI.BR.Propiedades.VisitaPropiedad Visita
        {
            get { return visita; }
            set { visita = value; }
        }



        public override EnumTipoEvento TipoEvento
        {
            get { return EnumTipoEvento.Visita; }
        }

        public override void CrearEvento()
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}
