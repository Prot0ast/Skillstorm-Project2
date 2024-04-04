using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Contracts;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class BillingRepository : RepositoryBase<Billing>, IBillingRepository
    {
        public BillingRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }
        public void CreateBill(Billing billing) => Create(billing);
        public void DeleteBill(Billing billing) => Delete(billing);
        public async Task<IEnumerable<Billing>> GetAllBills(bool trackChanges) => await FindAll(trackChanges).OrderBy(b => b.Id).ToListAsync();
        public async Task<Billing> GetBillByAmount(decimal amount, bool trackChanges) => await FindByCondition(b => b.Amount.Equals(amount), trackChanges).SingleOrDefaultAsync();
        public async Task<Billing> GetBillById(int id, bool trackChanges) => await FindByCondition(b => b.Id.Equals(id), trackChanges).SingleOrDefaultAsync();
    }
}
