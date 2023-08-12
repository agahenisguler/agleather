using AgLeather.Shop.Application.Models.Dtos;
using AgLeather.Shop.Domain.Entities;
using AutoMapper;

namespace AgLeather.Shop.Application.Automap
{
    public class DomainToDto : Profile
    {
        public DomainToDto() 
        {
            CreateMap<Category, CategoryDto>();
        }

    }
}
