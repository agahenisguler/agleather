using AgLeather.Shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Dynamic;

namespace AgLeather.Shop.Persistance.Mappings
{
    public class CategoryMapping : AuditableEntityMapping<Category>
    {
        public override void ConfigureDrivedEntityMapping(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("nvarchar(100)")
                .HasColumnName("NAME")
                .HasColumnOrder(2);

            builder.ToTable("CATEGORIES");
        }
    }
}
