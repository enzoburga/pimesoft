namespace GI.UI.Propiedades.Formularios
{
    partial class FrmFoto
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBoxUrlFoto = new System.Windows.Forms.TextBox();
            this.bExaminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxEsFechada = new System.Windows.Forms.CheckBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTipoAmbiente = new GI.Framework.ComboBox();
            this.textBoxAlto = new System.Windows.Forms.TextBox();
            this.textBoxAncho = new System.Windows.Forms.TextBox();
            this.cbTipoPiso = new GI.Framework.ComboBox();
            this.textBoxAmbiente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxCargarambiente = new System.Windows.Forms.CheckBox();
            this.medidaAmbienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medidaAmbienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Imagenes JPG|*.jpg";
            // 
            // textBoxUrlFoto
            // 
            this.textBoxUrlFoto.Location = new System.Drawing.Point(25, 14);
            this.textBoxUrlFoto.Name = "textBoxUrlFoto";
            this.textBoxUrlFoto.ReadOnly = true;
            this.textBoxUrlFoto.Size = new System.Drawing.Size(341, 21);
            this.textBoxUrlFoto.TabIndex = 0;
            // 
            // bExaminar
            // 
            this.bExaminar.Location = new System.Drawing.Point(372, 12);
            this.bExaminar.Name = "bExaminar";
            this.bExaminar.Size = new System.Drawing.Size(75, 23);
            this.bExaminar.TabIndex = 1;
            this.bExaminar.Text = "Examinar";
            this.bExaminar.UseVisualStyleBackColor = true;
            this.bExaminar.Click += new System.EventHandler(this.bExaminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // checkBoxEsFechada
            // 
            this.checkBoxEsFechada.AutoSize = true;
            this.checkBoxEsFechada.Location = new System.Drawing.Point(76, 72);
            this.checkBoxEsFechada.Name = "checkBoxEsFechada";
            this.checkBoxEsFechada.Size = new System.Drawing.Size(142, 17);
            this.checkBoxEsFechada.TabIndex = 3;
            this.checkBoxEsFechada.Text = "Foto Principal (Fachada)";
            this.checkBoxEsFechada.UseVisualStyleBackColor = true;
            this.checkBoxEsFechada.CheckedChanged += new System.EventHandler(this.checkBoxEsFechada_CheckedChanged);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(76, 45);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(184, 21);
            this.textBoxNombre.TabIndex = 4;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(372, 279);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 5;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(291, 279);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 6;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxCargarambiente);
            this.groupBox1.Controls.Add(this.cbTipoAmbiente);
            this.groupBox1.Controls.Add(this.textBoxAlto);
            this.groupBox1.Controls.Add(this.textBoxAncho);
            this.groupBox1.Controls.Add(this.cbTipoPiso);
            this.groupBox1.Controls.Add(this.textBoxAmbiente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(25, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 148);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ambiente";
            // 
            // cbTipoAmbiente
            // 
            this.cbTipoAmbiente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.medidaAmbienteBindingSource, "TipoAmbiente", true));
            this.cbTipoAmbiente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medidaAmbienteBindingSource, "TipoAmbiente", true));
            this.cbTipoAmbiente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoAmbiente.FormattingEnabled = true;
            this.cbTipoAmbiente.Location = new System.Drawing.Point(64, 48);
            this.cbTipoAmbiente.Name = "cbTipoAmbiente";
            this.cbTipoAmbiente.Size = new System.Drawing.Size(121, 21);
            this.cbTipoAmbiente.TabIndex = 19;
            this.cbTipoAmbiente.SelectedIndexChanged += new System.EventHandler(this.cbTipoAmbiente_SelectedIndexChanged);
            // 
            // textBoxAlto
            // 
            this.textBoxAlto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medidaAmbienteBindingSource, "Largo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.textBoxAlto.Location = new System.Drawing.Point(277, 107);
            this.textBoxAlto.Name = "textBoxAlto";
            this.textBoxAlto.Size = new System.Drawing.Size(52, 21);
            this.textBoxAlto.TabIndex = 18;
            // 
            // textBoxAncho
            // 
            this.textBoxAncho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medidaAmbienteBindingSource, "Ancho", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.textBoxAncho.Location = new System.Drawing.Point(64, 107);
            this.textBoxAncho.Name = "textBoxAncho";
            this.textBoxAncho.Size = new System.Drawing.Size(52, 21);
            this.textBoxAncho.TabIndex = 17;
            // 
            // cbTipoPiso
            // 
            this.cbTipoPiso.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.medidaAmbienteBindingSource, "TipoDePiso", true));
            this.cbTipoPiso.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medidaAmbienteBindingSource, "TipoDePiso", true));
            this.cbTipoPiso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPiso.FormattingEnabled = true;
            this.cbTipoPiso.Location = new System.Drawing.Point(277, 48);
            this.cbTipoPiso.Name = "cbTipoPiso";
            this.cbTipoPiso.Size = new System.Drawing.Size(121, 21);
            this.cbTipoPiso.TabIndex = 16;
            // 
            // textBoxAmbiente
            // 
            this.textBoxAmbiente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medidaAmbienteBindingSource, "NombreAmbiente", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxAmbiente.Location = new System.Drawing.Point(64, 75);
            this.textBoxAmbiente.Name = "textBoxAmbiente";
            this.textBoxAmbiente.Size = new System.Drawing.Size(121, 21);
            this.textBoxAmbiente.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tipo de Piso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Largo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ancho";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ambiente";
            // 
            // checkBoxCargarambiente
            // 
            this.checkBoxCargarambiente.AutoSize = true;
            this.checkBoxCargarambiente.Checked = true;
            this.checkBoxCargarambiente.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCargarambiente.Location = new System.Drawing.Point(64, 20);
            this.checkBoxCargarambiente.Name = "checkBoxCargarambiente";
            this.checkBoxCargarambiente.Size = new System.Drawing.Size(107, 17);
            this.checkBoxCargarambiente.TabIndex = 20;
            this.checkBoxCargarambiente.Text = "Cargar Ambiente";
            this.checkBoxCargarambiente.UseVisualStyleBackColor = true;
            this.checkBoxCargarambiente.CheckedChanged += new System.EventHandler(this.checkBoxCargarambiente_CheckedChanged);
            // 
            // medidaAmbienteBindingSource
            // 
            this.medidaAmbienteBindingSource.DataSource = typeof(GI.BR.Propiedades.MedidaAmbiente);
            // 
            // FrmFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 314);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.checkBoxEsFechada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bExaminar);
            this.Controls.Add(this.textBoxUrlFoto);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFoto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Foto de Propiedad";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medidaAmbienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox textBoxUrlFoto;
        private System.Windows.Forms.Button bExaminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxEsFechada;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxCargarambiente;
        private GI.Framework.ComboBox cbTipoAmbiente;
        private System.Windows.Forms.TextBox textBoxAlto;
        private System.Windows.Forms.TextBox textBoxAncho;
        private GI.Framework.ComboBox cbTipoPiso;
        private System.Windows.Forms.TextBox textBoxAmbiente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource medidaAmbienteBindingSource;
    }
}