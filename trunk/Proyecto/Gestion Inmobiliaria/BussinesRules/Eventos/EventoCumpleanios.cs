using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Eventos
{
    public class EventoCumpleanios : Evento
    {





        public override EnumTipoEvento TipoEvento
        {
            get { return EnumTipoEvento.Cumpleaños; }
        }

        public override void CrearEvento()
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}
