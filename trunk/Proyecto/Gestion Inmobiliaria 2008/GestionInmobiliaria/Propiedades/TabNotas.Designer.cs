namespace GI.UI.Propiedades
{
    partial class TabNotas
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
            this.lvNotas = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.linkLabelAgregar = new System.Windows.Forms.LinkLabel();
            this.linkLabelEliminar = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvNotas
            // 
            this.lvNotas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvNotas.FullRowSelect = true;
            this.lvNotas.HideSelection = false;
            this.lvNotas.Location = new System.Drawing.Point(15, 17);
            this.lvNotas.Name = "lvNotas";
            this.lvNotas.Size = new System.Drawing.Size(608, 407);
            this.lvNotas.TabIndex = 0;
            this.lvNotas.UseCompatibleStateImageBehavior = false;
            this.lvNotas.View = System.Windows.Forms.View.Details;
            this.lvNotas.DoubleClick += new System.EventHandler(this.lvNotas_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fecha";
            this.columnHeader1.Width = 73;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nota";
            this.columnHeader2.Width = 318;
            // 
            // linkLabelAgregar
            // 
            this.linkLabelAgregar.AutoSize = true;
            this.linkLabelAgregar.Location = new System.Drawing.Point(551, 427);
            this.linkLabelAgregar.Name = "linkLabelAgregar";
            this.linkLabelAgregar.Size = new System.Drawing.Size(72, 13);
            this.linkLabelAgregar.TabIndex = 1;
            this.linkLabelAgregar.TabStop = true;
            this.linkLabelAgregar.Text = "Agregar Nota";
            this.linkLabelAgregar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAgregar_LinkClicked);
            // 
            // linkLabelEliminar
            // 
            this.linkLabelEliminar.AutoSize = true;
            this.linkLabelEliminar.Location = new System.Drawing.Point(552, 443);
            this.linkLabelEliminar.Name = "linkLabelEliminar";
            this.linkLabelEliminar.Size = new System.Drawing.Size(69, 13);
            this.linkLabelEliminar.TabIndex = 2;
            this.linkLabelEliminar.TabStop = true;
            this.linkLabelEliminar.Text = "Eliminar Nota";
            this.linkLabelEliminar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEliminar_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Opciones";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(549, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 30);
            this.label2.TabIndex = 4;
            // 
            // TabNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelEliminar);
            this.Controls.Add(this.linkLabelAgregar);
            this.Controls.Add(this.lvNotas);
            this.Name = "TabNotas";
            this.Size = new System.Drawing.Size(640, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvNotas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.LinkLabel linkLabelAgregar;
        private System.Windows.Forms.LinkLabel linkLabelEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
