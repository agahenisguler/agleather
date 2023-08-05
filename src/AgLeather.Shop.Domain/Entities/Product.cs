using AgLeather.Shop.Domain.Common;
using System.Collections;

namespace AgLeather.Shop.Domain.Entities
{
    public class Product : AuditableEntity
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public int UnitInStock { get; set; }
        public int UnıtPrice { get; set; }

        //Navigation property uygulandı.
        public Category Category { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }

        //Bir ürün birden fazla satışta kullanılabilir.
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}
