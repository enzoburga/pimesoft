namespace GI.UI.Propiedades.Formularios
{
    partial class FrmEnviarFichasMail
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmailTo = new System.Windows.Forms.RichTextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.bCerrar = new System.Windows.Forms.Button();
            this.bEnviar = new System.Windows.Forms.Button();
            this.bConfigurarCorreo = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabelEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.radioButtonPdf = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.bAgregarContacto = new System.Windows.Forms.Button();
            this.tbPropiedades = new System.Windows.Forms.RichTextBox();
            this.bAgregarPropiedad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mensaje";
            // 
            // textBoxEmailTo
            // 
            this.textBoxEmailTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmailTo.Location = new System.Drawing.Point(88, 33);
            this.textBoxEmailTo.Name = "textBoxEmailTo";
            this.textBoxEmailTo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.textBoxEmailTo.Size = new System.Drawing.Size(528, 46);
            this.textBoxEmailTo.TabIndex = 2;
            this.textBoxEmailTo.Text = "";
            this.textBoxEmailTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEmailTo_KeyPress);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMessage.Location = new System.Drawing.Point(12, 95);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessage.Size = new System.Drawing.Size(685, 279);
            this.textBoxMessage.TabIndex = 3;
            // 
            // bCerrar
            // 
            this.bCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCerrar.Location = new System.Drawing.Point(622, 403);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 4;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // bEnviar
            // 
            this.bEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bEnviar.Location = new System.Drawing.Point(541, 403);
            this.bEnviar.Name = "bEnviar";
            this.bEnviar.Size = new System.Drawing.Size(75, 23);
            this.bEnviar.TabIndex = 5;
            this.bEnviar.Text = "Enviar";
            this.bEnviar.UseVisualStyleBackColor = true;
            this.bEnviar.Click += new System.EventHandler(this.bEnviar_Click);
            // 
            // bConfigurarCorreo
            // 
            this.bConfigurarCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bConfigurarCorreo.Location = new System.Drawing.Point(401, 403);
            this.bConfigurarCorreo.Name = "bConfigurarCorreo";
            this.bConfigurarCorreo.Size = new System.Drawing.Size(118, 23);
            this.bConfigurarCorreo.TabIndex = 8;
            this.bConfigurarCorreo.Text = "Configurar Correo";
            this.bConfigurarCorreo.UseVisualStyleBackColor = true;
            this.bConfigurarCorreo.Click += new System.EventHandler(this.bConfigurarCorreo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.toolStripStatusLabelEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 440);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(714, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabelEstado
            // 
            this.toolStripStatusLabelEstado.Name = "toolStripStatusLabelEstado";
            this.toolStripStatusLabelEstado.Size = new System.Drawing.Size(200, 17);
            this.toolStripStatusLabelEstado.Text = "Haga clic en Enviar para enviar el correo";
            // 
            // radioButtonPdf
            // 
            this.radioButtonPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonPdf.AutoSize = true;
            this.radioButtonPdf.Checked = true;
            this.radioButtonPdf.Location = new System.Drawing.Point(555, 380);
            this.radioButtonPdf.Name = "radioButtonPdf";
            this.radioButtonPdf.Size = new System.Drawing.Size(44, 17);
            this.radioButtonPdf.TabIndex = 10;
            this.radioButtonPdf.TabStop = true;
            this.radioButtonPdf.Text = "PDF";
            this.radioButtonPdf.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(605, 380);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.Text = "Microsft Word";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // bAgregarContacto
            // 
            this.bAgregarContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAgregarContacto.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.bAgregarContacto.FlatAppearance.BorderSize = 0;
            this.bAgregarContacto.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.bAgregarContacto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bAgregarContacto.Location = new System.Drawing.Point(622, 31);
            this.bAgregarContacto.Name = "bAgregarContacto";
            this.bAgregarContacto.Size = new System.Drawing.Size(75, 23);
            this.bAgregarContacto.TabIndex = 5;
            this.bAgregarContacto.Text = "Agregar";
            this.bAgregarContacto.UseVisualStyleBackColor = true;
            this.bAgregarContacto.Click += new System.EventHandler(this.bAgregarContacto_Click);
            // 
            // tbPropiedades
            // 
            this.tbPropiedades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPropiedades.Location = new System.Drawing.Point(88, 6);
            this.tbPropiedades.Name = "tbPropiedades";
            this.tbPropiedades.ReadOnly = true;
            this.tbPropiedades.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbPropiedades.Size = new System.Drawing.Size(528, 21);
            this.tbPropiedades.TabIndex = 12;
            this.tbPropiedades.Text = "";
            // 
            // bAgregarPropiedad
            // 
            this.bAgregarPropiedad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAgregarPropiedad.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.bAgregarPropiedad.FlatAppearance.BorderSize = 0;
            this.bAgregarPropiedad.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.bAgregarPropiedad.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bAgregarPropiedad.Location = new System.Drawing.Point(622, 6);
            this.bAgregarPropiedad.Name = "bAgregarPropiedad";
            this.bAgregarPropiedad.Size = new System.Drawing.Size(75, 23);
            this.bAgregarPropiedad.TabIndex = 5;
            this.bAgregarPropiedad.Text = "Agregar";
            this.bAgregarPropiedad.UseVisualStyleBackColor = true;
            this.bAgregarPropiedad.Visible = false;
            this.bAgregarPropiedad.Click += new System.EventHandler(this.bAgregarPropiedad_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Propiedades:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para:";
            // 
            // FrmEnviarFichasMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 462);
            this.Controls.Add(this.tbPropiedades);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButtonPdf);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bConfigurarCorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bAgregarPropiedad);
            this.Controls.Add(this.bAgregarContacto);
            this.Controls.Add(this.bEnviar);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.textBoxEmailTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(474, 253);
            this.Name = "FrmEnviarFichasMail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Enviar fichas por mail";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox textBoxEmailTo;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Button bEnviar;
        private System.Windows.Forms.Button bConfigurarCorreo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelEstado;
        private System.Windows.Forms.RadioButton radioButtonPdf;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button bAgregarContacto;
        private System.Windows.Forms.RichTextBox tbPropiedades;
        private System.Windows.Forms.Button bAgregarPropiedad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}