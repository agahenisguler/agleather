using AgLeather.Shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgLeather.Shop.Persistance.Mappings
{
    public class OrderMapping : AuditableEntityMapping<Order>

    {
        public override void ConfigureDrivedEntityMapping(EntityTypeBuilder<Order> builder)
        {
            builder.Property(x => x.CustomerId)
                .HasColumnName("CUSTOMER_ID")
                .HasColumnOrder(1);

            builder.Property(x => x.AddressId)
                .HasColumnName("ADDRESS_ID")
                .HasColumnOrder(2);

            builder.Property(x=>x.OrderDate)
                .HasColumnName("ORDER_DATE")
                .HasDefaultValueSql("getdate()")    //Bu alan boş bırakılabilir.
                .HasColumnOrder(3);

            builder.Property(x => x.Status)
                .HasColumnName("ORDER_STATUS")
                .HasColumnOrder(4);

            builder.Property(x => x.DeliveryType)
                .HasColumnName("DELIVERY_TYPE")
                .IsRequired()
                .HasColumnOrder(5);

            builder.Property(x => x.GiftPackt)
                .HasColumnName("GIFT_PACKT")
                .HasColumnOrder(6);

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.CustomerId)
                .HasConstraintName("ORDER_CUSTOMER_CUSTOMER_ID");

            builder.HasOne(x => x.Address)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.AddressId)
                .HasConstraintName("ORDER_ADDRESS_ADDRES_ID");









        }
    }
}
