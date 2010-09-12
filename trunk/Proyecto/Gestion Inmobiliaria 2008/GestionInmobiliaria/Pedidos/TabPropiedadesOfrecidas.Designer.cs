namespace GI.UI.Pedidos
{
    partial class TabPropiedadesOfrecidas
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
            this.lvPropiedades = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verFichaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarPorEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvPropiedades
            // 
            this.lvPropiedades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader2,
            this.columnHeader1});
            this.lvPropiedades.FullRowSelect = true;
            this.lvPropiedades.HideSelection = false;
            this.lvPropiedades.Location = new System.Drawing.Point(12, 12);
            this.lvPropiedades.Name = "lvPropiedades";
            this.lvPropiedades.Size = new System.Drawing.Size(672, 463);
            this.lvPropiedades.TabIndex = 1;
            this.lvPropiedades.UseCompatibleStateImageBehavior = false;
            this.lvPropiedades.View = System.Windows.Forms.View.Details;
            this.lvPropiedades.DoubleClick += new System.EventHandler(this.lvPropiedades_DoubleClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Código";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Direccion Propiedad";
            this.columnHeader2.Width = 156;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Propietario";
            this.columnHeader1.Width = 188;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verFichaToolStripMenuItem,
            this.enviarPorEmailToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(162, 70);
            // 
            // verFichaToolStripMenuItem
            // 
            this.verFichaToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.verFichaToolStripMenuItem.Name = "verFichaToolStripMenuItem";
            this.verFichaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.verFichaToolStripMenuItem.Text = "Ver Ficha";
            this.verFichaToolStripMenuItem.Click += new System.EventHandler(this.verFichaToolStripMenuItem_Click);
            // 
            // enviarPorEmailToolStripMenuItem
            // 
            this.enviarPorEmailToolStripMenuItem.Name = "enviarPorEmailToolStripMenuItem";
            this.enviarPorEmailToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.enviarPorEmailToolStripMenuItem.Text = "Enviar por Email";
            this.enviarPorEmailToolStripMenuItem.Click += new System.EventHandler(this.enviarPorEmailToolStripMenuItem_Click);
            // 
            // TabPropiedadesOfrecidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvPropiedades);
            this.Name = "TabPropiedadesOfrecidas";
            this.Size = new System.Drawing.Size(699, 478);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvPropiedades;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verFichaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarPorEmailToolStripMenuItem;
    }
}
