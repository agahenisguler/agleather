using AgLeather.Shop.Application.Models.RequestModels.ProductImages;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLeather.Shop.Application.Validators.ProductImages
{
    public class GetAllProductImageByProductValidator : AbstractValidator<GetAllProductImageByProductVM>
    {
        public GetAllProductImageByProductValidator()
        {
            RuleFor(x => x.ProductId)
                .NotNull().WithMessage("Ürüne ait kimlik bilgisi boş bırakılamaz.")
                .GreaterThan(0).WithMessage("Ürüne ait kimlik bilgisi sıfırdan büyük olmalıdır.");
        }
    }
}
