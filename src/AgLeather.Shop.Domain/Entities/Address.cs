﻿using AgLeather.Shop.Domain.Common;

namespace AgLeather.Shop.Domain.Entities
{
    public class Address : BaseEntity
    {
        public int CityId { get; set; }
        public string Text { get; set; }

        public City City { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
