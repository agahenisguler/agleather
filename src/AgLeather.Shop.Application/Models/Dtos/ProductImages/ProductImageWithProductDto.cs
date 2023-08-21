﻿using AgLeather.Shop.Application.Models.Dtos.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLeather.Shop.Application.Models.Dtos.ProductImages
{
    public class ProductImageWithProductDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Path { get; set; }
        public int Order { get; set; }
        public bool? IsThumbnail { get; set; }

        public ProductDto Product { get; set; }
    }
}
