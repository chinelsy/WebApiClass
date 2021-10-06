using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiClass.Model.Dtos;
using WebApiClass.Model.Entities;

namespace WebApiClass.Api.Configurations
{
    public class MappingConfiguration : Profile
    {
        public MappingConfiguration()
        {
            CreateMap<Account, ViewAccountDto>()
                .ForMember(des => des.Name, opt => opt.MapFrom(src => src.Customer.FullName))
                .ForMember(des => des.AccountNumber, opt => opt.MapFrom(src => src.Number))
                .ForMember(des => des.AccountBalance, opt => opt.MapFrom(src => src.Balance));
        }
    }
}
