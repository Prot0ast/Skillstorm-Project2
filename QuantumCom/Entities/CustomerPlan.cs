﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CustomerPlan
    {
        [ForeignKey(nameof(Customer.Id))]
        public Guid Id { get; set; }

        public ICollection<Plan>? Plans { get; set; }
    }
}
