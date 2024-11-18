using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalServiceApplication.Controllers
{
    public class UserController
    {
        private DbHelper db;

        public UserController()
        {
            db = new DbHelper();
        }

        public bool Signup(string username, string password)
        {
            if (String.IsNullOrEmpty(username) || String.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username cannot be empty.");
            }

            if (db.UserExists(username))
            {
                MessageBox.Show("Username already exists. Please choose another.");
                return false; // User already exists
            }

            string hashedPassword = HashPassword(password);
            return db.AddUser(username, hashedPassword);
        }

        public bool Login(string username, string password)
        {
            string storedHashedPassword = db.GetPassword(username);
            if (storedHashedPassword == null)
            {
                return false; // User not found
            }

            int id = int.Parse(db.GetUser(username));

            GetSet.userId = id;

            return VerifyPassword(password, storedHashedPassword);
        }

        public string HashPassword(string password)
        {
            // Implement hashing logic here (e.g., using SHA256, BCrypt, or similar)
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        public bool VerifyPassword(string enteredPassword, string storedHashedPassword)
        {
            string hashOfInput = HashPassword(enteredPassword);
            return hashOfInput == storedHashedPassword;
        }
    }
}
