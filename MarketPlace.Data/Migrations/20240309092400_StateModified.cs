using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarketPlace.Data.Migrations
{
    /// <inheritdoc />
    public partial class StateModified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_States_States_StateId",
                table: "States");

            migrationBuilder.DropIndex(
                name: "IX_States_StateId",
                table: "States");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "States");

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "States");

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IPAddress", "IsActive", "IsDeleted", "LastModified", "ModifiedBy", "Name", "ProductTypeId" },
                values: new object[,]
                {
                    { 1L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 192, DateTimeKind.Local).AddTicks(9779), "192.168.8.193", false, null, null, null, "Edible", null },
                    { 2L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 193, DateTimeKind.Local).AddTicks(4917), "192.168.8.193", false, null, null, null, "Mechanical", null },
                    { 3L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 193, DateTimeKind.Local).AddTicks(9903), "192.168.8.193", false, null, null, null, "Electrical", null },
                    { 4L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 194, DateTimeKind.Local).AddTicks(3921), "192.168.8.193", false, null, null, null, "Wooden", null },
                    { 5L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 194, DateTimeKind.Local).AddTicks(9938), "192.168.8.193", false, null, null, null, "Ceramic", null }
                });

            migrationBuilder.InsertData(
                table: "ProductConditions",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IPAddress", "IsActive", "IsDeleted", "LastModified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 189, DateTimeKind.Local).AddTicks(9879), "192.168.8.193", false, null, null, null, "Brand New" },
                    { 2L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 191, DateTimeKind.Local).AddTicks(475), "192.168.8.193", false, null, null, null, "Foreign Use" },
                    { 3L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 191, DateTimeKind.Local).AddTicks(8685), "192.168.8.193", false, null, null, null, "Fairly Used" },
                    { 4L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 192, DateTimeKind.Local).AddTicks(4163), "192.168.8.193", false, null, null, null, "Really Used" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IPAddress", "IsActive", "IsDeleted", "LastModified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 181, DateTimeKind.Local).AddTicks(9315), "192.168.8.193", false, null, null, null, "Vehicles" },
                    { 2L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 182, DateTimeKind.Local).AddTicks(6849), "192.168.8.193", false, null, null, null, "Properties" },
                    { 3L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 183, DateTimeKind.Local).AddTicks(4791), "192.168.8.193", false, null, null, null, "Mobile Gadgets" },
                    { 4L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 184, DateTimeKind.Local).AddTicks(1187), "192.168.8.193", false, null, null, null, "Electronics" },
                    { 5L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 184, DateTimeKind.Local).AddTicks(7592), "192.168.8.193", false, null, null, null, "Home Appliances" },
                    { 6L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 185, DateTimeKind.Local).AddTicks(4719), "192.168.8.193", false, null, null, null, "Cosmetics/Beauty" },
                    { 7L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 185, DateTimeKind.Local).AddTicks(9702), "192.168.8.193", false, null, null, null, "Fashion" },
                    { 8L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 186, DateTimeKind.Local).AddTicks(4108), "192.168.8.193", false, null, null, null, "Sports" },
                    { 9L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 186, DateTimeKind.Local).AddTicks(8647), "192.168.8.193", false, null, null, null, "Outdoor Equipment" },
                    { 10L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 187, DateTimeKind.Local).AddTicks(3724), "192.168.8.193", false, null, null, null, "Jobs" },
                    { 11L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 187, DateTimeKind.Local).AddTicks(9655), "192.168.8.193", false, null, null, null, "Babies/Toys" },
                    { 12L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 188, DateTimeKind.Local).AddTicks(5100), "192.168.8.193", false, null, null, null, "Pets" },
                    { 13L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 189, DateTimeKind.Local).AddTicks(836), "192.168.8.193", false, null, null, null, "Agriculture" },
                    { 14L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 189, DateTimeKind.Local).AddTicks(4997), "192.168.8.193", false, null, null, null, "Workman" }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IPAddress", "IsActive", "IsDeleted", "LastModified", "ModifiedBy", "Name", "StateCode" },
                values: new object[,]
                {
                    { 1L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 111, DateTimeKind.Local).AddTicks(3733), "192.168.8.193", false, null, null, null, "Akwa Ibom", "01" },
                    { 2L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 112, DateTimeKind.Local).AddTicks(9634), "192.168.8.193", false, null, null, null, "Anambra", "02" },
                    { 3L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 113, DateTimeKind.Local).AddTicks(7482), "192.168.8.193", false, null, null, null, "Bauchi", "03" },
                    { 4L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 115, DateTimeKind.Local).AddTicks(3426), "192.168.8.193", false, null, null, null, "Adamawa", "04" },
                    { 5L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 116, DateTimeKind.Local).AddTicks(7392), "192.168.8.193", false, null, null, null, "Benue", "05" },
                    { 6L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 117, DateTimeKind.Local).AddTicks(6925), "192.168.8.193", false, null, null, null, "Borno", "06" },
                    { 7L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 133, DateTimeKind.Local).AddTicks(9605), "192.168.8.193", false, null, null, null, "Cross River", "07" },
                    { 8L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 135, DateTimeKind.Local).AddTicks(1604), "192.168.8.193", false, null, null, null, "FCT", "08" },
                    { 9L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 136, DateTimeKind.Local).AddTicks(308), "192.168.8.193", false, null, null, null, "Delta", "09" },
                    { 10L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 136, DateTimeKind.Local).AddTicks(8039), "192.168.8.193", false, null, null, null, "Imo", "10" },
                    { 11L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 137, DateTimeKind.Local).AddTicks(4136), "192.168.8.193", false, null, null, null, "Kaduna", "11" },
                    { 12L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 138, DateTimeKind.Local).AddTicks(142), "192.168.8.193", false, null, null, null, "Kano", "12" },
                    { 13L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 139, DateTimeKind.Local).AddTicks(639), "192.168.8.193", false, null, null, null, "Katsina", "13" },
                    { 14L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 139, DateTimeKind.Local).AddTicks(6813), "192.168.8.193", false, null, null, null, "Kwara", "14" },
                    { 15L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 140, DateTimeKind.Local).AddTicks(1318), "192.168.8.193", false, null, null, null, "Lagos", "15" },
                    { 16L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 140, DateTimeKind.Local).AddTicks(5609), "192.168.8.193", false, null, null, null, "Niger", "16" },
                    { 17L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 141, DateTimeKind.Local).AddTicks(612), "192.168.8.193", false, null, null, null, "Ogun", "17" },
                    { 18L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 141, DateTimeKind.Local).AddTicks(6239), "192.168.8.193", false, null, null, null, "Ondo", "18" },
                    { 19L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 142, DateTimeKind.Local).AddTicks(1345), "192.168.8.193", false, null, null, null, "Oyo", "19" },
                    { 20L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 144, DateTimeKind.Local).AddTicks(9542), "192.168.8.193", false, null, null, null, "Plateau", "20" },
                    { 21L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 147, DateTimeKind.Local).AddTicks(7935), "192.168.8.193", false, null, null, null, "Rivers", "21" },
                    { 22L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 148, DateTimeKind.Local).AddTicks(7133), "192.168.8.193", false, null, null, null, "Sokoto", "22" },
                    { 23L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 149, DateTimeKind.Local).AddTicks(3799), "192.168.8.193", false, null, null, null, "Abia", "23" },
                    { 24L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 153, DateTimeKind.Local).AddTicks(6040), "192.168.8.193", false, null, null, null, "Edo", "24" },
                    { 25L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 154, DateTimeKind.Local).AddTicks(5556), "192.168.8.193", false, null, null, null, "Enugu", "25" },
                    { 26L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 155, DateTimeKind.Local).AddTicks(1758), "192.168.8.193", false, null, null, null, "Jigawa", "26" },
                    { 27L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 158, DateTimeKind.Local).AddTicks(2210), "192.168.8.193", false, null, null, null, "Kebbi", "27" },
                    { 28L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 159, DateTimeKind.Local).AddTicks(1112), "192.168.8.193", false, null, null, null, "Kogi", "28" },
                    { 29L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 161, DateTimeKind.Local).AddTicks(3872), "192.168.8.193", false, null, null, null, "Osun", "29" },
                    { 30L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 162, DateTimeKind.Local).AddTicks(3422), "192.168.8.193", false, null, null, null, "Taraba", "30" },
                    { 31L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 163, DateTimeKind.Local).AddTicks(1040), "192.168.8.193", false, null, null, null, "Yobe", "31" },
                    { 32L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 163, DateTimeKind.Local).AddTicks(8051), "192.168.8.193", false, null, null, null, "Bayelsa", "32" },
                    { 33L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 178, DateTimeKind.Local).AddTicks(3468), "192.168.8.193", false, null, null, null, "Ebonyi", "33" },
                    { 34L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 179, DateTimeKind.Local).AddTicks(1053), "192.168.8.193", false, null, null, null, "Ekiti", "34" },
                    { 35L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 179, DateTimeKind.Local).AddTicks(7516), "192.168.8.193", false, null, null, null, "Gombe", "35" },
                    { 36L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 180, DateTimeKind.Local).AddTicks(3105), "192.168.8.193", false, null, null, null, "Nassarawa", "36" },
                    { 37L, "System", new DateTime(2024, 3, 9, 10, 24, 0, 180, DateTimeKind.Local).AddTicks(9427), "192.168.8.193", false, null, null, null, "Zamfara", "37" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "ProductConditions",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "ProductConditions",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "ProductConditions",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "ProductConditions",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.AddColumn<long>(
                name: "CountryId",
                table: "States",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "StateId",
                table: "States",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_States_StateId",
                table: "States",
                column: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_States_States_StateId",
                table: "States",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id");
        }
    }
}
