using AgLeather.Shop.Application.Models.RequestModels.Orders;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLeather.Shop.Application.Validators.Orders
{
    public class GetOrdersByCustomerValidator : AbstractValidator<GetOrdersByCustomerVM>
    {
        public GetOrdersByCustomerValidator()
        {
            RuleFor(x => x.CustomerId)
                .NotEmpty().WithMessage("Müşteri numarası boş olamaz.")
                .GreaterThan(0).WithMessage("Müşteri numarası sıfırdan büyük bir sayı olmalıdır.");
        }
    }
}
