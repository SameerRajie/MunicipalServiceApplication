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
        /// <summary>
        /// Variables for the user and issue controllers
        /// </summary>
        private UserController userController;
        private IssueController issueController;
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Initializes the controllers and components
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            userController = new UserController();
            issueController = new IssueController();
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Validates the log in information and logs the user in if the information is correct
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Redirects the user to the Sign up page if clickes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Changes the password values characters to either * or normal letters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Ensures that the application stops when the form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //---------------------------------------------------------------------------------------------------------------------------------
    }
}
//--------------------------------------------------End of Code------------------------------------------------------------