using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades.Formularios
{
    public partial class FrmPublicacion : Framework.Seguridad.FrmGISeguridad
    {

        private GI.BR.Propiedades.Publicacion publicacion;

        public FrmPublicacion(GI.BR.Propiedades.Publicacion Publicacion)
            : this()
        {
            publicacion = Publicacion;


            this.dateTimePickerFecha.Value = publicacion.Fecha;
            this.textBoxComentarios.Text = publicacion.Detalles;
            this.textBoxMedio.Text = publicacion.Medio;
            this.textBoxValor.Text = publicacion.ValorPublicacion.Importe.ToString();



            if (publicacion.ValorPublicacion.Moneda != null)
            {
                foreach (GI.BR.Monedas.Moneda m in comboBoxMonedas.Items)
                {
                    if (m.IdMoneda == publicacion.ValorPublicacion.Moneda.IdMoneda)
                    {
                        comboBoxMonedas.SelectedItem = m;
                        break;
                    }
                }
            }
        }



        public FrmPublicacion()
        {
            InitializeComponent();


            GI.BR.Monedas.Monedas monedas = new GI.BR.Monedas.Monedas();
            monedas.RecuperarTodas();
            foreach (GI.BR.Monedas.Moneda m in monedas)
                comboBoxMonedas.Items.Add(m);
            comboBoxMonedas.SelectedIndex = 0;
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

            if (textBoxMedio.Text == "")
            {
                Framework.General.GIMsgBox.Show("Debe ingresar un medio de publicación", GI.Framework.General.enumTipoMensaje.Error);
                textBoxMedio.Focus();
                return;
            }
            
            decimal importe = 0;
            if (!Decimal.TryParse(textBoxValor.Text, out importe))
            {
                Framework.General.GIMsgBox.Show("El importe debe ser un valor numérico", GI.Framework.General.enumTipoMensaje.Error);
                textBoxValor.Focus();
                return;
            }



            publicacion.Fecha = dateTimePickerFecha.Value;
            publicacion.Detalles = textBoxComentarios.Text;
            publicacion.Medio = textBoxMedio.Text;
            publicacion.ValorPublicacion.Importe = importe;
            publicacion.ValorPublicacion.Moneda = (GI.BR.Monedas.Moneda)comboBoxMonedas.SelectedItem;

            if (publicacion.IdPublicacion == 0)
            {
                if (!publicacion.Crear())
                {
                    Framework.General.GIMsgBox.Show("No es posible guardar la publicación", GI.Framework.General.enumTipoMensaje.Error);
                    return;
                }
            }
            else
            {
                if (!publicacion.Actualizar())
                {
                    Framework.General.GIMsgBox.Show("No es posible guardar la publicación", GI.Framework.General.enumTipoMensaje.Error);
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