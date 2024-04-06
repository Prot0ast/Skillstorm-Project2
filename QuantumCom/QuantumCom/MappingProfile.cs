using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Entities;
using Shared.DataTransferObjects;

namespace QuantumCom
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>()
                .ForMember(c => c.FullName, 
                opt => opt.MapFrom(src=> $"{src.FirstName} {src.LastName}"));
            CreateMap<Billing, BillingDto>();
            CreateMap<UserForRegistrationDto, User>();
            CreateMap<CustomerForCreationDto, Customer>();
            CreateMap<CustomerForUpdateDto, Customer>().ReverseMap();
            CreateMap<CustomerPlan, CustomerPlanDto>();
            CreateMap<Plan, PlanDto>();
            CreateMap<Device, DeviceDto>();
        }

    }
}
