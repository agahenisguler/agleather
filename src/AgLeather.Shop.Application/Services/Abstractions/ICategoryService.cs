using AgLeather.Shop.Application.Models.Dtos;
using AgLeather.Shop.Application.Models.RequestModels;

namespace AgLeather.Shop.Application.Services.Abstractions
{
    public interface ICategoryService
    {
        //Dto servisin dışarıya gönderildiği türler 
        //VM servisin dışarıya gönderildiği parametreler

        #region Select

        List<CategoryDto> GetAllCategory();
        CategoryDto GetCategoryById(int id);

        #endregion

        #region Insert, Update, Delete

        int CreateCategory(CreateCategoryVM createCategoryVM); 
        int UpdateCategory(UpdateCategoryVM updateCategoryVM);  
        int DeleteCategory(int id);

        #endregion

    }
}
