namespace AppConsultorio
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.tctrlUsuario = new System.Windows.Forms.TabControl();
            this.tbpgModificarUsuario = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tbpgResetearClave = new System.Windows.Forms.TabPage();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtRepetirContraseña = new System.Windows.Forms.TextBox();
            this.txtNuevaContraseña = new System.Windows.Forms.TextBox();
            this.txtContraseñaActual = new System.Windows.Forms.TextBox();
            this.lblRepetirContraseña = new System.Windows.Forms.Label();
            this.lblNuevaContraseña = new System.Windows.Forms.Label();
            this.lblContraseñaActual = new System.Windows.Forms.Label();
            this.tctrlUsuario.SuspendLayout();
            this.tbpgModificarUsuario.SuspendLayout();
            this.tbpgResetearClave.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctrlUsuario
            // 
            this.tctrlUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tctrlUsuario.Controls.Add(this.tbpgModificarUsuario);
            this.tctrlUsuario.Controls.Add(this.tbpgResetearClave);
            this.tctrlUsuario.Location = new System.Drawing.Point(13, 9);
            this.tctrlUsuario.Name = "tctrlUsuario";
            this.tctrlUsuario.SelectedIndex = 0;
            this.tctrlUsuario.Size = new System.Drawing.Size(323, 288);
            this.tctrlUsuario.TabIndex = 0;
            // 
            // tbpgModificarUsuario
            // 
            this.tbpgModificarUsuario.BackColor = System.Drawing.Color.Teal;
            this.tbpgModificarUsuario.Controls.Add(this.button1);
            this.tbpgModificarUsuario.Controls.Add(this.txtUsuario);
            this.tbpgModificarUsuario.Controls.Add(this.txtNombre);
            this.tbpgModificarUsuario.Controls.Add(this.txtApellido);
            this.tbpgModificarUsuario.Controls.Add(this.lblUsuario);
            this.tbpgModificarUsuario.Controls.Add(this.lblNombre);
            this.tbpgModificarUsuario.Controls.Add(this.lblApellido);
            this.tbpgModificarUsuario.Location = new System.Drawing.Point(4, 22);
            this.tbpgModificarUsuario.Name = "tbpgModificarUsuario";
            this.tbpgModificarUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgModificarUsuario.Size = new System.Drawing.Size(315, 262);
            this.tbpgModificarUsuario.TabIndex = 0;
            this.tbpgModificarUsuario.Text = "Modificar Usuario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 50);
            this.button1.TabIndex = 18;
            this.button1.Text = "Guardar Cambios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(145, 108);
            this.txtUsuario.MaxLength = 30;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(139, 20);
            this.txtUsuario.TabIndex = 16;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(145, 67);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(139, 20);
            this.txtNombre.TabIndex = 15;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(145, 24);
            this.txtApellido.MaxLength = 30;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(139, 20);
            this.txtApellido.TabIndex = 14;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(30, 108);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(65, 16);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(30, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 16);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(30, 25);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(69, 16);
            this.lblApellido.TabIndex = 10;
            this.lblApellido.Text = "Apellido:";
            // 
            // tbpgResetearClave
            // 
            this.tbpgResetearClave.BackColor = System.Drawing.Color.Teal;
            this.tbpgResetearClave.Controls.Add(this.btnGuardar);
            this.tbpgResetearClave.Controls.Add(this.txtRepetirContraseña);
            this.tbpgResetearClave.Controls.Add(this.txtNuevaContraseña);
            this.tbpgResetearClave.Controls.Add(this.txtContraseñaActual);
            this.tbpgResetearClave.Controls.Add(this.lblRepetirContraseña);
            this.tbpgResetearClave.Controls.Add(this.lblNuevaContraseña);
            this.tbpgResetearClave.Controls.Add(this.lblContraseñaActual);
            this.tbpgResetearClave.Location = new System.Drawing.Point(4, 22);
            this.tbpgResetearClave.Name = "tbpgResetearClave";
            this.tbpgResetearClave.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgResetearClave.Size = new System.Drawing.Size(315, 262);
            this.tbpgResetearClave.TabIndex = 1;
            this.tbpgResetearClave.Text = "Resetear Clave";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(119, 205);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(79, 30);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtRepetirContraseña
            // 
            this.txtRepetirContraseña.Location = new System.Drawing.Point(71, 164);
            this.txtRepetirContraseña.Name = "txtRepetirContraseña";
            this.txtRepetirContraseña.Size = new System.Drawing.Size(187, 20);
            this.txtRepetirContraseña.TabIndex = 5;
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.Location = new System.Drawing.Point(71, 104);
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.Size = new System.Drawing.Size(187, 20);
            this.txtNuevaContraseña.TabIndex = 4;
            // 
            // txtContraseñaActual
            // 
            this.txtContraseñaActual.Location = new System.Drawing.Point(71, 45);
            this.txtContraseñaActual.Name = "txtContraseñaActual";
            this.txtContraseñaActual.Size = new System.Drawing.Size(187, 20);
            this.txtContraseñaActual.TabIndex = 3;
            // 
            // lblRepetirContraseña
            // 
            this.lblRepetirContraseña.AutoSize = true;
            this.lblRepetirContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepetirContraseña.ForeColor = System.Drawing.Color.White;
            this.lblRepetirContraseña.Location = new System.Drawing.Point(67, 141);
            this.lblRepetirContraseña.Name = "lblRepetirContraseña";
            this.lblRepetirContraseña.Size = new System.Drawing.Size(176, 20);
            this.lblRepetirContraseña.TabIndex = 2;
            this.lblRepetirContraseña.Text = "Repetir Contraseña: ";
            // 
            // lblNuevaContraseña
            // 
            this.lblNuevaContraseña.AutoSize = true;
            this.lblNuevaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaContraseña.ForeColor = System.Drawing.Color.White;
            this.lblNuevaContraseña.Location = new System.Drawing.Point(67, 81);
            this.lblNuevaContraseña.Name = "lblNuevaContraseña";
            this.lblNuevaContraseña.Size = new System.Drawing.Size(167, 20);
            this.lblNuevaContraseña.TabIndex = 1;
            this.lblNuevaContraseña.Text = "Nueva Contraseña: ";
            // 
            // lblContraseñaActual
            // 
            this.lblContraseñaActual.AutoSize = true;
            this.lblContraseñaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaActual.ForeColor = System.Drawing.Color.White;
            this.lblContraseñaActual.Location = new System.Drawing.Point(66, 22);
            this.lblContraseñaActual.Name = "lblContraseñaActual";
            this.lblContraseñaActual.Size = new System.Drawing.Size(168, 20);
            this.lblContraseñaActual.TabIndex = 0;
            this.lblContraseñaActual.Text = "Contraseña Actual: ";
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(348, 309);
            this.Controls.Add(this.tctrlUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.tctrlUsuario.ResumeLayout(false);
            this.tbpgModificarUsuario.ResumeLayout(false);
            this.tbpgModificarUsuario.PerformLayout();
            this.tbpgResetearClave.ResumeLayout(false);
            this.tbpgResetearClave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tctrlUsuario;
        private System.Windows.Forms.TabPage tbpgModificarUsuario;
        private System.Windows.Forms.TabPage tbpgResetearClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtRepetirContraseña;
        private System.Windows.Forms.TextBox txtNuevaContraseña;
        private System.Windows.Forms.TextBox txtContraseñaActual;
        private System.Windows.Forms.Label lblRepetirContraseña;
        private System.Windows.Forms.Label lblNuevaContraseña;
        private System.Windows.Forms.Label lblContraseñaActual;
    }
}