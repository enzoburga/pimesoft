namespace GI.UI.Clientes
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
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.cbTipoDocumento = new GI.Framework.ComboBox();
            this.tbNroDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbObervaciones = new System.Windows.Forms.TextBox();
            this.tbTelParticular = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTelCelular = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbTelLaboral = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ctrlDireccion1 = new GI.UI.Generales.CtrlDireccion();
            this.ctrlUbicacion1 = new GI.UI.Generales.CtrlUbicacion();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNombres
            // 
            this.tbNombres.BackColor = System.Drawing.SystemColors.Window;
            this.tbNombres.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbNombres.Location = new System.Drawing.Point(114, 11);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(106, 21);
            this.tbNombres.TabIndex = 0;
            this.tbNombres.TextChanged += new System.EventHandler(this.tbNombres_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(278, 11);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(145, 21);
            this.tbApellido.TabIndex = 1;
            this.tbApellido.TextChanged += new System.EventHandler(this.tbApellido_TextChanged);
            // 
            // cbTipoDocumento
            // 
            this.cbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDocumento.FormattingEnabled = true;
            this.cbTipoDocumento.Location = new System.Drawing.Point(176, 38);
            this.cbTipoDocumento.Name = "cbTipoDocumento";
            this.cbTipoDocumento.Size = new System.Drawing.Size(44, 21);
            this.cbTipoDocumento.TabIndex = 3;
            this.cbTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cbTipoDocumento_SelectedIndexChanged);
            // 
            // tbNroDocumento
            // 
            this.tbNroDocumento.Location = new System.Drawing.Point(114, 38);
            this.tbNroDocumento.MaxLength = 8;
            this.tbNroDocumento.Name = "tbNroDocumento";
            this.tbNroDocumento.Size = new System.Drawing.Size(56, 21);
            this.tbNroDocumento.TabIndex = 2;
            this.tbNroDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbNroDocumento.TextChanged += new System.EventHandler(this.tbNroDocumento_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Documento";
            // 
            // tbObervaciones
            // 
            this.tbObervaciones.Location = new System.Drawing.Point(6, 20);
            this.tbObervaciones.Multiline = true;
            this.tbObervaciones.Name = "tbObervaciones";
            this.tbObervaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbObervaciones.Size = new System.Drawing.Size(399, 75);
            this.tbObervaciones.TabIndex = 18;
            this.tbObervaciones.TextChanged += new System.EventHandler(this.tbObervaciones_TextChanged);
            // 
            // tbTelParticular
            // 
            this.tbTelParticular.Location = new System.Drawing.Point(114, 67);
            this.tbTelParticular.Name = "tbTelParticular";
            this.tbTelParticular.Size = new System.Drawing.Size(106, 21);
            this.tbTelParticular.TabIndex = 5;
            this.tbTelParticular.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbTelParticular.TextChanged += new System.EventHandler(this.tbTelParticular_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Telefono Particular";
            // 
            // tbTelCelular
            // 
            this.tbTelCelular.Location = new System.Drawing.Point(114, 94);
            this.tbTelCelular.Name = "tbTelCelular";
            this.tbTelCelular.Size = new System.Drawing.Size(106, 21);
            this.tbTelCelular.TabIndex = 7;
            this.tbTelCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbTelCelular.TextChanged += new System.EventHandler(this.tbTelCelular_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Telefono Celular";
            // 
            // tbTelLaboral
            // 
            this.tbTelLaboral.Location = new System.Drawing.Point(318, 70);
            this.tbTelLaboral.Name = "tbTelLaboral";
            this.tbTelLaboral.Size = new System.Drawing.Size(105, 21);
            this.tbTelLaboral.TabIndex = 6;
            this.tbTelLaboral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbTelLaboral.TextChanged += new System.EventHandler(this.tbTelLaboral_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(225, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Telefono Trabajo";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(223, 102);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Fecha Nacimiento";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(320, 98);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.ShowCheckBox = true;
            this.dtpFechaNac.Size = new System.Drawing.Size(106, 21);
            this.dtpFechaNac.TabIndex = 8;
            this.dtpFechaNac.Value = new System.DateTime(1978, 11, 16, 15, 35, 0, 0);
            this.dtpFechaNac.ValueChanged += new System.EventHandler(this.dtpFechaNac_ValueChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(278, 38);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(145, 21);
            this.tbEmail.TabIndex = 4;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(237, 41);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "E-Mail";
            // 
            // ctrlDireccion1
            // 
            this.ctrlDireccion1.Direccion = null;
            this.ctrlDireccion1.Location = new System.Drawing.Point(18, 217);
            this.ctrlDireccion1.Name = "ctrlDireccion1";
            this.ctrlDireccion1.Size = new System.Drawing.Size(417, 112);
            this.ctrlDireccion1.SoloLectura = false;
            this.ctrlDireccion1.TabIndex = 38;
            // 
            // ctrlUbicacion1
            // 
            this.ctrlUbicacion1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlUbicacion1.Location = new System.Drawing.Point(18, 131);
            this.ctrlUbicacion1.Name = "ctrlUbicacion1";
            this.ctrlUbicacion1.OpcionTodos = true;
            this.ctrlUbicacion1.Size = new System.Drawing.Size(415, 89);
            this.ctrlUbicacion1.SoloLectura = false;
            this.ctrlUbicacion1.TabIndex = 37;
            this.ctrlUbicacion1.Ubicacion = new GI.BR.Propiedades.Ubicacion();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbObervaciones);
            this.groupBox5.Location = new System.Drawing.Point(17, 335);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(411, 101);
            this.groupBox5.TabIndex = 60;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Observaciones";
            // 
            // TabDatosPrincipales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.ctrlDireccion1);
            this.Controls.Add(this.ctrlUbicacion1);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbTipoDocumento);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tbTelLaboral);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbTelCelular);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbTelParticular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNroDocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNombres);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TabDatosPrincipales";
            this.Size = new System.Drawing.Size(444, 451);
            this.Load += new System.EventHandler(this.TabDatosPrincipales_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbApellido;
        private GI.Framework.ComboBox cbTipoDocumento;
        private System.Windows.Forms.TextBox tbNroDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbObervaciones;
        private System.Windows.Forms.TextBox tbTelParticular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTelCelular;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbTelLaboral;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label18;
        private GI.UI.Generales.CtrlUbicacion ctrlUbicacion1;
        private GI.UI.Generales.CtrlDireccion ctrlDireccion1;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}
