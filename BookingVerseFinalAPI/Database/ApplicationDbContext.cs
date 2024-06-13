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
        }
    }
}

/*
 * 
 * 
 *
 *
 *
 *dotnet add package Microsoft.AspNetCore.Components.WebView.Maui
dotnet add package Microsoft.Extensions.Http
Microsoft.AspNetCore.Authentication.JwtBearer: To handle JWT authentication.
Microsoft.IdentityModel.Tokens: To manage JWT token validation.
Microsoft.EntityFrameworkCore: Core package for Entity Framework Core.
Microsoft.EntityFrameworkCore.SqlServer: Provider for SQL Server.
Microsoft.EntityFrameworkCore.Design: Tools for Entity Framework Core.
Microsoft.EntityFrameworkCore.Tools: Tools for managing migrations and scaffolding.
 **/