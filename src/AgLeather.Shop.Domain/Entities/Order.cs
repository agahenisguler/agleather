﻿using AgLeather.Shop.Domain.Common;
using System.Collections;
using System.Net.Mail;

namespace AgLeather.Shop.Domain.Entities
{
    public class Order : AuditableEntity

    {
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }

        //Bir şipariş bir üye tarafından verilir.
        public Customer Customer { get; set; }
        public Address Address { get; set; }

        //Bir müşterinin birden fazla siperişi olabilir.
        public ICollection<OrderDetail> OrderDetails { get; set; }

    }

    public enum OrderStatus
    {
        OrderCreated = 1,
        PaymentComplated = 2,
        Pending = 3,
        OrderDelivering = 4,
        CargoDelivered = 5,
        Complated = 6
    }


}
