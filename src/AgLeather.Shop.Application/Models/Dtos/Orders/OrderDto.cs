using AgLeather.Shop.Application.Models.Dtos.OrderDetails;
using AgLeather.Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLeather.Shop.Application.Models.Dtos.Orders
{
    public class OrderDto
    {
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
        public DateTime? OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public ICollection<OrderDetailDto> OrderDetails { get; set; }
    }
}
