namespace AppConsultorio
{
    partial class frmRecuperarClave
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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.cbxPreguntasSeguridad = new System.Windows.Forms.ComboBox();
            this.lblPreguntaSeguridad = new System.Windows.Forms.Label();
            this.txtRespuestaSeguridad = new System.Windows.Forms.TextBox();
            this.lblRespuestaSeguridad = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnlSecundario = new System.Windows.Forms.Panel();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.txtRepetirContraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNuevaContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPrincipal.SuspendLayout();
            this.pnlSecundario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.btnVerificar);
            this.pnlPrincipal.Controls.Add(this.cbxPreguntasSeguridad);
            this.pnlPrincipal.Controls.Add(this.lblPreguntaSeguridad);
            this.pnlPrincipal.Controls.Add(this.txtRespuestaSeguridad);
            this.pnlPrincipal.Controls.Add(this.lblRespuestaSeguridad);
            this.pnlPrincipal.Controls.Add(this.txtUsuario);
            this.pnlPrincipal.Controls.Add(this.lblUsuario);
            this.pnlPrincipal.Location = new System.Drawing.Point(39, 12);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(411, 234);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(174, 184);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(85, 35);
            this.btnVerificar.TabIndex = 6;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // cbxPreguntasSeguridad
            // 
            this.cbxPreguntasSeguridad.FormattingEnabled = true;
            this.cbxPreguntasSeguridad.Location = new System.Drawing.Point(222, 78);
            this.cbxPreguntasSeguridad.Name = "cbxPreguntasSeguridad";
            this.cbxPreguntasSeguridad.Size = new System.Drawing.Size(161, 21);
            this.cbxPreguntasSeguridad.TabIndex = 5;
            // 
            // lblPreguntaSeguridad
            // 
            this.lblPreguntaSeguridad.AutoSize = true;
            this.lblPreguntaSeguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreguntaSeguridad.ForeColor = System.Drawing.Color.White;
            this.lblPreguntaSeguridad.Location = new System.Drawing.Point(15, 76);
            this.lblPreguntaSeguridad.Name = "lblPreguntaSeguridad";
            this.lblPreguntaSeguridad.Size = new System.Drawing.Size(201, 20);
            this.lblPreguntaSeguridad.TabIndex = 4;
            this.lblPreguntaSeguridad.Text = "Pregunta de seguridad: ";
            // 
            // txtRespuestaSeguridad
            // 
            this.txtRespuestaSeguridad.Location = new System.Drawing.Point(222, 127);
            this.txtRespuestaSeguridad.MaxLength = 50;
            this.txtRespuestaSeguridad.Name = "txtRespuestaSeguridad";
            this.txtRespuestaSeguridad.Size = new System.Drawing.Size(161, 20);
            this.txtRespuestaSeguridad.TabIndex = 3;
            // 
            // lblRespuestaSeguridad
            // 
            this.lblRespuestaSeguridad.AutoSize = true;
            this.lblRespuestaSeguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuestaSeguridad.ForeColor = System.Drawing.Color.White;
            this.lblRespuestaSeguridad.Location = new System.Drawing.Point(6, 125);
            this.lblRespuestaSeguridad.Name = "lblRespuestaSeguridad";
            this.lblRespuestaSeguridad.Size = new System.Drawing.Size(210, 20);
            this.lblRespuestaSeguridad.TabIndex = 2;
            this.lblRespuestaSeguridad.Text = "Respuesta de seguridad:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(150, 31);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(233, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(68, 29);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(76, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // pnlSecundario
            // 
            this.pnlSecundario.Controls.Add(this.btnGuardarCambios);
            this.pnlSecundario.Controls.Add(this.txtRepetirContraseña);
            this.pnlSecundario.Controls.Add(this.label2);
            this.pnlSecundario.Controls.Add(this.txtNuevaContraseña);
            this.pnlSecundario.Controls.Add(this.label1);
            this.pnlSecundario.Location = new System.Drawing.Point(12, 252);
            this.pnlSecundario.Name = "pnlSecundario";
            this.pnlSecundario.Size = new System.Drawing.Size(465, 194);
            this.pnlSecundario.TabIndex = 1;
            this.pnlSecundario.Visible = false;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.Location = new System.Drawing.Point(186, 125);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(98, 52);
            this.btnGuardarCambios.TabIndex = 8;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // txtRepetirContraseña
            // 
            this.txtRepetirContraseña.Location = new System.Drawing.Point(209, 87);
            this.txtRepetirContraseña.MaxLength = 50;
            this.txtRepetirContraseña.Name = "txtRepetirContraseña";
            this.txtRepetirContraseña.PasswordChar = '*';
            this.txtRepetirContraseña.Size = new System.Drawing.Size(228, 20);
            this.txtRepetirContraseña.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Repetir Contraseña: ";
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.Location = new System.Drawing.Point(209, 34);
            this.txtNuevaContraseña.MaxLength = 50;
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.PasswordChar = '*';
            this.txtNuevaContraseña.Size = new System.Drawing.Size(228, 20);
            this.txtNuevaContraseña.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nueva Contraseña: ";
            // 
            // frmRecuperarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(488, 459);
            this.Controls.Add(this.pnlSecundario);
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "frmRecuperarClave";
            this.ShowIcon = false;
            this.Text = "Recuperar Clave";
            this.Load += new System.EventHandler(this.frmRecuperarClave_Load);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlSecundario.ResumeLayout(false);
            this.pnlSecundario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.ComboBox cbxPreguntasSeguridad;
        private System.Windows.Forms.Label lblPreguntaSeguridad;
        private System.Windows.Forms.TextBox txtRespuestaSeguridad;
        private System.Windows.Forms.Label lblRespuestaSeguridad;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Panel pnlSecundario;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.TextBox txtRepetirContraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNuevaContraseña;
        private System.Windows.Forms.Label label1;
    }
}