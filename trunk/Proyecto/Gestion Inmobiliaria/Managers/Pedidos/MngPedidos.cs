using System;
using System.Collections.Generic;
using System.Text;
using GI.BR.Propiedades;

namespace GI.Managers.Pedidos
{
    public class MngPedidos
    {

        #region Metodos Publicos

        public GI.BR.Propiedades.Propiedades GetPropiedadesOfrecidas(GI.BR.Pedidos.Pedido pedido)
        {
            return new GI.BR.Propiedades.Propiedades();
        }

        public GI.BR.Propiedades.Propiedades GetPropiedadesSinOfrecer(GI.BR.Pedidos.Pedido pedido)
        {
            return new GI.BR.Propiedades.Propiedades();
        }

        #endregion
    }
}
