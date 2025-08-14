using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentorTask.Migrations
{
    /// <inheritdoc />
    public partial class FixTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AbousUses",
                table: "AbousUses");

            migrationBuilder.RenameTable(
                name: "AbousUses",
                newName: "AboutUses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AboutUses",
                table: "AboutUses",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AboutUses",
                table: "AboutUses");

            migrationBuilder.RenameTable(
                name: "AboutUses",
                newName: "AbousUses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbousUses",
                table: "AbousUses",
                column: "Id");
        }
    }
}
