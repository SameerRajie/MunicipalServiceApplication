namespace MunicipalServiceApplication
{
    partial class ReportIssuesPage
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
            this.txtBoxLocation = new System.Windows.Forms.TextBox();
            this.cBoxCategory = new System.Windows.Forms.ComboBox();
            this.txtBoxDescription = new System.Windows.Forms.RichTextBox();
            this.btnAttachFile = new System.Windows.Forms.Button();
            this.pBarEngagement = new System.Windows.Forms.ProgressBar();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnToMenu = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLocationError = new System.Windows.Forms.Label();
            this.lblCategoryError = new System.Windows.Forms.Label();
            this.lblDescriptionError = new System.Windows.Forms.Label();
            this.lblAttachFileError = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.EventsBtn = new System.Windows.Forms.Button();
            this.RequestBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxLocation
            // 
            this.txtBoxLocation.Location = new System.Drawing.Point(597, 157);
            this.txtBoxLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxLocation.MinimumSize = new System.Drawing.Size(4, 25);
            this.txtBoxLocation.Name = "txtBoxLocation";
            this.txtBoxLocation.Size = new System.Drawing.Size(307, 26);
            this.txtBoxLocation.TabIndex = 0;
            this.txtBoxLocation.TextChanged += new System.EventHandler(this.txtBoxLocation_TextChanged);
            // 
            // cBoxCategory
            // 
            this.cBoxCategory.FormattingEnabled = true;
            this.cBoxCategory.Location = new System.Drawing.Point(599, 214);
            this.cBoxCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBoxCategory.Name = "cBoxCategory";
            this.cBoxCategory.Size = new System.Drawing.Size(307, 28);
            this.cBoxCategory.TabIndex = 1;
            this.cBoxCategory.SelectedIndexChanged += new System.EventHandler(this.cBoxCategory_SelectedIndexChanged);
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Location = new System.Drawing.Point(597, 273);
            this.txtBoxDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(307, 146);
            this.txtBoxDescription.TabIndex = 2;
            this.txtBoxDescription.Text = "";
            this.txtBoxDescription.TextChanged += new System.EventHandler(this.txtBoxDescription_TextChanged);
            // 
            // btnAttachFile
            // 
            this.btnAttachFile.Location = new System.Drawing.Point(794, 429);
            this.btnAttachFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAttachFile.Name = "btnAttachFile";
            this.btnAttachFile.Size = new System.Drawing.Size(112, 35);
            this.btnAttachFile.TabIndex = 3;
            this.btnAttachFile.Text = "Attach File";
            this.btnAttachFile.UseVisualStyleBackColor = true;
            this.btnAttachFile.Click += new System.EventHandler(this.btnAttachFile_Click);
            // 
            // pBarEngagement
            // 
            this.pBarEngagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBarEngagement.ForeColor = System.Drawing.Color.Yellow;
            this.pBarEngagement.Location = new System.Drawing.Point(18, 596);
            this.pBarEngagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pBarEngagement.Maximum = 4;
            this.pBarEngagement.Name = "pBarEngagement";
            this.pBarEngagement.Size = new System.Drawing.Size(1268, 60);
            this.pBarEngagement.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(597, 518);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(112, 35);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnToMenu
            // 
            this.btnToMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToMenu.Location = new System.Drawing.Point(1164, 21);
            this.btnToMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnToMenu.Name = "btnToMenu";
            this.btnToMenu.Size = new System.Drawing.Size(133, 60);
            this.btnToMenu.TabIndex = 6;
            this.btnToMenu.Text = "Back To Menu";
            this.btnToMenu.UseVisualStyleBackColor = true;
            this.btnToMenu.Click += new System.EventHandler(this.btnToMenu_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(186, 43);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(378, 58);
            this.lblHeading.TabIndex = 7;
            this.lblHeading.Text = "Report an Issue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 273);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description";
            // 
            // lblLocationError
            // 
            this.lblLocationError.AutoSize = true;
            this.lblLocationError.ForeColor = System.Drawing.Color.White;
            this.lblLocationError.Location = new System.Drawing.Point(921, 146);
            this.lblLocationError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocationError.Name = "lblLocationError";
            this.lblLocationError.Size = new System.Drawing.Size(0, 20);
            this.lblLocationError.TabIndex = 9;
            // 
            // lblCategoryError
            // 
            this.lblCategoryError.AutoSize = true;
            this.lblCategoryError.ForeColor = System.Drawing.Color.White;
            this.lblCategoryError.Location = new System.Drawing.Point(926, 205);
            this.lblCategoryError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryError.Name = "lblCategoryError";
            this.lblCategoryError.Size = new System.Drawing.Size(0, 20);
            this.lblCategoryError.TabIndex = 10;
            // 
            // lblDescriptionError
            // 
            this.lblDescriptionError.AutoSize = true;
            this.lblDescriptionError.ForeColor = System.Drawing.Color.White;
            this.lblDescriptionError.Location = new System.Drawing.Point(926, 293);
            this.lblDescriptionError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescriptionError.Name = "lblDescriptionError";
            this.lblDescriptionError.Size = new System.Drawing.Size(0, 20);
            this.lblDescriptionError.TabIndex = 11;
            // 
            // lblAttachFileError
            // 
            this.lblAttachFileError.AutoSize = true;
            this.lblAttachFileError.ForeColor = System.Drawing.Color.White;
            this.lblAttachFileError.Location = new System.Drawing.Point(921, 440);
            this.lblAttachFileError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttachFileError.Name = "lblAttachFileError";
            this.lblAttachFileError.Size = new System.Drawing.Size(0, 20);
            this.lblAttachFileError.TabIndex = 12;
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.Color.Transparent;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.Location = new System.Drawing.Point(591, 661);
            this.lblProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(55, 32);
            this.lblProgress.TabIndex = 13;
            this.lblProgress.Text = "0%";
            // 
            // EventsBtn
            // 
            this.EventsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EventsBtn.Location = new System.Drawing.Point(821, 21);
            this.EventsBtn.Name = "EventsBtn";
            this.EventsBtn.Size = new System.Drawing.Size(161, 60);
            this.EventsBtn.TabIndex = 14;
            this.EventsBtn.Text = "Events and Annoouncements";
            this.EventsBtn.UseVisualStyleBackColor = true;
            this.EventsBtn.Click += new System.EventHandler(this.EventsBtn_Click);
            // 
            // RequestBtn
            // 
            this.RequestBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RequestBtn.Location = new System.Drawing.Point(1008, 21);
            this.RequestBtn.Name = "RequestBtn";
            this.RequestBtn.Size = new System.Drawing.Size(133, 60);
            this.RequestBtn.TabIndex = 14;
            this.RequestBtn.Text = "Request Status";
            this.RequestBtn.UseVisualStyleBackColor = true;
            this.RequestBtn.Click += new System.EventHandler(this.RequestBtn_Click);
            // 
            // ReportIssuesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1304, 699);
            this.Controls.Add(this.RequestBtn);
            this.Controls.Add(this.EventsBtn);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.lblAttachFileError);
            this.Controls.Add(this.lblDescriptionError);
            this.Controls.Add(this.lblCategoryError);
            this.Controls.Add(this.lblLocationError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnToMenu);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pBarEngagement);
            this.Controls.Add(this.btnAttachFile);
            this.Controls.Add(this.txtBoxDescription);
            this.Controls.Add(this.cBoxCategory);
            this.Controls.Add(this.txtBoxLocation);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReportIssuesPage";
            this.Text = "ReportIssuesPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportIssuesPage_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxLocation;
        private System.Windows.Forms.ComboBox cBoxCategory;
        private System.Windows.Forms.RichTextBox txtBoxDescription;
        private System.Windows.Forms.Button btnAttachFile;
        private System.Windows.Forms.ProgressBar pBarEngagement;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnToMenu;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLocationError;
        private System.Windows.Forms.Label lblCategoryError;
        private System.Windows.Forms.Label lblDescriptionError;
        private System.Windows.Forms.Label lblAttachFileError;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button EventsBtn;
        private System.Windows.Forms.Button RequestBtn;
    }
}