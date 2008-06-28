namespace GI.UI
{
    partial class frmPopUpEventos
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
            this.lvEventos = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.bSilencias = new System.Windows.Forms.Button();
            this.bCerra = new System.Windows.Forms.Button();
            this.chMantenerOculto = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lvEventos
            // 
            this.lvEventos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvEventos.FullRowSelect = true;
            this.lvEventos.Location = new System.Drawing.Point(12, 12);
            this.lvEventos.Name = "lvEventos";
            this.lvEventos.Size = new System.Drawing.Size(701, 278);
            this.lvEventos.TabIndex = 0;
            this.lvEventos.UseCompatibleStateImageBehavior = false;
            this.lvEventos.View = System.Windows.Forms.View.Details;
            this.lvEventos.DoubleClick += new System.EventHandler(this.lvEventos_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tipo de Evento";
            this.columnHeader1.Width = 93;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fecha";
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Evento";
            this.columnHeader3.Width = 397;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Vencimiento";
            this.columnHeader4.Width = 102;
            // 
            // bSilencias
            // 
            this.bSilencias.Location = new System.Drawing.Point(517, 296);
            this.bSilencias.Name = "bSilencias";
            this.bSilencias.Size = new System.Drawing.Size(115, 23);
            this.bSilencias.TabIndex = 1;
            this.bSilencias.Text = "Apagar Evento/s";
            this.bSilencias.UseVisualStyleBackColor = true;
            this.bSilencias.Click += new System.EventHandler(this.bSilencias_Click);
            // 
            // bCerra
            // 
            this.bCerra.Location = new System.Drawing.Point(638, 296);
            this.bCerra.Name = "bCerra";
            this.bCerra.Size = new System.Drawing.Size(75, 23);
            this.bCerra.TabIndex = 2;
            this.bCerra.Text = "Cerrar";
            this.bCerra.UseVisualStyleBackColor = true;
            this.bCerra.Click += new System.EventHandler(this.bCerra_Click);
            // 
            // chMantenerOculto
            // 
            this.chMantenerOculto.AutoSize = true;
            this.chMantenerOculto.Location = new System.Drawing.Point(12, 300);
            this.chMantenerOculto.Name = "chMantenerOculto";
            this.chMantenerOculto.Size = new System.Drawing.Size(147, 17);
            this.chMantenerOculto.TabIndex = 4;
            this.chMantenerOculto.Text = "Mantener ventana oculta";
            this.chMantenerOculto.UseVisualStyleBackColor = true;
            // 
            // frmPopUpEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 331);
            this.Controls.Add(this.chMantenerOculto);
            this.Controls.Add(this.bCerra);
            this.Controls.Add(this.bSilencias);
            this.Controls.Add(this.lvEventos);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPopUpEventos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notificación de Eventos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPopUpEventos_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPopUpEventos_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvEventos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button bSilencias;
        private System.Windows.Forms.Button bCerra;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.CheckBox chMantenerOculto;
    }
}