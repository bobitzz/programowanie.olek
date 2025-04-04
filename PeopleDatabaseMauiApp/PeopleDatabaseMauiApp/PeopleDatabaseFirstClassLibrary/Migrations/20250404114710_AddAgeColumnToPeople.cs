using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeopleDatabaseFirstClassLibrary.Migrations
{
    /// <inheritdoc />
    public partial class AddAgeColumnToPeople : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "People",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "People");
        }
    }
}
