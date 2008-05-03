namespace GI.UI.AdminAlquileres
{
    partial class TabDatosPrincipales
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
            this.cBoxEsPropietario = new System.Windows.Forms.CheckBox();
            this.LinkPropiedad = new System.Windows.Forms.LinkLabel();
            this.admAlquilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.LinkPropietario = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.propiedadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contratoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DepositoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MontoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctrlDireccion1 = new GI.UI.Generales.CtrlDireccion();
            this.ctrlContrato1 = new GI.UI.Generales.CtrlContrato();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admAlquilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propiedadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepositoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBoxEsPropietario);
            this.groupBox2.Controls.Add(this.LinkPropiedad);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.LinkPropietario);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(14, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 71);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Propiedad";
            // 
            // cBoxEsPropietario
            // 
            this.cBoxEsPropietario.AutoSize = true;
            this.cBoxEsPropietario.Location = new System.Drawing.Point(310, 26);
            this.cBoxEsPropietario.Name = "cBoxEsPropietario";
            this.cBoxEsPropietario.Size = new System.Drawing.Size(92, 17);
            this.cBoxEsPropietario.TabIndex = 1;
            this.cBoxEsPropietario.Text = "Es Propietario";
            this.cBoxEsPropietario.UseVisualStyleBackColor = true;
            this.cBoxEsPropietario.CheckedChanged += new System.EventHandler(this.cBoxEsPropietario_CheckedChanged);
            // 
            // LinkPropiedad
            // 
            this.LinkPropiedad.AutoSize = true;
            this.LinkPropiedad.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.admAlquilerBindingSource, "Alquiler", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LinkPropiedad.Location = new System.Drawing.Point(74, 49);
            this.LinkPropiedad.Name = "LinkPropiedad";
            this.LinkPropiedad.Size = new System.Drawing.Size(129, 13);
            this.LinkPropiedad.TabIndex = 0;
            this.LinkPropiedad.TabStop = true;
            this.LinkPropiedad.Text = "Seleccione una Propiedad";
            this.LinkPropiedad.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkPropiedad_LinkClicked);
            // 
            // admAlquilerBindingSource
            // 
            this.admAlquilerBindingSource.DataSource = typeof(GI.BR.AdmAlquileres.AdmAlquiler);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Código";
            // 
            // LinkPropietario
            // 
            this.LinkPropietario.AutoSize = true;
            this.LinkPropietario.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.admAlquilerBindingSource, "Contacto", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LinkPropietario.Location = new System.Drawing.Point(74, 26);
            this.LinkPropietario.Name = "LinkPropietario";
            this.LinkPropietario.Size = new System.Drawing.Size(119, 13);
            this.LinkPropietario.TabIndex = 2;
            this.LinkPropietario.TabStop = true;
            this.LinkPropietario.Text = "Seleccione un Contacto";
            this.LinkPropietario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkPropietario_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Contacto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // propiedadBindingSource
            // 
            this.propiedadBindingSource.DataSource = typeof(GI.BR.Propiedades.Propiedad);
            // 
            // contratoBindingSource
            // 
            this.contratoBindingSource.DataSource = typeof(GI.BR.AdmAlquileres.Contrato);
            // 
            // DepositoBindingSource
            // 
            this.DepositoBindingSource.DataSource = typeof(GI.BR.Valor);
            // 
            // MontoBindingSource
            // 
            this.MontoBindingSource.DataSource = typeof(GI.BR.Valor);
            // 
            // ctrlDireccion1
            // 
            this.ctrlDireccion1.Direccion = null;
            this.ctrlDireccion1.Location = new System.Drawing.Point(14, 81);
            this.ctrlDireccion1.Name = "ctrlDireccion1";
            this.ctrlDireccion1.Size = new System.Drawing.Size(417, 113);
            this.ctrlDireccion1.SoloLectura = false;
            this.ctrlDireccion1.TabIndex = 0;
            // 
            // ctrlContrato1
            // 
            this.ctrlContrato1.Contrato = null;
            this.ctrlContrato1.Location = new System.Drawing.Point(14, 197);
            this.ctrlContrato1.Name = "ctrlContrato1";
            this.ctrlContrato1.Size = new System.Drawing.Size(409, 318);
            this.ctrlContrato1.SoloLectura = false;
            this.ctrlContrato1.TabIndex = 1;
            // 
            // TabDatosPrincipales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlContrato1);
            this.Controls.Add(this.ctrlDireccion1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TabDatosPrincipales";
            this.Size = new System.Drawing.Size(444, 518);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admAlquilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propiedadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepositoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel LinkPropiedad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LinkPropietario;
        private System.Windows.Forms.Label label2;
        private GI.UI.Generales.CtrlDireccion ctrlDireccion1;
        private System.Windows.Forms.BindingSource propiedadBindingSource;
        private System.Windows.Forms.BindingSource MontoBindingSource;
        private System.Windows.Forms.BindingSource contratoBindingSource;
        private System.Windows.Forms.BindingSource admAlquilerBindingSource;
        private System.Windows.Forms.BindingSource DepositoBindingSource;
        private System.Windows.Forms.CheckBox cBoxEsPropietario;
        private GI.UI.Generales.CtrlContrato ctrlContrato1;

    }
}
