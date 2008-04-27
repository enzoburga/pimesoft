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
            
            MontoBindingSource.Add(AdmAlquiler.ContratoVigente.Monto);
            DepositoBindingSource.Add(AdmAlquiler.ContratoVigente.Deposito);
            contratoBindingSource.Add(AdmAlquiler.ContratoVigente);


            if (AdmAlquiler.Alquiler != null)
            {
                if (AdmAlquiler.Alquiler.Propietario == null)
                    LinkPropietario.Text = "Seleccione un propietario";
                else
                {
                    LinkPropietario.Text = AdmAlquiler.Alquiler.Propietario.ToString();

                }

                if (AdmAlquiler.Alquiler == null)
                    LinkPropiedad.Text = "Seleccione una propiedad";
                else
                {
                    propiedadBindingSource.Add(AdmAlquiler.Alquiler);
                    LinkPropiedad.Text = AdmAlquiler.Alquiler.Codigo.ToString();

                }
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
            if (LinkPropiedad.Text == "Seleccione una Propiedad")
            {
                Framework.frmSeleccionador frmSeleccionador = new GI.Framework.frmSeleccionador(new Propiedades.SeleccionadorPropiedades(typeof(GI.BR.Propiedades.Alquiler)));
                if (frmSeleccionador.ShowDialog() == DialogResult.OK)
                {
                    LinkPropiedad.Tag = (GI.BR.Propiedades.Propiedad)frmSeleccionador.ObjetoSeleccionado;
                    LinkPropiedad.Text = ((GI.BR.Propiedades.Propiedad)frmSeleccionador.ObjetoSeleccionado).Codigo.ToString();
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
            if (LinkPropietario.Text == "Seleccione un Propietario")
            {
                Framework.frmSeleccionador frmSeleccionador = new GI.Framework.frmSeleccionador(new Clientes.SeleccionadorPropietarios(typeof(GI.BR.Clientes.Propietario)));
                if (frmSeleccionador.ShowDialog() == DialogResult.OK)
                {
                    LinkPropietario.Tag = (GI.BR.Clientes.Propietario)frmSeleccionador.ObjetoSeleccionado;
                    LinkPropietario.Text = frmSeleccionador.ObjetoSeleccionado.ToString();
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
            LinkPropietario_LinkClicked(null, null);
        }

        private void TabDatosPrincipales_Load(object sender, EventArgs e)
        {
            Inicializar();
        }
    }
}
