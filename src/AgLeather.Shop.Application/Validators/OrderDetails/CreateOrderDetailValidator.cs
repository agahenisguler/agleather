using AgLeather.Shop.Application.Models.RequestModels.OrderDetails;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLeather.Shop.Application.Validators.OrderDetails
{
    public class CreateOrderDetailValidator : AbstractValidator<CreateOrderDetailVM>
    {
        public CreateOrderDetailValidator()
        {
            RuleFor(x => x.OrderId)
                .NotEmpty().WithMessage("Sipariş numarası boş olamaz.")
                .GreaterThan(0).WithMessage("Sipariş numarası sıfırdan büyük olmalıdır.");

            RuleFor(x => x.ProductId)
                .NotEmpty().WithMessage("Ürün numarası boş olamaz.")
                .GreaterThan(0).WithMessage("Ürün numarası sıfırdan büyük olmalıdır.");

            RuleFor(x => x.Quantity)
                .NotEmpty().WithMessage("Miktar bilgisi boş olamaz.")
                .GreaterThan(0).WithMessage("Miktar bilgisi sıfırdan büyük olmalıdır.");
        }
    }
}
