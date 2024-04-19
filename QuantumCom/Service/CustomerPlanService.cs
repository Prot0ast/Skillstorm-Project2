using AutoMapper;
using Contracts;
using Entities;
using Entities.Exceptions;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CustomerPlanService : ICustomerPlanService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public CustomerPlanService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<CustomerPlanDto> CreateCustomerPlan(CustomerPlanForCreationDto customer)
        {
           var customerPlanEntity = _mapper.Map<CustomerPlan>(customer);
            var cust = await _repositoryManager.Customer.GetCustomerById(customerPlanEntity.CustId, false);
            if (customer == null)
            {
                throw new CustomerNotFoundException(customerPlanEntity.CustId);
            }

            customerPlanEntity.CustId = cust.Id;
            _repositoryManager.CustomerPlan.CreateCustomerPlan(customerPlanEntity);

            var plans = await _repositoryManager.CustomerPlan.GetCustomerPlanById(customer.CustId, trackChanges:false);
            customerPlanEntity.Plans = (ICollection<Plan>?)plans;
            await _repositoryManager.SaveAsync();
            var customerPlanToReturn = _mapper.Map<CustomerPlanDto>(customerPlanEntity);
            return customerPlanToReturn;
        }

        public async Task DeleteCustomerPlan(Guid id, bool trackChanges)
        {
            var customerPlan = await _repositoryManager.CustomerPlan.GetCustomerPlanById(id, trackChanges);
            if (customerPlan == null)
            {
                throw new CustomerNotFoundException(id);
            }

            _repositoryManager.CustomerPlan.DeleteCustomerPlan(customerPlan);
            await _repositoryManager.SaveAsync();
        }

        public async Task<CustomerPlanDto> GetCustomerPlanById(Guid id, bool trackChanges)
        {
            var customerPlan = await _repositoryManager.CustomerPlan.GetCustomerPlanById(id, trackChanges);
            if (customerPlan == null)
            {
                throw new CustomerPlanNotFoundException(id);
            }
            
            var customerPlanDto = _mapper.Map<CustomerPlanDto>(customerPlan);
            return customerPlanDto;
        }

        public async Task<IEnumerable<CustomerPlanDto>> GetCustomerPlans(bool trackChanges)
        {
            var customerPlans = await _repositoryManager.CustomerPlan.GetCustomerPlans(trackChanges);
            var customerPlanDto = _mapper.Map<IEnumerable<CustomerPlanDto>>(customerPlans);
            return customerPlanDto;
        }
    }
}
