﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record CustomerPlanDto
    {
        public int Id { get; init; }
        public ICollection<PlanDto> Plans { get; init; }
    }
}
