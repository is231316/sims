

using StackExchange.Redis;
using System.Security.Cryptography;
using System.Text;

namespace Shared
{
    public class PasswordManagement
    {
        private static readonly ConnectionMultiplexer redisConnection = ConnectionMultiplexer.Connect("localhost");
        private static readonly IDatabase redisDatabase = redisConnection.GetDatabase();
        public static string Username { get; set; }
        private static readonly string _password;
        public static bool isLoggedIn;
        public static string userRole;

        private static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {

                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        public static bool VerifyPassword(string username, string password)
        {
            var userData = redisDatabase.HashGetAll(username);
                
            if (string.IsNullOrEmpty(username))
            {
                return false;
            }

			var storedPassword = userData.FirstOrDefault(field => field.Name == "password").Value;
            var role = userData.FirstOrDefault(field => field.Name == "role").Value;

			string hashedPassword = HashPassword(password);
            userRole = role;

            return storedPassword == hashedPassword;
        }
    }
}
