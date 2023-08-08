using AgLeather.Shop.Application.Models.Dtos;
using AgLeather.Shop.Application.Models.RequestModels;
using AgLeather.Shop.Application.Services.Abstractions;
using AgLeather.Shop.Domain.Entities;
using AgLeather.Shop.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace AgLeather.Shop.Application.Services.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly AgLeatherContext _context;

        public CategoryService(AgLeatherContext context)
        {
            _context = context;
        }

        //Ctrl+M+O

        public async Task<List<CategoryDto>> GetAllCategory()
        {
            var categories = await _context.Categories
                .Select(x => new CategoryDto
                {
                    Id = x.Id,
                    Name = x.Name

                }).ToListAsync();

            return categories;

        }

        public async Task<CategoryDto> GetCategoryById(int id)
        {
            var categoryEntity = await _context.Categories.FindAsync(id);
            var categoryDto = new CategoryDto
            {
                Id = id,
                Name = categoryEntity.Name
            };
            return categoryDto;
        }
        public async Task<int> CreateCategory(CreateCategoryVM createCategoryVM)
        {
            //Yeni bir kategori entity nesnesi
            var categoryEntity = new Category
            {
                Name = createCategoryVM.CategoryName
            };
            //Üretilen entity kategori koleksiyonuna ekleniyor.
            await _context.Categories.AddAsync(categoryEntity);
            await _context.SaveChangesAsync();
            //Ekleme işleminden sonra herhangi bir sıkıntı yoksa bu kategori için atanan entitiy geri döner.
            return categoryEntity.Id;
        }

        public async Task<int> DeleteCategory(int id)
        {
            //Gönderilen id bilgisine karşılık gelen bir kategory var mı?
            var categoryExist = await _context.Categories.AnyAsync(x => x.Id == id);
            if (!categoryExist)
            {
                throw new Exception($"{id} numarali kategori bulunamadi.");
            }

            //Veritabanında kayıtlı kategori getirelim.
            var existsCategory = await _context.Categories.FindAsync(id);
            //Silindi olarak işaretleyiniz.
            existsCategory.IsDeleted = true;
            //Gündellemeyi veritabanına yansıtalım
            _context.Categories.Update(existsCategory);
            await _context.SaveChangesAsync();

            return existsCategory.Id;
        }

        public async Task<int> UpdateCategory(UpdateCategoryVM updateCategoryVM)
        {
            //Gönderilen id bilgisine karşılık gelen bir kategory var mı?
            var categoryExist = await _context.Categories.AnyAsync(x => x.Id == updateCategoryVM.Id);
            if (!categoryExist)
            {
                throw new Exception($"{updateCategoryVM} numarali kategori bulunamadi.");

            }

            //Veritabanında kayıtlı kategori getirelim.
            var existsCategory = await _context.Categories.FindAsync(updateCategoryVM.Id);
            //Silindi olarak işaretleyiniz.
            existsCategory.Name = updateCategoryVM.CategoryName;
            //Gündellemeyi veritabanına yansıtalım
            _context.Categories.Update(existsCategory);
            await _context.SaveChangesAsync();

            return updateCategoryVM.Id;
        }

    }
}
