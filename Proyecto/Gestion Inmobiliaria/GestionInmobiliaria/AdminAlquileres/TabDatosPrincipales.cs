using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.AdminAlquileres
{
    public partial class TabDatosPrincipales : TabContenidoAdmAlquiler
    {
        public TabDatosPrincipales()
        {
            InitializeComponent();
        }

        protected override void  Inicializar()
        {
            if (AdmAlquiler.Alquiler.Propietario == null)
                LinkPropietario.Text = "Seleccione un propietario";
            else
            {
                LinkPropietario.Text = AdmAlquiler.Alquiler.Propietario.ToString();

            }
            
            if (AdmAlquiler.ContratoVigente.Inquilino == null)
                LinkInquilino.Text = "Seleccione un inquilino";
            else
            {
                LinkInquilino.Text = AdmAlquiler.ContratoVigente.Inquilino.ToString();

            }
        }

        private void LinkPropiedad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GI.UI.Propiedades.frmFichaPropiedad frm = new GI.UI.Propiedades.frmFichaPropiedad();
            frm.ShowDialog();
        }

        private void LinkPropietario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GI.UI.Clientes.frmFichaCliente frm = new GI.UI.Clientes.frmFichaCliente();
            frm.ShowDialog();
        }

        private void LinkInquilino_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkPropietario_LinkClicked(null, null);
        }
    }
}
