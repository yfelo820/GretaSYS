using AutoMapper;
using Greta.BO.Api.Dto;
using Greta.BO.Api.Entities;
using Greta.Sdk.Core.Models.Pager;

namespace Greta.BO.Api.Core.Startup.AutoMapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap(typeof(Pager<>), typeof(Pager<>));
            CreateMap<Vendor, VendorDto>().ReverseMap();
            CreateMap<Family, FamilyDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<City, CityDto>().ReverseMap();
            CreateMap<Province, ProvinceDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();

        }
    }
}
