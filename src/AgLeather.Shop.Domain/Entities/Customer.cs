using AgLeather.Shop.Domain.Common;

namespace AgLeather.Shop.Domain.Entities
{
    public class Customer : AuditableEntity
    {
        public int AccountId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public DateTime Birtdate { get; set; }
        public Gender Gender { get; set; }
       
        //Yalnızca üye olan kullanıcılar sipariş verebilir.
        public Account Account { get; set; }
        
        //Bir kullanıcının birden fazla siparişi olabilir.
        public ICollection<Order> Orders { get; set; }

    }
    
        public enum Gender
        {
            Male=1,
            Female=2
        } 
}
