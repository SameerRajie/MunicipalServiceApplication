﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServiceApplication
{
    public class Event
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public Event(string title, string category, DateTime date, string description)
        {
            Title = title;
            Category = category;
            Date = date;
            Description = description;
        }
    }
}
