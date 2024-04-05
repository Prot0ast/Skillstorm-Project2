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
    public class PlanService : IPlanService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public PlanService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<PlanDto> CreatePlan(PlanForCreationDto plan)
        {
            var planEntity = _mapper.Map<Plan>(plan);
            _repositoryManager.Plan.CreatePlan(planEntity);
            await _repositoryManager.SaveAsync();
            var planToReturn = _mapper.Map<PlanDto>(planEntity);
            return planToReturn;

        }

        public async Task DeletePlan(Guid id, bool trackChanges)
        {
            var plan = await _repositoryManager.Plan.GetPlanById(id, trackChanges);
            if (plan == null)
            {
                throw new PlanNotFoundException(id);
            }

            _repositoryManager.Plan.DeletePlan(plan);
           await _repositoryManager.SaveAsync();
        }

        public async Task<IEnumerable<PlanDto>> GetAllPlans(bool trackChanges)
        {
           var plans = await _repositoryManager.Plan.GetAllPlans(trackChanges);
           var planDto = _mapper.Map<IEnumerable<PlanDto>>(plans);
           return planDto;
        }

        public async Task<PlanDto> GetPlan(Guid id, bool trackChanges)
        {
            var plan = await _repositoryManager.Plan.GetPlanById(id, trackChanges);
            if(plan == null)
            {
                throw new PlanNotFoundException(id);
            }

            var planDto = _mapper.Map<PlanDto>(plan);
            return planDto;
        }

        public async Task<PlanDto> GetPlanByName(string name, bool trackChanges)
        {
            var plan = await _repositoryManager.Plan.GetPlanByName(name, trackChanges);
            if(plan == null)
            {
                throw new PlanNotFoundException(name);
            }

            var planDto = _mapper.Map<PlanDto>(plan);
            return planDto;
        }

        public async Task<PlanDto> GetPlanByPrice(decimal price, bool trackChanges)
        {
            var plan = await _repositoryManager.Plan.GetPlanByPrice(price, trackChanges);
            if(plan == null)
            {
                throw new PlanNotFoundException(price);
            }

            var planDto = _mapper.Map<PlanDto>(plan);
            return planDto;
        }
    }
}
