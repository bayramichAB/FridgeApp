using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FridgeApp_API.Migrations
{
    public partial class DatabaseCreation2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fridges_Fridge_Models_Fridge_ModelId",
                table: "Fridges");

            migrationBuilder.DropIndex(
                name: "IX_Fridges_Fridge_ModelId",
                table: "Fridges");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Fridges_Fridge_ModelId",
                table: "Fridges",
                column: "Fridge_ModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fridges_Fridge_Models_Fridge_ModelId",
                table: "Fridges",
                column: "Fridge_ModelId",
                principalTable: "Fridge_Models",
                principalColumn: "Fridge_ModelId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
