using AgLeather.Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLeather.Shop.Application.Models.RequestModels.Orders
{
    public class UpdateOrderVM
    {
        public int? OrderId { get; set; }
        public OrderStatus? StatusId { get; set; }
        public int AddressId { get; set; }
    }
}
