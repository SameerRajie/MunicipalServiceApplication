namespace MunicipalServiceApplication
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.navBtnLogOut = new System.Windows.Forms.Button();
            this.navBtnStatus = new System.Windows.Forms.Button();
            this.navBtnEvents = new System.Windows.Forms.Button();
            this.navBtnIssue = new System.Windows.Forms.Button();
            this.navBtnHome = new System.Windows.Forms.Button();
            this.btnToggleMenu = new System.Windows.Forms.Button();
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnReportIssue = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.navBtnLogOut);
            this.panelMenu.Controls.Add(this.navBtnStatus);
            this.panelMenu.Controls.Add(this.navBtnEvents);
            this.panelMenu.Controls.Add(this.navBtnIssue);
            this.panelMenu.Controls.Add(this.navBtnHome);
            this.panelMenu.Controls.Add(this.btnToggleMenu);
            this.panelMenu.ForeColor = System.Drawing.Color.Black;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(55, 639);
            this.panelMenu.TabIndex = 3;
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
            this.timerMenu.Tick += new System.EventHandler(this.timerMenu_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.14585F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.85415F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnReportIssue, 1, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(69, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1326, 665);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(36, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 106);
            this.label1.TabIndex = 1;
            this.label1.Text = "Municipal \r\nEngagement";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(753, 520);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 66);
            this.button3.TabIndex = 0;
            this.button3.Text = "Request Status";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(753, 298);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 66);
            this.button2.TabIndex = 0;
            this.button2.Text = "Events and Announcements";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // btnReportIssue
            // 
            this.btnReportIssue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReportIssue.Location = new System.Drawing.Point(753, 77);
            this.btnReportIssue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReportIssue.Name = "btnReportIssue";
            this.btnReportIssue.Size = new System.Drawing.Size(178, 66);
            this.btnReportIssue.TabIndex = 0;
            this.btnReportIssue.Text = "Report an Issue";
            this.btnReportIssue.UseVisualStyleBackColor = true;
            this.btnReportIssue.Click += new System.EventHandler(this.btnReportIssue_Click);
            this.btnReportIssue.MouseLeave += new System.EventHandler(this.btnReportIssue_MouseLeave);
            this.btnReportIssue.MouseHover += new System.EventHandler(this.btnReportIssue_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1145, 634);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panelMenu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReportIssue;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button navBtnStatus;
        private System.Windows.Forms.Button navBtnEvents;
        private System.Windows.Forms.Button navBtnIssue;
        private System.Windows.Forms.Button navBtnHome;
        private System.Windows.Forms.Button btnToggleMenu;
        private System.Windows.Forms.Timer timerMenu;
        private System.Windows.Forms.Button navBtnLogOut;
    }
}

