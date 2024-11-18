using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MunicipalServiceApplication.Controllers
{
    public class DbHelper
    {
        //Globally declares connection string variable
        private readonly string connectionString;
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// When an instance of this class is called, the connection string is set to a relative path
        /// </summary>
        public DbHelper() 
        {
            // Get the base directory of the application
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Build a relative path to the .mdf file
            string dbFilePath = Path.Combine(baseDirectory, "MunicipalEngagementDatabase.mdf");

            // Construct the connection string with the relative path
            connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={dbFilePath};Integrated Security=True";
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Checks if a user already exists in the database.
        /// </summary>
        /// <param name="username">The username to check.</param>
        /// <returns>True if the user exists, false otherwise.</returns>
        public bool UserExists(string username)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error checking user existence: {ex.Message}");
                return false;
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Adds a new user to the database.
        /// </summary>
        /// <param name="username">The username of the new user.</param>
        /// <param name="hashedPassword">The hashed password of the new user.</param>
        /// <returns>True if the user was added successfully, false otherwise.</returns>
        public bool AddUser(string username, string hashedPassword)
        {
            string query = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", hashedPassword);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding user: {ex.Message}");
                return false;
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Retrieves the hashed password for a given username.
        /// </summary>
        /// <param name="username">The username to retrieve the password for.</param>
        /// <returns>The hashed password, or null if the user doesn't exist.</returns>
        public string GetPassword(string username)
        {
            string query = "SELECT Password FROM Users WHERE Username = @Username";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);

                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result?.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Gets the User's ID based on the username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public string GetUser(string username)
        {
            string query = "SELECT Id FROM Users WHERE Username = @Username";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);

                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result?.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Adds the report to the Issues database with the relative userId as the foreign key
        /// </summary>
        /// <param name="report"></param>
        /// <returns></returns>
        public bool AddIssue(IssueReport report, int userId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    if (report.AttachedFile == null)
                    {
                        string query = "INSERT INTO Issues (Location, Category, Description, Status, Priority, UserId) " +
                                       "VALUES (@Location, @Category, @Description, @Status, @Priority, @UserId)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Location", report.Location);
                            command.Parameters.AddWithValue("@Category", report.Category);
                            command.Parameters.AddWithValue("@Description", report.Description);
                            command.Parameters.AddWithValue("@Status", report.Status);
                            command.Parameters.AddWithValue("@Priority", (int)report.Priority);
                            command.Parameters.AddWithValue("@UserId", userId);

                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            connection.Close();

                            return rowsAffected > 0;
                        }
                    }
                    else
                    {
                        string query = "INSERT INTO Issues (Location, Category, Description, AttachedFile, Status, Priority, UserId) " +
                                       "VALUES (@Location, @Category, @Description, @AttachedFile, @Status, @Priority, @UserId)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Location", report.Location);
                            command.Parameters.AddWithValue("@Category", report.Category);
                            command.Parameters.AddWithValue("@Description", report.Description);
                            command.Parameters.AddWithValue("@AttachedFile", (object)report.AttachedFile);
                            command.Parameters.AddWithValue("@Status", report.Status);
                            command.Parameters.AddWithValue("@Priority", (int)report.Priority);
                            command.Parameters.AddWithValue("@UserId", userId);

                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            connection.Close();

                            return rowsAffected > 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Gets all Issues that were reported by the designated user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<IssueReport> GetIssues(int userId)
        {
            List<IssueReport> Issues = new List<IssueReport>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Issues WHERE UserId = " + userId;

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string location = reader.GetString(1);
                                string category = reader.GetString(2);
                                string description = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                                byte[] attachedFile = reader.IsDBNull(4) ? null : (byte[])reader["AttachedFile"];
                                string status = reader.GetString(5);
                                int priority = reader.GetInt32(6);

                                Issues.Add(new IssueReport(id, location, category, description, attachedFile, status, priority));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            return Issues;
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Gets all the events in the database
        /// </summary>
        /// <returns></returns>
        public List<Event> GetEvents()
        {
            List<Event> events = new List<Event>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Events";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string title = reader.GetString(1);
                                string category = reader.GetString(2);
                                DateTime date = reader.GetDateTime(3);
                                string description = reader.GetString(4);

                                events.Add(new Event(title, category, date, description));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            return events;
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Gets all of the announcements in the database
        /// </summary>
        /// <returns></returns>
        public List<Announcement> GetAnnouncements()
        {
            List<Announcement> announcements = new List<Announcement>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Announcements";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string title = reader.GetString(1);
                                string content = reader.GetString(2);
                                DateTime date = reader.GetDateTime(3);

                                announcements.Add(new Announcement(title, content, date));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            return announcements;
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Clears all of the existing values in a designated table
        /// used for loading dummy data
        /// </summary>
        /// <param name="tableName"></param>
        public void ClearTable(string tableName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = $"DELETE FROM {tableName}";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Cycles through a list to populate the events table
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public async Task InsertEvents(List<Event> events)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    foreach (Event e in events)
                    {
                        string query = "INSERT INTO Events (Title, Category, Date, Description) VALUES (@Title, @Category, @Date, @Description)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Title", e.Title);
                            command.Parameters.AddWithValue("@Category", e.Category);
                            command.Parameters.AddWithValue("@Date", e.Date);
                            command.Parameters.AddWithValue("@Description", e.Description);

                            command.ExecuteNonQuery();
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Cycles through a list to populate the announcements table
        /// </summary>
        /// <param name="announcements"></param>
        /// <returns></returns>
        public async Task InsertAnnouncement(List<Announcement> announcements)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    foreach (Announcement a in announcements)
                    {
                        string query = "INSERT INTO Announcements (Title, Content, PublishDate) VALUES (@Title, @Content, @Date)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {

                            command.Parameters.AddWithValue("@Title", a.Title);
                            command.Parameters.AddWithValue("@Content", a.Content);
                            command.Parameters.AddWithValue("@Date", a.PublishDate);

                            command.ExecuteNonQuery();
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------
    }
}
//--------------------------------------------------End of Code------------------------------------------------------------