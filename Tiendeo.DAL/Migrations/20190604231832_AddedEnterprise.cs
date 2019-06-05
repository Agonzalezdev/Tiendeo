using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tiendeo.DAL.Migrations
{
    public partial class AddedEnterprise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "EnterpriseId",
                table: "Establishment",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Enterprise",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Top = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    MarkerUrl = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enterprise", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Establishment_EnterpriseId",
                table: "Establishment",
                column: "EnterpriseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Establishment_Enterprise_EnterpriseId",
                table: "Establishment",
                column: "EnterpriseId",
                principalTable: "Enterprise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Establishment_Enterprise_EnterpriseId",
                table: "Establishment");

            migrationBuilder.DropTable(
                name: "Enterprise");

            migrationBuilder.DropIndex(
                name: "IX_Establishment_EnterpriseId",
                table: "Establishment");

            migrationBuilder.DropColumn(
                name: "EnterpriseId",
                table: "Establishment");
        }
    }
}
