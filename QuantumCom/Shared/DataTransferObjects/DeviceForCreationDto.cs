using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record DeviceForCreationDto
    {
        public Guid CustId { get; init; }
        public string? Name { get; init; }
        public string? Number { get; init; }
    }
}
