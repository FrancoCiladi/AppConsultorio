namespace AppConsultorio
{
    partial class frmReporteCancelaciones
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
            this.rpvCancelaciones = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvCancelaciones
            // 
            this.rpvCancelaciones.Location = new System.Drawing.Point(12, 12);
            this.rpvCancelaciones.Name = "rpvCancelaciones";
            this.rpvCancelaciones.ServerReport.BearerToken = null;
            this.rpvCancelaciones.Size = new System.Drawing.Size(1413, 577);
            this.rpvCancelaciones.TabIndex = 0;
            // 
            // frmReporteCancelaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1437, 601);
            this.Controls.Add(this.rpvCancelaciones);
            this.Name = "frmReporteCancelaciones";
            this.Text = "Reporte Cancelaciones";
            this.Load += new System.EventHandler(this.frmReporteCancelaciones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvCancelaciones;
    }
}