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
        //l
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>()
                .ForMember(c => c.FullName, 
                opt => opt.MapFrom(src=> $"{src.FirstName} {src.LastName}"));
            CreateMap<Billing, BillingDto>().ReverseMap();
            CreateMap<BillingForCreationDto, Billing>().ReverseMap();
   
            CreateMap<UserForRegistrationDto, User>().ReverseMap();
            CreateMap<CustomerForCreationDto, Customer>().ReverseMap();
            CreateMap<CustomerForUpdateDto, Customer>().ReverseMap();

            CreateMap<CustomerPlan, CustomerPlanDto>().ReverseMap();
            CreateMap<CustomerPlanDto, CustomerPlanDto>().ReverseMap();
            CreateMap<CustomerPlanForCreationDto, CustomerPlanDto>().ReverseMap();

            CreateMap<Plan, PlanDto>().ReverseMap();
            CreateMap<PlanForCreationDto, Plan>().ReverseMap();


            CreateMap<DeviceForCreationDto, Device>().ReverseMap();
            CreateMap<DeviceForUpdateDto, Device>().ReverseMap();
            CreateMap<Device, DeviceDto>().ReverseMap();
        }

    }
}
