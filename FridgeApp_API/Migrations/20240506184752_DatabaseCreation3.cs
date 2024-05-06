using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FridgeApp_API.Migrations
{
    public partial class DatabaseCreation3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Fridge_Models",
                columns: new[] { "Fridge_ModelId", "Name", "Year" },
                values: new object[,]
                {
                    { new Guid("0b807b23-c2ee-4527-a8e5-89bf7d285e35"), "KGN49XLEA", new DateTime(2022, 8, 6, 18, 30, 25, 0, DateTimeKind.Unspecified) },
                    { new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "KGN49XLEA", new DateTime(2015, 7, 20, 18, 30, 25, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Fridge_Products",
                columns: new[] { "Fridge_ProductId", "FridgeId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("00a683f4-e0c9-408b-b296-81c859a3ef9a"), new Guid("7c381238-9449-4de2-ba64-dacc6b002740"), new Guid("303460e8-4587-4f3d-a9d1-c50ca65bf2f5"), 10 },
                    { new Guid("75f14f8f-8053-4877-9185-ee146cffc549"), new Guid("bbfb530d-d221-4e6f-a484-93d6b29f6ccd"), new Guid("303460e8-4587-4f3d-a9d1-c50ca65bf2f5"), 3 },
                    { new Guid("7fadbab3-ee3c-4ba3-b1f8-6bf2a99bf007"), new Guid("7c381238-9449-4de2-ba64-dacc6b002740"), new Guid("8e19a214-ae0f-46e7-97fe-08cd3cccf73d"), 2 },
                    { new Guid("8552221f-458b-43d1-bd3f-2350a952333a"), new Guid("bbfb530d-d221-4e6f-a484-93d6b29f6ccd"), new Guid("2dce0163-2ca2-48c9-9820-6607575e780b"), 3 }
                });

            migrationBuilder.InsertData(
                table: "Fridges",
                columns: new[] { "FridgeId", "Fridge_ModelId", "Name", "OwnerName" },
                values: new object[,]
                {
                    { new Guid("217502ea-394d-439b-8968-ef018426b329"), new Guid("0b807b23-c2ee-4527-a8e5-89bf7d285e35"), "ATLANT", "Bogdana" },
                    { new Guid("7c381238-9449-4de2-ba64-dacc6b002740"), new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "Indesit", "Alina" },
                    { new Guid("bbfb530d-d221-4e6f-a484-93d6b29f6ccd"), new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "Indesit", "Arkadi" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Default_Quantity", "Name" },
                values: new object[,]
                {
                    { new Guid("2dce0163-2ca2-48c9-9820-6607575e780b"), 5, "Water" },
                    { new Guid("303460e8-4587-4f3d-a9d1-c50ca65bf2f5"), 0, "Egg" },
                    { new Guid("8e19a214-ae0f-46e7-97fe-08cd3cccf73d"), 1, "Bread" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fridge_Models",
                keyColumn: "Fridge_ModelId",
                keyValue: new Guid("0b807b23-c2ee-4527-a8e5-89bf7d285e35"));

            migrationBuilder.DeleteData(
                table: "Fridge_Models",
                keyColumn: "Fridge_ModelId",
                keyValue: new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"));

            migrationBuilder.DeleteData(
                table: "Fridge_Products",
                keyColumn: "Fridge_ProductId",
                keyValue: new Guid("00a683f4-e0c9-408b-b296-81c859a3ef9a"));

            migrationBuilder.DeleteData(
                table: "Fridge_Products",
                keyColumn: "Fridge_ProductId",
                keyValue: new Guid("75f14f8f-8053-4877-9185-ee146cffc549"));

            migrationBuilder.DeleteData(
                table: "Fridge_Products",
                keyColumn: "Fridge_ProductId",
                keyValue: new Guid("7fadbab3-ee3c-4ba3-b1f8-6bf2a99bf007"));

            migrationBuilder.DeleteData(
                table: "Fridge_Products",
                keyColumn: "Fridge_ProductId",
                keyValue: new Guid("8552221f-458b-43d1-bd3f-2350a952333a"));

            migrationBuilder.DeleteData(
                table: "Fridges",
                keyColumn: "FridgeId",
                keyValue: new Guid("217502ea-394d-439b-8968-ef018426b329"));

            migrationBuilder.DeleteData(
                table: "Fridges",
                keyColumn: "FridgeId",
                keyValue: new Guid("7c381238-9449-4de2-ba64-dacc6b002740"));

            migrationBuilder.DeleteData(
                table: "Fridges",
                keyColumn: "FridgeId",
                keyValue: new Guid("bbfb530d-d221-4e6f-a484-93d6b29f6ccd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2dce0163-2ca2-48c9-9820-6607575e780b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("303460e8-4587-4f3d-a9d1-c50ca65bf2f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8e19a214-ae0f-46e7-97fe-08cd3cccf73d"));
        }
    }
}
