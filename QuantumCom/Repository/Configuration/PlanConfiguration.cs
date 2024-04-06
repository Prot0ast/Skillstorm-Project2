using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Plan> builder)
        {
            builder.HasData(
                new Plan
                {
                    Name = "Basic",
                    Price = 100,
                    DeviceLimit = 2
                },
                new Plan
                {
                    Name = "Family",
                    Price = 400,
                    DeviceLimit = 5
                },
                new Plan
                {
                    Name = "Unlimited",
                    Price = 700,
                    DeviceLimit = 15
                }
                );
        }
    }
}
