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
            this.lblFiltrarApellido = new System.Windows.Forms.Label();
            this.txtFiltroApellido = new System.Windows.Forms.TextBox();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.mnuPacientes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cargarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTurnosPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.mnuPacientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFiltrarApellido
            // 
            this.lblFiltrarApellido.AutoSize = true;
            this.lblFiltrarApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarApellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFiltrarApellido.Location = new System.Drawing.Point(13, 22);
            this.lblFiltrarApellido.Name = "lblFiltrarApellido";
            this.lblFiltrarApellido.Size = new System.Drawing.Size(69, 16);
            this.lblFiltrarApellido.TabIndex = 0;
            this.lblFiltrarApellido.Text = "Apellido:";
            // 
            // txtFiltroApellido
            // 
            this.txtFiltroApellido.Location = new System.Drawing.Point(88, 21);
            this.txtFiltroApellido.Name = "txtFiltroApellido";
            this.txtFiltroApellido.Size = new System.Drawing.Size(154, 20);
            this.txtFiltroApellido.TabIndex = 1;
            this.txtFiltroApellido.TextChanged += new System.EventHandler(this.txtFiltroApellido_TextChanged);
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
            // frmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.txtFiltroApellido);
            this.Controls.Add(this.lblFiltrarApellido);
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

        private System.Windows.Forms.Label lblFiltrarApellido;
        private System.Windows.Forms.TextBox txtFiltroApellido;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.ContextMenuStrip mnuPacientes;
        private System.Windows.Forms.ToolStripMenuItem editarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTurnosPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarPacienteToolStripMenuItem;
    }
}