using AgLeather.Shop.Application.Models.RequestModels.ProductImages;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLeather.Shop.Application.Validators.ProductImages
{
    public class DeleteProductImageValidator : AbstractValidator<DeleteProductImageVM>
    {
        public DeleteProductImageValidator()
        {
            RuleFor(x => x.Id)
                .NotNull().WithMessage("Silinecek ürün resmine ait kimlik bilgisi boş bırakılamaz.")
                .GreaterThan(0).WithMessage("Silinecek ürün resmi kimlik bilgisi sıfırdan büyük olmalıdır.");
        }
    }
}
