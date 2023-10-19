using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheosummaChat.Core.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; } // Consider using a secure password hashing mechanism
        public string PhoneNumber { get; set; }
        public List<string> PreferredTopics { get; set; } // List of preferred topics
        // Add other user-related properties as needed
    }
}
