using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ServerManagement.Data
{
    public class ServerManagementContextFactory : IDesignTimeDbContextFactory<ServerManagementContext>
    {
        public ServerManagementContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ServerManagementContext>();

            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.Development.json", optional: true)
                .AddJsonFile("appsettings.json", optional: true)
                .Build();

            var connectionString = config.GetConnectionString("ServerManagement");
            optionsBuilder.UseSqlServer(connectionString);

            return new ServerManagementContext(optionsBuilder.Options);
        }
    }
}
