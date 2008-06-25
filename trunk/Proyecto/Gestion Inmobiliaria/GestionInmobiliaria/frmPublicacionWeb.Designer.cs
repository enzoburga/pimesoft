namespace GI.UI
{
    partial class frmPublicacionWeb
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bRefresh = new System.Windows.Forms.Button();
            this.linkLabelSelectAll = new System.Windows.Forms.LinkLabel();
            this.linkLabelSelectNone = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bIniciar = new System.Windows.Forms.Button();
            this.lvTransacciones = new System.Windows.Forms.ListView();
            this.Objeto = new System.Windows.Forms.ColumnHeader();
            this.Operación = new System.Windows.Forms.ColumnHeader();
            this.Fecha = new System.Windows.Forms.ColumnHeader();
            this.Estado = new System.Windows.Forms.ColumnHeader();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bRefresh);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabelSelectAll);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabelSelectNone);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.bCancelar);
            this.splitContainer1.Panel1.Controls.Add(this.bIniciar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvTransacciones);
            this.splitContainer1.Panel2.Controls.Add(this.progressBar1);
            this.splitContainer1.Size = new System.Drawing.Size(948, 531);
            this.splitContainer1.SplitterDistance = 81;
            this.splitContainer1.TabIndex = 0;
            // 
            // bRefresh
            // 
            this.bRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bRefresh.Location = new System.Drawing.Point(776, 41);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(75, 23);
            this.bRefresh.TabIndex = 5;
            this.bRefresh.Text = "Actualizar";
            this.bRefresh.UseVisualStyleBackColor = true;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // linkLabelSelectAll
            // 
            this.linkLabelSelectAll.AutoSize = true;
            this.linkLabelSelectAll.Location = new System.Drawing.Point(15, 64);
            this.linkLabelSelectAll.Name = "linkLabelSelectAll";
            this.linkLabelSelectAll.Size = new System.Drawing.Size(86, 13);
            this.linkLabelSelectAll.TabIndex = 3;
            this.linkLabelSelectAll.TabStop = true;
            this.linkLabelSelectAll.Text = "Seleccionar todo";
            this.linkLabelSelectAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSelectAll_LinkClicked);
            // 
            // linkLabelSelectNone
            // 
            this.linkLabelSelectNone.AutoSize = true;
            this.linkLabelSelectNone.Location = new System.Drawing.Point(107, 64);
            this.linkLabelSelectNone.Name = "linkLabelSelectNone";
            this.linkLabelSelectNone.Size = new System.Drawing.Size(89, 13);
            this.linkLabelSelectNone.TabIndex = 4;
            this.linkLabelSelectNone.TabStop = true;
            this.linkLabelSelectNone.Text = "Invertir selección";
            this.linkLabelSelectNone.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSelectNone_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 66);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(660, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecciones los objetos a sincronizar y haga clic en el botòn Iniciar.";
            // 
            // bCancelar
            // 
            this.bCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bCancelar.Enabled = false;
            this.bCancelar.Location = new System.Drawing.Point(857, 41);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 1;
            this.bCancelar.Text = "Detener";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bIniciar
            // 
            this.bIniciar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bIniciar.Location = new System.Drawing.Point(857, 12);
            this.bIniciar.Name = "bIniciar";
            this.bIniciar.Size = new System.Drawing.Size(75, 23);
            this.bIniciar.TabIndex = 0;
            this.bIniciar.Text = "Iniciar";
            this.bIniciar.UseVisualStyleBackColor = true;
            this.bIniciar.Click += new System.EventHandler(this.bIniciar_Click);
            // 
            // lvTransacciones
            // 
            this.lvTransacciones.CheckBoxes = true;
            this.lvTransacciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Objeto,
            this.Operación,
            this.Fecha,
            this.Estado,
            this.columnHeader1});
            this.lvTransacciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTransacciones.Location = new System.Drawing.Point(0, 0);
            this.lvTransacciones.Name = "lvTransacciones";
            this.lvTransacciones.Size = new System.Drawing.Size(948, 423);
            this.lvTransacciones.TabIndex = 1;
            this.lvTransacciones.UseCompatibleStateImageBehavior = false;
            this.lvTransacciones.View = System.Windows.Forms.View.Details;
            this.lvTransacciones.SelectedIndexChanged += new System.EventHandler(this.lvTransacciones_SelectedIndexChanged);
            // 
            // Objeto
            // 
            this.Objeto.Text = "Objeto";
            this.Objeto.Width = 221;
            // 
            // Operación
            // 
            this.Operación.Text = "Tipo de Operación";
            this.Operación.Width = 133;
            // 
            // Fecha
            // 
            this.Fecha.Text = "Fecha";
            this.Fecha.Width = 153;
            // 
            // Estado
            // 
            this.Estado.Text = "Estado";
            this.Estado.Width = 80;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 423);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(948, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mensaje";
            this.columnHeader1.Width = 314;
            // 
            // frmPublicacionWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 531);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPublicacionWeb";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Publicación Web";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPublicacionWeb_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bIniciar;
        private System.Windows.Forms.ListView lvTransacciones;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Objeto;
        private System.Windows.Forms.ColumnHeader Operación;
        private System.Windows.Forms.ColumnHeader Fecha;
        private System.Windows.Forms.ColumnHeader Estado;
        private System.Windows.Forms.Button bRefresh;
        private System.Windows.Forms.LinkLabel linkLabelSelectAll;
        private System.Windows.Forms.LinkLabel linkLabelSelectNone;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}