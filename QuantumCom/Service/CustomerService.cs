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
    public class CustomerService : ICustomerService
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

        public async Task<CustomerDto> CreateCustomerAsync(CustomerForCreationDto customer)
        {
            var customerEntity = _mapper.Map<Customer>(customer);
            _repositoryManager.Customer.CreateCustomer(customerEntity);
            await _repositoryManager.SaveAsync();
            var customerToReturn = _mapper.Map<CustomerDto>(customerEntity);
            return customerToReturn;
        }

    public async Task DeleteCustomerAsync(Guid id, bool trackChanges)
    {
            var customer = await _repositoryManager.Customer.GetCustomerById(id, trackChanges);
            if (customer != null)
            {
                throw new CustomerNotFoundException(id);
            }

            _repositoryManager.Customer.DeleteCustomer(customer);
            await _repositoryManager.SaveAsync();
    }

    public async Task<IEnumerable<CustomerDto>> GetAllCustomersAsync(bool trackChanges)
    {
        var customers = await _repositoryManager.Customer.GetAllCustomers(trackChanges);
            var customerDto = _mapper.Map<IEnumerable<CustomerDto>>(customers);
            return customerDto;
    }

    public async Task<(CustomerForUpdateDto customerForUpdate, Customer customerEntity)> GetCustomerForPatchAsync(Guid id, bool trackChanges)
    {
            var customerEntity = await _repositoryManager.Customer.GetCustomerById(id, trackChanges);
            if (customerEntity != null)
            {
                throw new CustomerNotFoundException(id);
            }

            var customerForUpdate = _mapper.Map<CustomerForUpdateDto>(customerEntity);
            return (customerForUpdate, customerEntity);
    }

    public async Task SaveChangesForPatchAsync(CustomerForUpdateDto customerForUpdate, Customer customerEntity)
    {
            _mapper.Map(customerForUpdate, customerEntity);
            await _repositoryManager.SaveAsync();
    }

    public async Task UpdateCustomerAsync(Guid id, CustomerForUpdateDto customer, bool trackChanges)
    {
            var customerEntity = await _repositoryManager.Customer.GetCustomerById(id, trackChanges);
            if (customerEntity != null)
            {
                throw new CustomerNotFoundException(id);
            }

            _mapper.Map(customer, customerEntity);
            await _repositoryManager.SaveAsync();
    }
}
}
