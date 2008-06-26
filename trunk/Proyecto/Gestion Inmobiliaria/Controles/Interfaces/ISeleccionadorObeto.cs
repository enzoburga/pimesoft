using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Framework.Interfaces
{
    public interface ISeleccionadorObeto
    {

        #region Busqueda
        System.Collections.Generic.List<Seleccionador.MetodoBusqueda> GetMetodosBusqueda();
        System.Collections.Generic.List<object> Buscar(Seleccionador.MetodoBusqueda Metodo);
        System.Collections.Generic.List<object> ListadoInicial();
        
        #endregion

        #region Interface WindowsForm

        System.Windows.Forms.ColumnHeader[] GetColumnsHeader();
        System.Windows.Forms.ListViewItem GenerarListViewItem(object Objeto);
        GI.Framework.Interfaces.IBuscador GetBuscador();
        
        #endregion

        #region Persistencia


        object NuevoObjeto();
        void ModificarObjeto(object Objeto);


        
        #endregion



    }
}
