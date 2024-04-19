using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                   Id = new Guid("8d373114-e2fe-449f-9c36-eb50dcb02874"),
               
                },
                new CustomerPlan
                {
                    Id = new Guid("0b5c7ab7-b0e6-4265-a8e4-ef6037f03214")

                }, 
                new CustomerPlan
                {
                    Id = new Guid("7d728329-e865-480c-8b50-93ec58617d8f")

                },
                new CustomerPlan
                {
                    Id = new Guid("91aca162-93ed-4359-b8e0-22ac8a7998b3")

                },
                new CustomerPlan
                {
                    Id = new Guid("0f321dd1-45bd-45ee-861b-cae561131c61")

                }
                );
        }
    }
}
