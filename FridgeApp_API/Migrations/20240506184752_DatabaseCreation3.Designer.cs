﻿// <auto-generated />
using System;
using FridgeApp_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FridgeApp_API.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20240506184752_DatabaseCreation3")]
    partial class DatabaseCreation3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FridgeApp_API.Models.Fridge", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("FridgeId");

                    b.Property<Guid>("Fridge_ModelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fridges");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bbfb530d-d221-4e6f-a484-93d6b29f6ccd"),
                            Fridge_ModelId = new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                            Name = "Indesit",
                            OwnerName = "Arkadi"
                        },
                        new
                        {
                            Id = new Guid("7c381238-9449-4de2-ba64-dacc6b002740"),
                            Fridge_ModelId = new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                            Name = "Indesit",
                            OwnerName = "Alina"
                        },
                        new
                        {
                            Id = new Guid("217502ea-394d-439b-8968-ef018426b329"),
                            Fridge_ModelId = new Guid("0b807b23-c2ee-4527-a8e5-89bf7d285e35"),
                            Name = "ATLANT",
                            OwnerName = "Bogdana"
                        });
                });

            modelBuilder.Entity("FridgeApp_API.Models.Fridge_Model", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Fridge_ModelId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Year")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Fridge_Models");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                            Name = "KGN49XLEA",
                            Year = new DateTime(2015, 7, 20, 18, 30, 25, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("0b807b23-c2ee-4527-a8e5-89bf7d285e35"),
                            Name = "KGN49XLEA",
                            Year = new DateTime(2022, 8, 6, 18, 30, 25, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("FridgeApp_API.Models.Fridge_Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Fridge_ProductId");

                    b.Property<Guid>("FridgeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Fridge_Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("75f14f8f-8053-4877-9185-ee146cffc549"),
                            FridgeId = new Guid("bbfb530d-d221-4e6f-a484-93d6b29f6ccd"),
                            ProductId = new Guid("303460e8-4587-4f3d-a9d1-c50ca65bf2f5"),
                            Quantity = 3
                        },
                        new
                        {
                            Id = new Guid("7fadbab3-ee3c-4ba3-b1f8-6bf2a99bf007"),
                            FridgeId = new Guid("7c381238-9449-4de2-ba64-dacc6b002740"),
                            ProductId = new Guid("8e19a214-ae0f-46e7-97fe-08cd3cccf73d"),
                            Quantity = 2
                        },
                        new
                        {
                            Id = new Guid("00a683f4-e0c9-408b-b296-81c859a3ef9a"),
                            FridgeId = new Guid("7c381238-9449-4de2-ba64-dacc6b002740"),
                            ProductId = new Guid("303460e8-4587-4f3d-a9d1-c50ca65bf2f5"),
                            Quantity = 10
                        },
                        new
                        {
                            Id = new Guid("8552221f-458b-43d1-bd3f-2350a952333a"),
                            FridgeId = new Guid("bbfb530d-d221-4e6f-a484-93d6b29f6ccd"),
                            ProductId = new Guid("2dce0163-2ca2-48c9-9820-6607575e780b"),
                            Quantity = 3
                        });
                });

            modelBuilder.Entity("FridgeApp_API.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ProductId");

                    b.Property<int?>("Default_Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("303460e8-4587-4f3d-a9d1-c50ca65bf2f5"),
                            Default_Quantity = 0,
                            Name = "Egg"
                        },
                        new
                        {
                            Id = new Guid("8e19a214-ae0f-46e7-97fe-08cd3cccf73d"),
                            Default_Quantity = 1,
                            Name = "Bread"
                        },
                        new
                        {
                            Id = new Guid("2dce0163-2ca2-48c9-9820-6607575e780b"),
                            Default_Quantity = 5,
                            Name = "Water"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
