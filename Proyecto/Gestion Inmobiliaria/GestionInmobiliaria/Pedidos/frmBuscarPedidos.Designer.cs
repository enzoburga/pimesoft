namespace GI.UI.Pedidos
{
    partial class frmBuscarPedidos
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tbNombresInquilinos = new System.Windows.Forms.TextBox();
            this.lNombreCliente = new System.Windows.Forms.Label();
            this.tabControlTiposDeBusqueda = new System.Windows.Forms.TabControl();
            this.cbIncluirHistoricos = new System.Windows.Forms.CheckBox();
            this.tabPage4.SuspendLayout();
            this.tabControlTiposDeBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // bBuscar
            // 
            this.bBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bBuscar.Location = new System.Drawing.Point(155, 96);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 48;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Transparent;
            this.tabPage4.Controls.Add(this.tbNombresInquilinos);
            this.tabPage4.Controls.Add(this.lNombreCliente);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(237, 68);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Buscar por contacto";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tbNombresInquilinos
            // 
            this.tbNombresInquilinos.Location = new System.Drawing.Point(105, 23);
            this.tbNombresInquilinos.Name = "tbNombresInquilinos";
            this.tbNombresInquilinos.Size = new System.Drawing.Size(123, 20);
            this.tbNombresInquilinos.TabIndex = 50;
            // 
            // lNombreCliente
            // 
            this.lNombreCliente.AutoSize = true;
            this.lNombreCliente.Location = new System.Drawing.Point(3, 26);
            this.lNombreCliente.Name = "lNombreCliente";
            this.lNombreCliente.Size = new System.Drawing.Size(97, 13);
            this.lNombreCliente.TabIndex = 49;
            this.lNombreCliente.Text = "Nombres / Apellido";
            // 
            // tabControlTiposDeBusqueda
            // 
            this.tabControlTiposDeBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlTiposDeBusqueda.Controls.Add(this.tabPage4);
            this.tabControlTiposDeBusqueda.Location = new System.Drawing.Point(0, 0);
            this.tabControlTiposDeBusqueda.Name = "tabControlTiposDeBusqueda";
            this.tabControlTiposDeBusqueda.SelectedIndex = 0;
            this.tabControlTiposDeBusqueda.Size = new System.Drawing.Size(245, 94);
            this.tabControlTiposDeBusqueda.TabIndex = 47;
            // 
            // cbIncluirHistoricos
            // 
            this.cbIncluirHistoricos.AutoSize = true;
            this.cbIncluirHistoricos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbIncluirHistoricos.Location = new System.Drawing.Point(46, 100);
            this.cbIncluirHistoricos.Name = "cbIncluirHistoricos";
            this.cbIncluirHistoricos.Size = new System.Drawing.Size(103, 17);
            this.cbIncluirHistoricos.TabIndex = 49;
            this.cbIncluirHistoricos.Text = "Incluir Históricos";
            this.cbIncluirHistoricos.UseVisualStyleBackColor = true;
            // 
            // frmBuscarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 125);
            this.Controls.Add(this.cbIncluirHistoricos);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.tabControlTiposDeBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarPedidos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Pedidos";
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabControlTiposDeBusqueda.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox tbNombresInquilinos;
        private System.Windows.Forms.Label lNombreCliente;
        private System.Windows.Forms.TabControl tabControlTiposDeBusqueda;
        private System.Windows.Forms.CheckBox cbIncluirHistoricos;
    }
}