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

            ctrlDireccion1.SoloLectura = true;
            ctrlDireccion1.RefrezcarSoloLectura(ctrlDireccion1.Controls);

            if (AdmAlquiler.Alquiler == null)
            {
                LinkPropiedad.Text = "Seleccione una Propiedad";
                LinkPropietario.Text = "Seleccione una Propiedad";
                LinkPropietario.Enabled = false;
            }
            else
            {
                if (AdmAlquiler.Alquiler.Propietario == null)
                {
                    LinkPropietario.Text = "Seleccione una Propiedad";
                    LinkPropietario.Enabled = false;
                }
                else
                {
                    LinkPropietario.Text = AdmAlquiler.Alquiler.Propietario.ToString();
                    LinkPropietario.Enabled = true;
                }

                propiedadBindingSource.Add(AdmAlquiler.Alquiler);
                LinkPropiedad.Text = AdmAlquiler.Alquiler.Codigo.ToString();
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

                    if (((GI.BR.Propiedades.Propiedad)frmSeleccionador.ObjetoSeleccionado).Propietario != null)
                    {
                        LinkPropietario.Text = ((GI.BR.Propiedades.Propiedad)frmSeleccionador.ObjetoSeleccionado).Propietario.ToString();
                        LinkPropietario.Tag = ((GI.BR.Propiedades.Propiedad)frmSeleccionador.ObjetoSeleccionado).Propietario;
                    }
                    else
                    {
                        LinkPropietario.Text = "Propiedad sin propietario, haga click aqui para asignar uno.";
                        
                    }
                    LinkPropietario.Enabled = true;
                   
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
                        LinkPropiedad.Text = frm.Propiedad.ToString();
                    }

                }
            }
        }

        private void LinkPropietario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LinkPropietario.Text == "Propiedad sin propietario, haga click aqui para asignar uno.")
            {
                Framework.frmSeleccionador frmSeleccionador = new GI.Framework.frmSeleccionador(new Clientes.SeleccionadorPropietarios(typeof(GI.BR.Clientes.Propietario)));
                if (frmSeleccionador.ShowDialog() == DialogResult.OK)
                {
                    LinkPropietario.Tag = (GI.BR.Clientes.Propietario)frmSeleccionador.ObjetoSeleccionado;
                    LinkPropietario.Text = ((GI.BR.Clientes.Propietario)frmSeleccionador.ObjetoSeleccionado).ToString();
                    if (!VincularPropietarioConPropiedad((GI.BR.Clientes.Propietario)LinkPropietario.Tag, (GI.BR.Propiedades.Propiedad)LinkPropiedad.Tag))
                    {
                        GI.Framework.General.GIMsgBox.Show("No se pudo asociar el propietario a la propiedad.", GI.Framework.General.enumTipoMensaje.Advertencia);
                    }
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

        private bool VincularPropietarioConPropiedad(GI.BR.Clientes.Propietario propietario, GI.BR.Propiedades.Propiedad propiedad)
        {
            propiedad.Propietario = propietario;
            return propiedad.Actualizar();
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
    }
}
