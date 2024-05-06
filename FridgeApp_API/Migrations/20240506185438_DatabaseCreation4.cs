using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FridgeApp_API.Migrations
{
    public partial class DatabaseCreation4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fridge_Models",
                keyColumn: "Fridge_ModelId",
                keyValue: new Guid("0b807b23-c2ee-4527-a8e5-89bf7d285e35"));

            migrationBuilder.InsertData(
                table: "Fridge_Models",
                columns: new[] { "Fridge_ModelId", "Name", "Year" },
                values: new object[] { new Guid("3ff39ba8-a6f3-40bf-b1ce-6c2b89068f1c"), "МХМ 2819 ", new DateTime(2022, 8, 6, 18, 30, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Fridges",
                keyColumn: "FridgeId",
                keyValue: new Guid("217502ea-394d-439b-8968-ef018426b329"),
                column: "Fridge_ModelId",
                value: new Guid("3ff39ba8-a6f3-40bf-b1ce-6c2b89068f1c"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fridge_Models",
                keyColumn: "Fridge_ModelId",
                keyValue: new Guid("3ff39ba8-a6f3-40bf-b1ce-6c2b89068f1c"));

            migrationBuilder.InsertData(
                table: "Fridge_Models",
                columns: new[] { "Fridge_ModelId", "Name", "Year" },
                values: new object[] { new Guid("0b807b23-c2ee-4527-a8e5-89bf7d285e35"), "KGN49XLEA", new DateTime(2022, 8, 6, 18, 30, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Fridges",
                keyColumn: "FridgeId",
                keyValue: new Guid("217502ea-394d-439b-8968-ef018426b329"),
                column: "Fridge_ModelId",
                value: new Guid("0b807b23-c2ee-4527-a8e5-89bf7d285e35"));
        }
    }
}
