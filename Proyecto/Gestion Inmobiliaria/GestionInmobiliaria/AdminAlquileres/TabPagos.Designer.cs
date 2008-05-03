namespace GI.UI.AdminAlquileres
{
    partial class TabPagos
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lvPagos = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvPagos
            // 
            this.lvPagos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvPagos.ContextMenuStrip = this.contextMenuStrip1;
            this.lvPagos.FullRowSelect = true;
            this.lvPagos.HideSelection = false;
            this.lvPagos.Location = new System.Drawing.Point(16, 17);
            this.lvPagos.Name = "lvPagos";
            this.lvPagos.Size = new System.Drawing.Size(413, 498);
            this.lvPagos.TabIndex = 1;
            this.lvPagos.UseCompatibleStateImageBehavior = false;
            this.lvPagos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fecha Pago";
            this.columnHeader1.Width = 193;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mes de Pago";
            this.columnHeader2.Width = 91;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Importe";
            this.columnHeader3.Width = 99;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPagoToolStripMenuItem,
            this.modificarPagoToolStripMenuItem,
            this.eliminarPagoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 70);
            // 
            // nuevoPagoToolStripMenuItem
            // 
            this.nuevoPagoToolStripMenuItem.Name = "nuevoPagoToolStripMenuItem";
            this.nuevoPagoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.nuevoPagoToolStripMenuItem.Text = "Nuevo Pago";
            this.nuevoPagoToolStripMenuItem.Click += new System.EventHandler(this.nuevoPagoToolStripMenuItem_Click);
            // 
            // modificarPagoToolStripMenuItem
            // 
            this.modificarPagoToolStripMenuItem.Name = "modificarPagoToolStripMenuItem";
            this.modificarPagoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.modificarPagoToolStripMenuItem.Text = "Modificar Pago";
            this.modificarPagoToolStripMenuItem.Click += new System.EventHandler(this.modificarPagoToolStripMenuItem_Click);
            // 
            // eliminarPagoToolStripMenuItem
            // 
            this.eliminarPagoToolStripMenuItem.Name = "eliminarPagoToolStripMenuItem";
            this.eliminarPagoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.eliminarPagoToolStripMenuItem.Text = "Eliminar Pago";
            this.eliminarPagoToolStripMenuItem.Click += new System.EventHandler(this.eliminarPagoToolStripMenuItem_Click);
            // 
            // TabPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvPagos);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TabPagos";
            this.Size = new System.Drawing.Size(444, 518);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvPagos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoPagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarPagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarPagoToolStripMenuItem;
    }
}
