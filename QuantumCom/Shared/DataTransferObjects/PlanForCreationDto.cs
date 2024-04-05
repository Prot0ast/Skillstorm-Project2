using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record PlanForCreationDto
    {
    
        public string? Name { get; init; }
        public decimal? Price { get; init; }
        public int DeviceLimit { get; init; }
    }
}
