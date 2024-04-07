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
                    Name = "Iphone 14",
                    Number = "1111111111"
                },
                new Device
                {
                    Name = "Iphone 12 SE",
                    Number = "9012219981"
                },
                new Device
                {
                    Name = "Samsung Galaxy S22 Ultra",
                    Number = "9332910021"
                },
                new Device
                {
                    Name = "Motorola Edge",
                    Number = "4121229921"
                },
                new Device
                {
                    Name = "Iphone 11 S",
                    Number = "3329990192"
                },
                new Device
                {
                    Name = "Blackberry OG",
                    Number = "91119119111"
                }
                
                );
        }
    }
}
