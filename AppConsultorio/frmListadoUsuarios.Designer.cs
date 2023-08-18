namespace AppConsultorio
{
    partial class frmListadoUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoUsuarios));
            this.rbActivos = new System.Windows.Forms.RadioButton();
            this.rbInactivos = new System.Windows.Forms.RadioButton();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.mnuUsuarios = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deshabilitarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habilitarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetearIntentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarGrupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secretariaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetearIntentosRecClaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.mnuUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbActivos
            // 
            this.rbActivos.AutoSize = true;
            this.rbActivos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.rbInactivos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.habilitarUsuarioToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem,
            this.resetearIntentosToolStripMenuItem,
            this.resetearIntentosRecClaveToolStripMenuItem,
            this.cambiarGrupoToolStripMenuItem});
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(222, 158);
            // 
            // deshabilitarUsuarioToolStripMenuItem
            // 
            this.deshabilitarUsuarioToolStripMenuItem.Name = "deshabilitarUsuarioToolStripMenuItem";
            this.deshabilitarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.deshabilitarUsuarioToolStripMenuItem.Text = "Deshabilitar Usuario";
            this.deshabilitarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.deshabilitarUsuarioToolStripMenuItem_Click);
            // 
            // habilitarUsuarioToolStripMenuItem
            // 
            this.habilitarUsuarioToolStripMenuItem.Name = "habilitarUsuarioToolStripMenuItem";
            this.habilitarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.habilitarUsuarioToolStripMenuItem.Text = "Habilitar Usuario";
            this.habilitarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.habilitarUsuarioToolStripMenuItem_Click);
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.eliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario";
            this.eliminarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.eliminarUsuarioToolStripMenuItem_Click);
            // 
            // resetearIntentosToolStripMenuItem
            // 
            this.resetearIntentosToolStripMenuItem.Name = "resetearIntentosToolStripMenuItem";
            this.resetearIntentosToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.resetearIntentosToolStripMenuItem.Text = "Resetear Intentos Login";
            this.resetearIntentosToolStripMenuItem.Click += new System.EventHandler(this.resetearIntentosToolStripMenuItem_Click);
            // 
            // cambiarGrupoToolStripMenuItem
            // 
            this.cambiarGrupoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorToolStripMenuItem,
            this.medicoaToolStripMenuItem,
            this.secretariaoToolStripMenuItem});
            this.cambiarGrupoToolStripMenuItem.Name = "cambiarGrupoToolStripMenuItem";
            this.cambiarGrupoToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.cambiarGrupoToolStripMenuItem.Text = "Cambiar Grupo";
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.administradorToolStripMenuItem.Text = "Administrador";
            this.administradorToolStripMenuItem.Click += new System.EventHandler(this.administradorToolStripMenuItem_Click);
            // 
            // medicoaToolStripMenuItem
            // 
            this.medicoaToolStripMenuItem.Name = "medicoaToolStripMenuItem";
            this.medicoaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.medicoaToolStripMenuItem.Text = "Medico/a";
            this.medicoaToolStripMenuItem.Click += new System.EventHandler(this.medicoaToolStripMenuItem_Click);
            // 
            // secretariaoToolStripMenuItem
            // 
            this.secretariaoToolStripMenuItem.Name = "secretariaoToolStripMenuItem";
            this.secretariaoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.secretariaoToolStripMenuItem.Text = "Secretaria/o";
            this.secretariaoToolStripMenuItem.Click += new System.EventHandler(this.secretariaoToolStripMenuItem_Click);
            // 
            // resetearIntentosRecClaveToolStripMenuItem
            // 
            this.resetearIntentosRecClaveToolStripMenuItem.Name = "resetearIntentosRecClaveToolStripMenuItem";
            this.resetearIntentosRecClaveToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.resetearIntentosRecClaveToolStripMenuItem.Text = "Resetear Intentos Rec. Clave";
            this.resetearIntentosRecClaveToolStripMenuItem.Click += new System.EventHandler(this.resetearIntentosRecClaveToolStripMenuItem_Click);
            // 
            // frmListadoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.rbInactivos);
            this.Controls.Add(this.rbActivos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoUsuarios";
            this.Text = "Usuarios";
            this.Activated += new System.EventHandler(this.frmUsuarios_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUsuarios_FormClosed);
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
        private System.Windows.Forms.ToolStripMenuItem habilitarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarGrupoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secretariaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetearIntentosRecClaveToolStripMenuItem;
    }
}