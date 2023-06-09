namespace AppConsultorio
{
    partial class frmTurnosHistoricos
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
            this.components = new System.ComponentModel.Container();
            this.dgvTurnosHistoricos = new System.Windows.Forms.DataGridView();
            this.mnuTurnosHistoricos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ingresarImporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.observacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxMeses = new System.Windows.Forms.ComboBox();
            this.eliminarTurnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosHistoricos)).BeginInit();
            this.mnuTurnosHistoricos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTurnosHistoricos
            // 
            this.dgvTurnosHistoricos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTurnosHistoricos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTurnosHistoricos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnosHistoricos.ContextMenuStrip = this.mnuTurnosHistoricos;
            this.dgvTurnosHistoricos.Location = new System.Drawing.Point(13, 66);
            this.dgvTurnosHistoricos.Name = "dgvTurnosHistoricos";
            this.dgvTurnosHistoricos.Size = new System.Drawing.Size(775, 372);
            this.dgvTurnosHistoricos.TabIndex = 0;
            // 
            // mnuTurnosHistoricos
            // 
            this.mnuTurnosHistoricos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarImporteToolStripMenuItem,
            this.observacionesToolStripMenuItem,
            this.eliminarTurnoToolStripMenuItem});
            this.mnuTurnosHistoricos.Name = "mnuTurnosHistoricos";
            this.mnuTurnosHistoricos.Size = new System.Drawing.Size(181, 92);
            // 
            // ingresarImporteToolStripMenuItem
            // 
            this.ingresarImporteToolStripMenuItem.Name = "ingresarImporteToolStripMenuItem";
            this.ingresarImporteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingresarImporteToolStripMenuItem.Text = "Ingresar Importe";
            this.ingresarImporteToolStripMenuItem.Click += new System.EventHandler(this.ingresarImporteToolStripMenuItem_Click);
            // 
            // observacionesToolStripMenuItem
            // 
            this.observacionesToolStripMenuItem.Name = "observacionesToolStripMenuItem";
            this.observacionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.observacionesToolStripMenuItem.Text = "Observaciones";
            this.observacionesToolStripMenuItem.Click += new System.EventHandler(this.observacionesToolStripMenuItem_Click);
            // 
            // cbxMeses
            // 
            this.cbxMeses.FormattingEnabled = true;
            this.cbxMeses.Location = new System.Drawing.Point(13, 22);
            this.cbxMeses.Name = "cbxMeses";
            this.cbxMeses.Size = new System.Drawing.Size(121, 21);
            this.cbxMeses.TabIndex = 3;
            this.cbxMeses.SelectedIndexChanged += new System.EventHandler(this.cbxMeses_SelectedIndexChanged);
            // 
            // eliminarTurnoToolStripMenuItem
            // 
            this.eliminarTurnoToolStripMenuItem.Name = "eliminarTurnoToolStripMenuItem";
            this.eliminarTurnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarTurnoToolStripMenuItem.Text = "Eliminar Turno";
            this.eliminarTurnoToolStripMenuItem.Click += new System.EventHandler(this.eliminarTurnoToolStripMenuItem_Click);
            // 
            // frmTurnosHistoricos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxMeses);
            this.Controls.Add(this.dgvTurnosHistoricos);
            this.Name = "frmTurnosHistoricos";
            this.Text = "Turnos Historicos";
            this.Activated += new System.EventHandler(this.frmTurnosHistoricos_Activated);
            this.Load += new System.EventHandler(this.frmTurnosHistoricos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosHistoricos)).EndInit();
            this.mnuTurnosHistoricos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTurnosHistoricos;
        private System.Windows.Forms.ContextMenuStrip mnuTurnosHistoricos;
        private System.Windows.Forms.ToolStripMenuItem ingresarImporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem observacionesToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbxMeses;
        private System.Windows.Forms.ToolStripMenuItem eliminarTurnoToolStripMenuItem;
    }
}