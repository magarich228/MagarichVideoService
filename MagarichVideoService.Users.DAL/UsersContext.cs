using MagarichVideoService.Users.DAL.Models;
using MagarichVideoService.Users.DAL.Models.Configurations;
using Microsoft.EntityFrameworkCore;

namespace MagarichVideoService.Users.DAL
{
    public class UsersContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Credentials> UsersCredentials { get; set; } = null!;

        public UsersContext(DbContextOptions<UsersContext> optionsBuilder) : base(optionsBuilder)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new CredentialsConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
