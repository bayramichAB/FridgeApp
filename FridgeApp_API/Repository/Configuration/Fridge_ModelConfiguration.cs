using FridgeApp_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FridgeApp_API.Repository.Configuration
{
    public class Fridge_ModelConfiguration : IEntityTypeConfiguration<Fridge_Model>
    {
        public void Configure(EntityTypeBuilder<Fridge_Model> builder)
        {
            builder.HasData
                (
                    new Fridge_Model
                    {
                        Id = new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                        Name = "KGN49XLEA",
                        Year = new DateTime(2015, 7, 20, 18, 30, 25)
                    },
                    new Fridge_Model
                    {
                        Id = new Guid("0b807b23-c2ee-4527-a8e5-89bf7d285e35"),
                        Name = "KGN49XLEA",
                        Year = new DateTime(2022, 8, 06, 18, 30, 25)
                    }
                );
        }
    }
}
