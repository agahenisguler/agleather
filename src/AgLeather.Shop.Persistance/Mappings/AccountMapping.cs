﻿using AgLeather.Shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgLeather.Shop.Persistance.Mappings
{
    public class AccountMapping : BaseEntityMapping<Account>
    {
        public override void ConfigureDrivedEntityMapping(EntityTypeBuilder<Account> builder)
        {
            builder.Property(x => x.CustomerId)
              .HasColumnName("CUSTOMER_ID")
              .HasColumnOrder(2);

            builder.Property(x => x.Username)
                .IsRequired()
                .HasColumnType("nvarchar(10)")
                .HasColumnName("USER_NAME")
                .HasColumnOrder(3);

            builder.Property(x => x.Password)
                .IsRequired()
                .HasColumnType("nvarchar(100)")
                .HasColumnName("PASSWORD")
                .HasColumnOrder(4);

            builder.Property(x => x.LastLoginDate)
                .HasColumnName("LAST_LOGIN_DATE")
                .HasColumnOrder(5);

            builder.Property(x => x.LastUserIp)
                .HasColumnType("nvarchar(50)")
                .HasColumnName("LAST_LOGIN_IP")
                .HasColumnOrder(6);

            builder.Property(x => x.Role)
               .HasColumnName("ROLE_ID")
               .HasColumnOrder(7);

            builder.HasOne(x => x.Customer)
                .WithOne(x => x.Account)
                .HasForeignKey<Account>(x=>x.CustomerId);

            builder.ToTable("ACCOUNTS");
        }
    }
}
