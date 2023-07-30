using AgLeather.Shop.Domain.Common;

namespace AgLeather.Shop.Domain.Entities
{
    public class ProductImage : AuditableEntity
    {
        public int ProductId { get; set; }
        public string FileName { get; set; }
        public int Order { get; set; }
        public bool IsThumbnail { get; set; }

        public Product Product { get; set; }
    }
}
