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
                    
                },
                new CustomerPlan
                {
                    
                }, 
                new CustomerPlan
                {
                    
                },
                new CustomerPlan
                {
                    
                },
                new CustomerPlan
                {
                    
                }
                );
        }
    }
}
