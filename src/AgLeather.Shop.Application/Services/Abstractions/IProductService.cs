using AgLeather.Shop.Application.Models.Dtos.Products;
using AgLeather.Shop.Application.Models.RequestModels.Products;
using AgLeather.Shop.Application.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLeather.Shop.Application.Services.Abstractions
{
    public interface IProductService
    {
        #region Select

        Task<Result<List<ProductDto>>> GetAllProducts();
        Task<Result<List<ProductWithCategoryDto>>> GetAllProductsWithCategory();
        Task<Result<ProductDto>> GetProductById(GetProductByIdVM getProductByIdVM);

        #endregion

        #region Insert, Update, Delete

        Task<Result<int>> CreateProduct(CreateProductVM createProductVM);
        Task<Result<int>> UpdateProduct(UpdateProductVM updateProductVM);
        Task<Result<int>> DeleteProduct(DeleteProductVM deleteProductVM);

        #endregion
    }
}
