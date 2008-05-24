using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Eventos
{
    public class FactoryEventos
    {


        public Evento GetEvento(EnumTipoEvento Tipo)
        {
            Evento e;

            switch (Tipo)
            {
                case EnumTipoEvento.Visita: e = new EventoVisita(); break;
                default: throw new Exception("Tipo de Evento no definido");
            }


            return e;
        
        
        }


    }
}
