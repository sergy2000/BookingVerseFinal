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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .HasIndex(a => a.Email)
                .IsUnique();

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Account)
                .WithMany()
                .HasForeignKey(o => o.AccountID);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Event)
                .WithMany()
                .HasForeignKey(o => o.EventID);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Account>().HasData(
                new Account(1,"Hans", "Mueller", "admin1@example.com", "admin123"),
                new Account(2,"John", "Doe", "user1@example.com", "user123")
            );

            modelBuilder.Entity<Event>().HasData(
                new Event(1,"Event 1", DateTime.Now, "Location 1", "Category 1", 50.0M, "Description 1") ,
                new Event(2,"Event 2", DateTime.Now, "Location 2", "Category 2", 75.0M, "Description 2")
            );
        }
    }
}
