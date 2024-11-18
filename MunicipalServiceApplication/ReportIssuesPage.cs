using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MunicipalServiceApplication.Controllers;

namespace MunicipalServiceApplication
{
    public partial class ReportIssuesPage : Form
    {
        //---------------------------------------------------------------------------------------------------------------------------------
        //Declares Global variables to help with the prograss bar
        byte[] fileData;
        int progress;
        bool locationChanged;
        bool categorySelected;
        bool descriptionChanged;
        bool fileAttached;
        //---------------------------------------------------------------------------------------------------------------------------------
        private IssueController controller;
        private bool isMenuCollapsed = true; // Start in a collapsed state
        private int menuWidth = 250; // Full width of the menu
        private int collapsedWidth = 40; // Collapsed width of the menu
        private int stepSize = 30;
        /// <summary>
        /// Method that runs when the page is loaded, ensures progress bar is nothing, all errors are cleared and the combo box has values
        /// </summary>
        public ReportIssuesPage()
        {
            InitializeComponent();
            locationChanged = false;
            categorySelected = false;
            descriptionChanged = false;
            fileAttached = false;
            controller = new IssueController();

            panelMenu.Width = collapsedWidth;
            timerMenu.Interval = 30;

            PopulateComboBox();
            ClearErrors();
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Method to clear the error labels
        /// </summary>
        public void ClearErrors()
        {
            lblAttachFileError.Text = string.Empty;
            lblCategoryError.Text = string.Empty;
            lblDescriptionError.Text = string.Empty;
            lblLocationError.Text = string.Empty;
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Method to populate the combobox with the wanted values
        /// </summary>
        public void PopulateComboBox()
        {
            List<string> categories = new List<string>();

            categories.Add("Traffic and Road");
            categories.Add("Public Safety");
            categories.Add("Housing and Building");
            categories.Add("Animal Control");
            categories.Add("Environmental Concerns");
            categories.Add("Public Transportation");
            categories.Add("Feedback and Suggestion");
            categories.Add("Other");

            cBoxCategory.Items.AddRange(categories.ToArray());
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Method to ensure that the progress bar is updated
        /// </summary>
        public void UpdateProgressBar()
        {
            pBarEngagement.Value = progress;

            if (progress <= 0) 
            {
                lblProgress.Text = "0%";
            }
            if (progress == 1)
            {
                lblProgress.Text = "25%";
            }
            if (progress == 2)
            {
                lblProgress.Text = "50%";
            }
            if (progress == 3)
            {
                lblProgress.Text = "75%";
            }
            if (progress == 4)
            {
                lblProgress.Text = "100%";
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Method to get a file from the device and add it to a byte array
        /// </summary>
        /// <returns></returns>
        public byte[] getFile()
        {
            string selectedFilePath;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of specified file
                    selectedFilePath = openFileDialog.FileName;
                    return File.ReadAllBytes(selectedFilePath);
                }
                else
                {
                    return null;
                }
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Button to attach a file and update the progress bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAttachFile_Click(object sender, EventArgs e)
        {
            fileData = getFile();

            if (fileData.Length > 0)
            {
                if (!fileAttached)
                {
                    progress++;
                    fileAttached = true;
                    UpdateProgressBar();
                }
            }
            else
            {
                if (progress > 0 && fileAttached)
                {
                    progress--;
                    fileAttached = false;
                    UpdateProgressBar();
                }
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Button to check the inputs and save the data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            Validation val = new Validation();
            string location;
            string category;
            string description;
            byte[] attachedFile;

            ClearErrors();

            if (val.ValidState(txtBoxLocation.Text, cBoxCategory.SelectedIndex, txtBoxDescription.Text, fileData))
            {
                location = txtBoxLocation.Text;
                category = cBoxCategory.Text;
                description = txtBoxDescription.Text;
                attachedFile = fileData; 

                if(controller.Report(location, category, description, attachedFile))
                {
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        form.WindowState = FormWindowState.Maximized;
                    }
                    else
                    {
                        form.Size = this.Size;
                        form.Location = this.Location;
                    }

                    form.Show();
                    this.Hide();
                    MessageBox.Show("Issue Reported");
                }
                else
                {
                    MessageBox.Show("Issue not Reported");
                }
            }
            else
            {
                if (!val.NotEmpty(txtBoxLocation.Text))
                {
                    lblLocationError.Text = "*This is a required field";
                }
                if (!val.ChoiceMade(cBoxCategory.SelectedIndex))
                {
                    lblCategoryError.Text = "*You must select a category";
                }
                if (!val.NotEmpty(txtBoxDescription.Text))
                {
                    lblDescriptionError.Text = "*This is a required field";
                }
                if (fileData == null || fileData.Length <= 0)
                {
                    lblAttachFileError.Text = "*You must attach a file";
                }
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Method to update the progress bar depending on the location textbox's value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxLocation_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBoxLocation.Text))
            {
                if (!locationChanged)
                {
                    progress++;
                    locationChanged = true;
                    UpdateProgressBar();
                }
            }
            else
            {
                if (progress > 0 && locationChanged)
                {
                    progress--;
                    locationChanged = false;
                    UpdateProgressBar();
                }
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Method to update the progress bar depending on the category combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxCategory.SelectedIndex >= 0)
            {
                if (!categorySelected)
                {
                    progress++;
                    categorySelected = true;
                    UpdateProgressBar();
                }
            }
            else
            {
                if (progress > 0 && categorySelected)
                {
                    progress--;
                    categorySelected = true;
                    UpdateProgressBar();
                }
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Method to update the progress bar depending on the description textbox's value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxDescription_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBoxDescription.Text))
            {
                if (!descriptionChanged)
                {
                    progress++;
                    descriptionChanged = true;
                    UpdateProgressBar();
                }
            }
            else
            {
                if (progress > 0 && descriptionChanged)
                {
                    progress--;
                    descriptionChanged = false;
                    UpdateProgressBar();
                }
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Ensures that the application is closed when the apllication is stopped when the form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportIssuesPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //----------------------------------------------------------Nav Menu------------------------------------------------------------
        private void btnToggleMenu_Click(object sender, EventArgs e)
        {
            timerMenu.Enabled = true;
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Timer method to open and close the panel smoothly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (isMenuCollapsed)
            {
                // Expand the menu
                panelMenu.Width += stepSize;
                if (panelMenu.Width >= menuWidth)
                {
                    // Stop expanding
                    timerMenu.Enabled = false;
                    panelMenu.Width = menuWidth; // Ensure exact size
                    isMenuCollapsed = false;
                }
            }
            else
            {
                // Collapse the menu
                panelMenu.Width -= stepSize;
                if (panelMenu.Width <= collapsedWidth)
                {
                    // Stop collapsing
                    timerMenu.Enabled = false;
                    panelMenu.Width = collapsedWidth; // Ensure exact size
                    isMenuCollapsed = true;
                }
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        private void navBtnIssue_Click(object sender, EventArgs e)
        {
            if (!isMenuCollapsed)
            {
                timerMenu.Enabled = true;
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        private void navBtnEvents_Click(object sender, EventArgs e)
        {
            EventsAndAnnouncements eventsAndAnnouncements = new EventsAndAnnouncements();

            if (this.WindowState == FormWindowState.Maximized)
            {
                eventsAndAnnouncements.WindowState = FormWindowState.Maximized;
            }
            else
            {
                eventsAndAnnouncements.Size = this.Size;
                eventsAndAnnouncements.Location = this.Location;
            }

            eventsAndAnnouncements.Show();
            this.Hide();
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        private void navBtnStatus_Click(object sender, EventArgs e)
        {
            RequestStatusPage requestStatusPage = new RequestStatusPage();

            if (this.WindowState == FormWindowState.Maximized)
            {
                requestStatusPage.WindowState = FormWindowState.Maximized;
            }
            else
            {
                requestStatusPage.Size = this.Size;
                requestStatusPage.Location = this.Location;
            }

            requestStatusPage.Show();
            this.Hide();
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        private void navBtnLogOut_Click(object sender, EventArgs e)
        {
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
        private void navBtnHome_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();

            if (this.WindowState == FormWindowState.Maximized)
            {
                form.WindowState = FormWindowState.Maximized;
            }
            else
            {
                form.Size = this.Size;
                form.Location = this.Location;
            }

            form.Show();
            this.Hide();
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        private void ReportIssuesPage_Click(object sender, EventArgs e)
        {
            if (!isMenuCollapsed)
            {
                timerMenu.Enabled = true;
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------
    }
}
//--------------------------------------------------End of Code------------------------------------------------------------
