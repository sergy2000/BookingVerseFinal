using BookingVerseFinal.Components.Models;

namespace BookingVerseFinal.Components.Services
{
    internal class UserService
    {
        public List<Account> Users;

        public UserService() 
        {
            Users =
            [
                new Account(1, "password123", "john.doe@example.com", "John", "Doe"),
                new Account(2, "securepass", "jane.doe@example.com", "Jane", "Doe"),
                new Account(3, "mypassword", "bob.smith@example.com", "Bob", "Smith"),
                new Account(4, "letmein", "alice.jones@example.com", "Alice", "Jones"),
                new Account(5, "password1", "charlie.brown@example.com", "Charlie", "Brown"),
            ];
        }

        public async Task AddUser(Account sender)
        {
            if (await Task.Run(() => !Users.Any(x => x.UserID.Equals(sender.UserID))))
            {
                Users.Add(sender);
            }
        }

        public List<Account> GetUsers() => Users;

        public async Task<Account> GetUserByEmail() => await Task.Run(() => Users.First());
    }
}
