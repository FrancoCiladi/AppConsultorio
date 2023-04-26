namespace AppConsultorio
{
    partial class frmDetalleTurno
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
            this.richprueba = new System.Windows.Forms.RichTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richprueba
            // 
            this.richprueba.Location = new System.Drawing.Point(12, 12);
            this.richprueba.Name = "richprueba";
            this.richprueba.Size = new System.Drawing.Size(620, 490);
            this.richprueba.TabIndex = 0;
            this.richprueba.Text = "";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(263, 521);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 31);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // frmDetalleTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 564);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.richprueba);
            this.Name = "frmDetalleTurno";
            this.Text = "Detalle Turno";
            this.Load += new System.EventHandler(this.frmDetalleTurno_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richprueba;
        private System.Windows.Forms.Button btnGuardar;
    }
}