﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServiceApplication
{
    internal class IssueReport
    {
        public IssueReport(int id, string location, string category, string description, byte[] attachedFile)
        {
            Id = id;
            Location = location;
            Category = category;
            Description = description;
            AttachedFile = attachedFile;
        }

        public int Id { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public byte[] AttachedFile { get; set; }
    }
}
