using MunicipalServiceApplication.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalServiceApplication
{
    public partial class LoginForm : Form
    {
        private UserController userController;
        private IssueController issueController;

        public LoginForm()
        {
            InitializeComponent();
            userController = new UserController();
            issueController = new IssueController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (userController.Login(username, password))
            {
                MessageBox.Show("Login successful!");
                // Redirect to main application form
                Form1 mainForm = new Form1();


                issueController.GenerateDummyData(GetSet.userId);

                if (this.WindowState == FormWindowState.Maximized)
                {
                    mainForm.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    mainForm.Size = this.Size;
                    mainForm.Location = this.Location;
                }

                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void linkSignup_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the Signup form
            SignupForm signupForm = new SignupForm();

            if (this.WindowState == FormWindowState.Maximized)
            {
                signupForm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                signupForm.Size = this.Size;
                signupForm.Location = this.Location;
            }

            signupForm.Show();
            this.Hide();
        }

        private void cBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
