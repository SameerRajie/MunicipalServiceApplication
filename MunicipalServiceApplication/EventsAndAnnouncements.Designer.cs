namespace MunicipalServiceApplication
{
    partial class EventsAndAnnouncements
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
            this.components = new System.ComponentModel.Container();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lViewEvents = new System.Windows.Forms.ListView();
            this.lViewAnnouncements = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxEventsCategory = new System.Windows.Forms.ComboBox();
            this.btnResetEvents = new System.Windows.Forms.Button();
            this.dPickerEvents = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.navBtnLogOut = new System.Windows.Forms.Button();
            this.navBtnStatus = new System.Windows.Forms.Button();
            this.navBtnEvents = new System.Windows.Forms.Button();
            this.navBtnIssue = new System.Windows.Forms.Button();
            this.navBtnHome = new System.Windows.Forms.Button();
            this.btnToggleMenu = new System.Windows.Forms.Button();
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(68, 9);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(388, 58);
            this.lblHeading.TabIndex = 16;
            this.lblHeading.Text = "Announcements";
            // 
            // lViewEvents
            // 
            this.lViewEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lViewEvents.HideSelection = false;
            this.lViewEvents.Location = new System.Drawing.Point(648, 248);
            this.lViewEvents.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lViewEvents.MinimumSize = new System.Drawing.Size(529, 357);
            this.lViewEvents.Name = "lViewEvents";
            this.lViewEvents.Size = new System.Drawing.Size(529, 357);
            this.lViewEvents.TabIndex = 19;
            this.lViewEvents.UseCompatibleStateImageBehavior = false;
            this.lViewEvents.View = System.Windows.Forms.View.Details;
            // 
            // lViewAnnouncements
            // 
            this.lViewAnnouncements.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lViewAnnouncements.HideSelection = false;
            this.lViewAnnouncements.Location = new System.Drawing.Point(67, 70);
            this.lViewAnnouncements.MinimumSize = new System.Drawing.Size(548, 450);
            this.lViewAnnouncements.Name = "lViewAnnouncements";
            this.lViewAnnouncements.Size = new System.Drawing.Size(548, 450);
            this.lViewAnnouncements.TabIndex = 19;
            this.lViewAnnouncements.UseCompatibleStateImageBehavior = false;
            this.lViewAnnouncements.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(637, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MinimumSize = new System.Drawing.Size(178, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 58);
            this.label1.TabIndex = 16;
            this.label1.Text = "Events";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(642, 107);
            this.label2.MinimumSize = new System.Drawing.Size(202, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Search";
            // 
            // cBoxEventsCategory
            // 
            this.cBoxEventsCategory.FormattingEnabled = true;
            this.cBoxEventsCategory.Location = new System.Drawing.Point(851, 172);
            this.cBoxEventsCategory.MinimumSize = new System.Drawing.Size(241, 0);
            this.cBoxEventsCategory.Name = "cBoxEventsCategory";
            this.cBoxEventsCategory.Size = new System.Drawing.Size(241, 28);
            this.cBoxEventsCategory.TabIndex = 23;
            this.cBoxEventsCategory.SelectedIndexChanged += new System.EventHandler(this.cBoxEventsCategory_SelectedIndexChanged);
            // 
            // btnResetEvents
            // 
            this.btnResetEvents.AutoSize = true;
            this.btnResetEvents.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnResetEvents.Location = new System.Drawing.Point(1101, 200);
            this.btnResetEvents.MinimumSize = new System.Drawing.Size(75, 32);
            this.btnResetEvents.Name = "btnResetEvents";
            this.btnResetEvents.Size = new System.Drawing.Size(75, 32);
            this.btnResetEvents.TabIndex = 24;
            this.btnResetEvents.Text = "Reset";
            this.btnResetEvents.UseVisualStyleBackColor = true;
            this.btnResetEvents.Click += new System.EventHandler(this.btnResetEvents_Click);
            // 
            // dPickerEvents
            // 
            this.dPickerEvents.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dPickerEvents.Location = new System.Drawing.Point(851, 205);
            this.dPickerEvents.MinimumSize = new System.Drawing.Size(241, 26);
            this.dPickerEvents.Name = "dPickerEvents";
            this.dPickerEvents.Size = new System.Drawing.Size(241, 26);
            this.dPickerEvents.TabIndex = 25;
            this.dPickerEvents.ValueChanged += new System.EventHandler(this.dPickerEvents_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(643, 205);
            this.label4.MinimumSize = new System.Drawing.Size(155, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 29);
            this.label4.TabIndex = 22;
            this.label4.Text = "Filter by Date";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.navBtnLogOut);
            this.panelMenu.Controls.Add(this.navBtnStatus);
            this.panelMenu.Controls.Add(this.navBtnEvents);
            this.panelMenu.Controls.Add(this.navBtnIssue);
            this.panelMenu.Controls.Add(this.navBtnHome);
            this.panelMenu.Controls.Add(this.btnToggleMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.Black;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(61, 633);
            this.panelMenu.TabIndex = 26;
            // 
            // navBtnLogOut
            // 
            this.navBtnLogOut.Location = new System.Drawing.Point(60, 544);
            this.navBtnLogOut.Name = "navBtnLogOut";
            this.navBtnLogOut.Size = new System.Drawing.Size(285, 55);
            this.navBtnLogOut.TabIndex = 1;
            this.navBtnLogOut.Text = "Log Out";
            this.navBtnLogOut.UseVisualStyleBackColor = true;
            this.navBtnLogOut.Click += new System.EventHandler(this.navBtnLogOut_Click);
            // 
            // navBtnStatus
            // 
            this.navBtnStatus.Location = new System.Drawing.Point(60, 326);
            this.navBtnStatus.Name = "navBtnStatus";
            this.navBtnStatus.Size = new System.Drawing.Size(285, 55);
            this.navBtnStatus.TabIndex = 1;
            this.navBtnStatus.Text = "Request Status";
            this.navBtnStatus.UseVisualStyleBackColor = true;
            this.navBtnStatus.Click += new System.EventHandler(this.navBtnStatus_Click);
            // 
            // navBtnEvents
            // 
            this.navBtnEvents.Location = new System.Drawing.Point(60, 265);
            this.navBtnEvents.Name = "navBtnEvents";
            this.navBtnEvents.Size = new System.Drawing.Size(283, 55);
            this.navBtnEvents.TabIndex = 1;
            this.navBtnEvents.Text = "Events and Announcements";
            this.navBtnEvents.UseVisualStyleBackColor = true;
            this.navBtnEvents.Click += new System.EventHandler(this.navBtnEvents_Click);
            // 
            // navBtnIssue
            // 
            this.navBtnIssue.Location = new System.Drawing.Point(60, 204);
            this.navBtnIssue.Name = "navBtnIssue";
            this.navBtnIssue.Size = new System.Drawing.Size(283, 55);
            this.navBtnIssue.TabIndex = 1;
            this.navBtnIssue.Text = "Report Issue";
            this.navBtnIssue.UseVisualStyleBackColor = true;
            this.navBtnIssue.Click += new System.EventHandler(this.navBtnIssue_Click);
            // 
            // navBtnHome
            // 
            this.navBtnHome.Location = new System.Drawing.Point(60, 143);
            this.navBtnHome.Name = "navBtnHome";
            this.navBtnHome.Size = new System.Drawing.Size(283, 55);
            this.navBtnHome.TabIndex = 1;
            this.navBtnHome.Text = "Home";
            this.navBtnHome.UseVisualStyleBackColor = true;
            this.navBtnHome.Click += new System.EventHandler(this.navBtnHome_Click);
            // 
            // btnToggleMenu
            // 
            this.btnToggleMenu.BackgroundImage = global::MunicipalServiceApplication.Properties.Resources.three_lines1;
            this.btnToggleMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnToggleMenu.Location = new System.Drawing.Point(0, 0);
            this.btnToggleMenu.Name = "btnToggleMenu";
            this.btnToggleMenu.Size = new System.Drawing.Size(59, 60);
            this.btnToggleMenu.TabIndex = 0;
            this.btnToggleMenu.UseVisualStyleBackColor = true;
            this.btnToggleMenu.Click += new System.EventHandler(this.btnToggleMenu_Click);
            // 
            // timerMenu
            // 
            this.timerMenu.Tick += new System.EventHandler(this.timerMenu_Tick_1);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(850, 107);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(242, 26);
            this.txtBoxSearch.TabIndex = 27;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1101, 103);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(77, 34);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(642, 168);
            this.label3.MinimumSize = new System.Drawing.Size(155, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Filter by Category";
            // 
            // EventsAndAnnouncements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1243, 633);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.dPickerEvents);
            this.Controls.Add(this.btnResetEvents);
            this.Controls.Add(this.cBoxEventsCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lViewAnnouncements);
            this.Controls.Add(this.lViewEvents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHeading);
            this.Name = "EventsAndAnnouncements";
            this.Text = "EventsAndAnnouncements";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EventsAndAnnouncements_FormClosing);
            this.SizeChanged += new System.EventHandler(this.EventsAndAnnouncements_SizeChanged);
            this.Click += new System.EventHandler(this.EventsAndAnnouncements_Click);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.ListView lViewEvents;
        private System.Windows.Forms.ListView lViewAnnouncements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxEventsCategory;
        private System.Windows.Forms.Button btnResetEvents;
        private System.Windows.Forms.DateTimePicker dPickerEvents;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button navBtnLogOut;
        private System.Windows.Forms.Button navBtnStatus;
        private System.Windows.Forms.Button navBtnEvents;
        private System.Windows.Forms.Button navBtnIssue;
        private System.Windows.Forms.Button navBtnHome;
        private System.Windows.Forms.Button btnToggleMenu;
        private System.Windows.Forms.Timer timerMenu;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
    }
}