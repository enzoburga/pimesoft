using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace GI.BR.Clientes
{
    public class Clientes : List<Cliente>
    {
        #region Propietarios
        public void RecuperarPropietarios(string nombre)
        {
            GI.DA.ClientesData cd = new GI.DA.ClientesData();
            using (IDataReader dr = cd.RecuperarPropietarios(nombre))
            {
                while (dr.Read())
                {
                    this.Add(GetPropietario(dr));
                }
            }
        }

        public void RecuperarPropietarios()
        {
            this.Clear();
            GI.DA.ClientesData cd = new GI.DA.ClientesData();
            using (IDataReader dr = cd.RecuperarPropietarios())
            {
                while (dr.Read())
                {
                    this.Add(GetPropietario(dr));
                }
            }
        }

        private Cliente GetPropietario(IDataReader dr)
        {
            Propietario p = new Propietario();
            p.llenar(dr);
            return p;
        } 
        #endregion

        #region Inquilinos
        public void RecuperarInquilinos(string Nombres)
        {
            this.Clear();
            GI.DA.ClientesData cd = new GI.DA.ClientesData();
            using (IDataReader dr = cd.RecuperarInquilinos(Nombres))
            {
                while (dr.Read())
                {
                    this.Add(GetInquilino(dr));
                }
            }
        }

        public void RecuperarInquilinos()
        {
            this.Clear();
            GI.DA.ClientesData cd = new GI.DA.ClientesData();
            using (IDataReader dr = cd.RecuperarInquilinos())
            {
                while (dr.Read())
                {
                    this.Add(GetInquilino(dr));
                }
            }
        }

        private Cliente GetInquilino(IDataReader dr)
        {
            Inquilino i = new Inquilino();
            i.llenar(dr);
            return i;
        }

        #endregion

        #region Clientes Pedidos

        public void RecuperarClientesPedido(string Nombres)
        {
            this.Clear();
            GI.DA.ClientesData cd = new GI.DA.ClientesData();
            using (IDataReader dr = cd.RecuperarClientesPedido(Nombres))
            {
                while (dr.Read())
                {
                    this.Add(GetClientePedido(dr));
                }
            }
        }

        public void RecuperarClientesPedido()
        {
            this.Clear();
            GI.DA.ClientesData cd = new GI.DA.ClientesData();
            using (IDataReader dr = cd.RecuperarClientesPedido())
            {
                while (dr.Read())
                {
                    this.Add(GetClientePedido(dr));
                }
            }
        }

        private Cliente GetClientePedido(IDataReader dr)
        {
            ClientePedido c = new ClientePedido();
            c.llenar(dr);
            return c;
        }

        #endregion

        public void RecuperarTodos(string Nombres)
        {
            Clientes inquilinos = new Clientes();
            Clientes propietarios = new Clientes();
            Clientes clientesPedido = new Clientes();

            inquilinos.RecuperarInquilinos(Nombres);
            propietarios.RecuperarPropietarios(Nombres);
            clientesPedido.RecuperarClientesPedido(Nombres);

            this.AddRange(inquilinos);
            this.AddRange(propietarios);
            this.AddRange(clientesPedido);  
        }

        public void RecuperarTodos()
        {
            Clientes inquilinos = new Clientes();
            Clientes propietarios = new Clientes();
            Clientes clientesPedido = new Clientes();

            inquilinos.RecuperarInquilinos();
            propietarios.RecuperarPropietarios();
            clientesPedido.RecuperarClientesPedido();

            this.AddRange(inquilinos);
            this.AddRange(propietarios);
            this.AddRange(clientesPedido); 
        }


    }
}
