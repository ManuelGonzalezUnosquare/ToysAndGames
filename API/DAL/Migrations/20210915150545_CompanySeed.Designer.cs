﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(ToysGamesContext))]
    [Migration("20210915150545_CompanySeed")]
    partial class CompanySeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.DbModels.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            CreatedAt = new DateTime(2021, 9, 15, 15, 5, 44, 765, DateTimeKind.Utc).AddTicks(21),
                            Guid = new Guid("d67f2165-be02-4c6a-b99c-2d056522312b"),
                            Name = "Mattel",
                            UpdatedAt = new DateTime(2021, 9, 15, 15, 5, 44, 765, DateTimeKind.Utc).AddTicks(404)
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            CreatedAt = new DateTime(2021, 9, 15, 15, 5, 44, 765, DateTimeKind.Utc).AddTicks(1069),
                            Guid = new Guid("3dd4c0cf-6ba0-4e94-bb4e-e78501df1d96"),
                            Name = "Nintendo",
                            UpdatedAt = new DateTime(2021, 9, 15, 15, 5, 44, 765, DateTimeKind.Utc).AddTicks(1072)
                        });
                });

            modelBuilder.Entity("DAL.DbModels.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int>("AgeRestriction")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Pic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PicThumbnail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,0)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            AgeRestriction = 5,
                            CompanyId = 2,
                            CreatedAt = new DateTime(2021, 9, 15, 15, 5, 44, 766, DateTimeKind.Utc).AddTicks(5374),
                            Description = "Introducing Nintendo Switch Lite, a version of the Nintendo Switch system that’s optimized.",
                            Guid = new Guid("9082f7d4-9b6f-49cd-9faf-4ebe81d5b708"),
                            Name = "Nintendo Switch Lite",
                            Pic = "https://m.media-amazon.com/images/I/71qmF0FHj7L._AC_SL1500_.jpg",
                            PicThumbnail = "https://res.cloudinary.com/walmart-labs/image/upload/w_225,dpr_auto,f_auto,q_auto:good/mg/gm/1p/images/product-images/img_large/00004549688228l.jpg",
                            Price = 8600m,
                            UpdatedAt = new DateTime(2021, 9, 15, 15, 5, 44, 766, DateTimeKind.Utc).AddTicks(5379)
                        });
                });

            modelBuilder.Entity("DAL.DbModels.Product", b =>
                {
                    b.HasOne("DAL.DbModels.Company", "Company")
                        .WithMany("Products")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("DAL.DbModels.Company", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}