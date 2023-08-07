using AgLeather.Shop.Application.Models.Dtos;
using AgLeather.Shop.Application.Models.RequestModels;
using AgLeather.Shop.Application.Services.Abstractions;

namespace AgLeather.Shop.Application.Services.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly AgLeatherContext _context;

        public CategoryService()
        { 
            _context = new AgLeatherContext();
        }
        public int CreateCategory(CreateCategoryVM createCategoryVM)
        {
            throw new NotImplementedException();
        }

        public int DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public List<CategoryDto> GetAllCategory()
        {
            throw new NotImplementedException();
        }

        public CategoryDto GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public int UpdateCategory(UpdateCategoryVM updateCategoryVM)
        {
            throw new NotImplementedException();
        }
    }
}
