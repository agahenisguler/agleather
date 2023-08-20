using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLeather.Shop.Application.Validators.OrderDetails
{
    public class DeleteOrderDetailValidator : AbstractValidator<DeleteOrderDetailVM>
    {
        public DeleteOrderDetailValidator()
        {
            RuleFor(x => x.OrderDetailId)
                .NotEmpty().WithMessage("Sipariş detay numarası boş olamaz.")
                .GreaterThan(0).WithMessage("Sipariş detay numarası sıfırdan büyük olmalıdır.");
        }
    }
}
