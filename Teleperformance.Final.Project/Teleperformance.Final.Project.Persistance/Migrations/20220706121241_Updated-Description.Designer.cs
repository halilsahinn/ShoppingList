﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Teleperformance.Final.Project.Persistance.Contexs;

#nullable disable

namespace Teleperformance.Final.Project.Persistance.Migrations
{
    [DbContext(typeof(ShoppingListDbContext))]
    [Migration("20220706121241_Updated-Description")]
    partial class UpdatedDescription
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Teleperformance.Final.Project.Domain.Category.CategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("CategoryName")
                        .HasColumnOrder(2);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreateDate")
                        .HasColumnOrder(4);

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("Description")
                        .HasColumnOrder(8);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive")
                        .HasColumnOrder(9);

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpatedDate")
                        .HasColumnOrder(5);

                    b.HasKey("Id");

                    b.ToTable("Category", "ShopList");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Alışveriş Listesi",
                            CreatedDate = new DateTime(2022, 7, 6, 12, 12, 40, 790, DateTimeKind.Utc).AddTicks(2482),
                            Description = "",
                            IsActive = true
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Film Listesi",
                            CreatedDate = new DateTime(2022, 7, 6, 12, 12, 40, 790, DateTimeKind.Utc).AddTicks(2485),
                            Description = "",
                            IsActive = true
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Yapılacaklar Listesi",
                            CreatedDate = new DateTime(2022, 7, 6, 12, 12, 40, 790, DateTimeKind.Utc).AddTicks(2486),
                            Description = "",
                            IsActive = true
                        });
                });

            modelBuilder.Entity("Teleperformance.Final.Project.Domain.Product.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CategoryEntityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreateDate")
                        .HasColumnOrder(4);

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("Description")
                        .HasColumnOrder(8);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive")
                        .HasColumnOrder(9);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("ProductName")
                        .HasColumnOrder(2);

                    b.Property<int?>("ShopListEntityId")
                        .HasColumnType("int");

                    b.Property<byte>("Unit")
                        .HasColumnType("tinyint");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpatedDate")
                        .HasColumnOrder(5);

                    b.HasKey("Id");

                    b.HasIndex("CategoryEntityId");

                    b.HasIndex("ShopListEntityId");

                    b.ToTable("Product", "ShopList");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 7, 6, 12, 12, 40, 790, DateTimeKind.Utc).AddTicks(2666),
                            Description = "",
                            IsActive = true,
                            ProductName = "Süt",
                            Unit = (byte)1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 7, 6, 12, 12, 40, 790, DateTimeKind.Utc).AddTicks(2668),
                            Description = "",
                            IsActive = true,
                            ProductName = "Çikolata",
                            Unit = (byte)2
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 7, 6, 12, 12, 40, 790, DateTimeKind.Utc).AddTicks(2669),
                            Description = "",
                            IsActive = true,
                            ProductName = "Gazoz",
                            Unit = (byte)3
                        });
                });

            modelBuilder.Entity("Teleperformance.Final.Project.Domain.ShopList.ShopListEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreateDate")
                        .HasColumnOrder(4);

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("Description")
                        .HasColumnOrder(8);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive")
                        .HasColumnOrder(9);

                    b.Property<bool>("IsTaken")
                        .HasColumnType("bit");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<byte>("Unit")
                        .HasColumnType("tinyint");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpatedDate")
                        .HasColumnOrder(5);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Items", "ShopList");
                });

            modelBuilder.Entity("Teleperformance.Final.Project.Domain.Product.ProductEntity", b =>
                {
                    b.HasOne("Teleperformance.Final.Project.Domain.Category.CategoryEntity", null)
                        .WithMany("Products")
                        .HasForeignKey("CategoryEntityId");

                    b.HasOne("Teleperformance.Final.Project.Domain.ShopList.ShopListEntity", null)
                        .WithMany("Products")
                        .HasForeignKey("ShopListEntityId");
                });

            modelBuilder.Entity("Teleperformance.Final.Project.Domain.ShopList.ShopListEntity", b =>
                {
                    b.HasOne("Teleperformance.Final.Project.Domain.Category.CategoryEntity", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Teleperformance.Final.Project.Domain.Category.CategoryEntity", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Teleperformance.Final.Project.Domain.ShopList.ShopListEntity", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
