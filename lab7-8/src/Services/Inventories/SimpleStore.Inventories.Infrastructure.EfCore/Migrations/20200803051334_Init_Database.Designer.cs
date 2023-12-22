﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleStore.Inventories.Infrastructure.EfCore.Persistence;

namespace SimpleStore.Inventories.Infrastructure.EfCore.Migrations
{
    [DbContext(typeof(InventoryDbContext))]
    [Migration("20200803051334_Init_Database")]
    partial class Init_Database
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SimpleStore.Inventories.Domain.Models.Inventory", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Inventory");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a6e22a9f-286f-4767-9b5c-3a2be7d6e596"),
                            Location = "Inventory-1-Location",
                            Name = "Inventory-1"
                        },
                        new
                        {
                            Id = new Guid("1730b960-4e6f-4d4f-9baf-be57fc4678e9"),
                            Location = "Inventory-2-Location",
                            Name = "Inventory-2"
                        },
                        new
                        {
                            Id = new Guid("df6f5b85-a625-4f23-a08f-8daed0636ecc"),
                            Location = "Inventory-3-Location",
                            Name = "Inventory-3"
                        });
                });

            modelBuilder.Entity("SimpleStore.Inventories.Domain.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4a2abe51-e895-49be-878a-0729535ba92e"),
                            Code = "PRD-1"
                        },
                        new
                        {
                            Id = new Guid("1d250f1d-1546-47f3-92d2-31fbf87a3511"),
                            Code = "PRD-2"
                        },
                        new
                        {
                            Id = new Guid("4012d62c-2bea-42eb-9e64-d7b22185c4f0"),
                            Code = "PRD-3"
                        });
                });

            modelBuilder.Entity("SimpleStore.Inventories.Domain.Models.ProductInventory", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("CanPurchase")
                        .HasColumnType("bit");

                    b.Property<Guid>("InventoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InventoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductInventory");

                    b.HasData(
                        new
                        {
                            Id = new Guid("45b1c74d-7175-4de8-a41f-b02d48728745"),
                            CanPurchase = true,
                            InventoryId = new Guid("a6e22a9f-286f-4767-9b5c-3a2be7d6e596"),
                            ProductId = new Guid("4a2abe51-e895-49be-878a-0729535ba92e"),
                            Quantity = 10
                        },
                        new
                        {
                            Id = new Guid("2d289c08-5b3d-44a1-b498-dd306702660d"),
                            CanPurchase = true,
                            InventoryId = new Guid("a6e22a9f-286f-4767-9b5c-3a2be7d6e596"),
                            ProductId = new Guid("4012d62c-2bea-42eb-9e64-d7b22185c4f0"),
                            Quantity = 5
                        },
                        new
                        {
                            Id = new Guid("6c82fd1d-238a-41d4-8957-06be16773531"),
                            CanPurchase = true,
                            InventoryId = new Guid("1730b960-4e6f-4d4f-9baf-be57fc4678e9"),
                            ProductId = new Guid("4a2abe51-e895-49be-878a-0729535ba92e"),
                            Quantity = 3
                        },
                        new
                        {
                            Id = new Guid("75adb09b-37de-4a56-9ae9-4abab87578fc"),
                            CanPurchase = true,
                            InventoryId = new Guid("1730b960-4e6f-4d4f-9baf-be57fc4678e9"),
                            ProductId = new Guid("1d250f1d-1546-47f3-92d2-31fbf87a3511"),
                            Quantity = 1
                        },
                        new
                        {
                            Id = new Guid("a6b9f7f8-821a-4b61-802b-497d452f2a63"),
                            CanPurchase = true,
                            InventoryId = new Guid("df6f5b85-a625-4f23-a08f-8daed0636ecc"),
                            ProductId = new Guid("1d250f1d-1546-47f3-92d2-31fbf87a3511"),
                            Quantity = 9
                        },
                        new
                        {
                            Id = new Guid("b356a1c0-26a4-4af6-ad25-6db86ca21fb7"),
                            CanPurchase = true,
                            InventoryId = new Guid("df6f5b85-a625-4f23-a08f-8daed0636ecc"),
                            ProductId = new Guid("4012d62c-2bea-42eb-9e64-d7b22185c4f0"),
                            Quantity = 8
                        });
                });

            modelBuilder.Entity("SimpleStore.Inventories.Domain.Models.ProductInventory", b =>
                {
                    b.HasOne("SimpleStore.Inventories.Domain.Models.Inventory", "Inventory")
                        .WithMany("Products")
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimpleStore.Inventories.Domain.Models.Product", "Product")
                        .WithMany("Inventories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
