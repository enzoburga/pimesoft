namespace GI.UI.Carteles
{
    partial class frmListadoCarteles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoCarteles));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BuscarPedidostoolStripButton = new System.Windows.Forms.ToolStripSplitButton();
            this.verActivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NuevoPedidotoolStripButton = new System.Windows.Forms.ToolStripSplitButton();
            this.nuevoPedidoDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPedidoDeAlquilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvCarteles = new System.Windows.Forms.ListView();
            this.chTipoCartel = new System.Windows.Forms.ColumnHeader();
            this.chFechaAlta = new System.Windows.Forms.ColumnHeader();
            this.chCodigoPropiedad = new System.Windows.Forms.ColumnHeader();
            this.chDireccion = new System.Windows.Forms.ColumnHeader();
            this.chFechaVencimiento = new System.Windows.Forms.ColumnHeader();
            this.chEstado = new System.Windows.Forms.ColumnHeader();
            this.chMedida = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verFichaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarFichaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvCarteles);
            this.splitContainer1.Size = new System.Drawing.Size(675, 502);
            this.splitContainer1.SplitterDistance = 71;
            this.splitContainer1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(219, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BuscarPedidostoolStripButton,
            this.NuevoPedidotoolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(171, 71);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BuscarPedidostoolStripButton
            // 
            this.BuscarPedidostoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BuscarPedidostoolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verActivosToolStripMenuItem,
            this.verTodosToolStripMenuItem});
            this.BuscarPedidostoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarPedidostoolStripButton.Image")));
            this.BuscarPedidostoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BuscarPedidostoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BuscarPedidostoolStripButton.Name = "BuscarPedidostoolStripButton";
            this.BuscarPedidostoolStripButton.Size = new System.Drawing.Size(79, 68);
            this.BuscarPedidostoolStripButton.Text = "Buscar Carteles";
            // 
            // verActivosToolStripMenuItem
            // 
            this.verActivosToolStripMenuItem.Name = "verActivosToolStripMenuItem";
            this.verActivosToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.verActivosToolStripMenuItem.Text = "Ver Activos";
            this.verActivosToolStripMenuItem.Click += new System.EventHandler(this.verActivosToolStripMenuItem_Click);
            // 
            // verTodosToolStripMenuItem
            // 
            this.verTodosToolStripMenuItem.Name = "verTodosToolStripMenuItem";
            this.verTodosToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.verTodosToolStripMenuItem.Text = "Ver Todos";
            this.verTodosToolStripMenuItem.Click += new System.EventHandler(this.verTodosToolStripMenuItem_Click);
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
            this.NuevoPedidotoolStripButton.Text = "Nuevo Cartel";
            // 
            // nuevoPedidoDeVentaToolStripMenuItem
            // 
            this.nuevoPedidoDeVentaToolStripMenuItem.Name = "nuevoPedidoDeVentaToolStripMenuItem";
            this.nuevoPedidoDeVentaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.nuevoPedidoDeVentaToolStripMenuItem.Text = "Nuevo Cartel de Venta";
            this.nuevoPedidoDeVentaToolStripMenuItem.Click += new System.EventHandler(this.nuevoCartelDeVentaToolStripMenuItem_Click);
            // 
            // nuevoPedidoDeAlquilerToolStripMenuItem
            // 
            this.nuevoPedidoDeAlquilerToolStripMenuItem.Name = "nuevoPedidoDeAlquilerToolStripMenuItem";
            this.nuevoPedidoDeAlquilerToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.nuevoPedidoDeAlquilerToolStripMenuItem.Text = "Nuevo Cartel de Alquiler";
            this.nuevoPedidoDeAlquilerToolStripMenuItem.Click += new System.EventHandler(this.nuevoCartelDeAlquilerToolStripMenuItem_Click);
            // 
            // lvCarteles
            // 
            this.lvCarteles.AllowColumnReorder = true;
            this.lvCarteles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTipoCartel,
            this.chFechaAlta,
            this.chCodigoPropiedad,
            this.chDireccion,
            this.chFechaVencimiento,
            this.chEstado,
            this.chMedida});
            this.lvCarteles.ContextMenuStrip = this.contextMenuStrip1;
            this.lvCarteles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCarteles.FullRowSelect = true;
            this.lvCarteles.HideSelection = false;
            this.lvCarteles.LabelWrap = false;
            this.lvCarteles.Location = new System.Drawing.Point(0, 0);
            this.lvCarteles.MultiSelect = false;
            this.lvCarteles.Name = "lvCarteles";
            this.lvCarteles.Size = new System.Drawing.Size(675, 427);
            this.lvCarteles.TabIndex = 0;
            this.lvCarteles.UseCompatibleStateImageBehavior = false;
            this.lvCarteles.View = System.Windows.Forms.View.Details;
            this.lvCarteles.DoubleClick += new System.EventHandler(this.lvCarteles_DoubleClick);
            this.lvCarteles.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvCarteles_ColumnClick);
            // 
            // chTipoCartel
            // 
            this.chTipoCartel.Text = "Tipo";
            // 
            // chFechaAlta
            // 
            this.chFechaAlta.Text = "Fecha Alta";
            this.chFechaAlta.Width = 68;
            // 
            // chCodigoPropiedad
            // 
            this.chCodigoPropiedad.Text = "Código Propiedad";
            this.chCodigoPropiedad.Width = 102;
            // 
            // chDireccion
            // 
            this.chDireccion.Text = "Dirección";
            this.chDireccion.Width = 138;
            // 
            // chFechaVencimiento
            // 
            this.chFechaVencimiento.Text = "Fecha Vencimiento";
            this.chFechaVencimiento.Width = 107;
            // 
            // chEstado
            // 
            this.chEstado.Text = "Estado";
            // 
            // chMedida
            // 
            this.chMedida.Text = "Medida [cm]";
            this.chMedida.Width = 78;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verFichaToolStripMenuItem,
            this.editarFichaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 48);
            // 
            // verFichaToolStripMenuItem
            // 
            this.verFichaToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.verFichaToolStripMenuItem.Name = "verFichaToolStripMenuItem";
            this.verFichaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.verFichaToolStripMenuItem.Text = "Ver Ficha";
            this.verFichaToolStripMenuItem.Click += new System.EventHandler(this.verFichaToolStripMenuItem_Click);
            // 
            // editarFichaToolStripMenuItem
            // 
            this.editarFichaToolStripMenuItem.Name = "editarFichaToolStripMenuItem";
            this.editarFichaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.editarFichaToolStripMenuItem.Text = "Editar Ficha";
            this.editarFichaToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.editarFichaToolStripMenuItem.Click += new System.EventHandler(this.editarFichaToolStripMenuItem_Click);
            // 
            // frmListadoCarteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 502);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmListadoCarteles";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Administración de Carteles";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lvCarteles;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verFichaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarFichaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton NuevoPedidotoolStripButton;
        private System.Windows.Forms.ToolStripMenuItem nuevoPedidoDeVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoPedidoDeAlquilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton BuscarPedidostoolStripButton;
        private System.Windows.Forms.ToolStripMenuItem verTodosToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader chFechaAlta;
        private System.Windows.Forms.ColumnHeader chDireccion;
        private System.Windows.Forms.ColumnHeader chFechaVencimiento;
        private System.Windows.Forms.ColumnHeader chEstado;
        private System.Windows.Forms.ColumnHeader chMedida;
        private System.Windows.Forms.ColumnHeader chCodigoPropiedad;
        private System.Windows.Forms.ColumnHeader chTipoCartel;
        private System.Windows.Forms.ToolStripMenuItem verActivosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}