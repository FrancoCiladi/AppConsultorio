namespace AppConsultorio
{
    partial class frmPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPacientes));
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.mnuPacientes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cargarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTurnosPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxFiltrado = new System.Windows.Forms.ComboBox();
            this.cbxObrasSociales = new System.Windows.Forms.ComboBox();
            this.btnAsignarTurno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.mnuPacientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(151, 21);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(154, 20);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltroApellido_TextChanged);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.ContextMenuStrip = this.mnuPacientes;
            this.dgvPacientes.Location = new System.Drawing.Point(16, 62);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.Size = new System.Drawing.Size(772, 376);
            this.dgvPacientes.TabIndex = 2;
            this.dgvPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacientes_CellContentClick);
            // 
            // mnuPacientes
            // 
            this.mnuPacientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarPacienteToolStripMenuItem,
            this.editarPacienteToolStripMenuItem,
            this.eliminarPacienteToolStripMenuItem,
            this.verTurnosPacienteToolStripMenuItem});
            this.mnuPacientes.Name = "mnuPacientes";
            this.mnuPacientes.Size = new System.Drawing.Size(178, 92);
            // 
            // cargarPacienteToolStripMenuItem
            // 
            this.cargarPacienteToolStripMenuItem.Name = "cargarPacienteToolStripMenuItem";
            this.cargarPacienteToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.cargarPacienteToolStripMenuItem.Text = "Cargar Paciente";
            this.cargarPacienteToolStripMenuItem.Click += new System.EventHandler(this.cargarPacienteToolStripMenuItem_Click);
            // 
            // editarPacienteToolStripMenuItem
            // 
            this.editarPacienteToolStripMenuItem.Name = "editarPacienteToolStripMenuItem";
            this.editarPacienteToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.editarPacienteToolStripMenuItem.Text = "Editar Paciente";
            this.editarPacienteToolStripMenuItem.Click += new System.EventHandler(this.editarPacienteToolStripMenuItem_Click);
            // 
            // eliminarPacienteToolStripMenuItem
            // 
            this.eliminarPacienteToolStripMenuItem.Name = "eliminarPacienteToolStripMenuItem";
            this.eliminarPacienteToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.eliminarPacienteToolStripMenuItem.Text = "Eliminar Paciente";
            this.eliminarPacienteToolStripMenuItem.Click += new System.EventHandler(this.eliminarPacienteToolStripMenuItem_Click);
            // 
            // verTurnosPacienteToolStripMenuItem
            // 
            this.verTurnosPacienteToolStripMenuItem.Name = "verTurnosPacienteToolStripMenuItem";
            this.verTurnosPacienteToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.verTurnosPacienteToolStripMenuItem.Text = "Ver Turnos Paciente";
            this.verTurnosPacienteToolStripMenuItem.Click += new System.EventHandler(this.verTurnosPacienteToolStripMenuItem_Click);
            // 
            // cbxFiltrado
            // 
            this.cbxFiltrado.FormattingEnabled = true;
            this.cbxFiltrado.Location = new System.Drawing.Point(16, 21);
            this.cbxFiltrado.Name = "cbxFiltrado";
            this.cbxFiltrado.Size = new System.Drawing.Size(121, 21);
            this.cbxFiltrado.TabIndex = 3;
            this.cbxFiltrado.SelectedIndexChanged += new System.EventHandler(this.cbxFiltrado_SelectedIndexChanged);
            // 
            // cbxObrasSociales
            // 
            this.cbxObrasSociales.FormattingEnabled = true;
            this.cbxObrasSociales.Location = new System.Drawing.Point(151, 20);
            this.cbxObrasSociales.Name = "cbxObrasSociales";
            this.cbxObrasSociales.Size = new System.Drawing.Size(190, 21);
            this.cbxObrasSociales.TabIndex = 4;
            this.cbxObrasSociales.SelectedIndexChanged += new System.EventHandler(this.cbxObrasSociales_SelectedIndexChanged);
            // 
            // btnAsignarTurno
            // 
            this.btnAsignarTurno.Location = new System.Drawing.Point(674, 9);
            this.btnAsignarTurno.Name = "btnAsignarTurno";
            this.btnAsignarTurno.Size = new System.Drawing.Size(114, 43);
            this.btnAsignarTurno.TabIndex = 5;
            this.btnAsignarTurno.Text = "Asignar Turno";
            this.btnAsignarTurno.UseVisualStyleBackColor = true;
            this.btnAsignarTurno.Click += new System.EventHandler(this.btnAsignarTurno_Click);
            // 
            // frmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAsignarTurno);
            this.Controls.Add(this.cbxObrasSociales);
            this.Controls.Add(this.cbxFiltrado);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.txtFiltro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPacientes";
            this.Text = "Pacientes";
            this.Activated += new System.EventHandler(this.frmPacientes_Activated);
            this.Load += new System.EventHandler(this.frmPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.mnuPacientes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.ContextMenuStrip mnuPacientes;
        private System.Windows.Forms.ToolStripMenuItem editarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTurnosPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarPacienteToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbxFiltrado;
        private System.Windows.Forms.ComboBox cbxObrasSociales;
        private System.Windows.Forms.Button btnAsignarTurno;
    }
}