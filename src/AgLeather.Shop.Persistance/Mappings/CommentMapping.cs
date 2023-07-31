using AgLeather.Shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgLeather.Shop.Persistance.Mappings
{
    public class CommentMapping : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("ID")
                .HasColumnOrder(1);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("nvarchar(100)")
                .HasColumnName("NAME")
                .HasColumnOrder(2);

            builder.Property(x => x.CreateDate)
                .HasColumnName("CREATE_DATE")
                .HasColumnOrder(3);

            builder.Property(x => x.CreateBy)
                .HasColumnName("CREATE_BY")
                .HasColumnOrder(4);

            builder.Property(x => x.ModifiedDate)
                .HasColumnName("MODIFIED_DATED")
                .HasColumnOrder(5);

            builder.Property(x => x.ModifiedBy)
                .HasColumnName("MODIFIED_BY")
                .HasColumnOrder(6);

            builder.Property(x => x.IsDeleted)
                .HasColumnName("IS_DALETED")
                .HasDefaultValueSql("0");
        }
    }
}
