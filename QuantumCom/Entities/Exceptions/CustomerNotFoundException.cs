using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class CustomerNotFoundException : NotFoundException
    {
        public CustomerNotFoundException(Guid customerId) : base($"The customer wth id: {customerId} doesnt exist within the database.")
        {

        }
    }
}
