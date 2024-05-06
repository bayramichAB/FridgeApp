using FridgeApp_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FridgeApp_API.Repository.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData
                (
                    new Product
                    {
                        Id = new Guid("303460e8-4587-4f3d-a9d1-c50ca65bf2f5"),
                        Name = "Egg",
                        Default_Quantity = 0
                    },
                    new Product
                    {
                        Id = new Guid("8e19a214-ae0f-46e7-97fe-08cd3cccf73d"),
                        Name = "Bread",
                        Default_Quantity = 1
                    },
                    new Product
                    {
                        Id = new Guid("2dce0163-2ca2-48c9-9820-6607575e780b"),
                        Name = "Water",
                        Default_Quantity = 5
                    }
                );
        }
    }
}
