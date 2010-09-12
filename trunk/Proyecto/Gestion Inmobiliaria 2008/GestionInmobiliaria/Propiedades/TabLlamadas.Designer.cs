namespace GI.UI.Propiedades
{
    partial class TabLlamadas
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
            this.linkLabelEliminarLlamado = new System.Windows.Forms.LinkLabel();
            this.linkLabelAgregarLlamado = new System.Windows.Forms.LinkLabel();
            this.lvLlamados = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(539, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 30);
            this.label2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Opciones";
            // 
            // linkLabelEliminarLlamado
            // 
            this.linkLabelEliminarLlamado.AutoSize = true;
            this.linkLabelEliminarLlamado.Location = new System.Drawing.Point(542, 443);
            this.linkLabelEliminarLlamado.Name = "linkLabelEliminarLlamado";
            this.linkLabelEliminarLlamado.Size = new System.Drawing.Size(85, 13);
            this.linkLabelEliminarLlamado.TabIndex = 12;
            this.linkLabelEliminarLlamado.TabStop = true;
            this.linkLabelEliminarLlamado.Text = "Eliminar Llamado";
            this.linkLabelEliminarLlamado.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEliminarLlamado_LinkClicked);
            // 
            // linkLabelAgregarLlamado
            // 
            this.linkLabelAgregarLlamado.AutoSize = true;
            this.linkLabelAgregarLlamado.Location = new System.Drawing.Point(541, 427);
            this.linkLabelAgregarLlamado.Name = "linkLabelAgregarLlamado";
            this.linkLabelAgregarLlamado.Size = new System.Drawing.Size(88, 13);
            this.linkLabelAgregarLlamado.TabIndex = 11;
            this.linkLabelAgregarLlamado.TabStop = true;
            this.linkLabelAgregarLlamado.Text = "Agregar Llamado";
            this.linkLabelAgregarLlamado.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAgregarLlamado_LinkClicked);
            // 
            // lvLlamados
            // 
            this.lvLlamados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvLlamados.FullRowSelect = true;
            this.lvLlamados.HideSelection = false;
            this.lvLlamados.Location = new System.Drawing.Point(15, 17);
            this.lvLlamados.Name = "lvLlamados";
            this.lvLlamados.Size = new System.Drawing.Size(608, 407);
            this.lvLlamados.TabIndex = 10;
            this.lvLlamados.UseCompatibleStateImageBehavior = false;
            this.lvLlamados.View = System.Windows.Forms.View.Details;
            this.lvLlamados.DoubleClick += new System.EventHandler(this.lvLlamados_DoubleClick);
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
            // columnHeader4
            // 
            this.columnHeader4.Text = "Contacto";
            this.columnHeader4.Width = 124;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Teléfono";
            this.columnHeader5.Width = 139;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Comentarios";
            this.columnHeader6.Width = 165;
            // 
            // TabLlamadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelEliminarLlamado);
            this.Controls.Add(this.linkLabelAgregarLlamado);
            this.Controls.Add(this.lvLlamados);
            this.Name = "TabLlamadas";
            this.Size = new System.Drawing.Size(640, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelEliminarLlamado;
        private System.Windows.Forms.LinkLabel linkLabelAgregarLlamado;
        private System.Windows.Forms.ListView lvLlamados;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}
