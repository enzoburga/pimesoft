namespace GI.UI.Propiedades
{
    partial class TabPublicaciones
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
            this.linkLabelEliminar = new System.Windows.Forms.LinkLabel();
            this.linkLabelAgregarPublicacion = new System.Windows.Forms.LinkLabel();
            this.lvPublicaciones = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(520, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 30);
            this.label2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Opciones";
            // 
            // linkLabelEliminar
            // 
            this.linkLabelEliminar.AutoSize = true;
            this.linkLabelEliminar.Location = new System.Drawing.Point(523, 443);
            this.linkLabelEliminar.Name = "linkLabelEliminar";
            this.linkLabelEliminar.Size = new System.Drawing.Size(98, 13);
            this.linkLabelEliminar.TabIndex = 12;
            this.linkLabelEliminar.TabStop = true;
            this.linkLabelEliminar.Text = "Eliminar Publicación";
            this.linkLabelEliminar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEliminar_LinkClicked);
            // 
            // linkLabelAgregarPublicacion
            // 
            this.linkLabelAgregarPublicacion.AutoSize = true;
            this.linkLabelAgregarPublicacion.Location = new System.Drawing.Point(522, 427);
            this.linkLabelAgregarPublicacion.Name = "linkLabelAgregarPublicacion";
            this.linkLabelAgregarPublicacion.Size = new System.Drawing.Size(101, 13);
            this.linkLabelAgregarPublicacion.TabIndex = 11;
            this.linkLabelAgregarPublicacion.TabStop = true;
            this.linkLabelAgregarPublicacion.Text = "Agregar Publicación";
            this.linkLabelAgregarPublicacion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAgregarPublicacion_LinkClicked);
            // 
            // lvPublicaciones
            // 
            this.lvPublicaciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvPublicaciones.FullRowSelect = true;
            this.lvPublicaciones.HideSelection = false;
            this.lvPublicaciones.Location = new System.Drawing.Point(15, 17);
            this.lvPublicaciones.Name = "lvPublicaciones";
            this.lvPublicaciones.Size = new System.Drawing.Size(608, 407);
            this.lvPublicaciones.TabIndex = 10;
            this.lvPublicaciones.UseCompatibleStateImageBehavior = false;
            this.lvPublicaciones.View = System.Windows.Forms.View.Details;
            this.lvPublicaciones.DoubleClick += new System.EventHandler(this.lvPublicaciones_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fecha";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Publicado en";
            this.columnHeader2.Width = 96;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Costo";
            this.columnHeader3.Width = 83;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Detalles";
            this.columnHeader4.Width = 251;
            // 
            // TabPublicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelEliminar);
            this.Controls.Add(this.linkLabelAgregarPublicacion);
            this.Controls.Add(this.lvPublicaciones);
            this.Name = "TabPublicaciones";
            this.Size = new System.Drawing.Size(640, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelEliminar;
        private System.Windows.Forms.LinkLabel linkLabelAgregarPublicacion;
        private System.Windows.Forms.ListView lvPublicaciones;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
