namespace AppConsultorio
{
    partial class frmUsuarios
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
            this.rbActivos = new System.Windows.Forms.RadioButton();
            this.rbInactivos = new System.Windows.Forms.RadioButton();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.mnuUsuarios = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deshabilitarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetearIntentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.mnuUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbActivos
            // 
            this.rbActivos.AutoSize = true;
            this.rbActivos.Location = new System.Drawing.Point(13, 27);
            this.rbActivos.Name = "rbActivos";
            this.rbActivos.Size = new System.Drawing.Size(60, 17);
            this.rbActivos.TabIndex = 0;
            this.rbActivos.TabStop = true;
            this.rbActivos.Text = "Activos";
            this.rbActivos.UseVisualStyleBackColor = true;
            this.rbActivos.CheckedChanged += new System.EventHandler(this.rbActivos_CheckedChanged);
            // 
            // rbInactivos
            // 
            this.rbInactivos.AutoSize = true;
            this.rbInactivos.Location = new System.Drawing.Point(94, 27);
            this.rbInactivos.Name = "rbInactivos";
            this.rbInactivos.Size = new System.Drawing.Size(68, 17);
            this.rbInactivos.TabIndex = 1;
            this.rbInactivos.TabStop = true;
            this.rbInactivos.Text = "Inactivos";
            this.rbInactivos.UseVisualStyleBackColor = true;
            this.rbInactivos.CheckedChanged += new System.EventHandler(this.rbInactivos_CheckedChanged);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.ContextMenuStrip = this.mnuUsuarios;
            this.dgvUsuarios.Location = new System.Drawing.Point(13, 65);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(431, 373);
            this.dgvUsuarios.TabIndex = 2;
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deshabilitarUsuarioToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem,
            this.resetearIntentosToolStripMenuItem});
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(180, 70);
            // 
            // deshabilitarUsuarioToolStripMenuItem
            // 
            this.deshabilitarUsuarioToolStripMenuItem.Name = "deshabilitarUsuarioToolStripMenuItem";
            this.deshabilitarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.deshabilitarUsuarioToolStripMenuItem.Text = "Deshabilitar Usuario";
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.eliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario";
            // 
            // resetearIntentosToolStripMenuItem
            // 
            this.resetearIntentosToolStripMenuItem.Name = "resetearIntentosToolStripMenuItem";
            this.resetearIntentosToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.resetearIntentosToolStripMenuItem.Text = "Resetear Intentos";
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.rbInactivos);
            this.Controls.Add(this.rbActivos);
            this.Name = "frmUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.mnuUsuarios.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbActivos;
        private System.Windows.Forms.RadioButton rbInactivos;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.ContextMenuStrip mnuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem deshabilitarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetearIntentosToolStripMenuItem;
    }
}