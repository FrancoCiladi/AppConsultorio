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
            this.rbRealizados = new System.Windows.Forms.RadioButton();
            this.rbCancelados = new System.Windows.Forms.RadioButton();
            this.observacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosHistoricos)).BeginInit();
            this.mnuTurnosHistoricos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTurnosHistoricos
            // 
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
            this.observacionesToolStripMenuItem});
            this.mnuTurnosHistoricos.Name = "mnuTurnosHistoricos";
            this.mnuTurnosHistoricos.Size = new System.Drawing.Size(181, 70);
            // 
            // ingresarImporteToolStripMenuItem
            // 
            this.ingresarImporteToolStripMenuItem.Name = "ingresarImporteToolStripMenuItem";
            this.ingresarImporteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingresarImporteToolStripMenuItem.Text = "Ingresar Importe";
            this.ingresarImporteToolStripMenuItem.Click += new System.EventHandler(this.ingresarImporteToolStripMenuItem_Click);
            // 
            // rbRealizados
            // 
            this.rbRealizados.AutoSize = true;
            this.rbRealizados.Location = new System.Drawing.Point(13, 22);
            this.rbRealizados.Name = "rbRealizados";
            this.rbRealizados.Size = new System.Drawing.Size(77, 17);
            this.rbRealizados.TabIndex = 1;
            this.rbRealizados.TabStop = true;
            this.rbRealizados.Text = "Realizados";
            this.rbRealizados.UseVisualStyleBackColor = true;
            this.rbRealizados.CheckedChanged += new System.EventHandler(this.rbRealizados_CheckedChanged);
            // 
            // rbCancelados
            // 
            this.rbCancelados.AutoSize = true;
            this.rbCancelados.Location = new System.Drawing.Point(114, 22);
            this.rbCancelados.Name = "rbCancelados";
            this.rbCancelados.Size = new System.Drawing.Size(81, 17);
            this.rbCancelados.TabIndex = 2;
            this.rbCancelados.TabStop = true;
            this.rbCancelados.Text = "Cancelados";
            this.rbCancelados.UseVisualStyleBackColor = true;
            this.rbCancelados.CheckedChanged += new System.EventHandler(this.rbCancelados_CheckedChanged);
            // 
            // observacionesToolStripMenuItem
            // 
            this.observacionesToolStripMenuItem.Name = "observacionesToolStripMenuItem";
            this.observacionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.observacionesToolStripMenuItem.Text = "Observaciones";
            this.observacionesToolStripMenuItem.Click += new System.EventHandler(this.observacionesToolStripMenuItem_Click);
            // 
            // frmTurnosHistoricos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbCancelados);
            this.Controls.Add(this.rbRealizados);
            this.Controls.Add(this.dgvTurnosHistoricos);
            this.Name = "frmTurnosHistoricos";
            this.Text = "Turnos Historicos";
            this.Load += new System.EventHandler(this.frmTurnosHistoricos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosHistoricos)).EndInit();
            this.mnuTurnosHistoricos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTurnosHistoricos;
        private System.Windows.Forms.RadioButton rbRealizados;
        private System.Windows.Forms.RadioButton rbCancelados;
        private System.Windows.Forms.ContextMenuStrip mnuTurnosHistoricos;
        private System.Windows.Forms.ToolStripMenuItem ingresarImporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem observacionesToolStripMenuItem;
    }
}