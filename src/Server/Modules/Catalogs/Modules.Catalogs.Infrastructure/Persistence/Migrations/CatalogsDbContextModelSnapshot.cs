﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Modules.Catalogs.Infrastructure.Persistence;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Modules.Catalogs.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(CatalogsDbContext))]
    partial class CatalogsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Modules.Catalogs.Core.Entites.Brand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("LocaleName")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Modules.Catalogs.Core.Entites.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("AlertQuantity")
                        .HasColumnType("numeric");

                    b.Property<string>("BarcodeSymbology")
                        .HasColumnType("text");

                    b.Property<int>("BrandId")
                        .HasColumnType("integer");

                    b.Property<Guid?>("BrandId1")
                        .HasColumnType("uuid");

                    b.Property<decimal>("Cost")
                        .HasColumnType("numeric");

                    b.Property<string>("Detail")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("LocaleName")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("Tax")
                        .HasColumnType("text");

                    b.Property<string>("TaxMethod")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("BrandId1");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Modules.Catalogs.Core.Entites.Product", b =>
                {
                    b.HasOne("Modules.Catalogs.Core.Entites.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId1");

                    b.Navigation("Brand");
                });
#pragma warning restore 612, 618
        }
    }
}