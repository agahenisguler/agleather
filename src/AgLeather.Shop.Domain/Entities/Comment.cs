using AgLeather.Shop.Domain.Common;

namespace AgLeather.Shop.Domain.Entities
{
    public class Comment : AuditableEntity
    {
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public string Detail { get; set; }
        public int LikeCount { get; set; }
        public int DislikeCount { get; set; }
        public bool? IsApproved { get; set; }

        public Product Product { get; set; }
        public Customer Customer { get; set; }
        public object Name { get; set; }
        public object? Id { get; set; }
        public object CreateDate { get; set; }
        public object CreateBy { get; set; }
        public object ModifiedDate { get; set; }
        public object ModifiedBy { get; set; }
        public object IsDeleted { get; set; }
    }
}
