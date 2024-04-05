using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class PlanNotFoundException : NotFoundException
    {
        public PlanNotFoundException(Guid id) : base($"Plan with id {id} could not be found in the database")
        {

        }
    }
}
