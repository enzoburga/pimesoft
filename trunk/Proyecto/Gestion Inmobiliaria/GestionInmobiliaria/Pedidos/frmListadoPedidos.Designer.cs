namespace GI.UI.Pedidos
{
    partial class frmListadoPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoPedidos));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BuscarPedidostoolStripButton = new System.Windows.Forms.ToolStripSplitButton();
            this.pedidosDeAlquilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NuevoPedidotoolStripButton = new System.Windows.Forms.ToolStripSplitButton();
            this.nuevoPedidoDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPedidoDeAlquilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirListadotoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lvPedidos = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verFichaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarFichaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirFichaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.splitContainer1.Panel2.Controls.Add(this.lvPedidos);
            this.splitContainer1.Size = new System.Drawing.Size(832, 415);
            this.splitContainer1.SplitterDistance = 71;
            this.splitContainer1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BuscarPedidostoolStripButton,
            this.NuevoPedidotoolStripButton,
            this.imprimirListadotoolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(832, 71);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BuscarPedidostoolStripButton
            // 
            this.BuscarPedidostoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BuscarPedidostoolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosDeAlquilerToolStripMenuItem,
            this.pedidosDeVentasToolStripMenuItem});
            this.BuscarPedidostoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarPedidostoolStripButton.Image")));
            this.BuscarPedidostoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BuscarPedidostoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BuscarPedidostoolStripButton.Name = "BuscarPedidostoolStripButton";
            this.BuscarPedidostoolStripButton.Size = new System.Drawing.Size(79, 68);
            this.BuscarPedidostoolStripButton.Text = "Buscar Pedidos";
            // 
            // pedidosDeAlquilerToolStripMenuItem
            // 
            this.pedidosDeAlquilerToolStripMenuItem.Name = "pedidosDeAlquilerToolStripMenuItem";
            this.pedidosDeAlquilerToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.pedidosDeAlquilerToolStripMenuItem.Text = "Pedidos de Alquileres";
            this.pedidosDeAlquilerToolStripMenuItem.Click += new System.EventHandler(this.pedidosDeAlquilerToolStripMenuItem_Click);
            // 
            // pedidosDeVentasToolStripMenuItem
            // 
            this.pedidosDeVentasToolStripMenuItem.Name = "pedidosDeVentasToolStripMenuItem";
            this.pedidosDeVentasToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.pedidosDeVentasToolStripMenuItem.Text = "Pedidos de Ventas";
            this.pedidosDeVentasToolStripMenuItem.Click += new System.EventHandler(this.pedidosDeVentasToolStripMenuItem_Click);
            // 
            // NuevoPedidotoolStripButton
            // 
            this.NuevoPedidotoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NuevoPedidotoolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPedidoDeVentaToolStripMenuItem,
            this.nuevoPedidoDeAlquilerToolStripMenuItem});
            this.NuevoPedidotoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoPedidotoolStripButton.Image")));
            this.NuevoPedidotoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NuevoPedidotoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoPedidotoolStripButton.Name = "NuevoPedidotoolStripButton";
            this.NuevoPedidotoolStripButton.Size = new System.Drawing.Size(80, 68);
            this.NuevoPedidotoolStripButton.Text = "Nuevo Pedido";
            // 
            // nuevoPedidoDeVentaToolStripMenuItem
            // 
            this.nuevoPedidoDeVentaToolStripMenuItem.Name = "nuevoPedidoDeVentaToolStripMenuItem";
            this.nuevoPedidoDeVentaToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.nuevoPedidoDeVentaToolStripMenuItem.Text = "Nuevo Pedido de Venta";
            this.nuevoPedidoDeVentaToolStripMenuItem.Click += new System.EventHandler(this.nuevoPedidoDeVentaToolStripMenuItem_Click);
            // 
            // nuevoPedidoDeAlquilerToolStripMenuItem
            // 
            this.nuevoPedidoDeAlquilerToolStripMenuItem.Name = "nuevoPedidoDeAlquilerToolStripMenuItem";
            this.nuevoPedidoDeAlquilerToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.nuevoPedidoDeAlquilerToolStripMenuItem.Text = "Nuevo Pedido de Alquiler";
            this.nuevoPedidoDeAlquilerToolStripMenuItem.Click += new System.EventHandler(this.nuevoPedidoDeAlquilerToolStripMenuItem_Click);
            // 
            // imprimirListadotoolStripButton
            // 
            this.imprimirListadotoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imprimirListadotoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("imprimirListadotoolStripButton.Image")));
            this.imprimirListadotoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.imprimirListadotoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimirListadotoolStripButton.Name = "imprimirListadotoolStripButton";
            this.imprimirListadotoolStripButton.Size = new System.Drawing.Size(68, 68);
            this.imprimirListadotoolStripButton.Text = "Imprimir listado";
            this.imprimirListadotoolStripButton.Click += new System.EventHandler(this.imprimirListadotoolStripButton_Click);
            // 
            // lvPedidos
            // 
            this.lvPedidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvPedidos.ContextMenuStrip = this.contextMenuStrip1;
            this.lvPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPedidos.FullRowSelect = true;
            this.lvPedidos.HideSelection = false;
            this.lvPedidos.Location = new System.Drawing.Point(0, 0);
            this.lvPedidos.Name = "lvPedidos";
            this.lvPedidos.Size = new System.Drawing.Size(832, 340);
            this.lvPedidos.TabIndex = 0;
            this.lvPedidos.UseCompatibleStateImageBehavior = false;
            this.lvPedidos.View = System.Windows.Forms.View.Details;
            this.lvPedidos.DoubleClick += new System.EventHandler(this.lvPedidos_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Contacto";
            this.columnHeader1.Width = 231;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Estado Propiedad";
            this.columnHeader2.Width = 206;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verFichaToolStripMenuItem,
            this.editarFichaToolStripMenuItem,
            this.imprimirFichaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 70);
            // 
            // verFichaToolStripMenuItem
            // 
            this.verFichaToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.verFichaToolStripMenuItem.Name = "verFichaToolStripMenuItem";
            this.verFichaToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.verFichaToolStripMenuItem.Text = "Ver Ficha";
            this.verFichaToolStripMenuItem.Click += new System.EventHandler(this.verFichaToolStripMenuItem_Click);
            // 
            // editarFichaToolStripMenuItem
            // 
            this.editarFichaToolStripMenuItem.Name = "editarFichaToolStripMenuItem";
            this.editarFichaToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.editarFichaToolStripMenuItem.Text = "Editar Ficha";
            this.editarFichaToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.editarFichaToolStripMenuItem.Click += new System.EventHandler(this.editarFichaToolStripMenuItem_Click);
            // 
            // imprimirFichaToolStripMenuItem
            // 
            this.imprimirFichaToolStripMenuItem.Name = "imprimirFichaToolStripMenuItem";
            this.imprimirFichaToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.imprimirFichaToolStripMenuItem.Text = "Imprimir";
            // 
            // frmListadoPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 415);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmListadoPedidos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Administración de Pedidos";
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
        private System.Windows.Forms.ListView lvPedidos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton imprimirListadotoolStripButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verFichaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarFichaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirFichaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton NuevoPedidotoolStripButton;
        private System.Windows.Forms.ToolStripMenuItem nuevoPedidoDeVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoPedidoDeAlquilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton BuscarPedidostoolStripButton;
        private System.Windows.Forms.ToolStripMenuItem pedidosDeAlquilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosDeVentasToolStripMenuItem;
    }
}