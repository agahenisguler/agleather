using AgLeather.Shop.Application.Models.Dtos;
using AgLeather.Shop.Application.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace AgLeather.APİ.Controllers
{

    //Endpoint url : [ControllerRoute]/[ActionRoute]
    //category//getAll

    [ApiController]
    [Route("[category]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService; 
        }

        [HttpGet("getAll")]
        public async Task<List<CategoryDto>> GetAllCategories()
        {
            var category = await _categoryService.GetAllCategory();
            return category;

        }
    }
}