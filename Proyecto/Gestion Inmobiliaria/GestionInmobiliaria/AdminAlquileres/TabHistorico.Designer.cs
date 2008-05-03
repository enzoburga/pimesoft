namespace GI.UI.AdminAlquileres
{
    partial class TabHistorico
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
            this.lvContratos = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lvContratos
            // 
            this.lvContratos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvContratos.FullRowSelect = true;
            this.lvContratos.HideSelection = false;
            this.lvContratos.Location = new System.Drawing.Point(16, 17);
            this.lvContratos.Name = "lvContratos";
            this.lvContratos.Size = new System.Drawing.Size(413, 498);
            this.lvContratos.TabIndex = 0;
            this.lvContratos.UseCompatibleStateImageBehavior = false;
            this.lvContratos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Inquilino";
            this.columnHeader1.Width = 143;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fecha Inicio";
            this.columnHeader2.Width = 131;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fecha Vto.";
            this.columnHeader3.Width = 99;
            // 
            // TabHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvContratos);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TabHistorico";
            this.Size = new System.Drawing.Size(444, 518);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvContratos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
