using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record DeviceDto
    {
        public int Id { get; init; }
        public int CustId { get; init; }
        public string? Name { get; init; }
        public string? Number { get; init; }
    }
}
