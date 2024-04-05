using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface ICustomerPlanService
    {
        Task <CustomerPlanDto> GetCustomerPlanById(Guid id, bool trackChanges);
        Task<IEnumerable<CustomerPlanDto>> GetCustomerPlans(bool trackChanges);

        Task<CustomerPlanDto> CreateCustomerPlan(CustomerPlanForCreationDto customer);

        Task DeleteCustomerPlan(Guid id, bool trackChanges);
    }
}
