namespace AppConsultorio
{
    partial class frmTurnos
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
            this.dgvTurnos = new System.Windows.Forms.DataGridView();
            this.mnuTurnos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cancelarTurnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxTurnosCategorias = new System.Windows.Forms.ComboBox();
            this.btnAgregarTurno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            this.mnuTurnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTurnos
            // 
            this.dgvTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnos.ContextMenuStrip = this.mnuTurnos;
            this.dgvTurnos.Location = new System.Drawing.Point(12, 69);
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.Size = new System.Drawing.Size(529, 285);
            this.dgvTurnos.TabIndex = 0;
            // 
            // mnuTurnos
            // 
            this.mnuTurnos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelarTurnoToolStripMenuItem});
            this.mnuTurnos.Name = "mnuTurnos";
            this.mnuTurnos.Size = new System.Drawing.Size(155, 26);
            // 
            // cancelarTurnoToolStripMenuItem
            // 
            this.cancelarTurnoToolStripMenuItem.Name = "cancelarTurnoToolStripMenuItem";
            this.cancelarTurnoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.cancelarTurnoToolStripMenuItem.Text = "Cancelar Turno";
            this.cancelarTurnoToolStripMenuItem.Click += new System.EventHandler(this.cancelarTurnoToolStripMenuItem_Click);
            // 
            // cbxTurnosCategorias
            // 
            this.cbxTurnosCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTurnosCategorias.FormattingEnabled = true;
            this.cbxTurnosCategorias.Location = new System.Drawing.Point(12, 21);
            this.cbxTurnosCategorias.Name = "cbxTurnosCategorias";
            this.cbxTurnosCategorias.Size = new System.Drawing.Size(132, 21);
            this.cbxTurnosCategorias.TabIndex = 1;
            this.cbxTurnosCategorias.SelectedIndexChanged += new System.EventHandler(this.cbxTurnosCategorias_SelectedIndexChanged);
            // 
            // btnAgregarTurno
            // 
            this.btnAgregarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTurno.Location = new System.Drawing.Point(452, 12);
            this.btnAgregarTurno.Name = "btnAgregarTurno";
            this.btnAgregarTurno.Size = new System.Drawing.Size(89, 37);
            this.btnAgregarTurno.TabIndex = 3;
            this.btnAgregarTurno.Text = "Agregar Turno";
            this.btnAgregarTurno.UseVisualStyleBackColor = true;
            this.btnAgregarTurno.Click += new System.EventHandler(this.btnAgregarTurno_Click);
            // 
            // frmTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 366);
            this.Controls.Add(this.btnAgregarTurno);
            this.Controls.Add(this.cbxTurnosCategorias);
            this.Controls.Add(this.dgvTurnos);
            this.Name = "frmTurnos";
            this.Text = "Turnos";
            this.Activated += new System.EventHandler(this.frmTurnos_Activated);
            this.Load += new System.EventHandler(this.frmTurnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
            this.mnuTurnos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTurnos;
        private System.Windows.Forms.ComboBox cbxTurnosCategorias;
        private System.Windows.Forms.ContextMenuStrip mnuTurnos;
        private System.Windows.Forms.ToolStripMenuItem cancelarTurnoToolStripMenuItem;
        private System.Windows.Forms.Button btnAgregarTurno;
    }
}