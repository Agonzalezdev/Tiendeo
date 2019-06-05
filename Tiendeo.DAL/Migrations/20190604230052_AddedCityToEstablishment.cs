using Microsoft.EntityFrameworkCore.Migrations;

namespace Tiendeo.DAL.Migrations
{
    public partial class AddedCityToEstablishment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CityId",
                table: "Establishment",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Establishment_CityId",
                table: "Establishment",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Establishment_City_CityId",
                table: "Establishment",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Establishment_City_CityId",
                table: "Establishment");

            migrationBuilder.DropIndex(
                name: "IX_Establishment_CityId",
                table: "Establishment");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Establishment");
        }
    }
}
