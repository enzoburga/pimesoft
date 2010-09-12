using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GI.BR.Clientes;

namespace GI.UI.Clientes
{
    public partial class frmFichaCliente : GI.Framework.Seguridad.FrmGISeguridad
    {
        public frmFichaCliente()
        {
            InitializeComponent();
            Inicializar();
        }

        private GI.BR.Clientes.Cliente cliente = null;
        private GI.BR.Clientes.Cliente clienteClone = null;

        public GI.BR.Clientes.Cliente Cliente
        {
            get { return cliente; }
            set 
            { 
                cliente = value;
                clienteClone = (GI.BR.Clientes.Cliente)cliente.Clone();
                CargarDatosCliente();
            
            }
        }
        

        private void Inicializar()
        {

            System.Windows.Forms.TabPage tabPage;
            TabDatosPrincipales controlDatosPersonales;

            tabPage = new TabPage("Datos Principales");
            controlDatosPersonales = new TabDatosPrincipales();
            controlDatosPersonales.Dock = DockStyle.Fill;
            tabPage.Controls.Add(controlDatosPersonales);
            tabControl.TabPages.Add(tabPage);

            




        }

        private void CargarDatosCliente()
        {
            //Implementado para 1 Tab.
            ((TabDatosPrincipales)tabControl.TabPages[0].Controls[0]).Cliente = cliente;
        }

        private void frmFichaCliente_Load(object sender, EventArgs e)
        {
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

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (SoloLectura)
            {
                GI.Framework.General.GIMsgBox.ShowSoloLectura();
                return;
            }
            try
            {
                //Verifico si el cliente esta o no guardado. Si lo esta lo actualizo.
                if(((TabDatosPrincipales)tabControl.TabPages[0].Controls[0]).Cliente.IdCliente == 0)
                    ((TabDatosPrincipales)tabControl.TabPages[0].Controls[0]).Cliente.Guardar();
                else
                    ((TabDatosPrincipales)tabControl.TabPages[0].Controls[0]).Cliente.Actualizar();
            }
            catch (Exception ex)
            {
                GI.Framework.General.GIMsgBox.Show(ex.Message, GI.Framework.General.enumTipoMensaje.Error);
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {

            bool guardado = false;
            if (SoloLectura)
            {
                GI.Framework.General.GIMsgBox.ShowSoloLectura();
                return;
            }
            try
            {
                //Verifico si el cliente esta o no guardado. Si lo esta lo actualizo.
                if (((TabDatosPrincipales)tabControl.TabPages[0].Controls[0]).Cliente.IdCliente == 0)
                    guardado = ((TabDatosPrincipales)tabControl.TabPages[0].Controls[0]).Cliente.Guardar();
                else
                    guardado = ((TabDatosPrincipales)tabControl.TabPages[0].Controls[0]).Cliente.Actualizar();


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
            if (((TabDatosPrincipales)tabControl.TabPages[0].Controls[0]).CambioDatos)

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
                        cliente = (GI.BR.Clientes.Cliente)clienteClone.Clone();
                        DialogResult = DialogResult.Cancel;
                        Close();
                        break;//Cierro.

                }

            DialogResult = DialogResult.Cancel;
            this.Close();

        }
    }
}