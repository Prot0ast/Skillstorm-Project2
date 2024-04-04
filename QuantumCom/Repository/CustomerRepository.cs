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
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

        public void CreateCustomer(Customer customer) => Create(customer);

        public void DeleteCustomer(Customer customer) => Delete(customer);

        public async Task<IEnumerable<Customer>> GetAllCustomers(bool trackChanges) => await FindAll(trackChanges).OrderBy(c => c.Id).ToListAsync();

        public async Task<Customer> GetCustomerById(Guid id, bool trackChanges) => await FindByCondition(c => c.Id.Equals(id), trackChanges).SingleOrDefaultAsync();
    }
}
