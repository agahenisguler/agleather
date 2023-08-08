using AgLeather.Shop.Application.Models.Dtos;
using AgLeather.Shop.Application.Models.RequestModels;

namespace AgLeather.Shop.Application.Services.Abstractions
{
    public interface ICategoryService
    {
        //Dto servisin dışarıya gönderildiği türler 
        //VM servisin dışarıya gönderildiği parametreler

        #region Select

        Task<List<CategoryDto>> GetAllCategory();
        Task<CategoryDto> GetCategoryById(int id);

        #endregion

        #region Insert, Update, Delete

        Task<int> CreateCategory(CreateCategoryVM createCategoryVM); 
        Task<int> UpdateCategory(UpdateCategoryVM updateCategoryVM);  
        Task<int> DeleteCategory(int id);

        #endregion

    }
}
