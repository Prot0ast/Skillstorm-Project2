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
    public class PlanRepository : RepositoryBase<Plan>, IPlanRepository
    {
        public PlanRepository(RepositoryContext repositoryContext): base(repositoryContext) {}

        public void CreatePlan(Plan plan) => Create(plan);
        public void DeletePlan(Plan plan) => Delete(plan);
        public async Task<IEnumerable<Plan>> GetAllPlans(bool trackChanges) => await FindAll(trackChanges).OrderBy(p => p.Id).ToListAsync();

        public async Task<Plan> GetPlanById(Guid id, bool trackChanges) => await FindByCondition(p => p.Id.Equals(id), trackChanges).SingleOrDefaultAsync();


        public async Task<Plan> GetPlanByName(string name, bool trackChanges) => await FindByCondition(p => p.Name.Equals(name), trackChanges).SingleOrDefaultAsync();

        public async Task<Plan> GetPlanByPrice(decimal price, bool trackChanges) => await FindByCondition(p => p.Price.Equals(price), trackChanges).SingleOrDefaultAsync();

    }
}
