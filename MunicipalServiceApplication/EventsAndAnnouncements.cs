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
        // Data structures to manage events and announcements
        private SortedDictionary<DateTime, List<Event>> eventsByDate = new SortedDictionary<DateTime, List<Event>>();
        private SortedDictionary<DateTime, List<Announcement>> announcementsByDate = new SortedDictionary<DateTime, List<Announcement>>();

        private Dictionary<string, List<Event>> eventsByCategory = new Dictionary<string, List<Event>>();

        private HashSet<string> eventCategories = new HashSet<string>();

        private Queue<Event> eventQueue = new Queue<Event>();
        private Queue<Announcement> announcementQueue = new Queue<Announcement>();

        private SortedList<DateTime, Event> eventPriorityQueue = new SortedList<DateTime, Event>();
        private SortedList<DateTime, Announcement> announcementPriorityQueue = new SortedList<DateTime, Announcement>();

        private Dictionary<string, int> userSearchPreferences = new Dictionary<string, int>();
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Calls methods necessary when the page is first loaded
        /// </summary>
        public EventsAndAnnouncements()
        {
            InitializeComponent();
            ListViewLayout();
            LoadSampleData();
            DisplayAllEvents();
            DisplayAllAnnouncements();
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Method to load the events and announcements for the prototype of the app
        /// </summary>
        public void LoadSampleData()
        {
            AddEvent(new Event("Music Concert", "Music", DateTime.Now.AddDays(2), "A live music concert at the city park."));
            AddEvent(new Event("Art Exhibition", "Art", DateTime.Now.AddDays(5), "An art exhibition showcasing local talent at the gallery."));
            AddEvent(new Event("Tech Conference", "Technology", DateTime.Now.AddDays(10), "A tech conference for developers covering the latest trends."));
            AddEvent(new Event("Food Festival", "Food", DateTime.Now.AddDays(1), "A food festival featuring local chefs and cuisine."));
            AddEvent(new Event("Charity Run", "Sports", DateTime.Now.AddDays(7), "Join the charity run to raise funds for community projects."));
            AddEvent(new Event("Film Screening", "Entertainment", DateTime.Now.AddDays(4), "Outdoor film screening of a popular movie in the park."));
            AddEvent(new Event("Book Fair", "Literature", DateTime.Now.AddDays(12), "A book fair with local authors and publishers."));
            AddEvent(new Event("Yoga Retreat", "Health", DateTime.Now.AddDays(3), "A weekend yoga retreat for beginners and advanced practitioners."));
            AddEvent(new Event("Career Workshop", "Education", DateTime.Now.AddDays(8), "A workshop on career development and job hunting tips."));
            AddEvent(new Event("Jazz Night", "Music", DateTime.Now.AddDays(15), "Enjoy a relaxing evening of live jazz music."));

            AddAnnouncement(new Announcement("Water Outage Notice", "Water will be unavailable due to maintenance on April 10th.", DateTime.Now.AddDays(-2)));
            AddAnnouncement(new Announcement("New Community Center Opening", "The new community center will open on May 15th.", DateTime.Now.AddDays(-10)));
            AddAnnouncement(new Announcement("Road Closure", "Main Street will be closed for construction from April 14th to April 20th.", DateTime.Now.AddDays(-5)));
            AddAnnouncement(new Announcement("Library Renovation", "The city library will be closed for renovation from April 18th to May 5th.", DateTime.Now.AddDays(-3)));
            AddAnnouncement(new Announcement("Holiday Celebration", "Join us for a community holiday celebration on April 25th.", DateTime.Now));
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
        /// Adds the event that is parsed to a queue and to the dictionary in the correct order, dependent on the date
        /// </summary>
        /// <param name="newEvent"></param>
        public void AddEvent(Event newEvent)
        {
            if (!eventsByDate.ContainsKey(newEvent.Date))
            {
                eventsByDate[newEvent.Date] = new List<Event>();
            }
            eventsByDate[newEvent.Date].Add(newEvent);

            if (!eventsByCategory.ContainsKey(newEvent.Category))
            {
                eventsByCategory[newEvent.Category] = new List<Event>();
            }
            eventsByCategory[newEvent.Category].Add(newEvent);

            eventCategories.Add(newEvent.Category);

            eventPriorityQueue.Add(newEvent.Date, newEvent);
            eventQueue.Enqueue(newEvent);
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Adds the announcement that is parsed to a queue and to the dictionary in the correct order, dependent on the date
        /// </summary>
        /// <param name="newAnnouncement"></param>
        public void AddAnnouncement(Announcement newAnnouncement)
        {
            if (!announcementsByDate.ContainsKey(newAnnouncement.PublishDate))
            {
                announcementsByDate[newAnnouncement.PublishDate] = new List<Announcement>();
            }
            announcementsByDate[newAnnouncement.PublishDate].Add(newAnnouncement);

            announcementPriorityQueue.Add(newAnnouncement.PublishDate, newAnnouncement);
            announcementQueue.Enqueue(newAnnouncement);
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Method to display all the events that are after today in ascending date order and adjust the list view accordingly
        /// </summary>
        public void DisplayAllEvents()
        {
            lViewEvents.Items.Clear();

            lViewEvents.Items.Add("");

            foreach (var eventGroup in eventsByDate)
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
            cBoxEventsCategory.Items.AddRange(eventCategories.ToArray());
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Method to display all the announcements in order from the nearest date added to the furthest and adjust the list view accordingly
        /// </summary>
        public void DisplayAllAnnouncements()
        {
            lViewAnnouncements.Items.Clear();

            lViewAnnouncements.Items.Add("");

            var sortedAnnouncementGroups = announcementsByDate.OrderByDescending(a => a.Key).ToList();

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
        /// Tracks how many times a category has been selected for filtering
        /// </summary>
        /// <param name="category"></param>
        public void TrackSearchPreference(string category)
        {
            if (userSearchPreferences.ContainsKey(category))
            {
                userSearchPreferences[category]++;
            }
            else
            {
                userSearchPreferences[category] = 1;
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Sorts the categories by what category was selected the most, then get the events from those categories and returns the list
        /// </summary>
        /// <returns></returns>
        public List<Event> RecommendEvents()
        {
            var mostSearchedCategories = userSearchPreferences
                .OrderByDescending(entry => entry.Value) 
                .Select(entry => entry.Key)         
                .ToList();

            List<Event> recommendedEvents = new List<Event>();

            foreach (var category in mostSearchedCategories)
            {
                var eventsInCategory = GetEventsByCategory(category)
                    .OrderBy(e => e.Date) 
                    .ToList();

                recommendedEvents.AddRange(eventsInCategory);
            }

            return recommendedEvents.ToList();
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Displays the recommendations in the Events list view with a heading, limiting it to 5 and not allowing any repeats
        /// </summary>
        public void DisplayRecommendations()
        {
            List<Event> recommendedEvents = RecommendEvents();

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

            IEnumerable<Event> filteredEvents;

            if (selectedCategory != null)
            {
                TrackSearchPreference(selectedCategory);
            }

            if (selectedDate == DateTime.Today || selectedDate == null)
            {
                filteredEvents = eventsByDate
                    .SelectMany(e => e.Value)  
                    .Where(ev => selectedCategory == null || ev.Category == selectedCategory); 
            }
            else
            {
                filteredEvents = eventsByDate
                    .Where(e => e.Key.Date == selectedDate) 
                    .SelectMany(e => e.Value)
                    .Where(ev => selectedCategory == null || ev.Category == selectedCategory); 
            }

            filteredEvents = filteredEvents.OrderBy(ev => ev.Date);

            lViewEvents.Items.Clear();

            lViewEvents.Items.Add("");

            foreach (var e in filteredEvents)
            {
                var listItem = new ListViewItem(new[] { e.Title, e.Category, e.Date.ToShortDateString(), e.Description });
                lViewEvents.Items.Add(listItem);
            }

            if (lViewEvents.Items.Count <= 0)
            {
                MessageBox.Show("No events found for the selected date and category.");
            }

            DisplayRecommendations();

            AdjustListViewHeight(lViewEvents);
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Method that returns a list of events based on a category
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public List<Event> GetEventsByCategory(string category)
        {
            return eventsByCategory.ContainsKey(category) ? eventsByCategory[category] : new List<Event>();
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Button to send the user back to the main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnToMenu_Click(object sender, EventArgs e)
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
        /// <summary>
        /// Method to Reset the filter conditions for the events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResetEvents_Click(object sender, EventArgs e)
        {
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
        /// Navigation button to send the user back to the Report issue page 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EventsBtn_Click(object sender, EventArgs e)
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
        /// Button to show a message that this feature is not implemented yet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RequestBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To Be Implemented");
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
        //---------------------------------------------------------------------------------------------------------------------------------
    }
}
//--------------------------------------------------End of Code------------------------------------------------------------
