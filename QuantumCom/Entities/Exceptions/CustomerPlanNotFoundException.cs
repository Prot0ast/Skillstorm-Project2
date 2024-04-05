using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class CustomerPlanNotFoundException : NotFoundException
    {
        public CustomerPlanNotFoundException(Guid id) : base($"Customer plan with id {id} doesnt exist in the database")
        {

        }
    }
}
