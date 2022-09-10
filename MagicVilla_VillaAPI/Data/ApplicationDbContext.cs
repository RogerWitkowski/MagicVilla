using MagicVilla_VillaAPI.Models;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
            });
        }
    }
}