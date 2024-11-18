using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServiceApplication
{
    public class StatusGraph
    {
        private readonly Dictionary<string, List<IssueReport>> adjacencyList;

        public StatusGraph()
        {
            adjacencyList = new Dictionary<string, List<IssueReport>>();
        }

        // Add a status node to the graph
        public void AddStatus(string status)
        {
            if (!adjacencyList.ContainsKey(status))
            {
                adjacencyList[status] = new List<IssueReport>();
            }
        }

        // Add a service request under a specific status
        public void AddRequest(string status, IssueReport request)
        {
            if (adjacencyList.ContainsKey(status))
            {
                adjacencyList[status].Add(request);
            }
        }

        // Perform a topological sort to display statuses in the correct order
        public List<IssueReport> TraverseStatusesInOrder(List<string> statusOrder)
        {
            List<IssueReport> sortedRequests = new List<IssueReport>();

            foreach (string status in statusOrder)
            {
                if (adjacencyList.ContainsKey(status))
                {
                    sortedRequests.AddRange(adjacencyList[status]);
                }
            }

            return sortedRequests;
        }
    }

}
