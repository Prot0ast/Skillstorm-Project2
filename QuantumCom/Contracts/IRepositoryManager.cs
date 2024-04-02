namespace Contracts
{
    public class IRepositoryManager
    {
        IBillingRepository Billing { get; }

        ICustomerRepository Customer { get; }

        ICustomerPlanRepository CustomerPlan { get; }

        IDeviceRepository Device { get; }

        IPlanRepository Plan { get; }

       // Task SaveAsync();


    }
}
