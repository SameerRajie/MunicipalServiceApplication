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
            IssueReport report = new IssueReport(0, location, category, description, attachedFile, "Pending", 0);
            int userId = GetSet.userId;
            return db.AddIssue(report, userId);
        }

        public List<IssueReport> GetReports(int userId)
        {
            List<IssueReport> reportList = new List<IssueReport>();

            reportList = db.GetIssues(userId);

            return reportList;
        }
    }
}
