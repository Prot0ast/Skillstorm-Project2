using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class BillingConfiguration : IEntityTypeConfiguration<Billing>
    {
        public void Configure(EntityTypeBuilder<Billing> builder)
        {
            builder.HasData(
                new Billing
                {
                    Amount = 200
                },
                new Billing
                {
                    Amount = 500
                },
                new Billing
                {
                    Amount = 1299
                },
                new Billing
                {
                    Amount = 350
                },
                new Billing
                {
                    Amount = 699
                });
        }
    }
}
