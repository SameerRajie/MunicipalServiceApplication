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
            this.RequestBtn = new System.Windows.Forms.Button();
            this.issueBtn = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnToMenu = new System.Windows.Forms.Button();
            this.lViewEvents = new System.Windows.Forms.ListView();
            this.lViewAnnouncements = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxEventsCategory = new System.Windows.Forms.ComboBox();
            this.btnResetEvents = new System.Windows.Forms.Button();
            this.dPickerEvents = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RequestBtn
            // 
            this.RequestBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RequestBtn.Location = new System.Drawing.Point(943, 26);
            this.RequestBtn.MinimumSize = new System.Drawing.Size(133, 60);
            this.RequestBtn.Name = "RequestBtn";
            this.RequestBtn.Size = new System.Drawing.Size(133, 60);
            this.RequestBtn.TabIndex = 17;
            this.RequestBtn.Text = "Request Status";
            this.RequestBtn.UseVisualStyleBackColor = true;
            this.RequestBtn.Click += new System.EventHandler(this.RequestBtn_Click);
            // 
            // issueBtn
            // 
            this.issueBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.issueBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.issueBtn.Location = new System.Drawing.Point(756, 26);
            this.issueBtn.MinimumSize = new System.Drawing.Size(161, 60);
            this.issueBtn.Name = "issueBtn";
            this.issueBtn.Size = new System.Drawing.Size(161, 60);
            this.issueBtn.TabIndex = 18;
            this.issueBtn.Text = "Report Issue";
            this.issueBtn.UseVisualStyleBackColor = true;
            this.issueBtn.Click += new System.EventHandler(this.EventsBtn_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(60, 92);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(388, 58);
            this.lblHeading.TabIndex = 16;
            this.lblHeading.Text = "Announcements";
            // 
            // btnToMenu
            // 
            this.btnToMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToMenu.Location = new System.Drawing.Point(1099, 26);
            this.btnToMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnToMenu.MinimumSize = new System.Drawing.Size(133, 60);
            this.btnToMenu.Name = "btnToMenu";
            this.btnToMenu.Size = new System.Drawing.Size(133, 60);
            this.btnToMenu.TabIndex = 15;
            this.btnToMenu.Text = "Back To Menu";
            this.btnToMenu.UseVisualStyleBackColor = true;
            this.btnToMenu.Click += new System.EventHandler(this.btnToMenu_Click);
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
            this.lViewAnnouncements.Location = new System.Drawing.Point(59, 153);
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
            this.label1.Location = new System.Drawing.Point(637, 99);
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
            this.label2.Location = new System.Drawing.Point(643, 168);
            this.label2.MinimumSize = new System.Drawing.Size(202, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Filter by Category";
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
            // EventsAndAnnouncements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1243, 633);
            this.Controls.Add(this.dPickerEvents);
            this.Controls.Add(this.btnResetEvents);
            this.Controls.Add(this.cBoxEventsCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lViewAnnouncements);
            this.Controls.Add(this.lViewEvents);
            this.Controls.Add(this.RequestBtn);
            this.Controls.Add(this.issueBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnToMenu);
            this.Name = "EventsAndAnnouncements";
            this.Text = "EventsAndAnnouncements";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EventsAndAnnouncements_FormClosing);
            this.SizeChanged += new System.EventHandler(this.EventsAndAnnouncements_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RequestBtn;
        private System.Windows.Forms.Button issueBtn;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnToMenu;
        private System.Windows.Forms.ListView lViewEvents;
        private System.Windows.Forms.ListView lViewAnnouncements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxEventsCategory;
        private System.Windows.Forms.Button btnResetEvents;
        private System.Windows.Forms.DateTimePicker dPickerEvents;
        private System.Windows.Forms.Label label4;
    }
}