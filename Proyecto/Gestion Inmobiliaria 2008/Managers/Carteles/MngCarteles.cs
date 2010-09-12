using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Managers.Carteles
{
    public class MngCarteles
    {
        public GI.BR.Carteles.Carteles RecuperarCarteles(bool IncluirHistoricos)
        {
            GI.BR.Carteles.Carteles carteles = new GI.BR.Carteles.Carteles();
            carteles.RecuperarCartelesTodos();
            return AplicarFiltros(carteles, IncluirHistoricos);
        }

        private GI.BR.Carteles.Carteles AplicarFiltros(GI.BR.Carteles.Carteles carteles, bool IncluirHistoricos)
        {
            GI.BR.Carteles.Carteles filtro = new GI.BR.Carteles.Carteles();
            foreach (GI.BR.Carteles.Cartel c in carteles)
            {
                if(!IncluirHistoricos)
                    if (!c.Activo)
                        continue;

                filtro.Add(c);
            }
            return filtro;
        }
    }
}
