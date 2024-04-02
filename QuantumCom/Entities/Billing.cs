using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Billing
    {

        public int Id { get; set; }

        [ForeignKey(nameof(Customer))]
        public int CustId { get; set; }

        [DataType(DataType.Currency)]
        public decimal? Amount { get; set; }
    }
}
