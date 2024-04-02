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
                    Id = 1,
                    CustId = 1,
                    Amount = 200
                },
                new Billing
                {
                    Id = 2,
                    CustId = 2,
                    Amount = 500
                },
                new Billing
                {
                    Id = 3,
                    CustId = 3,
                    Amount = 1299
                },
                new Billing
                {
                    Id =4,
                    CustId = 4,
                    Amount = 350
                },
                new Billing
                {
                    Id=5,
                    CustId = 5,
                    Amount = 699
                });
        }
    }
}
