namespace GI.UI.Propiedades
{
    partial class frmBuscarPropiedades
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxIdProp = new System.Windows.Forms.TextBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.cbBarrio2 = new GI.Framework.ComboBox();
            this.cbLocalidad2 = new GI.Framework.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbBarrio3 = new GI.Framework.ComboBox();
            this.cbLocalidad3 = new GI.Framework.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabControlTiposDeBusqueda.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlTiposDeBusqueda
            // 
            this.tabControlTiposDeBusqueda.Controls.Add(this.tabPage1);
            this.tabControlTiposDeBusqueda.Controls.Add(this.tabPage2);
            this.tabControlTiposDeBusqueda.Controls.Add(this.tabPage3);
            this.tabControlTiposDeBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlTiposDeBusqueda.Location = new System.Drawing.Point(0, 0);
            this.tabControlTiposDeBusqueda.Name = "tabControlTiposDeBusqueda";
            this.tabControlTiposDeBusqueda.SelectedIndex = 0;
            this.tabControlTiposDeBusqueda.Size = new System.Drawing.Size(680, 187);
            this.tabControlTiposDeBusqueda.TabIndex = 47;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.cbBarrio3);
            this.tabPage1.Controls.Add(this.cbLocalidad3);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.cbBarrio2);
            this.tabPage1.Controls.Add(this.cbLocalidad2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label14);
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
            this.tabPage1.Size = new System.Drawing.Size(672, 161);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Buscar por Ubicaci�n";
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
            this.label8.Location = new System.Drawing.Point(262, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Barrio 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Pa�s";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Localidad 1";
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
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.textBoxNumero);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.textBoxDireccion);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(672, 161);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buscar por Direcci�n";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(407, 23);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(58, 20);
            this.textBoxNumero.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(367, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Altura";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Calle";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(105, 23);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(229, 20);
            this.textBoxDireccion.TabIndex = 51;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.textBoxIdProp);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(672, 161);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Buscar por C�digo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(420, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Ingresar solo la parte n�merica del c�digo. Ej. si el c�digo es P001 ingresar sol" +
                "o 001 o 1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "C�digo";
            // 
            // textBoxIdProp
            // 
            this.textBoxIdProp.Location = new System.Drawing.Point(105, 23);
            this.textBoxIdProp.Name = "textBoxIdProp";
            this.textBoxIdProp.Size = new System.Drawing.Size(123, 20);
            this.textBoxIdProp.TabIndex = 53;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(601, 193);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 48;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // cbBarrio2
            // 
            this.cbBarrio2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBarrio2.FormattingEnabled = true;
            this.cbBarrio2.Location = new System.Drawing.Point(310, 103);
            this.cbBarrio2.Name = "cbBarrio2";
            this.cbBarrio2.Size = new System.Drawing.Size(123, 21);
            this.cbBarrio2.TabIndex = 61;
            // 
            // cbLocalidad2
            // 
            this.cbLocalidad2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocalidad2.FormattingEnabled = true;
            this.cbLocalidad2.Location = new System.Drawing.Point(105, 104);
            this.cbLocalidad2.Name = "cbLocalidad2";
            this.cbLocalidad2.Size = new System.Drawing.Size(123, 21);
            this.cbLocalidad2.TabIndex = 60;
            this.cbLocalidad2.SelectedIndexChanged += new System.EventHandler(this.cbLocalidad2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Barrio 2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 58;
            this.label14.Text = "Localidad 2";
            // 
            // cbBarrio3
            // 
            this.cbBarrio3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBarrio3.FormattingEnabled = true;
            this.cbBarrio3.Location = new System.Drawing.Point(310, 130);
            this.cbBarrio3.Name = "cbBarrio3";
            this.cbBarrio3.Size = new System.Drawing.Size(123, 21);
            this.cbBarrio3.TabIndex = 65;
            // 
            // cbLocalidad3
            // 
            this.cbLocalidad3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocalidad3.FormattingEnabled = true;
            this.cbLocalidad3.Location = new System.Drawing.Point(105, 131);
            this.cbLocalidad3.Name = "cbLocalidad3";
            this.cbLocalidad3.Size = new System.Drawing.Size(123, 21);
            this.cbLocalidad3.TabIndex = 64;
            this.cbLocalidad3.SelectedIndexChanged += new System.EventHandler(this.cbLocalidad3_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(262, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 63;
            this.label15.Text = "Barrio 3";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(40, 134);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 62;
            this.label16.Text = "Localidad 3";
            // 
            // frmBuscarPropiedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 223);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.tabControlTiposDeBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarPropiedades";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Propiedades";
            this.tabControlTiposDeBusqueda.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxIdProp;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Label label3;
        private GI.Framework.ComboBox cbBarrio3;
        private GI.Framework.ComboBox cbLocalidad3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private GI.Framework.ComboBox cbBarrio2;
        private GI.Framework.ComboBox cbLocalidad2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
    }
}