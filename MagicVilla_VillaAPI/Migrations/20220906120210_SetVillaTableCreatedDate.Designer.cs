﻿// <auto-generated />
using System;
using MagicVilla_VillaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220906120210_SetVillaTableCreatedDate")]
    partial class SetVillaTableCreatedDate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "",
                            CreatedDate = new DateTime(2022, 9, 6, 14, 2, 10, 103, DateTimeKind.Local).AddTicks(1249),
                            Details = "Distinctio quam et inventore alias et facilis deserunt explicabo eos dolores quia fugit amet.",
                            ImageUrl = "https://i.picsum.photos/id/778/200/200.jpg?hmac=fgFK_HI_g_N4MzYuYbssOB8ymhT_m0JK61tNJHfdPYU",
                            Name = "Ms. Easton DuBuque",
                            Occupancy = 3,
                            Rate = 11.0,
                            Sqft = 451,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            CreatedDate = new DateTime(2022, 9, 6, 14, 2, 10, 103, DateTimeKind.Local).AddTicks(5655),
                            Details = "Vero quo sunt veritatis voluptatibus alias itaque et dolores quae et eos libero quia eos.",
                            ImageUrl = "https://i.picsum.photos/id/287/200/200.jpg?hmac=kXFCSMZE2rF7NM-EFSH6c_nl5HlKQWvwCdE8JYL-YNQ",
                            Name = "Vicente Schuster Jr.",
                            Occupancy = 1,
                            Rate = 13.0,
                            Sqft = 493,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "",
                            CreatedDate = new DateTime(2022, 9, 6, 14, 2, 10, 103, DateTimeKind.Local).AddTicks(8814),
                            Details = "Ab iure id iure non suscipit et rerum suscipit sequi tempore non.",
                            ImageUrl = "https://i.picsum.photos/id/446/200/200.jpg?hmac=PkaLcCtgL4IvAz-gsxbCXz_tl0qdVUGOrxhYLrywa-c",
                            Name = "Miss Mekhi Halvorson MD",
                            Occupancy = 4,
                            Rate = 8.0,
                            Sqft = 121,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "",
                            CreatedDate = new DateTime(2022, 9, 6, 14, 2, 10, 104, DateTimeKind.Local).AddTicks(1308),
                            Details = "Et ducimus voluptatibus labore repellendus et distinctio qui repellat minima.",
                            ImageUrl = "https://i.picsum.photos/id/602/200/200.jpg?hmac=UQpVCHEMGI1-S-kt8OQLic6TfuG2elfLbLTNDl1mqZE",
                            Name = "Mr. Brant Nicolas II",
                            Occupancy = 8,
                            Rate = 20.0,
                            Sqft = 103,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "",
                            CreatedDate = new DateTime(2022, 9, 6, 14, 2, 10, 104, DateTimeKind.Local).AddTicks(6225),
                            Details = "Aut sint aspernatur mollitia quae voluptate voluptatem inventore dicta rerum ullam eligendi nam.",
                            ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                            Name = "Miss Mayra Shannon Ruecker MD",
                            Occupancy = 5,
                            Rate = 19.0,
                            Sqft = 389,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
