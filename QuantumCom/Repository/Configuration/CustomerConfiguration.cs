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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer
                {
                    Id = new Guid("54e5ce77-c784-42ab-84d0-0b11d5ec43c3"),
                    FirstName = "John",
                    LastName = "Test",
                    Email = "JohnTest@example.com",
                    CardType = "Visa",
                    CardNumber = "0000000000000000",
                    ExpirationDate = DateTime.Parse("2010-09-01"),
                    CCV = 111,
                },
                new Customer
                {
                    Id = new Guid("dea1f480-6a7e-4efd-9e26-f4387ee99398"),
                    FirstName = "Aaron",
                    LastName = "Rodgers",
                    Email = "Arod@example.com",
                    CardType = "Mastercard",
                    CardNumber = "1234123412341234",
                    ExpirationDate = DateTime.Parse("2024-10-08"),
                    CCV = 123,
                },
                new Customer
                {
                    Id = new Guid("5d1d8eac-2cb6-4f34-9e59-25a3a5ae3473"),
                    FirstName = "Kim",
                    LastName = "Mccrary",
                    Email = "KimMC123@example.com",
                    CardType = "Amex",
                    CardNumber = "9999999999999999",
                    ExpirationDate = DateTime.Parse("2026-12-25"),
                    CCV = 111,
                },
                new Customer
                {
                    Id = new Guid("d576cdc7-927a-408f-833b-dc12fba5c579"),
                    FirstName = "Marcus",
                    LastName = "Peters",
                    Email = "MarcusPeters@example.com",
                    CardType = "Discover",
                    CardNumber = "8888888888888888",
                    ExpirationDate = DateTime.Parse("2023-04-25"),
                    CCV = 421,
                },
                new Customer
                {
                    Id = new Guid("207e2d46-5364-4b83-b45c-0c27321f3a88"),
                    FirstName = "Lorenzo",
                    LastName = "Taylor",
                    Email = "LTaylor@example.com",
                    CardType = "Apple",
                    CardNumber = "4321432143214321",
                    ExpirationDate = DateTime.Parse("2027-11-01"),
                    CCV = 232,
                }
                ) ;
        }
    }
}
