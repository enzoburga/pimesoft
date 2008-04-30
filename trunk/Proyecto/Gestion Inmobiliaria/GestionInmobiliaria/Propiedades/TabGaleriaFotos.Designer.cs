namespace GI.UI.Propiedades
{
    partial class TabGaleriaFotos
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbFotos = new GI.Framework.ComboBox();
            this.linkLabelAgregarFoto = new System.Windows.Forms.LinkLabel();
            this.linkLabelEliminarFoto = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Lavender;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(35, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 466);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cbFotos
            // 
            this.cbFotos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFotos.FormattingEnabled = true;
            this.cbFotos.Location = new System.Drawing.Point(129, 484);
            this.cbFotos.Name = "cbFotos";
            this.cbFotos.Size = new System.Drawing.Size(229, 21);
            this.cbFotos.TabIndex = 1;
            this.cbFotos.SelectedIndexChanged += new System.EventHandler(this.cbFotos_SelectedIndexChanged);
            // 
            // linkLabelAgregarFoto
            // 
            this.linkLabelAgregarFoto.AutoSize = true;
            this.linkLabelAgregarFoto.Location = new System.Drawing.Point(372, 487);
            this.linkLabelAgregarFoto.Name = "linkLabelAgregarFoto";
            this.linkLabelAgregarFoto.Size = new System.Drawing.Size(92, 13);
            this.linkLabelAgregarFoto.TabIndex = 2;
            this.linkLabelAgregarFoto.TabStop = true;
            this.linkLabelAgregarFoto.Text = "Agregar una Foto";
            this.linkLabelAgregarFoto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAgregarFoto_LinkClicked);
            // 
            // linkLabelEliminarFoto
            // 
            this.linkLabelEliminarFoto.AutoSize = true;
            this.linkLabelEliminarFoto.Location = new System.Drawing.Point(396, 503);
            this.linkLabelEliminarFoto.Name = "linkLabelEliminarFoto";
            this.linkLabelEliminarFoto.Size = new System.Drawing.Size(68, 13);
            this.linkLabelEliminarFoto.TabIndex = 3;
            this.linkLabelEliminarFoto.TabStop = true;
            this.linkLabelEliminarFoto.Text = "Eliminar Foto";
            this.linkLabelEliminarFoto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEliminarFoto_LinkClicked);
            // 
            // TabGaleriaFotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabelEliminarFoto);
            this.Controls.Add(this.linkLabelAgregarFoto);
            this.Controls.Add(this.cbFotos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TabGaleriaFotos";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(494, 544);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private GI.Framework.ComboBox cbFotos;
        private System.Windows.Forms.LinkLabel linkLabelAgregarFoto;
        private System.Windows.Forms.LinkLabel linkLabelEliminarFoto;
    }
}
