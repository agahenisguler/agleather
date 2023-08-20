﻿using AgLeather.Shop.Application.Behaviors;
using AgLeather.Shop.Application.Exceptions;
using AgLeather.Shop.Application.Models.Dtos.ProductImages;
using AgLeather.Shop.Application.Models.RequestModels.ProductImages;
using AgLeather.Shop.Application.Services.Abstractions;
using AgLeather.Shop.Application.Wrapper;
using AgLeather.Shop.Domain.Entities;
using AgLeather.Shop.Domain.UWork;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLeather.Shop.Application.Services.Implementation
{
    public class ProductImageService : IProductImageService
    {
        private readonly IUnitWork _unitWork;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IConfiguration _configuration;

        public ProductImageService(IUnitWork unitWork, IMapper mapper, IWebHostEnvironment hostingEnvironment, IConfiguration configuration)
        {
            _unitWork = unitWork;
            _mapper = mapper;
            _hostingEnvironment = hostingEnvironment;
            _configuration = configuration;
        }

        [ValidationBehavior(typeof(GetAllProductImageByProductValidator))]
        public async Task<Result<List<ProductImageDto>>> GetAllImagesByProduct(GetAllProductImageByProductVM getByProductVM)
        {
            var result = new Result<List<ProductImageDto>>();

            var productImageEntities = await _unitWork.GetRepository<ProductImage>().GetByFilterAsync(x => x.ProductId == getByProductVM.ProductId);
            var productImageDtos = await productImageEntities.ProjectTo<ProductImageDto>(_mapper.ConfigurationProvider).ToListAsync();

            result.Data = productImageDtos;
            return result;
        }


        [ValidationBehavior(typeof(GetAllProductImageByProductValidator))]
        public async Task<Result<List<ProductImageWithProductDto>>> GetAllProductImagesWithProduct(GetAllProductImageByProductVM getByProductVM)
        {
            var result = new Result<List<ProductImageWithProductDto>>();

            var productImageEntities = await _unitWork.GetRepository<ProductImage>().GetByFilterAsync(x => x.ProductId == getByProductVM.ProductId);
            var productImageDtos = await productImageEntities.ProjectTo<ProductImageWithProductDto>(_mapper.ConfigurationProvider).ToListAsync();

            result.Data = productImageDtos;
            return result;
        }


        [ValidationBehavior(typeof(CreateProductImageValidator))]
        public async Task<Result<int>> CreateProductImage(CreateProductImageVM createProductImageVM)
        {
            var result = new Result<int>();

            var productExists = await _unitWork.GetRepository<Product>().AnyAsync(x => x.Id == createProductImageVM.ProductId);
            if (!productExists)
            {
                throw new NotFoundException($"{createProductImageVM.ProductId} numaralı ürün bulunamadı.");
            }
            //Dosyanın ismi belirleniyor.
            var fileName = PathUtil.GenerateFileName(createProductImageVM.UploadedImage);
            var filePath = Path.Combine(_hostingEnvironment.WebRootPath, _configuration["Paths:ProductImages"], fileName);
            //Dosya fiziksel olarak kaydediliyor.
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                createProductImageVM.UploadedImage.CopyTo(fs);
                fs.Close();
            }

            //Dosyanı yolu [Projenin kök dizininin yolu]+["images"]+"["product-images"]+["dosyanın adı.uzantısı"]

            var productImageEntity = _mapper.Map<ProductImage>(createProductImageVM);
            //images/product-images/14_8_2023_21_56_39_987.png
            productImageEntity.Path = Path.Combine(_configuration["Paths:ProductImages"], fileName);

            //Dosyaya ait bilgileri dbye yaz.
            _unitWork.GetRepository<ProductImage>().Add(productImageEntity);
            await _unitWork.CommitAsync();

            result.Data = productImageEntity.Id;
            return result;
        }


        [ValidationBehavior(typeof(DeleteProductImageValidator))]
        public async Task<Result<int>> DeleteProductImage(DeleteProductImageVM deleteProductImageVM)
        {
            var result = new Result<int>();

            var existsProductImage = await _unitWork.GetRepository<ProductImage>().GetById(deleteProductImageVM.Id);
            if (existsProductImage is null)
            {
                throw new NotFoundException($"{deleteProductImageVM.Id} numaralı ürün resmi bulunamadı.");
            }

            //Ürün resmine ait db kaydı siliniyor.
            _unitWork.GetRepository<ProductImage>().Delete(existsProductImage);
            await _unitWork.CommitAsync();

            //Fiziksel resim dosyası siliniyor.
            var filePath = Path.Combine(_hostingEnvironment.WebRootPath, existsProductImage.Path);
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            result.Data = existsProductImage.Id;
            return result;
        }
    }
}
