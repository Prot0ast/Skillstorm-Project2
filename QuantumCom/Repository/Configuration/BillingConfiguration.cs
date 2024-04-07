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
                    Id = new Guid("df7108b0-0222-480b-8fb6-fa039e5aebd5"),
                    CustId = new Guid("54e5ce77-c784-42ab-84d0-0b11d5ec43c3"),
                    Amount = 400
                },
                new Billing
                {
                    Id = new Guid("aa62935f-3b2b-4121-8448-c494e55530a7"),
                    CustId = new Guid("dea1f480-6a7e-4efd-9e26-f4387ee99398"),
                    Amount = 500
                },
                new Billing
                {
                    Id = new Guid("ff07f3cb-7589-4e77-b1a9-bf90d0e6faab"),
                    CustId = new Guid("5d1d8eac-2cb6-4f34-9e59-25a3a5ae3473"),
                    Amount = 1299
                },
                new Billing
                {
                    Id = new Guid("d6a3feb0-6e6c-472b-82fd-ae97b94922af"),
                    CustId = new Guid("d576cdc7-927a-408f-833b-dc12fba5c579"),
                    Amount = 350
                },
                new Billing
                {
                    Id = new Guid("ec87d4af-74c3-40f5-9add-a430dd551073"),
                    CustId = new Guid("207e2d46-5364-4b83-b45c-0c27321f3a88"),
                    Amount = 699
                }) ;
        }
    }
}
