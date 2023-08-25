using AgLeather.Shop.Application.Models.Dtos.Accounts;
using AgLeather.Shop.Application.Models.Dtos.ProductImages;
using AgLeather.Shop.Application.Models.RequestModels.Accounts;
using AgLeather.Shop.Application.Models.RequestModels.ProductImages;
using AgLeather.Shop.Application.Services.Abstractions;
using AgLeather.Shop.Application.Wrapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AgLeather.API.Controllers
{

    [ApiController]
    [Route("productImage")]
    //[Authorize("Admin")]
    public class ProductImageController : ControllerBase
    {
        private readonly IProductImageService _productImageService;

        public ProductImageController(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }

        [HttpGet("getAllByProduct/{id:int?}")]
        public async Task<ActionResult<Result<List<ProductImageDto>>>> GetAllImagesByProduct(int? id)
        {
            var result = await _productImageService.GetAllImagesByProduct(new GetAllProductImageByProductVM { ProductId = id });
            return Ok(result);
        }

        [HttpGet("getAllDetailByProduct/{id:int?}")]
        public async Task<ActionResult<Result<List<ProductImageWithProductDto>>>> GetAllImagesWithProductByProduct(int? id)
        {
            var result = await _productImageService.GetAllProductImagesWithProduct(new GetAllProductImageByProductVM { ProductId = id });
            return Ok(result);
        }

        [HttpPost("create")]
        public async Task<ActionResult<Result<int>>> CreateProductImage([FromForm] CreateProductImageVM createProductImageVM)
        {
            var result = await _productImageService.CreateProductImage(createProductImageVM);
            return Ok(result);
        }

        [HttpDelete("delete/{id:int?}")]
        public async Task<ActionResult<Result<int>>> DeleteProductImage(int? id)
        {
            var result = await _productImageService.DeleteProductImage(new DeleteProductImageVM { Id = id });
            return Ok(result);
        }
    }
}
