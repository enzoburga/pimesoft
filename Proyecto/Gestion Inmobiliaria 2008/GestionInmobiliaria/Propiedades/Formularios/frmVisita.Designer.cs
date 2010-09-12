namespace GI.UI.Propiedades.Formularios
{
    partial class frmVisita
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.checkBoxAlarma = new System.Windows.Forms.CheckBox();
            this.cbAviso = new GI.Framework.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxVisitante = new System.Windows.Forms.TextBox();
            this.textBoxTelefonoContacto = new System.Windows.Forms.TextBox();
            this.textBoxDetalle = new System.Windows.Forms.TextBox();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.checkBoxRealizada = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha / Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contacto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Detalles";
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.CustomFormat = "d/MM/yy HH:mm";
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(77, 8);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(114, 21);
            this.dateTimePickerFecha.TabIndex = 5;
            // 
            // checkBoxAlarma
            // 
            this.checkBoxAlarma.AutoSize = true;
            this.checkBoxAlarma.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAlarma.Checked = true;
            this.checkBoxAlarma.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAlarma.Location = new System.Drawing.Point(14, 40);
            this.checkBoxAlarma.Name = "checkBoxAlarma";
            this.checkBoxAlarma.Size = new System.Drawing.Size(59, 17);
            this.checkBoxAlarma.TabIndex = 7;
            this.checkBoxAlarma.Text = "Alarma";
            this.checkBoxAlarma.UseVisualStyleBackColor = true;
            this.checkBoxAlarma.CheckedChanged += new System.EventHandler(this.checkBoxAlarma_CheckedChanged);
            // 
            // cbAviso
            // 
            this.cbAviso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAviso.FormattingEnabled = true;
            this.cbAviso.Location = new System.Drawing.Point(77, 38);
            this.cbAviso.Name = "cbAviso";
            this.cbAviso.Size = new System.Drawing.Size(98, 21);
            this.cbAviso.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefono";
            // 
            // textBoxVisitante
            // 
            this.textBoxVisitante.Location = new System.Drawing.Point(77, 65);
            this.textBoxVisitante.Name = "textBoxVisitante";
            this.textBoxVisitante.Size = new System.Drawing.Size(224, 21);
            this.textBoxVisitante.TabIndex = 10;
            this.textBoxVisitante.Text = "Emilio Davidis";
            // 
            // textBoxTelefonoContacto
            // 
            this.textBoxTelefonoContacto.Location = new System.Drawing.Point(77, 92);
            this.textBoxTelefonoContacto.Name = "textBoxTelefonoContacto";
            this.textBoxTelefonoContacto.Size = new System.Drawing.Size(224, 21);
            this.textBoxTelefonoContacto.TabIndex = 11;
            this.textBoxTelefonoContacto.Text = "153-590-5900";
            // 
            // textBoxDetalle
            // 
            this.textBoxDetalle.Location = new System.Drawing.Point(77, 119);
            this.textBoxDetalle.Multiline = true;
            this.textBoxDetalle.Name = "textBoxDetalle";
            this.textBoxDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDetalle.Size = new System.Drawing.Size(224, 105);
            this.textBoxDetalle.TabIndex = 12;
            this.textBoxDetalle.Text = "un detalle de la visita";
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(145, 230);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 14;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(226, 230);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 13;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // checkBoxRealizada
            // 
            this.checkBoxRealizada.AutoSize = true;
            this.checkBoxRealizada.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxRealizada.Checked = true;
            this.checkBoxRealizada.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRealizada.Location = new System.Drawing.Point(231, 13);
            this.checkBoxRealizada.Name = "checkBoxRealizada";
            this.checkBoxRealizada.Size = new System.Drawing.Size(72, 17);
            this.checkBoxRealizada.TabIndex = 15;
            this.checkBoxRealizada.Text = "Realizada";
            this.checkBoxRealizada.UseVisualStyleBackColor = true;
            // 
            // frmVisita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 263);
            this.Controls.Add(this.checkBoxRealizada);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.textBoxDetalle);
            this.Controls.Add(this.textBoxTelefonoContacto);
            this.Controls.Add(this.textBoxVisitante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbAviso);
            this.Controls.Add(this.checkBoxAlarma);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVisita";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Visita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.CheckBox checkBoxAlarma;
        private GI.Framework.ComboBox cbAviso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxVisitante;
        private System.Windows.Forms.TextBox textBoxTelefonoContacto;
        private System.Windows.Forms.TextBox textBoxDetalle;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.CheckBox checkBoxRealizada;
    }
}