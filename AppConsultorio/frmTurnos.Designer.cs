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
            this.mnuTurnos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cancelarTurnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarImporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.observacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPacientes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxTurnosCategorias = new System.Windows.Forms.ComboBox();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.btnAsignarTurno = new System.Windows.Forms.Button();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dgvTurnos = new System.Windows.Forms.DataGridView();
            this.cbxMeses = new System.Windows.Forms.ComboBox();
            this.mnuTurnos.SuspendLayout();
            this.mnuPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuTurnos
            // 
            this.mnuTurnos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelarTurnoToolStripMenuItem,
            this.ingresarImporteToolStripMenuItem,
            this.observacionesToolStripMenuItem,
            this.exportarToolStripMenuItem});
            this.mnuTurnos.Name = "mnuTurnos";
            this.mnuTurnos.Size = new System.Drawing.Size(162, 92);
            // 
            // cancelarTurnoToolStripMenuItem
            // 
            this.cancelarTurnoToolStripMenuItem.Name = "cancelarTurnoToolStripMenuItem";
            this.cancelarTurnoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.cancelarTurnoToolStripMenuItem.Text = "Cancelar Turno";
            this.cancelarTurnoToolStripMenuItem.Click += new System.EventHandler(this.cancelarTurnoToolStripMenuItem_Click);
            // 
            // ingresarImporteToolStripMenuItem
            // 
            this.ingresarImporteToolStripMenuItem.Name = "ingresarImporteToolStripMenuItem";
            this.ingresarImporteToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.ingresarImporteToolStripMenuItem.Text = "Ingresar Importe";
            this.ingresarImporteToolStripMenuItem.Click += new System.EventHandler(this.ingresarImporteToolStripMenuItem_Click);
            // 
            // observacionesToolStripMenuItem
            // 
            this.observacionesToolStripMenuItem.Name = "observacionesToolStripMenuItem";
            this.observacionesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.observacionesToolStripMenuItem.Text = "Observaciones";
            this.observacionesToolStripMenuItem.Click += new System.EventHandler(this.observacionesToolStripMenuItem_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.exportarToolStripMenuItem.Text = "Exportar";
            this.exportarToolStripMenuItem.Click += new System.EventHandler(this.exportarToolStripMenuItem_Click);
            // 
            // mnuPacientes
            // 
            this.mnuPacientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPacienteToolStripMenuItem});
            this.mnuPacientes.Name = "mnuPacientes";
            this.mnuPacientes.Size = new System.Drawing.Size(158, 26);
            // 
            // nuevoPacienteToolStripMenuItem
            // 
            this.nuevoPacienteToolStripMenuItem.Name = "nuevoPacienteToolStripMenuItem";
            this.nuevoPacienteToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.nuevoPacienteToolStripMenuItem.Text = "Nuevo Paciente";
            this.nuevoPacienteToolStripMenuItem.Click += new System.EventHandler(this.nuevoPacienteToolStripMenuItem_Click);
            // 
            // cbxTurnosCategorias
            // 
            this.cbxTurnosCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTurnosCategorias.FormattingEnabled = true;
            this.cbxTurnosCategorias.Location = new System.Drawing.Point(12, 12);
            this.cbxTurnosCategorias.Name = "cbxTurnosCategorias";
            this.cbxTurnosCategorias.Size = new System.Drawing.Size(132, 21);
            this.cbxTurnosCategorias.TabIndex = 25;
            this.cbxTurnosCategorias.SelectedIndexChanged += new System.EventHandler(this.cbxTurnosCategorias_SelectedIndexChanged_1);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.ContextMenuStrip = this.mnuPacientes;
            this.dgvPacientes.Location = new System.Drawing.Point(185, 302);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.Size = new System.Drawing.Size(492, 272);
            this.dgvPacientes.TabIndex = 31;
            this.dgvPacientes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPacientes_RowHeaderMouseClick_1);
            // 
            // btnAsignarTurno
            // 
            this.btnAsignarTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAsignarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarTurno.Location = new System.Drawing.Point(683, 420);
            this.btnAsignarTurno.Name = "btnAsignarTurno";
            this.btnAsignarTurno.Size = new System.Drawing.Size(89, 60);
            this.btnAsignarTurno.TabIndex = 26;
            this.btnAsignarTurno.Text = "Asignar Turno";
            this.btnAsignarTurno.UseVisualStyleBackColor = true;
            this.btnAsignarTurno.Click += new System.EventHandler(this.btnAsignarTurno_Click_1);
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFiltrar.Location = new System.Drawing.Point(12, 322);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(69, 16);
            this.lblFiltrar.TabIndex = 33;
            this.lblFiltrar.Text = "Apellido:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(70, 442);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(103, 20);
            this.dtpFecha.TabIndex = 27;
            // 
            // dtpHora
            // 
            this.dtpHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpHora.CustomFormat = "HH:mm";
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.Location = new System.Drawing.Point(70, 519);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(103, 20);
            this.dtpHora.TabIndex = 29;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHora.Location = new System.Drawing.Point(12, 523);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(45, 16);
            this.lblHora.TabIndex = 30;
            this.lblHora.Text = "Hora:";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFiltrar.Location = new System.Drawing.Point(14, 347);
            this.txtFiltrar.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(158, 20);
            this.txtFiltrar.TabIndex = 32;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged_1);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFecha.Location = new System.Drawing.Point(12, 441);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 16);
            this.lblFecha.TabIndex = 28;
            this.lblFecha.Text = "Fecha:";
            // 
            // dgvTurnos
            // 
            this.dgvTurnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnos.ContextMenuStrip = this.mnuTurnos;
            this.dgvTurnos.Location = new System.Drawing.Point(12, 39);
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.ShowEditingIcon = false;
            this.dgvTurnos.Size = new System.Drawing.Size(757, 257);
            this.dgvTurnos.TabIndex = 24;
            // 
            // cbxMeses
            // 
            this.cbxMeses.FormattingEnabled = true;
            this.cbxMeses.Location = new System.Drawing.Point(150, 12);
            this.cbxMeses.Name = "cbxMeses";
            this.cbxMeses.Size = new System.Drawing.Size(155, 21);
            this.cbxMeses.TabIndex = 34;
            this.cbxMeses.SelectedIndexChanged += new System.EventHandler(this.cbxMeses_SelectedIndexChanged);
            // 
            // frmTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(789, 586);
            this.Controls.Add(this.cbxMeses);
            this.Controls.Add(this.dgvTurnos);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.cbxTurnosCategorias);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnAsignarTurno);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTurnos";
            this.Text = "Turnos";
            this.Activated += new System.EventHandler(this.frmTurnos_Activated);
            this.Load += new System.EventHandler(this.frmTurnos_Load);
            this.mnuTurnos.ResumeLayout(false);
            this.mnuPacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip mnuTurnos;
        private System.Windows.Forms.ToolStripMenuItem cancelarTurnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarImporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem observacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip mnuPacientes;
        private System.Windows.Forms.ToolStripMenuItem nuevoPacienteToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbxTurnosCategorias;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.Button btnAsignarTurno;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridView dgvTurnos;
        private System.Windows.Forms.ComboBox cbxMeses;
    }
}