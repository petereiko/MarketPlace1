using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketPlace.Data.Migrations
{
    /// <inheritdoc />
    public partial class MigrationNew10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kycs_Countries_CountryId",
                table: "Kycs");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Countries_CountryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Products_CountryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Kycs_CountryId",
                table: "Kycs");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Kycs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CountryId",
                table: "Products",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CountryId",
                table: "Kycs",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    StateId = table.Column<long>(type: "bigint", nullable: true),
                    VatRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Countries_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CountryId",
                table: "Products",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Kycs_CountryId",
                table: "Kycs",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_StateId",
                table: "Countries",
                column: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kycs_Countries_CountryId",
                table: "Kycs",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Countries_CountryId",
                table: "Products",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");
        }
    }
}
