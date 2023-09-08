using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrisTask.Migrations
{
    /// <inheritdoc />
    public partial class RemovedImageIds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Albums");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageId",
                table: "Tracks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageId",
                table: "Stations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageId",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageId",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageId",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageId",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
