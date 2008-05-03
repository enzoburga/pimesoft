namespace GI.UI.AdminAlquileres
{
    partial class frmNuevoContrato
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
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.ctrlContrato1 = new GI.UI.Generales.CtrlContrato();
            this.SuspendLayout();
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(257, 328);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 3;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(347, 328);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 2;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // ctrlContrato1
            // 
            this.ctrlContrato1.Contrato = null;
            this.ctrlContrato1.Location = new System.Drawing.Point(13, 9);
            this.ctrlContrato1.Name = "ctrlContrato1";
            this.ctrlContrato1.Size = new System.Drawing.Size(409, 320);
            this.ctrlContrato1.SoloLectura = false;
            this.ctrlContrato1.TabIndex = 4;
            // 
            // frmNuevoContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 358);
            this.Controls.Add(this.ctrlContrato1);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.bCancelar);
            this.Name = "frmNuevoContrato";
            this.Text = "Nuevo contrato";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private GI.UI.Generales.CtrlContrato ctrlContrato1;
    }
}