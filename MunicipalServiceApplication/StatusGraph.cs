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
        private readonly AVLTree<string> statusOrderTree;

        public StatusGraph()
        {
            adjacencyList = new Dictionary<string, List<IssueReport>>();
            statusOrderTree = new AVLTree<string>();
        }

        // Add a status node to the graph
        public void AddStatus(string status)
        {
            if (!adjacencyList.ContainsKey(status))
            {
                adjacencyList[status] = new List<IssueReport>();
                statusOrderTree.Insert(status); // Add status to AVL Tree
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

        // Perform a topological traversal of the statuses using AVL tree order
        public List<IssueReport> TraverseStatusesInOrder()
        {
            List<IssueReport> sortedRequests = new List<IssueReport>();

            // Get statuses in order from AVL Tree
            List<string> sortedStatuses = statusOrderTree.InOrder();

            // Collect requests for each status
            foreach (string status in sortedStatuses)
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
