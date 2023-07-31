using AgLeather.Shop.Domain.Common;

namespace AgLeather.Shop.Domain.Entities
{
    public class OrderDetail : AuditableEntity
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }

    }
}
