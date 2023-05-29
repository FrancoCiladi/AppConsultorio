namespace AppConsultorio
{
    partial class frmMenu
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnTurnos = new System.Windows.Forms.Button();
            this.btnTurnosHistoricos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(129, 307);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 63);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.Location = new System.Drawing.Point(34, 51);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(124, 63);
            this.btnPacientes.TabIndex = 1;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnTurnos
            // 
            this.btnTurnos.Location = new System.Drawing.Point(214, 51);
            this.btnTurnos.Name = "btnTurnos";
            this.btnTurnos.Size = new System.Drawing.Size(124, 63);
            this.btnTurnos.TabIndex = 2;
            this.btnTurnos.Text = "Turnos";
            this.btnTurnos.UseVisualStyleBackColor = true;
            this.btnTurnos.Click += new System.EventHandler(this.btnTurnos_Click);
            // 
            // btnTurnosHistoricos
            // 
            this.btnTurnosHistoricos.Location = new System.Drawing.Point(34, 193);
            this.btnTurnosHistoricos.Name = "btnTurnosHistoricos";
            this.btnTurnosHistoricos.Size = new System.Drawing.Size(124, 63);
            this.btnTurnosHistoricos.TabIndex = 3;
            this.btnTurnosHistoricos.Text = "Turnos Historicos";
            this.btnTurnosHistoricos.UseVisualStyleBackColor = true;
            this.btnTurnosHistoricos.Click += new System.EventHandler(this.btnTurnosHistoricos_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 414);
            this.Controls.Add(this.btnTurnosHistoricos);
            this.Controls.Add(this.btnTurnos);
            this.Controls.Add(this.btnPacientes);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnTurnos;
        private System.Windows.Forms.Button btnTurnosHistoricos;
    }
}