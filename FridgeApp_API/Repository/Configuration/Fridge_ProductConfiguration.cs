using FridgeApp_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FridgeApp_API.Repository.Configuration
{
    public class Fridge_ProductConfiguration : IEntityTypeConfiguration<Fridge_Product>
    {
        public void Configure(EntityTypeBuilder<Fridge_Product> builder)
        {
            builder.HasData
                (
                    new Fridge_Product
                    {
                        Id = new Guid("75f14f8f-8053-4877-9185-ee146cffc549"),
                        FridgeId = new Guid("bbfb530d-d221-4e6f-a484-93d6b29f6ccd"),
                        ProductId = new Guid("303460e8-4587-4f3d-a9d1-c50ca65bf2f5"),
                        Quantity = 3
                    },
                    new Fridge_Product
                    {
                        Id = new Guid("7fadbab3-ee3c-4ba3-b1f8-6bf2a99bf007"),
                        FridgeId = new Guid("7c381238-9449-4de2-ba64-dacc6b002740"),
                        ProductId = new Guid("8e19a214-ae0f-46e7-97fe-08cd3cccf73d"),
                        Quantity = 2
                    },
                    new Fridge_Product
                    {
                        Id = new Guid("00a683f4-e0c9-408b-b296-81c859a3ef9a"),
                        FridgeId = new Guid("7c381238-9449-4de2-ba64-dacc6b002740"),
                        ProductId = new Guid("303460e8-4587-4f3d-a9d1-c50ca65bf2f5"),
                        Quantity = 10
                    },
                    new Fridge_Product
                    {
                        Id = new Guid("8552221f-458b-43d1-bd3f-2350a952333a"),
                        FridgeId = new Guid("bbfb530d-d221-4e6f-a484-93d6b29f6ccd"),
                        ProductId = new Guid("2dce0163-2ca2-48c9-9820-6607575e780b"),
                        Quantity = 3
                    }
                );
        }
    }
}
