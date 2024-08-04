using C42_G02_OOP04.Q2_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP04.Q2
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        // Simulate a user store with credentials and roles
        private readonly Dictionary<string, string> userStore = new Dictionary<string, string>
    {
        { "user1", "password1" },
        { "user2", "password2" }
    };

        private readonly Dictionary<string, List<string>> userRoles = new Dictionary<string, List<string>>
    {
        { "user1", new List<string> { "admin", "user" } },
        { "user2", new List<string> { "user" } }
    };

        // Implement the AuthenticateUser method
        public bool AuthenticateUser(string username, string password)
        {
            return userStore.ContainsKey(username) && userStore[username] == password;
        }

        // Implement the AuthorizeUser method
        public bool AuthorizeUser(string username, string role)
        {
            return userRoles.ContainsKey(username) && userRoles[username].Contains(role);
        }
    }
}
