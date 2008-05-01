namespace GI.UI.Generales
{
    partial class CtrlContrato
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
            this.tbDepositoContrato = new System.Windows.Forms.TextBox();
            this.valorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbMontoContrato = new System.Windows.Forms.TextBox();
            this.valorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.contratoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LinkInquilino = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxCancelado = new System.Windows.Forms.CheckBox();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbMonedaDepositoContrato = new GI.Framework.ComboBox();
            this.cbMonedaMontoContrato = new GI.Framework.ComboBox();
            this.tbDiaVto = new System.Windows.Forms.TextBox();
            this.dtpFechaCancelacion = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.valorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDepositoContrato
            // 
            this.tbDepositoContrato.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.valorBindingSource1, "Importe", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.tbDepositoContrato.Location = new System.Drawing.Point(86, 104);
            this.tbDepositoContrato.Name = "tbDepositoContrato";
            this.tbDepositoContrato.Size = new System.Drawing.Size(57, 20);
            this.tbDepositoContrato.TabIndex = 42;
            this.tbDepositoContrato.Text = "145700";
            this.tbDepositoContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // valorBindingSource1
            // 
            this.valorBindingSource1.DataSource = typeof(GI.BR.Valor);
            // 
            // tbMontoContrato
            // 
            this.tbMontoContrato.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.valorBindingSource, "Importe", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.tbMontoContrato.Location = new System.Drawing.Point(86, 76);
            this.tbMontoContrato.Name = "tbMontoContrato";
            this.tbMontoContrato.Size = new System.Drawing.Size(57, 20);
            this.tbMontoContrato.TabIndex = 40;
            this.tbMontoContrato.Text = "145700";
            this.tbMontoContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // valorBindingSource
            // 
            this.valorBindingSource.DataSource = typeof(GI.BR.Valor);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contratoBindingSource, "FechaInicio", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "d"));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(86, 49);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(86, 20);
            this.dtpFechaInicio.TabIndex = 35;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // contratoBindingSource
            // 
            this.contratoBindingSource.DataSource = typeof(GI.BR.AdmAlquileres.Contrato);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Monto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Fecha Vencimiento";
            // 
            // LinkInquilino
            // 
            this.LinkInquilino.AutoSize = true;
            this.LinkInquilino.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.contratoBindingSource, "Inquilino", true));
            this.LinkInquilino.Location = new System.Drawing.Point(86, 26);
            this.LinkInquilino.Name = "LinkInquilino";
            this.LinkInquilino.Size = new System.Drawing.Size(117, 13);
            this.LinkInquilino.TabIndex = 28;
            this.LinkInquilino.TabStop = true;
            this.LinkInquilino.Text = "Seleccione un Inquilino";
            this.LinkInquilino.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkInquilino_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxCancelado);
            this.groupBox1.Controls.Add(this.tbObservaciones);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tbDepositoContrato);
            this.groupBox1.Controls.Add(this.cbMonedaDepositoContrato);
            this.groupBox1.Controls.Add(this.tbMontoContrato);
            this.groupBox1.Controls.Add(this.cbMonedaMontoContrato);
            this.groupBox1.Controls.Add(this.tbDiaVto);
            this.groupBox1.Controls.Add(this.dtpFechaCancelacion);
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
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 270);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contrato";
            // 
            // cBoxCancelado
            // 
            this.cBoxCancelado.AutoSize = true;
            this.cBoxCancelado.Location = new System.Drawing.Point(316, 131);
            this.cBoxCancelado.Name = "cBoxCancelado";
            this.cBoxCancelado.Size = new System.Drawing.Size(77, 17);
            this.cBoxCancelado.TabIndex = 46;
            this.cBoxCancelado.Text = "Cancelado";
            this.cBoxCancelado.UseVisualStyleBackColor = true;
            this.cBoxCancelado.CheckedChanged += new System.EventHandler(this.cBoxCancelado_CheckedChanged);
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contratoBindingSource, "Observaciones", true));
            this.tbObservaciones.Location = new System.Drawing.Point(13, 175);
            this.tbObservaciones.Multiline = true;
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbObservaciones.Size = new System.Drawing.Size(390, 89);
            this.tbObservaciones.TabIndex = 45;
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
            // cbMonedaDepositoContrato
            // 
            this.cbMonedaDepositoContrato.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.valorBindingSource1, "Moneda", true));
            this.cbMonedaDepositoContrato.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.valorBindingSource1, "Moneda", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbMonedaDepositoContrato.DisplayMember = "Moneda";
            this.cbMonedaDepositoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonedaDepositoContrato.FormattingEnabled = true;
            this.cbMonedaDepositoContrato.Location = new System.Drawing.Point(149, 104);
            this.cbMonedaDepositoContrato.Name = "cbMonedaDepositoContrato";
            this.cbMonedaDepositoContrato.Size = new System.Drawing.Size(47, 21);
            this.cbMonedaDepositoContrato.TabIndex = 43;
            this.cbMonedaDepositoContrato.ValueMember = "Moneda";
            // 
            // cbMonedaMontoContrato
            // 
            this.cbMonedaMontoContrato.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.valorBindingSource, "Moneda", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbMonedaMontoContrato.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.valorBindingSource, "Moneda", true));
            this.cbMonedaMontoContrato.DisplayMember = "Moneda";
            this.cbMonedaMontoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonedaMontoContrato.FormattingEnabled = true;
            this.cbMonedaMontoContrato.Location = new System.Drawing.Point(149, 76);
            this.cbMonedaMontoContrato.Name = "cbMonedaMontoContrato";
            this.cbMonedaMontoContrato.Size = new System.Drawing.Size(47, 21);
            this.cbMonedaMontoContrato.TabIndex = 41;
            this.cbMonedaMontoContrato.ValueMember = "Moneda";
            // 
            // tbDiaVto
            // 
            this.tbDiaVto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contratoBindingSource, "DiaCobro", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbDiaVto.Location = new System.Drawing.Point(316, 76);
            this.tbDiaVto.Name = "tbDiaVto";
            this.tbDiaVto.Size = new System.Drawing.Size(29, 20);
            this.tbDiaVto.TabIndex = 37;
            // 
            // dtpFechaCancelacion
            // 
            this.dtpFechaCancelacion.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contratoBindingSource, "FechaCancelacion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "d"));
            this.dtpFechaCancelacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCancelacion.Location = new System.Drawing.Point(316, 103);
            this.dtpFechaCancelacion.Name = "dtpFechaCancelacion";
            this.dtpFechaCancelacion.Size = new System.Drawing.Size(86, 20);
            this.dtpFechaCancelacion.TabIndex = 36;
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contratoBindingSource, "FechaVencimiento", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "d"));
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(316, 49);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(86, 20);
            this.dtpFechaVencimiento.TabIndex = 36;
            this.dtpFechaVencimiento.ValueChanged += new System.EventHandler(this.dtpFechaVencimiento_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Día Vto. Cuota";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(214, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Fecha Cancelación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Fecha Inicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Inquilino";
            // 
            // CtrlContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "CtrlContrato";
            this.Size = new System.Drawing.Size(409, 270);
            ((System.ComponentModel.ISupportInitialize)(this.valorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbDepositoContrato;
        private GI.Framework.ComboBox cbMonedaDepositoContrato;
        private System.Windows.Forms.TextBox tbMontoContrato;
        private GI.Framework.ComboBox cbMonedaMontoContrato;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel LinkInquilino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cBoxCancelado;
        private System.Windows.Forms.TextBox tbObservaciones;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbDiaVto;
        private System.Windows.Forms.DateTimePicker dtpFechaCancelacion;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource valorBindingSource;
        private System.Windows.Forms.BindingSource valorBindingSource1;
        private System.Windows.Forms.BindingSource contratoBindingSource;
    }
}