using AgLeather.Shop.Application.Models.Dtos;
using AgLeather.Shop.Application.Models.Dtos.Accounts;
using AgLeather.Shop.Application.Models.Dtos.Cities;
using AgLeather.Shop.Application.Models.Dtos.Customers;
using AgLeather.Shop.Application.Models.Dtos.OrderDetails;
using AgLeather.Shop.Application.Models.Dtos.Orders;
using AgLeather.Shop.Application.Models.Dtos.ProductImages;
using AgLeather.Shop.Application.Models.Dtos.Products;
using AgLeather.Shop.Domain.Entities;
using AutoMapper;

namespace AgLeather.Shop.Application.Automap
{
    public class DomainToDto : Profile
    {
        public DomainToDto()
        {
            CreateMap<Category, CategoryDto>();

            CreateMap<Customer, CustomerDto>();

            CreateMap<Account, AccountDto>();

            CreateMap<City, CityDto>();

            CreateMap<Product, ProductDto>();
            CreateMap<Product, ProductWithCategoryDto>();
            CreateMap<Product, ProductWithImagesDto>();

            CreateMap<ProductImage, ProductImageDto>();
            CreateMap<ProductImage, ProductImageWithProductDto>();

            CreateMap<Order, OrderDto>();

            CreateMap<OrderDetail, OrderDetailDto>();



        }


    }
    
}
