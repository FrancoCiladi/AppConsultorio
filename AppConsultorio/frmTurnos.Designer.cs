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
            this.pnlTurnoNuevo = new System.Windows.Forms.Panel();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnAsignarTurno = new System.Windows.Forms.Button();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pnlTurnos = new System.Windows.Forms.Panel();
            this.btnTurnoNuevo = new System.Windows.Forms.Button();
            this.cbxTurnosCategorias = new System.Windows.Forms.ComboBox();
            this.dgvTurnos = new System.Windows.Forms.DataGridView();
            this.pnlPacienteNuevo = new System.Windows.Forms.Panel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cbxObrasSociales = new System.Windows.Forms.ComboBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblObraSocial = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTurnos.SuspendLayout();
            this.pnlTurnoNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.pnlTurnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            this.pnlPacienteNuevo.SuspendLayout();
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
            this.mnuTurnos.Size = new System.Drawing.Size(181, 114);
            // 
            // cancelarTurnoToolStripMenuItem
            // 
            this.cancelarTurnoToolStripMenuItem.Name = "cancelarTurnoToolStripMenuItem";
            this.cancelarTurnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cancelarTurnoToolStripMenuItem.Text = "Cancelar Turno";
            this.cancelarTurnoToolStripMenuItem.Click += new System.EventHandler(this.cancelarTurnoToolStripMenuItem_Click);
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
            // pnlTurnoNuevo
            // 
            this.pnlTurnoNuevo.Controls.Add(this.lblFiltrar);
            this.pnlTurnoNuevo.Controls.Add(this.txtFiltrar);
            this.pnlTurnoNuevo.Controls.Add(this.dgvPacientes);
            this.pnlTurnoNuevo.Controls.Add(this.lblHora);
            this.pnlTurnoNuevo.Controls.Add(this.btnAsignarTurno);
            this.pnlTurnoNuevo.Controls.Add(this.dtpHora);
            this.pnlTurnoNuevo.Controls.Add(this.dtpFecha);
            this.pnlTurnoNuevo.Controls.Add(this.lblFecha);
            this.pnlTurnoNuevo.Location = new System.Drawing.Point(13, 372);
            this.pnlTurnoNuevo.Name = "pnlTurnoNuevo";
            this.pnlTurnoNuevo.Size = new System.Drawing.Size(954, 286);
            this.pnlTurnoNuevo.TabIndex = 2;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.Location = new System.Drawing.Point(232, 7);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(69, 16);
            this.lblFiltrar.TabIndex = 16;
            this.lblFiltrar.Text = "Apellido:";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(307, 6);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(158, 20);
            this.txtFiltrar.TabIndex = 15;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(235, 32);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.Size = new System.Drawing.Size(598, 242);
            this.dgvPacientes.TabIndex = 14;
            this.dgvPacientes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPacientes_RowHeaderMouseClick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(20, 171);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(45, 16);
            this.lblHora.TabIndex = 13;
            this.lblHora.Text = "Hora:";
            // 
            // btnAsignarTurno
            // 
            this.btnAsignarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarTurno.Location = new System.Drawing.Point(850, 125);
            this.btnAsignarTurno.Name = "btnAsignarTurno";
            this.btnAsignarTurno.Size = new System.Drawing.Size(89, 37);
            this.btnAsignarTurno.TabIndex = 9;
            this.btnAsignarTurno.Text = "Asignar Turno";
            this.btnAsignarTurno.UseVisualStyleBackColor = true;
            this.btnAsignarTurno.Click += new System.EventHandler(this.btnAsignarTurno_Click);
            // 
            // dtpHora
            // 
            this.dtpHora.CustomFormat = "HH:mm";
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.Location = new System.Drawing.Point(100, 171);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(103, 20);
            this.dtpHora.TabIndex = 12;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(100, 97);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(103, 20);
            this.dtpFecha.TabIndex = 10;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(20, 97);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 16);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha:";
            // 
            // pnlTurnos
            // 
            this.pnlTurnos.Controls.Add(this.btnTurnoNuevo);
            this.pnlTurnos.Controls.Add(this.cbxTurnosCategorias);
            this.pnlTurnos.Controls.Add(this.dgvTurnos);
            this.pnlTurnos.Location = new System.Drawing.Point(5, 1);
            this.pnlTurnos.Name = "pnlTurnos";
            this.pnlTurnos.Size = new System.Drawing.Size(546, 365);
            this.pnlTurnos.TabIndex = 11;
            // 
            // btnTurnoNuevo
            // 
            this.btnTurnoNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnoNuevo.Location = new System.Drawing.Point(447, 11);
            this.btnTurnoNuevo.Name = "btnTurnoNuevo";
            this.btnTurnoNuevo.Size = new System.Drawing.Size(89, 37);
            this.btnTurnoNuevo.TabIndex = 13;
            this.btnTurnoNuevo.Text = "Nuevo Turno";
            this.btnTurnoNuevo.UseVisualStyleBackColor = true;
            this.btnTurnoNuevo.Click += new System.EventHandler(this.btnTurnoNuevo_Click);
            // 
            // cbxTurnosCategorias
            // 
            this.cbxTurnosCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTurnosCategorias.FormattingEnabled = true;
            this.cbxTurnosCategorias.Location = new System.Drawing.Point(8, 20);
            this.cbxTurnosCategorias.Name = "cbxTurnosCategorias";
            this.cbxTurnosCategorias.Size = new System.Drawing.Size(132, 21);
            this.cbxTurnosCategorias.TabIndex = 12;
            this.cbxTurnosCategorias.SelectedIndexChanged += new System.EventHandler(this.cbxTurnosCategorias_SelectedIndexChanged_1);
            // 
            // dgvTurnos
            // 
            this.dgvTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnos.ContextMenuStrip = this.mnuTurnos;
            this.dgvTurnos.Location = new System.Drawing.Point(7, 63);
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.Size = new System.Drawing.Size(529, 285);
            this.dgvTurnos.TabIndex = 11;
            // 
            // pnlPacienteNuevo
            // 
            this.pnlPacienteNuevo.Controls.Add(this.btnRegistrar);
            this.pnlPacienteNuevo.Controls.Add(this.cbxObrasSociales);
            this.pnlPacienteNuevo.Controls.Add(this.txtCorreo);
            this.pnlPacienteNuevo.Controls.Add(this.txtTelefono);
            this.pnlPacienteNuevo.Controls.Add(this.txtNroDoc);
            this.pnlPacienteNuevo.Controls.Add(this.txtNombre);
            this.pnlPacienteNuevo.Controls.Add(this.txtApellido);
            this.pnlPacienteNuevo.Controls.Add(this.lblObraSocial);
            this.pnlPacienteNuevo.Controls.Add(this.lblCorreo);
            this.pnlPacienteNuevo.Controls.Add(this.lblTelefono);
            this.pnlPacienteNuevo.Controls.Add(this.lblNroDoc);
            this.pnlPacienteNuevo.Controls.Add(this.lblNombre);
            this.pnlPacienteNuevo.Controls.Add(this.lblApellido);
            this.pnlPacienteNuevo.Location = new System.Drawing.Point(558, 1);
            this.pnlPacienteNuevo.Name = "pnlPacienteNuevo";
            this.pnlPacienteNuevo.Size = new System.Drawing.Size(409, 365);
            this.pnlPacienteNuevo.TabIndex = 12;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(161, 292);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(89, 37);
            this.btnRegistrar.TabIndex = 25;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cbxObrasSociales
            // 
            this.cbxObrasSociales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxObrasSociales.FormattingEnabled = true;
            this.cbxObrasSociales.Location = new System.Drawing.Point(178, 246);
            this.cbxObrasSociales.Name = "cbxObrasSociales";
            this.cbxObrasSociales.Size = new System.Drawing.Size(172, 21);
            this.cbxObrasSociales.TabIndex = 24;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(163, 196);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(187, 20);
            this.txtCorreo.TabIndex = 23;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(163, 156);
            this.txtTelefono.MaxLength = 20;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(187, 20);
            this.txtTelefono.TabIndex = 22;
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(214, 111);
            this.txtNroDoc.MaxLength = 8;
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(136, 20);
            this.txtNroDoc.TabIndex = 21;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(163, 70);
            this.txtNombre.MaxLength = 40;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(187, 20);
            this.txtNombre.TabIndex = 20;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(163, 21);
            this.txtApellido.MaxLength = 40;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(187, 20);
            this.txtApellido.TabIndex = 19;
            // 
            // lblObraSocial
            // 
            this.lblObraSocial.AutoSize = true;
            this.lblObraSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObraSocial.Location = new System.Drawing.Point(64, 246);
            this.lblObraSocial.Name = "lblObraSocial";
            this.lblObraSocial.Size = new System.Drawing.Size(102, 18);
            this.lblObraSocial.TabIndex = 18;
            this.lblObraSocial.Text = "Obra Social:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(64, 196);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(66, 18);
            this.lblCorreo.TabIndex = 17;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(64, 158);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(79, 18);
            this.lblTelefono.TabIndex = 16;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDoc.Location = new System.Drawing.Point(64, 113);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(138, 18);
            this.lblNroDoc.TabIndex = 15;
            this.lblNroDoc.Text = "Nro. Documento:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(64, 69);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 18);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(64, 23);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(72, 18);
            this.lblApellido.TabIndex = 13;
            this.lblApellido.Text = "Apellido:";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportarToolStripMenuItem.Text = "Exportar";
            this.exportarToolStripMenuItem.Click += new System.EventHandler(this.exportarToolStripMenuItem_Click);
            // 
            // frmTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(979, 661);
            this.Controls.Add(this.pnlPacienteNuevo);
            this.Controls.Add(this.pnlTurnos);
            this.Controls.Add(this.pnlTurnoNuevo);
            this.Name = "frmTurnos";
            this.Text = "Turnos";
            this.Activated += new System.EventHandler(this.frmTurnos_Activated);
            this.Load += new System.EventHandler(this.frmTurnos_Load);
            this.mnuTurnos.ResumeLayout(false);
            this.pnlTurnoNuevo.ResumeLayout(false);
            this.pnlTurnoNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.pnlTurnos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
            this.pnlPacienteNuevo.ResumeLayout(false);
            this.pnlPacienteNuevo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip mnuTurnos;
        private System.Windows.Forms.ToolStripMenuItem cancelarTurnoToolStripMenuItem;
        private System.Windows.Forms.Panel pnlTurnoNuevo;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnAsignarTurno;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel pnlTurnos;
        private System.Windows.Forms.Button btnTurnoNuevo;
        private System.Windows.Forms.ComboBox cbxTurnosCategorias;
        private System.Windows.Forms.DataGridView dgvTurnos;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.Panel pnlPacienteNuevo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cbxObrasSociales;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNroDoc;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblObraSocial;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.ToolStripMenuItem ingresarImporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem observacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
    }
}