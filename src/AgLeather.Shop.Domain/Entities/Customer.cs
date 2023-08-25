using AgLeather.Shop.Domain.Common;
using System.Collections;

namespace AgLeather.Shop.Domain.Entities
{
    public class Customer : AuditableEntity
    {

        public int CityId { get; set; }
        public string IdentityNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime Birthdate { get; set; }
        public Gender Gender { get; set; }

        //Yalnızca üye olan kullanıcılar sipariş verebilir.
        public Account Account { get; set; }
        public City City { get; set; }

        //Bir kullanıcının birden fazla siparişi olabilir.
        public ICollection<Order> Orders { get; set; }
        public ICollection<Comment> Comments { get; set; }


    }

    public enum Gender
    {
        Male = 1,
        Female = 2
    }
}
