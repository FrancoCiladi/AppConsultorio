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
            this.lblFiltrarApellido = new System.Windows.Forms.Label();
            this.txtFiltroApellido = new System.Windows.Forms.TextBox();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.mnuPacientes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cargarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTurnosPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeBajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkPacientesDeshabilitados = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.mnuPacientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFiltrarApellido
            // 
            this.lblFiltrarApellido.AutoSize = true;
            this.lblFiltrarApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.verTurnosPacienteToolStripMenuItem,
            this.cambiarEstadoToolStripMenuItem});
            this.mnuPacientes.Name = "mnuPacientes";
            this.mnuPacientes.Size = new System.Drawing.Size(181, 114);
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
            // verTurnosPacienteToolStripMenuItem
            // 
            this.verTurnosPacienteToolStripMenuItem.Name = "verTurnosPacienteToolStripMenuItem";
            this.verTurnosPacienteToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.verTurnosPacienteToolStripMenuItem.Text = "Ver Turnos Paciente";
            this.verTurnosPacienteToolStripMenuItem.Click += new System.EventHandler(this.verTurnosPacienteToolStripMenuItem_Click);
            // 
            // cambiarEstadoToolStripMenuItem
            // 
            this.cambiarEstadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.habilitarToolStripMenuItem,
            this.darDeBajaToolStripMenuItem});
            this.cambiarEstadoToolStripMenuItem.Name = "cambiarEstadoToolStripMenuItem";
            this.cambiarEstadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cambiarEstadoToolStripMenuItem.Text = "Cambiar Estado";
            // 
            // habilitarToolStripMenuItem
            // 
            this.habilitarToolStripMenuItem.Name = "habilitarToolStripMenuItem";
            this.habilitarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.habilitarToolStripMenuItem.Text = "Habilitar";
            this.habilitarToolStripMenuItem.Click += new System.EventHandler(this.habilitarToolStripMenuItem_Click_1);
            // 
            // darDeBajaToolStripMenuItem
            // 
            this.darDeBajaToolStripMenuItem.Name = "darDeBajaToolStripMenuItem";
            this.darDeBajaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.darDeBajaToolStripMenuItem.Text = "Dar de baja";
            this.darDeBajaToolStripMenuItem.Click += new System.EventHandler(this.darDeBajaToolStripMenuItem_Click_1);
            // 
            // chkPacientesDeshabilitados
            // 
            this.chkPacientesDeshabilitados.AutoSize = true;
            this.chkPacientesDeshabilitados.Location = new System.Drawing.Point(287, 23);
            this.chkPacientesDeshabilitados.Name = "chkPacientesDeshabilitados";
            this.chkPacientesDeshabilitados.Size = new System.Drawing.Size(161, 17);
            this.chkPacientesDeshabilitados.TabIndex = 3;
            this.chkPacientesDeshabilitados.Text = "Ver pacientes deshabilitados";
            this.chkPacientesDeshabilitados.UseVisualStyleBackColor = true;
            // 
            // frmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkPacientesDeshabilitados);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.txtFiltroApellido);
            this.Controls.Add(this.lblFiltrarApellido);
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
        private System.Windows.Forms.ToolStripMenuItem cambiarEstadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habilitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeBajaToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkPacientesDeshabilitados;
    }
}