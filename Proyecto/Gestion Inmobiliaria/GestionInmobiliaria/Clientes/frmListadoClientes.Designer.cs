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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoClientes));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvClientes = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.nuevoPropietarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoInquilinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimirListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMailFicha = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonImprimirListado = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.splitContainer1.SplitterDistance = 66;
            this.splitContainer1.TabIndex = 2;
            // 
            // lvClientes
            // 
            this.lvClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader8});
            this.lvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvClientes.FullRowSelect = true;
            this.lvClientes.HideSelection = false;
            this.lvClientes.Location = new System.Drawing.Point(0, 0);
            this.lvClientes.MultiSelect = false;
            this.lvClientes.Name = "lvClientes";
            this.lvClientes.Size = new System.Drawing.Size(880, 355);
            this.lvClientes.TabIndex = 0;
            this.lvClientes.UseCompatibleStateImageBehavior = false;
            this.lvClientes.View = System.Windows.Forms.View.Details;
            this.lvClientes.DoubleClick += new System.EventHandler(this.lvClientes_DoubleClick);
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
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButtonBuscar,
            this.toolStripButtonAgregar,
            this.toolStripButtonMailFicha,
            this.toolStripButtonImprimirListado});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(880, 66);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPropietarioToolStripMenuItem,
            this.nuevoInquilinoToolStripMenuItem,
            this.toolStripSeparator1,
            this.imprimirListToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(56, 63);
            this.toolStripDropDownButton1.Text = "Archivo";
            // 
            // nuevoPropietarioToolStripMenuItem
            // 
            this.nuevoPropietarioToolStripMenuItem.Name = "nuevoPropietarioToolStripMenuItem";
            this.nuevoPropietarioToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.nuevoPropietarioToolStripMenuItem.Text = "Nuevo Propietario";
            // 
            // nuevoInquilinoToolStripMenuItem
            // 
            this.nuevoInquilinoToolStripMenuItem.Name = "nuevoInquilinoToolStripMenuItem";
            this.nuevoInquilinoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.nuevoInquilinoToolStripMenuItem.Text = "Nuevo Inquilino";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // imprimirListToolStripMenuItem
            // 
            this.imprimirListToolStripMenuItem.Name = "imprimirListToolStripMenuItem";
            this.imprimirListToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.imprimirListToolStripMenuItem.Text = "Imprimir listado";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            // 
            // toolStripButtonBuscar
            // 
            this.toolStripButtonBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBuscar.Image")));
            this.toolStripButtonBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBuscar.Name = "toolStripButtonBuscar";
            this.toolStripButtonBuscar.Size = new System.Drawing.Size(23, 63);
            this.toolStripButtonBuscar.Text = "toolStripButton1";
            this.toolStripButtonBuscar.Click += new System.EventHandler(this.toolStripButtonBuscar_Click);
            // 
            // toolStripButtonAgregar
            // 
            this.toolStripButtonAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAgregar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAgregar.Image")));
            this.toolStripButtonAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAgregar.Name = "toolStripButtonAgregar";
            this.toolStripButtonAgregar.Size = new System.Drawing.Size(23, 63);
            this.toolStripButtonAgregar.Text = "toolStripButton2";
            // 
            // toolStripButtonMailFicha
            // 
            this.toolStripButtonMailFicha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMailFicha.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMailFicha.Image")));
            this.toolStripButtonMailFicha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMailFicha.Name = "toolStripButtonMailFicha";
            this.toolStripButtonMailFicha.Size = new System.Drawing.Size(23, 63);
            this.toolStripButtonMailFicha.Text = "toolStripButton4";
            // 
            // toolStripButtonImprimirListado
            // 
            this.toolStripButtonImprimirListado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonImprimirListado.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonImprimirListado.Image")));
            this.toolStripButtonImprimirListado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonImprimirListado.Name = "toolStripButtonImprimirListado";
            this.toolStripButtonImprimirListado.Size = new System.Drawing.Size(23, 63);
            this.toolStripButtonImprimirListado.Text = "toolStripButton3";
            // 
            // frmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 425);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmListadoClientes";
            this.ShowIcon = false;
            this.Text = "Listado de Clientes";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lvClientes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem nuevoPropietarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoInquilinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem imprimirListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonBuscar;
        private System.Windows.Forms.ToolStripButton toolStripButtonAgregar;
        private System.Windows.Forms.ToolStripButton toolStripButtonMailFicha;
        private System.Windows.Forms.ToolStripButton toolStripButtonImprimirListado;
    }
}