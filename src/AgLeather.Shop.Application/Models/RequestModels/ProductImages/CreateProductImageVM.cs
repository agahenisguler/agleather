﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLeather.Shop.Application.Models.RequestModels.ProductImages
{
    public class CreateProductImageVM
    {
        public int? ProductId { get; set; }
        public int? Order { get; set; } = 0;
        public bool? IsThumbnail { get; set; }
        public string UploadedImage { get; set; }
    }
}
