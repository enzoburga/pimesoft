using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades
{
    public partial class FrmListadoPropiedades : Framework.Seguridad.FrmGISeguridad
    {

        private Type tipo;
        GI.BR.Propiedades.Propiedades propiedades;
        Framework.ListView.ListViewColumnSorter sorter = new GI.Framework.ListView.ListViewColumnSorter();

        public FrmListadoPropiedades()
        {
            InitializeComponent();
            lvPropiedades.ListViewItemSorter = sorter;
            


            
        }

        public FrmListadoPropiedades(Type Tipo) : this()
        {
            tipo = Tipo;

            switch (Tipo.ToString())
            {
                case "GI.BR.Propiedades.Alquiler":
                    {
                        Text = "Propiedades en Alquiler";
                        pictureBox1.Visible = false;
                        break;
                    }
                case "GI.BR.Propiedades.Venta":
                    {
                        Text = "Propiedades en Venta";
                        pictureBox2.Visible = false;
                        break;

                    }
            }

            Inicializar();
        }


        private ListViewItem generarLVItem(GI.BR.Propiedades.Propiedad p)
        {
            ListViewItem item = new ListViewItem();

            item.Text = p.Codigo;
            item.SubItems.Add(p.TipoPropiedad.ToString());
            item.SubItems.Add(p.Estado.ToString());
            item.SubItems.Add(p.Ambiente.ToString());
            item.SubItems.Add(p.ValorPublicacion.Moneda.ToString());
            item.SubItems.Add(p.ValorPublicacion.Importe.ToString());
            item.SubItems.Add(p.Ubicacion.Localidad.ToString());
            item.SubItems.Add(p.Ubicacion.Barrio.ToString());
            item.SubItems.Add(p.Direccion.ToString());

            if (p.EsOtraInmobiliaria)
            {
                this.lvPropiedades.ShowItemToolTips = true;
                item.ToolTipText = "Esta propiedad es de otra inmobiliaria.";
                item.ForeColor = System.Drawing.Color.Blue;
            }
            else
            {
                item.ToolTipText = "";
                item.ForeColor = System.Drawing.Color.Black;
            }

            item.Tag = p;


            return item;
        }


        public void Inicializar()
        {
            GI.BR.Propiedades.EstadosPropiedad estados = new GI.BR.Propiedades.EstadosPropiedad();
            estados.RecuperarEstados(tipo);

            GI.BR.Propiedades.EstadoPropiedad estado = null;
            foreach (GI.BR.Propiedades.EstadoPropiedad e in estados)
            {
                if (tipo.ToString() == "GI.BR.Propiedades.Venta")
                {
                    if (e.IdEstadoPropiedad == 1)
                    {
                        estado = e;
                        break;
                    }
                }
                else
                {
                    if (e.IdEstadoPropiedad == 6)
                    {
                        estado = e;
                        break;
                    }
                }
            }

            propiedades = new GI.BR.Propiedades.Propiedades();
            if (tipo.ToString() == "GI.BR.Propiedades.Venta")
                propiedades.RecuperarPropiedadesVentas(estado);
            else
                propiedades.RecuperarPropiedadesAlquileres(estado);


            lvPropiedades.BeginUpdate();
            lvPropiedades.Items.Clear();

            
            ListViewItem item;

            foreach (GI.BR.Propiedades.Propiedad p in propiedades)
            {


                lvPropiedades.Items.Add(generarLVItem(p));
            }

            lvPropiedades.EndUpdate();


        }

        #region Eventos





        private void lvPropiedades_DoubleClick_1(object sender, EventArgs e)
        {
            if (lvPropiedades.SelectedItems.Count == 1)
            {
                frmFichaPropiedad frmFicha = new frmFichaPropiedad();
                frmFicha.Propiedad = (GI.BR.Propiedades.Propiedad)lvPropiedades.SelectedItems[0].Tag;
                frmFicha.SoloLectura = true;
                frmFicha.ShowDialog();

                
            }
        }

        private void lvPropiedades_DoubleClick(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.lvPropiedades_DoubleClick_1(null, null);
        }
        
        private void editarFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvPropiedades.SelectedItems.Count != 1) return;

            frmFichaPropiedad frmFicha = new frmFichaPropiedad();
            frmFicha.Propiedad = (GI.BR.Propiedades.Propiedad)lvPropiedades.SelectedItems[0].Tag;
            frmFicha.SoloLectura = false;
            if (frmFicha.ShowDialog() == DialogResult.OK)
            {

                GI.BR.Propiedades.Propiedad p = (GI.BR.Propiedades.Propiedad)lvPropiedades.SelectedItems[0].Tag;

                ListViewItem item = generarLVItem(p);
                


                int index = lvPropiedades.SelectedIndices[0];

                lvPropiedades.Items.RemoveAt(index);
                lvPropiedades.Items.Insert(index, item);
            }
        }

        private void toolStripButtonBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarPropiedades frmBusqueda = new frmBuscarPropiedades(tipo);
            if (frmBusqueda.ShowDialog() == DialogResult.OK)
            {
                lvPropiedades.BeginUpdate();
                lvPropiedades.Items.Clear();
 
                propiedades = frmBusqueda.Propiedades;
                ListViewItem item;

                foreach (GI.BR.Propiedades.Propiedad p in propiedades)
                {
                    item = generarLVItem(p);


                    lvPropiedades.Items.Add(item);
                }

                lvPropiedades.EndUpdate();
            }
        }

        private void toolStripButtonNuevaFicha_Click(object sender, EventArgs e)
        {
            if (MostrarAvisoDemo())
                return;

            GI.BR.Propiedades.Propiedad p = null;
            if (tipo.ToString() == "GI.BR.Propiedades.Venta")
                p = new GI.BR.Propiedades.Venta();
            else
                p = new GI.BR.Propiedades.Alquiler();

            

            frmFichaPropiedad ficha = new frmFichaPropiedad();
            ficha.Propiedad = p;
            if (ficha.ShowDialog() == DialogResult.OK)
            {
                ListViewItem item = new ListViewItem();

                item = generarLVItem(p);


                lvPropiedades.Items.Add(item);
            }

        }

        private void toolStripButtonImprimir_Click(object sender, EventArgs e)
        {

            if (propiedades == null || propiedades.Count == 0)
            {
                Framework.General.GIMsgBox.Show("No hay propiedades para la vista actual", GI.Framework.General.enumTipoMensaje.Informacion);
                return;
            }

            GI.Reportes.Clases.Propiedades.ReporteListadoPropiedades reporte = new GI.Reportes.Clases.Propiedades.ReporteListadoPropiedades(tipo, propiedades);

            GI.Reportes.Visor.FrmVisorReporte frmVisor = new GI.Reportes.Visor.FrmVisorReporte(reporte);

            frmVisor.ShowDialog();


        }


        private void toolStripButtonEnviarMail_Click(object sender, EventArgs e)
        {
            if (lvPropiedades.SelectedItems.Count < 1)
            {
                Framework.General.GIMsgBox.Show("Debe seleccionar una o mas propiedades", GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }



            GI.BR.Propiedades.Propiedades propiedades = new GI.BR.Propiedades.Propiedades();
            foreach(ListViewItem item in lvPropiedades.SelectedItems)
                propiedades.Add((GI.BR.Propiedades.Propiedad)item.Tag);

            
            Formularios.FrmEnviarFichasMail frm = new GI.UI.Propiedades.Formularios.FrmEnviarFichasMail(propiedades);
            frm.ShowDialog();





        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (lvPropiedades.SelectedItems.Count != 1) return;
            Reportes.Clases.Propiedades.ReporteFichaPropiedad Reporte = new GI.Reportes.Clases.Propiedades.ReporteFichaPropiedad(
                (GI.BR.Propiedades.Propiedad)lvPropiedades.SelectedItems[0].Tag);

            Reportes.Visor.FrmVisorReporte frmVisor = new GI.Reportes.Visor.FrmVisorReporte(Reporte);
            frmVisor.ShowDialog();



        }

        private void enviarACorreoElectrˇnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButtonEnviarMail_Click(null, null);
        }

        private void lvPropiedades_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 5)
                sorter.SetTipoComparacion(GI.Framework.ListView.ListViewColumnSorter.TipoComparacion.INT);
            else
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
            this.lvPropiedades.Sort();
        }





        #endregion

        private void FrmListadoPropiedades_Load(object sender, EventArgs e)
        {

        }











    }
}