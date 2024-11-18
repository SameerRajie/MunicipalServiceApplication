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
    public partial class Form1 : Form
    {
        /// <summary>
        /// Variable dictating the state of the nav panel
        /// </summary>
        private bool isMenuCollapsed = true; // Start in a collapsed state
        private int menuWidth = 250; // Full width of the menu
        private int collapsedWidth = 40; // Collapsed width of the menu
        private int stepSize = 30;
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Ensures that the nav panel starts collapsed
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            panelMenu.Width = collapsedWidth;
            timerMenu.Interval = 30;
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Button to Navigate to the page to report issues
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReportIssue_Click(object sender, EventArgs e)
        {
            ReportIssuesPage reportIssuesPage = new ReportIssuesPage();

            if (this.WindowState == FormWindowState.Maximized)
            {
                reportIssuesPage.WindowState = FormWindowState.Maximized;
            }
            else
            {
                reportIssuesPage.Size = this.Size;
                reportIssuesPage.Location = this.Location;
            }

            reportIssuesPage.Show();
            this.Hide();
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Ensures that the application is stopped when the form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Buttons to Navigate to the events and announcements page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
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
        /// <summary>
        /// Button to navigate to the Request Status page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
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
        /// <summary>
        /// Methods to change the colours of the buttons based on if the mouse is hovered over it or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Green;
        }

        private void btnReportIssue_MouseHover(object sender, EventArgs e)
        {
            btnReportIssue.BackColor = Color.Red;
        }

        private void btnReportIssue_MouseLeave(object sender, EventArgs e)
        {
            btnReportIssue.BackColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Blue;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.White;
        }
        //---------------------------------------------------------------------------------------------------------------------------------

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
        private void tableLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isMenuCollapsed)
            {
                timerMenu.Enabled = true;
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        private void navBtnIssue_Click(object sender, EventArgs e)
        {
            ReportIssuesPage reportIssuesPage = new ReportIssuesPage();

            if (this.WindowState == FormWindowState.Maximized)
            {
                reportIssuesPage.WindowState = FormWindowState.Maximized;
            }
            else
            {
                reportIssuesPage.Size = this.Size;
                reportIssuesPage.Location = this.Location;
            }

            reportIssuesPage.Show();
            this.Hide();
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
            if (!isMenuCollapsed)
            {
                timerMenu.Enabled = true;
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------
    }
}
//--------------------------------------------------End of Code------------------------------------------------------------