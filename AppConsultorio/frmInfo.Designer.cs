namespace AppConsultorio
{
    partial class frmInfo
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartTurnosRealizados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTurnosCancelados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartRecaudado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTotalTurnosRealizados = new System.Windows.Forms.Label();
            this.lblTotalTurnosCancelados = new System.Windows.Forms.Label();
            this.lblTotalRecaudado = new System.Windows.Forms.Label();
            this.mnuInfo = new System.Windows.Forms.MenuStrip();
            this.cancelacionesPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chartTurnosRealizados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTurnosCancelados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRecaudado)).BeginInit();
            this.mnuInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartTurnosRealizados
            // 
            this.chartTurnosRealizados.BorderlineColor = System.Drawing.Color.Black;
            this.chartTurnosRealizados.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.Name = "ChartArea1";
            this.chartTurnosRealizados.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartTurnosRealizados.Legends.Add(legend4);
            this.chartTurnosRealizados.Location = new System.Drawing.Point(12, 27);
            this.chartTurnosRealizados.Name = "chartTurnosRealizados";
            this.chartTurnosRealizados.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Turnos Realizados";
            this.chartTurnosRealizados.Series.Add(series4);
            this.chartTurnosRealizados.Size = new System.Drawing.Size(695, 404);
            this.chartTurnosRealizados.TabIndex = 0;
            // 
            // chartTurnosCancelados
            // 
            this.chartTurnosCancelados.BorderlineColor = System.Drawing.Color.Black;
            this.chartTurnosCancelados.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea5.Name = "ChartArea1";
            this.chartTurnosCancelados.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartTurnosCancelados.Legends.Add(legend5);
            this.chartTurnosCancelados.Location = new System.Drawing.Point(713, 27);
            this.chartTurnosCancelados.Name = "chartTurnosCancelados";
            this.chartTurnosCancelados.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartTurnosCancelados.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Turnos Cancelados";
            this.chartTurnosCancelados.Series.Add(series5);
            this.chartTurnosCancelados.Size = new System.Drawing.Size(720, 404);
            this.chartTurnosCancelados.TabIndex = 1;
            // 
            // chartRecaudado
            // 
            this.chartRecaudado.BorderlineColor = System.Drawing.Color.Black;
            this.chartRecaudado.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea6.Name = "ChartArea1";
            this.chartRecaudado.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartRecaudado.Legends.Add(legend6);
            this.chartRecaudado.Location = new System.Drawing.Point(395, 437);
            this.chartRecaudado.Name = "chartRecaudado";
            this.chartRecaudado.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Total Recaudado";
            this.chartRecaudado.Series.Add(series6);
            this.chartRecaudado.Size = new System.Drawing.Size(695, 404);
            this.chartRecaudado.TabIndex = 2;
            // 
            // lblTotalTurnosRealizados
            // 
            this.lblTotalTurnosRealizados.AutoSize = true;
            this.lblTotalTurnosRealizados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTurnosRealizados.Location = new System.Drawing.Point(12, 437);
            this.lblTotalTurnosRealizados.Name = "lblTotalTurnosRealizados";
            this.lblTotalTurnosRealizados.Size = new System.Drawing.Size(186, 16);
            this.lblTotalTurnosRealizados.TabIndex = 3;
            this.lblTotalTurnosRealizados.Text = "Total Turnos Realizados: ";
            // 
            // lblTotalTurnosCancelados
            // 
            this.lblTotalTurnosCancelados.AutoSize = true;
            this.lblTotalTurnosCancelados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTurnosCancelados.Location = new System.Drawing.Point(1164, 437);
            this.lblTotalTurnosCancelados.Name = "lblTotalTurnosCancelados";
            this.lblTotalTurnosCancelados.Size = new System.Drawing.Size(190, 16);
            this.lblTotalTurnosCancelados.TabIndex = 4;
            this.lblTotalTurnosCancelados.Text = "Total Turnos Cancelados: ";
            // 
            // lblTotalRecaudado
            // 
            this.lblTotalRecaudado.AutoSize = true;
            this.lblTotalRecaudado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecaudado.Location = new System.Drawing.Point(207, 654);
            this.lblTotalRecaudado.Name = "lblTotalRecaudado";
            this.lblTotalRecaudado.Size = new System.Drawing.Size(136, 16);
            this.lblTotalRecaudado.TabIndex = 5;
            this.lblTotalRecaudado.Text = "Total Recaudado: ";
            // 
            // mnuInfo
            // 
            this.mnuInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelacionesPacientesToolStripMenuItem});
            this.mnuInfo.Location = new System.Drawing.Point(0, 0);
            this.mnuInfo.Name = "mnuInfo";
            this.mnuInfo.Size = new System.Drawing.Size(1439, 24);
            this.mnuInfo.TabIndex = 6;
            this.mnuInfo.Text = "menuStrip1";
            // 
            // cancelacionesPacientesToolStripMenuItem
            // 
            this.cancelacionesPacientesToolStripMenuItem.Name = "cancelacionesPacientesToolStripMenuItem";
            this.cancelacionesPacientesToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.cancelacionesPacientesToolStripMenuItem.Text = "Cancelaciones Pacientes";
            this.cancelacionesPacientesToolStripMenuItem.Click += new System.EventHandler(this.cancelacionesPacientesToolStripMenuItem_Click);
            // 
            // frmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1439, 617);
            this.Controls.Add(this.lblTotalRecaudado);
            this.Controls.Add(this.lblTotalTurnosCancelados);
            this.Controls.Add(this.lblTotalTurnosRealizados);
            this.Controls.Add(this.chartRecaudado);
            this.Controls.Add(this.chartTurnosCancelados);
            this.Controls.Add(this.chartTurnosRealizados);
            this.Controls.Add(this.mnuInfo);
            this.MainMenuStrip = this.mnuInfo;
            this.Name = "frmInfo";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.PruebaChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTurnosRealizados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTurnosCancelados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRecaudado)).EndInit();
            this.mnuInfo.ResumeLayout(false);
            this.mnuInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTurnosRealizados;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTurnosCancelados;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRecaudado;
        private System.Windows.Forms.Label lblTotalTurnosRealizados;
        private System.Windows.Forms.Label lblTotalTurnosCancelados;
        private System.Windows.Forms.Label lblTotalRecaudado;
        private System.Windows.Forms.MenuStrip mnuInfo;
        private System.Windows.Forms.ToolStripMenuItem cancelacionesPacientesToolStripMenuItem;
    }
}