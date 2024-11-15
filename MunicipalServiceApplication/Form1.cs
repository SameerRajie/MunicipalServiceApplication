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
        public Form1()
        {
            InitializeComponent();
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
        /// Buttons to show that these still need to be implemented
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

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To Be Implemented");
        }

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
    }
}
//--------------------------------------------------End of Code------------------------------------------------------------