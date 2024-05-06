using FridgeApp_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace FridgeApp_API.Repository.Configuration
{
    public class FridgeConfiguration:IEntityTypeConfiguration<Fridge>
    {
        public void Configure(EntityTypeBuilder<Fridge> builder)
        {
            builder.HasData
                (
                    new Fridge
                    {
                        Id = new Guid("bbfb530d-d221-4e6f-a484-93d6b29f6ccd"),
                        Name = "Indesit",
                        OwnerName = "Arkadi",
                        Fridge_ModelId = new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6")
                    },
                    new Fridge
                    {
                        Id = new Guid("7c381238-9449-4de2-ba64-dacc6b002740"),
                        Name = "Indesit",
                        OwnerName = "Alina",
                        Fridge_ModelId = new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6")
                    },
                    new Fridge
                    {
                        Id = new Guid("217502ea-394d-439b-8968-ef018426b329"),
                        Name = "ATLANT",
                        OwnerName = "Bogdana",
                        Fridge_ModelId = new Guid("3ff39ba8-a6f3-40bf-b1ce-6c2b89068f1c")
                    }
                );
        }
    }
}
