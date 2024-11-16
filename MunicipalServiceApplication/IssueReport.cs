using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServiceApplication
{
    public class IssueReport
    {
        public IssueReport(int id, string location, string category, string description, byte[] attachedFile, string status, int priority)
        {
            Id = id;
            Location = location;
            Category = category;
            Description = description;
            AttachedFile = attachedFile;
            Status = status;
            Priority = priority;
        }

        public int Id { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public byte[] AttachedFile { get; set; }
        public string Status { get; set; }
        public int Priority { get; set; }
    }
}
