using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Clientes
{
    
    public partial class frmBuscarClientes : Form
    {
        private GI.BR.Clientes.Clientes clientes;



        public frmBuscarClientes()
        {
            InitializeComponent();            
            
        }

        public GI.BR.Clientes.Clientes Clientes
        {
            get { return clientes; }
           
        }
        
        private void Inicializar()
        {

            #region Tipo de Propiedad
            cbTipoCliente.Items.Add("Seleccione opción...");
            cbTipoCliente.Items.Add(GI.Managers.Clientes.enumTipoBusquedaCliente.Propietarios);
            cbTipoCliente.Items.Add(GI.Managers.Clientes.enumTipoBusquedaCliente.Inquilinos);
            cbTipoCliente.Items.Add(GI.Managers.Clientes.enumTipoBusquedaCliente.Todos); 

            cbTipoCliente.SelectedIndex = 0;
            #endregion 

        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            if (cbTipoCliente.SelectedIndex == 0)
            {
                GI.Framework.General.GIMsgBox.Show("Debe Seleccionar un tipo de cliente.", GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }

            if (!checkBox1.Checked)
            {
                if (tbNombres.Text.Length < 2)
                {
                    GI.Framework.General.GIMsgBox.Show("Debe al menos ingresar 2 caracteres en el campo Nombres / Apellido", GI.Framework.General.enumTipoMensaje.Advertencia);
                    return;
                }
            }

            GI.Managers.Clientes.mngClientes mngClientes = new GI.Managers.Clientes.mngClientes();

            if(checkBox1.Checked)
                this.clientes = mngClientes.RecuperarClientesTodos((GI.Managers.Clientes.enumTipoBusquedaCliente)cbTipoCliente.SelectedItem);
            else
                this.clientes = mngClientes.RecuperarClientes((GI.Managers.Clientes.enumTipoBusquedaCliente)cbTipoCliente.SelectedItem, this.tbNombres.Text);

            if (clientes.Count < 1)
            {
                GI.Framework.General.GIMsgBox.Show("No se han encontrado clientes coincidentes con el criterio.", GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void frmBuscarClientes_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tbNombres.Enabled = !checkBox1.Checked;
        }
    }
}