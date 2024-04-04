using AutoMapper;
using Contracts;
using Entities;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CustomerService// : ICustomerService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public CustomerService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
            _mapper = mapper;
        }

//        public async Task<CustomerDto> CreateCustomerAsync(CustomerForCreationDTO customer)
//        {
//            var customerEntity = _mapper.Map<Customer>(customer);
//            _repositoryManager.Customer.CreateCustomer(customerEntity);
//            await _repositoryManager.SaveAsync();
//            var customerToReturn = _mapper.Map<CustomerDto>(customerEntity);
//            return customerToReturn;
//        }

//        public Task DeleteCustomerAsync(Guid id, bool trackChanges)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<IEnumerable<CustomerDto>> GetAllCustomersAsync(bool trackChanges)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<(CustomerForUpdateDto customerForUpdate, Customer customerEntity)> GetCustomerForPatchAsync(Guid id, bool trackChanges)
//        {
//            throw new NotImplementedException();
//        }

//        public Task SaveChangesForPatchAsync(CustomerForUpdateDto customerForUpdate, Customer customerEntity)
//        {
//            throw new NotImplementedException();
//        }

//        public Task UpdateCustomerAsync(Guid id, CustomerForUpdateDto customer, bool trackChanges)
//        {
//            throw new NotImplementedException();
//        }
//    }
}
