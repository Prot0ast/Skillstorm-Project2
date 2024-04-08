using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record PlanDto
    {
        public Guid Id { get; init; }
        public string? Name { get; init; }
        public decimal? Price { get; init; }
        public int DeviceLimit { get; init; }
    }
}
