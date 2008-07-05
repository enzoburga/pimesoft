using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Clientes
{
    [Serializable]
    public class ClientePedido : Cliente
    {
        public override enumTipoClientes TipoCliente
        {
            get { return enumTipoClientes.ClientePedido; }
        }
        #region Persistencia

        public override bool Guardar()
        {
            //Antes llamo al guardar de la clase base.
            if (!base.Guardar())
                return false;
            GI.DA.ClientesData data = new GI.DA.ClientesData();
            return data.GuardarClientePedido(this.IdCliente);
        }

        public override bool Actualizar()
        {
            //Antes llamo al actualizar de la clase base.
            return base.Actualizar();
        }

        #endregion

        #region ICloneable Members

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion

        public void RecuperarPorEmail(string email)
        {
            using(System.Data.IDataReader dr = new  DA.ClientesData().RecuperarDatosClientePorEmail(email))
            {
                if (dr.Read())
                {
                    this.llenar(dr);
                }
            }            
        }
    }
}
