using Faker.Extensions;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }

        public DbSet<LocalUser> LocalUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VillaNumber>().HasData(

                new VillaNumber()
                {
                    VillaNo = 101,
                    VillaId = 1,
                    SpecialDetails = Faker.Lorem.Sentence(10),
                    CreatedDate = DateTime.Now
                },
                new VillaNumber()
                {
                    VillaNo = 102,
                    VillaId = 1,
                    SpecialDetails = Faker.Lorem.Sentence(10),
                    CreatedDate = DateTime.Now
                },
                new VillaNumber()
                {
                    VillaNo = 103,
                    VillaId = 1,
                    SpecialDetails = Faker.Lorem.Sentence(10),
                    CreatedDate = DateTime.Now
                },
                new VillaNumber()
                {
                    VillaNo = 104,
                    VillaId = 1,
                    SpecialDetails = Faker.Lorem.Sentence(10),
                    CreatedDate = DateTime.Now
                },
                new VillaNumber()
                {
                    VillaNo = 105,
                    VillaId = 1,
                    SpecialDetails = Faker.Lorem.Sentence(10),
                    CreatedDate = DateTime.Now
                },
                new VillaNumber()
                {
                    VillaNo = 106,
                    VillaId = 1,
                    SpecialDetails = Faker.Lorem.Sentence(10),
                    CreatedDate = DateTime.Now
                },
                new VillaNumber()
                {
                    VillaNo = 107,
                    VillaId = 1,
                    SpecialDetails = Faker.Lorem.Sentence(10),
                    CreatedDate = DateTime.Now
                },
                new VillaNumber()
                {
                    VillaNo = 109,
                    VillaId = 1,
                    SpecialDetails = Faker.Lorem.Sentence(10),
                    CreatedDate = DateTime.Now
                },
                new VillaNumber()
                {
                    VillaNo = 110,
                    VillaId = 1,
                    SpecialDetails = Faker.Lorem.Sentence(10),
                    CreatedDate = DateTime.Now
                },
                new VillaNumber()
                {
                    VillaNo = 201,
                    VillaId = 2,
                    SpecialDetails = Faker.Lorem.Sentence(10),
                    CreatedDate = DateTime.Now
                },
                new VillaNumber()
                {
                    VillaNo = 202,
                    VillaId = 2,
                    SpecialDetails = Faker.Lorem.Sentence(10),
                    CreatedDate = DateTime.Now
                },
                new VillaNumber()
                {
                    VillaNo = 203,
                    VillaId = 2,
                    SpecialDetails = Faker.Lorem.Sentence(10),
                    CreatedDate = DateTime.Now
                },
                new VillaNumber()
                {
                    VillaNo = 204,
                    VillaId = 2,
                    SpecialDetails = Faker.Lorem.Sentence(10),
                    CreatedDate = DateTime.Now
                },
                new VillaNumber()
                {
                    VillaNo = 205,
                    VillaId = 2,
                    SpecialDetails = Faker.Lorem.Sentence(10),
                    CreatedDate = DateTime.Now
                },
                new VillaNumber()
                {
                    VillaNo = 206,
                    VillaId = 2,
                    SpecialDetails = Faker.Lorem.Sentence(10),
                    CreatedDate = DateTime.Now
                },
                new VillaNumber()
                {
                    VillaNo = 207,
                    VillaId = 2,
                    SpecialDetails = Faker.Lorem.Sentence(10),
                    CreatedDate = DateTime.Now
                },
                new VillaNumber()
                {
                    VillaNo = 208,
                    VillaId = 2,
                    SpecialDetails = Faker.Lorem.Sentence(10),
                    CreatedDate = DateTime.Now
                },
                new VillaNumber()
                {
                    VillaNo = 209,
                    VillaId = 2,
                    SpecialDetails = Faker.Lorem.Sentence(10),
                    CreatedDate = DateTime.Now
                },
                new VillaNumber()
                {
                    VillaNo = 210,
                    VillaId = 2,
                    SpecialDetails = Faker.Lorem.Sentence(10),
                    CreatedDate = DateTime.Now
                });

            modelBuilder.Entity<Villa>().HasData(
            new Villa()
            {
                Id = 1,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/778/200/200.jpg?hmac=fgFK_HI_g_N4MzYuYbssOB8ymhT_m0JK61tNJHfdPYU",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 2,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/287/200/200.jpg?hmac=kXFCSMZE2rF7NM-EFSH6c_nl5HlKQWvwCdE8JYL-YNQ",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 3,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/446/200/200.jpg?hmac=PkaLcCtgL4IvAz-gsxbCXz_tl0qdVUGOrxhYLrywa-c",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 4,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/602/200/200.jpg?hmac=UQpVCHEMGI1-S-kt8OQLic6TfuG2elfLbLTNDl1mqZE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 5,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 6,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 7,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 8,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 9,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 10,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 11,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 12,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 13,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 14,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 15,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 16,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 17,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 18,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 19,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 20,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 21,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 22,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 23,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 24,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 25,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 26,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 27,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 28,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 29,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 30,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 31,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 32,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 33,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 34,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 35,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 36,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 37,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 38,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 39,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 40,
                Name = Faker.Name.FullName(),
                Details = Faker.Lorem.Sentence(10),
                ImageUrl = "https://i.picsum.photos/id/58/200/200.jpg?hmac=aol3E3KC2fpsVXlPhgxLR9-CLoUQa-kbswhZx-gYzCE",
                Occupancy = Faker.RandomNumber.Next(1, 10),
                Rate = Faker.RandomNumber.Next(1, 20),
                Sqft = Faker.RandomNumber.Next(100, 500),
                Amenity = "",
                CreatedDate = DateTime.Now
            });
        }
    }
}