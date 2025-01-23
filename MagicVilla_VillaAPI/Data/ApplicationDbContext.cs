using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {       
        }

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Beach Villa",
                    Details = "Rashafushi Luxury Beach Villa",
                    ImageUrl = "https://stock.adobe.com/search?k=villa&search_type=autosuggest&asset_id=906237906",
                    Amenity = "",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 400,
                    CreatedDate = DateTime.Now
                },
                new Villa
                {
                    Id = 2,
                    Name = "Mountain Villa",
                    Details = "Rashamashi Luxury Beach Villa",
                    ImageUrl = "https://stock.adobe.com/search?k=villa&search_type=autosuggest&asset_id=906237906",
                    Amenity = "",
                    Occupancy = 4,
                    Rate = 250,
                    Sqft = 350,
                    CreatedDate = DateTime.Now
                },
                new Villa
                {
                    Id = 3,
                    Name = "Ocean Villa",
                    Details = "Hasafushi Luxury Beach Villa",
                    ImageUrl = "https://stock.adobe.com/search?k=villa&search_type=autosuggest&asset_id=906237906",
                    Amenity = "",
                    Occupancy = 6,
                    Rate = 250,
                    Sqft = 450,
                    CreatedDate = DateTime.Now
                });
        }
    }
}
