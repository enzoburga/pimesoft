namespace GI.UI.Propiedades.Formularios
{
    partial class FrmMedida
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAmbiente = new System.Windows.Forms.TextBox();
            this.medidaAmbienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbTipoPiso = new GI.Framework.ComboBox();
            this.textBoxAncho = new System.Windows.Forms.TextBox();
            this.textBoxAlto = new System.Windows.Forms.TextBox();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.cbTipoAmbiente = new GI.Framework.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.medidaAmbienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ambiente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ancho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Largo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de Piso";
            // 
            // textBoxAmbiente
            // 
            this.textBoxAmbiente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medidaAmbienteBindingSource, "NombreAmbiente", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxAmbiente.Location = new System.Drawing.Point(88, 44);
            this.textBoxAmbiente.Name = "textBoxAmbiente";
            this.textBoxAmbiente.Size = new System.Drawing.Size(121, 21);
            this.textBoxAmbiente.TabIndex = 4;
            // 
            // medidaAmbienteBindingSource
            // 
            this.medidaAmbienteBindingSource.DataSource = typeof(GI.BR.Propiedades.MedidaAmbiente);
            // 
            // cbTipoPiso
            // 
            this.cbTipoPiso.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.medidaAmbienteBindingSource, "TipoDePiso", true));
            this.cbTipoPiso.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medidaAmbienteBindingSource, "TipoDePiso", true));
            this.cbTipoPiso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPiso.FormattingEnabled = true;
            this.cbTipoPiso.Location = new System.Drawing.Point(301, 17);
            this.cbTipoPiso.Name = "cbTipoPiso";
            this.cbTipoPiso.Size = new System.Drawing.Size(121, 21);
            this.cbTipoPiso.TabIndex = 5;
            // 
            // textBoxAncho
            // 
            this.textBoxAncho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medidaAmbienteBindingSource, "Ancho", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.textBoxAncho.Location = new System.Drawing.Point(88, 89);
            this.textBoxAncho.Name = "textBoxAncho";
            this.textBoxAncho.Size = new System.Drawing.Size(52, 21);
            this.textBoxAncho.TabIndex = 6;
            // 
            // textBoxAlto
            // 
            this.textBoxAlto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medidaAmbienteBindingSource, "Largo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.textBoxAlto.Location = new System.Drawing.Point(301, 89);
            this.textBoxAlto.Name = "textBoxAlto";
            this.textBoxAlto.Size = new System.Drawing.Size(52, 21);
            this.textBoxAlto.TabIndex = 7;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(359, 140);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 8;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(278, 140);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 9;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // cbTipoAmbiente
            // 
            this.cbTipoAmbiente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.medidaAmbienteBindingSource, "TipoAmbiente", true));
            this.cbTipoAmbiente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medidaAmbienteBindingSource, "TipoAmbiente", true));
            this.cbTipoAmbiente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoAmbiente.FormattingEnabled = true;
            this.cbTipoAmbiente.Location = new System.Drawing.Point(88, 17);
            this.cbTipoAmbiente.Name = "cbTipoAmbiente";
            this.cbTipoAmbiente.Size = new System.Drawing.Size(121, 21);
            this.cbTipoAmbiente.TabIndex = 10;
            this.cbTipoAmbiente.SelectedIndexChanged += new System.EventHandler(this.cbTipoAmbiente_SelectedIndexChanged);
            // 
            // FrmMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 175);
            this.Controls.Add(this.cbTipoAmbiente);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.textBoxAlto);
            this.Controls.Add(this.textBoxAncho);
            this.Controls.Add(this.cbTipoPiso);
            this.Controls.Add(this.textBoxAmbiente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMedida";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Medida";
            ((System.ComponentModel.ISupportInitialize)(this.medidaAmbienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAmbiente;
        private GI.Framework.ComboBox cbTipoPiso;
        private System.Windows.Forms.TextBox textBoxAncho;
        private System.Windows.Forms.TextBox textBoxAlto;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.BindingSource medidaAmbienteBindingSource;
        private GI.Framework.ComboBox cbTipoAmbiente;
    }
}