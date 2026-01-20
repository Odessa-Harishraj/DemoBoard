using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jira.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewColumnInWorkItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "WorkItems",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "WorkItems");
        }
    }
}
