namespace AppConsultorio
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.pnlMenuPrincipal = new System.Windows.Forms.Panel();
            this.pnlBotonesInfo = new System.Windows.Forms.Panel();
            this.btnCancelacionesPacientes = new System.Windows.Forms.Button();
            this.btnTotalImportes = new System.Windows.Forms.Button();
            this.btnInfoTurnosCancelados = new System.Windows.Forms.Button();
            this.btnInfoTurnosRealizados = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnTurnosHistoricos = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnTurnos = new System.Windows.Forms.Button();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pnlChildForms = new System.Windows.Forms.Panel();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlMenuPrincipal.SuspendLayout();
            this.pnlBotonesInfo.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            this.pnlChildForms.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuPrincipal
            // 
            this.pnlMenuPrincipal.BackColor = System.Drawing.Color.Teal;
            this.pnlMenuPrincipal.Controls.Add(this.pnlBotonesInfo);
            this.pnlMenuPrincipal.Controls.Add(this.btnInfo);
            this.pnlMenuPrincipal.Controls.Add(this.btnTurnosHistoricos);
            this.pnlMenuPrincipal.Controls.Add(this.btnPacientes);
            this.pnlMenuPrincipal.Controls.Add(this.btnTurnos);
            this.pnlMenuPrincipal.Controls.Add(this.pnlUsuario);
            this.pnlMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuPrincipal.Name = "pnlMenuPrincipal";
            this.pnlMenuPrincipal.Size = new System.Drawing.Size(170, 664);
            this.pnlMenuPrincipal.TabIndex = 0;
            // 
            // pnlBotonesInfo
            // 
            this.pnlBotonesInfo.Controls.Add(this.btnCancelacionesPacientes);
            this.pnlBotonesInfo.Controls.Add(this.btnTotalImportes);
            this.pnlBotonesInfo.Controls.Add(this.btnInfoTurnosCancelados);
            this.pnlBotonesInfo.Controls.Add(this.btnInfoTurnosRealizados);
            this.pnlBotonesInfo.Location = new System.Drawing.Point(0, 366);
            this.pnlBotonesInfo.Name = "pnlBotonesInfo";
            this.pnlBotonesInfo.Size = new System.Drawing.Size(170, 237);
            this.pnlBotonesInfo.TabIndex = 0;
            this.pnlBotonesInfo.Visible = false;
            // 
            // btnCancelacionesPacientes
            // 
            this.btnCancelacionesPacientes.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCancelacionesPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancelacionesPacientes.FlatAppearance.BorderSize = 0;
            this.btnCancelacionesPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelacionesPacientes.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelacionesPacientes.ForeColor = System.Drawing.Color.White;
            this.btnCancelacionesPacientes.Location = new System.Drawing.Point(0, 180);
            this.btnCancelacionesPacientes.Name = "btnCancelacionesPacientes";
            this.btnCancelacionesPacientes.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCancelacionesPacientes.Size = new System.Drawing.Size(170, 60);
            this.btnCancelacionesPacientes.TabIndex = 11;
            this.btnCancelacionesPacientes.Text = "Cancelaciones Pacientes";
            this.btnCancelacionesPacientes.UseVisualStyleBackColor = false;
            this.btnCancelacionesPacientes.Click += new System.EventHandler(this.btnCancelacionesPacientes_Click);
            // 
            // btnTotalImportes
            // 
            this.btnTotalImportes.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTotalImportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTotalImportes.FlatAppearance.BorderSize = 0;
            this.btnTotalImportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalImportes.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalImportes.ForeColor = System.Drawing.Color.White;
            this.btnTotalImportes.Location = new System.Drawing.Point(0, 120);
            this.btnTotalImportes.Name = "btnTotalImportes";
            this.btnTotalImportes.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTotalImportes.Size = new System.Drawing.Size(170, 60);
            this.btnTotalImportes.TabIndex = 10;
            this.btnTotalImportes.Text = "Total Importes";
            this.btnTotalImportes.UseVisualStyleBackColor = false;
            this.btnTotalImportes.Click += new System.EventHandler(this.btnTotalImportes_Click);
            // 
            // btnInfoTurnosCancelados
            // 
            this.btnInfoTurnosCancelados.BackColor = System.Drawing.Color.CadetBlue;
            this.btnInfoTurnosCancelados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfoTurnosCancelados.FlatAppearance.BorderSize = 0;
            this.btnInfoTurnosCancelados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoTurnosCancelados.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoTurnosCancelados.ForeColor = System.Drawing.Color.White;
            this.btnInfoTurnosCancelados.Location = new System.Drawing.Point(0, 60);
            this.btnInfoTurnosCancelados.Name = "btnInfoTurnosCancelados";
            this.btnInfoTurnosCancelados.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnInfoTurnosCancelados.Size = new System.Drawing.Size(170, 60);
            this.btnInfoTurnosCancelados.TabIndex = 9;
            this.btnInfoTurnosCancelados.Text = "Turnos Cancelados";
            this.btnInfoTurnosCancelados.UseVisualStyleBackColor = false;
            this.btnInfoTurnosCancelados.Click += new System.EventHandler(this.btnInfoTurnosCancelados_Click_1);
            // 
            // btnInfoTurnosRealizados
            // 
            this.btnInfoTurnosRealizados.BackColor = System.Drawing.Color.CadetBlue;
            this.btnInfoTurnosRealizados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfoTurnosRealizados.FlatAppearance.BorderSize = 0;
            this.btnInfoTurnosRealizados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoTurnosRealizados.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoTurnosRealizados.ForeColor = System.Drawing.Color.White;
            this.btnInfoTurnosRealizados.Location = new System.Drawing.Point(0, 0);
            this.btnInfoTurnosRealizados.Name = "btnInfoTurnosRealizados";
            this.btnInfoTurnosRealizados.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnInfoTurnosRealizados.Size = new System.Drawing.Size(170, 60);
            this.btnInfoTurnosRealizados.TabIndex = 8;
            this.btnInfoTurnosRealizados.Text = "Turnos Realizados";
            this.btnInfoTurnosRealizados.UseVisualStyleBackColor = false;
            this.btnInfoTurnosRealizados.Click += new System.EventHandler(this.btnInfoTurnosRealizados_Click_1);
            // 
            // btnInfo
            // 
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Location = new System.Drawing.Point(0, 300);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnInfo.Size = new System.Drawing.Size(170, 60);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnTurnosHistoricos
            // 
            this.btnTurnosHistoricos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTurnosHistoricos.FlatAppearance.BorderSize = 0;
            this.btnTurnosHistoricos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurnosHistoricos.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnosHistoricos.ForeColor = System.Drawing.Color.White;
            this.btnTurnosHistoricos.Location = new System.Drawing.Point(0, 240);
            this.btnTurnosHistoricos.Name = "btnTurnosHistoricos";
            this.btnTurnosHistoricos.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTurnosHistoricos.Size = new System.Drawing.Size(170, 60);
            this.btnTurnosHistoricos.TabIndex = 3;
            this.btnTurnosHistoricos.Text = "Turnos Historicos";
            this.btnTurnosHistoricos.UseVisualStyleBackColor = true;
            this.btnTurnosHistoricos.Click += new System.EventHandler(this.btnTurnosHistoricos_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.ForeColor = System.Drawing.Color.White;
            this.btnPacientes.Location = new System.Drawing.Point(0, 180);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPacientes.Size = new System.Drawing.Size(170, 60);
            this.btnPacientes.TabIndex = 2;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnTurnos
            // 
            this.btnTurnos.BackColor = System.Drawing.Color.Teal;
            this.btnTurnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTurnos.FlatAppearance.BorderSize = 0;
            this.btnTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurnos.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnos.ForeColor = System.Drawing.Color.White;
            this.btnTurnos.Location = new System.Drawing.Point(0, 120);
            this.btnTurnos.Name = "btnTurnos";
            this.btnTurnos.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTurnos.Size = new System.Drawing.Size(170, 60);
            this.btnTurnos.TabIndex = 1;
            this.btnTurnos.Text = "Turnos";
            this.btnTurnos.UseVisualStyleBackColor = false;
            this.btnTurnos.Click += new System.EventHandler(this.btnTurnos_Click);
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlUsuario.Controls.Add(this.btnUsuario);
            this.pnlUsuario.Controls.Add(this.btnCerrarSesion);
            this.pnlUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsuario.Location = new System.Drawing.Point(0, 0);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(170, 120);
            this.pnlUsuario.TabIndex = 0;
            // 
            // btnUsuario
            // 
            this.btnUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUsuario.AutoSize = true;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Liberation Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Location = new System.Drawing.Point(0, 0);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(170, 77);
            this.btnUsuario.TabIndex = 2;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCerrarSesion.AutoSize = true;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 83);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(167, 34);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // pnlChildForms
            // 
            this.pnlChildForms.BackColor = System.Drawing.SystemColors.Control;
            this.pnlChildForms.Controls.Add(this.pnlTitulo);
            this.pnlChildForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForms.Location = new System.Drawing.Point(170, 0);
            this.pnlChildForms.Name = "pnlChildForms";
            this.pnlChildForms.Size = new System.Drawing.Size(937, 664);
            this.pnlChildForms.TabIndex = 1;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(937, 38);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Liberation Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(385, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(147, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Menu Principal";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1107, 664);
            this.Controls.Add(this.pnlChildForms);
            this.Controls.Add(this.pnlMenuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuPrincipal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.pnlMenuPrincipal.ResumeLayout(false);
            this.pnlBotonesInfo.ResumeLayout(false);
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            this.pnlChildForms.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuPrincipal;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnTurnosHistoricos;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnTurnos;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Panel pnlChildForms;
        private System.Windows.Forms.Panel pnlBotonesInfo;
        private System.Windows.Forms.Button btnInfoTurnosCancelados;
        private System.Windows.Forms.Button btnInfoTurnosRealizados;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnTotalImportes;
        private System.Windows.Forms.Button btnCancelacionesPacientes;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnUsuario;
    }
}