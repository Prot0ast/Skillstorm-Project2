using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IPlanService
    {
        Task<IEnumerable<PlanDto>> GetAllPlans(bool trackChanges);
        Task<PlanDto> GetPlan(Guid id, bool trackChanges);
        Task<PlanDto> CreatePlan(PlanForCreationDto plan);
        Task<PlanDto> GetPlanByName(string name, bool trackChanges);
        Task<PlanDto> GetPlanByPrice(decimal price, bool trackChanges);
        Task DeletePlan(Guid id, bool trackChanges);

    }
}
