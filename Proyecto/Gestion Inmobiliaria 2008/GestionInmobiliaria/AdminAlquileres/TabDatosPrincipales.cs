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

        public override bool AsignarSoloLectura(Control Ctrl)
        {
            
            if (Ctrl.Name == "LinkPropietario" && Ctrl.Text != "Seleccione un Contacto")
                return false;

            if (Ctrl.Name == "LinkPropiedad" && Ctrl.Text != "Seleccione una Propiedad")
                return false;

            return base.AsignarSoloLectura(Ctrl);
        }

        protected override void Inicializar()
        {

            admAlquilerBindingSource.Add(AdmAlquiler);

            ctrlDireccion1.SoloLectura = true;
            ctrlDireccion1.RefrezcarSoloLectura(ctrlDireccion1.Controls);

            if (AdmAlquiler.Contacto == null)
                LinkPropietario.Text = "Seleccione un Contacto";
            else
            {
                LinkPropietario.Text = AdmAlquiler.Contacto.ToString();
                LinkPropietario.Tag = AdmAlquiler.Contacto;
                //if (AdmAlquiler.Alquiler.Propietario.IdCliente == AdmAlquiler.Contacto.IdCliente)
                //    cBoxEsPropietario.Checked = true;
            }

            if (AdmAlquiler.Alquiler == null)
            {
                LinkPropiedad.Text = "Seleccione una Propiedad";
                cBoxEsPropietario.Enabled = false;
            }
            else
            {
                propiedadBindingSource.Add(AdmAlquiler.Alquiler);
                LinkPropiedad.Text = AdmAlquiler.Alquiler.Codigo.ToString();
                ctrlDireccion1.Direccion = AdmAlquiler.Alquiler.Direccion;
                cBoxEsPropietario.Enabled = true;
                
            }
            
            //asignar contrato a control.
            this.ctrlContrato1.Contrato = AdmAlquiler.ContratoVigente;
        }


        private void LinkPropiedad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LinkPropiedad.Text == "Seleccione una Propiedad")
            {
                Framework.frmSeleccionador frmSeleccionador = new GI.Framework.frmSeleccionador(new Propiedades.SeleccionadorPropiedades(typeof(GI.BR.Propiedades.Alquiler)));
                if (frmSeleccionador.ShowDialog() == DialogResult.OK)
                {
                    LinkPropiedad.Tag = (GI.BR.Propiedades.Propiedad)frmSeleccionador.ObjetoSeleccionado;
                    this.AdmAlquiler.Alquiler = (GI.BR.Propiedades.Alquiler)frmSeleccionador.ObjetoSeleccionado;
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
                    AdmAlquiler.Contacto = (GI.BR.Clientes.Propietario)frmSeleccionador.ObjetoSeleccionado;
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

        private bool noResetearContacto = false;
        private void cBoxEsPropietario_CheckedChanged(object sender, EventArgs e)
        {

            if (cBoxEsPropietario.Checked == true)
            {
                if (((GI.BR.Propiedades.Propiedad)LinkPropiedad.Tag).Propietario == null)
                {
                    GI.Framework.General.GIMsgBox.Show("La propiedad no posee ningun propietario asociado.", GI.Framework.General.enumTipoMensaje.Advertencia);
                    noResetearContacto = true;
                    cBoxEsPropietario.Checked = false;
                    return;
                }
                LinkPropietario.Tag = ((GI.BR.Propiedades.Propiedad)LinkPropiedad.Tag).Propietario;
                LinkPropietario.Text = ((GI.BR.Propiedades.Propiedad)LinkPropiedad.Tag).Propietario.ToString();
                this.AdmAlquiler.Contacto = ((GI.BR.Propiedades.Propiedad)LinkPropiedad.Tag).Propietario;
            }
            else
            {
                if (noResetearContacto)
                {
                    noResetearContacto = false;
                    return;
                }
                LinkPropietario.Tag = null;
                this.AdmAlquiler.Contacto = null;
                LinkPropietario.Text = "Seleccione un Contacto";
            }

        }
    }
}
