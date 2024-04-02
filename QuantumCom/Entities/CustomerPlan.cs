using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CustomerPlan
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Plan))]
        public int PlanId { get; set; }
    }
}
