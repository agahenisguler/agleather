using AgLeather.Shop.Domain.Common;
using AgLeather.Shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLeather.Shop.Persistance.Mappings
{
    public class AddressMapping : BaseEntityMapping<Address>
    {
        public override void ConfigureDrivedEntityMapping(EntityTypeBuilder<Address> builder)
        {
            builder.Property(x => x.CityId)
                .HasColumnName("CITY_ID")
                .HasColumnOrder(1);

            builder.Property(x=>x.Text)
                .HasColumnName("TEXT")
                .HasColumnOrder (2);

            builder.HasOne(x => x.City)
                .WithMany(x => x.Addresses)
                .HasForeignKey(x => x.CityId)
                .HasConstraintName("ADDRESS_CITY_CITY_ID");

            builder.ToTable("ADDRESSES");


        }
    }
}
