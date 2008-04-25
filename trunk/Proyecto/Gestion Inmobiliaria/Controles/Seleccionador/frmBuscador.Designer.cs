namespace GI.Framework.Seleccionador
{
    partial class frmBuscador
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
            this.txtbuscador = new System.Windows.Forms.TextBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCriterios = new GI.Framework.ComboBox();
            this.cbOpciones = new GI.Framework.ComboBox();
            this.SuspendLayout();
            // 
            // txtbuscador
            // 
            this.txtbuscador.Location = new System.Drawing.Point(12, 52);
            this.txtbuscador.Name = "txtbuscador";
            this.txtbuscador.Size = new System.Drawing.Size(268, 21);
            this.txtbuscador.TabIndex = 0;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(286, 52);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 1;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Criterio de Búsqueda";
            // 
            // cbCriterios
            // 
            this.cbCriterios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCriterios.FormattingEnabled = true;
            this.cbCriterios.Location = new System.Drawing.Point(125, 19);
            this.cbCriterios.Name = "cbCriterios";
            this.cbCriterios.Size = new System.Drawing.Size(155, 21);
            this.cbCriterios.TabIndex = 3;
            this.cbCriterios.SelectedIndexChanged += new System.EventHandler(this.cbCriterios_SelectedIndexChanged);
            // 
            // cbOpciones
            // 
            this.cbOpciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpciones.FormattingEnabled = true;
            this.cbOpciones.Location = new System.Drawing.Point(12, 54);
            this.cbOpciones.Name = "cbOpciones";
            this.cbOpciones.Size = new System.Drawing.Size(268, 21);
            this.cbOpciones.TabIndex = 4;
            // 
            // frmBuscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 98);
            this.Controls.Add(this.cbOpciones);
            this.Controls.Add(this.cbCriterios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.txtbuscador);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscador";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Buscar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbuscador;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Label label1;
        private ComboBox cbCriterios;
        private ComboBox cbOpciones;
    }
}