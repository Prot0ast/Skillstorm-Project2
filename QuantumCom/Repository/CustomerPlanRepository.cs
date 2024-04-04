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
    public class CustomerPlanRepository : RepositoryBase<CustomerPlan>, ICustomerPlanRepository
    {
        public CustomerPlanRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

        public void CreateCustomerPlan(CustomerPlan customerPlan) => Create(customerPlan);

        public void DeleteCustomerPlan(CustomerPlan customerPlan) => Delete(customerPlan);

        public async Task<CustomerPlan> GetCustomerPlanById(int id, bool trackChanges) => await FindByCondition(c => c.Id.Equals(id), trackChanges).SingleOrDefaultAsync();

        public async Task<IEnumerable<CustomerPlan>> GetCustomerPlans(bool trackChanges) => await FindAll(trackChanges).OrderBy(c => c.Id).ToListAsync();
    }
}
