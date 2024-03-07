using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketPlace.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProductConditionEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ProductConditionId",
                table: "Products",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductConditions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductConditions", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 222, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 222, DateTimeKind.Local).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 222, DateTimeKind.Local).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 222, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 222, DateTimeKind.Local).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 223, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 223, DateTimeKind.Local).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 223, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 223, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 223, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 224, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 224, DateTimeKind.Local).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 224, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 224, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 224, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 225, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 225, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 225, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 225, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 225, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 226, DateTimeKind.Local).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 226, DateTimeKind.Local).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 226, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 226, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 226, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 226, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 227, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 227, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 227, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 227, DateTimeKind.Local).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 227, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 227, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 228, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 228, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 228, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 228, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 228, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 228, DateTimeKind.Local).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 229, DateTimeKind.Local).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 40L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 229, DateTimeKind.Local).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 229, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 229, DateTimeKind.Local).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 229, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 229, DateTimeKind.Local).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 230, DateTimeKind.Local).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 230, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 230, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 48L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 230, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 230, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 231, DateTimeKind.Local).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 231, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 231, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 231, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 231, DateTimeKind.Local).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 231, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 56L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 232, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 232, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 232, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 232, DateTimeKind.Local).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 232, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 232, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 233, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 233, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 64L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 233, DateTimeKind.Local).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 233, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 233, DateTimeKind.Local).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 234, DateTimeKind.Local).AddTicks(339));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 234, DateTimeKind.Local).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 234, DateTimeKind.Local).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 234, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 234, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 72L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 234, DateTimeKind.Local).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 235, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 235, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 235, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 235, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 236, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 236, DateTimeKind.Local).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 236, DateTimeKind.Local).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 80L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 236, DateTimeKind.Local).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 236, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 237, DateTimeKind.Local).AddTicks(1594));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 237, DateTimeKind.Local).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 237, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 237, DateTimeKind.Local).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 237, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 238, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 88L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 238, DateTimeKind.Local).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 238, DateTimeKind.Local).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 238, DateTimeKind.Local).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 238, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 238, DateTimeKind.Local).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 239, DateTimeKind.Local).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 239, DateTimeKind.Local).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 239, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 96L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 239, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 239, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 239, DateTimeKind.Local).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 240, DateTimeKind.Local).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 240, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 240, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 240, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 240, DateTimeKind.Local).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 104L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 241, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 241, DateTimeKind.Local).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 241, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 241, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 241, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 242, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 242, DateTimeKind.Local).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 242, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 112L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 242, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 242, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 242, DateTimeKind.Local).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 243, DateTimeKind.Local).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 243, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 243, DateTimeKind.Local).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 243, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 243, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 120L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 243, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 244, DateTimeKind.Local).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 244, DateTimeKind.Local).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 244, DateTimeKind.Local).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 244, DateTimeKind.Local).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 244, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 245, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 245, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 128L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 245, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 245, DateTimeKind.Local).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 245, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 245, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 246, DateTimeKind.Local).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 246, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 246, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 246, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 136L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 246, DateTimeKind.Local).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 246, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 247, DateTimeKind.Local).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 247, DateTimeKind.Local).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 247, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 247, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 247, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 248, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 144L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 248, DateTimeKind.Local).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 248, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 249, DateTimeKind.Local).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 249, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 249, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 249, DateTimeKind.Local).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 250, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 250, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 152L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 250, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 250, DateTimeKind.Local).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 251, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 251, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 251, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 251, DateTimeKind.Local).AddTicks(9762));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 252, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 252, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 160L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 252, DateTimeKind.Local).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 252, DateTimeKind.Local).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 253, DateTimeKind.Local).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 253, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 253, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 253, DateTimeKind.Local).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 253, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 254, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 168L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 254, DateTimeKind.Local).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 254, DateTimeKind.Local).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 254, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 254, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 255, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 255, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 255, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 255, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 176L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 255, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 256, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 256, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 256, DateTimeKind.Local).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 256, DateTimeKind.Local).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 256, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 256, DateTimeKind.Local).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 257, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 184L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 257, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 257, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 257, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 257, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 258, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 258, DateTimeKind.Local).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 258, DateTimeKind.Local).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 258, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 192L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 258, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 259, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 259, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 259, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 259, DateTimeKind.Local).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 260, DateTimeKind.Local).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 260, DateTimeKind.Local).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 260, DateTimeKind.Local).AddTicks(3595));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 200L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 260, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 201L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 260, DateTimeKind.Local).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 202L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 260, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 203L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 261, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 204L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 261, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 205L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 261, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 206L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 261, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 207L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 261, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 208L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 261, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 209L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 262, DateTimeKind.Local).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 210L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 262, DateTimeKind.Local).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 211L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 262, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 212L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 262, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 213L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 262, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 214L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 263, DateTimeKind.Local).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 215L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 263, DateTimeKind.Local).AddTicks(1927));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 216L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 263, DateTimeKind.Local).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 217L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 263, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 218L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 263, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 219L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 263, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 220L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 264, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 221L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 264, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 222L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 264, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 223L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 264, DateTimeKind.Local).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 224L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 264, DateTimeKind.Local).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 225L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 265, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 226L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 265, DateTimeKind.Local).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 227L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 265, DateTimeKind.Local).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 228L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 265, DateTimeKind.Local).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 229L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 265, DateTimeKind.Local).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 230L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 265, DateTimeKind.Local).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 231L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 266, DateTimeKind.Local).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 232L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 266, DateTimeKind.Local).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 233L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 266, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 234L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 266, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 235L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 266, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 236L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 267, DateTimeKind.Local).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 237L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 267, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 238L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 267, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 239L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 267, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 240L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 267, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 241L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 267, DateTimeKind.Local).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 242L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 268, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 243L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 268, DateTimeKind.Local).AddTicks(2835));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 244L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 268, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 245L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 268, DateTimeKind.Local).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 246L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 268, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 247L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 269, DateTimeKind.Local).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 248L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 269, DateTimeKind.Local).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 249L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 269, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 250L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 269, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 251L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 269, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 269, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 270, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 270, DateTimeKind.Local).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 270, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 270, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 270, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 271, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 271, DateTimeKind.Local).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 271, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 272, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 272, DateTimeKind.Local).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 272, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 272, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 273, DateTimeKind.Local).AddTicks(77));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 273, DateTimeKind.Local).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 273, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 273, DateTimeKind.Local).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 273, DateTimeKind.Local).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 273, DateTimeKind.Local).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 274, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 274, DateTimeKind.Local).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 274, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 274, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 274, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 275, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 275, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 275, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 275, DateTimeKind.Local).AddTicks(6019));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 275, DateTimeKind.Local).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 275, DateTimeKind.Local).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 276, DateTimeKind.Local).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 276, DateTimeKind.Local).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 276, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 276, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 276, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 277, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 7, 1, 33, 0, 277, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductConditionId",
                table: "Products",
                column: "ProductConditionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductConditions_ProductConditionId",
                table: "Products",
                column: "ProductConditionId",
                principalTable: "ProductConditions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductConditions_ProductConditionId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductConditions");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductConditionId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductConditionId",
                table: "Products");

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
    }
}
