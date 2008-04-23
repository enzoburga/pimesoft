using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Clientes
{
    public partial class frmFichaCliente : Form
    {
        public frmFichaCliente()
        {
            InitializeComponent();            
        }

        private GI.BR.Cliente cliente = null;

        public GI.BR.Cliente Cliente
        {
            get { return cliente; }
            set 
            { 
                cliente = value; 
            
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

            if (cliente != null)
            {
                bAceptar.Visible = false;
                bCancelar.Text = "Cerrar";
                CargarDatosCliente();
            }
            else
            {
                bAceptar.Visible = true;
                bCancelar.Text = "Cancelar";
            }

        }

        private void CargarDatosCliente()
        {
            //Implementado para 1 Tab.
            ((TabDatosPrincipales)tabControl.TabPages[0].Controls[0]).Cliente = cliente;
        }

        private void frmFichaCliente_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ((TabDatosPrincipales)tabControl.TabPages[0].Controls[0]).Cliente.Guardar();
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
            this.guardarToolStripMenuItem_Click(sender, e);
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}