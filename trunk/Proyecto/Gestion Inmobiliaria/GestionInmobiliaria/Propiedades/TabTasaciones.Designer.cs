namespace GI.UI.Propiedades
{
    partial class TabTasaciones
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelEliminarTasacion = new System.Windows.Forms.LinkLabel();
            this.linkLabelAgregarTasacion = new System.Windows.Forms.LinkLabel();
            this.lvTasaciones = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(530, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 30);
            this.label2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Opciones";
            // 
            // linkLabelEliminarTasacion
            // 
            this.linkLabelEliminarTasacion.AutoSize = true;
            this.linkLabelEliminarTasacion.Location = new System.Drawing.Point(533, 443);
            this.linkLabelEliminarTasacion.Name = "linkLabelEliminarTasacion";
            this.linkLabelEliminarTasacion.Size = new System.Drawing.Size(88, 13);
            this.linkLabelEliminarTasacion.TabIndex = 18;
            this.linkLabelEliminarTasacion.TabStop = true;
            this.linkLabelEliminarTasacion.Text = "Eliminar Tasación";
            this.linkLabelEliminarTasacion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEliminarTasacion_LinkClicked);
            // 
            // linkLabelAgregarTasacion
            // 
            this.linkLabelAgregarTasacion.AutoSize = true;
            this.linkLabelAgregarTasacion.Location = new System.Drawing.Point(532, 427);
            this.linkLabelAgregarTasacion.Name = "linkLabelAgregarTasacion";
            this.linkLabelAgregarTasacion.Size = new System.Drawing.Size(91, 13);
            this.linkLabelAgregarTasacion.TabIndex = 17;
            this.linkLabelAgregarTasacion.TabStop = true;
            this.linkLabelAgregarTasacion.Text = "Agregar Tasación";
            this.linkLabelAgregarTasacion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAgregarTasacion_LinkClicked);
            // 
            // lvTasaciones
            // 
            this.lvTasaciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvTasaciones.FullRowSelect = true;
            this.lvTasaciones.HideSelection = false;
            this.lvTasaciones.Location = new System.Drawing.Point(15, 17);
            this.lvTasaciones.Name = "lvTasaciones";
            this.lvTasaciones.Size = new System.Drawing.Size(608, 407);
            this.lvTasaciones.TabIndex = 16;
            this.lvTasaciones.UseCompatibleStateImageBehavior = false;
            this.lvTasaciones.View = System.Windows.Forms.View.Details;
            this.lvTasaciones.DoubleClick += new System.EventHandler(this.lvPedidos_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fecha";
            this.columnHeader1.Width = 94;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Valor Real";
            this.columnHeader2.Width = 87;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Valor Mercado";
            this.columnHeader3.Width = 93;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Detalles";
            this.columnHeader4.Width = 284;
            // 
            // TabTasaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelEliminarTasacion);
            this.Controls.Add(this.linkLabelAgregarTasacion);
            this.Controls.Add(this.lvTasaciones);
            this.Name = "TabTasaciones";
            this.Size = new System.Drawing.Size(640, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelEliminarTasacion;
        private System.Windows.Forms.LinkLabel linkLabelAgregarTasacion;
        private System.Windows.Forms.ListView lvTasaciones;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;

    }
}
