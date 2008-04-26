namespace GI.UI.Generales
{
    partial class CtrlDireccion
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxEntreCalle2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxEntreCalle1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxCodigoPostal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxDpto = new System.Windows.Forms.TextBox();
            this.textBoxPiso = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxCalle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.direccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.direccionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxEntreCalle2);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.textBoxEntreCalle1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBoxCodigoPostal);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBoxDpto);
            this.groupBox2.Controls.Add(this.textBoxPiso);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBoxNumero);
            this.groupBox2.Controls.Add(this.textBoxCalle);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(1, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 107);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dirección";
            // 
            // textBoxEntreCalle2
            // 
            this.textBoxEntreCalle2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.direccionBindingSource, "CalleEntre2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxEntreCalle2.Location = new System.Drawing.Point(230, 69);
            this.textBoxEntreCalle2.Name = "textBoxEntreCalle2";
            this.textBoxEntreCalle2.Size = new System.Drawing.Size(164, 20);
            this.textBoxEntreCalle2.TabIndex = 6;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(211, 72);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(12, 13);
            this.label21.TabIndex = 27;
            this.label21.Text = "y";
            // 
            // textBoxEntreCalle1
            // 
            this.textBoxEntreCalle1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.direccionBindingSource, "CalleEntre1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxEntreCalle1.Location = new System.Drawing.Point(67, 69);
            this.textBoxEntreCalle1.Name = "textBoxEntreCalle1";
            this.textBoxEntreCalle1.Size = new System.Drawing.Size(138, 20);
            this.textBoxEntreCalle1.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Entre calle";
            // 
            // textBoxCodigoPostal
            // 
            this.textBoxCodigoPostal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.direccionBindingSource, "CodigoPostal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCodigoPostal.Location = new System.Drawing.Point(245, 41);
            this.textBoxCodigoPostal.Name = "textBoxCodigoPostal";
            this.textBoxCodigoPostal.Size = new System.Drawing.Size(46, 20);
            this.textBoxCodigoPostal.TabIndex = 4;
            this.textBoxCodigoPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(219, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "CP";
            // 
            // textBoxDpto
            // 
            this.textBoxDpto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.direccionBindingSource, "Depto", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxDpto.Location = new System.Drawing.Point(166, 41);
            this.textBoxDpto.Name = "textBoxDpto";
            this.textBoxDpto.Size = new System.Drawing.Size(24, 20);
            this.textBoxDpto.TabIndex = 3;
            this.textBoxDpto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxPiso
            // 
            this.textBoxPiso.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.direccionBindingSource, "Piso", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxPiso.Location = new System.Drawing.Point(67, 41);
            this.textBoxPiso.Name = "textBoxPiso";
            this.textBoxPiso.Size = new System.Drawing.Size(38, 20);
            this.textBoxPiso.TabIndex = 2;
            this.textBoxPiso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(120, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Depto.";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.direccionBindingSource, "Numero", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.textBoxNumero.Location = new System.Drawing.Point(347, 14);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(47, 20);
            this.textBoxNumero.TabIndex = 1;
            this.textBoxNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxCalle
            // 
            this.textBoxCalle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.direccionBindingSource, "Calle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCalle.Location = new System.Drawing.Point(67, 14);
            this.textBoxCalle.Name = "textBoxCalle";
            this.textBoxCalle.Size = new System.Drawing.Size(224, 20);
            this.textBoxCalle.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Piso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(297, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Número";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Calle";
            // 
            // direccionBindingSource
            // 
            this.direccionBindingSource.DataSource = typeof(GI.BR.Propiedades.Direccion);
            // 
            // CtrlDireccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "CtrlDireccion";
            this.Size = new System.Drawing.Size(417, 113);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.direccionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxEntreCalle2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxEntreCalle1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxCodigoPostal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxDpto;
        private System.Windows.Forms.TextBox textBoxPiso;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBoxCalle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource direccionBindingSource;
    }
}
