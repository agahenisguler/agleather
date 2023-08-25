using AgLeather.Shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgLeather.Shop.Persistance.Mappings
{
    public class CustomerMapping : AuditableEntityMapping<Customer>
    {
        public override void ConfigureDrivedEntityMapping(EntityTypeBuilder<Customer> builder)
        {

            builder.Property(x => x.CityId)
                .HasColumnName("CITY_ID")
                .HasColumnOrder(3);

            builder.Property(x => x.IdentityNumber)
                .HasColumnName("IDENTITY_NUMBER")
                .HasColumnType("nchar(11)")
                .IsRequired()
                .HasColumnOrder(4);

            builder.Property(x => x.Name)
               .HasColumnName("NAME")
               .HasColumnType("nvarchar(30)")
               .IsRequired()
               .HasColumnOrder(5);

            builder.Property(x => x.Surname)
               .HasColumnName("SURNAME")
               .HasColumnType("nvarchar(30)")
               .IsRequired()   //Boş bırakılamaz.
               .HasColumnOrder(6);

            builder.Property(x => x.Email)
               .HasColumnName("EMAIL")
               .HasColumnType("nvarchar(200)")
               .IsRequired()
               .HasColumnOrder(7);

            builder.Property(x => x.PhoneNumber)
               .HasColumnType("nchar(13)")
               .HasColumnName("PHONE_NUMBER")
               .IsRequired()
               .HasColumnOrder(8);

            builder.Property(x => x.Birthdate)
               .HasColumnName("BIRTHDATE")
               .IsRequired()
               .HasColumnOrder(9);

            builder.Property(x => x.Gender)
              .HasColumnName("GENDER")
              .IsRequired()
              .HasColumnOrder(10);


            builder.HasOne(x => x.City)
                .WithMany(x => x.Customers)
                .HasForeignKey(x => x.CityId)
                .HasConstraintName("CUSTOMER_CIT_CITY_ID");


            builder.ToTable("CUSTOMERS");




        }
    }
}
