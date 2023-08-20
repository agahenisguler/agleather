using AgLeather.Shop.Application.Models.RequestModels.OrderDetails;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLeather.Shop.Application.Validators.OrderDetails
{
    public class GetOrderDetailsByOrderIdValidator : AbstractValidator<GetOrderDetailsByOrderIdVM>
    {
        public GetOrderDetailsByOrderIdValidator()
        {
            RuleFor(x => x.OrderId)
                .NotEmpty().WithMessage("Sipariş numarası boş olamaz.")
                .GreaterThan(0).WithMessage("Sipariş numarası sıfırdan büyük olmalıdır.");
        }
    }
}
