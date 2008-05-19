namespace GI.UI.Pedidos
{
    partial class frmBuscarPedidos
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
            this.bBuscar = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tbNombresInquilinos = new System.Windows.Forms.TextBox();
            this.lNombreCliente = new System.Windows.Forms.Label();
            this.tabControlTiposDeBusqueda = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbMonedaReal = new GI.Framework.ComboBox();
            this.textBoxValorHasta = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxValorDesde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBarrio = new GI.Framework.ComboBox();
            this.cbTipoPropiedad = new GI.Framework.ComboBox();
            this.cbLocalidad = new GI.Framework.ComboBox();
            this.cbEstadoPropiedad = new GI.Framework.ComboBox();
            this.cbProvincia = new GI.Framework.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbPais = new GI.Framework.ComboBox();
            this.cbAmbientes = new GI.Framework.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage4.SuspendLayout();
            this.tabControlTiposDeBusqueda.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bBuscar
            // 
            this.bBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bBuscar.Location = new System.Drawing.Point(597, 136);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 48;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Transparent;
            this.tabPage4.Controls.Add(this.tbNombresInquilinos);
            this.tabPage4.Controls.Add(this.lNombreCliente);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(679, 108);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Buscar por contacto";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tbNombresInquilinos
            // 
            this.tbNombresInquilinos.Location = new System.Drawing.Point(105, 23);
            this.tbNombresInquilinos.Name = "tbNombresInquilinos";
            this.tbNombresInquilinos.Size = new System.Drawing.Size(123, 20);
            this.tbNombresInquilinos.TabIndex = 50;
            // 
            // lNombreCliente
            // 
            this.lNombreCliente.AutoSize = true;
            this.lNombreCliente.Location = new System.Drawing.Point(3, 26);
            this.lNombreCliente.Name = "lNombreCliente";
            this.lNombreCliente.Size = new System.Drawing.Size(97, 13);
            this.lNombreCliente.TabIndex = 49;
            this.lNombreCliente.Text = "Nombres / Apellido";
            // 
            // tabControlTiposDeBusqueda
            // 
            this.tabControlTiposDeBusqueda.Controls.Add(this.tabPage1);
            this.tabControlTiposDeBusqueda.Controls.Add(this.tabPage4);
            this.tabControlTiposDeBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlTiposDeBusqueda.Location = new System.Drawing.Point(0, 0);
            this.tabControlTiposDeBusqueda.Name = "tabControlTiposDeBusqueda";
            this.tabControlTiposDeBusqueda.SelectedIndex = 0;
            this.tabControlTiposDeBusqueda.Size = new System.Drawing.Size(687, 134);
            this.tabControlTiposDeBusqueda.TabIndex = 47;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.cbMonedaReal);
            this.tabPage1.Controls.Add(this.textBoxValorHasta);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.textBoxValorDesde);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbBarrio);
            this.tabPage1.Controls.Add(this.cbTipoPropiedad);
            this.tabPage1.Controls.Add(this.cbLocalidad);
            this.tabPage1.Controls.Add(this.cbEstadoPropiedad);
            this.tabPage1.Controls.Add(this.cbProvincia);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.cbPais);
            this.tabPage1.Controls.Add(this.cbAmbientes);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(679, 108);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Buscar por propiedad";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbMonedaReal
            // 
            this.cbMonedaReal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonedaReal.FormattingEnabled = true;
            this.cbMonedaReal.Location = new System.Drawing.Point(613, 50);
            this.cbMonedaReal.Name = "cbMonedaReal";
            this.cbMonedaReal.Size = new System.Drawing.Size(48, 21);
            this.cbMonedaReal.TabIndex = 57;
            // 
            // textBoxValorHasta
            // 
            this.textBoxValorHasta.Location = new System.Drawing.Point(567, 50);
            this.textBoxValorHasta.Name = "textBoxValorHasta";
            this.textBoxValorHasta.Size = new System.Drawing.Size(40, 20);
            this.textBoxValorHasta.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(548, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 13);
            this.label13.TabIndex = 55;
            this.label13.Text = "y";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(439, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "Valor entre";
            // 
            // textBoxValorDesde
            // 
            this.textBoxValorDesde.Location = new System.Drawing.Point(502, 50);
            this.textBoxValorDesde.Name = "textBoxValorDesde";
            this.textBoxValorDesde.Size = new System.Drawing.Size(40, 20);
            this.textBoxValorDesde.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de Propiedad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estado";
            // 
            // cbBarrio
            // 
            this.cbBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBarrio.FormattingEnabled = true;
            this.cbBarrio.Location = new System.Drawing.Point(310, 76);
            this.cbBarrio.Name = "cbBarrio";
            this.cbBarrio.Size = new System.Drawing.Size(123, 21);
            this.cbBarrio.TabIndex = 44;
            this.cbBarrio.SelectedIndexChanged += new System.EventHandler(this.cbBarrio_SelectedIndexChanged);
            // 
            // cbTipoPropiedad
            // 
            this.cbTipoPropiedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPropiedad.FormattingEnabled = true;
            this.cbTipoPropiedad.Location = new System.Drawing.Point(105, 23);
            this.cbTipoPropiedad.Name = "cbTipoPropiedad";
            this.cbTipoPropiedad.Size = new System.Drawing.Size(123, 21);
            this.cbTipoPropiedad.TabIndex = 6;
            // 
            // cbLocalidad
            // 
            this.cbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocalidad.FormattingEnabled = true;
            this.cbLocalidad.Location = new System.Drawing.Point(105, 77);
            this.cbLocalidad.Name = "cbLocalidad";
            this.cbLocalidad.Size = new System.Drawing.Size(123, 21);
            this.cbLocalidad.TabIndex = 43;
            this.cbLocalidad.SelectedIndexChanged += new System.EventHandler(this.cbLocalidad_SelectedIndexChanged_1);
            // 
            // cbEstadoPropiedad
            // 
            this.cbEstadoPropiedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoPropiedad.FormattingEnabled = true;
            this.cbEstadoPropiedad.Location = new System.Drawing.Point(502, 21);
            this.cbEstadoPropiedad.Name = "cbEstadoPropiedad";
            this.cbEstadoPropiedad.Size = new System.Drawing.Size(159, 21);
            this.cbEstadoPropiedad.TabIndex = 7;
            // 
            // cbProvincia
            // 
            this.cbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvincia.FormattingEnabled = true;
            this.cbProvincia.Location = new System.Drawing.Point(310, 49);
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.Size = new System.Drawing.Size(123, 21);
            this.cbProvincia.TabIndex = 42;
            this.cbProvincia.SelectedIndexChanged += new System.EventHandler(this.cbProvincia_SelectedIndexChanged_1);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(245, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Ambientes";
            // 
            // cbPais
            // 
            this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(105, 50);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(123, 21);
            this.cbPais.TabIndex = 37;
            this.cbPais.SelectedIndexChanged += new System.EventHandler(this.cbPais_SelectedIndexChanged_1);
            // 
            // cbAmbientes
            // 
            this.cbAmbientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAmbientes.FormattingEnabled = true;
            this.cbAmbientes.Location = new System.Drawing.Point(310, 22);
            this.cbAmbientes.Name = "cbAmbientes";
            this.cbAmbientes.Size = new System.Drawing.Size(123, 21);
            this.cbAmbientes.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Barrio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "País";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Localidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Provincia";
            // 
            // frmBuscarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 165);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.tabControlTiposDeBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarPedidos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Pedidos";
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabControlTiposDeBusqueda.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox tbNombresInquilinos;
        private System.Windows.Forms.Label lNombreCliente;
        private System.Windows.Forms.TabControl tabControlTiposDeBusqueda;
        private System.Windows.Forms.TabPage tabPage1;
        private GI.Framework.ComboBox cbMonedaReal;
        private System.Windows.Forms.TextBox textBoxValorHasta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxValorDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private GI.Framework.ComboBox cbBarrio;
        private GI.Framework.ComboBox cbTipoPropiedad;
        private GI.Framework.ComboBox cbLocalidad;
        private GI.Framework.ComboBox cbEstadoPropiedad;
        private GI.Framework.ComboBox cbProvincia;
        private System.Windows.Forms.Label label18;
        private GI.Framework.ComboBox cbPais;
        private GI.Framework.ComboBox cbAmbientes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}