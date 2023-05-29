namespace AppConsultorio
{
    partial class frmInfoTurnosCancelados
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
            this.lblTotalTurnosCancelados = new System.Windows.Forms.Label();
            this.chartTurnosCancelados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTurnosCancelados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalTurnosCancelados
            // 
            this.lblTotalTurnosCancelados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalTurnosCancelados.AutoSize = true;
            this.lblTotalTurnosCancelados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTurnosCancelados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalTurnosCancelados.Location = new System.Drawing.Point(12, 433);
            this.lblTotalTurnosCancelados.Name = "lblTotalTurnosCancelados";
            this.lblTotalTurnosCancelados.Size = new System.Drawing.Size(190, 16);
            this.lblTotalTurnosCancelados.TabIndex = 6;
            this.lblTotalTurnosCancelados.Text = "Total Turnos Cancelados: ";
            // 
            // chartTurnosCancelados
            // 
            this.chartTurnosCancelados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartTurnosCancelados.BorderlineColor = System.Drawing.Color.Black;
            this.chartTurnosCancelados.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chartTurnosCancelados.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTurnosCancelados.Legends.Add(legend1);
            this.chartTurnosCancelados.Location = new System.Drawing.Point(12, 15);
            this.chartTurnosCancelados.Name = "chartTurnosCancelados";
            this.chartTurnosCancelados.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartTurnosCancelados.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Turnos Cancelados";
            this.chartTurnosCancelados.Series.Add(series1);
            this.chartTurnosCancelados.Size = new System.Drawing.Size(776, 404);
            this.chartTurnosCancelados.TabIndex = 5;
            // 
            // frmInfoTurnosCancelados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.lblTotalTurnosCancelados);
            this.Controls.Add(this.chartTurnosCancelados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInfoTurnosCancelados";
            this.Text = "Turnos Cancelados";
            this.Load += new System.EventHandler(this.frmInfoTurnosCancelados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTurnosCancelados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalTurnosCancelados;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTurnosCancelados;
    }
}