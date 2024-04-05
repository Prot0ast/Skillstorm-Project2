using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IBillingService
    {
        Task<IEnumerable<BillingDto>> GetAllBillings(bool trackChanges);
        Task<BillingDto> GetBillingById(Guid custId, Guid id, bool trackChanges);
        Task<BillingDto> CreateBilling(BillingForCreationDto billing);
        Task DeleteBilling(Guid id, bool trackChanges);
        Task<BillingDto> GetBillingByAmount(decimal amount, bool trackChanges);

    }
}
