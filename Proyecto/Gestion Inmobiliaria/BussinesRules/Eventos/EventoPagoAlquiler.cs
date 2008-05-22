using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Eventos
{
    public class EventoPagoAlquiler : Evento
    {
        public EventoPagoAlquiler()
        { }




        public override EnumTipoEvento TipoEvento
        {
            get { return EnumTipoEvento.PagoAlquiler; }
        }

        public override void CrearEvento()
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}
