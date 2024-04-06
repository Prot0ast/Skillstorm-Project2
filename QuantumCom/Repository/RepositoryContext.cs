using Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }

        public DbSet<Billing>? Billings { get; set; }
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<CustomerPlan>? CustomerPlans { get; set; }
        public DbSet<Device>? Devices { get; set; }
        public DbSet<Plan>? Plans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Device>()
                .HasKey(x => new { x.Id, x.CustId });

            modelBuilder.ApplyConfiguration(new BillingConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerPlanConfiguration());
            modelBuilder.ApplyConfiguration(new DeviceConfiguration());
            modelBuilder.ApplyConfiguration(new PlanConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }

        }
}
