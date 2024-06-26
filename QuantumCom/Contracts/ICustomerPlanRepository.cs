﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Contracts
{
    public interface ICustomerPlanRepository
    {
        Task<IEnumerable<CustomerPlan>> GetCustomerPlans(bool trackChanges);
        Task<CustomerPlan> GetCustomerPlanById(Guid id, bool trackChanges);
        void CreateCustomerPlan(CustomerPlan customerPlan);
        void DeleteCustomerPlan(CustomerPlan customerPlan);
    }
}
