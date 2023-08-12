using AgLeather.Shop.Application.Models.RequestModels;
using AgLeather.Shop.Domain.Entities;
using AutoMapper;

namespace AgLeather.Shop.Application.Automap
{
    public class ViewModelToDomain : Profile
    {
        public ViewModelToDomain() 
        {
            //kaynak ve hedef arasında property isimleri veya türleri eşleşmezse manuel tanımlama yapmak gerekir.
            CreateMap<CreateCategoryVM, Category>()
                .ForMember(x=>x.Name, y=>y.MapFrom(e => e.CategoryName));

            CreateMap<UpdateCategoryVM, Category>()
                .ForMember(x => x.Name, y => y.MapFrom(e => e.CategoryName));
        }
    }
}
