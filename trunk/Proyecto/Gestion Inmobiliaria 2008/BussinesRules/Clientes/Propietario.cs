using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Clientes
{
    public class Propietario : Cliente
    {
        public override enumTipoClientes TipoCliente
        {
            get { return enumTipoClientes.Propietario; }
        }
        #region Persistencia

        public override bool Guardar()
        {
            //Antes llamo al guardar de la clase base.
            if (!base.Guardar())
                return false;
            GI.DA.ClientesData data = new GI.DA.ClientesData();
            return data.GuardarPropietario(this.IdCliente);
        }

        public override bool Actualizar()
        {
            //Antes llamo al actualizar de la clase base.
            return base.Actualizar();
        }

        //public bool Eliminar()
        //{
        //    GI.DA.ClientesData data = new GI.DA.ClientesData();
        //    return data.Eliminar(this.IdCliente);
        //}
        #endregion

        #region ICloneable Members

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion

    }
}
