namespace GI.UI.Clientes
{
    partial class frmBuscarClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bBuscar = new System.Windows.Forms.Button();
            this.tabControlTiposDeBusqueda = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.lTipoCliente = new System.Windows.Forms.Label();
            this.cbTipoCliente = new GI.Framework.ComboBox();
            this.lNombreCliente = new System.Windows.Forms.Label();
            this.tabControlTiposDeBusqueda.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bBuscar
            // 
            this.bBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bBuscar.Location = new System.Drawing.Point(158, 112);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 3;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // tabControlTiposDeBusqueda
            // 
            this.tabControlTiposDeBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlTiposDeBusqueda.Controls.Add(this.tabPage1);
            this.tabControlTiposDeBusqueda.Location = new System.Drawing.Point(0, 0);
            this.tabControlTiposDeBusqueda.Name = "tabControlTiposDeBusqueda";
            this.tabControlTiposDeBusqueda.SelectedIndex = 0;
            this.tabControlTiposDeBusqueda.Size = new System.Drawing.Size(248, 110);
            this.tabControlTiposDeBusqueda.TabIndex = 47;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.tbNombres);
            this.tabPage1.Controls.Add(this.lTipoCliente);
            this.tabPage1.Controls.Add(this.cbTipoCliente);
            this.tabPage1.Controls.Add(this.lNombreCliente);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(240, 84);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Buscar por Nombres / Apellido";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(109, 50);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(123, 20);
            this.tbNombres.TabIndex = 1;
            // 
            // lTipoCliente
            // 
            this.lTipoCliente.AutoSize = true;
            this.lTipoCliente.Location = new System.Drawing.Point(6, 26);
            this.lTipoCliente.Name = "lTipoCliente";
            this.lTipoCliente.Size = new System.Drawing.Size(78, 13);
            this.lTipoCliente.TabIndex = 0;
            this.lTipoCliente.Text = "Tipo de Cliente";
            // 
            // cbTipoCliente
            // 
            this.cbTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoCliente.FormattingEnabled = true;
            this.cbTipoCliente.Location = new System.Drawing.Point(109, 23);
            this.cbTipoCliente.Name = "cbTipoCliente";
            this.cbTipoCliente.Size = new System.Drawing.Size(123, 21);
            this.cbTipoCliente.TabIndex = 0;
            // 
            // lNombreCliente
            // 
            this.lNombreCliente.AutoSize = true;
            this.lNombreCliente.Location = new System.Drawing.Point(6, 53);
            this.lNombreCliente.Name = "lNombreCliente";
            this.lNombreCliente.Size = new System.Drawing.Size(97, 13);
            this.lNombreCliente.TabIndex = 0;
            this.lNombreCliente.Text = "Nombres / Apellido";
            // 
            // frmBuscarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 141);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.tabControlTiposDeBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarClientes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Buscar Clientes";
            this.Load += new System.EventHandler(this.frmBuscarClientes_Load);
            this.tabControlTiposDeBusqueda.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.TabControl tabControlTiposDeBusqueda;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.Label lTipoCliente;
        private GI.Framework.ComboBox cbTipoCliente;
        private System.Windows.Forms.Label lNombreCliente;
    }
}