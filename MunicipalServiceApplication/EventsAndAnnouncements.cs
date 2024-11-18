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
    public partial class EventsAndAnnouncements : Form
    {
        //---------------------------------------------------------------------------------------------------------------------------------
        private bool isMenuCollapsed = true; // Start in a collapsed state
        private int menuWidth = 250; // Full width of the menu
        private int collapsedWidth = 40; // Collapsed width of the menu
        private int stepSize = 30;

        private EventsAndAnnouncementsController controller;
        /// <summary>
        /// Calls methods necessary when the page is first loaded
        /// </summary>
        public EventsAndAnnouncements()
        {
            InitializeComponent();
            controller = new EventsAndAnnouncementsController();
            ListViewLayout();
            controller.LoadSampleData();
            DisplayAllEvents();
            DisplayAllAnnouncements();

            panelMenu.Width = collapsedWidth;
            timerMenu.Interval = 30;
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Sets the layouts of the list views to align with what is necessary, including headings
        /// </summary>
        public void ListViewLayout()
        {
            lViewEvents.View = View.Details;
            lViewAnnouncements.View = View.Details;

            lViewEvents.Columns.Add("Title", 150);
            lViewEvents.Columns.Add("Category", 100); 
            lViewEvents.Columns.Add("Date", 100); 
            lViewEvents.Columns.Add("Description", -2); 

            lViewAnnouncements.Columns.Add("Title", 150);
            lViewAnnouncements.Columns.Add("Date Added", 100);
            lViewAnnouncements.Columns.Add("Content", -2);

            lViewEvents.GridLines = true;
            lViewAnnouncements.GridLines = true;
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Ensures that the parsed list's dimensions are limited in the way that we intend it to
        /// </summary>
        /// <param name="listView"></param>
        public void AdjustListViewHeight(ListView listView)
        {
            int itemHeight = listView.Items.Count > 0 ? listView.Items[0].Bounds.Height : 0;

            int totalHeight = itemHeight * listView.Items.Count + listView.HeaderStyle == ColumnHeaderStyle.None ? 0 : 25;

            listView.Height = totalHeight + 10;

            if (listView == lViewEvents)
            {
                int totalWidth = 0;
                foreach (ColumnHeader column in listView.Columns)
                {
                    int columnWidth = column.Width; 
                    foreach (ListViewItem item in listView.Items)
                    {
                        if (item.SubItems.Count > column.Index)
                        {
                            Size textSize = TextRenderer.MeasureText(item.SubItems[column.Index].Text, listView.Font);
                            if (textSize.Width > columnWidth)
                            {
                                columnWidth = textSize.Width;
                            }
                        }
                    }
                    totalWidth += columnWidth;
                }

                totalWidth += 20;
                listView.Width = totalWidth;
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Method to display all the events that are after today in ascending date order and adjust the list view accordingly
        /// </summary>
        public void DisplayAllEvents()
        {
            lViewEvents.Items.Clear();

            lViewEvents.Items.Add("");

            foreach (var eventGroup in controller.GetEventsByDate())
            {
                if (eventGroup.Key >= DateTime.Today)
                {
                    foreach (var e in eventGroup.Value)
                    {
                        var listItem = new ListViewItem(new[] { e.Title, e.Category, e.Date.ToShortDateString(), e.Description });
                        lViewEvents.Items.Add(listItem);
                    }
                }
            }

            AdjustListViewHeight(lViewEvents);

            cBoxEventsCategory.Items.Clear();
            cBoxEventsCategory.Items.AddRange(controller.GetEventCategories().ToArray());
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Method to display all the announcements in order from the nearest date added to the furthest and adjust the list view accordingly
        /// </summary>
        public void DisplayAllAnnouncements()
        {
            lViewAnnouncements.Items.Clear();

            lViewAnnouncements.Items.Add("");

            var sortedAnnouncementGroups = controller.GetAnnouncementsByDate();

            foreach (var announcementGroup in sortedAnnouncementGroups)
            {
                foreach (var announcement in announcementGroup.Value)
                {
                    var listItem = new ListViewItem(new[] { announcement.Title, announcement.PublishDate.ToShortDateString(), announcement.Content });
                    lViewAnnouncements.Items.Add(listItem);
                }
            }

            AdjustListViewHeight(lViewAnnouncements);

        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Displays the recommendations in the Events list view with a heading, limiting it to 5 and not allowing any repeats
        /// </summary>
        public void DisplayRecommendations()
        {
            List<Event> recommendedEvents = controller.RecommendEvents();

            var emptySpace = new ListViewItem("");
            lViewEvents.Items.Add(emptySpace);

            var listTitle = new ListViewItem("Suggested:");
            lViewEvents.Items.Add(listTitle);

            int counter = 0;

            foreach (var eventItem in recommendedEvents)
            {
                bool isEventInListView = lViewEvents.Items.Cast<ListViewItem>()
                    .Any(item => item.SubItems[0].Text == eventItem.Title &&
                                 item.SubItems[1].Text == eventItem.Category &&
                                 item.SubItems[2].Text == eventItem.Date.ToShortDateString());

                if (!isEventInListView)
                {
                    var listItem = new ListViewItem(new[]
                    {
                        eventItem.Title,
                        eventItem.Category,
                        eventItem.Date.ToShortDateString(),
                        eventItem.Description
                    });

                    lViewEvents.Items.Add(listItem);

                    counter++;
                }
                if (counter == 5)
                {
                    break;
                }
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Filters the events list by either categories, dates, or both. Then displays it with the recommendations
        /// </summary>
        public void FilterEvents()
        {
            string selectedCategory = cBoxEventsCategory.SelectedItem?.ToString();
            DateTime selectedDate = dPickerEvents.Value.Date; 

            IEnumerable<Event> filteredEvents = controller.FilterEventMethod(selectedCategory, selectedDate);

            lViewEvents.Items.Clear();

            lViewEvents.Items.Add("");

            foreach (var e in filteredEvents)
            {
                var listItem = new ListViewItem(new[] { e.Title, e.Category, e.Date.ToShortDateString(), e.Description });
                lViewEvents.Items.Add(listItem);
            }

            if (lViewEvents.Items.Count <= 0)
            {
                MessageBox.Show("No events found for the criteria.");
            }

            DisplayRecommendations();

            AdjustListViewHeight(lViewEvents);
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Method to Reset the filter conditions for the events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResetEvents_Click(object sender, EventArgs e)
        {
            txtBoxSearch.Text = String.Empty;
            cBoxEventsCategory.SelectedIndex = -1;
            dPickerEvents.Value = DateTime.Now; 

            DisplayAllEvents();
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Filters the list of events when the combo box selection is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cBoxEventsCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterEvents();
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Filters the list of events when the date selection is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dPickerEvents_ValueChanged(object sender, EventArgs e)
        {
            FilterEvents();
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Ensures that after the form is closed, the application shuts down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EventsAndAnnouncements_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Searches events by title or description and displays the results.
        /// </summary>
        private void SearchEvents()
        {
            string query = txtBoxSearch.Text.Trim().ToLower();

            List<Event> searchResults = new List<Event>();
            searchResults = controller.FilterEvents(query);

            lViewEvents.Items.Clear();

            if (searchResults != null ||searchResults.Count > 0)
            {
                foreach (var e in searchResults)
                {
                    var listItem = new ListViewItem(new[] { e.Title, e.Category, e.Date.ToShortDateString(), e.Description });
                    lViewEvents.Items.Add(listItem);
                }
            }
            else
            {
                MessageBox.Show("No events found matching your search query.");
            }

            DisplayRecommendations();

            AdjustListViewHeight(lViewEvents);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBoxSearch.Text))
            {
                MessageBox.Show("Please enter a search term.");
            }
            SearchEvents();
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchEvents();
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Ensures that when the size of the form is changed, the list views are set to the desired size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EventsAndAnnouncements_SizeChanged(object sender, EventArgs e)
        {
            AdjustListViewHeight(lViewEvents);
            AdjustListViewHeight(lViewAnnouncements);
        }

        //----------------------------------------------------------Nav Menu------------------------------------------------------------
        private void btnToggleMenu_Click(object sender, EventArgs e)
        {
            timerMenu.Enabled = true;
        }

        private void timerMenu_Tick_1(object sender, EventArgs e)
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

        private void navBtnIssue_Click(object sender, EventArgs e)
        {
            ReportIssuesPage reportIssue = new ReportIssuesPage();

            if (this.WindowState == FormWindowState.Maximized)
            {
                reportIssue.WindowState = FormWindowState.Maximized;
            }
            else
            {
                reportIssue.Size = this.Size;
                reportIssue.Location = this.Location;
            }

            reportIssue.Show();
            this.Hide();
        }

        private void navBtnEvents_Click(object sender, EventArgs e)
        {
            if (!isMenuCollapsed)
            {
                timerMenu.Enabled = true;
            }
        }

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

        private void EventsAndAnnouncements_Click(object sender, EventArgs e)
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
