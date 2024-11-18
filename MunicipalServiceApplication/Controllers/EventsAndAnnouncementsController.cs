using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalServiceApplication.Controllers
{
    public class EventsAndAnnouncementsController
    {
        //---------------------------------------------------------------------------------------------------------------------------------
        private DbHelper db;
        //---------------------------------------------------------------------------------------------------------------------------------
        // Data structures to manage events and announcements
        private SortedDictionary<DateTime, List<Event>> eventsByDate = new SortedDictionary<DateTime, List<Event>>();
        private SortedDictionary<DateTime, List<Announcement>> announcementsByDate = new SortedDictionary<DateTime, List<Announcement>>();
        //---------------------------------------------------------------------------------------------------------------------------------
        private Dictionary<string, List<Event>> eventsByCategory = new Dictionary<string, List<Event>>();
        //---------------------------------------------------------------------------------------------------------------------------------
        private HashSet<string> eventCategories = new HashSet<string>();
        //---------------------------------------------------------------------------------------------------------------------------------
        private Queue<Event> eventQueue = new Queue<Event>();
        private Queue<Announcement> announcementQueue = new Queue<Announcement>();
        //---------------------------------------------------------------------------------------------------------------------------------
        private SortedList<DateTime, Event> eventPriorityQueue = new SortedList<DateTime, Event>();
        private SortedList<DateTime, Announcement> announcementPriorityQueue = new SortedList<DateTime, Announcement>();
        //---------------------------------------------------------------------------------------------------------------------------------
        private Dictionary<string, int> userSearchPreferences = new Dictionary<string, int>();
        //---------------------------------------------------------------------------------------------------------------------------------
        public EventsAndAnnouncementsController()
        {
            db = new DbHelper();
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        public List<Event> GetEvents()
        {
            List<Event> events = db.GetEvents();

            return events;
        }

        public List<Announcement> GetAnnouncements()
        {
            List<Announcement> announcements = db.GetAnnouncements();

            return announcements;
        }

        public SortedDictionary<DateTime, List<Event>> GetEventsByDate()
        {
            return eventsByDate;
        }

        public HashSet<string> GetEventCategories()
        {
            return eventCategories;
        }

        public List<KeyValuePair<DateTime, List<Announcement>>> GetAnnouncementsByDate()
        {
            return announcementsByDate.OrderByDescending(a => a.Key).ToList();
        }

        public async void LoadSampleData()
        {
            List<Event> events = new List<Event>();
            List<Announcement> announcements = new List<Announcement>();
            db.ClearTable("Announcements");
            db.ClearTable("Events");

            events.Add(new Event("Music Concert", "Music", DateTime.Now.AddDays(2), "A live music concert at the city park."));
            events.Add(new Event("Art Exhibition", "Art", DateTime.Now.AddDays(5), "An art exhibition showcasing local talent at the gallery."));
            events.Add(new Event("Tech Conference", "Technology", DateTime.Now.AddDays(10), "A tech conference for developers covering the latest trends."));
            events.Add(new Event("Food Festival", "Food", DateTime.Now.AddDays(1), "A food festival featuring local chefs and cuisine."));
            events.Add(new Event("Charity Run", "Sports", DateTime.Now.AddDays(7), "Join the charity run to raise funds for community projects."));
            events.Add(new Event("Film Screening", "Entertainment", DateTime.Now.AddDays(4), "Outdoor film screening of a popular movie in the park."));
            events.Add(new Event("Book Fair", "Literature", DateTime.Now.AddDays(12), "A book fair with local authors and publishers."));
            events.Add(new Event("Yoga Retreat", "Health", DateTime.Now.AddDays(3), "A weekend yoga retreat for beginners and advanced practitioners."));
            events.Add(new Event("Career Workshop", "Education", DateTime.Now.AddDays(8), "A workshop on career development and job hunting tips."));
            events.Add(new Event("Jazz Night", "Music", DateTime.Now.AddDays(15), "Enjoy a relaxing evening of live jazz music."));

            announcements.Add(new Announcement("Water Outage Notice", "Water will be unavailable due to maintenance on April 10th.", DateTime.Now.AddDays(-2)));
            announcements.Add(new Announcement("New Community Center Opening", "The new community center will open on May 15th.", DateTime.Now.AddDays(-10)));
            announcements.Add(new Announcement("Road Closure", "Main Street will be closed for construction from April 14th to April 20th.", DateTime.Now.AddDays(-5)));
            announcements.Add(new Announcement("Library Renovation", "The city library will be closed for renovation from April 18th to May 5th.", DateTime.Now.AddDays(-3)));
            announcements.Add(new Announcement("Holiday Celebration", "Join us for a community holiday celebration on April 25th.", DateTime.Now));

            await db.InsertEvents(events);
            await db.InsertAnnouncement(announcements);

            SortEntries();
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Adds the event that is parsed to a queue and to the dictionary in the correct order, dependent on the date
        /// </summary>
        /// <param name="newEvent"></param>
        public void SortEvent(Event newEvent)
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
        public void SortAnnouncement(Announcement newAnnouncement)
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

        public void SortEntries()
        {
            foreach (Event e in GetEvents())
            {
                SortEvent(e);
            }

            foreach (Announcement a  in GetAnnouncements())
            {
                SortAnnouncement(a);
            }
        }
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
        /// Method to filter events by category and/or date
        /// </summary>
        /// <param name="category"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public IEnumerable<Event> FilterEventMethod(string category, DateTime date)
        {
            IEnumerable<Event> filteredEvents;

            if (category != null)
            {
                TrackSearchPreference(category);
            }

            if (date == DateTime.Today || date == null)
            {
                filteredEvents = GetEventsByDate()
                    .SelectMany(e => e.Value)
                    .Where(ev => category == null || ev.Category == category);
            }
            else
            {
                filteredEvents = GetEventsByDate()
                    .Where(e => e.Key.Date == date)
                    .SelectMany(e => e.Value)
                    .Where(ev => category == null || ev.Category == category);
            }

            filteredEvents =  filteredEvents.OrderBy(ev => ev.Date);

            return filteredEvents;
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Method to filter events by text representing title or descriptions
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<Event> FilterEvents(string input)
        {

            if (string.IsNullOrEmpty(input))
            {
                return GetEvents();
            }
            var searchResults = GetEvents()
            .Where(e => e.Title.ToLower().Contains(input) || e.Description.ToLower().Contains(input))
            .ToList();

            return searchResults;
        }
        //---------------------------------------------------------------------------------------------------------------------------------
    }
}
//--------------------------------------------------End of Code------------------------------------------------------------