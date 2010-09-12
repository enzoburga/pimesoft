using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.AdminAlquileres
{
    public partial class TabHistorico : TabContenidoAdmAlquiler
    {
        public TabHistorico()
        {
            InitializeComponent();
        }

        protected override void Inicializar()
        {
            contratos = new GI.BR.AdmAlquileres.Contratos();
            if(AdmAlquiler.Alquiler != null)
                contratos.RecuperarPorAdmAlquiler(this.AdmAlquiler);

            LlenarLista();
        }

        private GI.BR.AdmAlquileres.Contratos contratos;

        public override bool AsignarSoloLectura(Control Ctrl)
        {
            return false;
        }


        private void LlenarLista()
        {
            lvContratos.Items.Clear();
            lvContratos.BeginUpdate();

            ListViewItem lvi;
            foreach (GI.BR.AdmAlquileres.Contrato c in contratos)
            {
                if (c.Vigente)
                    continue;
                lvi = new ListViewItem();
                if (c.Inquilino != null)
                    lvi.Text = c.Inquilino.ToString();
                else
                    lvi.Text = "No hay inquilino.";

                lvi.SubItems.Add(c.FechaInicio.ToShortDateString());
                lvi.SubItems.Add(c.FechaVencimiento.ToShortDateString());
                lvi.Tag = c;
                lvContratos.Items.Add(lvi);
            }

            lvContratos.EndUpdate();
        }

        private void lvContratos_DoubleClick(object sender, EventArgs e)
        {
            if (lvContratos.SelectedItems.Count != 1)
                return;

            frmNuevoContrato frm = new frmNuevoContrato();
            frm.Contrato = (GI.BR.AdmAlquileres.Contrato)lvContratos.SelectedItems[0].Tag;
            frm.SoloLectura = true;
            frm.Text = "Ficha de contrato";
            frm.Show();
        }

    }
}
