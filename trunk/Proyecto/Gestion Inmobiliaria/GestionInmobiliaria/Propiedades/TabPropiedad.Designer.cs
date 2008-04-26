namespace GI.UI.Propiedades
{
    partial class TabPropiedad
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoPropiedad = new GI.Framework.ComboBox();
            this.propiedadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbEstado = new GI.Framework.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbBarrio = new GI.Framework.ComboBox();
            this.cbLocalidad = new GI.Framework.ComboBox();
            this.cbProvincia = new GI.Framework.ComboBox();
            this.cbPais = new GI.Framework.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxEntreCalle2 = new System.Windows.Forms.TextBox();
            this.direccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxEntreCalle1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxCodigoPostal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxDpto = new System.Windows.Forms.TextBox();
            this.textBoxPiso = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxCalle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbMonedaReal = new GI.Framework.ComboBox();
            this.valorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxVarorMercado = new System.Windows.Forms.TextBox();
            this.textBoxValorPublicacion = new System.Windows.Forms.TextBox();
            this.valorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbMonedaPublicacion = new GI.Framework.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.checkBoxEsOtraPropiedad = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbAmbientes = new GI.Framework.ComboBox();
            this.cbEstadoProp = new GI.Framework.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbCategoria = new GI.Framework.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvMedidas = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.linkLabelEliminarMedida = new System.Windows.Forms.LinkLabel();
            this.linkLabelAgregarMedida = new System.Windows.Forms.LinkLabel();
            this.LinkPropietario = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.propiedadBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.direccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado";
            // 
            // cbTipoPropiedad
            // 
            this.cbTipoPropiedad.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.propiedadBindingSource, "TipoPropiedad", true));
            this.cbTipoPropiedad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propiedadBindingSource, "TipoPropiedad", true));
            this.cbTipoPropiedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPropiedad.FormattingEnabled = true;
            this.cbTipoPropiedad.Location = new System.Drawing.Point(120, 44);
            this.cbTipoPropiedad.Name = "cbTipoPropiedad";
            this.cbTipoPropiedad.Size = new System.Drawing.Size(106, 21);
            this.cbTipoPropiedad.TabIndex = 1;
            // 
            // propiedadBindingSource
            // 
            this.propiedadBindingSource.DataSource = typeof(GI.BR.Propiedades.Propiedad);
            // 
            // cbEstado
            // 
            this.cbEstado.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.propiedadBindingSource, "Estado", true));
            this.cbEstado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propiedadBindingSource, "Estado", true));
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(323, 17);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(109, 21);
            this.cbEstado.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Propietario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Código";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbBarrio);
            this.groupBox1.Controls.Add(this.cbLocalidad);
            this.groupBox1.Controls.Add(this.cbProvincia);
            this.groupBox1.Controls.Add(this.cbPais);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(41, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 84);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ubicación";
            // 
            // cbBarrio
            // 
            this.cbBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBarrio.FormattingEnabled = true;
            this.cbBarrio.Location = new System.Drawing.Point(255, 47);
            this.cbBarrio.Name = "cbBarrio";
            this.cbBarrio.Size = new System.Drawing.Size(148, 21);
            this.cbBarrio.TabIndex = 3;
            // 
            // cbLocalidad
            // 
            this.cbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocalidad.FormattingEnabled = true;
            this.cbLocalidad.Location = new System.Drawing.Point(67, 47);
            this.cbLocalidad.Name = "cbLocalidad";
            this.cbLocalidad.Size = new System.Drawing.Size(123, 21);
            this.cbLocalidad.TabIndex = 2;
            // 
            // cbProvincia
            // 
            this.cbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvincia.FormattingEnabled = true;
            this.cbProvincia.Location = new System.Drawing.Point(255, 20);
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.Size = new System.Drawing.Size(148, 21);
            this.cbProvincia.TabIndex = 1;
            // 
            // cbPais
            // 
            this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(67, 20);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(123, 21);
            this.cbPais.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Barrio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Localidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Provincia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "País";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxEntreCalle2);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.textBoxEntreCalle1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBoxCodigoPostal);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBoxDpto);
            this.groupBox2.Controls.Add(this.textBoxPiso);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBoxNumero);
            this.groupBox2.Controls.Add(this.textBoxCalle);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(41, 387);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 107);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dirección";
            // 
            // textBoxEntreCalle2
            // 
            this.textBoxEntreCalle2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.direccionBindingSource, "CalleEntre2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxEntreCalle2.Location = new System.Drawing.Point(230, 69);
            this.textBoxEntreCalle2.Name = "textBoxEntreCalle2";
            this.textBoxEntreCalle2.Size = new System.Drawing.Size(164, 21);
            this.textBoxEntreCalle2.TabIndex = 6;
            this.textBoxEntreCalle2.TextChanged += new System.EventHandler(this.textBoxEntreCalle2_TextChanged);
            // 
            // direccionBindingSource
            // 
            this.direccionBindingSource.DataSource = typeof(GI.BR.Propiedades.Direccion);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(211, 72);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(13, 13);
            this.label21.TabIndex = 27;
            this.label21.Text = "y";
            // 
            // textBoxEntreCalle1
            // 
            this.textBoxEntreCalle1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.direccionBindingSource, "CalleEntre1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxEntreCalle1.Location = new System.Drawing.Point(67, 69);
            this.textBoxEntreCalle1.Name = "textBoxEntreCalle1";
            this.textBoxEntreCalle1.Size = new System.Drawing.Size(138, 21);
            this.textBoxEntreCalle1.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Entre calle";
            // 
            // textBoxCodigoPostal
            // 
            this.textBoxCodigoPostal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.direccionBindingSource, "CodigoPostal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCodigoPostal.Location = new System.Drawing.Point(245, 41);
            this.textBoxCodigoPostal.Name = "textBoxCodigoPostal";
            this.textBoxCodigoPostal.Size = new System.Drawing.Size(46, 21);
            this.textBoxCodigoPostal.TabIndex = 4;
            this.textBoxCodigoPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(219, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "CP";
            // 
            // textBoxDpto
            // 
            this.textBoxDpto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.direccionBindingSource, "Depto", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxDpto.Location = new System.Drawing.Point(166, 41);
            this.textBoxDpto.Name = "textBoxDpto";
            this.textBoxDpto.Size = new System.Drawing.Size(24, 21);
            this.textBoxDpto.TabIndex = 3;
            this.textBoxDpto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxPiso
            // 
            this.textBoxPiso.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.direccionBindingSource, "Piso", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxPiso.Location = new System.Drawing.Point(67, 41);
            this.textBoxPiso.Name = "textBoxPiso";
            this.textBoxPiso.Size = new System.Drawing.Size(38, 21);
            this.textBoxPiso.TabIndex = 2;
            this.textBoxPiso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(120, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Depto.";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.direccionBindingSource, "Numero", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.textBoxNumero.Location = new System.Drawing.Point(347, 14);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(47, 21);
            this.textBoxNumero.TabIndex = 1;
            this.textBoxNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxCalle
            // 
            this.textBoxCalle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.direccionBindingSource, "Calle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCalle.Location = new System.Drawing.Point(67, 14);
            this.textBoxCalle.Name = "textBoxCalle";
            this.textBoxCalle.Size = new System.Drawing.Size(224, 21);
            this.textBoxCalle.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Piso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(297, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Número";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Calle";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(268, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Valor Real";
            // 
            // cbMonedaReal
            // 
            this.cbMonedaReal.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.valorBindingSource1, "Moneda", true));
            this.cbMonedaReal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.valorBindingSource1, "Moneda", true));
            this.cbMonedaReal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonedaReal.FormattingEnabled = true;
            this.cbMonedaReal.Location = new System.Drawing.Point(396, 100);
            this.cbMonedaReal.Name = "cbMonedaReal";
            this.cbMonedaReal.Size = new System.Drawing.Size(48, 21);
            this.cbMonedaReal.TabIndex = 8;
            // 
            // valorBindingSource1
            // 
            this.valorBindingSource1.DataSource = typeof(GI.BR.Valor);
            // 
            // textBoxVarorMercado
            // 
            this.textBoxVarorMercado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.valorBindingSource1, "Importe", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.textBoxVarorMercado.Location = new System.Drawing.Point(323, 100);
            this.textBoxVarorMercado.Name = "textBoxVarorMercado";
            this.textBoxVarorMercado.Size = new System.Drawing.Size(67, 21);
            this.textBoxVarorMercado.TabIndex = 7;
            this.textBoxVarorMercado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxValorPublicacion
            // 
            this.textBoxValorPublicacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.valorBindingSource, "Importe", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.textBoxValorPublicacion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValorPublicacion.Location = new System.Drawing.Point(120, 98);
            this.textBoxValorPublicacion.Name = "textBoxValorPublicacion";
            this.textBoxValorPublicacion.Size = new System.Drawing.Size(73, 21);
            this.textBoxValorPublicacion.TabIndex = 5;
            this.textBoxValorPublicacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // valorBindingSource
            // 
            this.valorBindingSource.DataSource = typeof(GI.BR.Valor);
            // 
            // cbMonedaPublicacion
            // 
            this.cbMonedaPublicacion.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.valorBindingSource, "Moneda", true));
            this.cbMonedaPublicacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.valorBindingSource, "Moneda", true));
            this.cbMonedaPublicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonedaPublicacion.FormattingEnabled = true;
            this.cbMonedaPublicacion.Location = new System.Drawing.Point(199, 98);
            this.cbMonedaPublicacion.Name = "cbMonedaPublicacion";
            this.cbMonedaPublicacion.Size = new System.Drawing.Size(47, 21);
            this.cbMonedaPublicacion.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(28, 103);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Valor Publicación";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propiedadBindingSource, "Codigo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCodigo.Location = new System.Drawing.Point(120, 71);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.ReadOnly = true;
            this.textBoxCodigo.Size = new System.Drawing.Size(73, 21);
            this.textBoxCodigo.TabIndex = 31;
            this.textBoxCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(340, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Otra Inmobiliaria";
            // 
            // checkBoxEsOtraPropiedad
            // 
            this.checkBoxEsOtraPropiedad.AutoSize = true;
            this.checkBoxEsOtraPropiedad.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.propiedadBindingSource, "EsOtraInmobiliaria", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxEsOtraPropiedad.Location = new System.Drawing.Point(323, 74);
            this.checkBoxEsOtraPropiedad.Name = "checkBoxEsOtraPropiedad";
            this.checkBoxEsOtraPropiedad.Size = new System.Drawing.Size(15, 14);
            this.checkBoxEsOtraPropiedad.TabIndex = 4;
            this.checkBoxEsOtraPropiedad.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(264, 135);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "Ambientes";
            // 
            // cbAmbientes
            // 
            this.cbAmbientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAmbientes.FormattingEnabled = true;
            this.cbAmbientes.Location = new System.Drawing.Point(323, 132);
            this.cbAmbientes.Name = "cbAmbientes";
            this.cbAmbientes.Size = new System.Drawing.Size(121, 21);
            this.cbAmbientes.TabIndex = 9;
            this.cbAmbientes.SelectedIndexChanged += new System.EventHandler(this.cbAmbientes_SelectedIndexChanged);
            // 
            // cbEstadoProp
            // 
            this.cbEstadoProp.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.propiedadBindingSource, "EnumEstado", true));
            this.cbEstadoProp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propiedadBindingSource, "EnumEstado", true));
            this.cbEstadoProp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoProp.FormattingEnabled = true;
            this.cbEstadoProp.Location = new System.Drawing.Point(120, 132);
            this.cbEstadoProp.Name = "cbEstadoProp";
            this.cbEstadoProp.Size = new System.Drawing.Size(127, 21);
            this.cbEstadoProp.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(29, 135);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 13);
            this.label19.TabIndex = 35;
            this.label19.Text = "Estado Propiedad";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.propiedadBindingSource, "Categoria", true));
            this.cbCategoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propiedadBindingSource, "Categoria", true));
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(119, 17);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(106, 21);
            this.cbCategoria.TabIndex = 0;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 47);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(93, 13);
            this.label20.TabIndex = 38;
            this.label20.Text = "Tipo de Propiedad";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvMedidas);
            this.groupBox3.Controls.Add(this.linkLabelEliminarMedida);
            this.groupBox3.Controls.Add(this.linkLabelAgregarMedida);
            this.groupBox3.Location = new System.Drawing.Point(41, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 136);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Medidas";
            // 
            // lvMedidas
            // 
            this.lvMedidas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvMedidas.FullRowSelect = true;
            this.lvMedidas.HideSelection = false;
            this.lvMedidas.Location = new System.Drawing.Point(11, 20);
            this.lvMedidas.MultiSelect = false;
            this.lvMedidas.Name = "lvMedidas";
            this.lvMedidas.Size = new System.Drawing.Size(392, 92);
            this.lvMedidas.TabIndex = 0;
            this.lvMedidas.UseCompatibleStateImageBehavior = false;
            this.lvMedidas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ambiente";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ancho";
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Largo";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tipo de Piso";
            this.columnHeader4.Width = 111;
            // 
            // linkLabelEliminarMedida
            // 
            this.linkLabelEliminarMedida.AutoSize = true;
            this.linkLabelEliminarMedida.Location = new System.Drawing.Point(303, 115);
            this.linkLabelEliminarMedida.Name = "linkLabelEliminarMedida";
            this.linkLabelEliminarMedida.Size = new System.Drawing.Size(80, 13);
            this.linkLabelEliminarMedida.TabIndex = 1;
            this.linkLabelEliminarMedida.TabStop = true;
            this.linkLabelEliminarMedida.Text = "Eliminar Medida";
            this.linkLabelEliminarMedida.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEliminarMedida_LinkClicked);
            // 
            // linkLabelAgregarMedida
            // 
            this.linkLabelAgregarMedida.AutoSize = true;
            this.linkLabelAgregarMedida.Location = new System.Drawing.Point(218, 115);
            this.linkLabelAgregarMedida.Name = "linkLabelAgregarMedida";
            this.linkLabelAgregarMedida.Size = new System.Drawing.Size(83, 13);
            this.linkLabelAgregarMedida.TabIndex = 1;
            this.linkLabelAgregarMedida.TabStop = true;
            this.linkLabelAgregarMedida.Text = "Agregar Medida";
            this.linkLabelAgregarMedida.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAgregarMedida_LinkClicked);
            // 
            // LinkPropietario
            // 
            this.LinkPropietario.AutoSize = true;
            this.LinkPropietario.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.propiedadBindingSource, "Propietario", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LinkPropietario.Location = new System.Drawing.Point(320, 47);
            this.LinkPropietario.Name = "LinkPropietario";
            this.LinkPropietario.Size = new System.Drawing.Size(127, 13);
            this.LinkPropietario.TabIndex = 3;
            this.LinkPropietario.TabStop = true;
            this.LinkPropietario.Text = "Seleccione un propietario";
            this.LinkPropietario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkPropietario_LinkClicked);
            // 
            // TabPropiedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LinkPropietario);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cbAmbientes);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbEstadoProp);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.checkBoxEsOtraPropiedad);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.textBoxValorPublicacion);
            this.Controls.Add(this.cbMonedaPublicacion);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxVarorMercado);
            this.Controls.Add(this.cbMonedaReal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cbTipoPropiedad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TabPropiedad";
            this.Size = new System.Drawing.Size(494, 544);
            ((System.ComponentModel.ISupportInitialize)(this.propiedadBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.direccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private GI.Framework.ComboBox cbTipoPropiedad;
        private GI.Framework.ComboBox cbEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private GI.Framework.ComboBox cbBarrio;
        private GI.Framework.ComboBox cbLocalidad;
        private GI.Framework.ComboBox cbProvincia;
        private GI.Framework.ComboBox cbPais;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCodigoPostal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxDpto;
        private System.Windows.Forms.TextBox textBoxPiso;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBoxCalle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private GI.Framework.ComboBox cbMonedaReal;
        private System.Windows.Forms.TextBox textBoxVarorMercado;
        private System.Windows.Forms.TextBox textBoxValorPublicacion;
        private GI.Framework.ComboBox cbMonedaPublicacion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox checkBoxEsOtraPropiedad;
        private System.Windows.Forms.Label label18;
        private GI.Framework.ComboBox cbAmbientes;
        private GI.Framework.ComboBox cbEstadoProp;
        private System.Windows.Forms.Label label19;
        private GI.Framework.ComboBox cbCategoria;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lvMedidas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.LinkLabel linkLabelEliminarMedida;
        private System.Windows.Forms.LinkLabel linkLabelAgregarMedida;
        private System.Windows.Forms.LinkLabel LinkPropietario;
        private System.Windows.Forms.TextBox textBoxEntreCalle2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxEntreCalle1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.BindingSource propiedadBindingSource;
        private System.Windows.Forms.BindingSource valorBindingSource;
        private System.Windows.Forms.BindingSource direccionBindingSource;
        private System.Windows.Forms.BindingSource valorBindingSource1;
    }
}
