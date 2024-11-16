using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServiceApplication
{
    internal class BSTNode
    {
        public IssueReport Data { get; set; }
        public BSTNode Left { get; set; }
        public BSTNode Right { get; set; }

        public BSTNode(IssueReport data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

    public class BinarySearchTree
    {
        private BSTNode root;
        private readonly IssueComparer comparer = new IssueComparer();

        // Insert Method
        public void Insert(IssueReport issue)
        {
            root = Insert(root, issue);
        }

        private BSTNode Insert(BSTNode node, IssueReport issue)
        {
            if (node == null)
                return new BSTNode(issue);

            int comparison = comparer.Compare(issue, node.Data);

            if (comparison < 0)
                node.Left = Insert(node.Left, issue);
            else if (comparison > 0)
                node.Right = Insert(node.Right, issue);

            return node;
        }

        // Search Method
        public IEnumerable<IssueReport> Search(string searchInput)
        {
            var results = new List<IssueReport>();
            Search(root, searchInput, results);
            return results;
        }

        private void Search(BSTNode node, string searchInput, List<IssueReport> results)
        {
            if (node == null) return;

            // Convert searchInput to lowercase for a case-insensitive comparison
            string lowerSearchInput = searchInput.ToLower();

            // Check if any field matches the search input (with null checks)
            if ((node.Data.Location?.ToLower().Contains(lowerSearchInput) ?? false) ||
                (node.Data.Category?.ToLower().Contains(lowerSearchInput) ?? false) ||
                (node.Data.Description?.ToLower().Contains(lowerSearchInput) ?? false))
            {
                results.Add(node.Data);
            }

            // Recursively search left and right subtrees
            Search(node.Left, lowerSearchInput, results);
            Search(node.Right, lowerSearchInput, results);
        }

        // InOrder Traversal (For displaying all nodes)
        public void TraverseInOrder(Action<IssueReport> action)
        {
            TraverseInOrder(root, action);
        }

        private void TraverseInOrder(BSTNode node, Action<IssueReport> action)
        {
            if (node == null) return;

            TraverseInOrder(node.Left, action);
            action(node.Data);
            TraverseInOrder(node.Right, action);
        }
    }
}
