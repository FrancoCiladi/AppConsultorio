﻿namespace AppConsultorio
{
    partial class frmReporteTurnos
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
            this.rpvTurnos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvTurnos
            // 
            this.rpvTurnos.Location = new System.Drawing.Point(12, 12);
            this.rpvTurnos.Name = "rpvTurnos";
            this.rpvTurnos.ServerReport.BearerToken = null;
            this.rpvTurnos.Size = new System.Drawing.Size(1255, 578);
            this.rpvTurnos.TabIndex = 0;
            // 
            // frmReporteTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1279, 602);
            this.Controls.Add(this.rpvTurnos);
            this.Name = "frmReporteTurnos";
            this.Text = "Reporte Turnos";
            this.Load += new System.EventHandler(this.frmReporteTurnos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvTurnos;
    }
}