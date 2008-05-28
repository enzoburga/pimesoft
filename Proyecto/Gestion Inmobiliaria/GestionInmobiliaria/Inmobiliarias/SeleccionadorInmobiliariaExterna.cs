using System;
using System.Collections.Generic;
using System.Text;

namespace GI.UI.Inmobiliarias
{
    public class SeleccionadorInmobiliariaExterna : Framework.Interfaces.ISeleccionadorObeto
    {

        public SeleccionadorInmobiliariaExterna()
        { 
        
        }

        #region ISeleccionadorObeto Members

        public List<GI.Framework.Seleccionador.MetodoBusqueda> GetMetodosBusqueda()
        {
            Framework.Seleccionador.MetodoBusqueda metodo = new GI.Framework.Seleccionador.MetodoBusqueda();
            metodo.TipoBusqueda = GI.Framework.Seleccionador.EnumTipoBusqueda.SinEntrada;
            metodo.NombreBusqueda = "Todas las inmobiliarias";

            List<Framework.Seleccionador.MetodoBusqueda> metodos = new List<GI.Framework.Seleccionador.MetodoBusqueda>();
            metodos.Add(metodo);

            return metodos;

        }

        public List<object> Buscar(GI.Framework.Seleccionador.MetodoBusqueda Metodo)
        {

            GI.BR.InmobiliariasExternas inmobiliarias = new GI.BR.InmobiliariasExternas();
            inmobiliarias.RecuperarTodas();

            List<object> lista = new List<object>();
            lista.AddRange(inmobiliarias.ToArray());

            return lista;
        }

        public System.Windows.Forms.ColumnHeader[] GetColumnsHeader()
        {
            System.Windows.Forms.ColumnHeader[] columns = new System.Windows.Forms.ColumnHeader[3];

            System.Windows.Forms.ColumnHeader column;

            column = new System.Windows.Forms.ColumnHeader();
            column.Text = "Inmobiliaria";
            column.Width = 250;
            columns[0] = column;

            column = new System.Windows.Forms.ColumnHeader();
            column.Text = "Contacto";
            column.Width = 250;
            columns[1] = column;


            column = new System.Windows.Forms.ColumnHeader();
            column.Text = "Telefono";
            column.Width = 250;
            columns[2] = column;

            return columns;


        }

        public System.Windows.Forms.ListViewItem GenerarListViewItem(object Objeto)
        {
            System.Windows.Forms.ListViewItem item = new System.Windows.Forms.ListViewItem();


            item.Text = ((GI.BR.InmobiliariaExterna)Objeto).Nombre;
            item.SubItems.Add(((GI.BR.InmobiliariaExterna)Objeto).PersonaResponsable);
            item.SubItems.Add(((GI.BR.InmobiliariaExterna)Objeto).Telefono);
            item.Tag = ((GI.BR.InmobiliariaExterna)Objeto);

            return item;
            



        }

        public GI.Framework.Interfaces.IBuscador GetBuscador()
        {
            return null;
        }

        public object NuevoObjeto()
        {
            GI.BR.InmobiliariaExterna Inmobiliaria = new GI.BR.InmobiliariaExterna();
            FrmInmobiliariaExterna frm = new FrmInmobiliariaExterna(Inmobiliaria);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                return Inmobiliaria;

            return null;


        }

        public void ModificarObjeto(object Objeto)
        {
            FrmInmobiliariaExterna frm = new FrmInmobiliariaExterna((GI.BR.InmobiliariaExterna)Objeto);
            frm.ShowDialog();
        }

        #endregion
    }
}
