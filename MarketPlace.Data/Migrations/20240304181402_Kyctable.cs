using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketPlace.Data.Migrations
{
    /// <inheritdoc />
    public partial class Kyctable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kycs_AspNetUsers_ApplicationUserId",
                table: "Kycs");

            migrationBuilder.DropIndex(
                name: "IX_Kycs_ApplicationUserId",
                table: "Kycs");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Kycs");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Kycs",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kycs_UserId",
                table: "Kycs",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kycs_AspNetUsers_UserId",
                table: "Kycs",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kycs_AspNetUsers_UserId",
                table: "Kycs");

            migrationBuilder.DropIndex(
                name: "IX_Kycs_UserId",
                table: "Kycs");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Kycs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Kycs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kycs_ApplicationUserId",
                table: "Kycs",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kycs_AspNetUsers_ApplicationUserId",
                table: "Kycs",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
