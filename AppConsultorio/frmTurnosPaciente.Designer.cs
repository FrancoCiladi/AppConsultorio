namespace AppConsultorio
{
    partial class frmTurnosPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTurnosPaciente));
            this.dgvTurnosRealizados = new System.Windows.Forms.DataGridView();
            this.tabTurnosPaciente = new System.Windows.Forms.TabControl();
            this.tabTurnosRealizados = new System.Windows.Forms.TabPage();
            this.tabTurnosPendientes = new System.Windows.Forms.TabPage();
            this.dgvTurnosPendientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosRealizados)).BeginInit();
            this.tabTurnosPaciente.SuspendLayout();
            this.tabTurnosRealizados.SuspendLayout();
            this.tabTurnosPendientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosPendientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTurnosRealizados
            // 
            this.dgvTurnosRealizados.AllowUserToAddRows = false;
            this.dgvTurnosRealizados.AllowUserToDeleteRows = false;
            this.dgvTurnosRealizados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTurnosRealizados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTurnosRealizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnosRealizados.Location = new System.Drawing.Point(6, 6);
            this.dgvTurnosRealizados.Name = "dgvTurnosRealizados";
            this.dgvTurnosRealizados.Size = new System.Drawing.Size(651, 330);
            this.dgvTurnosRealizados.TabIndex = 0;
            this.dgvTurnosRealizados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurnosPaciente_CellDoubleClick);
            // 
            // tabTurnosPaciente
            // 
            this.tabTurnosPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabTurnosPaciente.Controls.Add(this.tabTurnosRealizados);
            this.tabTurnosPaciente.Controls.Add(this.tabTurnosPendientes);
            this.tabTurnosPaciente.Location = new System.Drawing.Point(12, 12);
            this.tabTurnosPaciente.Name = "tabTurnosPaciente";
            this.tabTurnosPaciente.SelectedIndex = 0;
            this.tabTurnosPaciente.Size = new System.Drawing.Size(671, 368);
            this.tabTurnosPaciente.TabIndex = 1;
            this.tabTurnosPaciente.SelectedIndexChanged += new System.EventHandler(this.tabTurnosPaciente_SelectedIndexChanged);
            // 
            // tabTurnosRealizados
            // 
            this.tabTurnosRealizados.BackColor = System.Drawing.Color.Teal;
            this.tabTurnosRealizados.Controls.Add(this.dgvTurnosRealizados);
            this.tabTurnosRealizados.Location = new System.Drawing.Point(4, 22);
            this.tabTurnosRealizados.Name = "tabTurnosRealizados";
            this.tabTurnosRealizados.Padding = new System.Windows.Forms.Padding(3);
            this.tabTurnosRealizados.Size = new System.Drawing.Size(663, 342);
            this.tabTurnosRealizados.TabIndex = 0;
            this.tabTurnosRealizados.Text = "Realizados";
            // 
            // tabTurnosPendientes
            // 
            this.tabTurnosPendientes.BackColor = System.Drawing.Color.Teal;
            this.tabTurnosPendientes.Controls.Add(this.dgvTurnosPendientes);
            this.tabTurnosPendientes.Location = new System.Drawing.Point(4, 22);
            this.tabTurnosPendientes.Name = "tabTurnosPendientes";
            this.tabTurnosPendientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabTurnosPendientes.Size = new System.Drawing.Size(663, 342);
            this.tabTurnosPendientes.TabIndex = 1;
            this.tabTurnosPendientes.Text = "Pendientes";
            // 
            // dgvTurnosPendientes
            // 
            this.dgvTurnosPendientes.AllowUserToAddRows = false;
            this.dgvTurnosPendientes.AllowUserToDeleteRows = false;
            this.dgvTurnosPendientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTurnosPendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTurnosPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnosPendientes.Location = new System.Drawing.Point(6, 6);
            this.dgvTurnosPendientes.Name = "dgvTurnosPendientes";
            this.dgvTurnosPendientes.Size = new System.Drawing.Size(651, 330);
            this.dgvTurnosPendientes.TabIndex = 1;
            // 
            // frmTurnosPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(695, 392);
            this.Controls.Add(this.tabTurnosPaciente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTurnosPaciente";
            this.Text = "Turnos Paciente";
            this.Load += new System.EventHandler(this.frmTurnosPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosRealizados)).EndInit();
            this.tabTurnosPaciente.ResumeLayout(false);
            this.tabTurnosRealizados.ResumeLayout(false);
            this.tabTurnosPendientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosPendientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTurnosRealizados;
        private System.Windows.Forms.TabControl tabTurnosPaciente;
        private System.Windows.Forms.TabPage tabTurnosRealizados;
        private System.Windows.Forms.TabPage tabTurnosPendientes;
        private System.Windows.Forms.DataGridView dgvTurnosPendientes;
    }
}