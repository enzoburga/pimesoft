using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Inmobiliarias
{
    public partial class FrmInmobiliariaExterna : Framework.Seguridad.FrmGISeguridad
    {
        private GI.BR.InmobiliariaExterna inmobiliaria;

        public FrmInmobiliariaExterna()
        {
            InitializeComponent();
        }

        public FrmInmobiliariaExterna(GI.BR.InmobiliariaExterna Inmobiliaria)
            : this()
        {
            inmobiliaria = Inmobiliaria;
            inmobiliariaExternaBindingSource.Add(inmobiliaria);
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

            bool retVal = false;

            if (inmobiliaria.IdInmobiliaria == 0)
                retVal = inmobiliaria.Crear();
            else
                retVal = inmobiliaria.Actualizar();

            if (!retVal)
            {
                Framework.General.GIMsgBox.Show("Los datos no se han podido guardar", GI.Framework.General.enumTipoMensaje.Error);
                return;
            }


            DialogResult = DialogResult.OK;
            Close();



        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            if (!SoloLectura)
            {
                if (Framework.General.GIMsgBox.Show("¿Desea salir sin guardar los cambios?", GI.Framework.General.enumTipoMensaje.PreguntaSinCancelar) == DialogResult.Yes)
                {
                    DialogResult = DialogResult.Cancel;
                    Close();
                }
            }
            else
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }
    }
}