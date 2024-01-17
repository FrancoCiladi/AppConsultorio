namespace AppConsultorio
{
    partial class frmInfoImportes
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
            this.lblTotalRecaudado = new System.Windows.Forms.Label();
            this.chartRecaudado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbxAño = new System.Windows.Forms.ComboBox();
            this.lblAño = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartRecaudado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalRecaudado
            // 
            this.lblTotalRecaudado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalRecaudado.AutoSize = true;
            this.lblTotalRecaudado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecaudado.ForeColor = System.Drawing.Color.White;
            this.lblTotalRecaudado.Location = new System.Drawing.Point(9, 433);
            this.lblTotalRecaudado.Name = "lblTotalRecaudado";
            this.lblTotalRecaudado.Size = new System.Drawing.Size(136, 16);
            this.lblTotalRecaudado.TabIndex = 7;
            this.lblTotalRecaudado.Text = "Total Recaudado: ";
            // 
            // chartRecaudado
            // 
            this.chartRecaudado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartRecaudado.BorderlineColor = System.Drawing.Color.Black;
            this.chartRecaudado.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.chartRecaudado.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartRecaudado.Legends.Add(legend2);
            this.chartRecaudado.Location = new System.Drawing.Point(10, 38);
            this.chartRecaudado.Name = "chartRecaudado";
            this.chartRecaudado.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Total Recaudado";
            this.chartRecaudado.Series.Add(series2);
            this.chartRecaudado.Size = new System.Drawing.Size(778, 378);
            this.chartRecaudado.TabIndex = 6;
            // 
            // cbxAño
            // 
            this.cbxAño.FormattingEnabled = true;
            this.cbxAño.Location = new System.Drawing.Point(58, 11);
            this.cbxAño.Name = "cbxAño";
            this.cbxAño.Size = new System.Drawing.Size(78, 21);
            this.cbxAño.TabIndex = 11;
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
            this.lblAño.TabIndex = 10;
            this.lblAño.Text = "Año: ";
            // 
            // frmInfoImportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.cbxAño);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblTotalRecaudado);
            this.Controls.Add(this.chartRecaudado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInfoImportes";
            this.Text = "Total Importes";
            this.Load += new System.EventHandler(this.frmInfoImportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartRecaudado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalRecaudado;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRecaudado;
        private System.Windows.Forms.ComboBox cbxAño;
        private System.Windows.Forms.Label lblAño;
    }
}