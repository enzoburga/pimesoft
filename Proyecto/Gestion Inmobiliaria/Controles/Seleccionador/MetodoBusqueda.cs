using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Framework.Seleccionador
{
    public class MetodoBusqueda
    {
        public MetodoBusqueda()
        { }

        private string nombreBusqueda;
        private EnumTipoBusqueda tipoBusqueda;
        private object[] valoresPosibles;
        private object valorSeleccionado;

        public string NombreBusqueda
        {
            get { return nombreBusqueda; }
            set { nombreBusqueda = value; }
        }
        

        public EnumTipoBusqueda TipoBusqueda
        {
            get { return tipoBusqueda; }
            set { tipoBusqueda = value; }
        }
        

        public object[] ValoresPosibles
        {
            get { return valoresPosibles; }
            set { valoresPosibles = value; }
        }
        

        public object ValorSeleccionado
        {
            get { return valorSeleccionado; }
            set { valorSeleccionado = value; }
        }

        public override string ToString()
        {
            return nombreBusqueda;
        }


    }



}
