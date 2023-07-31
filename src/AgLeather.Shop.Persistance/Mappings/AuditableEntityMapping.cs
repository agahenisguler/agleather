using AgLeather.Shop.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgLeather.Shop.Persistance.Mappings
{
    public abstract class AuditableEntityMapping<T> : IEntityTypeConfiguration<T> where T : AuditableEntity
    {
        public abstract void ConfigureDrivedEntityMapping(EntityTypeBuilder<T> builder);
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("ID")
                .HasColumnOrder(1);

            ConfigureDrivedEntityMapping(builder);

            builder.Property(x => x.CreateDate)
               .HasColumnName("CREATE_DATE")
               .HasColumnOrder(26);

            builder.Property(x => x.CreateBy)
                .HasColumnName("CREATE_BY")
                .HasColumnOrder(27);

            builder.Property(x => x.ModifiedDate)
                .HasColumnName("MODIFIED_DATED")
                .HasColumnOrder(28);

            builder.Property(x => x.ModifiedBy)
                .HasColumnName("MODIFIED_BY")
                .HasColumnOrder(29);

            builder.Property(x => x.IsDeleted)
                .HasColumnName("IS_DALETED")
                .HasDefaultValueSql("0")
                .HasColumnOrder(30);
        }

    

    }
}
