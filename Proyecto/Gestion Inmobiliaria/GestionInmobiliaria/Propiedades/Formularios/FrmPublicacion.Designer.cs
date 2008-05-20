namespace GI.UI.Propiedades.Formularios
{
    partial class FrmPublicacion
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
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMedio = new System.Windows.Forms.TextBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.comboBoxMonedas = new GI.Framework.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxComentarios = new System.Windows.Forms.TextBox();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Publicación";
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(109, 22);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(85, 21);
            this.dateTimePickerFecha.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Medio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor";
            // 
            // textBoxMedio
            // 
            this.textBoxMedio.Location = new System.Drawing.Point(109, 49);
            this.textBoxMedio.Name = "textBoxMedio";
            this.textBoxMedio.Size = new System.Drawing.Size(257, 21);
            this.textBoxMedio.TabIndex = 4;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(109, 76);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(74, 21);
            this.textBoxValor.TabIndex = 5;
            // 
            // comboBoxMonedas
            // 
            this.comboBoxMonedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonedas.FormattingEnabled = true;
            this.comboBoxMonedas.Location = new System.Drawing.Point(189, 76);
            this.comboBoxMonedas.Name = "comboBoxMonedas";
            this.comboBoxMonedas.Size = new System.Drawing.Size(59, 21);
            this.comboBoxMonedas.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Comentarios";
            // 
            // textBoxComentarios
            // 
            this.textBoxComentarios.Location = new System.Drawing.Point(19, 131);
            this.textBoxComentarios.Multiline = true;
            this.textBoxComentarios.Name = "textBoxComentarios";
            this.textBoxComentarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxComentarios.Size = new System.Drawing.Size(347, 83);
            this.textBoxComentarios.TabIndex = 8;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(291, 230);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 9;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(210, 230);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 10;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // FrmPublicacion
            // 
            this.ClientSize = new System.Drawing.Size(378, 265);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.textBoxComentarios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxMonedas);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.textBoxMedio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPublicacion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Publicación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMedio;
        private System.Windows.Forms.TextBox textBoxValor;
        private GI.Framework.ComboBox comboBoxMonedas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxComentarios;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
    }
}