using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Clientes
{
    public class ClienteFactory
    {



        public Cliente CrearClaseCliente(Type Tipo)
        {
            if (Tipo.ToString() == "GI.BR.Clientes.Propietario")
                return new Propietario();

            else if (Tipo.ToString() == "GI.BR.Clientes.Inquilino")
                return new Inquilino();

            return null;
        
        
        }
    }
}
