namespace AppConsultorio
{
    partial class frmInfoTurno
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
            this.btnCancelarTurno = new System.Windows.Forms.Button();
            this.btnObservaciones = new System.Windows.Forms.Button();
            this.btnImporte = new System.Windows.Forms.Button();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblPacienteComp = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblTelefonoCompleto = new System.Windows.Forms.Label();
            this.lblObraSocial = new System.Windows.Forms.Label();
            this.lblObraSocialComp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelarTurno
            // 
            this.btnCancelarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarTurno.Location = new System.Drawing.Point(354, 13);
            this.btnCancelarTurno.Name = "btnCancelarTurno";
            this.btnCancelarTurno.Size = new System.Drawing.Size(100, 51);
            this.btnCancelarTurno.TabIndex = 0;
            this.btnCancelarTurno.Text = "Cancelar Turno";
            this.btnCancelarTurno.UseVisualStyleBackColor = true;
            this.btnCancelarTurno.Click += new System.EventHandler(this.btnCancelarTurno_Click);
            // 
            // btnObservaciones
            // 
            this.btnObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObservaciones.Location = new System.Drawing.Point(354, 89);
            this.btnObservaciones.Name = "btnObservaciones";
            this.btnObservaciones.Size = new System.Drawing.Size(100, 51);
            this.btnObservaciones.TabIndex = 1;
            this.btnObservaciones.Text = "Observaciones";
            this.btnObservaciones.UseVisualStyleBackColor = true;
            this.btnObservaciones.Click += new System.EventHandler(this.btnObservaciones_Click);
            // 
            // btnImporte
            // 
            this.btnImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImporte.Location = new System.Drawing.Point(354, 163);
            this.btnImporte.Name = "btnImporte";
            this.btnImporte.Size = new System.Drawing.Size(100, 51);
            this.btnImporte.TabIndex = 2;
            this.btnImporte.Text = "Modificar Importe";
            this.btnImporte.UseVisualStyleBackColor = true;
            this.btnImporte.Click += new System.EventHandler(this.btnImporte_Click);
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPaciente.Location = new System.Drawing.Point(22, 28);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(84, 20);
            this.lblPaciente.TabIndex = 3;
            this.lblPaciente.Text = "Paciente:";
            // 
            // lblPacienteComp
            // 
            this.lblPacienteComp.AutoSize = true;
            this.lblPacienteComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacienteComp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPacienteComp.Location = new System.Drawing.Point(112, 28);
            this.lblPacienteComp.Name = "lblPacienteComp";
            this.lblPacienteComp.Size = new System.Drawing.Size(141, 20);
            this.lblPacienteComp.TabIndex = 4;
            this.lblPacienteComp.Text = "NombrePaciente";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTelefono.Location = new System.Drawing.Point(22, 104);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(89, 20);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Telefono: ";
            // 
            // lblTelefonoCompleto
            // 
            this.lblTelefonoCompleto.AutoSize = true;
            this.lblTelefonoCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoCompleto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTelefonoCompleto.Location = new System.Drawing.Point(112, 104);
            this.lblTelefonoCompleto.Name = "lblTelefonoCompleto";
            this.lblTelefonoCompleto.Size = new System.Drawing.Size(155, 20);
            this.lblTelefonoCompleto.TabIndex = 6;
            this.lblTelefonoCompleto.Text = "TelefonoCompleto";
            // 
            // lblObraSocial
            // 
            this.lblObraSocial.AutoSize = true;
            this.lblObraSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObraSocial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblObraSocial.Location = new System.Drawing.Point(21, 178);
            this.lblObraSocial.Name = "lblObraSocial";
            this.lblObraSocial.Size = new System.Drawing.Size(107, 20);
            this.lblObraSocial.TabIndex = 7;
            this.lblObraSocial.Text = "Obra Social:";
            // 
            // lblObraSocialComp
            // 
            this.lblObraSocialComp.AutoSize = true;
            this.lblObraSocialComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObraSocialComp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblObraSocialComp.Location = new System.Drawing.Point(134, 178);
            this.lblObraSocialComp.Name = "lblObraSocialComp";
            this.lblObraSocialComp.Size = new System.Drawing.Size(143, 20);
            this.lblObraSocialComp.TabIndex = 8;
            this.lblObraSocialComp.Text = "ObraSocialComp";
            // 
            // frmInfoTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(468, 235);
            this.Controls.Add(this.lblObraSocialComp);
            this.Controls.Add(this.lblObraSocial);
            this.Controls.Add(this.lblTelefonoCompleto);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblPacienteComp);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.btnImporte);
            this.Controls.Add(this.btnObservaciones);
            this.Controls.Add(this.btnCancelarTurno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmInfoTurno";
            this.Load += new System.EventHandler(this.frmInfoTurno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarTurno;
        private System.Windows.Forms.Button btnObservaciones;
        private System.Windows.Forms.Button btnImporte;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblPacienteComp;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblTelefonoCompleto;
        private System.Windows.Forms.Label lblObraSocial;
        private System.Windows.Forms.Label lblObraSocialComp;
    }
}