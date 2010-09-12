using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Eventos
{
    public class EventoSincronizacion : Evento
    {


        public override EnumTipoEvento TipoEvento
        {
            get { return EnumTipoEvento.Sincronización; }
        }

        public override void CrearEvento()
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}
