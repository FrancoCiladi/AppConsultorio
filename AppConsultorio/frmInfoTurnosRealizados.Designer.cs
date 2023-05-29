namespace AppConsultorio
{
    partial class frmInfoTurnosRealizados
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTotalTurnosRealizados = new System.Windows.Forms.Label();
            this.chartTurnosRealizados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTurnosRealizados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalTurnosRealizados
            // 
            this.lblTotalTurnosRealizados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalTurnosRealizados.AutoSize = true;
            this.lblTotalTurnosRealizados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTurnosRealizados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalTurnosRealizados.Location = new System.Drawing.Point(12, 420);
            this.lblTotalTurnosRealizados.Name = "lblTotalTurnosRealizados";
            this.lblTotalTurnosRealizados.Size = new System.Drawing.Size(186, 16);
            this.lblTotalTurnosRealizados.TabIndex = 5;
            this.lblTotalTurnosRealizados.Text = "Total Turnos Realizados: ";
            // 
            // chartTurnosRealizados
            // 
            this.chartTurnosRealizados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartTurnosRealizados.BorderlineColor = System.Drawing.Color.Black;
            this.chartTurnosRealizados.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chartTurnosRealizados.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTurnosRealizados.Legends.Add(legend1);
            this.chartTurnosRealizados.Location = new System.Drawing.Point(12, 12);
            this.chartTurnosRealizados.Name = "chartTurnosRealizados";
            this.chartTurnosRealizados.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Turnos Realizados";
            this.chartTurnosRealizados.Series.Add(series1);
            this.chartTurnosRealizados.Size = new System.Drawing.Size(695, 392);
            this.chartTurnosRealizados.TabIndex = 4;
            // 
            // frmInfoTurnosRealizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(719, 454);
            this.Controls.Add(this.lblTotalTurnosRealizados);
            this.Controls.Add(this.chartTurnosRealizados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInfoTurnosRealizados";
            this.Text = "Turnos Realizados";
            this.Load += new System.EventHandler(this.frmInfoTurnosRealizados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTurnosRealizados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalTurnosRealizados;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTurnosRealizados;
    }
}