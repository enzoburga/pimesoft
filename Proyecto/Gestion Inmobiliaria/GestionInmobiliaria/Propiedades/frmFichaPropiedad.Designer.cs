namespace GI.UI.Propiedades
{
    partial class frmFichaPropiedad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFichaPropiedad));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabControl = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonenviarxmail = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPublicar = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarACorreoElectr�nicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicaci�nToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.copiaAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bAceptar);
            this.splitContainer1.Panel2.Controls.Add(this.bCancelar);
            this.splitContainer1.Size = new System.Drawing.Size(685, 606);
            this.splitContainer1.SplitterDistance = 575;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabControl);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(685, 506);
            this.tabControl1.TabIndex = 3;
            // 
            // tabControl
            // 
            this.tabControl.Location = new System.Drawing.Point(4, 22);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Windows.Forms.Padding(3);
            this.tabControl.Size = new System.Drawing.Size(677, 480);
            this.tabControl.TabIndex = 0;
            this.tabControl.Text = "tabPage1";
            this.tabControl.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(677, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonImprimir,
            this.toolStripButtonenviarxmail,
            this.toolStripButtonPublicar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(685, 45);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonImprimir
            // 
            this.toolStripButtonImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonImprimir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonImprimir.Image")));
            this.toolStripButtonImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonImprimir.Name = "toolStripButtonImprimir";
            this.toolStripButtonImprimir.Size = new System.Drawing.Size(42, 42);
            this.toolStripButtonImprimir.Text = "Imprimir";
            this.toolStripButtonImprimir.Click += new System.EventHandler(this.toolStripButtonImprimir_Click);
            // 
            // toolStripButtonenviarxmail
            // 
            this.toolStripButtonenviarxmail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonenviarxmail.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonenviarxmail.Image")));
            this.toolStripButtonenviarxmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonenviarxmail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonenviarxmail.Name = "toolStripButtonenviarxmail";
            this.toolStripButtonenviarxmail.Size = new System.Drawing.Size(42, 42);
            this.toolStripButtonenviarxmail.Text = "Enviar por correo";
            this.toolStripButtonenviarxmail.Click += new System.EventHandler(this.toolStripButtonenviarxmail_Click);
            // 
            // toolStripButtonPublicar
            // 
            this.toolStripButtonPublicar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPublicar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPublicar.Image")));
            this.toolStripButtonPublicar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonPublicar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPublicar.Name = "toolStripButtonPublicar";
            this.toolStripButtonPublicar.Size = new System.Drawing.Size(42, 42);
            this.toolStripButtonPublicar.Text = "Publicar";
            this.toolStripButtonPublicar.Click += new System.EventHandler(this.toolStripButtonPublicar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichaToolStripMenuItem,
            this.publicaci�nToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(685, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichaToolStripMenuItem
            // 
            this.fichaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.enviarACorreoElectr�nicoToolStripMenuItem,
            this.copiaAToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.fichaToolStripMenuItem.Name = "fichaToolStripMenuItem";
            this.fichaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.fichaToolStripMenuItem.Text = "Ficha";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // enviarACorreoElectr�nicoToolStripMenuItem
            // 
            this.enviarACorreoElectr�nicoToolStripMenuItem.Name = "enviarACorreoElectr�nicoToolStripMenuItem";
            this.enviarACorreoElectr�nicoToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.enviarACorreoElectr�nicoToolStripMenuItem.Text = "Enviar a correo electr�nico";
            this.enviarACorreoElectr�nicoToolStripMenuItem.Click += new System.EventHandler(this.enviarACorreoElectr�nicoToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // publicaci�nToolStripMenuItem
            // 
            this.publicaci�nToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.publicarToolStripMenuItem});
            this.publicaci�nToolStripMenuItem.Name = "publicaci�nToolStripMenuItem";
            this.publicaci�nToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.publicaci�nToolStripMenuItem.Text = "Publicaci�n";
            // 
            // publicarToolStripMenuItem
            // 
            this.publicarToolStripMenuItem.Name = "publicarToolStripMenuItem";
            this.publicarToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.publicarToolStripMenuItem.Text = "Publicar ficha";
            this.publicarToolStripMenuItem.Click += new System.EventHandler(this.publicarToolStripMenuItem_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(526, 1);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 1;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(607, 1);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 0;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // copiaAToolStripMenuItem
            // 
            this.copiaAToolStripMenuItem.Name = "copiaAToolStripMenuItem";
            this.copiaAToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.copiaAToolStripMenuItem.Text = "Copia a venta/alquiler";
            this.copiaAToolStripMenuItem.Click += new System.EventHandler(this.copiaAToolStripMenuItem_Click);
            // 
            // frmFichaPropiedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 606);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFichaPropiedad";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Propiedad";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarACorreoElectr�nicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicaci�nToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonImprimir;
        private System.Windows.Forms.ToolStripButton toolStripButtonenviarxmail;
        private System.Windows.Forms.ToolStripButton toolStripButtonPublicar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem copiaAToolStripMenuItem;
    }
}