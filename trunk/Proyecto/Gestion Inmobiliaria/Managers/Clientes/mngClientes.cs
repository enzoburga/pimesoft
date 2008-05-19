using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Managers.Clientes
{
    public class mngClientes
    {
        public GI.BR.Clientes.Clientes RecuperarClientes(GI.Managers.Clientes.enumTipoBusquedaCliente tipoCliente, string Nombres)
        {
            GI.BR.Clientes.Clientes clientes = new GI.BR.Clientes.Clientes();

            switch (tipoCliente)
            {
                case enumTipoBusquedaCliente.Propietarios:
                    clientes.RecuperarPropietarios(Nombres);
                    break;
                case enumTipoBusquedaCliente.ClientePedido:
                    clientes.RecuperarClientesPedido(Nombres);
                    break;
                case enumTipoBusquedaCliente.Inquilinos:
                    clientes.RecuperarInquilinos(Nombres);
                    break;
                case enumTipoBusquedaCliente.Todos:
                    clientes.RecuperarTodos(Nombres); 
                    break;
            }

            return clientes;
        }

        public GI.BR.Clientes.Clientes RecuperarClientesTodos(GI.Managers.Clientes.enumTipoBusquedaCliente tipoCliente)
        {
            GI.BR.Clientes.Clientes clientes = new GI.BR.Clientes.Clientes();

            switch (tipoCliente)
            {
                case enumTipoBusquedaCliente.Propietarios:
                    clientes.RecuperarPropietarios();
                    break;
                case enumTipoBusquedaCliente.ClientePedido:
                    clientes.RecuperarClientesPedido();
                    break;
                case enumTipoBusquedaCliente.Inquilinos:
                    clientes.RecuperarInquilinos();
                    break;
                case enumTipoBusquedaCliente.Todos:
                    clientes.RecuperarTodos();
                    break;
            }

            return clientes;
        }
    }
}
