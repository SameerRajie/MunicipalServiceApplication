using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

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
            if (db.UserExists(username))
            {
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

            GetSet.userId = int.Parse(db.GetUser(username));

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
