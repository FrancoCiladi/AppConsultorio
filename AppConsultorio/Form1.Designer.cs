namespace AppConsultorio
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblConstraseña = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblNuevoUsuario = new System.Windows.Forms.LinkLabel();
            this.txtRepetirContraseña = new System.Windows.Forms.TextBox();
            this.lblRepetirContraseña = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(82, 94);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(76, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblConstraseña
            // 
            this.lblConstraseña.AutoSize = true;
            this.lblConstraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConstraseña.Location = new System.Drawing.Point(51, 131);
            this.lblConstraseña.Name = "lblConstraseña";
            this.lblConstraseña.Size = new System.Drawing.Size(107, 20);
            this.lblConstraseña.TabIndex = 1;
            this.lblConstraseña.Text = "Contraseña:";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(164, 216);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 36);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(164, 96);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(178, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(164, 133);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(178, 20);
            this.txtContraseña.TabIndex = 4;
            // 
            // lblNuevoUsuario
            // 
            this.lblNuevoUsuario.AutoSize = true;
            this.lblNuevoUsuario.Location = new System.Drawing.Point(325, 293);
            this.lblNuevoUsuario.Name = "lblNuevoUsuario";
            this.lblNuevoUsuario.Size = new System.Drawing.Size(84, 13);
            this.lblNuevoUsuario.TabIndex = 5;
            this.lblNuevoUsuario.TabStop = true;
            this.lblNuevoUsuario.Text = "Nuevo Usuario?";
            this.lblNuevoUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNuevoUsuario_LinkClicked);
            // 
            // txtRepetirContraseña
            // 
            this.txtRepetirContraseña.Location = new System.Drawing.Point(164, 172);
            this.txtRepetirContraseña.Name = "txtRepetirContraseña";
            this.txtRepetirContraseña.PasswordChar = '*';
            this.txtRepetirContraseña.Size = new System.Drawing.Size(178, 20);
            this.txtRepetirContraseña.TabIndex = 7;
            this.txtRepetirContraseña.Visible = false;
            // 
            // lblRepetirContraseña
            // 
            this.lblRepetirContraseña.AutoSize = true;
            this.lblRepetirContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepetirContraseña.Location = new System.Drawing.Point(12, 172);
            this.lblRepetirContraseña.Name = "lblRepetirContraseña";
            this.lblRepetirContraseña.Size = new System.Drawing.Size(145, 16);
            this.lblRepetirContraseña.TabIndex = 6;
            this.lblRepetirContraseña.Text = "Repetir Contraseña:";
            this.lblRepetirContraseña.Visible = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(289, 216);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(94, 36);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Visible = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "LOGO";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 315);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtRepetirContraseña);
            this.Controls.Add(this.lblRepetirContraseña);
            this.Controls.Add(this.lblNuevoUsuario);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblConstraseña);
            this.Controls.Add(this.lblUsuario);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblConstraseña;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.LinkLabel lblNuevoUsuario;
        private System.Windows.Forms.TextBox txtRepetirContraseña;
        private System.Windows.Forms.Label lblRepetirContraseña;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label1;
    }
}

