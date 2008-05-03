using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.AdminAlquileres
{
    public partial class frmListadoAdmAlquiler : GI.Framework.Seguridad.FrmGISeguridad
    {
        public frmListadoAdmAlquiler()
        {
            InitializeComponent();
        }

        private GI.BR.AdmAlquileres.AdmAlquileres admAlquileres = new GI.BR.AdmAlquileres.AdmAlquileres();

        private void lvAdmAlquileres_DoubleClick(object sender, EventArgs e)
        {

           frmFichaAdmAlquileres frm = new frmFichaAdmAlquileres();
           frm.AdmAlquiler = (GI.BR.AdmAlquileres.AdmAlquiler)lvAdmAlquileres.SelectedItems[0].Tag;
           frm.SoloLectura = true;
           frm.ShowDialog();


        }

        private void NuevoAlquilertoolStripButton_Click(object sender, EventArgs e)
        {
            frmFichaAdmAlquileres frm = new frmFichaAdmAlquileres();

            GI.BR.AdmAlquileres.AdmAlquiler admAlquiler = new GI.BR.AdmAlquileres.AdmAlquiler();
            admAlquiler.ContratoVigente = new GI.BR.AdmAlquileres.Contrato();
            admAlquiler.ContratoVigente.Deposito = new GI.BR.Valor();
            admAlquiler.ContratoVigente.Deposito.Moneda = new GI.BR.Monedas.Moneda();
            admAlquiler.ContratoVigente.Vigente = true;
            admAlquiler.ContratoVigente.Observaciones = "";
            

            frm.AdmAlquiler = admAlquiler;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                admAlquileres.Add(admAlquiler);
                LlenarLista();
            }
        }

        private void LlenarLista()
        {
            ListViewItem lvi;
            lvAdmAlquileres.BeginUpdate();

            lvAdmAlquileres.Items.Clear();
            foreach (GI.BR.AdmAlquileres.AdmAlquiler a in admAlquileres)
            {
                lvi = new ListViewItem();

                if (a.Contacto == null)
                    lvi.Text = "No hay un Contacto asociado.";
                else
                    lvi.Text = a.Contacto.ToString();

                //HACER GET PROPIEDAD POR ID
                //lvi.SubItems.Add(a.Alquiler.Codigo + " - " + a.Alquiler.Direccion.ToString());

                lvi.SubItems.Add("HACER CARGADO DE PROPIEDAD POR ID");

                if (a.ContratoVigente.Inquilino == null)
                    lvi.SubItems.Add("No hay Inquilino.");
                else
                    lvi.SubItems.Add(a.ContratoVigente.Inquilino.ToString());

                lvi.SubItems.Add(a.ContratoVigente.FechaVencimiento.ToShortDateString());
                lvi.Tag = a;
                lvAdmAlquileres.Items.Add(lvi);


                
                
            }
            lvAdmAlquileres.EndUpdate();

            lvAdmAlquileres.Focus();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmBuscarAdminAlquileres frmBuscar = new frmBuscarAdminAlquileres();

            if (frmBuscar.ShowDialog() == DialogResult.OK)
            {
                this.admAlquileres = frmBuscar.AdmAlquileres;
                this.LlenarLista();
            }
        }

        private void verFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvAdmAlquileres_DoubleClick(sender, e);
        }

        private void editarFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFichaAdmAlquileres frm = new frmFichaAdmAlquileres();
            frm.AdmAlquiler = (GI.BR.AdmAlquileres.AdmAlquiler)lvAdmAlquileres.SelectedItems[0].Tag;
            if (frm.ShowDialog() == DialogResult.OK)
                LlenarLista();
        }

        private void imprimirListadotoolStripButton_Click(object sender, EventArgs e)
        {

            if (admAlquileres == null || admAlquileres.Count == 0)
            {
                Framework.General.GIMsgBox.Show("No hay alquileres para la vista actual", GI.Framework.General.enumTipoMensaje.Informacion);
                return;
            }

            GI.Reportes.Clases.AdmAlquileres.ReporteListadoAdmAlquileres reporte = new GI.Reportes.Clases.AdmAlquileres.ReporteListadoAdmAlquileres("Listado de Alquileres Administrados", admAlquileres);

            GI.Reportes.Visor.FrmVisorReporte frmVisor = new GI.Reportes.Visor.FrmVisorReporte(reporte);

            frmVisor.ShowDialog();
        }

        



    }
}