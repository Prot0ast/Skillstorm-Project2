using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Service.Contracts
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerDto>> GetAllCustomersAsync(bool trackChanges);
        Task<CustomerDto> CreateCustomerAsync(CustomerForCreationDto customer);
        Task DeleteCustomerAsync(Guid id, bool trackChanges);
        Task UpdateCustomerAsync(Guid id, CustomerForUpdateDto customer, bool trackChanges);
        Task<(CustomerForUpdateDto customerForUpdate, Customer customerEntity)> GetCustomerForPatchAsync(Guid id, bool trackChanges);
        Task SaveChangesForPatchAsync(CustomerForUpdateDto customerForUpdate, Customer customerEntity);
        Task<CustomerDto> GetCustomerAsync(Guid id, bool trackChanges);

    }
}
