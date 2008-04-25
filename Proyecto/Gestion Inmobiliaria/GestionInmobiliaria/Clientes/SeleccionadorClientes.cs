using System;
using System.Collections.Generic;
using System.Text;

namespace GI.UI.Clientes
{
    public class SeleccionadorClientes : Framework.Interfaces.ISeleccionadorObeto
    {

        System.Type tipoCliente;

        public SeleccionadorClientes(Type TipoCliente)
        {
            tipoCliente = TipoCliente;
        }


        #region ISeleccionadorObeto Members

        public List<GI.Framework.Seleccionador.MetodoBusqueda> GetMetodosBusqueda()
        {
            List<Framework.Seleccionador.MetodoBusqueda> metodos = new List<GI.Framework.Seleccionador.MetodoBusqueda>();

            Framework.Seleccionador.MetodoBusqueda metodo;

            //buscar por nombre y apellido
            metodo = new GI.Framework.Seleccionador.MetodoBusqueda();
            metodo.NombreBusqueda = "Buscar por apellido y nombre";
            metodo.TipoBusqueda = GI.Framework.Seleccionador.EnumTipoBusqueda.Texto;
            metodos.Add(metodo);

            //todos
            metodo = new GI.Framework.Seleccionador.MetodoBusqueda();
            metodo.NombreBusqueda = "Todos los clientes";
            metodo.TipoBusqueda = GI.Framework.Seleccionador.EnumTipoBusqueda.SinEntrada;
            metodos.Add(metodo);

            return metodos;



        }

        public List<object> Buscar(GI.Framework.Seleccionador.MetodoBusqueda Metodo)
        {
            List<object> objetos = new List<object>();
            GI.BR.Clientes clientes = new GI.BR.Clientes();


            if (tipoCliente is GI.BR.Propietario)
            {
                if (Metodo.NombreBusqueda == "Buscar por apellido y nombre")
                {
                    clientes.RecuperarPropietarios(Metodo.ValorSeleccionado.ToString());
                    objetos.AddRange(clientes.ToArray());

                }
                else if (Metodo.NombreBusqueda == "Todos los clientes")
                {
                    clientes.RecuperarPropietarios();
                    objetos.AddRange(clientes.ToArray());
                }
            }

            return objetos;


        }

        public System.Windows.Forms.ColumnHeader[] GetColumnsHeader()
        {

            System.Windows.Forms.ColumnHeader[] columns = new System.Windows.Forms.ColumnHeader[2];

            System.Windows.Forms.ColumnHeader column;

            column = new System.Windows.Forms.ColumnHeader();
            column.Text = "Nombre";
            column.Width = 250;
            columns[0] = column;


            column = new System.Windows.Forms.ColumnHeader();
            column.Text = "Dirección";
            column.Width = 250;
            columns[1] = column;

            return columns;

        }

        public System.Windows.Forms.ListViewItem GenerarListViewItem(object Objeto)
        {

            GI.BR.Cliente cliente = (GI.BR.Cliente)Objeto;

            System.Windows.Forms.ListViewItem item = new System.Windows.Forms.ListViewItem();

            item.Text = cliente.Nombres + " " + cliente.Apellido;
            item.SubItems.Add(cliente.Direccion.Calle + " " + cliente.Direccion.Numero.ToString());

            item.Tag = cliente;

            return item;

        }

        public object NuevoObjeto()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void ModificarObjeto(object Objeto)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
