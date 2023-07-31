using AgLeather.Shop.Domain.Common;

namespace AgLeather.Shop.Domain.Entities
{
    public class Account : BaseEntity
    {
        public int CostemerId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public string LastUserIp { get; set; }
       
        //Ziyaretçi ile müşteriler arasındakı farkı göstermek için kullanıldı.
        public Customer Customer { get; set; }
        public object CustomerId { get; set; }
    }
}
