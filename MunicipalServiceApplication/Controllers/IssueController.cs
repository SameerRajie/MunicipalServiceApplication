using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServiceApplication.Controllers
{
    public class IssueController
    {
        private DbHelper db;

        public IssueController()
        {
            db = new DbHelper();
        }

        public bool Report(string location, string category, string description, byte[] attachedFile)
        {
            IssueReport report = new IssueReport(0, location, category, description, attachedFile, "Pending", 10);
            int userId = GetSet.userId;
            return db.AddIssue(report, userId);
        }

        public List<IssueReport> GetReports(int userId)
        {
            List<IssueReport> reportList = db.GetIssues(userId);

            return reportList;
        }

        public void GenerateDummyData(int userId)
        {
            db.ClearTable("Issues");

            var dummyData = new List<IssueReport>
            {
                new IssueReport(1, "Main Street", "Street Light", "Street light not working in front of the park", null, "In Progress", 2),
                new IssueReport(2, "Elm Road", "Pothole", "Large pothole near the intersection", null, "Pending", 5),
                new IssueReport(3, "Pine Avenue", "Waste Collection", "Garbage not picked up last week", null, "Resolved", 1),
                new IssueReport(4, "Greenfield Park", "Graffiti", "Graffiti on the park's main gate", null, "In Progress", 3),
                new IssueReport(5, "Oak Lane", "Street Light", "Street light flickering intermittently", null, "Pending", 4),
                new IssueReport(6, "Birch Crescent", "Road Repair", "Crack in the road near the pedestrian crossing", null, "Resolved", 2),
                new IssueReport(7, "Maple Street", "Water Leak", "Water leaking from underground pipe", null, "In Progress", 5),
                new IssueReport(8, "Sunset Boulevard", "Pothole", "Pothole on the main road", null, "Pending", 3),
                new IssueReport(9, "Cedar Avenue", "Waste Collection", "Garbage truck missed my area last Tuesday", null, "Resolved", 1),
                new IssueReport(10, "Rosewood Lane", "Graffiti", "Graffiti on the bus stop", null, "Pending", 4)
            };

            foreach (IssueReport report in dummyData)
            {
                db.AddIssue(report, userId);
            }
        }
    }
}
