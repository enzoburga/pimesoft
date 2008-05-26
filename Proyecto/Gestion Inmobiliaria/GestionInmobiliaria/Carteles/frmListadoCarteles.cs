using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Carteles
{
    public partial class frmListadoCarteles : GI.Framework.Seguridad.FrmGISeguridad
    {
        public frmListadoCarteles()
        {
            InitializeComponent();
            lvCarteles.ListViewItemSorter = sorter;
        }


        public void Inicializar()
        {

            this.carteles = new GI.BR.Carteles.Carteles();
            carteles.RecuperarCartelesTodos();
            LlenarLista();
        }

        private GI.BR.Carteles.Carteles carteles;

        Framework.ListView.ListViewColumnSorter sorter = new GI.Framework.ListView.ListViewColumnSorter();

        private void lvCarteles_DoubleClick(object sender, EventArgs e)
        {
            if (lvCarteles.SelectedItems.Count != 1)
                return;

            frmFichaCarteles frm = new frmFichaCarteles();
            frm.Cartel = (GI.BR.Carteles.Cartel)lvCarteles.SelectedItems[0].Tag;
            frm.SoloLectura = true;
            frm.ShowDialog();


        }

        private void LlenarLista()
        {
            ListViewItem lvi;
            lvCarteles.BeginUpdate();

            lvCarteles.Items.Clear();
            foreach (GI.BR.Carteles.Cartel c in carteles)
            {
                lvi = new ListViewItem();

                //TODO: LLENAR LISTA
                if (c.TipoCartel == typeof(GI.BR.Propiedades.Venta))
                    lvi.Text = "Venta";
                if (c.TipoCartel == typeof(GI.BR.Propiedades.Alquiler))
                    lvi.Text = "Alquiler";

                lvi.SubItems.Add(c.FechaAlta.ToShortDateString());
                lvi.SubItems.Add(c.Propiedad.Codigo.ToString());
                lvi.SubItems.Add(c.Propiedad.Direccion.ToString());
                lvi.SubItems.Add(c.FechaVencimiento.ToShortDateString());

                if (c.Activo)
                    lvi.SubItems.Add("Activo");
                else
                    lvi.SubItems.Add("Histórico");

                if (c.Ancho > 0 && c.Alto > 0)
                {
                    lvi.SubItems.Add(c.Alto.ToString() + " x " + c.Ancho.ToString());
                }
                else
                    lvi.SubItems.Add("-----"); 

                lvi.Tag = c;
                lvCarteles.Items.Add(lvi);
            }
            lvCarteles.EndUpdate();

            lvCarteles.Focus();
        }

        private void verFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvCarteles_DoubleClick(sender, e);
        }

        private void editarFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvCarteles.SelectedItems.Count != 1)
                return;

            frmFichaCarteles frm = new frmFichaCarteles();
            frm.Cartel = (GI.BR.Carteles.Cartel)lvCarteles.SelectedItems[0].Tag;

            if (!frm.Cartel.Activo)
            {
                GI.Framework.General.GIMsgBox.Show("El cartel es histórico, se abrira en modo solo lectura.", GI.Framework.General.enumTipoMensaje.Informacion);
                lvCarteles_DoubleClick(sender, e);
            }
            else
            {

                frm.ShowDialog();
                LlenarLista();
            }
        }


        private void nuevoCartelDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFichaCarteles frm = new frmFichaCarteles();
            GI.BR.Carteles.Cartel c = new GI.BR.Carteles.Cartel();
            c.TipoCartel = typeof(GI.BR.Propiedades.Venta);
            c.FechaAlta = DateTime.Today;
            c.FechaVencimiento = DateTime.Today;
            c.Activo = true;
            frm.Cartel = c;
            frm.Text = "Cartel de Venta";

            if (frm.ShowDialog() == DialogResult.OK)
            {
                carteles.Add(c);
                LlenarLista();
            }

        }

        private void nuevoCartelDeAlquilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFichaCarteles frm = new frmFichaCarteles();
            GI.BR.Carteles.Cartel c = new GI.BR.Carteles.Cartel();
            c.TipoCartel = typeof(GI.BR.Propiedades.Alquiler);
            c.FechaAlta = DateTime.Today;
            c.FechaVencimiento = DateTime.Today;
            c.Activo = true;

            frm.Cartel = c;
            frm.Text = "Cartel de Alquiler";


            if (frm.ShowDialog() == DialogResult.OK)
            {
                carteles.Add(c);
                LlenarLista();
            }
        }




        private void lvCarteles_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0 || e.Column == 2 || e.Column == 3 || e.Column == 5 || e.Column == 6)
                sorter.SetTipoComparacion(GI.Framework.ListView.ListViewColumnSorter.TipoComparacion.STRING);
            if (e.Column == 1 || e.Column == 4)
                sorter.SetTipoComparacion(GI.Framework.ListView.ListViewColumnSorter.TipoComparacion.DATETIME);

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
            this.lvCarteles.Sort();
        }

        private void verTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carteles.RecuperarCartelesTodos();
            LlenarLista();
        }






    }
}