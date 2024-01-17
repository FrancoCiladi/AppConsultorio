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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTotalTurnosCancelados = new System.Windows.Forms.Label();
            this.chartTurnosCancelados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbxAño = new System.Windows.Forms.ComboBox();
            this.lblAño = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartTurnosCancelados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalTurnosCancelados
            // 
            this.lblTotalTurnosCancelados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalTurnosCancelados.AutoSize = true;
            this.lblTotalTurnosCancelados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTurnosCancelados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalTurnosCancelados.Location = new System.Drawing.Point(12, 483);
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
            chartArea2.Name = "ChartArea1";
            this.chartTurnosCancelados.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTurnosCancelados.Legends.Add(legend2);
            this.chartTurnosCancelados.Location = new System.Drawing.Point(12, 38);
            this.chartTurnosCancelados.Name = "chartTurnosCancelados";
            this.chartTurnosCancelados.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartTurnosCancelados.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Turnos Cancelados";
            this.chartTurnosCancelados.Series.Add(series2);
            this.chartTurnosCancelados.Size = new System.Drawing.Size(776, 431);
            this.chartTurnosCancelados.TabIndex = 5;
            // 
            // cbxAño
            // 
            this.cbxAño.FormattingEnabled = true;
            this.cbxAño.Location = new System.Drawing.Point(58, 11);
            this.cbxAño.Name = "cbxAño";
            this.cbxAño.Size = new System.Drawing.Size(78, 21);
            this.cbxAño.TabIndex = 9;
            this.cbxAño.SelectedIndexChanged += new System.EventHandler(this.cbxAño_SelectedIndexChanged);
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAño.Location = new System.Drawing.Point(12, 9);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(51, 20);
            this.lblAño.TabIndex = 8;
            this.lblAño.Text = "Año: ";
            // 
            // frmInfoTurnosCancelados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.cbxAño);
            this.Controls.Add(this.lblAño);
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
        private System.Windows.Forms.ComboBox cbxAño;
        private System.Windows.Forms.Label lblAño;
    }
}