using AgLeather.Shop.Application.Behaviors;
using AgLeather.Shop.Application.Exceptions;
using AgLeather.Shop.Application.Models.Dtos;
using AgLeather.Shop.Application.Models.RequestModels;
using AgLeather.Shop.Application.Repositories;
using AgLeather.Shop.Application.Services.Abstractions;
using AgLeather.Shop.Application.Validators;
using AgLeather.Shop.Application.Validators.Categories;
using AgLeather.Shop.Application.Wrapper;
using AgLeather.Shop.Domain.Entities;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace AgLeather.Shop.Application.Services.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Category> _repository; 
        

        public CategoryService(IMapper mapper)
        {
            
            _mapper = mapper;
        }

        //Ctrl+M+O   
        //Automapper : Bir modeli başka bir modele çevirmek için kullanılır.
       
        public async Task<Result<List<CategoryDto>>> GetAllCategories()
        {
            var result=new Result<List<CategoryDto>>();
            //var categories = await _context.Categories.ToListAsync();
            //_mapper.Map<T1,T2> T1 tipindeki kaynak objeyi T2 tipindeki kaynak objeye çevirir.
            //var categoryDtos = _mapper.Map<List<Category> ,List<CategoryDto>>(categories);

            var categoryEntities = await _repository.GetAllAsync();

            var categoryDtos = _mapper.Map<List<Category>, List<CategoryDto>>(categoryEntities);

            //var categoryDtos = await _context.Categories
            //    .ProjectTo<CategoryDto>(_mapper.ConfigurationProvider)
            //    .ToListAsync();
            result.Data = categoryDtos;

            return result;

        }

        [ValidationBehavior(typeof(GetCategoryByIdValidator))]
        public async Task<Result<CategoryDto>> GetCategoryById(GetCategoryByIdVM getCategoryByIdVM)

        {
            //var categoryEntity = await _context.Categories.FindAsync(id);
            //var categoryDto = new CategoryDto
            //{
            //    Id = id,
            //    Name = categoryEntity.Name
            //};

            var result=new Result<CategoryDto>();

            
            var categoryExists = await _repository.AnyAsync(x => x.Id == getCategoryByIdVM.Id);
            if (!categoryExists)
            {
                throw new NotFoundException($"{getCategoryByIdVM.Id} numarali kategori bulunamadı.");
            }

            //var categoryDto = await _context.Categories
            //    .ProjectTo<CategoryDto>(_mapper.ConfigurationProvider)
            //    .FirstOrDefaultAsync(x => x.Id == getCategoryByIdVM.Id);

            var catagoryEntity = await _repository.GetById(getCategoryByIdVM.Id);

            var categoryDto = _mapper.Map<Category, CategoryDto > (catagoryEntity);

            result.Data = categoryDto;
                        return result;
        }

        [ValidationBehavior(typeof(CreateCategoryValidator))]
        public async Task<Result<int>> CreateCategory(CreateCategoryVM createCategoryVM)
        {
            //Yeni bir kategori entity nesnesi
            //var categoryEntity = new Category
            //{
            //    Name = createCategoryVM.CategoryName
            //};

            var result=new Result<int>();

          
            var categoryEntity = _mapper.Map<CreateCategoryVM, Category>(createCategoryVM);

            //Üretilen entity kategori koleksiyonuna ekleniyor.
            //await _context.Categories.AddAsync(categoryEntity);
            //await _context.SaveChangesAsync();
            //Ekleme işleminden sonra herhangi bir sıkıntı yoksa bu kategori için atanan entitiy geri döner.
            await _repository.Add(categoryEntity);
            result.Data = categoryEntity.Id;
            return result;  
        }

        [ValidationBehavior(typeof(DeleteCategoryValidator))]
        public async Task<Result<int>> DeleteCategory(DeleteCategoryVM deleteCategoryVM)
        {
            var result = new Result<int>();


            //Gönderilen id bilgisine karşılık gelen bir kategory var mı?
            //var categoryExist = await _context.Categories.AnyAsync(x => x.Id == deleteCategoryVM.Id);
            var categoryExist = await _repository.AnyAsync(x => x.Id == deleteCategoryVM.Id);
            if (!categoryExist)
            {
                throw new NotFoundException($"{deleteCategoryVM.Id} numarali kategori bulunamadi.");
            }


            //Veritabanında kayıtlı kategori getirelim.
            //var existsCategory = await _context.Categories.FindAsync(deleteCategoryVM.Id);
            _repository.Delete(deleteCategoryVM.Id);
            //Silindi olarak işaretleyiniz.
            //existsCategory.IsDeleted = true;
            ////Gündellemeyi veritabanına yansıtalım
            //_context.Categories.Update(existsCategory);
            //await _context.SaveChangesAsync();

            result.Data= deleteCategoryVM.Id;
            return result;
        }

        [ValidationBehavior(typeof(UpdateCategoryValidator))]
        public async Task<Result<int>> UpdateCategory(UpdateCategoryVM updateCategoryVM)
        {

            var result = new Result<int>();

          
            //Gönderilen id bilgisine karşılık gelen bir kategory var mı?
            var categoryExist = await _repository.AnyAsync(x => x.Id == updateCategoryVM.Id);
            if (!categoryExist)
            {
                throw new Exception($"{updateCategoryVM} numarali kategori bulunamadi.");

            }


            var updatedCategory = _mapper.Map<UpdateCategoryVM, Category>(updateCategoryVM);

            //Veritabanında kayıtlı kategori getirelim.
            //var existsCategory = await _context.Categories.FindAsync(updateCategoryVM.Id);
            ////Silindi olarak işaretleyiniz.
            //existsCategory.Name = updateCategoryVM.CategoryName;
            //Gündellemeyi veritabanına yansıtalım
            //_context.Categories.Update(updatedCategory);
            //await _context.SaveChangesAsync();

            await _repository.Update(updatedCategory);

            result.Data=updatedCategory.Id;
            return result;
        }

    }
}
