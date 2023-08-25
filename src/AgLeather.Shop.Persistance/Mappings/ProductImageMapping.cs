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
    public class ProductImageMapping : AuditableEntityMapping<ProductImage>
    {
        public override void ConfigureDrivedEntityMapping(EntityTypeBuilder<ProductImage> builder)
        {
            builder.Property(x => x.ProductId)
                .IsRequired()
                .HasColumnName("PRODUCT_ID")
                .HasColumnOrder(2);

            builder.Property(x => x.Path)
                .HasColumnName("PATH")
                .HasColumnType("nvarchar(150)")
                .HasColumnOrder(3);

            builder.Property(x => x.Order)
                .HasColumnName("ORDER")
                .HasColumnOrder(4);

            builder.Property(x => x.IsThumbnail)
                .HasColumnName("IS_THUMB_NAIL")
                .HasColumnOrder(5);

            builder.HasOne(x => x.Product)
                .WithMany(x => x.ProductImages)
                .HasForeignKey(x => x.ProductId)
                .HasConstraintName("PRODUCT_IMAGE_PRODUCT_PRODUCT_ID");


            builder.ToTable("PRODUCT_IMAGES");
        }
    }
}
