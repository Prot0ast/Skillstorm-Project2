using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IBillingRepository> _billingRepository;
        private readonly Lazy<ICustomerPlanRepository> _customerPlanRepository;
        private readonly Lazy<ICustomerRepository> _customerRepository;
        private readonly Lazy<IDeviceRepository> _deviceRepository;
        private readonly Lazy<IPlanRepository> _planRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _billingRepository = new Lazy<IBillingRepository>(() => new BillingRepository(_repositoryContext));
            _customerPlanRepository = new Lazy<ICustomerPlanRepository>(() => new CustomerPlanRepository(_repositoryContext));
            _customerRepository = new Lazy<ICustomerRepository>(() => new CustomerRepository(_repositoryContext));
            _deviceRepository = new Lazy<IDeviceRepository>(() => new DeviceRepository(_repositoryContext));
            _planRepository = new Lazy<IPlanRepository>(() => new PlanRepository(_repositoryContext));
        }

        public IBillingRepository Billing => _billingRepository.Value;
        public ICustomerPlanRepository CustomerPlan => _customerPlanRepository.Value;
        public ICustomerRepository Customer => _customerRepository.Value;
        public IDeviceRepository Device => _deviceRepository.Value;
        public IPlanRepository Plan => _planRepository.Value;
        public void Save() => _repositoryContext.SaveChanges();
        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
    }
}
