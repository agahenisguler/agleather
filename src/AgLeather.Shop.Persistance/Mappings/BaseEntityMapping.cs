using AgLeather.Shop.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgLeather.Shop.Persistance.Mappings
{
    public abstract class BaseEntityMapping<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public abstract void ConfigureDrivedEntityMapping(EntityTypeBuilder<T> builder);

        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("ID")
                .HasColumnOrder(1);

            ConfigureDrivedEntityMapping(builder);

            builder.Property(x => x.IsDeleted)
                .HasColumnName("IS_DALETED")
                .HasDefaultValueSql("0")
                .HasColumnOrder(30);

        }
    }
}
