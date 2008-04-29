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

        protected override void Inicializar()
        {
            #region Inicializar Combos

            GI.BR.Monedas.Monedas Monedas = new GI.BR.Monedas.Monedas();
            Monedas.RecuperarTodas();
            foreach (GI.BR.Monedas.Moneda M in Monedas)
            {
                cbMonedaDepositoContrato.Items.Add(M);
                cbMonedaMontoContrato.Items.Add(M);
            }
            cbMonedaDepositoContrato.SelectedIndex = 0;
            cbMonedaMontoContrato.SelectedIndex = 0;
            #endregion

            MontoBindingSource.Add(AdmAlquiler.ContratoVigente.Monto);
            DepositoBindingSource.Add(AdmAlquiler.ContratoVigente.Deposito);
            contratoBindingSource.Add(AdmAlquiler.ContratoVigente);
            admAlquilerBindingSource.Add(AdmAlquiler);

            ctrlDireccion1.SoloLectura = true;
            ctrlDireccion1.RefrezcarSoloLectura(ctrlDireccion1.Controls);

            LinkPropietario.Text = "Seleccione un Contacto";

            if (AdmAlquiler.Alquiler == null)
            {
                LinkPropiedad.Text = "Seleccione una Propiedad";
                cBoxEsPropietario.Enabled = false;
            }
            else
            {
                propiedadBindingSource.Add(AdmAlquiler.Alquiler);
                LinkPropiedad.Text = AdmAlquiler.Alquiler.Codigo.ToString();
                cBoxEsPropietario.Enabled = true;
            }

            if (AdmAlquiler.ContratoVigente.Inquilino == null)
                LinkInquilino.Text = "Seleccione un Inquilino";
            else
            {
                LinkInquilino.Text = AdmAlquiler.ContratoVigente.Inquilino.ToString();

            }
        }

        private void LinkPropiedad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LinkPropiedad.Text == "Seleccione una Propiedad")
            {
                Framework.frmSeleccionador frmSeleccionador = new GI.Framework.frmSeleccionador(new Propiedades.SeleccionadorPropiedades(typeof(GI.BR.Propiedades.Alquiler)));
                if (frmSeleccionador.ShowDialog() == DialogResult.OK)
                {
                    LinkPropiedad.Tag = (GI.BR.Propiedades.Propiedad)frmSeleccionador.ObjetoSeleccionado;
                    LinkPropiedad.Text = ((GI.BR.Propiedades.Propiedad)frmSeleccionador.ObjetoSeleccionado).Codigo.ToString();
                    ctrlDireccion1.Direccion = ((GI.BR.Propiedades.Propiedad)frmSeleccionador.ObjetoSeleccionado).Direccion;
                    if(((GI.BR.Propiedades.Propiedad)LinkPropiedad.Tag).Propietario != null)
                        cBoxEsPropietario.Enabled = true;
                }

            }
            else
            {
                if (LinkPropiedad.Tag != null)
                {
                    Propiedades.frmFichaPropiedad frm = new GI.UI.Propiedades.frmFichaPropiedad();
                    frm.SoloLectura = SoloLectura;
                    frm.Propiedad = (GI.BR.Propiedades.Propiedad)LinkPropiedad.Tag;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LinkPropiedad.Text = frm.Propiedad.Codigo.ToString();
                    }

                }
            }
        }

        private void LinkPropietario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LinkPropietario.Text == "Seleccione un Contacto")
            {
                Framework.frmSeleccionador frmSeleccionador = new GI.Framework.frmSeleccionador(new Clientes.SeleccionadorPropietarios(typeof(GI.BR.Clientes.Propietario)));
                if (frmSeleccionador.ShowDialog() == DialogResult.OK)
                {
                    LinkPropietario.Tag = (GI.BR.Clientes.Propietario)frmSeleccionador.ObjetoSeleccionado;
                    LinkPropietario.Text = ((GI.BR.Clientes.Propietario)frmSeleccionador.ObjetoSeleccionado).ToString();
                }

            }
            else
            {
                if (LinkPropietario.Tag != null)
                {
                    Clientes.frmFichaCliente frm = new GI.UI.Clientes.frmFichaCliente();
                    frm.SoloLectura = SoloLectura;
                    frm.Cliente = (GI.BR.Clientes.Cliente)LinkPropietario.Tag;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LinkPropietario.Text = frm.Cliente.ToString();
                    }

                }
            }
        }

        private void LinkInquilino_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LinkInquilino.Text == "Seleccione un Inquilino")
            {
                Framework.frmSeleccionador frmSeleccionador = new GI.Framework.frmSeleccionador(new Clientes.SeleccionadorPropietarios(typeof(GI.BR.Clientes.Inquilino)));
                if (frmSeleccionador.ShowDialog() == DialogResult.OK)
                {
                    LinkInquilino.Tag = (GI.BR.Clientes.Inquilino)frmSeleccionador.ObjetoSeleccionado;
                    LinkInquilino.Text = frmSeleccionador.ObjetoSeleccionado.ToString();
                }

            }
            else
            {
                if (LinkInquilino.Tag != null)
                {
                    Clientes.frmFichaCliente frm = new GI.UI.Clientes.frmFichaCliente();
                    frm.SoloLectura = SoloLectura;
                    frm.Cliente = (GI.BR.Clientes.Cliente)LinkInquilino.Tag;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LinkInquilino.Tag = (GI.BR.Clientes.Inquilino)frm.Cliente;
                        LinkInquilino.Text = frm.Cliente.ToString();
                    }
                }
            }
        }

        private void TabDatosPrincipales_Load(object sender, EventArgs e)
        {

        }

        private void cBoxEsPropietario_CheckedChanged(object sender, EventArgs e)
        {

            if (cBoxEsPropietario.Checked == true)
            {
                LinkPropietario.Tag = ((GI.BR.Propiedades.Propiedad)LinkPropiedad.Tag).Propietario;
                LinkPropietario.Text = ((GI.BR.Propiedades.Propiedad)LinkPropiedad.Tag).Propietario.ToString();
            }
            else
            {
                LinkPropietario.Tag = null;
                LinkPropietario.Text = "Seleccione un Contacto";
            }

        }
    }
}
