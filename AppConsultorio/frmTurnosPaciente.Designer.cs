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
            this.dgvTurnosPaciente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTurnosPaciente
            // 
            this.dgvTurnosPaciente.AllowUserToAddRows = false;
            this.dgvTurnosPaciente.AllowUserToDeleteRows = false;
            this.dgvTurnosPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnosPaciente.Location = new System.Drawing.Point(13, 13);
            this.dgvTurnosPaciente.Name = "dgvTurnosPaciente";
            this.dgvTurnosPaciente.Size = new System.Drawing.Size(561, 276);
            this.dgvTurnosPaciente.TabIndex = 0;
            this.dgvTurnosPaciente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurnosPaciente_CellDoubleClick);
            // 
            // frmTurnosPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 306);
            this.Controls.Add(this.dgvTurnosPaciente);
            this.Name = "frmTurnosPaciente";
            this.Text = "Turnos Paciente";
            this.Load += new System.EventHandler(this.frmTurnosPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosPaciente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTurnosPaciente;
    }
}