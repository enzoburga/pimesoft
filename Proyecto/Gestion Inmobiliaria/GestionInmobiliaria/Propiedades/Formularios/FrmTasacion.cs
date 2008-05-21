using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades.Formularios
{
    public partial class FrmTasacion : Framework.Seguridad.FrmGISeguridad
    {

        private GI.BR.Propiedades.Tasacion tasacion;

        public FrmTasacion()
        {
            InitializeComponent();

            GI.BR.Monedas.Monedas monedas = new GI.BR.Monedas.Monedas();
            monedas.RecuperarTodas();
            foreach (GI.BR.Monedas.Moneda m in monedas)
            {
                cbMonedaValorPublicacion.Items.Add(m);
                cbMonedaValorReal.Items.Add(m);
            }

            cbMonedaValorPublicacion.SelectedIndex = 0;
            cbMonedaValorReal.SelectedIndex = 0;


        }


        public FrmTasacion(GI.BR.Propiedades.Tasacion Tasacion)
            : this()
        {

            tasacion = Tasacion;

            if (tasacion.IdTasacion == 0)
            {
                tasacion.ValorPublicacion.Moneda = (GI.BR.Monedas.Moneda)cbMonedaValorPublicacion.SelectedItem;
                tasacion.ValorReal.Moneda = (GI.BR.Monedas.Moneda)cbMonedaValorReal.SelectedItem;
            }



            valorBindingSource.Add(tasacion.ValorReal);
            valorBindingSource1.Add(tasacion.ValorPublicacion);
            tasacionBindingSource.Add(tasacion);

            dateTimePickerFecha.Value = tasacion.Fecha;



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


            tasacion.Fecha = dateTimePickerFecha.Value;


            if (tasacion.IdTasacion == 0)
            {
                if (!tasacion.Crear())
                {
                    Framework.General.GIMsgBox.Show("No es posible guardar la tasación", GI.Framework.General.enumTipoMensaje.Error);
                    return;
                }

            }
            else
            {
                if (!tasacion.Modificar())
                {
                    Framework.General.GIMsgBox.Show("No es posible guardar la tasacion", GI.Framework.General.enumTipoMensaje.Error);
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