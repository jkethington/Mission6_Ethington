using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieMission6.Migrations
{
    /// <inheritdoc />
    public partial class CopiedToPlex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CopiedToPlex",
                table: "MovieCollection",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CopiedToPlex",
                table: "MovieCollection");
        }
    }
}
