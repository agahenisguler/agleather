using AgLeather.Shop.Domain.Common;

namespace AgLeather.Shop.Domain.Entities
{
    public class Category : AuditableEntity
    {
        public string Name { get; set; }
    }
}
