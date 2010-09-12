namespace GI.UI.Propiedades
{
    partial class FrmListadoPropiedades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoPropiedades));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNuevaFicha = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEnviarMail = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonImprimir = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarFichaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarACorreoElectrónicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvPropiedades = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.Moneda = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBuscar,
            this.toolStripButtonNuevaFicha,
            this.toolStripButtonEnviarMail,
            this.toolStripButtonImprimir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(283, 71);
            this.toolStrip1.TabIndex = 0;
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
            this.toolStripButtonBuscar.Text = "Buscar Propiedades";
            this.toolStripButtonBuscar.Click += new System.EventHandler(this.toolStripButtonBuscar_Click);
            // 
            // toolStripButtonNuevaFicha
            // 
            this.toolStripButtonNuevaFicha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNuevaFicha.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNuevaFicha.Image")));
            this.toolStripButtonNuevaFicha.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonNuevaFicha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNuevaFicha.Name = "toolStripButtonNuevaFicha";
            this.toolStripButtonNuevaFicha.Size = new System.Drawing.Size(68, 68);
            this.toolStripButtonNuevaFicha.Text = "Nueva Ficha";
            this.toolStripButtonNuevaFicha.Click += new System.EventHandler(this.toolStripButtonNuevaFicha_Click);
            // 
            // toolStripButtonEnviarMail
            // 
            this.toolStripButtonEnviarMail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEnviarMail.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEnviarMail.Image")));
            this.toolStripButtonEnviarMail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonEnviarMail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEnviarMail.Name = "toolStripButtonEnviarMail";
            this.toolStripButtonEnviarMail.Size = new System.Drawing.Size(68, 68);
            this.toolStripButtonEnviarMail.Text = "Enviar a correo electrónico";
            this.toolStripButtonEnviarMail.Click += new System.EventHandler(this.toolStripButtonEnviarMail_Click);
            // 
            // toolStripButtonImprimir
            // 
            this.toolStripButtonImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonImprimir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonImprimir.Image")));
            this.toolStripButtonImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonImprimir.Name = "toolStripButtonImprimir";
            this.toolStripButtonImprimir.Size = new System.Drawing.Size(68, 68);
            this.toolStripButtonImprimir.Text = "Imprimir Listado";
            this.toolStripButtonImprimir.Click += new System.EventHandler(this.toolStripButtonImprimir_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editarFichaToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.enviarACorreoElectrónicoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(214, 92);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(213, 22);
            this.toolStripMenuItem1.Text = "Ver Ficha";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
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
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // enviarACorreoElectrónicoToolStripMenuItem
            // 
            this.enviarACorreoElectrónicoToolStripMenuItem.Name = "enviarACorreoElectrónicoToolStripMenuItem";
            this.enviarACorreoElectrónicoToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.enviarACorreoElectrónicoToolStripMenuItem.Text = "Enviar a correo electrónico";
            this.enviarACorreoElectrónicoToolStripMenuItem.Click += new System.EventHandler(this.enviarACorreoElectrónicoToolStripMenuItem_Click);
            // 
            // lvPropiedades
            // 
            this.lvPropiedades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.Moneda,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvPropiedades.ContextMenuStrip = this.contextMenuStrip1;
            this.lvPropiedades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPropiedades.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPropiedades.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvPropiedades.FullRowSelect = true;
            this.lvPropiedades.HideSelection = false;
            this.lvPropiedades.Location = new System.Drawing.Point(0, 0);
            this.lvPropiedades.Name = "lvPropiedades";
            this.lvPropiedades.ShowItemToolTips = true;
            this.lvPropiedades.Size = new System.Drawing.Size(895, 472);
            this.lvPropiedades.TabIndex = 1;
            this.lvPropiedades.UseCompatibleStateImageBehavior = false;
            this.lvPropiedades.View = System.Windows.Forms.View.Details;
            this.lvPropiedades.DoubleClick += new System.EventHandler(this.lvPropiedades_DoubleClick_1);
            this.lvPropiedades.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvPropiedades_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tipo";
            this.columnHeader2.Width = 103;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Estado";
            this.columnHeader3.Width = 94;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ambientes";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 83;
            // 
            // Moneda
            // 
            this.Moneda.Text = "Moneda";
            this.Moneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Valor";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 96;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Partido";
            this.columnHeader6.Width = 170;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Barrio";
            this.columnHeader7.Width = 228;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Dirección";
            this.columnHeader8.Width = 268;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(286, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 41);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvPropiedades);
            this.splitContainer1.Size = new System.Drawing.Size(895, 547);
            this.splitContainer1.SplitterDistance = 71;
            this.splitContainer1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(287, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(442, 41);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // FrmListadoPropiedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 547);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmListadoPropiedades";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Propiedades";
            this.Load += new System.EventHandler(this.FrmListadoPropiedades_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarFichaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarACorreoElectrónicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonNuevaFicha;
        private System.Windows.Forms.ToolStripButton toolStripButtonEnviarMail;
        private System.Windows.Forms.ToolStripButton toolStripButtonImprimir;
        private System.Windows.Forms.ListView lvPropiedades;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ToolStripButton toolStripButtonBuscar;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader Moneda;
        protected System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.SplitContainer splitContainer1;
        protected System.Windows.Forms.PictureBox pictureBox2;

    }
}