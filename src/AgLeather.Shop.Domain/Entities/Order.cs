using AgLeather.Shop.Domain.Common;
using System.Collections;
using System.Net.Mail;

namespace AgLeather.Shop.Domain.Entities
{
    public class Order : AuditableEntity

    {
        public int CostemerId { get; set; }
        public String OrderAddress { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public DeliveryType DeliveryType { get; set; }
        public bool GiftPackt { get; set; }

        //Bir şipariş bir üye tarafından verilir.
        public Customer Customer { get; set; }

        //Bir müşterinin birden fazla siperişi olabilir.
        public ICollection<OrderDetail> OrderDetails { get; set; }

    }
    public enum DeliveryType
    {
        Address = 1,
        ShoppingCenter = 2
    }
    public enum OrderStatus
    {
        OrderCreated=1,
        PaymentComplated=2,
        Pending=3,
        OrderDelivering=4,
        CargoDelivered=5,
        Complated=6
    }

    
}
