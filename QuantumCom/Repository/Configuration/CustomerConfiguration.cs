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
                    Id = 1,
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
                    Id = 2,
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
                    Id = 3,
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
                    Id = 4,
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
                    Id = 5,
                    FirstName = "Lorenzo",
                    LastName = "Taylot",
                    Email = "LTaylor@example.com",
                    CardType = "Apple",
                    CardNumber = "4321432143214321",
                    ExpirationDate = DateTime.Parse("2027-11-01"),
                    CCV = 232,
                }
                );
        }
    }
}
