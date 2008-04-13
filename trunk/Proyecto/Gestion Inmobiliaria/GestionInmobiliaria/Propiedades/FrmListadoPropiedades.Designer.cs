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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoPropiedades));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.nuevaFichaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.enviarListadoACorreoElectrónicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bBuscar = new System.Windows.Forms.Button();
            this.cbBarrio = new GI.Framework.ComboBox();
            this.cbLocalidad = new GI.Framework.ComboBox();
            this.cbProvincia = new GI.Framework.ComboBox();
            this.cbPais = new GI.Framework.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAmbientes = new GI.Framework.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbEstadoPropiedad = new GI.Framework.ComboBox();
            this.cbTipoPropiedad = new GI.Framework.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvPropiedades = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.toolStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(887, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaFichaToolStripMenuItem,
            this.toolStripSeparator1,
            this.enviarListadoACorreoElectrónicoToolStripMenuItem,
            this.imprimirListToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(56, 22);
            this.toolStripDropDownButton1.Text = "Archivo";
            // 
            // nuevaFichaToolStripMenuItem
            // 
            this.nuevaFichaToolStripMenuItem.Name = "nuevaFichaToolStripMenuItem";
            this.nuevaFichaToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.nuevaFichaToolStripMenuItem.Text = "Nueva Ficha";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(244, 6);
            // 
            // enviarListadoACorreoElectrónicoToolStripMenuItem
            // 
            this.enviarListadoACorreoElectrónicoToolStripMenuItem.Name = "enviarListadoACorreoElectrónicoToolStripMenuItem";
            this.enviarListadoACorreoElectrónicoToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.enviarListadoACorreoElectrónicoToolStripMenuItem.Text = "Enviar listado a correo electrónico";
            // 
            // imprimirListToolStripMenuItem
            // 
            this.imprimirListToolStripMenuItem.Name = "imprimirListToolStripMenuItem";
            this.imprimirListToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.imprimirListToolStripMenuItem.Text = "Imprimir listado";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bBuscar);
            this.splitContainer1.Panel1.Controls.Add(this.cbBarrio);
            this.splitContainer1.Panel1.Controls.Add(this.cbLocalidad);
            this.splitContainer1.Panel1.Controls.Add(this.cbProvincia);
            this.splitContainer1.Panel1.Controls.Add(this.cbPais);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.cbAmbientes);
            this.splitContainer1.Panel1.Controls.Add(this.label18);
            this.splitContainer1.Panel1.Controls.Add(this.cbEstadoPropiedad);
            this.splitContainer1.Panel1.Controls.Add(this.cbTipoPropiedad);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvPropiedades);
            this.splitContainer1.Size = new System.Drawing.Size(887, 421);
            this.splitContainer1.SplitterDistance = 95;
            this.splitContainer1.TabIndex = 1;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(555, 63);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 45;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click_1);
            // 
            // cbBarrio
            // 
            this.cbBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBarrio.FormattingEnabled = true;
            this.cbBarrio.Location = new System.Drawing.Point(315, 65);
            this.cbBarrio.Name = "cbBarrio";
            this.cbBarrio.Size = new System.Drawing.Size(123, 21);
            this.cbBarrio.TabIndex = 44;
            this.cbBarrio.SelectedIndexChanged += new System.EventHandler(this.cbBarrio_SelectedIndexChanged);
            // 
            // cbLocalidad
            // 
            this.cbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocalidad.FormattingEnabled = true;
            this.cbLocalidad.Location = new System.Drawing.Point(110, 66);
            this.cbLocalidad.Name = "cbLocalidad";
            this.cbLocalidad.Size = new System.Drawing.Size(123, 21);
            this.cbLocalidad.TabIndex = 43;
            this.cbLocalidad.SelectedIndexChanged += new System.EventHandler(this.cbLocalidad_SelectedIndexChanged);
            // 
            // cbProvincia
            // 
            this.cbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvincia.FormattingEnabled = true;
            this.cbProvincia.Location = new System.Drawing.Point(315, 38);
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.Size = new System.Drawing.Size(123, 21);
            this.cbProvincia.TabIndex = 42;
            this.cbProvincia.SelectedIndexChanged += new System.EventHandler(this.cbProvincia_SelectedIndexChanged);
            // 
            // cbPais
            // 
            this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(110, 39);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(123, 21);
            this.cbPais.TabIndex = 37;
            this.cbPais.SelectedIndexChanged += new System.EventHandler(this.cbPais_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Barrio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Localidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Provincia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "País";
            // 
            // cbAmbientes
            // 
            this.cbAmbientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAmbientes.FormattingEnabled = true;
            this.cbAmbientes.Location = new System.Drawing.Point(315, 11);
            this.cbAmbientes.Name = "cbAmbientes";
            this.cbAmbientes.Size = new System.Drawing.Size(123, 21);
            this.cbAmbientes.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(250, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Ambientes";
            // 
            // cbEstadoPropiedad
            // 
            this.cbEstadoPropiedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoPropiedad.FormattingEnabled = true;
            this.cbEstadoPropiedad.Location = new System.Drawing.Point(507, 10);
            this.cbEstadoPropiedad.Name = "cbEstadoPropiedad";
            this.cbEstadoPropiedad.Size = new System.Drawing.Size(123, 21);
            this.cbEstadoPropiedad.TabIndex = 7;
            // 
            // cbTipoPropiedad
            // 
            this.cbTipoPropiedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPropiedad.FormattingEnabled = true;
            this.cbTipoPropiedad.Location = new System.Drawing.Point(110, 12);
            this.cbTipoPropiedad.Name = "cbTipoPropiedad";
            this.cbTipoPropiedad.Size = new System.Drawing.Size(123, 21);
            this.cbTipoPropiedad.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de Propiedad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estado";
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
            this.lvPropiedades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPropiedades.FullRowSelect = true;
            this.lvPropiedades.HideSelection = false;
            this.lvPropiedades.Location = new System.Drawing.Point(0, 0);
            this.lvPropiedades.Name = "lvPropiedades";
            this.lvPropiedades.Size = new System.Drawing.Size(887, 322);
            this.lvPropiedades.TabIndex = 0;
            this.lvPropiedades.UseCompatibleStateImageBehavior = false;
            this.lvPropiedades.View = System.Windows.Forms.View.Details;
            this.lvPropiedades.DoubleClick += new System.EventHandler(this.lvPropiedades_DoubleClick);
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
            this.ClientSize = new System.Drawing.Size(887, 446);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmListadoPropiedades";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Propiedades";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bBuscar;
        private GI.Framework.ComboBox cbBarrio;
        private GI.Framework.ComboBox cbLocalidad;
        private GI.Framework.ComboBox cbProvincia;
        private GI.Framework.ComboBox cbPais;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private GI.Framework.ComboBox cbAmbientes;
        private System.Windows.Forms.Label label18;
        private GI.Framework.ComboBox cbEstadoPropiedad;
        private GI.Framework.ComboBox cbTipoPropiedad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvPropiedades;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem imprimirListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarListadoACorreoElectrónicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaFichaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;

    }
}