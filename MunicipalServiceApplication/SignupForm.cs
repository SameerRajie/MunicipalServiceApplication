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
    public partial class SignupForm : Form
    {
        private UserController userController;

        public SignupForm()
        {
            InitializeComponent();
            userController = new UserController();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string username = txtNewUsername.Text;
            string password = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (userController.Signup(username, password))
            {
                MessageBox.Show("Signup successful! You can now log in.");
                // Redirect to Login Form
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Username already exists. Please choose another.");
            }
        }

        private void linkLogin_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Redirect to Login form
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void cBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxShowPassword.Checked)
            {
                txtNewPassword.PasswordChar = '\0';
            }
            else
            {
                txtNewPassword.PasswordChar = '*';
            }
        }

        private void cBoxShowConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxShowConfirm.Checked)
            {
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtConfirmPassword.PasswordChar = '*';
            }
        }
    }
}
