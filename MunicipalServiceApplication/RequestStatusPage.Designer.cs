namespace MunicipalServiceApplication
{
    partial class RequestStatusPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.navBtnLogOut = new System.Windows.Forms.Button();
            this.navBtnStatus = new System.Windows.Forms.Button();
            this.navBtnEvents = new System.Windows.Forms.Button();
            this.navBtnIssue = new System.Windows.Forms.Button();
            this.navBtnHome = new System.Windows.Forms.Button();
            this.btnToggleMenu = new System.Windows.Forms.Button();
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.lblHeading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxSort = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Location = new System.Drawing.Point(60, 256);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(992, 387);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(600, 137);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 38);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(269, 143);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(307, 26);
            this.txtBoxSearch.TabIndex = 3;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
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
            this.panelMenu.Size = new System.Drawing.Size(54, 641);
            this.panelMenu.TabIndex = 27;
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
            // lblHeading
            // 
            this.lblHeading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(257, 26);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(438, 69);
            this.lblHeading.TabIndex = 28;
            this.lblHeading.Text = "Request Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(264, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 38);
            this.label1.TabIndex = 29;
            this.label1.Text = "Sorted By: ";
            // 
            // cBoxSort
            // 
            this.cBoxSort.BackColor = System.Drawing.Color.White;
            this.cBoxSort.FormattingEnabled = true;
            this.cBoxSort.Location = new System.Drawing.Point(394, 202);
            this.cBoxSort.Name = "cBoxSort";
            this.cBoxSort.Size = new System.Drawing.Size(314, 28);
            this.cBoxSort.TabIndex = 30;
            this.cBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RequestStatusPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1101, 641);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cBoxSort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHeading);
            this.Name = "RequestStatusPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RequestStatusPage_FormClosing);
            this.Click += new System.EventHandler(this.RequestStatusPage_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button navBtnLogOut;
        private System.Windows.Forms.Button navBtnStatus;
        private System.Windows.Forms.Button navBtnEvents;
        private System.Windows.Forms.Button navBtnIssue;
        private System.Windows.Forms.Button navBtnHome;
        private System.Windows.Forms.Button btnToggleMenu;
        private System.Windows.Forms.Timer timerMenu;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxSort;
    }
}