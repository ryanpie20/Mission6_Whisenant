using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission6_Whisenant.Migrations
{
    /// <inheritdoc />
    public partial class AddReleaseDateToMovieCollection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Subcategory",
                table: "MovieCollections",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subcategory",
                table: "MovieCollections");
        }
    }
}
