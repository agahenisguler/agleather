﻿// <auto-generated />
using System;
using AgLeather.Shop.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AgLeather.Shop.Persistance.Migrations
{
    [DbContext(typeof(AgLeatherContext))]
    [Migration("20230819154425_agah")]
    partial class agah
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AgLeather.Shop.Domain.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("CUSTOMER_ID")
                        .HasColumnOrder(2);

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("IS_DALETED")
                        .HasColumnOrder(30)
                        .HasDefaultValueSql("0");

                    b.Property<DateTime?>("LastLoginDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("LAST_LOGIN_DATE")
                        .HasColumnOrder(5);

                    b.Property<string>("LastUserIp")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("LAST_LOGIN_IP")
                        .HasColumnOrder(6);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("PASSWORD")
                        .HasColumnOrder(4);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("USER_NAME")
                        .HasColumnOrder(3);

                    b.HasKey("Id");

                    b.ToTable("ACCOUNTS", (string)null);
                });

            modelBuilder.Entity("AgLeather.Shop.Domain.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("int")
                        .HasColumnName("CITY_ID")
                        .HasColumnOrder(2);

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("IS_DALETED")
                        .HasColumnOrder(30)
                        .HasDefaultValueSql("0");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TEXT")
                        .HasColumnOrder(3);

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("ADDRESSES", (string)null);
                });

            modelBuilder.Entity("AgLeather.Shop.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("CREATE_BY")
                        .HasColumnOrder(27);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATE_DATE")
                        .HasColumnOrder(26);

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("IS_DELETED")
                        .HasColumnOrder(30)
                        .HasDefaultValueSql("0");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MODIFIED_BY")
                        .HasColumnOrder(29);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("MODIFIED_DATE")
                        .HasColumnOrder(28);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("CATEGORY_NAME")
                        .HasColumnOrder(2);

                    b.HasKey("Id");

                    b.ToTable("CATEGORIES", (string)null);
                });

            modelBuilder.Entity("AgLeather.Shop.Domain.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("IS_DALETED")
                        .HasColumnOrder(30)
                        .HasDefaultValueSql("0");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("NAME")
                        .HasColumnOrder(2);

                    b.HasKey("Id");

                    b.ToTable("CITIES", (string)null);
                });

            modelBuilder.Entity("AgLeather.Shop.Domain.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("CREATE_BY")
                        .HasColumnOrder(27);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATE_DATE")
                        .HasColumnOrder(26);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("CUSTOMER_ID")
                        .HasColumnOrder(3);

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DETAIL")
                        .HasColumnOrder(4);

                    b.Property<int>("DislikeCount")
                        .HasColumnType("int")
                        .HasColumnName("DISLIKE_COUNT")
                        .HasColumnOrder(6);

                    b.Property<bool?>("IsApproved")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("IS_APPROVED")
                        .HasColumnOrder(7)
                        .HasDefaultValueSql("0");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("IS_DELETED")
                        .HasColumnOrder(30)
                        .HasDefaultValueSql("0");

                    b.Property<int>("LikeCount")
                        .HasColumnType("int")
                        .HasColumnName("LIKE_COUNT")
                        .HasColumnOrder(5);

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MODIFIED_BY")
                        .HasColumnOrder(29);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("MODIFIED_DATE")
                        .HasColumnOrder(28);

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("PRODUCT_ID")
                        .HasColumnOrder(2);

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("COMMENTS", (string)null);
                });

            modelBuilder.Entity("AgLeather.Shop.Domain.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int")
                        .HasColumnName("ACCOUNT_ID")
                        .HasColumnOrder(2);

                    b.Property<int>("Age")
                        .HasColumnType("int")
                        .HasColumnName("AGE")
                        .HasColumnOrder(8);

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("BIRTHDATE")
                        .HasColumnOrder(9);

                    b.Property<int>("CityId")
                        .HasColumnType("int")
                        .HasColumnName("CITY_ID")
                        .HasColumnOrder(3);

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("CREATE_BY")
                        .HasColumnOrder(27);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATE_DATE")
                        .HasColumnOrder(26);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("EMAIL")
                        .HasColumnOrder(6);

                    b.Property<int>("Gender")
                        .HasColumnType("int")
                        .HasColumnName("GENDER")
                        .HasColumnOrder(10);

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("IS_DELETED")
                        .HasColumnOrder(30)
                        .HasDefaultValueSql("0");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MODIFIED_BY")
                        .HasColumnOrder(29);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("MODIFIED_DATE")
                        .HasColumnOrder(28);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("NAME")
                        .HasColumnOrder(4);

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int")
                        .HasColumnName("PHONE_NUMBER")
                        .HasColumnOrder(7);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("SURNAME")
                        .HasColumnOrder(5);

                    b.HasKey("Id");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.HasIndex("CityId");

                    b.ToTable("CUSTOMERS", (string)null);
                });

            modelBuilder.Entity("AgLeather.Shop.Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int")
                        .HasColumnName("ADDRESS_ID")
                        .HasColumnOrder(3);

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("CREATE_BY")
                        .HasColumnOrder(27);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATE_DATE")
                        .HasColumnOrder(26);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("CUSTOMER_ID")
                        .HasColumnOrder(2);

                    b.Property<int>("DeliveryType")
                        .HasColumnType("int")
                        .HasColumnName("DELIVERY_TYPE")
                        .HasColumnOrder(6);

                    b.Property<bool>("GiftPackt")
                        .HasColumnType("bit")
                        .HasColumnName("GIFT_PACKT")
                        .HasColumnOrder(7);

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("IS_DELETED")
                        .HasColumnOrder(30)
                        .HasDefaultValueSql("0");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MODIFIED_BY")
                        .HasColumnOrder(29);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("MODIFIED_DATE")
                        .HasColumnOrder(28);

                    b.Property<DateTime>("OrderDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("ORDER_DATE")
                        .HasColumnOrder(4)
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("ORDER_STATUS")
                        .HasColumnOrder(5);

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("CustomerId");

                    b.ToTable("ORDERS", (string)null);
                });

            modelBuilder.Entity("AgLeather.Shop.Domain.Entities.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("CREATE_BY")
                        .HasColumnOrder(27);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATE_DATE")
                        .HasColumnOrder(26);

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("IS_DELETED")
                        .HasColumnOrder(30)
                        .HasDefaultValueSql("0");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MODIFIED_BY")
                        .HasColumnOrder(29);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("MODIFIED_DATE")
                        .HasColumnOrder(28);

                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("ORDER_ID")
                        .HasColumnOrder(6);

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("PRODUCT_ID")
                        .HasColumnOrder(3);

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("QUANTITY")
                        .HasColumnOrder(4);

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int")
                        .HasColumnName("TOTAL_PRICE")
                        .HasColumnOrder(5);

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("ORDER_DETAILS", (string)null);
                });

            modelBuilder.Entity("AgLeather.Shop.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("CATEGORY_ID")
                        .HasColumnOrder(2);

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("CREATE_BY")
                        .HasColumnOrder(27);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATE_DATE")
                        .HasColumnOrder(26);

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DETAIL")
                        .HasColumnOrder(4);

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("IS_DELETED")
                        .HasColumnOrder(30)
                        .HasDefaultValueSql("0");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MODIFIED_BY")
                        .HasColumnOrder(29);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("MODIFIED_DATE")
                        .HasColumnOrder(28);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("NAME")
                        .HasColumnOrder(3);

                    b.Property<int>("UnitInStock")
                        .HasColumnType("int")
                        .HasColumnName("UNIT_IN_STOCK")
                        .HasColumnOrder(5);

                    b.Property<int>("UnıtPrice")
                        .HasColumnType("int")
                        .HasColumnName("UNIT_PRICE")
                        .HasColumnOrder(6);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("PRODUCTS", (string)null);
                });

            modelBuilder.Entity("AgLeather.Shop.Domain.Entities.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("CREATE_BY")
                        .HasColumnOrder(27);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATE_DATE")
                        .HasColumnOrder(26);

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("IS_DELETED")
                        .HasColumnOrder(30)
                        .HasDefaultValueSql("0");

                    b.Property<bool?>("IsThumbnail")
                        .HasColumnType("bit")
                        .HasColumnName("IS_THUMB_NAIL")
                        .HasColumnOrder(5);

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MODIFIED_BY")
                        .HasColumnOrder(29);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("MODIFIED_DATE")
                        .HasColumnOrder(28);

                    b.Property<int>("Order")
                        .HasColumnType("int")
                        .HasColumnName("ORDER")
                        .HasColumnOrder(4);

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("PATH")
                        .HasColumnOrder(3);

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("PRODUCT_ID")
                        .HasColumnOrder(2);

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("PRODUCT_IMAGES", (string)null);
                });

            modelBuilder.Entity("AgLeather.Shop.Domain.Entities.Address", b =>
                {
                    b.HasOne("AgLeather.Shop.Domain.Entities.City", "City")
                        .WithMany("Addresses")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("ADDRESS_CITY_CITY_ID");

                    b.Navigation("City");
                });

            modelBuilder.Entity("AgLeather.Shop.Domain.Entities.Comment", b =>
                {
                    b.HasOne("AgLeather.Shop.Domain.Entities.Customer", "Customer")
                        .WithMany("Comments")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("COMMENT_CUSTOMER_CUSTOMER_ID");

                    b.HasOne("AgLeather.Shop.Domain.Entities.Product", "Product")
                        .WithMany("Comments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("COMMENT_PRODUCT_PRODUCT_ID");

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AgLeather.Shop.Domain.Entities.Customer", b =>
                {
                    b.HasOne("AgLeather.Shop.Domain.Entities.Account", "Account")
                        .WithOne("Customer")
                        .HasForeignKey("AgLeather.Shop.Domain.Entities.Customer", "AccountId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("CUSTOMER_ACCOUNT_ACCOUNT_ID");

                    b.HasOne("AgLeather.Shop.Domain.Entities.City", "City")
                        .WithMany("Customers")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("CUSTOMER_CIT_CITY_ID");

                    b.Navigation("Account");

                    b.Navigation("City");
                });

            modelBuilder.Entity("AgLeather.Shop.Domain.Entities.Order", b =>
                {
                    b.HasOne("AgLeather.Shop.Domain.Entities.Address", "Address")
                        .WithMany("Orders")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("ORDER_ADDRESS_ADDRES_ID");

                    b.HasOne("AgLeather.Shop.Domain.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("ORDER_CUSTOMER_CUSTOMER_ID");

                    b.Navigation("Address");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("AgLeather.Shop.Domain.Entities.OrderDetail", b =>
                {
                    b.HasOne("AgLeather.Shop.Domain.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("ORDER_DETAIL_ORDER_ORDER_ID");

                    b.HasOne("AgLeather.Shop.Domain.Entities.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("ORDER_DETAIL_PRODUCT_PRODUCT_ID");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AgLeather.Shop.Domain.Entities.Product", b =>
                {
                    b.HasOne("AgLeather.Shop.Domain.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("PRODUCT_CATEGORY_CATEGORY_ID");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("AgLeather.Shop.Domain.Entities.ProductImage", b =>
                {
                    b.HasOne("AgLeather.Shop.Domain.Entities.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("PRODUCT_IMAGE_PRODUCT_PRODUCT_ID");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AgLeather.Shop.Domain.Entities.Account", b =>
                {
                    b.Navigation("Customer")
                        .IsRequired();
                });

            modelBuilder.Entity("AgLeather.Shop.Domain.Entities.Address", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("AgLeather.Shop.Domain.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("AgLeather.Shop.Domain.Entities.City", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("AgLeather.Shop.Domain.Entities.Customer", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("AgLeather.Shop.Domain.Entities.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("AgLeather.Shop.Domain.Entities.Product", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("OrderDetails");

                    b.Navigation("ProductImages");
                });
#pragma warning restore 612, 618
        }
    }
}