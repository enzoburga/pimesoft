using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Carteles
{
    public partial class frmFichaCarteles : GI.Framework.Seguridad.FrmGISeguridad
    {
        public frmFichaCarteles()
        {
            InitializeComponent();
        }

        private GI.BR.Carteles.Cartel cartel;

        public GI.BR.Carteles.Cartel Cartel
        {
            get { return cartel; }
            set
            {
                cartel = value;
                Inicializar();
                CargarCartel();
            }
        }

        private void Inicializar()
        {
            foreach (GI.BR.Carteles.UbicacionCartel uc in GI.BR.Carteles.UbicacionesCartelFlyweigthFactory.GetInstancia.GetUbicacionesCartel)
            {
                cbUbicacion.Items.Add(uc);
            }
            cbUbicacion.SelectedIndex = 0;
        }

        private void CargarCartel()
        {
            if (this.cartel.Propiedad != null)
            {
                this.llPropiedad.Text = this.cartel.Propiedad.Codigo.ToString();
                this.llPropiedad.Tag = this.cartel.Propiedad;
            }
            else
                this.llPropiedad.Text = "Seleccione una Propiedad";

            this.tbAlto.Text = this.cartel.Alto.ToString();
            this.tbAncho.Text = this.cartel.Ancho.ToString();

            this.dtpFechaAlta.Value = this.cartel.FechaAlta;

            this.dtpFechaVencimiento.Value = this.cartel.FechaVencimiento;

            this.cbActivo.Checked = this.cartel.Activo;

            this.cartel.UbicacionCartel = (GI.BR.Carteles.UbicacionCartel)cbUbicacion.SelectedItem;

            foreach(GI.BR.Carteles.UbicacionCartel uc in cbUbicacion.Items)
            {
                if(uc.IdUbicacionCartel == cartel.UbicacionCartel.IdUbicacionCartel)
                {
                    this.cbUbicacion.SelectedItem = uc;
                }
            }
            
        }

        public GI.BR.Carteles.Cartel GetCartel()
        {
            int Alto = 0;
            int Ancho = 0;
            cartel.Activo = cbActivo.Checked;

            if (tbAlto.Text == "")
                cartel.Alto = 0;
            else
            {
                if (int.TryParse(tbAlto.Text, out Alto))
                    cartel.Alto = Alto;
                else
                    throw new Exception("El alto es un campo numérico.");
            }

            if (tbAncho.Text == "")
                cartel.Ancho = 0;
            else
            {
                if (int.TryParse(tbAncho.Text, out Ancho))
                    cartel.Ancho = Ancho;
                else
                    throw new Exception("El ancho es un campo numérico.");
            }

            cartel.FechaAlta = dtpFechaAlta.Value;
            cartel.FechaVencimiento = dtpFechaVencimiento.Value;

            if(llPropiedad.Tag == null)
                throw new Exception("Debe seleccionar una propiedad.");

            cartel.Propiedad = (GI.BR.Propiedades.Propiedad)llPropiedad.Tag;
            cartel.TipoCartel = llPropiedad.Tag.GetType();

            cartel.UbicacionCartel = (GI.BR.Carteles.UbicacionCartel)cbUbicacion.SelectedItem;

            return cartel;
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool guardado = false;

            try
            {
                if (cartel.IdCartel == 0)
                    guardado = GetCartel().Guardar();
                else
                    guardado = GetCartel().Actualizar();
            }
            catch (Exception ex)
            {
                GI.Framework.General.GIMsgBox.Show(ex.Message, GI.Framework.General.enumTipoMensaje.Error);
            }


        }

        private void cAceptar_Click(object sender, EventArgs e)
        {
            bool guardado = false;

            try
            {
                if (cartel.IdCartel == 0)
                    guardado = GetCartel().Guardar();
                else
                    guardado = GetCartel().Actualizar();

                if (guardado)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                GI.Framework.General.GIMsgBox.Show(ex.Message, GI.Framework.General.enumTipoMensaje.Error);
            }

        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void llPropiedad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (llPropiedad.Text == "Seleccione una Propiedad")
            {
                Framework.frmSeleccionador frmSeleccionador = new GI.Framework.frmSeleccionador(new Propiedades.SeleccionadorPropiedades(cartel.TipoCartel));
                if (frmSeleccionador.ShowDialog() == DialogResult.OK)
                {
                    llPropiedad.Tag = (GI.BR.Propiedades.Propiedad)frmSeleccionador.ObjetoSeleccionado;
                    this.cartel.Propiedad = (GI.BR.Propiedades.Propiedad)frmSeleccionador.ObjetoSeleccionado;
                    llPropiedad.Text = ((GI.BR.Propiedades.Propiedad)frmSeleccionador.ObjetoSeleccionado).Codigo.ToString();

                }

            }
            else
            {
                if (llPropiedad.Tag != null)
                {
                    Propiedades.frmFichaPropiedad frm = new GI.UI.Propiedades.frmFichaPropiedad();
                    frm.SoloLectura = SoloLectura;
                    frm.Propiedad = (GI.BR.Propiedades.Propiedad)llPropiedad.Tag;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        llPropiedad.Text = frm.Propiedad.Codigo.ToString();
                    }

                }
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bCancelar_Click(sender, e);
        }
    }
}