namespace AppConsultorio
{
    partial class frmCancelacionesPacientes
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
            this.dgvCancelacionesPacientes = new System.Windows.Forms.DataGridView();
            this.mnuCancelacionesPacientes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancelacionesPacientes)).BeginInit();
            this.mnuCancelacionesPacientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCancelacionesPacientes
            // 
            this.dgvCancelacionesPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCancelacionesPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCancelacionesPacientes.ContextMenuStrip = this.mnuCancelacionesPacientes;
            this.dgvCancelacionesPacientes.Location = new System.Drawing.Point(13, 12);
            this.dgvCancelacionesPacientes.Name = "dgvCancelacionesPacientes";
            this.dgvCancelacionesPacientes.Size = new System.Drawing.Size(558, 410);
            this.dgvCancelacionesPacientes.TabIndex = 0;
            // 
            // mnuCancelacionesPacientes
            // 
            this.mnuCancelacionesPacientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarToolStripMenuItem});
            this.mnuCancelacionesPacientes.Name = "mnuCancelacionesPacientes";
            this.mnuCancelacionesPacientes.Size = new System.Drawing.Size(181, 48);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportarToolStripMenuItem.Text = "Exportar";
            this.exportarToolStripMenuItem.Click += new System.EventHandler(this.exportarToolStripMenuItem_Click);
            // 
            // frmCancelacionesPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 434);
            this.Controls.Add(this.dgvCancelacionesPacientes);
            this.Name = "frmCancelacionesPacientes";
            this.Text = "Cancelaciones Pacientes";
            this.Load += new System.EventHandler(this.frmCancelacionesPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancelacionesPacientes)).EndInit();
            this.mnuCancelacionesPacientes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCancelacionesPacientes;
        private System.Windows.Forms.ContextMenuStrip mnuCancelacionesPacientes;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
    }
}