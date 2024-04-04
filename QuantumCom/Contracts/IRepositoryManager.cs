namespace Contracts
{
    public interface IRepositoryManager
    {
        IBillingRepository Billing { get; }

        ICustomerRepository Customer { get; }

        ICustomerPlanRepository CustomerPlan { get; }

        IDeviceRepository Device { get; }

        IPlanRepository Plan { get; }

        Task SaveAsync();
    }
}
