using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class DeviceConfiguration : IEntityTypeConfiguration<Device>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Device> builder)
        {
            builder.HasData(
                new Device
                {
                    Id = 1,
                    CustId = 1,
                    Name = "Iphone 14",
                    Number = "1111111111"
                },
                new Device
                {
                    Id = 2,
                    CustId = 1,
                    Name = "Iphone 12 SE",
                    Number = "9012219981"
                },
                new Device
                {
                    Id = 3,
                    CustId = 2,
                    Name = "Samsung Galaxy S22 Ultra",
                    Number = "9332910021"
                },
                new Device
                {
                    Id = 4,
                    CustId = 3,
                    Name = "Motorola Edge",
                    Number = "4121229921"
                },
                new Device
                {
                    Id = 5,
                    CustId = 4,
                    Name = "Iphone 11 S",
                    Number = "3329990192"
                },
                new Device
                {
                    Id= 6,
                    CustId= 5,
                    Name = "Blackberry OG",
                    Number = "91119119111"
                }
                
                );
        }
    }
}
