using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLeather.Shop.Application.Models.RequestModels.Orders
{
    public class CreateOrderVM
    {
        public int? CustomerId { get; set; }
        public int? AddressId { get; set; }
    }
}
