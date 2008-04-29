namespace GI.UI.AdminAlquileres
{
    partial class TabDatosPrincipales
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBoxEsPropietario = new System.Windows.Forms.CheckBox();
            this.LinkPropiedad = new System.Windows.Forms.LinkLabel();
            this.admAlquilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.LinkPropietario = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.propiedadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.contratoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.tbDepositoContrato = new System.Windows.Forms.TextBox();
            this.DepositoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbMonedaDepositoContrato = new GI.Framework.ComboBox();
            this.tbMontoContrato = new System.Windows.Forms.TextBox();
            this.MontoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbMonedaMontoContrato = new GI.Framework.ComboBox();
            this.tbDiaVto = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LinkInquilino = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.ctrlDireccion1 = new GI.UI.Generales.CtrlDireccion();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admAlquilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propiedadBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contratoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepositoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBoxEsPropietario);
            this.groupBox2.Controls.Add(this.LinkPropiedad);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.LinkPropietario);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(14, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 71);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Propiedad";
            // 
            // cBoxEsPropietario
            // 
            this.cBoxEsPropietario.AutoSize = true;
            this.cBoxEsPropietario.Location = new System.Drawing.Point(310, 26);
            this.cBoxEsPropietario.Name = "cBoxEsPropietario";
            this.cBoxEsPropietario.Size = new System.Drawing.Size(92, 17);
            this.cBoxEsPropietario.TabIndex = 29;
            this.cBoxEsPropietario.Text = "Es Propietario";
            this.cBoxEsPropietario.UseVisualStyleBackColor = true;
            this.cBoxEsPropietario.CheckedChanged += new System.EventHandler(this.cBoxEsPropietario_CheckedChanged);
            // 
            // LinkPropiedad
            // 
            this.LinkPropiedad.AutoSize = true;
            this.LinkPropiedad.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.admAlquilerBindingSource, "Alquiler", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LinkPropiedad.Location = new System.Drawing.Point(74, 49);
            this.LinkPropiedad.Name = "LinkPropiedad";
            this.LinkPropiedad.Size = new System.Drawing.Size(129, 13);
            this.LinkPropiedad.TabIndex = 26;
            this.LinkPropiedad.TabStop = true;
            this.LinkPropiedad.Text = "Seleccione una Propiedad";
            this.LinkPropiedad.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkPropiedad_LinkClicked);
            // 
            // admAlquilerBindingSource
            // 
            this.admAlquilerBindingSource.DataSource = typeof(GI.BR.AdmAlquileres.AdmAlquiler);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Código";
            // 
            // LinkPropietario
            // 
            this.LinkPropietario.AutoSize = true;
            this.LinkPropietario.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.admAlquilerBindingSource, "Contacto", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LinkPropietario.Location = new System.Drawing.Point(74, 26);
            this.LinkPropietario.Name = "LinkPropietario";
            this.LinkPropietario.Size = new System.Drawing.Size(119, 13);
            this.LinkPropietario.TabIndex = 28;
            this.LinkPropietario.TabStop = true;
            this.LinkPropietario.Text = "Seleccione un Contacto";
            this.LinkPropietario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkPropietario_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Contacto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // propiedadBindingSource
            // 
            this.propiedadBindingSource.DataSource = typeof(GI.BR.Propiedades.Propiedad);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbObservaciones);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tbDepositoContrato);
            this.groupBox1.Controls.Add(this.cbMonedaDepositoContrato);
            this.groupBox1.Controls.Add(this.tbMontoContrato);
            this.groupBox1.Controls.Add(this.cbMonedaMontoContrato);
            this.groupBox1.Controls.Add(this.tbDiaVto);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.dtpFechaVencimiento);
            this.groupBox1.Controls.Add(this.dtpFechaInicio);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LinkInquilino);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(14, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 270);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contrato";
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contratoBindingSource, "Observaciones", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "\"\""));
            this.tbObservaciones.Location = new System.Drawing.Point(13, 175);
            this.tbObservaciones.Multiline = true;
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbObservaciones.Size = new System.Drawing.Size(390, 89);
            this.tbObservaciones.TabIndex = 45;
            this.tbObservaciones.Text = "Este espacio esta destinado a comentarios.";
            // 
            // contratoBindingSource
            // 
            this.contratoBindingSource.DataSource = typeof(GI.BR.AdmAlquileres.Contrato);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "Observaciones";
            // 
            // tbDepositoContrato
            // 
            this.tbDepositoContrato.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DepositoBindingSource, "Importe", true));
            this.tbDepositoContrato.Location = new System.Drawing.Point(86, 104);
            this.tbDepositoContrato.Name = "tbDepositoContrato";
            this.tbDepositoContrato.Size = new System.Drawing.Size(57, 21);
            this.tbDepositoContrato.TabIndex = 42;
            this.tbDepositoContrato.Text = "145700";
            this.tbDepositoContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DepositoBindingSource
            // 
            this.DepositoBindingSource.DataSource = typeof(GI.BR.Valor);
            // 
            // cbMonedaDepositoContrato
            // 
            this.cbMonedaDepositoContrato.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DepositoBindingSource, "Moneda", true));
            this.cbMonedaDepositoContrato.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.DepositoBindingSource, "Moneda", true));
            this.cbMonedaDepositoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonedaDepositoContrato.FormattingEnabled = true;
            this.cbMonedaDepositoContrato.Location = new System.Drawing.Point(149, 104);
            this.cbMonedaDepositoContrato.Name = "cbMonedaDepositoContrato";
            this.cbMonedaDepositoContrato.Size = new System.Drawing.Size(47, 21);
            this.cbMonedaDepositoContrato.TabIndex = 43;
            // 
            // tbMontoContrato
            // 
            this.tbMontoContrato.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MontoBindingSource, "Importe", true));
            this.tbMontoContrato.Location = new System.Drawing.Point(86, 76);
            this.tbMontoContrato.Name = "tbMontoContrato";
            this.tbMontoContrato.Size = new System.Drawing.Size(57, 21);
            this.tbMontoContrato.TabIndex = 40;
            this.tbMontoContrato.Text = "145700";
            this.tbMontoContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MontoBindingSource
            // 
            this.MontoBindingSource.DataSource = typeof(GI.BR.Valor);
            // 
            // cbMonedaMontoContrato
            // 
            this.cbMonedaMontoContrato.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.MontoBindingSource, "Moneda", true));
            this.cbMonedaMontoContrato.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MontoBindingSource, "Moneda", true));
            this.cbMonedaMontoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonedaMontoContrato.FormattingEnabled = true;
            this.cbMonedaMontoContrato.Location = new System.Drawing.Point(149, 76);
            this.cbMonedaMontoContrato.Name = "cbMonedaMontoContrato";
            this.cbMonedaMontoContrato.Size = new System.Drawing.Size(47, 21);
            this.cbMonedaMontoContrato.TabIndex = 41;
            // 
            // tbDiaVto
            // 
            this.tbDiaVto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contratoBindingSource, "DiaCobro", true));
            this.tbDiaVto.Location = new System.Drawing.Point(316, 76);
            this.tbDiaVto.Name = "tbDiaVto";
            this.tbDiaVto.Size = new System.Drawing.Size(29, 21);
            this.tbDiaVto.TabIndex = 37;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contratoBindingSource, "FechaCancelacion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "d"));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(316, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(86, 21);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contratoBindingSource, "FechaVencimiento", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(316, 49);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(86, 21);
            this.dtpFechaVencimiento.TabIndex = 36;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contratoBindingSource, "FechaInicio", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(86, 49);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(86, 21);
            this.dtpFechaInicio.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Depósito";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Día Vto. Cuota";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Monto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(214, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Fecha Cancelación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Fecha Vencimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Fecha Inicio";
            // 
            // LinkInquilino
            // 
            this.LinkInquilino.AutoSize = true;
            this.LinkInquilino.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.contratoBindingSource, "Inquilino", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LinkInquilino.Location = new System.Drawing.Point(86, 26);
            this.LinkInquilino.Name = "LinkInquilino";
            this.LinkInquilino.Size = new System.Drawing.Size(115, 13);
            this.LinkInquilino.TabIndex = 28;
            this.LinkInquilino.TabStop = true;
            this.LinkInquilino.Text = "Seleccione un Inquilino";
            this.LinkInquilino.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkInquilino_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Inquilino";
            // 
            // ctrlDireccion1
            // 
            this.ctrlDireccion1.Direccion = null;
            this.ctrlDireccion1.Location = new System.Drawing.Point(14, 89);
            this.ctrlDireccion1.Name = "ctrlDireccion1";
            this.ctrlDireccion1.Size = new System.Drawing.Size(417, 113);
            this.ctrlDireccion1.SoloLectura = false;
            this.ctrlDireccion1.TabIndex = 30;
            // 
            // TabDatosPrincipales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlDireccion1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TabDatosPrincipales";
            this.Size = new System.Drawing.Size(444, 493);
            this.Load += new System.EventHandler(this.TabDatosPrincipales_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admAlquilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propiedadBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contratoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepositoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel LinkPropiedad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LinkPropietario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel LinkInquilino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDiaVto;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.TextBox tbDepositoContrato;
        private GI.Framework.ComboBox cbMonedaDepositoContrato;
        private System.Windows.Forms.TextBox tbMontoContrato;
        private GI.Framework.ComboBox cbMonedaMontoContrato;
        private System.Windows.Forms.TextBox tbObservaciones;
        private System.Windows.Forms.Label label14;
        private GI.UI.Generales.CtrlDireccion ctrlDireccion1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource propiedadBindingSource;
        private System.Windows.Forms.BindingSource MontoBindingSource;
        private System.Windows.Forms.BindingSource contratoBindingSource;
        private System.Windows.Forms.BindingSource admAlquilerBindingSource;
        private System.Windows.Forms.BindingSource DepositoBindingSource;
        private System.Windows.Forms.CheckBox cBoxEsPropietario;

    }
}
