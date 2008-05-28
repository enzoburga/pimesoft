namespace GI.UI.AdminAlquileres
{
    partial class frmListadoAdmAlquiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoAdmAlquiler));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.NuevoAlquilertoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.imprimirListadotoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lvAdmAlquileres = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verFichaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarFichaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirFichaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
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
            this.splitContainer1.Panel2.Controls.Add(this.lvAdmAlquileres);
            this.splitContainer1.Size = new System.Drawing.Size(832, 415);
            this.splitContainer1.SplitterDistance = 71;
            this.splitContainer1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.NuevoAlquilertoolStripButton,
            this.imprimirListadotoolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(832, 71);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(67, 68);
            this.toolStripButton1.Text = "Buscar Alquileres";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // NuevoAlquilertoolStripButton
            // 
            this.NuevoAlquilertoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NuevoAlquilertoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoAlquilertoolStripButton.Image")));
            this.NuevoAlquilertoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NuevoAlquilertoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoAlquilertoolStripButton.Name = "NuevoAlquilertoolStripButton";
            this.NuevoAlquilertoolStripButton.Size = new System.Drawing.Size(68, 68);
            this.NuevoAlquilertoolStripButton.Text = "Nuevo Alquiler";
            this.NuevoAlquilertoolStripButton.Click += new System.EventHandler(this.NuevoAlquilertoolStripButton_Click);
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
            // lvAdmAlquileres
            // 
            this.lvAdmAlquileres.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader8,
            this.columnHeader3,
            this.columnHeader4});
            this.lvAdmAlquileres.ContextMenuStrip = this.contextMenuStrip1;
            this.lvAdmAlquileres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAdmAlquileres.FullRowSelect = true;
            this.lvAdmAlquileres.HideSelection = false;
            this.lvAdmAlquileres.Location = new System.Drawing.Point(0, 0);
            this.lvAdmAlquileres.Name = "lvAdmAlquileres";
            this.lvAdmAlquileres.Size = new System.Drawing.Size(832, 340);
            this.lvAdmAlquileres.TabIndex = 0;
            this.lvAdmAlquileres.UseCompatibleStateImageBehavior = false;
            this.lvAdmAlquileres.View = System.Windows.Forms.View.Details;
            this.lvAdmAlquileres.DoubleClick += new System.EventHandler(this.lvAdmAlquileres_DoubleClick);
            this.lvAdmAlquileres.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvAdmAlquileres_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Contacto";
            this.columnHeader1.Width = 231;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Propiedad";
            this.columnHeader2.Width = 206;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Inquilino";
            this.columnHeader8.Width = 177;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fecha Vencimiento Contrato";
            this.columnHeader3.Width = 153;
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
            // columnHeader4
            // 
            this.columnHeader4.Text = "Estado";
            // 
            // frmListadoAdmAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 415);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmListadoAdmAlquiler";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Administración de Alquileres";
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
        private System.Windows.Forms.ListView lvAdmAlquileres;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton NuevoAlquilertoolStripButton;
        private System.Windows.Forms.ToolStripButton imprimirListadotoolStripButton;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verFichaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarFichaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirFichaToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}