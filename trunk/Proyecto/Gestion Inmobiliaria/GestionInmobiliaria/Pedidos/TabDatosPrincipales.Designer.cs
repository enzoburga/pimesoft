namespace GI.UI.Pedidos
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
            this.LinkContacto = new System.Windows.Forms.LinkLabel();
            this.label20 = new System.Windows.Forms.Label();
            this.cbCategoria = new GI.Framework.ComboBox();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label19 = new System.Windows.Forms.Label();
            this.tbValorDesde = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbMoneda = new GI.Framework.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEstado = new GI.Framework.ComboBox();
            this.cbTipoPropiedad = new GI.Framework.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbValorHasta = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMedidaTerrenoHasta = new System.Windows.Forms.TextBox();
            this.tbMedidaTerrenoDesde = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbMetrosCubiertosHasta = new System.Windows.Forms.TextBox();
            this.tbMetrosCubiertosDesde = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbAmbientesInicial = new GI.Framework.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbAmbientesFinal = new GI.Framework.ComboBox();
            this.gbDepartamento = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbEsAptoProfesional = new GI.Framework.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbDisposicion = new GI.Framework.ComboBox();
            this.gbTerreno = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbMetrosConstruiblesHasta = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbMetrosConstruiblesDesde = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbTipoZona = new GI.Framework.ComboBox();
            this.cbEstadoProp = new GI.Framework.ComboBox();
            this.ctrlUbicacion1 = new GI.UI.Generales.CtrlUbicacion();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbObervaciones = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbDepartamento.SuspendLayout();
            this.gbTerreno.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // LinkContacto
            // 
            this.LinkContacto.AutoSize = true;
            this.LinkContacto.Location = new System.Drawing.Point(530, 16);
            this.LinkContacto.Name = "LinkContacto";
            this.LinkContacto.Size = new System.Drawing.Size(120, 13);
            this.LinkContacto.TabIndex = 44;
            this.LinkContacto.TabStop = true;
            this.LinkContacto.Text = "Seleccione un contacto";
            this.LinkContacto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkContacto_LinkClicked);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(432, 66);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 13);
            this.label20.TabIndex = 56;
            this.label20.Text = "Tipo de Propiedad";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.pedidoBindingSource, "Categoria", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "Sin Definir"));
            this.cbCategoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "Categoria", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "Sin Definir"));
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(530, 35);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(127, 21);
            this.cbCategoria.TabIndex = 39;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataSource = typeof(GI.BR.Pedidos.Pedido);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(433, 92);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 13);
            this.label19.TabIndex = 55;
            this.label19.Text = "Estado Propiedad";
            // 
            // tbValorDesde
            // 
            this.tbValorDesde.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "ValorInicial", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "Sin Definir"));
            this.tbValorDesde.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorDesde.Location = new System.Drawing.Point(69, 19);
            this.tbValorDesde.Name = "tbValorDesde";
            this.tbValorDesde.Size = new System.Drawing.Size(73, 21);
            this.tbValorDesde.TabIndex = 46;
            this.tbValorDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(29, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 53;
            this.label16.Text = "Desde";
            // 
            // cbMoneda
            // 
            this.cbMoneda.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.pedidoBindingSource, "Moneda", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "---"));
            this.cbMoneda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "Moneda", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "---"));
            this.cbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMoneda.FormattingEnabled = true;
            this.cbMoneda.Location = new System.Drawing.Point(316, 19);
            this.cbMoneda.Name = "cbMoneda";
            this.cbMoneda.Size = new System.Drawing.Size(48, 21);
            this.cbMoneda.TabIndex = 49;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(148, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = "Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Contacto";
            // 
            // cbEstado
            // 
            this.cbEstado.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.pedidoBindingSource, "Estado", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "Sin Definir"));
            this.cbEstado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "Estado", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "Sin Definir"));
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(530, 116);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(127, 21);
            this.cbEstado.TabIndex = 43;
            this.cbEstado.Visible = false;
            // 
            // cbTipoPropiedad
            // 
            this.cbTipoPropiedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPropiedad.FormattingEnabled = true;
            this.cbTipoPropiedad.Location = new System.Drawing.Point(530, 62);
            this.cbTipoPropiedad.Name = "cbTipoPropiedad";
            this.cbTipoPropiedad.Size = new System.Drawing.Size(127, 21);
            this.cbTipoPropiedad.TabIndex = 41;
            this.cbTipoPropiedad.SelectedIndexChanged += new System.EventHandler(this.cbTipoPropiedad_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Estado";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Moneda";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.tbValorHasta);
            this.groupBox1.Controls.Add(this.tbValorDesde);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbMoneda);
            this.groupBox1.Location = new System.Drawing.Point(16, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 52);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valor";
            // 
            // tbValorHasta
            // 
            this.tbValorHasta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "ValorFinal", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "Sin Definir"));
            this.tbValorHasta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorHasta.Location = new System.Drawing.Point(189, 19);
            this.tbValorHasta.Name = "tbValorHasta";
            this.tbValorHasta.Size = new System.Drawing.Size(73, 21);
            this.tbValorHasta.TabIndex = 46;
            this.tbValorHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbMedidaTerrenoHasta);
            this.groupBox2.Controls.Add(this.tbMedidaTerrenoDesde);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(16, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 52);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medida Terreno [Metros]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Desde";
            // 
            // tbMedidaTerrenoHasta
            // 
            this.tbMedidaTerrenoHasta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "MetrosTerrenoFinal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbMedidaTerrenoHasta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMedidaTerrenoHasta.Location = new System.Drawing.Point(189, 20);
            this.tbMedidaTerrenoHasta.Name = "tbMedidaTerrenoHasta";
            this.tbMedidaTerrenoHasta.Size = new System.Drawing.Size(73, 21);
            this.tbMedidaTerrenoHasta.TabIndex = 46;
            this.tbMedidaTerrenoHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbMedidaTerrenoDesde
            // 
            this.tbMedidaTerrenoDesde.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "MetrosTerrenoInicial", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbMedidaTerrenoDesde.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMedidaTerrenoDesde.Location = new System.Drawing.Point(69, 20);
            this.tbMedidaTerrenoDesde.Name = "tbMedidaTerrenoDesde";
            this.tbMedidaTerrenoDesde.Size = new System.Drawing.Size(73, 21);
            this.tbMedidaTerrenoDesde.TabIndex = 46;
            this.tbMedidaTerrenoDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Hasta";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbMetrosCubiertosHasta);
            this.groupBox3.Controls.Add(this.tbMetrosCubiertosDesde);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(16, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 52);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Metros Cubiertos [Metros]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Desde";
            // 
            // tbMetrosCubiertosHasta
            // 
            this.tbMetrosCubiertosHasta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "MetrosCubiertosFinal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbMetrosCubiertosHasta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMetrosCubiertosHasta.Location = new System.Drawing.Point(189, 20);
            this.tbMetrosCubiertosHasta.Name = "tbMetrosCubiertosHasta";
            this.tbMetrosCubiertosHasta.Size = new System.Drawing.Size(73, 21);
            this.tbMetrosCubiertosHasta.TabIndex = 46;
            this.tbMetrosCubiertosHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbMetrosCubiertosDesde
            // 
            this.tbMetrosCubiertosDesde.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "MetrosCubiertosInicial", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbMetrosCubiertosDesde.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMetrosCubiertosDesde.Location = new System.Drawing.Point(69, 20);
            this.tbMetrosCubiertosDesde.Name = "tbMetrosCubiertosDesde";
            this.tbMetrosCubiertosDesde.Size = new System.Drawing.Size(73, 21);
            this.tbMetrosCubiertosDesde.TabIndex = 46;
            this.tbMetrosCubiertosDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Hasta";
            // 
            // cbAmbientesInicial
            // 
            this.cbAmbientesInicial.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.pedidoBindingSource, "CantidadAmbientesInicial", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "Sin Definir"));
            this.cbAmbientesInicial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "CantidadAmbientesInicial", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "Sin Definir"));
            this.cbAmbientesInicial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAmbientesInicial.FormattingEnabled = true;
            this.cbAmbientesInicial.Location = new System.Drawing.Point(69, 20);
            this.cbAmbientesInicial.Name = "cbAmbientesInicial";
            this.cbAmbientesInicial.Size = new System.Drawing.Size(73, 21);
            this.cbAmbientesInicial.TabIndex = 50;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.cbAmbientesFinal);
            this.groupBox4.Controls.Add(this.cbAmbientesInicial);
            this.groupBox4.Location = new System.Drawing.Point(16, 276);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(409, 52);
            this.groupBox4.TabIndex = 57;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cantidad de Ambientes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Desde";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(148, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Hasta";
            // 
            // cbAmbientesFinal
            // 
            this.cbAmbientesFinal.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.pedidoBindingSource, "CantidadAmbientesFinal", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "Sin Definir"));
            this.cbAmbientesFinal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "CantidadAmbientesFinal", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "Sin Definir"));
            this.cbAmbientesFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAmbientesFinal.FormattingEnabled = true;
            this.cbAmbientesFinal.Location = new System.Drawing.Point(189, 20);
            this.cbAmbientesFinal.Name = "cbAmbientesFinal";
            this.cbAmbientesFinal.Size = new System.Drawing.Size(73, 21);
            this.cbAmbientesFinal.TabIndex = 50;
            // 
            // gbDepartamento
            // 
            this.gbDepartamento.Controls.Add(this.label11);
            this.gbDepartamento.Controls.Add(this.cbEsAptoProfesional);
            this.gbDepartamento.Controls.Add(this.label12);
            this.gbDepartamento.Controls.Add(this.cbDisposicion);
            this.gbDepartamento.Location = new System.Drawing.Point(16, 334);
            this.gbDepartamento.Name = "gbDepartamento";
            this.gbDepartamento.Size = new System.Drawing.Size(409, 52);
            this.gbDepartamento.TabIndex = 57;
            this.gbDepartamento.TabStop = false;
            this.gbDepartamento.Text = "Departamento";
            this.gbDepartamento.EnabledChanged += new System.EventHandler(this.gbDepartamento_EnabledChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(162, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "Es apto Profesional";
            // 
            // cbEsAptoProfesional
            // 
            this.cbEsAptoProfesional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEsAptoProfesional.FormattingEnabled = true;
            this.cbEsAptoProfesional.Location = new System.Drawing.Point(267, 20);
            this.cbEsAptoProfesional.Name = "cbEsAptoProfesional";
            this.cbEsAptoProfesional.Size = new System.Drawing.Size(73, 21);
            this.cbEsAptoProfesional.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Disposición";
            // 
            // cbDisposicion
            // 
            this.cbDisposicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisposicion.FormattingEnabled = true;
            this.cbDisposicion.Location = new System.Drawing.Point(69, 20);
            this.cbDisposicion.Name = "cbDisposicion";
            this.cbDisposicion.Size = new System.Drawing.Size(73, 21);
            this.cbDisposicion.TabIndex = 50;
            // 
            // gbTerreno
            // 
            this.gbTerreno.Controls.Add(this.groupBox7);
            this.gbTerreno.Controls.Add(this.label17);
            this.gbTerreno.Controls.Add(this.cbTipoZona);
            this.gbTerreno.Location = new System.Drawing.Point(16, 392);
            this.gbTerreno.Name = "gbTerreno";
            this.gbTerreno.Size = new System.Drawing.Size(409, 69);
            this.gbTerreno.TabIndex = 57;
            this.gbTerreno.TabStop = false;
            this.gbTerreno.Text = "Terreno";
            this.gbTerreno.EnabledChanged += new System.EventHandler(this.gbTerreno_EnabledChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.tbMetrosConstruiblesHasta);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.tbMetrosConstruiblesDesde);
            this.groupBox7.Location = new System.Drawing.Point(7, 16);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(255, 44);
            this.groupBox7.TabIndex = 54;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Metros Construibles";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 53;
            this.label14.Text = "Desde";
            // 
            // tbMetrosConstruiblesHasta
            // 
            this.tbMetrosConstruiblesHasta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "MetrosConstruiblesFinal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbMetrosConstruiblesHasta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMetrosConstruiblesHasta.Location = new System.Drawing.Point(172, 16);
            this.tbMetrosConstruiblesHasta.Name = "tbMetrosConstruiblesHasta";
            this.tbMetrosConstruiblesHasta.Size = new System.Drawing.Size(73, 21);
            this.tbMetrosConstruiblesHasta.TabIndex = 46;
            this.tbMetrosConstruiblesHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(131, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Hasta";
            // 
            // tbMetrosConstruiblesDesde
            // 
            this.tbMetrosConstruiblesDesde.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "MetrosConstruiblesInicial", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbMetrosConstruiblesDesde.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMetrosConstruiblesDesde.Location = new System.Drawing.Point(52, 16);
            this.tbMetrosConstruiblesDesde.Name = "tbMetrosConstruiblesDesde";
            this.tbMetrosConstruiblesDesde.Size = new System.Drawing.Size(73, 21);
            this.tbMetrosConstruiblesDesde.TabIndex = 46;
            this.tbMetrosConstruiblesDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(271, 35);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 52;
            this.label17.Text = "Zona";
            // 
            // cbTipoZona
            // 
            this.cbTipoZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoZona.FormattingEnabled = true;
            this.cbTipoZona.Location = new System.Drawing.Point(309, 32);
            this.cbTipoZona.Name = "cbTipoZona";
            this.cbTipoZona.Size = new System.Drawing.Size(94, 21);
            this.cbTipoZona.TabIndex = 49;
            // 
            // cbEstadoProp
            // 
            this.cbEstadoProp.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.pedidoBindingSource, "EnumEstado", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "Sin Definir"));
            this.cbEstadoProp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "EnumEstado", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "Sin Definir"));
            this.cbEstadoProp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoProp.FormattingEnabled = true;
            this.cbEstadoProp.Location = new System.Drawing.Point(530, 89);
            this.cbEstadoProp.Name = "cbEstadoProp";
            this.cbEstadoProp.Size = new System.Drawing.Size(127, 21);
            this.cbEstadoProp.TabIndex = 51;
            // 
            // ctrlUbicacion1
            // 
            this.ctrlUbicacion1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlUbicacion1.Location = new System.Drawing.Point(16, 7);
            this.ctrlUbicacion1.Name = "ctrlUbicacion1";
            this.ctrlUbicacion1.OpcionTodos = true;
            this.ctrlUbicacion1.Size = new System.Drawing.Size(415, 89);
            this.ctrlUbicacion1.SoloLectura = false;
            this.ctrlUbicacion1.TabIndex = 58;
            this.ctrlUbicacion1.Ubicacion = new GI.BR.Propiedades.Ubicacion();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbObervaciones);
            this.groupBox5.Location = new System.Drawing.Point(431, 160);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(252, 301);
            this.groupBox5.TabIndex = 59;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Observaciones";
            // 
            // tbObervaciones
            // 
            this.tbObervaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbObervaciones.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "Observaciones", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbObervaciones.Location = new System.Drawing.Point(7, 19);
            this.tbObervaciones.Multiline = true;
            this.tbObervaciones.Name = "tbObervaciones";
            this.tbObervaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbObervaciones.Size = new System.Drawing.Size(239, 276);
            this.tbObervaciones.TabIndex = 19;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(554, 143);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 17);
            this.checkBox1.TabIndex = 60;
            this.checkBox1.Text = "Pedido Histórico";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TabDatosPrincipales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.ctrlUbicacion1);
            this.Controls.Add(this.LinkContacto);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbEstadoProp);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cbTipoPropiedad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbTerreno);
            this.Controls.Add(this.gbDepartamento);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TabDatosPrincipales";
            this.Size = new System.Drawing.Size(699, 478);
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbDepartamento.ResumeLayout(false);
            this.gbDepartamento.PerformLayout();
            this.gbTerreno.ResumeLayout(false);
            this.gbTerreno.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LinkContacto;
        private System.Windows.Forms.Label label20;
        private GI.Framework.ComboBox cbCategoria;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbValorDesde;
        private System.Windows.Forms.Label label16;
        private GI.Framework.ComboBox cbMoneda;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private GI.Framework.ComboBox cbEstado;
        private GI.Framework.ComboBox cbTipoPropiedad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private GI.UI.Generales.CtrlUbicacion ctrlUbicacion1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMedidaTerrenoDesde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMetrosCubiertosDesde;
        private System.Windows.Forms.Label label9;
        private GI.Framework.ComboBox cbAmbientesInicial;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private GI.Framework.ComboBox cbAmbientesFinal;
        private System.Windows.Forms.GroupBox gbDepartamento;
        private System.Windows.Forms.Label label12;
        private GI.Framework.ComboBox cbDisposicion;
        private System.Windows.Forms.GroupBox gbTerreno;
        private System.Windows.Forms.TextBox tbMedidaTerrenoHasta;
        private System.Windows.Forms.TextBox tbMetrosCubiertosHasta;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox tbValorHasta;
        private System.Windows.Forms.Label label17;
        private GI.Framework.ComboBox cbTipoZona;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbMetrosConstruiblesHasta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbMetrosConstruiblesDesde;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private GI.Framework.ComboBox cbEstadoProp;
        private System.Windows.Forms.Label label11;
        private GI.Framework.ComboBox cbEsAptoProfesional;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbObervaciones;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
