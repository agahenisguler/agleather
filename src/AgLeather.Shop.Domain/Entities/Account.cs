using AgLeather.Shop.Domain.Common;
using System.Data;

namespace AgLeather.Shop.Domain.Entities
{
    public class Account : BaseEntity
    {
        public int CustomerId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public string LastUserIp { get; set; }
        public Roles Role { get; set; }

        //Ziyaretçi ile müşteriler arasındakı farkı göstermek için kullanıldı.
        public Customer Customer { get; set; }
    }
    public enum Roles
    {
        User=1,
        Admin=2
    }
}
