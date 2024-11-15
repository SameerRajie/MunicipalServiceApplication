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

        public LoginForm()
        {
            InitializeComponent();
            userController = new UserController();
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
                this.Hide();
                mainForm.Show();
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
            this.Hide();
            signupForm.Show();
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
    }
}
