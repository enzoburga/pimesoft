using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades.Formularios
{
    public partial class FrmLlamado : Framework.Seguridad.FrmGISeguridad
    {

        private GI.BR.Propiedades.Llamado llamado;

        public FrmLlamado()
        {
            InitializeComponent();
        }

        public FrmLlamado(GI.BR.Propiedades.Llamado Llamado)
            : this()
        {
            llamado = Llamado;

            dateTimePickerFecha.Value = llamado.FechaHora;
            textBoxVisitante.Text = llamado.Contacto;
            textBoxTelefonoContacto.Text = llamado.Telefono;
            textBoxDetalle.Text = llamado.Comentario;


        
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


        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (textBoxVisitante.Text == "")
            {
                Framework.General.GIMsgBox.Show("Debe ingresar una nombre", GI.Framework.General.enumTipoMensaje.Error);
                textBoxVisitante.Focus();
                return;
            }


            llamado.Comentario = textBoxDetalle.Text;
            llamado.Contacto = textBoxVisitante.Text;
            llamado.FechaHora = dateTimePickerFecha.Value;
            llamado.Telefono = textBoxTelefonoContacto.Text;


            if (llamado.IdLlamado == 0)
            {
                if (!llamado.Guardar())
                {
                    Framework.General.GIMsgBox.Show("No es posible guardar el llamado", GI.Framework.General.enumTipoMensaje.Error);
                    return;
                }

            }
            else
            {
                if (!llamado.Actualizar())
                {
                    Framework.General.GIMsgBox.Show("No es posible guardar el llamado", GI.Framework.General.enumTipoMensaje.Error);
                    return;
                }
            }


            DialogResult = DialogResult.OK;
            Close();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}