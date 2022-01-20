using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_bakery.Migrations
{
    public partial class FuckAllOfThisLoL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pet_PetOwner_petOwnerId",
                table: "Pet");

            migrationBuilder.RenameColumn(
                name: "petOwnerId",
                table: "Pet",
                newName: "petOwnerid");

            migrationBuilder.RenameColumn(
                name: "PetColor",
                table: "Pet",
                newName: "color");

            migrationBuilder.RenameColumn(
                name: "PetBreed",
                table: "Pet",
                newName: "breed");

            migrationBuilder.RenameIndex(
                name: "IX_Pet_petOwnerId",
                table: "Pet",
                newName: "IX_Pet_petOwnerid");

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_PetOwner_petOwnerid",
                table: "Pet",
                column: "petOwnerid",
                principalTable: "PetOwner",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pet_PetOwner_petOwnerid",
                table: "Pet");

            migrationBuilder.RenameColumn(
                name: "petOwnerid",
                table: "Pet",
                newName: "petOwnerId");

            migrationBuilder.RenameColumn(
                name: "color",
                table: "Pet",
                newName: "PetColor");

            migrationBuilder.RenameColumn(
                name: "breed",
                table: "Pet",
                newName: "PetBreed");

            migrationBuilder.RenameIndex(
                name: "IX_Pet_petOwnerid",
                table: "Pet",
                newName: "IX_Pet_petOwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_PetOwner_petOwnerId",
                table: "Pet",
                column: "petOwnerId",
                principalTable: "PetOwner",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
