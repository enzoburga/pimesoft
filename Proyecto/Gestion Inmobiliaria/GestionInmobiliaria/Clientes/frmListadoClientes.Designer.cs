namespace GI.UI.Clientes
{
    partial class frmListadoClientes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoClientes));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAgregar = new System.Windows.Forms.ToolStripSplitButton();
            this.nuevoPropietarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoInquilinoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoClientePedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonImprimirListado = new System.Windows.Forms.ToolStripButton();
            this.lvClientes = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verFichatoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarFichaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarACorreoElectrónicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvClientes);
            this.splitContainer1.Size = new System.Drawing.Size(880, 425);
            this.splitContainer1.SplitterDistance = 71;
            this.splitContainer1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBuscar,
            this.toolStripButtonAgregar,
            this.toolStripButtonImprimirListado});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(880, 71);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonBuscar
            // 
            this.toolStripButtonBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBuscar.Image")));
            this.toolStripButtonBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBuscar.Name = "toolStripButtonBuscar";
            this.toolStripButtonBuscar.Size = new System.Drawing.Size(67, 68);
            this.toolStripButtonBuscar.Text = "Buscar Clientes";
            this.toolStripButtonBuscar.Click += new System.EventHandler(this.toolStripButtonBuscar_Click);
            // 
            // toolStripButtonAgregar
            // 
            this.toolStripButtonAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAgregar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPropietarioToolStripMenuItem1,
            this.nuevoInquilinoToolStripMenuItem1,
            this.nuevoClientePedidoToolStripMenuItem});
            this.toolStripButtonAgregar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAgregar.Image")));
            this.toolStripButtonAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAgregar.Name = "toolStripButtonAgregar";
            this.toolStripButtonAgregar.Size = new System.Drawing.Size(80, 68);
            this.toolStripButtonAgregar.Text = "Nuevo Cliente";
            // 
            // nuevoPropietarioToolStripMenuItem1
            // 
            this.nuevoPropietarioToolStripMenuItem1.Name = "nuevoPropietarioToolStripMenuItem1";
            this.nuevoPropietarioToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.nuevoPropietarioToolStripMenuItem1.Text = "Nuevo Propietario";
            this.nuevoPropietarioToolStripMenuItem1.Click += new System.EventHandler(this.nuevoPropietarioToolStripMenuItem_Click);
            // 
            // nuevoInquilinoToolStripMenuItem1
            // 
            this.nuevoInquilinoToolStripMenuItem1.Name = "nuevoInquilinoToolStripMenuItem1";
            this.nuevoInquilinoToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.nuevoInquilinoToolStripMenuItem1.Text = "Nuevo Inquilino";
            this.nuevoInquilinoToolStripMenuItem1.Click += new System.EventHandler(this.nuevoInquilinoToolStripMenuItem_Click);
            // 
            // nuevoClientePedidoToolStripMenuItem
            // 
            this.nuevoClientePedidoToolStripMenuItem.Name = "nuevoClientePedidoToolStripMenuItem";
            this.nuevoClientePedidoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.nuevoClientePedidoToolStripMenuItem.Text = "Nuevo Cliente Pedido";
            this.nuevoClientePedidoToolStripMenuItem.Click += new System.EventHandler(this.nuevoClientePedidoToolStripMenuItem_Click);
            // 
            // toolStripButtonImprimirListado
            // 
            this.toolStripButtonImprimirListado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonImprimirListado.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonImprimirListado.Image")));
            this.toolStripButtonImprimirListado.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonImprimirListado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonImprimirListado.Name = "toolStripButtonImprimirListado";
            this.toolStripButtonImprimirListado.Size = new System.Drawing.Size(68, 68);
            this.toolStripButtonImprimirListado.Text = "Imprimir Listado";
            // 
            // lvClientes
            // 
            this.lvClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader8,
            this.columnHeader3});
            this.lvClientes.ContextMenuStrip = this.contextMenuStrip1;
            this.lvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvClientes.FullRowSelect = true;
            this.lvClientes.HideSelection = false;
            this.lvClientes.Location = new System.Drawing.Point(0, 0);
            this.lvClientes.MultiSelect = false;
            this.lvClientes.Name = "lvClientes";
            this.lvClientes.Size = new System.Drawing.Size(880, 350);
            this.lvClientes.TabIndex = 0;
            this.lvClientes.UseCompatibleStateImageBehavior = false;
            this.lvClientes.View = System.Windows.Forms.View.Details;
            this.lvClientes.DoubleClick += new System.EventHandler(this.lvClientes_DoubleClick);
            this.lvClientes.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvClientes_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 266;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Telefono";
            this.columnHeader2.Width = 178;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mail";
            this.columnHeader8.Width = 272;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tipo de Cliente";
            this.columnHeader3.Width = 107;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verFichatoolStripMenuItem,
            this.editarFichaToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.enviarACorreoElectrónicoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(214, 92);
            // 
            // verFichatoolStripMenuItem
            // 
            this.verFichatoolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verFichatoolStripMenuItem.Name = "verFichatoolStripMenuItem";
            this.verFichatoolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.verFichatoolStripMenuItem.Text = "Ver Ficha";
            this.verFichatoolStripMenuItem.Click += new System.EventHandler(this.verFichatoolStripMenuItem_Click);
            // 
            // editarFichaToolStripMenuItem
            // 
            this.editarFichaToolStripMenuItem.Name = "editarFichaToolStripMenuItem";
            this.editarFichaToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.editarFichaToolStripMenuItem.Text = "Editar Ficha";
            this.editarFichaToolStripMenuItem.Click += new System.EventHandler(this.editarFichaToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // enviarACorreoElectrónicoToolStripMenuItem
            // 
            this.enviarACorreoElectrónicoToolStripMenuItem.Name = "enviarACorreoElectrónicoToolStripMenuItem";
            this.enviarACorreoElectrónicoToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.enviarACorreoElectrónicoToolStripMenuItem.Text = "Enviar a correo electrónico";
            // 
            // frmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 425);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmListadoClientes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Listado de Clientes";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lvClientes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ToolStripMenuItem verFichatoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarFichaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarACorreoElectrónicoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonBuscar;
        private System.Windows.Forms.ToolStripSplitButton toolStripButtonAgregar;
        private System.Windows.Forms.ToolStripMenuItem nuevoPropietarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nuevoInquilinoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStripButtonImprimirListado;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripMenuItem nuevoClientePedidoToolStripMenuItem;
    }
}