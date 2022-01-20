using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace dotnet_bakery.Migrations
{
    public partial class CreatePetsTable20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PetBreed = table.Column<int>(type: "integer", nullable: false),
                    PetColor = table.Column<int>(type: "integer", nullable: false),
                    checkedInAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    petOwnerId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.id);
                    table.ForeignKey(
                        name: "FK_Pet_PetOwner_petOwnerId",
                        column: x => x.petOwnerId,
                        principalTable: "PetOwner",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pet_petOwnerId",
                table: "Pet",
                column: "petOwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pet");
        }
    }
}
