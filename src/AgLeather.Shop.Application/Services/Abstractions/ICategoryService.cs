using AgLeather.Shop.Application.Models.Dtos;
using AgLeather.Shop.Application.Models.RequestModels;
using AgLeather.Shop.Application.Wrapper;

namespace AgLeather.Shop.Application.Services.Abstractions
{
    public interface ICategoryService
    {
        //Dto servisin dışarıya gönderildiği türler 
        //VM servisin dışarıya gönderildiği parametreler

        #region Select

        Task<Result<List<CategoryDto>>> GetAllCategories();
        Task<Result<CategoryDto>> GetCategoryById(GetCategoryByIdVM getCategoryByIdVM);

        #endregion

        #region Insert, Update, Delete

        Task<Result<int>> CreateCategory(CreateCategoryVM createCategoryVM); 
        Task<Result<int>> UpdateCategory(UpdateCategoryVM updateCategoryVM);  
        Task<Result<int>> DeleteCategory(DeleteCategoryVM deleteCategoryVM);

        #endregion

    }
}
