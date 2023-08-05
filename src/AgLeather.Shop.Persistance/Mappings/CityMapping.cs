using AgLeather.Shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgLeather.Shop.Persistance.Mappings
{
    public class CityMapping : BaseEntityMapping<City>
    {
        public override void ConfigureDrivedEntityMapping(EntityTypeBuilder<City> builder)
        {
            builder.Property(x => x.Name)
                .HasColumnName("NAME")
                .HasColumnType("nvarchar(20)")
                .IsRequired()
                .HasColumnOrder(2);

            builder.ToTable("CITIES");



        }
    }
}
