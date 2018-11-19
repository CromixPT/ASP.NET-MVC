using AutoMapper;
using Vidly_V2.Dtos;
using Vidly_V2.Models;

namespace Vidly_V2.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}