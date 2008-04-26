using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades
{
    public partial class frmFichaPropiedad : Framework.Seguridad.FrmGISeguridad
    {

        private GI.BR.Propiedades.Propiedad propiedad;
        private GI.BR.Propiedades.Propiedad propiedadClone;


        public frmFichaPropiedad()
        {
            InitializeComponent();
            Inicializar();
        }

        #region Propiedades


        public GI.BR.Propiedades.Propiedad Propiedad
        {
            get { return propiedad; }
            set
            {

                propiedad = value;
                propiedadClone = (GI.BR.Propiedades.Propiedad)propiedad.Clone();
                this.Text += " " + propiedad.Codigo.ToString();

                foreach (System.Windows.Forms.TabPage Page in this.tabControl.TabPages)
                {
                    if (Page.Controls.Count != 1) continue;
                    if (Page.Controls[0] is TabContenidoPropiedad)
                        ((TabContenidoPropiedad)Page.Controls[0]).Propiedad = propiedad;
                   
                }

            }
        }

        #endregion

        #region Metoros Privados

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

        public void Inicializar()
        {

            System.Windows.Forms.TabPage tabPage;
            System.Windows.Forms.Control control;

            tabPage = new TabPage("Propiedad");
            control = new TabPropiedad();
            control.Dock = DockStyle.Fill;
            tabPage.Controls.Add(control);
            tabControl.TabPages.Add(tabPage);


            tabPage = new TabPage("Detalles");
            control = new TabDetalles();
            control.Dock = DockStyle.Fill;
            tabPage.Controls.Add(control);
            tabControl.TabPages.Add(tabPage);


            tabPage = new TabPage("Notas");
            control = new TabNotas();
            control.Dock = DockStyle.Fill;
            tabPage.Controls.Add(control);
            tabControl.TabPages.Add(tabPage);


            tabPage = new TabPage("Visitas");
            control = new TabVisitas();
            control.Dock = DockStyle.Fill;
            tabPage.Controls.Add(control);
            tabControl.TabPages.Add(tabPage);

            tabPage = new TabPage("Llamados");
            control = new TabVisitas();
            control.Dock = DockStyle.Fill;
            tabPage.Controls.Add(control);
            tabControl.TabPages.Add(tabPage);

            tabPage = new TabPage("Publicaciones");
            control = new TabPublicaciones();
            control.Dock = DockStyle.Fill;
            tabPage.Controls.Add(control);
            tabControl.TabPages.Add(tabPage);


            tabPage = new TabPage("Pedidos");
            control = new TabPedidos();
            control.Dock = DockStyle.Fill;
            tabPage.Controls.Add(control);
            tabControl.TabPages.Add(tabPage);


            tabPage = new TabPage("Tasaciones");
            control = new TabTasaciones();
            control.Dock = DockStyle.Fill;
            tabPage.Controls.Add(control);
            tabControl.TabPages.Add(tabPage);

            tabPage = new TabPage("Galería");
            control = new TabGaleriaFotos();
            control.Dock = DockStyle.Fill;
            tabPage.Controls.Add(control);
            tabControl.TabPages.Add(tabPage);


           

        }

        
        #endregion

        private void bCancelar_Click(object sender, EventArgs e)
        {
            propiedad = (GI.BR.Propiedades.Propiedad)propiedadClone.Clone();
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                bool guardado = false;
                if (!SoloLectura)
                {
                    foreach (System.Windows.Forms.TabPage Page in this.tabControl.TabPages)
                    {
                        if (Page.Controls[0] is TabContenidoPropiedad)
                            propiedad = ((TabContenidoPropiedad)Page.Controls[0]).GetPropiedad();


                    }


                    if (Propiedad.IdPropiedad == 0)
                        guardado = Propiedad.Guardar();
                    else
                        guardado = Propiedad.Actualizar();

                    if (!guardado)
                        throw new Exception("No se puede grabar la propiedad");


                    DialogResult = DialogResult.OK;
                    Close();

                }

            }
            catch (Exception ex)
            {

                Framework.General.GIMsgBox.Show(ex.Message, GI.Framework.General.enumTipoMensaje.Error);
            }

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool guardado = false;
            if (SoloLectura)
            {
                GI.Framework.General.GIMsgBox.ShowSoloLectura();
                return;
            }
            try
            {
                foreach (System.Windows.Forms.TabPage Page in this.tabControl.TabPages)
                {
                    if (Page.Controls[0] is TabContenidoPropiedad)
                        propiedad = ((TabContenidoPropiedad)Page.Controls[0]).GetPropiedad();


                }


                if (Propiedad.IdPropiedad == 0)
                    guardado = Propiedad.Guardar();
                else
                    guardado = Propiedad.Actualizar();

                if (!guardado)
                    throw new Exception("No se puede grabar la propiedad");
        

            }
            catch (Exception ex)
            {
                GI.Framework.General.GIMsgBox.Show(ex.Message, GI.Framework.General.enumTipoMensaje.Error);

            }
        }
    }
}