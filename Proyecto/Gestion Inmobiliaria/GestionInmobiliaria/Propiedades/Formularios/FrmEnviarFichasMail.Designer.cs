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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmailTo = new System.Windows.Forms.TextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.bCerrar = new System.Windows.Forms.Button();
            this.bEnviar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lPropiedadesCodigo = new System.Windows.Forms.Label();
            this.bConfigurarCorreo = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabelEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.radioButtonPdf = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dirección de corrego";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mensaje";
            // 
            // textBoxEmailTo
            // 
            this.textBoxEmailTo.Location = new System.Drawing.Point(123, 27);
            this.textBoxEmailTo.Name = "textBoxEmailTo";
            this.textBoxEmailTo.Size = new System.Drawing.Size(191, 21);
            this.textBoxEmailTo.TabIndex = 2;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(123, 55);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(326, 68);
            this.textBoxMessage.TabIndex = 3;
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(374, 162);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 4;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // bEnviar
            // 
            this.bEnviar.Location = new System.Drawing.Point(293, 162);
            this.bEnviar.Name = "bEnviar";
            this.bEnviar.Size = new System.Drawing.Size(75, 23);
            this.bEnviar.TabIndex = 5;
            this.bEnviar.Text = "Enviar";
            this.bEnviar.UseVisualStyleBackColor = true;
            this.bEnviar.Click += new System.EventHandler(this.bEnviar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Propiedades";
            // 
            // lPropiedadesCodigo
            // 
            this.lPropiedadesCodigo.AutoSize = true;
            this.lPropiedadesCodigo.Location = new System.Drawing.Point(123, 9);
            this.lPropiedadesCodigo.Name = "lPropiedadesCodigo";
            this.lPropiedadesCodigo.Size = new System.Drawing.Size(49, 13);
            this.lPropiedadesCodigo.TabIndex = 7;
            this.lPropiedadesCodigo.Text = "P000000";
            // 
            // bConfigurarCorreo
            // 
            this.bConfigurarCorreo.Location = new System.Drawing.Point(153, 162);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 199);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(466, 22);
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
            this.toolStripStatusLabelEstado.Size = new System.Drawing.Size(217, 17);
            this.toolStripStatusLabelEstado.Text = "Haga clic en Enviar para enviar el correo";
            // 
            // radioButtonPdf
            // 
            this.radioButtonPdf.AutoSize = true;
            this.radioButtonPdf.Checked = true;
            this.radioButtonPdf.Location = new System.Drawing.Point(153, 129);
            this.radioButtonPdf.Name = "radioButtonPdf";
            this.radioButtonPdf.Size = new System.Drawing.Size(44, 17);
            this.radioButtonPdf.TabIndex = 10;
            this.radioButtonPdf.TabStop = true;
            this.radioButtonPdf.Text = "PDF";
            this.radioButtonPdf.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(203, 129);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.Text = "Microsft Word";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // FrmEnviarFichasMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 221);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButtonPdf);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bConfigurarCorreo);
            this.Controls.Add(this.lPropiedadesCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bEnviar);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.textBoxEmailTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmailTo;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Button bEnviar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lPropiedadesCodigo;
        private System.Windows.Forms.Button bConfigurarCorreo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelEstado;
        private System.Windows.Forms.RadioButton radioButtonPdf;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}