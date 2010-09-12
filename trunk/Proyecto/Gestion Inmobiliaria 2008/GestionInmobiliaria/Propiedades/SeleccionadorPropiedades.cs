using System;
using System.Collections.Generic;
using System.Text;

namespace GI.UI.Propiedades
{
    public class SeleccionadorPropiedades : Framework.Interfaces.ISeleccionadorObeto
    {

        System.Type tipoPropiedad;
        GI.UI.Propiedades.frmBuscarPropiedades buscador ;

        public SeleccionadorPropiedades(Type TipoPropiedad)
        {
            tipoPropiedad = TipoPropiedad;
            buscador  = new GI.UI.Propiedades.frmBuscarPropiedades(TipoPropiedad);
        }


        #region ISeleccionadorObeto Members


        public System.Collections.Generic.List<object> ListadoInicial()
        {
            return null;
        }


        public List<GI.Framework.Seleccionador.MetodoBusqueda> GetMetodosBusqueda()
        {
            //List<Framework.Seleccionador.MetodoBusqueda> metodos = new List<GI.Framework.Seleccionador.MetodoBusqueda>();

            //Framework.Seleccionador.MetodoBusqueda metodo;

            ////buscar por nombre y apellido
            //metodo = new GI.Framework.Seleccionador.MetodoBusqueda();
            //metodo.NombreBusqueda = "Buscar por apellido y nombre";
            //metodo.TipoBusqueda = GI.Framework.Seleccionador.EnumTipoBusqueda.Texto;
            //metodos.Add(metodo);

            ////todos
            //metodo = new GI.Framework.Seleccionador.MetodoBusqueda();
            //metodo.NombreBusqueda = "Todos los clientes";
            //metodo.TipoBusqueda = GI.Framework.Seleccionador.EnumTipoBusqueda.SinEntrada;
            //metodos.Add(metodo);

            //return metodos;

            return null;



        }

        public List<object> Buscar(GI.Framework.Seleccionador.MetodoBusqueda Metodo)
        {
            //List<object> objetos = new List<object>();
            //GI.BR.Clientes.Clientes clientes = new GI.BR.Clientes.Clientes();


            //if (tipoCliente.ToString() == "GI.BR.Clientes.Propietario")
            //{
            //    if (Metodo.NombreBusqueda == "Buscar por apellido y nombre")
            //    {
            //        clientes.RecuperarPropietarios(Metodo.ValorSeleccionado.ToString());
            //        objetos.AddRange(clientes.ToArray());

            //    }
            //    else if (Metodo.NombreBusqueda == "Todos los clientes")
            //    {
            //        clientes.RecuperarPropietarios();
            //        objetos.AddRange(clientes.ToArray());
            //    }
            //}

            //return objetos;

            return null;


        }

        public System.Windows.Forms.ColumnHeader[] GetColumnsHeader()
        {

            System.Windows.Forms.ColumnHeader[] columns = new System.Windows.Forms.ColumnHeader[5];

            System.Windows.Forms.ColumnHeader column;

            column = new System.Windows.Forms.ColumnHeader();
            column.Text = "Código";
            column.Width = 250;
            columns[0] = column;

            column = new System.Windows.Forms.ColumnHeader();
            column.Text = "Dirección";
            column.Width = 250;
            columns[1] = column;


            column = new System.Windows.Forms.ColumnHeader();
            column.Text = "Estado";
            column.Width = 250;
            columns[2] = column;

            column = new System.Windows.Forms.ColumnHeader();
            column.Text = "Partido";
            column.Width = 250;
            columns[3] = column;

            column = new System.Windows.Forms.ColumnHeader();
            column.Text = "Barrio";
            column.Width = 250;
            columns[4] = column;
            return columns;

        }

        public System.Windows.Forms.ListViewItem GenerarListViewItem(object Objeto)
        {

            GI.BR.Propiedades.Propiedad p = (GI.BR.Propiedades.Propiedad)Objeto;

            System.Windows.Forms.ListViewItem item = new System.Windows.Forms.ListViewItem();

            item.Text = p.Codigo;
            item.SubItems.Add(p.Direccion.ToString());
            item.SubItems.Add(p.Estado.ToString());
            item.SubItems.Add(p.CantidadAmbientes.ToString());
            item.SubItems.Add(p.Ubicacion.Localidad.ToString());
            item.SubItems.Add(p.Ubicacion.Barrio.ToString());
            item.Tag = p;

            return item;
        }

        public object NuevoObjeto()
        {
            GI.BR.Propiedades.Propiedad propiedad = new GI.BR.Propiedades.PropiedadFactory().CrearClasePropiedad(tipoPropiedad);

            frmFichaPropiedad frmFicha = new frmFichaPropiedad();

            frmFicha.Propiedad = propiedad;
            frmFicha.SoloLectura = false;
            if (frmFicha.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                return propiedad;

            return null;
        }

        public void ModificarObjeto(object Objeto)
        {
            frmFichaPropiedad frmFicha = new frmFichaPropiedad();
            frmFicha.Propiedad = (GI.BR.Propiedades.Propiedad)Objeto;
            frmFicha.SoloLectura = false;
            frmFicha.ShowDialog();


        }

        


        GI.Framework.Interfaces.IBuscador GI.Framework.Interfaces.ISeleccionadorObeto.GetBuscador()
        {
            return this.buscador;
        }


        #endregion

    }
}
