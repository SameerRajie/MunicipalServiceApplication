namespace MunicipalServiceApplication
{
    partial class SignupForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnSignup = new System.Windows.Forms.Button();
            this.linkLogin = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.cBoxShowConfirm = new System.Windows.Forms.CheckBox();
            this.cBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Underline);
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create an Account";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(201, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(201, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Confirm Password";
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNewUsername.Location = new System.Drawing.Point(450, 195);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(318, 30);
            this.txtNewUsername.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(450, 360);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(318, 30);
            this.txtConfirmPassword.TabIndex = 2;
            // 
            // btnSignup
            // 
            this.btnSignup.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSignup.Location = new System.Drawing.Point(670, 546);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(123, 35);
            this.btnSignup.TabIndex = 3;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // linkLogin
            // 
            this.linkLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.linkLogin.AutoSize = true;
            this.linkLogin.BackColor = System.Drawing.Color.White;
            this.linkLogin.Location = new System.Drawing.Point(601, 584);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(192, 20);
            this.linkLogin.TabIndex = 4;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "Already have an account?";
            this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogin_LinkClicked_1);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(201, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNewPassword.Location = new System.Drawing.Point(450, 273);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(318, 30);
            this.txtNewPassword.TabIndex = 2;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // cBoxShowConfirm
            // 
            this.cBoxShowConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBoxShowConfirm.AutoSize = true;
            this.cBoxShowConfirm.BackColor = System.Drawing.Color.White;
            this.cBoxShowConfirm.Location = new System.Drawing.Point(620, 396);
            this.cBoxShowConfirm.Name = "cBoxShowConfirm";
            this.cBoxShowConfirm.Size = new System.Drawing.Size(148, 24);
            this.cBoxShowConfirm.TabIndex = 5;
            this.cBoxShowConfirm.Text = "Show Password";
            this.cBoxShowConfirm.UseVisualStyleBackColor = false;
            this.cBoxShowConfirm.CheckedChanged += new System.EventHandler(this.cBoxShowConfirm_CheckedChanged);
            // 
            // cBoxShowPassword
            // 
            this.cBoxShowPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBoxShowPassword.AutoSize = true;
            this.cBoxShowPassword.BackColor = System.Drawing.Color.White;
            this.cBoxShowPassword.Location = new System.Drawing.Point(620, 309);
            this.cBoxShowPassword.Name = "cBoxShowPassword";
            this.cBoxShowPassword.Size = new System.Drawing.Size(148, 24);
            this.cBoxShowPassword.TabIndex = 5;
            this.cBoxShowPassword.Text = "Show Password";
            this.cBoxShowPassword.UseVisualStyleBackColor = false;
            this.cBoxShowPassword.CheckedChanged += new System.EventHandler(this.cBoxShowPassword_CheckedChanged);
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordError.Location = new System.Drawing.Point(830, 273);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(48, 20);
            this.lblPasswordError.TabIndex = 6;
            this.lblPasswordError.Text = "Label";
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::MunicipalServiceApplication.Properties.Resources.Coat_of_Arms;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1037, 733);
            this.Controls.Add(this.lblPasswordError);
            this.Controls.Add(this.cBoxShowPassword);
            this.Controls.Add(this.cBoxShowConfirm);
            this.Controls.Add(this.linkLogin);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtNewUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignupForm";
            this.Text = "SignupForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignupForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.LinkLabel linkLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.CheckBox cBoxShowConfirm;
        private System.Windows.Forms.CheckBox cBoxShowPassword;
        private System.Windows.Forms.Label lblPasswordError;
    }
}