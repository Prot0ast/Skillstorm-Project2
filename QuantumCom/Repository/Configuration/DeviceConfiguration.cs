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
                    Id = new Guid("eb8fa05e-3380-4e4a-bd5e-bc69b401e110"),
                    CustId = new Guid("54e5ce77-c784-42ab-84d0-0b11d5ec43c3"),
                    Name = "Iphone 14",
                    Number = "1111111111"
                },
                new Device
                {
                    Id = new Guid("067e0b3f-78db-4f7d-b7eb-d2b803d48418"),
                    CustId = new Guid("dea1f480-6a7e-4efd-9e26-f4387ee99398"),
                    Name = "Iphone 12 SE",
                    Number = "9012219981"
                },
                new Device
                {
                    Id = new Guid("28f8bf3e-a6e5-44f7-963a-109404b3b8ce"),
                    CustId = new Guid("5d1d8eac-2cb6-4f34-9e59-25a3a5ae3473"),
                    Name = "Samsung Galaxy S22 Ultra",
                    Number = "9332910021"
                },
                new Device
                {
                    Id = new Guid("5bbf569d-a79c-424c-b077-9b6dff481c6b"),
                    CustId = new Guid("d576cdc7-927a-408f-833b-dc12fba5c579"),
                    Name = "Motorola Edge",
                    Number = "4121229921"
                },
                new Device
                {
                    Id = new Guid("a6cbc0d9-d7a8-47ee-95e7-beecb671613d"),
                    CustId = new Guid("207e2d46-5364-4b83-b45c-0c27321f3a88"),
                    Name = "Iphone 11 S",
                    Number = "3329990192"
                },
                new Device
                {
                    Id = new Guid("75f89763-1484-456e-a819-3d868343d0c0"),
                    CustId = new Guid("207e2d46-5364-4b83-b45c-0c27321f3a88"),
                    Name = "Blackberry OG",
                    Number = "91119119111"
                }
                
                );
        }
    }
}
