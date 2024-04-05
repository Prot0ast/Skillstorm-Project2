using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record DeviceForCreationDto
    {
        public string? Name { get; init; }
        public string? Number { get; init; }
    }
}
