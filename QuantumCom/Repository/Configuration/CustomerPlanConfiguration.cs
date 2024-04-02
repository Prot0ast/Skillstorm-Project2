using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class CustomerPlanConfiguration : IEntityTypeConfiguration<CustomerPlan>
    {
        public void Configure(EntityTypeBuilder<CustomerPlan> builder)
        {
            builder.HasData(
                new CustomerPlan
                {
                    Id = 1,
                },
                new CustomerPlan
                {
                    Id = 2,
                }, 
                new CustomerPlan
                {
                    Id = 3,
                },
                new CustomerPlan
                {
                    Id = 4,
                },
                new CustomerPlan
                {
                    Id = 5,
                }
                );
        }
    }
}
