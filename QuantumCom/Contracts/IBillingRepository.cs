using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Contracts
{
    public interface IBillingRepository
    {
        Task<IEnumerable<Billing>> GetAllBills(bool trackChanges);
        Task<Billing> GetBillById(int id, bool trackChanges);
        Task<Billing> GetBillByAmount(decimal amount, bool trackChanges);
        void CreateBill(Billing billing);
        void DeleteBill(Billing billing);
    }
}
