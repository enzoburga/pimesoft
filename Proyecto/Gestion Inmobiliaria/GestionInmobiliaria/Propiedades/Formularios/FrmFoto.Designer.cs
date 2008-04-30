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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBoxUrlFoto = new System.Windows.Forms.TextBox();
            this.bExaminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxEsFechada = new System.Windows.Forms.CheckBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Imagenes JPG|*.jpg";
            // 
            // textBoxUrlFoto
            // 
            this.textBoxUrlFoto.Location = new System.Drawing.Point(25, 33);
            this.textBoxUrlFoto.Name = "textBoxUrlFoto";
            this.textBoxUrlFoto.ReadOnly = true;
            this.textBoxUrlFoto.Size = new System.Drawing.Size(341, 21);
            this.textBoxUrlFoto.TabIndex = 0;
            // 
            // bExaminar
            // 
            this.bExaminar.Location = new System.Drawing.Point(372, 31);
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
            this.label1.Location = new System.Drawing.Point(70, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // checkBoxEsFechada
            // 
            this.checkBoxEsFechada.AutoSize = true;
            this.checkBoxEsFechada.Location = new System.Drawing.Point(124, 105);
            this.checkBoxEsFechada.Name = "checkBoxEsFechada";
            this.checkBoxEsFechada.Size = new System.Drawing.Size(142, 17);
            this.checkBoxEsFechada.TabIndex = 3;
            this.checkBoxEsFechada.Text = "Foto Principal (Fachada)";
            this.checkBoxEsFechada.UseVisualStyleBackColor = true;
            this.checkBoxEsFechada.CheckedChanged += new System.EventHandler(this.checkBoxEsFechada_CheckedChanged);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(124, 78);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(184, 21);
            this.textBoxNombre.TabIndex = 4;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(372, 146);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 5;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(291, 146);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 6;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // FrmFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 181);
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
    }
}