namespace GI.UI.Inmobiliarias
{
    partial class FrmInmobiliariaExterna
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
            this.textBoxInmobiliaria = new System.Windows.Forms.TextBox();
            this.textBoxContacto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.inmobiliariaExternaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inmobiliariaExternaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inmobiliaria";
            // 
            // textBoxInmobiliaria
            // 
            this.textBoxInmobiliaria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inmobiliariaExternaBindingSource, "Nombre", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxInmobiliaria.Location = new System.Drawing.Point(132, 29);
            this.textBoxInmobiliaria.Name = "textBoxInmobiliaria";
            this.textBoxInmobiliaria.Size = new System.Drawing.Size(276, 21);
            this.textBoxInmobiliaria.TabIndex = 1;
            // 
            // textBoxContacto
            // 
            this.textBoxContacto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inmobiliariaExternaBindingSource, "PersonaResponsable", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxContacto.Location = new System.Drawing.Point(132, 56);
            this.textBoxContacto.Name = "textBoxContacto";
            this.textBoxContacto.Size = new System.Drawing.Size(191, 21);
            this.textBoxContacto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefono";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inmobiliariaExternaBindingSource, "Telefono", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxTelefono.Location = new System.Drawing.Point(132, 83);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(191, 21);
            this.textBoxTelefono.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Persona de Contacto";
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(333, 139);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 6;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(252, 139);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 7;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // inmobiliariaExternaBindingSource
            // 
            this.inmobiliariaExternaBindingSource.DataSource = typeof(GI.BR.InmobiliariaExterna);
            // 
            // FrmInmobiliariaExterna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 174);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxContacto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxInmobiliaria);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInmobiliariaExterna";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Inmobiliaria";
            ((System.ComponentModel.ISupportInitialize)(this.inmobiliariaExternaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInmobiliaria;
        private System.Windows.Forms.TextBox textBoxContacto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.BindingSource inmobiliariaExternaBindingSource;
    }
}