using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades
{
    public partial class TabGaleriaFotos : TabContenidoPropiedad
    {
        public TabGaleriaFotos()
        {
            InitializeComponent();
        }



        public override GI.BR.Propiedades.Propiedad GetPropiedad()
        {
            return Propiedad;
        }

        protected override void Inicializar()
        {


        }

        protected override void CargarPropiedad()
        {


            if (Propiedad == null || Propiedad.IdPropiedad == 0)
                return;

            cbFotos.Items.Clear();

            foreach (GI.BR.Propiedades.Galeria.Foto f in Propiedad.GaleriaFotos)
            {
                cbFotos.Items.Add(f);
            
            }
            if (cbFotos.Items.Count > 0)
                cbFotos.SelectedIndex = 0;



        }


        private void linkLabelAgregarFoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (Propiedad.IdPropiedad == 0)
            {

                Framework.General.GIMsgBox.Show("Debe primero guardar la propiedad para subir fotos", GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }


            Formularios.FrmFoto frm = new GI.UI.Propiedades.Formularios.FrmFoto(Propiedad);
            if (frm.ShowDialog() == DialogResult.OK)
            {

                cbFotos.Items.Clear();
                pictureBox1.Image = null;
                Propiedad.GaleriaFotos.RecuperarPorPropiedad(Propiedad);
                foreach (GI.BR.Propiedades.Galeria.Foto f in Propiedad.GaleriaFotos)
                {
                    
                    cbFotos.Items.Add(f);

                    if (f.IdFoto == frm.GetFoto.IdFoto)
                        cbFotos.SelectedItem = f;

                }
            
            }



        }

        private void cbFotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFotos.SelectedItem == null) return;


            pictureBox1.Image = ((GI.BR.Propiedades.Galeria.Foto)cbFotos.SelectedItem).Imagen;

        }

        private void linkLabelEliminarFoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cbFotos.SelectedItem == null)
            {
                Framework.General.GIMsgBox.Show("No hay una foto seleccionada para eliminar", GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }

            ((GI.BR.Propiedades.Galeria.Foto)cbFotos.SelectedItem).Eliminar();
            Propiedad.GaleriaFotos.RecuperarPorPropiedad(Propiedad);
            cbFotos.Items.Clear();
            pictureBox1.Image = null;
            foreach (GI.BR.Propiedades.Galeria.Foto f in Propiedad.GaleriaFotos)
            {
                cbFotos.Items.Add(f);

            }
            if (cbFotos.Items.Count > 0)
                cbFotos.SelectedIndex = 0;
        }
    }
}
