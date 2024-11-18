using MunicipalServiceApplication.Controllers;
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
        private IssueController issueController;

        private bool isMenuCollapsed = true; // Start in a collapsed state
        private int menuWidth = 250; // Full width of the menu
        private int collapsedWidth = 40; // Collapsed width of the menu
        private int stepSize = 30;

        public RequestStatusPage()
        {
            InitializeComponent();

            // Initialize Binary Search Tree
            bst = new BinarySearchTree();

            issueController = new IssueController();

            InitializeDataGridView();

            AddData();

            InitializeComboBox();

            // Display all requests in DataGridView
            DisplayAllRequests();

            panelMenu.Width = collapsedWidth;
            timerMenu.Interval = 30;
        }

        private void InitializeDataGridView()
        {
            // Clear any existing columns
            dataGridView1.Columns.Clear();

            // Define columns
            var idColumn = new DataGridViewTextBoxColumn
            {
                Name = "IdColumn",
                HeaderText = "ID",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 50, // Fixed width
                ReadOnly = true
            };
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

            var priorityColumn = new DataGridViewTextBoxColumn
            {
                Name = "PriorityColumn",
                HeaderText = "Priority",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 50, // Fixed width
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
            dataGridView1.Columns.Add(idColumn);
            dataGridView1.Columns.Add(locationColumn);
            dataGridView1.Columns.Add(categoryColumn);
            dataGridView1.Columns.Add(descriptionColumn);
            dataGridView1.Columns.Add(priorityColumn);
            dataGridView1.Columns.Add(statusColumn);


            // Set AutoGenerateColumns to false
            dataGridView1.AutoGenerateColumns = false;
        }

        private void AddData()
        {
            foreach (IssueReport report in issueController.GetReports(GetSet.userId))
            {
                bst.Insert(report);
            }
        }

        private void DisplayAllRequests()
        {
            dataGridView1.Rows.Clear();

            string sortBy = cBoxSort.SelectedItem.ToString();

            // Option 1: Sort by Priority
            if (sortBy == "Priority")
            {
                // Min-Heap to sort requests by priority
                SortedSet<IssueReport> priorityHeap = new SortedSet<IssueReport>(
                    Comparer<IssueReport>.Create((r1, r2) =>
                    {
                        if (r1.Priority == r2.Priority)
                        {
                            return r1.Id.CompareTo(r2.Id); // Tie-breaker by ID
                        }
                        return r1.Priority.CompareTo(r2.Priority); // Sort by priority
                    })
                );

                // Traverse BST and add to heap
                bst.TraverseInOrder(request =>
                {
                    priorityHeap.Add(request);
                });

                // Display sorted by priority
                foreach (var request in priorityHeap)
                {
                    AddRequestToGrid(request);
                }
            }
            // Option 2: Sort by Status
            else if (sortBy == "Status")
            {
                // Create the graph and define the status order
                StatusGraph statusGraph = new StatusGraph();

                // Define the valid statuses in their desired order
                List<string> statusOrder = new List<string> { "in progress", "pending", "resolved" };

                // Add statuses as nodes in the graph
                foreach (string status in statusOrder)
                {
                    statusGraph.AddStatus(status);
                }

                // Traverse the BST and add requests to the graph
                bst.TraverseInOrder(request =>
                {
                    statusGraph.AddRequest(request.Status.ToLower(), request);
                });

                // Perform a topological traversal of the statuses
                List<IssueReport> sortedRequests = statusGraph.TraverseStatusesInOrder(statusOrder);

                // Display the sorted requests in the DataGridView
                foreach (var request in sortedRequests)
                {
                    AddRequestToGrid(request);
                }
            }
        }

        // Helper method to add a request to the DataGridView
        private void AddRequestToGrid(IssueReport request)
        {
            int rowIndex = dataGridView1.Rows.Add(request.Id, request.Location, request.Category, request.Description, request.Priority, request.Status);
            var row = dataGridView1.Rows[rowIndex];

            // Change background color based on status
            switch (request.Status.ToLower())
            {
                case "resolved":
                    row.Cells["StatusColumn"].Style.BackColor = Color.Green;
                    row.Cells["StatusColumn"].Style.ForeColor = Color.White;
                    break;
                case "in progress":
                    row.Cells["StatusColumn"].Style.BackColor = Color.Yellow;
                    row.Cells["StatusColumn"].Style.ForeColor = Color.Black;
                    break;
                case "pending":
                    row.Cells["StatusColumn"].Style.BackColor = Color.Red;
                    row.Cells["StatusColumn"].Style.ForeColor = Color.White;
                    break;
            }
        }


        private bool SearchList(string searchInput)
        {
            // Clear the DataGridView
            dataGridView1.Rows.Clear();

            // Search the BST and display results
            var results = bst.Search(searchInput.ToLower());

            foreach (var result in results)
            {
                AddRequestToGrid(result);
            }

            return results.Any();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchInput = txtBoxSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchInput) || string.IsNullOrWhiteSpace(searchInput))
            {
                MessageBox.Show("Please input a search value in Text Box.");
            }
            if (!SearchList(searchInput))
            {
                MessageBox.Show("No matching service requests found.");
            }
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchList(txtBoxSearch.Text.Trim());
        }

        private void RequestStatusPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void InitializeComboBox()
        {
            cBoxSort.Items.Add("Priority");
            cBoxSort.Items.Add("Status");
            cBoxSort.SelectedIndex = 0; // Default to "Sort by Priority"
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayAllRequests();
        }

        //----------------------------------------------------------Nav Menu------------------------------------------------------------
        private void btnToggleMenu_Click(object sender, EventArgs e)
        {
            timerMenu.Enabled = true;
        }

        private void navBtnIssue_Click(object sender, EventArgs e)
        {
            ReportIssuesPage reportIssue = new ReportIssuesPage();

            if (this.WindowState == FormWindowState.Maximized)
            {
                reportIssue.WindowState = FormWindowState.Maximized;
            }
            else
            {
                reportIssue.Size = this.Size;
                reportIssue.Location = this.Location;
            }

            reportIssue.Show();
            this.Hide();
        }

        private void navBtnEvents_Click(object sender, EventArgs e)
        {
            EventsAndAnnouncements eventsAndAnnouncements = new EventsAndAnnouncements();

            if (this.WindowState == FormWindowState.Maximized)
            {
                eventsAndAnnouncements.WindowState = FormWindowState.Maximized;
            }
            else
            {
                eventsAndAnnouncements.Size = this.Size;
                eventsAndAnnouncements.Location = this.Location;
            }

            eventsAndAnnouncements.Show();
            this.Hide();
        }

        private void navBtnStatus_Click(object sender, EventArgs e)
        {
            if (!isMenuCollapsed)
            {
                timerMenu.Enabled = true;
            }
        }

        private void navBtnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();

            if (this.WindowState == FormWindowState.Maximized)
            {
                login.WindowState = FormWindowState.Maximized;
            }
            else
            {
                login.Size = this.Size;
                login.Location = this.Location;
            }

            login.Show();
            this.Hide();
        }

        private void navBtnHome_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();

            if (this.WindowState == FormWindowState.Maximized)
            {
                form.WindowState = FormWindowState.Maximized;
            }
            else
            {
                form.Size = this.Size;
                form.Location = this.Location;
            }

            form.Show();
            this.Hide();
        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (isMenuCollapsed)
            {
                // Expand the menu
                panelMenu.Width += stepSize;
                if (panelMenu.Width >= menuWidth)
                {
                    // Stop expanding
                    timerMenu.Enabled = false;
                    panelMenu.Width = menuWidth; // Ensure exact size
                    isMenuCollapsed = false;
                }
            }
            else
            {
                // Collapse the menu
                panelMenu.Width -= stepSize;
                if (panelMenu.Width <= collapsedWidth)
                {
                    // Stop collapsing
                    timerMenu.Enabled = false;
                    panelMenu.Width = collapsedWidth; // Ensure exact size
                    isMenuCollapsed = true;
                }
            }
        }

        private void RequestStatusPage_Click(object sender, EventArgs e)
        {
            if (!isMenuCollapsed)
            {
                timerMenu.Enabled = true;
            }
        }


    }
}
