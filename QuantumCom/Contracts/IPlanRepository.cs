using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Contracts
{
    public interface IPlanRepository
    { 
        Task<IEnumerable<Plan>> GetAllPlans(bool trackChanges);
        Task<Plan> GetPlanByPrice(decimal price, bool trackChanges);
        Task<Plan> GetPlanByName(string name, bool trackChanges);
        Task<Plan> GetPlanById(Guid id, bool trackChanges);
        void CreatePlan(Plan plan);
        void DeletePlan(Plan plan);
    }
}
