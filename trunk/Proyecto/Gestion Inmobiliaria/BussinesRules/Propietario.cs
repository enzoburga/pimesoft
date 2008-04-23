using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR
{
    public class Propietario : Cliente
    {
        #region Persistencia

        new public bool Guardar()
        {
            //Antes llamo al guardar de la clase base.
            if (!base.Guardar())
                return false;
            GI.DA.ClientesData data = new GI.DA.ClientesData();
            return data.GuardarPropietario(this.IdCliente);
        }

        new public bool Actualizar()
        {
            //Antes llamo al actualizar de la clase base.
            if (!base.Actualizar())
                return false;
            GI.DA.ClientesData data = new GI.DA.ClientesData();
            return data.ActualizarPropietario(this.IdCliente);
        }

        public bool Eliminar()
        {
            GI.DA.ClientesData data = new GI.DA.ClientesData();
            return data.Eliminar(this.IdCliente);
        }
        #endregion

    }
}
