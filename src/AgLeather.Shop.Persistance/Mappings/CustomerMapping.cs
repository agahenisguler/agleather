using AgLeather.Shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgLeather.Shop.Persistance.Mappings
{
    public class CustomerMapping : AuditableEntityMapping<Customer>
    {
        public override void ConfigureDrivedEntityMapping(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(x => x.AccountId)
                 .HasColumnName("ACCOUNT_ID")
                 .HasColumnOrder(2);

            builder.Property(x => x.CityId)
                .HasColumnName("CITY_ID")
                .HasColumnOrder(3);

            builder.Property(x => x.Name)
               .HasColumnName("NAME")
               .HasColumnType("nvarchar(30)")
               .IsRequired()
               .HasColumnOrder(4);

            builder.Property(x => x.Surname)
               .HasColumnName("SURNAME")
               .HasColumnType("nvarchar(30)")
               .IsRequired()   //Boş bırakılamaz.
               .HasColumnOrder(5);

            builder.Property(x => x.Email)
               .HasColumnName("EMAIL")
               .HasColumnType("nvarchar(200)")
               .IsRequired()
               .HasColumnOrder(6);

            builder.Property(x => x.PhoneNumber)
               .HasColumnName("PHONE_NUMBER")
               .HasColumnOrder(7);

            builder.Property(x => x.Age)
               .HasColumnName("AGE")
               .HasColumnOrder(8);

            builder.Property(x => x.Birthdate)
               .HasColumnName("BIRTHDATE")
               .IsRequired()
               .HasColumnOrder(9);

            builder.Property(x => x.Gender)
              .HasColumnName("GENDER")
              .IsRequired()
              .HasColumnOrder(10);

            builder.HasOne(x => x.Account)
                .WithOne(x => x.Customer)
                .HasForeignKey<Customer>(x => x.AccountId)
                .HasConstraintName("CUSTOMER_ACCOUNT_ACCOUNT_ID")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.City)
                .WithMany(x => x.Customers)
                .HasForeignKey(x => x.CityId)
                .HasConstraintName("CUSTOMER_CIT_CITY_ID");


            builder.ToTable("CUSTOMERS");




        }
    }
}
