using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class PlanNotFoundException : NotFoundException
    {
        public PlanNotFoundException(Guid id) : base($"Plan with id {id} could not be found in the database"){}
        public PlanNotFoundException(string name) : base($"Plan with name {name} could not be found in the database") { }
        public PlanNotFoundException(decimal amount): base($"Plan with amount {amount} could not be found in the database") { }
    }
}
