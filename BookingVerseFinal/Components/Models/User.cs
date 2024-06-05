using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingVerseFinal.Components.Models
{
    public class User
    {
        public User()
        {
        }

        public User(string userId, string password, string email, string firstName, string lastName)
        {
            UserId = userId;
            Password = password;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
        }

        public string UserId { get; set; }
        public string Password { get; set; }

        public string Email { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }

    }
}
