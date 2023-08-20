using AgLeather.Shop.Application.Models.Dtos.ProductImages;
using AgLeather.Shop.Application.Models.RequestModels.ProductImages;
using AgLeather.Shop.Application.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLeather.Shop.Application.Services.Abstractions
{
    public interface IProductImageService
    {
        #region Select

        Task<Result<List<ProductImageDto>>> GetAllImagesByProduct(GetAllProductImageByProductVM getByProductVM);
        Task<Result<List<ProductImageWithProductDto>>> GetAllProductImagesWithProduct(GetAllProductImageByProductVM getByProductVM);

        #endregion

        #region Insert, Update, Delete

        Task<Result<int>> CreateProductImage(CreateProductImageVM createProductImageVM);
        Task<Result<int>> DeleteProductImage(DeleteProductImageVM deleteProductImageVM);

        #endregion
    }
}
