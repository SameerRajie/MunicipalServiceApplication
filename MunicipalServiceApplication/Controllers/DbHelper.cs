using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServiceApplication.Controllers
{
    public class DbHelper
    {
        private readonly string connectionString;

        public DbHelper() 
        {
            // Get the base directory of the application
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Build a relative path to the .mdf file
            string dbFilePath = Path.Combine(baseDirectory, "MunicipalEngagementDatabase.mdf");

            // Construct the connection string with the relative path
            connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={dbFilePath};Integrated Security=True";
        }

        /// <summary>
        /// Checks if a user already exists in the database.
        /// </summary>
        /// <param name="username">The username to check.</param>
        /// <returns>True if the user exists, false otherwise.</returns>
        public bool UserExists(string username)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        /// <summary>
        /// Adds a new user to the database.
        /// </summary>
        /// <param name="username">The username of the new user.</param>
        /// <param name="hashedPassword">The hashed password of the new user.</param>
        /// <returns>True if the user was added successfully, false otherwise.</returns>
        public bool AddUser(string username, string hashedPassword)
        {
            string query = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", hashedPassword);

                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                return rowsAffected > 0;
            }
        }

        /// <summary>
        /// Retrieves the hashed password for a given username.
        /// </summary>
        /// <param name="username">The username to retrieve the password for.</param>
        /// <returns>The hashed password, or null if the user doesn't exist.</returns>
        public string GetPassword(string username)
        {
            string query = "SELECT Password FROM Users WHERE Username = @Username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                connection.Open();
                object result = command.ExecuteScalar();
                return result?.ToString();
            }
        }
    }
}
