using BookingVerseFinalAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace BookingVerseFinalAPI.Database
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Account> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
