namespace AppConsultorio
{
    partial class pruebaCalendario
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
            this.monthView1 = new WindowsFormsCalendar.MonthView();
            this.panelCalendarioGrande.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCalendarioGrande
            // 
            this.panelCalendarioGrande.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCalendarioGrande.Controls.Add(this.calendarioGrande);
            this.panelCalendarioGrande.Location = new System.Drawing.Point(250, 1);
            this.panelCalendarioGrande.Name = "panelCalendarioGrande";
            this.panelCalendarioGrande.Size = new System.Drawing.Size(909, 623);
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
            this.calendarioGrande.Size = new System.Drawing.Size(909, 623);
            this.calendarioGrande.TabIndex = 0;
            this.calendarioGrande.LoadItems += new WindowsFormsCalendar.Calendar.CalendarLoadEventHandler(this.calendarioGrande_LoadItems_1);
            this.calendarioGrande.ItemCreating += new WindowsFormsCalendar.Calendar.CalendarItemCancelEventHandler(this.calendarioGrande_ItemCreating);
            this.calendarioGrande.ItemCreated += new WindowsFormsCalendar.Calendar.CalendarItemCancelEventHandler(this.calendarioGrande_ItemCreated);
            this.calendarioGrande.ItemDoubleClick += new WindowsFormsCalendar.Calendar.CalendarItemEventHandler(this.calendarioGrande_ItemDoubleClick);
            // 
            // monthView1
            // 
            this.monthView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.monthView1.ArrowsColor = System.Drawing.SystemColors.Window;
            this.monthView1.ArrowsSelectedColor = System.Drawing.Color.Gold;
            this.monthView1.DayBackgroundColor = System.Drawing.Color.Empty;
            this.monthView1.DayGrayedText = System.Drawing.SystemColors.GrayText;
            this.monthView1.DaySelectedBackgroundColor = System.Drawing.SystemColors.Highlight;
            this.monthView1.DaySelectedColor = System.Drawing.SystemColors.WindowText;
            this.monthView1.DaySelectedTextColor = System.Drawing.SystemColors.HighlightText;
            this.monthView1.ItemPadding = new System.Windows.Forms.Padding(2);
            this.monthView1.Location = new System.Drawing.Point(1, 1);
            this.monthView1.MonthTitleColor = System.Drawing.SystemColors.ActiveCaption;
            this.monthView1.MonthTitleColorInactive = System.Drawing.SystemColors.InactiveCaption;
            this.monthView1.MonthTitleTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monthView1.MonthTitleTextColorInactive = System.Drawing.SystemColors.InactiveCaptionText;
            this.monthView1.Name = "monthView1";
            this.monthView1.Size = new System.Drawing.Size(243, 623);
            this.monthView1.TabIndex = 2;
            this.monthView1.Text = "monthView1";
            this.monthView1.TodayBorderColor = System.Drawing.Color.Maroon;
            // 
            // pruebaCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 624);
            this.Controls.Add(this.monthView1);
            this.Controls.Add(this.panelCalendarioGrande);
            this.Name = "pruebaCalendario";
            this.Text = "pruebaCalendario";
            this.Load += new System.EventHandler(this.pruebaCalendario_Load);
            this.panelCalendarioGrande.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelCalendarioGrande;
        private WindowsFormsCalendar.Calendar calendarioGrande;
        private WindowsFormsCalendar.MonthView monthView1;
    }
}