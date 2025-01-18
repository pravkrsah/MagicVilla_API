using MagicVilla_VillaAPI.Models.DTOs;

namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO> {
                new VillaDTO { Id = 1, Name = "Beach View", Sqft = 300, Occupancy = 2},
                new VillaDTO { Id = 2, Name = "Pool View", Sqft = 400, Occupancy = 4},
                new VillaDTO { Id = 3, Name = "Mountain View", Sqft = 500, Occupancy = 5}
            };
    }
}
