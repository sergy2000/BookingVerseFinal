using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookingVerseFinal.Components.Models;

namespace BookingVerseFinal.Components.Services
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Event>().Wait();
            _database.CreateTableAsync<User>().Wait();
        }

        public Task<List<Event>> GetEventsAsync()
        {
            return _database.Table<Event>().ToListAsync();
        }

        public Task<int> SaveEventAsync(Event eventItem)
        {
            if (!string.IsNullOrEmpty(eventItem.EventID))
            {
                return _database.UpdateAsync(eventItem);
            }
            else
            {
                return _database.InsertAsync(eventItem);
            }
        }

        public Task<int> DeleteEventAsync(Event eventItem)
        {
            return _database.DeleteAsync(eventItem);
        }

        public Task<List<User>> GetUsersAsync()
        {
            return _database.Table<User>().ToListAsync();
        }

        public Task<int> SaveUserAsync(User user)
        {
            if (!string.IsNullOrEmpty(user.UserId))
            {
                return _database.UpdateAsync(user);
            }
            else
            {
                return _database.InsertAsync(user);
            }
        }

        public Task<int> DeleteUserAsync(User user)
        {
            return _database.DeleteAsync(user);
        }
    }
}
