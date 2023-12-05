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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblConstraseña = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblNuevoUsuario = new System.Windows.Forms.LinkLabel();
            this.lblOlvideContraseña = new System.Windows.Forms.LinkLabel();
            this.txtCodigoVerificacion = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lnkNuevoCodigo = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.Location = new System.Drawing.Point(99, 39);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(76, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblConstraseña
            // 
            this.lblConstraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConstraseña.AutoSize = true;
            this.lblConstraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConstraseña.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblConstraseña.Location = new System.Drawing.Point(68, 76);
            this.lblConstraseña.Name = "lblConstraseña";
            this.lblConstraseña.Size = new System.Drawing.Size(107, 20);
            this.lblConstraseña.TabIndex = 1;
            this.lblConstraseña.Text = "Contraseña:";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(181, 165);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 36);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Location = new System.Drawing.Point(181, 41);
            this.txtUsuario.MaxLength = 30;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(178, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContraseña.Location = new System.Drawing.Point(181, 78);
            this.txtContraseña.MaxLength = 30;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(178, 20);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContraseña_KeyDown);
            // 
            // lblNuevoUsuario
            // 
            this.lblNuevoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNuevoUsuario.AutoSize = true;
            this.lblNuevoUsuario.Location = new System.Drawing.Point(345, 224);
            this.lblNuevoUsuario.Name = "lblNuevoUsuario";
            this.lblNuevoUsuario.Size = new System.Drawing.Size(84, 13);
            this.lblNuevoUsuario.TabIndex = 3;
            this.lblNuevoUsuario.TabStop = true;
            this.lblNuevoUsuario.Text = "Nuevo Usuario?";
            this.lblNuevoUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNuevoUsuario_LinkClicked);
            // 
            // lblOlvideContraseña
            // 
            this.lblOlvideContraseña.AutoSize = true;
            this.lblOlvideContraseña.Location = new System.Drawing.Point(231, 224);
            this.lblOlvideContraseña.Name = "lblOlvideContraseña";
            this.lblOlvideContraseña.Size = new System.Drawing.Size(108, 13);
            this.lblOlvideContraseña.TabIndex = 10;
            this.lblOlvideContraseña.TabStop = true;
            this.lblOlvideContraseña.Text = "Olvide Mi Contraseña";
            this.lblOlvideContraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblOlvideContraseña_LinkClicked);
            // 
            // txtCodigoVerificacion
            // 
            this.txtCodigoVerificacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigoVerificacion.Location = new System.Drawing.Point(181, 114);
            this.txtCodigoVerificacion.MaxLength = 6;
            this.txtCodigoVerificacion.Name = "txtCodigoVerificacion";
            this.txtCodigoVerificacion.PasswordChar = '*';
            this.txtCodigoVerificacion.Size = new System.Drawing.Size(178, 20);
            this.txtCodigoVerificacion.TabIndex = 11;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodigo.Location = new System.Drawing.Point(6, 114);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(169, 20);
            this.lblCodigo.TabIndex = 12;
            this.lblCodigo.Text = "Codigo Verificación:";
            // 
            // lnkNuevoCodigo
            // 
            this.lnkNuevoCodigo.AutoSize = true;
            this.lnkNuevoCodigo.Location = new System.Drawing.Point(12, 224);
            this.lnkNuevoCodigo.Name = "lnkNuevoCodigo";
            this.lnkNuevoCodigo.Size = new System.Drawing.Size(75, 13);
            this.lnkNuevoCodigo.TabIndex = 13;
            this.lnkNuevoCodigo.TabStop = true;
            this.lnkNuevoCodigo.Text = "Nuevo Codigo";
            this.lnkNuevoCodigo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNuevoCodigo_LinkClicked);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(441, 256);
            this.Controls.Add(this.lnkNuevoCodigo);
            this.Controls.Add(this.txtCodigoVerificacion);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblOlvideContraseña);
            this.Controls.Add(this.lblNuevoUsuario);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblConstraseña);
            this.Controls.Add(this.lblUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.LinkLabel lblOlvideContraseña;
        private System.Windows.Forms.TextBox txtCodigoVerificacion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.LinkLabel lnkNuevoCodigo;
    }
}

