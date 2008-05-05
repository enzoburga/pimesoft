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

        public FrmListadoPropiedades()
        {
            InitializeComponent();
            
        }

        public FrmListadoPropiedades(Type Tipo) : this()
        {
            tipo = Tipo;

            switch (Tipo.ToString())
            {
                case "GI.BR.Propiedades.Alquiler":
                    {
                        Text = "Propiedades en Alquiler";
                        break;
                    }
                case "GI.BR.Propiedades.Venta":
                    {
                        Text = "Propiedades en Venta";
                        break;
                    }
            }

            Inicializar();
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
                item = new ListViewItem();

                item.Text = p.Codigo;
                item.SubItems.Add(p.TipoPropiedad.ToString());
                item.SubItems.Add(p.Estado.ToString());
                item.SubItems.Add(p.Ambiente.ToString());
                item.SubItems.Add(p.ValorPublicacion.ToString());
                item.SubItems.Add(p.Ubicacion.Localidad.ToString());
                item.SubItems.Add(p.Ubicacion.Barrio.ToString());
                item.SubItems.Add(p.Direccion.ToString());

                if (p.EsOtraInmobiliaria)
                    item.ForeColor = System.Drawing.Color.Blue;
                else
                    item.ForeColor = System.Drawing.Color.Black;

                item.Tag = p;

                lvPropiedades.Items.Add(item);
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
                ListViewItem item = new ListViewItem();
                GI.BR.Propiedades.Propiedad p = (GI.BR.Propiedades.Propiedad)lvPropiedades.SelectedItems[0].Tag;
                item.Text = p.Codigo;
                item.SubItems.Add(p.TipoPropiedad.ToString());
                item.SubItems.Add(p.Estado.ToString());
                item.SubItems.Add(p.Ambiente.ToString());
                item.SubItems.Add(p.ValorPublicacion.ToString());
                item.SubItems.Add(p.Ubicacion.Localidad.ToString());
                item.SubItems.Add(p.Ubicacion.Barrio.ToString());
                item.SubItems.Add(p.Direccion.ToString());
                if (p.EsOtraInmobiliaria)
                    item.ForeColor = System.Drawing.Color.Blue;
                else
                    item.ForeColor = System.Drawing.Color.Black;
                   
                item.Tag = p;

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
                    item = new ListViewItem();

                    item.Text = p.Codigo;
                    item.SubItems.Add(p.TipoPropiedad.ToString());
                    item.SubItems.Add(p.Estado.ToString());
                    item.SubItems.Add(p.Ambiente.ToString());
                    item.SubItems.Add(p.ValorPublicacion.ToString());
                    item.SubItems.Add(p.Ubicacion.Localidad.ToString());
                    item.SubItems.Add(p.Ubicacion.Barrio.ToString());
                    item.SubItems.Add(p.Direccion.ToString());

                    if (p.EsOtraInmobiliaria)
                        item.ForeColor = System.Drawing.Color.Blue;
                    else
                        item.ForeColor = System.Drawing.Color.Black;
                    
                    item.Tag = p;
                    
                    lvPropiedades.Items.Add(item);
                }

                lvPropiedades.EndUpdate();
            }
        }

        private void toolStripButtonNuevaFicha_Click(object sender, EventArgs e)
        {
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

                item.Text = p.Codigo;
                item.SubItems.Add(p.TipoPropiedad.ToString());
                item.SubItems.Add(p.Estado.ToString());
                item.SubItems.Add(p.Ambiente.ToString());
                item.SubItems.Add(p.ValorPublicacion.ToString());
                item.SubItems.Add(p.Ubicacion.Localidad.ToString());
                item.SubItems.Add(p.Ubicacion.Barrio.ToString());
                item.SubItems.Add(p.Direccion.ToString());

                if (p.EsOtraInmobiliaria)
                    item.ForeColor = System.Drawing.Color.Blue;
                else
                    item.ForeColor = System.Drawing.Color.Black;
                   


                item.Tag = p;

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


        #endregion

        private void toolStripButtonEnviarMail_Click(object sender, EventArgs e)
        {
            if (lvPropiedades.SelectedItems.Count != 1)
            {
                Framework.General.GIMsgBox.Show("Debe seleccionar una propiedad", GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }



            Formularios.FrmEnviarFichasMail frm = new GI.UI.Propiedades.Formularios.FrmEnviarFichasMail(
                (GI.BR.Propiedades.Propiedad)lvPropiedades.SelectedItems[0].Tag);
            frm.ShowDialog();





        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButtonImprimir_Click(null, null);
        }

        private void enviarACorreoElectrónicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButtonEnviarMail_Click(null, null);
        }












    }
}