using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Pedidos
{
    public partial class frmFichaPedidos : GI.Framework.Seguridad.FrmGISeguridad
    {
        public frmFichaPedidos()
        {
            InitializeComponent();
            Inicializar();
        }

        private GI.BR.Pedidos.Pedido pedido;
        private GI.BR.Pedidos.Pedido pedidoClone;


        public GI.BR.Pedidos.Pedido Pedido
        {
            get { return pedido; }
            set
            {

                pedido = value;
                pedidoClone = (GI.BR.Pedidos.Pedido)pedido.Clone();
                if(pedido.EstadoPropiedad == typeof(GI.BR.Propiedades.Venta))
                    this.Text = "Pedido de Venta";
                else
                    this.Text = "Pedido de Alquiler";

                InicializarTabs();

            }
        }

        private void Inicializar()
        {
            System.Windows.Forms.TabPage tabPage;
            System.Windows.Forms.Control control;

            tabPage = new TabPage("Datos Principales");
            control = new TabDatosPrincipales();
            control.Dock = DockStyle.Fill;
            tabPage.Controls.Add(control);
            tabControl.TabPages.Add(tabPage);

            tabPage = new TabPage("Propiedades ofrecidas");
            control = new TabPropiedadesOfrecidas();
            control.Dock = DockStyle.Fill;
            tabPage.Controls.Add(control);
            tabControl.TabPages.Add(tabPage);

            tabPage = new TabPage("Propiedades sin ofrecer");
            control = new TabPropiedadesSinOfrecer();
            control.Dock = DockStyle.Fill;
            tabPage.Controls.Add(control);
            tabControl.TabPages.Add(tabPage);


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

        private void bCancelar_Click(object sender, EventArgs e)
        {
            if (CambioDatosPedido())
                switch (GI.Framework.General.GIMsgBox.ShowCancelarPerdidaDatos())
                {
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.Yes:
                        bAceptar_Click(null, null);
                        DialogResult = DialogResult.OK;
                        this.Close();
                        break;
                    case DialogResult.No:
                        pedido = (GI.BR.Pedidos.Pedido)pedidoClone.Clone();
                        DialogResult = DialogResult.Cancel;
                        Close();
                        break;//Cierro.
                }

            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool CambioDatosPedido()
        {
            return false;
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            bool guardado = false;
            Validate();

            if (SoloLectura)
            {
                GI.Framework.General.GIMsgBox.ShowSoloLectura();
                return;
            }
            try
            {
                ((TabDatosPrincipales)tabControl.TabPages[0].Controls[0]).Validar();

                if (pedido.IdPedido == 0)
                    guardado = ((TabDatosPrincipales)tabControl.TabPages[0].Controls[0]).getPedido().Guardar();
                else
                    guardado = ((TabDatosPrincipales)tabControl.TabPages[0].Controls[0]).getPedido().Actualizar();

                if (guardado)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    GI.Framework.General.GIMsgBox.Show("No se han guardado los cambios.", GI.Framework.General.enumTipoMensaje.Error);

                }
            }
            catch (Exception ex)
            {
                GI.Framework.General.GIMsgBox.Show(ex.Message, GI.Framework.General.enumTipoMensaje.Error);

            }
        }
        
        private void InicializarTabs()
        {
            foreach (System.Windows.Forms.TabPage Page in this.tabControl.TabPages)
            {
                if (Page.Controls.Count != 1) continue;
                if (Page.Controls[0] is TabContenidoPedidos)
                    ((TabContenidoPedidos)Page.Controls[0]).Pedido = Pedido;
            }
        }


        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bCancelar_Click(sender, e);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Validate();
            bool guardado = false;


            if (SoloLectura)
            {
                GI.Framework.General.GIMsgBox.ShowSoloLectura();
                return;
            }
            try
            {

                //Verifico si la adm de alquiler esta o no guardado. Si lo esta lo actualizo.
                //Busco la administracion en el primer Tab.
                if (pedido.IdPedido == 0)
                    guardado = ((TabDatosPrincipales)tabControl.TabPages[0].Controls[0]).getPedido().Guardar();
                else
                    guardado = ((TabDatosPrincipales)tabControl.TabPages[0].Controls[0]).getPedido().Actualizar();

                if (guardado)
                {
                    InicializarTabs();
                }
                else
                {
                    GI.Framework.General.GIMsgBox.Show("No se han guardado los cambios.", GI.Framework.General.enumTipoMensaje.Error);

                }
            }
            catch (Exception ex)
            {
                GI.Framework.General.GIMsgBox.Show(ex.Message, GI.Framework.General.enumTipoMensaje.Error);
            }

        }
    }
   
}