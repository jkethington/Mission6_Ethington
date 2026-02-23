using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieMission6.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieCollection_Categories_CategoryId",
                table: "MovieCollection");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieCollection",
                table: "MovieCollection");

            migrationBuilder.RenameTable(
                name: "MovieCollection",
                newName: "Movies");

            migrationBuilder.RenameIndex(
                name: "IX_MovieCollection_CategoryId",
                table: "Movies",
                newName: "IX_Movies_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Categories_CategoryId",
                table: "Movies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Categories_CategoryId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "MovieCollection");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_CategoryId",
                table: "MovieCollection",
                newName: "IX_MovieCollection_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieCollection",
                table: "MovieCollection",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieCollection_Categories_CategoryId",
                table: "MovieCollection",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
