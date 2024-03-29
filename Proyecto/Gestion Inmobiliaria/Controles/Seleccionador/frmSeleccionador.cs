using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.Framework
{
    public partial class frmSeleccionador : Form
    {
        #region Atributos Privados
        private Interfaces.ISeleccionadorObeto claseSeleccionador;
        private object objetoSeleccionado;
        private List<object> objetosSeleccionados;
        private bool multiSeleccion;
        Framework.ListView.ListViewColumnSorter sorter = new GI.Framework.ListView.ListViewColumnSorter();


        
        #endregion

        #region Constructores


        public frmSeleccionador()
        {
            InitializeComponent();
            MultiSeleccion = false;
            lvItems.ListViewItemSorter = sorter;
            
        }



        public frmSeleccionador(Interfaces.ISeleccionadorObeto ISeleccionador)
            : this()
        {

            claseSeleccionador = ISeleccionador;

            lvItems.Columns.AddRange(claseSeleccionador.GetColumnsHeader());

            List<object> listaDefault = ISeleccionador.ListadoInicial();
            if (listaDefault != null && listaDefault.Count > 0)
                LlenarLista(listaDefault);

        }
        
        #endregion

        #region Propiedades Publicas

        public bool MultiSeleccion
        {
            get 
            { 
                return multiSeleccion; 
            }
            set 
            {
                multiSeleccion = value;
                lvItems.CheckBoxes = value;
                splitContainer2.Panel2Collapsed = !value;
            }
        }

        public object ObjetoSeleccionado
        {
            get { return objetoSeleccionado; }
        }

        public List<object> ObjetosSeleccionados
        {
            get { return objetosSeleccionados; }
        } 

        #endregion

        #region Metodos

        private void toolStripButtonBuscar_Click(object sender, EventArgs e)
        {



            if (claseSeleccionador.GetBuscador() == null)
                BuscarGenerico();
            else
            {


                if (claseSeleccionador.GetBuscador().MostrarBuscador() == DialogResult.OK)
                {
                    System.Collections.Generic.List<object> resultado = claseSeleccionador.GetBuscador().GetObjetosEncontrados();
                    //if (resultado.Count == 0)
                    //{
                    //    GI.Framework.General.GIMsgBox.ShowNoSeEncontraronDatos();
                    //    return;
                    //}

                    if (resultado.Count > 0)
                        LlenarLista(resultado);
                }
            }

        }

        private void BuscarGenerico()
        {

            List<Framework.Seleccionador.MetodoBusqueda> metodos = claseSeleccionador.GetMetodosBusqueda();
            if (metodos == null)
            {
                Framework.General.GIMsgBox.Show("No hay m�todos de b�squeda disponibles.", GI.Framework.General.enumTipoMensaje.Informacion);
                return;
            }

            Seleccionador.frmBuscador frmBuscar = new GI.Framework.Seleccionador.frmBuscador(metodos);


            if (frmBuscar.ShowDialog() == DialogResult.OK)
            {
                System.Collections.Generic.List<object> resultado = claseSeleccionador.Buscar(frmBuscar.Metodo);
                if (resultado.Count > 0)
                    LlenarLista(resultado);


            }
        }

        private void LlenarLista(System.Collections.Generic.List<object> resultado)
        {
            lvItems.BeginUpdate();
            lvItems.Items.Clear();

            ListViewItem item;
            foreach (object obj in resultado)
            {
                item = claseSeleccionador.GenerarListViewItem(obj);
                lvItems.Items.Add(item);
            }


            if (lvItems.Items.Count > 0) lvItems.Items[0].Selected = true;
            lvItems.EndUpdate();
        }

        private void toolStripButtonAgregar_Click(object sender, EventArgs e)
        {
            object objNuevo = claseSeleccionador.NuevoObjeto();

            if (objNuevo != null)
            {
                ListViewItem item = claseSeleccionador.GenerarListViewItem(objNuevo);
                lvItems.Items.Add(item);
                item.Selected = true;
            }
        }

        private void lvItems_DoubleClick(object sender, EventArgs e)
        {
            if (MultiSeleccion)
                return;
            if (lvItems.SelectedItems.Count != 1)
                return;
            objetoSeleccionado = lvItems.SelectedItems[0].Tag;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void seleccionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvItems.SelectedItems.Count != 1) return;
            if (MultiSeleccion)
            {
                foreach (ListViewItem lvi in lvItems.SelectedItems)
                    lvi.Checked = true;            
            }
            else
                lvItems_DoubleClick(null, null);
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvItems.SelectedItems.Count != 1) return;

            claseSeleccionador.ModificarObjeto(lvItems.SelectedItems[0].Tag);

            int index = lvItems.SelectedItems[0].Index;

            lvItems.Items[index] = claseSeleccionador.GenerarListViewItem(lvItems.SelectedItems[0].Tag);


        } 


        #endregion

        private void bAceptar_Click(object sender, EventArgs e)
        {
            objetosSeleccionados = new List<object>();
            foreach (ListViewItem lvi in lvItems.Items)
            {
                if(lvi.Checked)
                    objetosSeleccionados.Add(lvi.Tag);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void lvItems_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            

            sorter.SetTipoComparacion(GI.Framework.ListView.ListViewColumnSorter.TipoComparacion.STRING);

            if (e.Column == sorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (sorter.Order == SortOrder.Ascending)
                {
                    sorter.Order = SortOrder.Descending;
                }
                else
                {
                    sorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                sorter.SortColumn = e.Column;
                sorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.lvItems.Sort();
        }
    }
}