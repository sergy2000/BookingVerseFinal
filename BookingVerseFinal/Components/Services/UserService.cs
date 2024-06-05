using BookingVerseFinal.Components.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingVerseFinal.Components.Services
{
    internal class UserService
    {

        public List<User> Users = new List<User>();             


        
       public List<User> GetUser()
        {
            return Users;
        }

        public void AddUser(User sender)
        {
            if (!Users.Any(x => x.UsertId.Equals(sender.UsertId)))
            {
                Users.Add(sender);
            }
        }

      


    }
}
