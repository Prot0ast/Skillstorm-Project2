using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Repository;

namespace QuantumCom.ContextFactory
{
   
        public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
        {
            public RepositoryContext CreateDbContext(string[] args)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                var builder = new DbContextOptionsBuilder<RepositoryContext>()
                    .UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                        builder => builder.MigrationsAssembly("QuantumCom"));

                return new RepositoryContext(builder.Options);
            }
        }
    }

