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
        //Calls the UserController class
        private UserController userController;
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Initializes the usercontroller variable to the class
        /// Clears the password's error label
        /// </summary>
        public SignupForm()
        {
            InitializeComponent();
            userController = new UserController();
            lblPasswordError.Text = string.Empty;
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Button to create a new user using the input values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSignup_Click(object sender, EventArgs e)
        {
            string username = txtNewUsername.Text;
            string password = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (VerifyPassword(password))
            {
                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }

                if (userController.Signup(username, password))
                {
                    MessageBox.Show("Signup successful! You can now log in.");
                    // Redirect to Login Form
                    LoginForm login = new LoginForm();

                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        login.WindowState = FormWindowState.Maximized;
                    }
                    else
                    {
                        login.Size = this.Size;
                        login.Location = this.Location;
                    }

                    login.Show();
                    this.Hide();
                }
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Redirects the user to the login page when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLogin_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Redirect to Login form
            LoginForm login = new LoginForm();

            if (this.WindowState == FormWindowState.Maximized)
            {
                login.WindowState = FormWindowState.Maximized;
            }
            else
            {
                login.Size = this.Size;
                login.Location = this.Location;
            }

            login.Show();
            this.Hide();
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Changes the password values characters to either * or normal letters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Changes the confirm password values characters to either * or normal letters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Method to check that the password matches the requirements and updates the label accordingly
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool VerifyPassword(string password)
        {
            // Validation criteria
            bool isLongEnough = password.Length >= 7;
            bool hasUpperCase = password.Any(char.IsUpper);
            bool hasNumber = password.Any(char.IsDigit);
            bool hasSpecialChar = password.Any(ch => !char.IsLetterOrDigit(ch));

            // Build error message dynamically
            List<string> errors = new List<string>();

            if (!isLongEnough || !hasUpperCase || !hasNumber || !hasSpecialChar)
            {
                errors.Add("Must Contain: ");
            }

            if (!isLongEnough)
            {
                errors.Add("• At least 7 characters long");
            }
            if (!hasUpperCase)
            {
                errors.Add("• At least 1 uppercase letter");
            }
            if (!hasNumber)
            {
                errors.Add("• At least 1 number");
            }
            if (!hasSpecialChar)
            {
                errors.Add("• At least 1 special character");
            }

            // Show errors in lblPasswordError
            if (errors.Count > 0)
            {
                lblPasswordError.Text = string.Join(Environment.NewLine, errors);
                lblPasswordError.Visible = true;
                return false;
            }
            else
            {
                lblPasswordError.Text = string.Empty; // Clear error message
                lblPasswordError.Visible = false;
                return true;
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Calls the Verify Password method each time the text box value is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            VerifyPassword(txtNewPassword.Text);
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Ensures that the application is stopped when the form is closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //---------------------------------------------------------------------------------------------------------------------------------
    }
}
//--------------------------------------------------End of Code------------------------------------------------------------