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
            GI.BR.Propiedades.Ubicacion ubicacion2 = new GI.BR.Propiedades.Ubicacion();
            this.propiedadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.direccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.valorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LinkPropietario = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvMedidas = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.linkLabelEliminarMedida = new System.Windows.Forms.LinkLabel();
            this.linkLabelAgregarMedida = new System.Windows.Forms.LinkLabel();
            this.label20 = new System.Windows.Forms.Label();
            this.cbAmbientes = new GI.Framework.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbCategoria = new GI.Framework.ComboBox();
            this.cbEstadoProp = new GI.Framework.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.checkBoxEsOtraPropiedad = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxValorPublicacion = new System.Windows.Forms.TextBox();
            this.cbMonedaPublicacion = new GI.Framework.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxVarorMercado = new System.Windows.Forms.TextBox();
            this.cbMonedaReal = new GI.Framework.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEstado = new GI.Framework.ComboBox();
            this.cbTipoPropiedad = new GI.Framework.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlUbicacion1 = new GI.UI.Generales.CtrlUbicacion();
            this.ctrlDireccion1 = new GI.UI.Generales.CtrlDireccion();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDetalles = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.propiedadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.direccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // propiedadBindingSource
            // 
            this.propiedadBindingSource.DataSource = typeof(GI.BR.Propiedades.Propiedad);
            // 
            // direccionBindingSource
            // 
            this.direccionBindingSource.DataSource = typeof(GI.BR.Propiedades.Direccion);
            // 
            // valorBindingSource1
            // 
            this.valorBindingSource1.DataSource = typeof(GI.BR.Valor);
            // 
            // valorBindingSource
            // 
            this.valorBindingSource.DataSource = typeof(GI.BR.Valor);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvMedidas);
            this.groupBox3.Controls.Add(this.linkLabelEliminarMedida);
            this.groupBox3.Controls.Add(this.linkLabelAgregarMedida);
            this.groupBox3.Location = new System.Drawing.Point(41, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 119);
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
            this.lvMedidas.Size = new System.Drawing.Size(392, 80);
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
            this.linkLabelEliminarMedida.Location = new System.Drawing.Point(303, 100);
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
            this.linkLabelAgregarMedida.Location = new System.Drawing.Point(218, 100);
            this.linkLabelAgregarMedida.Name = "linkLabelAgregarMedida";
            this.linkLabelAgregarMedida.Size = new System.Drawing.Size(83, 13);
            this.linkLabelAgregarMedida.TabIndex = 1;
            this.linkLabelAgregarMedida.TabStop = true;
            this.linkLabelAgregarMedida.Text = "Agregar Medida";
            this.linkLabelAgregarMedida.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAgregarMedida_LinkClicked);
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
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(264, 135);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "Ambientes";
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
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(340, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Otra Inmobiliaria";
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
            // textBoxVarorMercado
            // 
            this.textBoxVarorMercado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.valorBindingSource1, "Importe", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.textBoxVarorMercado.Location = new System.Drawing.Point(323, 100);
            this.textBoxVarorMercado.Name = "textBoxVarorMercado";
            this.textBoxVarorMercado.Size = new System.Drawing.Size(67, 21);
            this.textBoxVarorMercado.TabIndex = 7;
            this.textBoxVarorMercado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(268, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Valor Real";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Propietario";
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
            this.cbTipoPropiedad.SelectedIndexChanged += new System.EventHandler(this.cbTipoPropiedad_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoria";
            // 
            // ctrlUbicacion1
            // 
            this.ctrlUbicacion1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlUbicacion1.Location = new System.Drawing.Point(41, 278);
            this.ctrlUbicacion1.Name = "ctrlUbicacion1";
            this.ctrlUbicacion1.Size = new System.Drawing.Size(415, 89);
            this.ctrlUbicacion1.SoloLectura = false;
            this.ctrlUbicacion1.TabIndex = 40;
            ubicacion2.Barrio = null;
            ubicacion2.Localidad = null;
            ubicacion2.Pais = null;
            ubicacion2.Provincia = null;
            this.ctrlUbicacion1.Ubicacion = ubicacion2;
            // 
            // ctrlDireccion1
            // 
            this.ctrlDireccion1.Direccion = null;
            this.ctrlDireccion1.Location = new System.Drawing.Point(41, 366);
            this.ctrlDireccion1.Name = "ctrlDireccion1";
            this.ctrlDireccion1.Size = new System.Drawing.Size(417, 113);
            this.ctrlDireccion1.SoloLectura = false;
            this.ctrlDireccion1.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Detalles";
            // 
            // textBoxDetalles
            // 
            this.textBoxDetalles.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propiedadBindingSource, "Observaciones", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.textBoxDetalles.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDetalles.Location = new System.Drawing.Point(41, 492);
            this.textBoxDetalles.Multiline = true;
            this.textBoxDetalles.Name = "textBoxDetalles";
            this.textBoxDetalles.Size = new System.Drawing.Size(415, 43);
            this.textBoxDetalles.TabIndex = 43;
            this.textBoxDetalles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TabPropiedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxDetalles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ctrlDireccion1);
            this.Controls.Add(this.ctrlUbicacion1);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cbTipoPropiedad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TabPropiedad";
            this.Size = new System.Drawing.Size(494, 544);
            ((System.ComponentModel.ISupportInitialize)(this.propiedadBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource propiedadBindingSource;
        private System.Windows.Forms.BindingSource valorBindingSource;
        private System.Windows.Forms.BindingSource direccionBindingSource;
        private System.Windows.Forms.BindingSource valorBindingSource1;
        private GI.UI.Generales.CtrlUbicacion ctrlUbicacion1;
        private GI.UI.Generales.CtrlDireccion ctrlDireccion1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDetalles;
    }
}
