namespace GI.UI.Propiedades
{
    partial class TabDetalles
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMetrosCubiertos = new System.Windows.Forms.TextBox();
            this.medidaPropiedadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxMetrosSemicubiertos = new System.Windows.Forms.TextBox();
            this.textBoxMestrosLibros = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFrente = new System.Windows.Forms.TextBox();
            this.medidasTerrenoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxFondo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxTerreno = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxdormitorios = new System.Windows.Forms.TextBox();
            this.propiedadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxbanios = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox1Plantas = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxCocheras = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxOrientacion = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cbDisposicion = new GI.Framework.ComboBox();
            this.chAptoProfesional = new System.Windows.Forms.CheckBox();
            this.textBoxCantidadPisos = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBoxDepertamanetosPorPiso = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBoxAscensores = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBoxAscensoresServicio = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.cbTipoZona = new GI.Framework.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBoxFOT = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textBoxFOS = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBoxZonificacion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxMetrosConstruibles = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.medidaPropiedadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidasTerrenoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propiedadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metros cubiertos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Metros semicubiertos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Metros libre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxMetrosCubiertos
            // 
            this.textBoxMetrosCubiertos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medidaPropiedadBindingSource, "MetrosCubiertos", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N1"));
            this.textBoxMetrosCubiertos.Location = new System.Drawing.Point(132, 38);
            this.textBoxMetrosCubiertos.Name = "textBoxMetrosCubiertos";
            this.textBoxMetrosCubiertos.Size = new System.Drawing.Size(58, 21);
            this.textBoxMetrosCubiertos.TabIndex = 9;
            this.textBoxMetrosCubiertos.Text = "0";
            this.textBoxMetrosCubiertos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxMetrosCubiertos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // medidaPropiedadBindingSource
            // 
            this.medidaPropiedadBindingSource.DataSource = typeof(GI.BR.Propiedades.MedidaPropiedad);
            // 
            // textBoxMetrosSemicubiertos
            // 
            this.textBoxMetrosSemicubiertos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medidaPropiedadBindingSource, "MetrosSemicubiertos", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N1"));
            this.textBoxMetrosSemicubiertos.Location = new System.Drawing.Point(353, 38);
            this.textBoxMetrosSemicubiertos.Name = "textBoxMetrosSemicubiertos";
            this.textBoxMetrosSemicubiertos.Size = new System.Drawing.Size(58, 21);
            this.textBoxMetrosSemicubiertos.TabIndex = 10;
            this.textBoxMetrosSemicubiertos.Text = "0";
            this.textBoxMetrosSemicubiertos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxMetrosSemicubiertos.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxMestrosLibros
            // 
            this.textBoxMestrosLibros.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medidaPropiedadBindingSource, "MetrosLibres", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N1"));
            this.textBoxMestrosLibros.Location = new System.Drawing.Point(132, 64);
            this.textBoxMestrosLibros.Name = "textBoxMestrosLibros";
            this.textBoxMestrosLibros.Size = new System.Drawing.Size(58, 21);
            this.textBoxMestrosLibros.TabIndex = 11;
            this.textBoxMestrosLibros.Text = "0";
            this.textBoxMestrosLibros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxMestrosLibros.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Frente";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxFrente
            // 
            this.textBoxFrente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medidasTerrenoBindingSource, "Frente", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N1"));
            this.textBoxFrente.Location = new System.Drawing.Point(132, 131);
            this.textBoxFrente.Name = "textBoxFrente";
            this.textBoxFrente.Size = new System.Drawing.Size(58, 21);
            this.textBoxFrente.TabIndex = 29;
            this.textBoxFrente.Text = "0";
            this.textBoxFrente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // medidasTerrenoBindingSource
            // 
            this.medidasTerrenoBindingSource.DataSource = typeof(GI.BR.Propiedades.MedidasTerreno);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "m";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "m2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "m2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "m2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Medidas del Lote";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(196, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "m";
            // 
            // textBoxFondo
            // 
            this.textBoxFondo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medidasTerrenoBindingSource, "Fondo", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N1"));
            this.textBoxFondo.Location = new System.Drawing.Point(132, 158);
            this.textBoxFondo.Name = "textBoxFondo";
            this.textBoxFondo.Size = new System.Drawing.Size(58, 21);
            this.textBoxFondo.TabIndex = 36;
            this.textBoxFondo.Text = "0";
            this.textBoxFondo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(89, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Fondo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(417, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "m2";
            // 
            // textBoxTerreno
            // 
            this.textBoxTerreno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medidasTerrenoBindingSource, "Metros", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N1"));
            this.textBoxTerreno.Location = new System.Drawing.Point(353, 131);
            this.textBoxTerreno.Name = "textBoxTerreno";
            this.textBoxTerreno.Size = new System.Drawing.Size(58, 21);
            this.textBoxTerreno.TabIndex = 39;
            this.textBoxTerreno.Text = "0";
            this.textBoxTerreno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(302, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Terreno";
            // 
            // textBoxdormitorios
            // 
            this.textBoxdormitorios.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propiedadBindingSource, "CantidadDormitorios", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.textBoxdormitorios.Location = new System.Drawing.Point(353, 212);
            this.textBoxdormitorios.Name = "textBoxdormitorios";
            this.textBoxdormitorios.Size = new System.Drawing.Size(58, 21);
            this.textBoxdormitorios.TabIndex = 45;
            this.textBoxdormitorios.Text = "0";
            this.textBoxdormitorios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // propiedadBindingSource
            // 
            this.propiedadBindingSource.DataSource = typeof(GI.BR.Propiedades.Propiedad);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(286, 215);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 44;
            this.label17.Text = "Dormitorios";
            // 
            // textBoxbanios
            // 
            this.textBoxbanios.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propiedadBindingSource, "CantidadBaños", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.textBoxbanios.Location = new System.Drawing.Point(132, 239);
            this.textBoxbanios.Name = "textBoxbanios";
            this.textBoxbanios.Size = new System.Drawing.Size(58, 21);
            this.textBoxbanios.TabIndex = 47;
            this.textBoxbanios.Text = "0";
            this.textBoxbanios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(87, 242);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 13);
            this.label18.TabIndex = 46;
            this.label18.Text = "Baños";
            // 
            // textBox1Plantas
            // 
            this.textBox1Plantas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propiedadBindingSource, "CantidadPlantas", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.textBox1Plantas.Location = new System.Drawing.Point(353, 239);
            this.textBox1Plantas.Name = "textBox1Plantas";
            this.textBox1Plantas.Size = new System.Drawing.Size(58, 21);
            this.textBox1Plantas.TabIndex = 49;
            this.textBox1Plantas.Text = "0";
            this.textBox1Plantas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(305, 242);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 13);
            this.label19.TabIndex = 48;
            this.label19.Text = "Plantas";
            // 
            // textBoxCocheras
            // 
            this.textBoxCocheras.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propiedadBindingSource, "CantidadCocheras", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.textBoxCocheras.Location = new System.Drawing.Point(132, 266);
            this.textBoxCocheras.Name = "textBoxCocheras";
            this.textBoxCocheras.Size = new System.Drawing.Size(58, 21);
            this.textBoxCocheras.TabIndex = 51;
            this.textBoxCocheras.Text = "0";
            this.textBoxCocheras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(71, 269);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 13);
            this.label20.TabIndex = 50;
            this.label20.Text = "Cocheras";
            // 
            // textBoxOrientacion
            // 
            this.textBoxOrientacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propiedadBindingSource, "Orientacion", true));
            this.textBoxOrientacion.Location = new System.Drawing.Point(132, 212);
            this.textBoxOrientacion.Name = "textBoxOrientacion";
            this.textBoxOrientacion.Size = new System.Drawing.Size(118, 21);
            this.textBoxOrientacion.TabIndex = 53;
            this.textBoxOrientacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(64, 215);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 13);
            this.label21.TabIndex = 52;
            this.label21.Text = "Orientación";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(36, 303);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 13);
            this.label15.TabIndex = 54;
            this.label15.Text = "Departamento";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(11, 416);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(115, 13);
            this.label22.TabIndex = 55;
            this.label22.Text = "Terrenos / Campos";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(64, 327);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 13);
            this.label23.TabIndex = 56;
            this.label23.Text = "Disposición";
            // 
            // cbDisposicion
            // 
            this.cbDisposicion.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.propiedadBindingSource, "Disposicion", true));
            this.cbDisposicion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propiedadBindingSource, "Disposicion", true));
            this.cbDisposicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisposicion.FormattingEnabled = true;
            this.cbDisposicion.Location = new System.Drawing.Point(127, 324);
            this.cbDisposicion.Name = "cbDisposicion";
            this.cbDisposicion.Size = new System.Drawing.Size(103, 21);
            this.cbDisposicion.TabIndex = 57;
            // 
            // chAptoProfesional
            // 
            this.chAptoProfesional.AutoSize = true;
            this.chAptoProfesional.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chAptoProfesional.Location = new System.Drawing.Point(260, 326);
            this.chAptoProfesional.Name = "chAptoProfesional";
            this.chAptoProfesional.Size = new System.Drawing.Size(105, 17);
            this.chAptoProfesional.TabIndex = 58;
            this.chAptoProfesional.Text = "Apto Profesional";
            this.chAptoProfesional.UseVisualStyleBackColor = true;
            // 
            // textBoxCantidadPisos
            // 
            this.textBoxCantidadPisos.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.propiedadBindingSource, "CantidadPisos", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.textBoxCantidadPisos.Location = new System.Drawing.Point(127, 351);
            this.textBoxCantidadPisos.Name = "textBoxCantidadPisos";
            this.textBoxCantidadPisos.Size = new System.Drawing.Size(58, 21);
            this.textBoxCantidadPisos.TabIndex = 60;
            this.textBoxCantidadPisos.Text = "0";
            this.textBoxCantidadPisos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(31, 354);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(92, 13);
            this.label24.TabIndex = 59;
            this.label24.Text = "Cantidad de Pisos";
            // 
            // textBoxDepertamanetosPorPiso
            // 
            this.textBoxDepertamanetosPorPiso.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propiedadBindingSource, "DepartamentosPorPiso", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.textBoxDepertamanetosPorPiso.Location = new System.Drawing.Point(350, 351);
            this.textBoxDepertamanetosPorPiso.Name = "textBoxDepertamanetosPorPiso";
            this.textBoxDepertamanetosPorPiso.Size = new System.Drawing.Size(58, 21);
            this.textBoxDepertamanetosPorPiso.TabIndex = 62;
            this.textBoxDepertamanetosPorPiso.Text = "0";
            this.textBoxDepertamanetosPorPiso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDepertamanetosPorPiso.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(222, 354);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(122, 13);
            this.label25.TabIndex = 61;
            this.label25.Text = "Departamentos por piso";
            // 
            // textBoxAscensores
            // 
            this.textBoxAscensores.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propiedadBindingSource, "CantidadAscensores", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.textBoxAscensores.Location = new System.Drawing.Point(127, 378);
            this.textBoxAscensores.Name = "textBoxAscensores";
            this.textBoxAscensores.Size = new System.Drawing.Size(58, 21);
            this.textBoxAscensores.TabIndex = 64;
            this.textBoxAscensores.Text = "0";
            this.textBoxAscensores.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(58, 381);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(62, 13);
            this.label26.TabIndex = 63;
            this.label26.Text = "Ascensores";
            // 
            // textBoxAscensoresServicio
            // 
            this.textBoxAscensoresServicio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propiedadBindingSource, "CantidadAscensoresServicio", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.textBoxAscensoresServicio.Location = new System.Drawing.Point(350, 378);
            this.textBoxAscensoresServicio.Name = "textBoxAscensoresServicio";
            this.textBoxAscensoresServicio.Size = new System.Drawing.Size(58, 21);
            this.textBoxAscensoresServicio.TabIndex = 66;
            this.textBoxAscensoresServicio.Text = "0";
            this.textBoxAscensoresServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(243, 381);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(101, 13);
            this.label27.TabIndex = 65;
            this.label27.Text = "Ascensores servicio";
            // 
            // cbTipoZona
            // 
            this.cbTipoZona.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.propiedadBindingSource, "TipoZona", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbTipoZona.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propiedadBindingSource, "TipoZona", true));
            this.cbTipoZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoZona.FormattingEnabled = true;
            this.cbTipoZona.Location = new System.Drawing.Point(126, 436);
            this.cbTipoZona.Name = "cbTipoZona";
            this.cbTipoZona.Size = new System.Drawing.Size(104, 21);
            this.cbTipoZona.TabIndex = 68;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(50, 439);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(69, 13);
            this.label28.TabIndex = 67;
            this.label28.Text = "Tipo de Zona";
            // 
            // textBoxFOT
            // 
            this.textBoxFOT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propiedadBindingSource, "Fot", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxFOT.Location = new System.Drawing.Point(349, 436);
            this.textBoxFOT.Name = "textBoxFOT";
            this.textBoxFOT.Size = new System.Drawing.Size(107, 21);
            this.textBoxFOT.TabIndex = 71;
            this.textBoxFOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(320, 439);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(27, 13);
            this.label30.TabIndex = 70;
            this.label30.Text = "FOT";
            // 
            // textBoxFOS
            // 
            this.textBoxFOS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propiedadBindingSource, "Fos", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxFOS.Location = new System.Drawing.Point(126, 466);
            this.textBoxFOS.Name = "textBoxFOS";
            this.textBoxFOS.Size = new System.Drawing.Size(104, 21);
            this.textBoxFOS.TabIndex = 73;
            this.textBoxFOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(93, 469);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(27, 13);
            this.label31.TabIndex = 72;
            this.label31.Text = "FOS";
            // 
            // textBoxZonificacion
            // 
            this.textBoxZonificacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propiedadBindingSource, "Zonificacion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxZonificacion.Location = new System.Drawing.Point(349, 466);
            this.textBoxZonificacion.Name = "textBoxZonificacion";
            this.textBoxZonificacion.Size = new System.Drawing.Size(107, 21);
            this.textBoxZonificacion.TabIndex = 75;
            this.textBoxZonificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(284, 469);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 74;
            this.label14.Text = "Zonificación";
            // 
            // textBoxMetrosConstruibles
            // 
            this.textBoxMetrosConstruibles.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propiedadBindingSource, "MetrosConstruibles", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N1"));
            this.textBoxMetrosConstruibles.Location = new System.Drawing.Point(126, 493);
            this.textBoxMetrosConstruibles.Name = "textBoxMetrosConstruibles";
            this.textBoxMetrosConstruibles.Size = new System.Drawing.Size(58, 21);
            this.textBoxMetrosConstruibles.TabIndex = 77;
            this.textBoxMetrosConstruibles.Text = "0";
            this.textBoxMetrosConstruibles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(28, 496);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(95, 13);
            this.label32.TabIndex = 76;
            this.label32.Text = "Metros contruibles";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(36, 14);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(144, 13);
            this.label29.TabIndex = 78;
            this.label29.Text = "Medidas de la Propiedad";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(84, 188);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(53, 13);
            this.label33.TabIndex = 79;
            this.label33.Text = "Detalles";
            // 
            // TabDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.textBoxMetrosConstruibles);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.textBoxZonificacion);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxFOS);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.textBoxFOT);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.cbTipoZona);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.textBoxAscensoresServicio);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.textBoxAscensores);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.textBoxDepertamanetosPorPiso);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.textBoxCantidadPisos);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.chAptoProfesional);
            this.Controls.Add(this.cbDisposicion);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxOrientacion);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.textBoxCocheras);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textBox1Plantas);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBoxbanios);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBoxdormitorios);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxTerreno);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxFondo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFrente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMestrosLibros);
            this.Controls.Add(this.textBoxMetrosSemicubiertos);
            this.Controls.Add(this.textBoxMetrosCubiertos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TabDetalles";
            this.Size = new System.Drawing.Size(494, 544);
            this.Load += new System.EventHandler(this.TabDetalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medidaPropiedadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidasTerrenoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propiedadBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMetrosCubiertos;
        private System.Windows.Forms.TextBox textBoxMetrosSemicubiertos;
        private System.Windows.Forms.TextBox textBoxMestrosLibros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFrente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxFondo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxTerreno;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxdormitorios;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxbanios;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox1Plantas;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxCocheras;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxOrientacion;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private GI.Framework.ComboBox cbDisposicion;
        private System.Windows.Forms.CheckBox chAptoProfesional;
        private System.Windows.Forms.TextBox textBoxCantidadPisos;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBoxDepertamanetosPorPiso;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBoxAscensores;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBoxAscensoresServicio;
        private System.Windows.Forms.Label label27;
        private GI.Framework.ComboBox cbTipoZona;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBoxFOT;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBoxFOS;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBoxZonificacion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxMetrosConstruibles;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.BindingSource medidaPropiedadBindingSource;
        private System.Windows.Forms.BindingSource medidasTerrenoBindingSource;
        private System.Windows.Forms.BindingSource propiedadBindingSource;
    }
}
