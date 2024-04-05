namespace Service.Contracts
{
    public interface IServiceManager
    {
        IBillingService Billing { get; }
        ICustomerService Customer { get; }
        ICustomerPlanService CustomerPlan { get; }
        IDeviceService Device { get; }
        IPlanService Plan {  get; }
        IAuthenticationService Authentication { get; }
    }
}
