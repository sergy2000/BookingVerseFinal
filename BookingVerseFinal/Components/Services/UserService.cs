using BookingVerseFinal.Components.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;

namespace BookingVerseFinal.Components.Services
{
    internal class UserService
    {

        public List<Account> Users = new List<Account>();             


        
       public List<Account> GetUser()
        {
            return Users;
        }

        public void AddUser(Account sender)
        {
            if (!Users.Any(x => x.UsertId.Equals(sender.UsertId)))
            {
                Users.Add(sender);
            }

        }

        public Account GetUserByEmail()
        {
            return Users.FirstOrDefault();
        }




    }
}
