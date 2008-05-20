namespace GI.UI.Propiedades
{
    partial class TabVisitas
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
            this.linkLabelEliminarVisita = new System.Windows.Forms.LinkLabel();
            this.linkLabelAgregarVisita = new System.Windows.Forms.LinkLabel();
            this.lvVisitas = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(547, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 30);
            this.label2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Opciones";
            // 
            // linkLabelEliminarVisita
            // 
            this.linkLabelEliminarVisita.AutoSize = true;
            this.linkLabelEliminarVisita.Location = new System.Drawing.Point(550, 443);
            this.linkLabelEliminarVisita.Name = "linkLabelEliminarVisita";
            this.linkLabelEliminarVisita.Size = new System.Drawing.Size(71, 13);
            this.linkLabelEliminarVisita.TabIndex = 7;
            this.linkLabelEliminarVisita.TabStop = true;
            this.linkLabelEliminarVisita.Text = "Eliminar Visita";
            this.linkLabelEliminarVisita.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEliminarVisita_LinkClicked);
            // 
            // linkLabelAgregarVisita
            // 
            this.linkLabelAgregarVisita.AutoSize = true;
            this.linkLabelAgregarVisita.Location = new System.Drawing.Point(549, 427);
            this.linkLabelAgregarVisita.Name = "linkLabelAgregarVisita";
            this.linkLabelAgregarVisita.Size = new System.Drawing.Size(74, 13);
            this.linkLabelAgregarVisita.TabIndex = 6;
            this.linkLabelAgregarVisita.TabStop = true;
            this.linkLabelAgregarVisita.Text = "Agregar Visita";
            this.linkLabelAgregarVisita.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAgregarVisita_LinkClicked);
            // 
            // lvVisitas
            // 
            this.lvVisitas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvVisitas.FullRowSelect = true;
            this.lvVisitas.HideSelection = false;
            this.lvVisitas.Location = new System.Drawing.Point(15, 17);
            this.lvVisitas.Name = "lvVisitas";
            this.lvVisitas.Size = new System.Drawing.Size(608, 407);
            this.lvVisitas.TabIndex = 5;
            this.lvVisitas.UseCompatibleStateImageBehavior = false;
            this.lvVisitas.View = System.Windows.Forms.View.Details;
            this.lvVisitas.DoubleClick += new System.EventHandler(this.lvVisitas_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fecha";
            this.columnHeader1.Width = 82;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hora";
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Concretada";
            this.columnHeader3.Width = 72;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Contacto";
            this.columnHeader4.Width = 124;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Detalles";
            this.columnHeader5.Width = 217;
            // 
            // TabVisitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelEliminarVisita);
            this.Controls.Add(this.linkLabelAgregarVisita);
            this.Controls.Add(this.lvVisitas);
            this.Name = "TabVisitas";
            this.Size = new System.Drawing.Size(640, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelEliminarVisita;
        private System.Windows.Forms.LinkLabel linkLabelAgregarVisita;
        private System.Windows.Forms.ListView lvVisitas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}
