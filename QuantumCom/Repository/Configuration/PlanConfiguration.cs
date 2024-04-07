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
                    Id = new Guid("ad449f26-1106-417d-9d96-6c4b962b64a8"),
                    Name = "Basic",
                    Price = 100,
                    DeviceLimit = 2
                },
                new Plan
                {
                    Id = new Guid("d944707b-e51f-4986-9cb5-ab80a87925ea"),
                    Name = "Family",
                    Price = 400,
                    DeviceLimit = 5
                },
                new Plan
                {
                    Id = new Guid("37efdae3-1f3d-46e0-8a7b-66a3f6bb5ff3"),
                    Name = "Unlimited",
                    Price = 700,
                    DeviceLimit = 15
                }
                );
        }
    }
}
