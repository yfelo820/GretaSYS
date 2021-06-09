using AutoMapper;
using Greta.BO.Api.Dto;
using Greta.BO.Api.Entities;
using Greta.Sdk.Core.Models.Pager;

namespace Greta.BO.Api.Test.Helpers
{
    internal class TestMappingProfile : Profile
    {
        public TestMappingProfile()
        {
            CreateMap(typeof(Pager<>), typeof(Pager<>)).ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}