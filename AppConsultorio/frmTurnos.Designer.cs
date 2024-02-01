namespace AppConsultorio
{
    partial class frmTurnos
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
            this.panelCalendarioGrande = new System.Windows.Forms.Panel();
            this.calendarioGrande = new WindowsFormsCalendar.Calendar();
            this.calendarioMes = new WindowsFormsCalendar.MonthView();
            this.cbxProfesional = new System.Windows.Forms.ComboBox();
            this.lblMedico = new System.Windows.Forms.Label();
            this.panelCalendarioGrande.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCalendarioGrande
            // 
            this.panelCalendarioGrande.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCalendarioGrande.Controls.Add(this.calendarioGrande);
            this.panelCalendarioGrande.Location = new System.Drawing.Point(250, 43);
            this.panelCalendarioGrande.Name = "panelCalendarioGrande";
            this.panelCalendarioGrande.Size = new System.Drawing.Size(909, 581);
            this.panelCalendarioGrande.TabIndex = 1;
            // 
            // calendarioGrande
            // 
            this.calendarioGrande.CalendarTimeFormat = WindowsFormsCalendar.CalendarTimeFormat.TwentyFourHour;
            this.calendarioGrande.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarioGrande.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calendarioGrande.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.calendarioGrande.ItemsBackgroundColor = System.Drawing.Color.RoyalBlue;
            this.calendarioGrande.ItemsFont = null;
            this.calendarioGrande.ItemsForeColor = System.Drawing.Color.Black;
            this.calendarioGrande.Location = new System.Drawing.Point(0, 0);
            this.calendarioGrande.Name = "calendarioGrande";
            this.calendarioGrande.Size = new System.Drawing.Size(909, 581);
            this.calendarioGrande.TabIndex = 0;
            this.calendarioGrande.LoadItems += new WindowsFormsCalendar.Calendar.CalendarLoadEventHandler(this.calendarioGrande_LoadItems_1);
            this.calendarioGrande.DayHeaderClick += new WindowsFormsCalendar.Calendar.CalendarDayEventHandler(this.calendarioGrande_DayHeaderClick);
            this.calendarioGrande.ItemCreating += new WindowsFormsCalendar.Calendar.CalendarItemCancelEventHandler(this.calendarioGrande_ItemCreating);
            this.calendarioGrande.ItemCreated += new WindowsFormsCalendar.Calendar.CalendarItemCancelEventHandler(this.calendarioGrande_ItemCreated);
            this.calendarioGrande.ItemDatesChanged += new WindowsFormsCalendar.Calendar.CalendarItemEventHandler(this.calendarioGrande_ItemDatesChanged);
            this.calendarioGrande.ItemDoubleClick += new WindowsFormsCalendar.Calendar.CalendarItemEventHandler(this.calendarioGrande_ItemDoubleClick);
            // 
            // calendarioMes
            // 
            this.calendarioMes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.calendarioMes.ArrowsColor = System.Drawing.SystemColors.Highlight;
            this.calendarioMes.ArrowsSelectedColor = System.Drawing.Color.Gold;
            this.calendarioMes.DayBackgroundColor = System.Drawing.Color.White;
            this.calendarioMes.DayGrayedText = System.Drawing.SystemColors.ControlDark;
            this.calendarioMes.DaySelectedBackgroundColor = System.Drawing.SystemColors.Highlight;
            this.calendarioMes.DaySelectedColor = System.Drawing.SystemColors.WindowText;
            this.calendarioMes.DaySelectedTextColor = System.Drawing.SystemColors.HighlightText;
            this.calendarioMes.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calendarioMes.ItemPadding = new System.Windows.Forms.Padding(2);
            this.calendarioMes.Location = new System.Drawing.Point(1, 1);
            this.calendarioMes.MonthTitleColor = System.Drawing.SystemColors.ActiveCaption;
            this.calendarioMes.MonthTitleColorInactive = System.Drawing.SystemColors.InactiveCaption;
            this.calendarioMes.MonthTitleTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calendarioMes.MonthTitleTextColorInactive = System.Drawing.SystemColors.InactiveCaptionText;
            this.calendarioMes.Name = "calendarioMes";
            this.calendarioMes.SelectionMode = WindowsFormsCalendar.MonthViewSelection.WorkWeek;
            this.calendarioMes.Size = new System.Drawing.Size(243, 623);
            this.calendarioMes.TabIndex = 2;
            this.calendarioMes.TodayBorderColor = System.Drawing.Color.Maroon;
            this.calendarioMes.SelectionChanged += new System.EventHandler(this.calendarioMes_SelectionChanged);
            // 
            // cbxProfesional
            // 
            this.cbxProfesional.FormattingEnabled = true;
            this.cbxProfesional.Location = new System.Drawing.Point(349, 7);
            this.cbxProfesional.Name = "cbxProfesional";
            this.cbxProfesional.Size = new System.Drawing.Size(183, 21);
            this.cbxProfesional.TabIndex = 9;
            this.cbxProfesional.SelectedValueChanged += new System.EventHandler(this.cbxProfesional_SelectedValueChanged);
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedico.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMedico.Location = new System.Drawing.Point(250, 9);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(104, 18);
            this.lblMedico.TabIndex = 8;
            this.lblMedico.Text = "Profesional: ";
            // 
            // frmTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 624);
            this.Controls.Add(this.cbxProfesional);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.calendarioMes);
            this.Controls.Add(this.panelCalendarioGrande);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTurnos";
            this.Text = "Turnos";
            this.Load += new System.EventHandler(this.pruebaCalendario_Load);
            this.panelCalendarioGrande.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelCalendarioGrande;
        private WindowsFormsCalendar.Calendar calendarioGrande;
        private WindowsFormsCalendar.MonthView calendarioMes;
        private System.Windows.Forms.ComboBox cbxProfesional;
        private System.Windows.Forms.Label lblMedico;
    }
}