using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Framework.Interfaces
{
    public interface IBuscador
    {
        List<Object> GetObjetosEncontrados();
        void SetTipoBusqueda(Type tipoObjeto);
        System.Windows.Forms.DialogResult MostrarBuscador();
    }
}
