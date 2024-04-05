using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class BillingNotFoundException : NotFoundException
    {
        public BillingNotFoundException(Guid id) : base($"Billing with id {id} does not exist in the database") { }
        public BillingNotFoundException(decimal amount) : base($"Billing with amount {amount} does not exist in the database") { }
    }
}
