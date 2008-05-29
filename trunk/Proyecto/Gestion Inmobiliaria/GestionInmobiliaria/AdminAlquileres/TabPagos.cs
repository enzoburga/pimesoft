using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.AdminAlquileres
{
    public partial class TabPagos : TabContenidoAdmAlquiler
    {
        public TabPagos()
        {
            InitializeComponent();
        }

        protected override void Inicializar()
        {
            pagos = new GI.BR.AdmAlquileres.Pagos();
            pagos.RecuperarPorContrato(AdmAlquiler.ContratoVigente);
            LlenarLista();
        }

        public override bool SoloLectura
        {
            get
            {
                return base.SoloLectura;
            }
            set
            {
                base.SoloLectura = value;
                this.contextMenuStrip1.Enabled = !SoloLectura;
            }
        }

        private GI.BR.AdmAlquileres.Pagos pagos;

        private void LlenarLista()
        {
            lvPagos.Items.Clear();
            lvPagos.BeginUpdate();

            ListViewItem lvi;
            foreach (GI.BR.AdmAlquileres.Pago p in pagos)
            {
                lvi = new ListViewItem();
                lvi.Text = p.FechaPago.ToShortDateString();
                lvi.SubItems.Add((System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(p.MesCancelado)).ToUpper());
                lvi.SubItems.Add(p.Importe.ToString());
                lvi.Tag = p;
                lvPagos.Items.Add(lvi);
            }

            lvPagos.EndUpdate();            
        }

        private void nuevoPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AdmAlquiler.ContratoVigente.ValoresRenta.Count <= 0)
            {
                GI.Framework.General.GIMsgBox.Show("No hay definidos montos de alquiler para esta administración.", GI.Framework.General.enumTipoMensaje.Advertencia); ;
                return;
            }
            frmNuevoPago frm = new frmNuevoPago();
            frm.Contrato = AdmAlquiler.ContratoVigente;
            frm.Pago = new GI.BR.AdmAlquileres.Pago();
            frm.Pagos = pagos;
            frm.Text = "Nuevo Pago";
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (!frm.Pago.Guardar())
                {
                    
                    GI.Framework.General.GIMsgBox.Show("No se han guardado los cambios.", GI.Framework.General.enumTipoMensaje.Advertencia);
                    return;
                }
                this.pagos.Add(frm.Pago);
                LlenarLista();
            }
        }

        public void IngresarNuevoPago()
        {
            nuevoPagoToolStripMenuItem_Click(null, null);
        }

        private void modificarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvPagos.SelectedItems.Count != 1)
                return;

            frmNuevoPago frm = new frmNuevoPago();
            frm.Contrato = AdmAlquiler.ContratoVigente;
            frm.Pago = (GI.BR.AdmAlquileres.Pago)lvPagos.SelectedItems[0].Tag;
            frm.Text = "Modificar Pago";
            frm.Pagos = pagos;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if(!frm.Pago.Actualizar())
                {

                    GI.Framework.General.GIMsgBox.Show("No se han guardado los cambios.", GI.Framework.General.enumTipoMensaje.Advertencia);
                    return;
                }
                LlenarLista();
            }
        }

        private void eliminarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvPagos.SelectedItems.Count != 1)
                return;

            switch (GI.Framework.General.GIMsgBox.ShowConfirmarEliminacion())
            {
                case DialogResult.Yes:
                    {
                        ((GI.BR.AdmAlquileres.Pago)lvPagos.SelectedItems[0].Tag).Anular();
                        pagos.Remove((GI.BR.AdmAlquileres.Pago)lvPagos.SelectedItems[0].Tag);
                        LlenarLista();
                        return;
                    }
            }
        }
    }
}
