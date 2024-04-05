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
    public class BillingService : IBillingService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public BillingService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<BillingDto> CreateBilling(BillingForCreationDto billing)
        {
            var billingEntity = _mapper.Map<Billing>(billing);
            _repositoryManager.Billing.CreateBill(billingEntity);
            await _repositoryManager.SaveAsync();
            var billingToReturn =  _mapper.Map<BillingDto>(billingEntity);
            return billingToReturn;
                
        }

        public async Task<IEnumerable<BillingDto>> GetAllBillings( bool trackChanges)
        {
            var billings = await _repositoryManager.Billing.GetAllBills( trackChanges);
            var billingDto = _mapper.Map<IEnumerable<BillingDto>>(billings);
            return billingDto;
        }

        public async Task<BillingDto> GetBilling(Guid custId, Guid id, bool trackChanges)
        {
            var billing = await _repositoryManager.Billing.GetBillById(id, trackChanges);
            if(billing == null) 
            {
                throw new BillingNotFoundException(id);
            }

            var billingDto = _mapper.Map<BillingDto>(billing);
            return billingDto;
          
        }
    }
}
