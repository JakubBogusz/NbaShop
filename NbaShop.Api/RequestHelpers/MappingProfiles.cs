using AutoMapper;
using NbaShop.Api.DTOs;
using NbaShop.Api.Entities;

namespace NbaShop.Api.RequestHelpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<CreateProductDto, Product>();
            CreateMap<UpdateProductDto, Product>();
        }
    }
}