using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalServiceApplication
{
    public partial class RequestStatusPage : Form
    {
        private BinarySearchTree bst;

        public RequestStatusPage()
        {
            InitializeComponent();

            // Initialize Binary Search Tree
            bst = new BinarySearchTree();

            InitializeDataGridView();

            // Add sample data
            AddSampleData();

            // Display all requests in DataGridView
            DisplayAllRequests();
        }

        private void InitializeDataGridView()
        {
            // Clear any existing columns
            dataGridView1.Columns.Clear();

            // Define columns
            var locationColumn = new DataGridViewTextBoxColumn
            {
                Name = "LocationColumn",
                HeaderText = "Location",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 150, // Fixed width
                ReadOnly = true
            };

            var categoryColumn = new DataGridViewTextBoxColumn
            {
                Name = "CategoryColumn",
                HeaderText = "Category",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 150, // Fixed width
                ReadOnly = true
            };

            var descriptionColumn = new DataGridViewTextBoxColumn
            {
                Name = "DescriptionColumn",
                HeaderText = "Description",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, // Fills the remaining space
                ReadOnly = true
            };

            var statusColumn = new DataGridViewTextBoxColumn
            {
                Name = "StatusColumn",
                HeaderText = "Status",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 100, // Fixed width
                ReadOnly = true
            };

            // Add columns to the DataGridView
            dataGridView1.Columns.Add(locationColumn);
            dataGridView1.Columns.Add(categoryColumn);
            dataGridView1.Columns.Add(descriptionColumn);
            dataGridView1.Columns.Add(statusColumn);


            // Set AutoGenerateColumns to false
            dataGridView1.AutoGenerateColumns = false;
        }

        private void AddSampleData()
        {
            bst.Insert(new IssueReport(1, "Main Street", "Street Lighting", "Broken streetlight near house #24", null, "Pending", 1));
            bst.Insert(new IssueReport(2, "Park Avenue", "Garbage Collection", "Uncollected garbage near the park entrance", null, "In Progress", 2));
            bst.Insert(new IssueReport(3, "Elm Street", "Road Maintenance", "Pothole on the main road near Elm Street", null, "Resolved", 3));
        }

        private void DisplayAllRequests()
        {
            dataGridView1.Rows.Clear();

            // Traverse the BST and populate DataGridView
            bst.TraverseInOrder(request =>
            {
                dataGridView1.Rows.Add(request.Location, request.Category, request.Description, request.Status);
            });
        }

        private bool SearchList(string searchInput)
        {
            // Clear the DataGridView
            dataGridView1.Rows.Clear();

            // Search the BST and display results
            var results = bst.Search(searchInput.ToLower());

            foreach (var result in results)
            {
                dataGridView1.Rows.Add(result.Location, result.Category, result.Description, result.Status);
            }

            return results.Any();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchInput = txtBoxSearch.Text.Trim();

            if (!SearchList(searchInput))
            {
                MessageBox.Show("No matching service requests found.");
            }
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchList(txtBoxSearch.Text.Trim());
        }
    }
}
