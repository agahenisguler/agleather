using AgLeather.Shop.UI.Models.Dtos;
using AgLeather.Shop.UI.Models.RequestModels;
using AutoMapper;

namespace AgLeather.Shop.UI.ModelMappings
{
    public class DtoToVm : Profile
    {
        public DtoToVm()
        {
            CreateMap<CategoryDto, UpdateCategoryVM>()
                .ForMember(x => x.CategoryName, y => y.MapFrom(e => e.Name));
        }
    }
}
