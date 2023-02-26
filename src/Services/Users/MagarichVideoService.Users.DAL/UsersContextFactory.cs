using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagarichVideoService.Users.DAL
{
    public class UsersContextFactory : IDesignTimeDbContextFactory<UsersContext>
    {
        public UsersContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<UsersContext>();

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("Postgre");

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ApplicationException("No connection string.");
            }

            builder.UseNpgsql(connectionString);

            return new UsersContext(builder.Options);
        }
    }
}
