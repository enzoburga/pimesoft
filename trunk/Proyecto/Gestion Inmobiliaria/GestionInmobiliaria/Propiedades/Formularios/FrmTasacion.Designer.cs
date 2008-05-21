namespace GI.UI.Propiedades.Formularios
{
    partial class FrmTasacion
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
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.textBoxValorReal = new System.Windows.Forms.TextBox();
            this.valorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxValorPublicacion = new System.Windows.Forms.TextBox();
            this.valorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxComentarios = new System.Windows.Forms.TextBox();
            this.tasacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbMonedaValorReal = new GI.Framework.ComboBox();
            this.cbMonedaValorPublicacion = new GI.Framework.ComboBox();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.valorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Real";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor Publicación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Comentarios";
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(115, 20);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(96, 21);
            this.dateTimePickerFecha.TabIndex = 4;
            // 
            // textBoxValorReal
            // 
            this.textBoxValorReal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.valorBindingSource, "Importe", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.textBoxValorReal.Location = new System.Drawing.Point(115, 53);
            this.textBoxValorReal.Name = "textBoxValorReal";
            this.textBoxValorReal.Size = new System.Drawing.Size(76, 21);
            this.textBoxValorReal.TabIndex = 5;
            // 
            // valorBindingSource
            // 
            this.valorBindingSource.DataSource = typeof(GI.BR.Valor);
            // 
            // textBoxValorPublicacion
            // 
            this.textBoxValorPublicacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.valorBindingSource1, "Importe", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.textBoxValorPublicacion.Location = new System.Drawing.Point(115, 80);
            this.textBoxValorPublicacion.Name = "textBoxValorPublicacion";
            this.textBoxValorPublicacion.Size = new System.Drawing.Size(76, 21);
            this.textBoxValorPublicacion.TabIndex = 6;
            // 
            // valorBindingSource1
            // 
            this.valorBindingSource1.DataSource = typeof(GI.BR.Valor);
            // 
            // textBoxComentarios
            // 
            this.textBoxComentarios.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tasacionBindingSource, "Comentarios", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxComentarios.Location = new System.Drawing.Point(26, 135);
            this.textBoxComentarios.Multiline = true;
            this.textBoxComentarios.Name = "textBoxComentarios";
            this.textBoxComentarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxComentarios.Size = new System.Drawing.Size(384, 104);
            this.textBoxComentarios.TabIndex = 7;
            // 
            // tasacionBindingSource
            // 
            this.tasacionBindingSource.DataSource = typeof(GI.BR.Propiedades.Tasacion);
            // 
            // cbMonedaValorReal
            // 
            this.cbMonedaValorReal.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.valorBindingSource, "Moneda", true));
            this.cbMonedaValorReal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.valorBindingSource, "Moneda", true));
            this.cbMonedaValorReal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonedaValorReal.FormattingEnabled = true;
            this.cbMonedaValorReal.Location = new System.Drawing.Point(197, 53);
            this.cbMonedaValorReal.Name = "cbMonedaValorReal";
            this.cbMonedaValorReal.Size = new System.Drawing.Size(54, 21);
            this.cbMonedaValorReal.TabIndex = 8;
            // 
            // cbMonedaValorPublicacion
            // 
            this.cbMonedaValorPublicacion.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.valorBindingSource1, "Moneda", true));
            this.cbMonedaValorPublicacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.valorBindingSource1, "Moneda", true));
            this.cbMonedaValorPublicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonedaValorPublicacion.FormattingEnabled = true;
            this.cbMonedaValorPublicacion.Location = new System.Drawing.Point(197, 80);
            this.cbMonedaValorPublicacion.Name = "cbMonedaValorPublicacion";
            this.cbMonedaValorPublicacion.Size = new System.Drawing.Size(54, 21);
            this.cbMonedaValorPublicacion.TabIndex = 9;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(346, 260);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 10;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(265, 260);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 11;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // FrmTasacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 295);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.cbMonedaValorPublicacion);
            this.Controls.Add(this.cbMonedaValorReal);
            this.Controls.Add(this.textBoxComentarios);
            this.Controls.Add(this.textBoxValorPublicacion);
            this.Controls.Add(this.textBoxValorReal);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTasacion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Tasación";
            ((System.ComponentModel.ISupportInitialize)(this.valorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasacionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.TextBox textBoxValorReal;
        private System.Windows.Forms.TextBox textBoxValorPublicacion;
        private System.Windows.Forms.TextBox textBoxComentarios;
        private GI.Framework.ComboBox cbMonedaValorReal;
        private GI.Framework.ComboBox cbMonedaValorPublicacion;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.BindingSource valorBindingSource;
        private System.Windows.Forms.BindingSource valorBindingSource1;
        private System.Windows.Forms.BindingSource tasacionBindingSource;
    }
}