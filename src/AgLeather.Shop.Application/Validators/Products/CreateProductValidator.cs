﻿using AgLeather.Shop.Application.Models.RequestModels.Products;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLeather.Shop.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<CreateProductVM>
    {
        public CreateProductValidator()
        {
            RuleFor(x => x.CategoryId)
                .NotNull().WithMessage("Ürüne ait kategori bilgisi boş olamaz.")
                .GreaterThan(0).WithMessage("Kategori bilgisi sıfırdan büyük bir sayı olmalıdır.");

            RuleFor(x => x.Name)
                .NotNull().WithMessage("Ürüne adı boş olamaz.")
                .MaximumLength(255).WithMessage("Ürün adı en fazla 255 karakter olabilir.");

            RuleFor(x => x.Detail)
                .NotNull().WithMessage("Ürüne detay bilgisi boş olamaz.");

            RuleFor(x => x.UnitInStock)
                .NotNull().WithMessage("Ürün stok adedi boş olamaz.");

            RuleFor(x => x.UnitPrice)
                .NotNull().WithMessage("Ürün fiyatı boş olamaz.");
        }
    }
}
