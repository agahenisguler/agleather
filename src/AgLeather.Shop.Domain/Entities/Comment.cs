namespace AgLeather.Shop.Domain.Entities
{
    public class Comment
    {
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public string Detail { get; set; }
        public int LikeCount { get; set; }
        public int DislikeCount { get; set; }
        public bool IsActive { get; set; }

        public Product Product { get; set; }
        public Customer Customer { get; set; }
    }
}
