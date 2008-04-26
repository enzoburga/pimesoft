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
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBuscar,
            this.toolStripButtonNuevaFicha,
            this.toolStripButtonEnviarMail,
            this.toolStripButtonImprimir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(831, 71);
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
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editarFichaToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.enviarACorreoElectrónicoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(214, 114);
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
            // 
            // enviarACorreoElectrónicoToolStripMenuItem
            // 
            this.enviarACorreoElectrónicoToolStripMenuItem.Name = "enviarACorreoElectrónicoToolStripMenuItem";
            this.enviarACorreoElectrónicoToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.enviarACorreoElectrónicoToolStripMenuItem.Text = "Enviar a correo electrónico";
            // 
            // lvPropiedades
            // 
            this.lvPropiedades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvPropiedades.ContextMenuStrip = this.contextMenuStrip1;
            this.lvPropiedades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPropiedades.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPropiedades.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvPropiedades.FullRowSelect = true;
            this.lvPropiedades.HideSelection = false;
            this.lvPropiedades.Location = new System.Drawing.Point(0, 71);
            this.lvPropiedades.Name = "lvPropiedades";
            this.lvPropiedades.Size = new System.Drawing.Size(831, 433);
            this.lvPropiedades.TabIndex = 1;
            this.lvPropiedades.UseCompatibleStateImageBehavior = false;
            this.lvPropiedades.View = System.Windows.Forms.View.Details;
            this.lvPropiedades.DoubleClick += new System.EventHandler(this.lvPropiedades_DoubleClick_1);
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
            // columnHeader5
            // 
            this.columnHeader5.Text = "Valor";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 120;
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
            // FrmListadoPropiedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 504);
            this.Controls.Add(this.lvPropiedades);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmListadoPropiedades";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Propiedades";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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

    }
}