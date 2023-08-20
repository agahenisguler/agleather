using AgLeather.Shop.Application.Models.RequestModels.Products;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLeather.Shop.Application.Validators.Products
{
    public class GetProductByIdValidator : AbstractValidator<GetProductByIdVM>
    {
        public GetProductByIdValidator()
        {
            RuleFor(x => x.Id)
                .NotNull().WithMessage("Ürünün kimlik bilgisi boş olamaz.")
                .GreaterThan(0).WithMessage("Ürünün kimlik bilgisi sıfırdan büyük bir sayı olmalıdır.");
        }
    }
}
