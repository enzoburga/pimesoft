using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades.Formularios
{
    public partial class frmVisita : Framework.Seguridad.FrmGISeguridad
    {

        private GI.BR.Propiedades.VisitaPropiedad visita;

        public frmVisita()
        {
            InitializeComponent();
            inicializar();
        }

        public frmVisita(GI.BR.Propiedades.VisitaPropiedad Visita)
            : this()
        {
            visita = Visita;

            this.dateTimePickerFecha.Value = visita.FechaHora;
            this.checkBoxAlarma.Checked = visita.ConAlarma;
            this.checkBoxRealizada.Checked = visita.Realizada;
            
            this.textBoxDetalle.Text = visita.Detalles;
            this.textBoxTelefonoContacto.Text = visita.TelefonoContacto;
            this.textBoxVisitante.Text = visita.Visita;

            foreach (GI.BR.Propiedades.TiempoAlarma t in cbAviso.Items)
            {
                if (t.Tiempo.Ticks == visita.TiempoAlarma.Tiempo.Ticks)
                {
                    cbAviso.SelectedItem = t;
                    break;
                }
            }







        }


        private void inicializar()
        {
            GI.BR.Propiedades.TiemposAlarmaFactory tiempos = new GI.BR.Propiedades.TiemposAlarmaFactory();
            foreach (GI.BR.Propiedades.TiempoAlarma t in tiempos.RecuperarTodos())
            {
                cbAviso.Items.Add(t);
            }

            cbAviso.SelectedIndex = 0;
        }

        public override bool AsignarSoloLectura(Control Ctrl)
        {
            if (Ctrl.Name == "bAceptar") return true;

            if (Ctrl.Name == "bCancelar")
            {
                Ctrl.Text = "Cerrar";
                return false;
            }

            return base.AsignarSoloLectura(Ctrl);
        }

        private void checkBoxAlarma_CheckedChanged(object sender, EventArgs e)
        {
            cbAviso.Enabled = checkBoxAlarma.Checked;

        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (textBoxVisitante.Text == "")
            {
                Framework.General.GIMsgBox.Show("Debe ingresar una nombre", GI.Framework.General.enumTipoMensaje.Error);
                textBoxVisitante.Focus();
                return;
            }

            this.visita.FechaHora = dateTimePickerFecha.Value;
            this.visita.ConAlarma = checkBoxAlarma.Checked;
            this.visita.Realizada = checkBoxRealizada.Checked;
            this.visita.TiempoAlarma = (GI.BR.Propiedades.TiempoAlarma)cbAviso.SelectedItem;
            this.visita.Detalles = textBoxDetalle.Text;
            this.visita.Visita = textBoxVisitante.Text;
            this.visita.TelefonoContacto = textBoxTelefonoContacto.Text;

            if (visita.IdVisita == 0)
            {
                if (!visita.Guardar())
                {
                    Framework.General.GIMsgBox.Show("No es posible guardar la visita", GI.Framework.General.enumTipoMensaje.Error);
                    return;
                }
            
            }
            else
            {
                if (!visita.Actualizar())
                {
                    Framework.General.GIMsgBox.Show("No es posible guardar la visita", GI.Framework.General.enumTipoMensaje.Error);
                    return;
                }
            }


            DialogResult = DialogResult.OK;
            Close();
           
        }
    }
}