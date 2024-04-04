using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record BillingDto
    {
        public int Id { get; init; }
        public int CustId { get; init; }
        public decimal? Amount { get; init; }
    }
}
