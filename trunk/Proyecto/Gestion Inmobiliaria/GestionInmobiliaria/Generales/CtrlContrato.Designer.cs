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
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.contratoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LinkInquilino = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.llModificarMonto = new System.Windows.Forms.LinkLabel();
            this.llEliminarMonto = new System.Windows.Forms.LinkLabel();
            this.llAgregarMonto = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvMontos = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.cBoxCancelado = new System.Windows.Forms.CheckBox();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbMonedaDepositoContrato = new GI.Framework.ComboBox();
            this.tbDiaVto = new System.Windows.Forms.TextBox();
            this.dtpFechaCancelacion = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.valorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDepositoContrato
            // 
            this.tbDepositoContrato.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.valorBindingSource1, "Importe", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.tbDepositoContrato.Location = new System.Drawing.Point(86, 66);
            this.tbDepositoContrato.Name = "tbDepositoContrato";
            this.tbDepositoContrato.Size = new System.Drawing.Size(57, 20);
            this.tbDepositoContrato.TabIndex = 6;
            this.tbDepositoContrato.Text = "145700";
            this.tbDepositoContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // valorBindingSource1
            // 
            this.valorBindingSource1.DataSource = typeof(GI.BR.Valor);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contratoBindingSource, "FechaInicio", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "d"));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(86, 39);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(86, 20);
            this.dtpFechaInicio.TabIndex = 1;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // contratoBindingSource
            // 
            this.contratoBindingSource.DataSource = typeof(GI.BR.AdmAlquileres.Contrato);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Depósito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Fecha Vencimiento";
            // 
            // LinkInquilino
            // 
            this.LinkInquilino.AutoSize = true;
            this.LinkInquilino.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.contratoBindingSource, "Inquilino", true));
            this.LinkInquilino.Location = new System.Drawing.Point(86, 16);
            this.LinkInquilino.Name = "LinkInquilino";
            this.LinkInquilino.Size = new System.Drawing.Size(117, 13);
            this.LinkInquilino.TabIndex = 0;
            this.LinkInquilino.TabStop = true;
            this.LinkInquilino.Text = "Seleccione un Inquilino";
            this.LinkInquilino.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkInquilino_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.llModificarMonto);
            this.groupBox1.Controls.Add(this.llEliminarMonto);
            this.groupBox1.Controls.Add(this.llAgregarMonto);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cBoxCancelado);
            this.groupBox1.Controls.Add(this.tbObservaciones);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tbDepositoContrato);
            this.groupBox1.Controls.Add(this.cbMonedaDepositoContrato);
            this.groupBox1.Controls.Add(this.tbDiaVto);
            this.groupBox1.Controls.Add(this.dtpFechaCancelacion);
            this.groupBox1.Controls.Add(this.dtpFechaVencimiento);
            this.groupBox1.Controls.Add(this.dtpFechaInicio);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LinkInquilino);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 314);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contrato";
            // 
            // llModificarMonto
            // 
            this.llModificarMonto.AutoSize = true;
            this.llModificarMonto.Location = new System.Drawing.Point(296, 209);
            this.llModificarMonto.Name = "llModificarMonto";
            this.llModificarMonto.Size = new System.Drawing.Size(50, 13);
            this.llModificarMonto.TabIndex = 46;
            this.llModificarMonto.TabStop = true;
            this.llModificarMonto.Text = "Modificar";
            this.llModificarMonto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llModificarMonto_LinkClicked);
            // 
            // llEliminarMonto
            // 
            this.llEliminarMonto.AutoSize = true;
            this.llEliminarMonto.Location = new System.Drawing.Point(352, 209);
            this.llEliminarMonto.Name = "llEliminarMonto";
            this.llEliminarMonto.Size = new System.Drawing.Size(43, 13);
            this.llEliminarMonto.TabIndex = 46;
            this.llEliminarMonto.TabStop = true;
            this.llEliminarMonto.Text = "Eliminar";
            this.llEliminarMonto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llEliminarMonto_LinkClicked);
            // 
            // llAgregarMonto
            // 
            this.llAgregarMonto.AutoSize = true;
            this.llAgregarMonto.Location = new System.Drawing.Point(246, 209);
            this.llAgregarMonto.Name = "llAgregarMonto";
            this.llAgregarMonto.Size = new System.Drawing.Size(44, 13);
            this.llAgregarMonto.TabIndex = 46;
            this.llAgregarMonto.TabStop = true;
            this.llAgregarMonto.Text = "Agregar";
            this.llAgregarMonto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAgregarMonto_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvMontos);
            this.groupBox2.Location = new System.Drawing.Point(13, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 109);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Montos Alquiler";
            // 
            // lvMontos
            // 
            this.lvMontos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4});
            this.lvMontos.FullRowSelect = true;
            this.lvMontos.Location = new System.Drawing.Point(6, 17);
            this.lvMontos.Name = "lvMontos";
            this.lvMontos.Size = new System.Drawing.Size(377, 71);
            this.lvMontos.TabIndex = 45;
            this.lvMontos.UseCompatibleStateImageBehavior = false;
            this.lvMontos.View = System.Windows.Forms.View.Details;
            this.lvMontos.DoubleClick += new System.EventHandler(this.lvMontos_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Monto";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mes Inicio";
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Año";
            this.columnHeader4.Width = 75;
            // 
            // cBoxCancelado
            // 
            this.cBoxCancelado.AutoSize = true;
            this.cBoxCancelado.Location = new System.Drawing.Point(316, 91);
            this.cBoxCancelado.Name = "cBoxCancelado";
            this.cBoxCancelado.Size = new System.Drawing.Size(77, 17);
            this.cBoxCancelado.TabIndex = 8;
            this.cBoxCancelado.Text = "Cancelado";
            this.cBoxCancelado.UseVisualStyleBackColor = true;
            this.cBoxCancelado.CheckedChanged += new System.EventHandler(this.cBoxCancelado_CheckedChanged);
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contratoBindingSource, "Observaciones", true));
            this.tbObservaciones.Location = new System.Drawing.Point(13, 246);
            this.tbObservaciones.Multiline = true;
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbObservaciones.Size = new System.Drawing.Size(390, 61);
            this.tbObservaciones.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 230);
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
            this.cbMonedaDepositoContrato.Location = new System.Drawing.Point(148, 66);
            this.cbMonedaDepositoContrato.Name = "cbMonedaDepositoContrato";
            this.cbMonedaDepositoContrato.Size = new System.Drawing.Size(47, 21);
            this.cbMonedaDepositoContrato.TabIndex = 7;
            this.cbMonedaDepositoContrato.ValueMember = "Moneda";
            // 
            // tbDiaVto
            // 
            this.tbDiaVto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contratoBindingSource, "DiaCobro", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbDiaVto.Location = new System.Drawing.Point(86, 91);
            this.tbDiaVto.Name = "tbDiaVto";
            this.tbDiaVto.Size = new System.Drawing.Size(29, 20);
            this.tbDiaVto.TabIndex = 5;
            // 
            // dtpFechaCancelacion
            // 
            this.dtpFechaCancelacion.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contratoBindingSource, "FechaCancelacion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "d"));
            this.dtpFechaCancelacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCancelacion.Location = new System.Drawing.Point(316, 66);
            this.dtpFechaCancelacion.Name = "dtpFechaCancelacion";
            this.dtpFechaCancelacion.Size = new System.Drawing.Size(86, 20);
            this.dtpFechaCancelacion.TabIndex = 9;
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contratoBindingSource, "FechaVencimiento", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "d"));
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(316, 39);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(86, 20);
            this.dtpFechaVencimiento.TabIndex = 2;
            this.dtpFechaVencimiento.ValueChanged += new System.EventHandler(this.dtpFechaVencimiento_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Día Vto. Cuota";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(214, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Fecha Cancelación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Fecha Inicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 16);
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
            this.Size = new System.Drawing.Size(409, 317);
            ((System.ComponentModel.ISupportInitialize)(this.valorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbDepositoContrato;
        private GI.Framework.ComboBox cbMonedaDepositoContrato;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label8;
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
        private System.Windows.Forms.BindingSource valorBindingSource1;
        private System.Windows.Forms.BindingSource contratoBindingSource;
        private System.Windows.Forms.ListView lvMontos;
        private System.Windows.Forms.LinkLabel llModificarMonto;
        private System.Windows.Forms.LinkLabel llEliminarMonto;
        private System.Windows.Forms.LinkLabel llAgregarMonto;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}