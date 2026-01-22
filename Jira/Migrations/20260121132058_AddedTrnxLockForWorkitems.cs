using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jira.Migrations
{
    /// <inheritdoc />
    public partial class AddedTrnxLockForWorkitems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EditLockedBy",
                table: "WorkItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EditLockedIp",
                table: "WorkItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "EditLockExpiresAt",
                table: "WorkItems",
                type: "timestamp with time zone",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EditLockedBy",
                table: "WorkItems");

            migrationBuilder.DropColumn(
                name: "EditLockedIp",
                table: "WorkItems");

            migrationBuilder.DropColumn(
                name: "EditLockExpiresAt",
                table: "WorkItems");
        }
    }
}
