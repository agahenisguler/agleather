using AgLeather.Shop.Application.Models.Dtos.ProductImages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLeather.Shop.Application.Models.Dtos.Products
{
    public class ProductWithImagesDto
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public int UnitInStock { get; set; }
        public decimal UnitPrice { get; set; }

        public CategoryDto Category { get; set; }
        public ICollection<ProductImageDto> ProductImages { get; set; }
    }
}
