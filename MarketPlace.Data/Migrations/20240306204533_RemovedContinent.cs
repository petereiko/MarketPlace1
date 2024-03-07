using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarketPlace.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemovedContinent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kycs_Continents_ContinentId",
                table: "Kycs");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Continents_ContinentId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Continents");

            migrationBuilder.DropIndex(
                name: "IX_Products_ContinentId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Kycs_ContinentId",
                table: "Kycs");

            migrationBuilder.DropColumn(
                name: "ContinentId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ContinentId",
                table: "Kycs");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 415, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 415, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 415, DateTimeKind.Local).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 415, DateTimeKind.Local).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 416, DateTimeKind.Local).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 416, DateTimeKind.Local).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 416, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 416, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 416, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 417, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 417, DateTimeKind.Local).AddTicks(5016));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 417, DateTimeKind.Local).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 418, DateTimeKind.Local).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 418, DateTimeKind.Local).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 418, DateTimeKind.Local).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 418, DateTimeKind.Local).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 419, DateTimeKind.Local).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 419, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 419, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 420, DateTimeKind.Local).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 420, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 420, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 421, DateTimeKind.Local).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 421, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 421, DateTimeKind.Local).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 422, DateTimeKind.Local).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 422, DateTimeKind.Local).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 422, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 423, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 423, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 423, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 424, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 424, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 424, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 424, DateTimeKind.Local).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 425, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 425, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 425, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 426, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 426, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 426, DateTimeKind.Local).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 426, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 427, DateTimeKind.Local).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 427, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 427, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 427, DateTimeKind.Local).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 428, DateTimeKind.Local).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 48L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 428, DateTimeKind.Local).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 428, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 428, DateTimeKind.Local).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 428, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 429, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 429, DateTimeKind.Local).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 429, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 429, DateTimeKind.Local).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 56L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 429, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 430, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 430, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 430, DateTimeKind.Local).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 430, DateTimeKind.Local).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 430, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 430, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 431, DateTimeKind.Local).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 64L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 431, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 431, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 431, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 431, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 432, DateTimeKind.Local).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 432, DateTimeKind.Local).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 432, DateTimeKind.Local).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 432, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 72L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 432, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 433, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 433, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 433, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 433, DateTimeKind.Local).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 434, DateTimeKind.Local).AddTicks(3175));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 434, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 434, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 80L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 435, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 435, DateTimeKind.Local).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 436, DateTimeKind.Local).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 436, DateTimeKind.Local).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 437, DateTimeKind.Local).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 437, DateTimeKind.Local).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 437, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 437, DateTimeKind.Local).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 88L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 438, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 438, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 438, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 438, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 439, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 439, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 439, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 440, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 96L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 440, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 440, DateTimeKind.Local).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 440, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 441, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 441, DateTimeKind.Local).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 441, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 442, DateTimeKind.Local).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 442, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 104L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 442, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 442, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 443, DateTimeKind.Local).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 443, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 443, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 443, DateTimeKind.Local).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 444, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 444, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 112L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 444, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 444, DateTimeKind.Local).AddTicks(9873));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 445, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 445, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 445, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 445, DateTimeKind.Local).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 445, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 446, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 120L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 446, DateTimeKind.Local).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 446, DateTimeKind.Local).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 446, DateTimeKind.Local).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 446, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 447, DateTimeKind.Local).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 447, DateTimeKind.Local).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 447, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 447, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 128L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 447, DateTimeKind.Local).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 448, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 448, DateTimeKind.Local).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 448, DateTimeKind.Local).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 448, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 448, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 449, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 449, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 136L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 449, DateTimeKind.Local).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 449, DateTimeKind.Local).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 450, DateTimeKind.Local).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 450, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 450, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 450, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 451, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 451, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 144L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 451, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 452, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 452, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 452, DateTimeKind.Local).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 453, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 453, DateTimeKind.Local).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 453, DateTimeKind.Local).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 454, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 152L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 454, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 454, DateTimeKind.Local).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 455, DateTimeKind.Local).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 455, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 455, DateTimeKind.Local).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 456, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 456, DateTimeKind.Local).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 456, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 160L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 457, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 457, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 457, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 457, DateTimeKind.Local).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 458, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 458, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 458, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 458, DateTimeKind.Local).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 168L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 459, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 459, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 459, DateTimeKind.Local).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 460, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 460, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 460, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 460, DateTimeKind.Local).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 461, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 176L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 461, DateTimeKind.Local).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 461, DateTimeKind.Local).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 461, DateTimeKind.Local).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 462, DateTimeKind.Local).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 462, DateTimeKind.Local).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 462, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 462, DateTimeKind.Local).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 462, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 184L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 463, DateTimeKind.Local).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 463, DateTimeKind.Local).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 463, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 463, DateTimeKind.Local).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 463, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 464, DateTimeKind.Local).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 464, DateTimeKind.Local).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 464, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 192L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 464, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 464, DateTimeKind.Local).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 464, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 465, DateTimeKind.Local).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 465, DateTimeKind.Local).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 465, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 465, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 465, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 200L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 466, DateTimeKind.Local).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 201L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 466, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 202L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 466, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 203L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 466, DateTimeKind.Local).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 204L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 466, DateTimeKind.Local).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 205L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 467, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 206L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 468, DateTimeKind.Local).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 207L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 468, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 208L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 469, DateTimeKind.Local).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 209L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 469, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 210L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 469, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 211L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 470, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 212L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 470, DateTimeKind.Local).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 213L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 470, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 214L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 471, DateTimeKind.Local).AddTicks(1934));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 215L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 471, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 216L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 471, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 217L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 472, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 218L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 472, DateTimeKind.Local).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 219L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 472, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 220L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 473, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 221L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 473, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 222L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 473, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 223L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 474, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 224L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 474, DateTimeKind.Local).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 225L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 474, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 226L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 475, DateTimeKind.Local).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 227L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 475, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 228L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 476, DateTimeKind.Local).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 229L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 476, DateTimeKind.Local).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 230L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 476, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 231L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 477, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 232L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 477, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 233L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 477, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 234L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 478, DateTimeKind.Local).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 235L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 478, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 236L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 478, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 237L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 479, DateTimeKind.Local).AddTicks(196));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 238L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 479, DateTimeKind.Local).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 239L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 479, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 240L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 479, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 241L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 480, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 242L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 480, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 243L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 480, DateTimeKind.Local).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 244L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 480, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 245L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 480, DateTimeKind.Local).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 246L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 481, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 247L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 481, DateTimeKind.Local).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 248L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 481, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 249L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 481, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 250L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 481, DateTimeKind.Local).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 251L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 482, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 482, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 482, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 483, DateTimeKind.Local).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 484, DateTimeKind.Local).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 485, DateTimeKind.Local).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 485, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 486, DateTimeKind.Local).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 486, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 486, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 487, DateTimeKind.Local).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 487, DateTimeKind.Local).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 488, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 488, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 488, DateTimeKind.Local).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 489, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 489, DateTimeKind.Local).AddTicks(3855));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 489, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 490, DateTimeKind.Local).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 490, DateTimeKind.Local).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 490, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 491, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 491, DateTimeKind.Local).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 491, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 492, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 492, DateTimeKind.Local).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 492, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 493, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 493, DateTimeKind.Local).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 493, DateTimeKind.Local).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 494, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 494, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 494, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 495, DateTimeKind.Local).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 495, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 495, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 496, DateTimeKind.Local).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 21, 45, 32, 496, DateTimeKind.Local).AddTicks(2960));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ContinentId",
                table: "Products",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ContinentId",
                table: "Kycs",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Continents",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Continents", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Continents",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IPAddress", "IsActive", "IsDeleted", "LastModified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 205, DateTimeKind.Local).AddTicks(957), "192.168.8.193", true, null, null, null, "Africa" },
                    { 2L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 205, DateTimeKind.Local).AddTicks(3150), "192.168.8.193", true, null, null, null, "Asia" },
                    { 3L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 205, DateTimeKind.Local).AddTicks(4717), "192.168.8.193", true, null, null, null, "Antarctica" },
                    { 4L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 205, DateTimeKind.Local).AddTicks(6257), "192.168.8.193", true, null, null, null, "Europe" },
                    { 5L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 205, DateTimeKind.Local).AddTicks(7731), "192.168.8.193", true, null, null, null, "Oceania" },
                    { 6L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 205, DateTimeKind.Local).AddTicks(8979), "192.168.8.193", true, null, null, null, "South America" },
                    { 7L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 206, DateTimeKind.Local).AddTicks(223), "192.168.8.193", true, null, null, null, "North America" }
                });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 206, DateTimeKind.Local).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 206, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 206, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 206, DateTimeKind.Local).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 206, DateTimeKind.Local).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 206, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 207, DateTimeKind.Local).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 207, DateTimeKind.Local).AddTicks(1841));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 207, DateTimeKind.Local).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 207, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 207, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 207, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 207, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 207, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 208, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 208, DateTimeKind.Local).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 208, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 208, DateTimeKind.Local).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 208, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 208, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 208, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 208, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 208, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 209, DateTimeKind.Local).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 209, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 209, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 209, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 209, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 209, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 209, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 209, DateTimeKind.Local).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 210, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 210, DateTimeKind.Local).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 210, DateTimeKind.Local).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 210, DateTimeKind.Local).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 210, DateTimeKind.Local).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 210, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 210, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 211, DateTimeKind.Local).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 211, DateTimeKind.Local).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 211, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 211, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 212, DateTimeKind.Local).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 212, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 212, DateTimeKind.Local).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 212, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 212, DateTimeKind.Local).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 48L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 213, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 213, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 213, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 213, DateTimeKind.Local).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 213, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 214, DateTimeKind.Local).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 214, DateTimeKind.Local).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 214, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 56L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 214, DateTimeKind.Local).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 214, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 214, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 214, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 215, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 215, DateTimeKind.Local).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 215, DateTimeKind.Local).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 215, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 64L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 215, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 215, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 215, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 215, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 216, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 216, DateTimeKind.Local).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 216, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 216, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 72L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 216, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 216, DateTimeKind.Local).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 216, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 216, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 217, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 217, DateTimeKind.Local).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 217, DateTimeKind.Local).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 217, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 80L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 217, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 217, DateTimeKind.Local).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 217, DateTimeKind.Local).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 218, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 218, DateTimeKind.Local).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 218, DateTimeKind.Local).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 218, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 218, DateTimeKind.Local).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 88L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 218, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 218, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 218, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 219, DateTimeKind.Local).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 219, DateTimeKind.Local).AddTicks(1805));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 219, DateTimeKind.Local).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 219, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 219, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 96L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 219, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 219, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 220, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 220, DateTimeKind.Local).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 220, DateTimeKind.Local).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 220, DateTimeKind.Local).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 220, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 220, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 104L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 221, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 221, DateTimeKind.Local).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 221, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 221, DateTimeKind.Local).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 221, DateTimeKind.Local).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 221, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 222, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 222, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 112L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 222, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 222, DateTimeKind.Local).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 222, DateTimeKind.Local).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 222, DateTimeKind.Local).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 222, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 222, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 222, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 223, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 120L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 223, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 223, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 223, DateTimeKind.Local).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 223, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 223, DateTimeKind.Local).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 223, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 223, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 224, DateTimeKind.Local).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 128L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 224, DateTimeKind.Local).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 224, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 224, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 224, DateTimeKind.Local).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 224, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 224, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 224, DateTimeKind.Local).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 225, DateTimeKind.Local).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 136L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 225, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 225, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 225, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 225, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 225, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 225, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 226, DateTimeKind.Local).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 226, DateTimeKind.Local).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 144L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 226, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 226, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 226, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 227, DateTimeKind.Local).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 227, DateTimeKind.Local).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 227, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 227, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 227, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 152L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 228, DateTimeKind.Local).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 228, DateTimeKind.Local).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 228, DateTimeKind.Local).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 228, DateTimeKind.Local).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 229, DateTimeKind.Local).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 229, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 229, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 229, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 160L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 229, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 230, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 230, DateTimeKind.Local).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 230, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 230, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 230, DateTimeKind.Local).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 231, DateTimeKind.Local).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 231, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 168L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 231, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 231, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 231, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 232, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 232, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 232, DateTimeKind.Local).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 232, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 232, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 176L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 233, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 233, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 233, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 233, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 233, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 234, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 234, DateTimeKind.Local).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 234, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 184L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 234, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 234, DateTimeKind.Local).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 234, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 235, DateTimeKind.Local).AddTicks(1365));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 235, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 235, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 235, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 235, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 192L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 236, DateTimeKind.Local).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 236, DateTimeKind.Local).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 236, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 236, DateTimeKind.Local).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 236, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 237, DateTimeKind.Local).AddTicks(1757));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 237, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 237, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 200L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 237, DateTimeKind.Local).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 201L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 237, DateTimeKind.Local).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 202L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 238, DateTimeKind.Local).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 203L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 238, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 204L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 238, DateTimeKind.Local).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 205L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 238, DateTimeKind.Local).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 206L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 238, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 207L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 239, DateTimeKind.Local).AddTicks(61));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 208L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 239, DateTimeKind.Local).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 209L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 239, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 210L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 239, DateTimeKind.Local).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 211L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 239, DateTimeKind.Local).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 212L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 239, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 213L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 240, DateTimeKind.Local).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 214L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 240, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 215L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 240, DateTimeKind.Local).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 216L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 240, DateTimeKind.Local).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 217L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 240, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 218L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 240, DateTimeKind.Local).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 219L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 241, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 220L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 241, DateTimeKind.Local).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 221L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 241, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 222L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 241, DateTimeKind.Local).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 223L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 242, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 224L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 242, DateTimeKind.Local).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 225L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 242, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 226L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 242, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 227L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 243, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 228L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 243, DateTimeKind.Local).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 229L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 243, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 230L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 243, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 231L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 243, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 232L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 244, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 233L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 244, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 234L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 244, DateTimeKind.Local).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 235L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 244, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 236L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 244, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 237L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 245, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 238L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 245, DateTimeKind.Local).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 239L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 245, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 240L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 245, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 241L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 245, DateTimeKind.Local).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 242L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 246, DateTimeKind.Local).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 243L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 246, DateTimeKind.Local).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 244L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 246, DateTimeKind.Local).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 245L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 246, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 246L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 247, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 247L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 247, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 248L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 247, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 249L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 247, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 250L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 247, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 251L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 248, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 248, DateTimeKind.Local).AddTicks(3131));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 248, DateTimeKind.Local).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 248, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 248, DateTimeKind.Local).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 249, DateTimeKind.Local).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 249, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 249, DateTimeKind.Local).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 249, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 249, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 250, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 250, DateTimeKind.Local).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 250, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 250, DateTimeKind.Local).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 250, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 251, DateTimeKind.Local).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 251, DateTimeKind.Local).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 251, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 251, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 252, DateTimeKind.Local).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 252, DateTimeKind.Local).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 252, DateTimeKind.Local).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 252, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 252, DateTimeKind.Local).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 253, DateTimeKind.Local).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 253, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 253, DateTimeKind.Local).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 253, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 253, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 254, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 254, DateTimeKind.Local).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 254, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 254, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 254, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 255, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 255, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 255, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 10, 30, 46, 255, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.CreateIndex(
                name: "IX_Products_ContinentId",
                table: "Products",
                column: "ContinentId");

            migrationBuilder.CreateIndex(
                name: "IX_Kycs_ContinentId",
                table: "Kycs",
                column: "ContinentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kycs_Continents_ContinentId",
                table: "Kycs",
                column: "ContinentId",
                principalTable: "Continents",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Continents_ContinentId",
                table: "Products",
                column: "ContinentId",
                principalTable: "Continents",
                principalColumn: "Id");
        }
    }
}
