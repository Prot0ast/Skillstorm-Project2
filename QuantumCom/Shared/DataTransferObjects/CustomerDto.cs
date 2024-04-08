using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record CustomerDto
    {
        public Guid Id { get; init; }
        public string? FirstName { get; init; }
        public string? LastName { get; init; }
        public string? FullName {  get; init; }
        public string? Email { get; init; }
        public string? CardType { get; init;}
        public string? CardNumber { get; init; }
        public DateTime? ExpirationDate { get; init; }
        public int? CCV { get; init; }
        public CustomerPlanDto? Plans { get; init; }
        public ICollection<DeviceDto>? Devices { get; init; }

    }
}
