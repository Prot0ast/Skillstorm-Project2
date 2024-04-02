using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }

        public DbSet<Billing>? Billings { get; set; }

        public DbSet<Customer>? Customers { get; set; }

        public DbSet<CustomerPlan> CustomerPlans { get; set; }

        public DbSet<Device> Devices { get; set; }

        public DbSet<Plan> Plans { get; set; }

    }
}
