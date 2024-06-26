﻿using AutoMapper;
using Contracts;
using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Service.Contracts;
using Entities.ConfigurationModels;

namespace Service
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IBillingService> _billingService;
        private readonly Lazy<ICustomerService> _customerService;
        private readonly Lazy<ICustomerPlanService> _customerPlanService;
        private readonly Lazy<IDeviceService> _deviceService;
        private readonly Lazy<IPlanService> _planService;
        private readonly Lazy<IAuthenticationService> _authenticationService;
        
        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper,UserManager<User> userManager, IOptions<JwtConfiguration> configuration) 
        {
            _billingService = new Lazy<IBillingService>(() => new BillingService(repositoryManager, logger, mapper));
            _customerService = new Lazy<ICustomerService>(() => new CustomerService(repositoryManager, logger, mapper));
            _customerPlanService = new Lazy<ICustomerPlanService>(() => new CustomerPlanService(repositoryManager, logger, mapper));
            _deviceService = new Lazy<IDeviceService>(() => new DeviceService(repositoryManager, logger, mapper));
            _planService = new Lazy<IPlanService>(() => new PlanService(repositoryManager, logger, mapper));
            _authenticationService = new Lazy<IAuthenticationService>(() => new AuthenticationService(logger, mapper,userManager, configuration));
        }
        
        public IBillingService Billing => _billingService.Value;
        public ICustomerService Customer => _customerService.Value;
        public ICustomerPlanService CustomerPlan => _customerPlanService.Value;
        public IDeviceService Device => _deviceService.Value;
        public IPlanService Plan => _planService.Value;
        public IAuthenticationService Authentication => _authenticationService.Value;
    }
}
