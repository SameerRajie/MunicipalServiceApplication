using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServiceApplication
{
    public class Announcement
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; } // When the announcement is published

        public Announcement(string title, string content, DateTime publishDate)
        {
            Title = title;
            Content = content;
            PublishDate = publishDate;
        }
    }
}
