using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarketPlace.Data.Migrations
{
    /// <inheritdoc />
    public partial class LocationEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Kycs");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Kycs");

            migrationBuilder.AddColumn<long>(
                name: "ContinentId",
                table: "Products",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CountryId",
                table: "Products",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "StateId",
                table: "Products",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ContinentId",
                table: "Kycs",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CountryId",
                table: "Kycs",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "StateId",
                table: "Kycs",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Continents",
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
                    table.PrimaryKey("PK_Continents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VatRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
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
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StateCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_States", x => x.Id);
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

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryCode", "CreatedBy", "CreatedDate", "IPAddress", "IsActive", "IsDeleted", "LastModified", "ModifiedBy", "Name", "NationalCurrency", "Nationality", "PhoneCode", "VatRate" },
                values: new object[,]
                {
                    { 1L, "AD", "System", new DateTime(2024, 3, 6, 10, 30, 46, 206, DateTimeKind.Local).AddTicks(1938), "192.168.8.193", false, null, null, null, "ANDORRA", "EUR", "Andorran", "+376", null },
                    { 2L, "AE", "System", new DateTime(2024, 3, 6, 10, 30, 46, 206, DateTimeKind.Local).AddTicks(3577), "192.168.8.193", false, null, null, null, "UNITED ARAB EMIRATES", "AED", "Emirati", "+967", 5.0m },
                    { 3L, "AF", "System", new DateTime(2024, 3, 6, 10, 30, 46, 206, DateTimeKind.Local).AddTicks(4996), "192.168.8.193", false, null, null, null, "AFGHANISTAN", "AFN", "Afgans", "+93", null },
                    { 4L, "AG", "System", new DateTime(2024, 3, 6, 10, 30, 46, 206, DateTimeKind.Local).AddTicks(6462), "192.168.8.193", false, null, null, null, "ANTIGUA AND BARBUDA", "XCD", null, "+809", null },
                    { 5L, "AI", "System", new DateTime(2024, 3, 6, 10, 30, 46, 206, DateTimeKind.Local).AddTicks(7858), "192.168.8.193", false, null, null, null, "ANGUILLA", "XCD", "Anguillan", "+809", null },
                    { 6L, "AL", "System", new DateTime(2024, 3, 6, 10, 30, 46, 206, DateTimeKind.Local).AddTicks(9239), "192.168.8.193", false, null, null, null, "ALBANIA", "ALL", "Albanian", "+355", 20.0m },
                    { 7L, "AM", "System", new DateTime(2024, 3, 6, 10, 30, 46, 207, DateTimeKind.Local).AddTicks(564), "192.168.8.193", false, null, null, null, "ARMENIA", "AMD", "Armenians", "+374", 20.0m },
                    { 8L, "AN", "System", new DateTime(2024, 3, 6, 10, 30, 46, 207, DateTimeKind.Local).AddTicks(1841), "192.168.8.193", false, null, null, null, "NETHERLANDS ANTILLES", "ANG", "Dutch", "+599", 21.0m },
                    { 9L, "AO", "System", new DateTime(2024, 3, 6, 10, 30, 46, 207, DateTimeKind.Local).AddTicks(3219), "192.168.8.193", false, null, null, null, "ANGOLA", "AOA", "Angolans", "+244", 14.0m },
                    { 10L, "AQ", "System", new DateTime(2024, 3, 6, 10, 30, 46, 207, DateTimeKind.Local).AddTicks(4441), "192.168.8.193", false, null, null, null, "ANTARCTICA", "N/A", null, "+672", null },
                    { 11L, "AR", "System", new DateTime(2024, 3, 6, 10, 30, 46, 207, DateTimeKind.Local).AddTicks(5659), "192.168.8.193", false, null, null, null, "ARGENTINA", "ARS", "Argentine", "+54", 21.0m },
                    { 12L, "AS", "System", new DateTime(2024, 3, 6, 10, 30, 46, 207, DateTimeKind.Local).AddTicks(6904), "192.168.8.193", false, null, null, null, "AMERICAN SAMOA", "USD", "American Samoans", "+684", null },
                    { 13L, "AT", "System", new DateTime(2024, 3, 6, 10, 30, 46, 207, DateTimeKind.Local).AddTicks(8236), "192.168.8.193", false, null, null, null, "AUSTRIA", "EUR", "Austrian", "+43", 21.0m },
                    { 14L, "AU", "System", new DateTime(2024, 3, 6, 10, 30, 46, 207, DateTimeKind.Local).AddTicks(9391), "192.168.8.193", false, null, null, null, "AUSTRALIA", "AUD", "Australian", "+61", 10.0m },
                    { 15L, "AW", "System", new DateTime(2024, 3, 6, 10, 30, 46, 208, DateTimeKind.Local).AddTicks(572), "192.168.8.193", false, null, null, null, "ARUBA", "AWG", "Dutch Caribbean", "+871", null },
                    { 16L, "AX", "System", new DateTime(2024, 3, 6, 10, 30, 46, 208, DateTimeKind.Local).AddTicks(1723), "192.168.8.193", false, null, null, null, "ÅLAND ISLANDS", "EUR", "Finnish", "+358", null },
                    { 17L, "AZ", "System", new DateTime(2024, 3, 6, 10, 30, 46, 208, DateTimeKind.Local).AddTicks(2873), "192.168.8.193", false, null, null, null, "AZERBAIJAN", "AZN", "Azerbaijani", "+994", 18.0m },
                    { 18L, "BA", "System", new DateTime(2024, 3, 6, 10, 30, 46, 208, DateTimeKind.Local).AddTicks(4099), "192.168.8.193", false, null, null, null, "BOSNIA AND HERZEGOVINA", "BAM", "Bosnian", "+387", 17.0m },
                    { 19L, "BB", "System", new DateTime(2024, 3, 6, 10, 30, 46, 208, DateTimeKind.Local).AddTicks(5258), "192.168.8.193", false, null, null, null, "BARBADOS", "BBD", "Barbadians", "+246", 17.5m },
                    { 20L, "BD", "System", new DateTime(2024, 3, 6, 10, 30, 46, 208, DateTimeKind.Local).AddTicks(6460), "192.168.8.193", false, null, null, null, "BANGLADESH", "BDT", "Bangladeshi", "+880", null },
                    { 21L, "BE", "System", new DateTime(2024, 3, 6, 10, 30, 46, 208, DateTimeKind.Local).AddTicks(7611), "192.168.8.193", false, null, null, null, "BELGIUM", "EUR", "Belgians", "+32", 21.0m },
                    { 22L, "BF", "System", new DateTime(2024, 3, 6, 10, 30, 46, 208, DateTimeKind.Local).AddTicks(8776), "192.168.8.193", false, null, null, null, "BURKINA FASO", "XOF", "Burkinabe", "+226", 18.0m },
                    { 23L, "BG", "System", new DateTime(2024, 3, 6, 10, 30, 46, 208, DateTimeKind.Local).AddTicks(9934), "192.168.8.193", false, null, null, null, "BULGARIA", "BGN", "Bulgarian", "+359", 20.0m },
                    { 24L, "BH", "System", new DateTime(2024, 3, 6, 10, 30, 46, 209, DateTimeKind.Local).AddTicks(1176), "192.168.8.193", false, null, null, null, "BAHRAIN", "BHD", "Bahraini", "+973", 5.0m },
                    { 25L, "BI", "System", new DateTime(2024, 3, 6, 10, 30, 46, 209, DateTimeKind.Local).AddTicks(2333), "192.168.8.193", false, null, null, null, "BURUNDI", "BIF", "Burundian", "+257", 18.0m },
                    { 26L, "BJ", "System", new DateTime(2024, 3, 6, 10, 30, 46, 209, DateTimeKind.Local).AddTicks(3545), "192.168.8.193", false, null, null, null, "BENIN", "XOF", "Beninese", "+229", 18.0m },
                    { 27L, "BL", "System", new DateTime(2024, 3, 6, 10, 30, 46, 209, DateTimeKind.Local).AddTicks(4703), "192.168.8.193", false, null, null, null, "SAINT BARTHÉLEMY", "EUR", "SAINT BARTHÉLEMOIS", "+590", 8.5m },
                    { 28L, "BM", "System", new DateTime(2024, 3, 6, 10, 30, 46, 209, DateTimeKind.Local).AddTicks(5856), "192.168.8.193", false, null, null, null, "BERMUDA", "BMD", "Bermudian", "+809", null },
                    { 29L, "BN", "System", new DateTime(2024, 3, 6, 10, 30, 46, 209, DateTimeKind.Local).AddTicks(7009), "192.168.8.193", false, null, null, null, "BRUNEI DARUSSALAM", "BND", "Bruneian", "+673", null },
                    { 30L, "BO", "System", new DateTime(2024, 3, 6, 10, 30, 46, 209, DateTimeKind.Local).AddTicks(8152), "192.168.8.193", false, null, null, null, "BOLIVIA", "BOB", "Bolivian", "+591", 13.0m },
                    { 31L, "BQ", "System", new DateTime(2024, 3, 6, 10, 30, 46, 209, DateTimeKind.Local).AddTicks(9299), "192.168.8.193", false, null, null, null, "BONAIRE, SAINT EUSTATIUS AND SABA", "USD", "Not Set", "+599", 8.0m },
                    { 32L, "BR", "System", new DateTime(2024, 3, 6, 10, 30, 46, 210, DateTimeKind.Local).AddTicks(457), "192.168.8.193", false, null, null, null, "BRAZIL", "BRL", "Bazillian", "+55", 18.0m },
                    { 33L, "BS", "System", new DateTime(2024, 3, 6, 10, 30, 46, 210, DateTimeKind.Local).AddTicks(1809), "192.168.8.193", false, null, null, null, "BAHAMAS", "BSD", "Bahamian", "+809", 12.0m },
                    { 34L, "BT", "System", new DateTime(2024, 3, 6, 10, 30, 46, 210, DateTimeKind.Local).AddTicks(3093), "192.168.8.193", false, null, null, null, "BHUTAN", "BTN", "Bhutanese", "+975", 50.0m },
                    { 35L, "BV", "System", new DateTime(2024, 3, 6, 10, 30, 46, 210, DateTimeKind.Local).AddTicks(4399), "192.168.8.193", false, null, null, null, "BOUVET ISLAND", "NOK", null, "+55", null },
                    { 36L, "BW", "System", new DateTime(2024, 3, 6, 10, 30, 46, 210, DateTimeKind.Local).AddTicks(6178), "192.168.8.193", false, null, null, null, "BOTSWANA", "BWP", "Batswana", "+267", 12.0m },
                    { 37L, "BY", "System", new DateTime(2024, 3, 6, 10, 30, 46, 210, DateTimeKind.Local).AddTicks(7664), "192.168.8.193", false, null, null, null, "BELARUS", "BYR", "Belarussian", "+375", 20.0m },
                    { 38L, "BZ", "System", new DateTime(2024, 3, 6, 10, 30, 46, 210, DateTimeKind.Local).AddTicks(9070), "192.168.8.193", false, null, null, null, "BELIZE", "BZD", "Belizean", "+501", 15.0m },
                    { 39L, "CA", "System", new DateTime(2024, 3, 6, 10, 30, 46, 211, DateTimeKind.Local).AddTicks(288), "192.168.8.193", false, null, null, null, "CANADA", "CAD", "Canadaian", "+1", 15.0m },
                    { 40L, "CC", "System", new DateTime(2024, 3, 6, 10, 30, 46, 211, DateTimeKind.Local).AddTicks(1522), "192.168.8.193", false, null, null, null, "COCOS (KEELING) ISLANDS", "AUD", null, "+61", 13.5m },
                    { 41L, "CD", "System", new DateTime(2024, 3, 6, 10, 30, 46, 211, DateTimeKind.Local).AddTicks(2753), "192.168.8.193", false, null, null, null, "CONGO, THE DEMOCRATIC REPUBLIC OF THE", "CDF", "Congolese", "+243", 16.0m },
                    { 42L, "CF", "System", new DateTime(2024, 3, 6, 10, 30, 46, 211, DateTimeKind.Local).AddTicks(6581), "192.168.8.193", false, null, null, null, "CENTRAL AFRICAN REPUBLIC", "XAF", "Central African", "+236", 19.0m },
                    { 43L, "CG", "System", new DateTime(2024, 3, 6, 10, 30, 46, 212, DateTimeKind.Local).AddTicks(368), "192.168.8.193", false, null, null, null, "CONGO", "XAF", "Congolese", "+242", 16.0m },
                    { 44L, "CH", "System", new DateTime(2024, 3, 6, 10, 30, 46, 212, DateTimeKind.Local).AddTicks(2700), "192.168.8.193", false, null, null, null, "SWITZERLAND", "CHF", "Swiss", "+41", 7.7m },
                    { 45L, "CI", "System", new DateTime(2024, 3, 6, 10, 30, 46, 212, DateTimeKind.Local).AddTicks(4897), "192.168.8.193", false, null, null, null, "COTE D'IVOIRE", "XOF", "Ivorian", "+225", 18.0m },
                    { 46L, "CK", "System", new DateTime(2024, 3, 6, 10, 30, 46, 212, DateTimeKind.Local).AddTicks(7244), "192.168.8.193", false, null, null, null, "COOK ISLANDS", "NZD", null, "+682", 15.0m },
                    { 47L, "CL", "System", new DateTime(2024, 3, 6, 10, 30, 46, 212, DateTimeKind.Local).AddTicks(9452), "192.168.8.193", false, null, null, null, "CHILE", "CLP", "Chilean", "+56", 19.0m },
                    { 48L, "CM", "System", new DateTime(2024, 3, 6, 10, 30, 46, 213, DateTimeKind.Local).AddTicks(1388), "192.168.8.193", false, null, null, null, "CAMEROON", "XAF", "Cameroonian", "+237", 19.25m },
                    { 49L, "CN", "System", new DateTime(2024, 3, 6, 10, 30, 46, 213, DateTimeKind.Local).AddTicks(3309), "192.168.8.193", false, null, null, null, "CHINA", "CNY", "Chinese", "+86", 13.0m },
                    { 50L, "CO", "System", new DateTime(2024, 3, 6, 10, 30, 46, 213, DateTimeKind.Local).AddTicks(5198), "192.168.8.193", false, null, null, null, "COLOMBIA", "COP", "Colombian", "+506", 19.0m },
                    { 51L, "CR", "System", new DateTime(2024, 3, 6, 10, 30, 46, 213, DateTimeKind.Local).AddTicks(7128), "192.168.8.193", false, null, null, null, "COSTA RICA", "CRC", "Costa Rican", "+506", 13.0m },
                    { 52L, "CU", "System", new DateTime(2024, 3, 6, 10, 30, 46, 213, DateTimeKind.Local).AddTicks(8815), "192.168.8.193", false, null, null, null, "CUBA", "CUP", "Cuban", "+53", 2.0m },
                    { 53L, "CV", "System", new DateTime(2024, 3, 6, 10, 30, 46, 214, DateTimeKind.Local).AddTicks(325), "192.168.8.193", false, null, null, null, "CAPE VERDE", "CVE", "Cape Verdean", "+238", 15.0m },
                    { 54L, "CW", "System", new DateTime(2024, 3, 6, 10, 30, 46, 214, DateTimeKind.Local).AddTicks(1942), "192.168.8.193", false, null, null, null, "CURACAO", "ANG", "Dutch", "+599", 6.0m },
                    { 55L, "CX", "System", new DateTime(2024, 3, 6, 10, 30, 46, 214, DateTimeKind.Local).AddTicks(3565), "192.168.8.193", false, null, null, null, "CHRISTMAS ISLAND", "AUD", "Christmas Islander", "+61", null },
                    { 56L, "CY", "System", new DateTime(2024, 3, 6, 10, 30, 46, 214, DateTimeKind.Local).AddTicks(5261), "192.168.8.193", false, null, null, null, "CYPRUS", "EUR", "Cypriot", "+357", 19.0m },
                    { 57L, "CZ", "System", new DateTime(2024, 3, 6, 10, 30, 46, 214, DateTimeKind.Local).AddTicks(6730), "192.168.8.193", false, null, null, null, "CZECH REPUBLIC", "CZK", "Czech", "+420", 21.0m },
                    { 58L, "DE", "System", new DateTime(2024, 3, 6, 10, 30, 46, 214, DateTimeKind.Local).AddTicks(8125), "192.168.8.193", false, null, null, null, "GERMANY", "EUR", "German", "+49", 16.0m },
                    { 59L, "DJ", "System", new DateTime(2024, 3, 6, 10, 30, 46, 214, DateTimeKind.Local).AddTicks(9437), "192.168.8.193", false, null, null, null, "DJIBOUTI", "DJF", "Djibouti", "+253", 10.0m },
                    { 60L, "DK", "System", new DateTime(2024, 3, 6, 10, 30, 46, 215, DateTimeKind.Local).AddTicks(738), "192.168.8.193", false, null, null, null, "DENMARK", "DKK", "Dane", "+45", 25.0m },
                    { 61L, "DM", "System", new DateTime(2024, 3, 6, 10, 30, 46, 215, DateTimeKind.Local).AddTicks(2001), "192.168.8.193", false, null, null, null, "DOMINICA", "XCD", "Dominican", "+767", 15.0m },
                    { 62L, "DO", "System", new DateTime(2024, 3, 6, 10, 30, 46, 215, DateTimeKind.Local).AddTicks(3250), "192.168.8.193", false, null, null, null, "DOMINICAN REPUBLIC", "DOP", "Dominican", "+1", 18.0m },
                    { 63L, "DZ", "System", new DateTime(2024, 3, 6, 10, 30, 46, 215, DateTimeKind.Local).AddTicks(4468), "192.168.8.193", false, null, null, null, "ALGERIA", "DZD", "Algerian", "+213", 19.0m },
                    { 64L, "EC", "System", new DateTime(2024, 3, 6, 10, 30, 46, 215, DateTimeKind.Local).AddTicks(5711), "192.168.8.193", false, null, null, null, "ECUADOR", "USD", "Ecuadorian", "+593", 12.0m },
                    { 65L, "EE", "System", new DateTime(2024, 3, 6, 10, 30, 46, 215, DateTimeKind.Local).AddTicks(6936), "192.168.8.193", false, null, null, null, "ESTONIA", "EUR", "Estonian", "+372", 20.0m },
                    { 66L, "EG", "System", new DateTime(2024, 3, 6, 10, 30, 46, 215, DateTimeKind.Local).AddTicks(8156), "192.168.8.193", false, null, null, null, "EGYPT", "EGP", "Egyptian", "+20", 18.0m },
                    { 67L, "EH", "System", new DateTime(2024, 3, 6, 10, 30, 46, 215, DateTimeKind.Local).AddTicks(9432), "192.168.8.193", false, null, null, null, "WESTERN SAHARA", "MAD", "Saharawi", "+212", null },
                    { 68L, "ER", "System", new DateTime(2024, 3, 6, 10, 30, 46, 216, DateTimeKind.Local).AddTicks(718), "192.168.8.193", false, null, null, null, "ERITREA", "ERN", "Eritean", "+291", 5.0m },
                    { 69L, "ES", "System", new DateTime(2024, 3, 6, 10, 30, 46, 216, DateTimeKind.Local).AddTicks(1943), "192.168.8.193", false, null, null, null, "SPAIN", "EUR", "Spaniard", "+34", 21.0m },
                    { 70L, "ET", "System", new DateTime(2024, 3, 6, 10, 30, 46, 216, DateTimeKind.Local).AddTicks(3210), "192.168.8.193", false, null, null, null, "ETHIOPIA", "ETB", "Ethiopian", "+251", 15.0m },
                    { 71L, "FI", "System", new DateTime(2024, 3, 6, 10, 30, 46, 216, DateTimeKind.Local).AddTicks(4425), "192.168.8.193", false, null, null, null, "FINLAND", "EUR", "Finn", "+358", 24.0m },
                    { 72L, "FJ", "System", new DateTime(2024, 3, 6, 10, 30, 46, 216, DateTimeKind.Local).AddTicks(5644), "192.168.8.193", false, null, null, null, "FIJI", "FJD", "Fijian", "+679", 9.0m },
                    { 73L, "FK", "System", new DateTime(2024, 3, 6, 10, 30, 46, 216, DateTimeKind.Local).AddTicks(6868), "192.168.8.193", false, null, null, null, "FALKLAND ISLANDS (MALVINAS)", "FKP", "Falkland Islander", "+500", 20.0m },
                    { 74L, "FM", "System", new DateTime(2024, 3, 6, 10, 30, 46, 216, DateTimeKind.Local).AddTicks(8088), "192.168.8.193", false, null, null, null, "MICRONESIA, FEDERATED STATES OF", "USD", "Micronesian", "+691", 5.0m },
                    { 75L, "FO", "System", new DateTime(2024, 3, 6, 10, 30, 46, 216, DateTimeKind.Local).AddTicks(9317), "192.168.8.193", false, null, null, null, "FAROE ISLANDS", "DKK", "Faroese", "+298", 18.0m },
                    { 76L, "FR", "System", new DateTime(2024, 3, 6, 10, 30, 46, 217, DateTimeKind.Local).AddTicks(796), "192.168.8.193", false, null, null, null, "FRANCE", "EUR", "FrenchPerson", "+508", 20.0m },
                    { 77L, "FX", "System", new DateTime(2024, 3, 6, 10, 30, 46, 217, DateTimeKind.Local).AddTicks(2175), "192.168.8.193", false, null, null, null, "FRANCE, METROPOLITAN", "EUR", "FrenchPerson", "+508", 20.0m },
                    { 78L, "GA", "System", new DateTime(2024, 3, 6, 10, 30, 46, 217, DateTimeKind.Local).AddTicks(3599), "192.168.8.193", false, null, null, null, "GABON", "XAF", "Gabonese", "+241", 18.0m },
                    { 79L, "GB", "System", new DateTime(2024, 3, 6, 10, 30, 46, 217, DateTimeKind.Local).AddTicks(5083), "192.168.8.193", false, null, null, null, "UNITED KINGDOM", "GBP", "Brit", "+44", 20.0m },
                    { 80L, "GD", "System", new DateTime(2024, 3, 6, 10, 30, 46, 217, DateTimeKind.Local).AddTicks(6559), "192.168.8.193", false, null, null, null, "GRENADA", "XCD", "Grenadian", "+473", 15.0m },
                    { 81L, "GE", "System", new DateTime(2024, 3, 6, 10, 30, 46, 217, DateTimeKind.Local).AddTicks(8127), "192.168.8.193", false, null, null, null, "GEORGIA", "GEL", "Georgian", "+995", 18.0m },
                    { 82L, "GF", "System", new DateTime(2024, 3, 6, 10, 30, 46, 217, DateTimeKind.Local).AddTicks(9468), "192.168.8.193", false, null, null, null, "FRENCH GUIANA", "EUR", null, "+594", 20.0m },
                    { 83L, "GG", "System", new DateTime(2024, 3, 6, 10, 30, 46, 218, DateTimeKind.Local).AddTicks(829), "192.168.8.193", false, null, null, null, "GUERNSEY", "GBP", null, "+44", null },
                    { 84L, "GH", "System", new DateTime(2024, 3, 6, 10, 30, 46, 218, DateTimeKind.Local).AddTicks(2105), "192.168.8.193", false, null, null, null, "GHANA", "GHS", "Ghanaian", "+233", 12.5m },
                    { 85L, "GI", "System", new DateTime(2024, 3, 6, 10, 30, 46, 218, DateTimeKind.Local).AddTicks(3323), "192.168.8.193", false, null, null, null, "GIBRALTAR", "GIP", "Gibraltarian", "+350", null },
                    { 86L, "GL", "System", new DateTime(2024, 3, 6, 10, 30, 46, 218, DateTimeKind.Local).AddTicks(4556), "192.168.8.193", false, null, null, null, "GREENLAND", "DKK", null, "+299", null },
                    { 87L, "GM", "System", new DateTime(2024, 3, 6, 10, 30, 46, 218, DateTimeKind.Local).AddTicks(5794), "192.168.8.193", false, null, null, null, "GAMBIA", "GMD", "Gambian", "+220", 15.0m },
                    { 88L, "GN", "System", new DateTime(2024, 3, 6, 10, 30, 46, 218, DateTimeKind.Local).AddTicks(7018), "192.168.8.193", false, null, null, null, "GUINEA", "GNF", "Guinean", "+224", 18.0m },
                    { 89L, "GP", "System", new DateTime(2024, 3, 6, 10, 30, 46, 218, DateTimeKind.Local).AddTicks(8203), "192.168.8.193", false, null, null, null, "GUADELOUPE", "EUR", null, "+590", 8.5m },
                    { 90L, "GQ", "System", new DateTime(2024, 3, 6, 10, 30, 46, 218, DateTimeKind.Local).AddTicks(9450), "192.168.8.193", false, null, null, null, "EQUATORIAL GUINEA", "XAF", "Equatoguinean", "+240", 15.0m },
                    { 91L, "GR", "System", new DateTime(2024, 3, 6, 10, 30, 46, 219, DateTimeKind.Local).AddTicks(647), "192.168.8.193", false, null, null, null, "GREECE", "EUR", "Greek", "+30", 24.0m },
                    { 92L, "GS", "System", new DateTime(2024, 3, 6, 10, 30, 46, 219, DateTimeKind.Local).AddTicks(1805), "192.168.8.193", false, null, null, null, "SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS", "GBP", null, "+500", null },
                    { 93L, "GT", "System", new DateTime(2024, 3, 6, 10, 30, 46, 219, DateTimeKind.Local).AddTicks(3008), "192.168.8.193", false, null, null, null, "GUATEMALA", "GTQ", "Guatemalan", "+502", 12.0m },
                    { 94L, "GU", "System", new DateTime(2024, 3, 6, 10, 30, 46, 219, DateTimeKind.Local).AddTicks(4236), "192.168.8.193", false, null, null, null, "GUAM", "USD", "Guamanian", "+671", 2.0m },
                    { 95L, "GW", "System", new DateTime(2024, 3, 6, 10, 30, 46, 219, DateTimeKind.Local).AddTicks(5803), "192.168.8.193", false, null, null, null, "GUINEA-BISSAU", "XOF", "Bissau Guinean", "+240", 15.0m },
                    { 96L, "GY", "System", new DateTime(2024, 3, 6, 10, 30, 46, 219, DateTimeKind.Local).AddTicks(7268), "192.168.8.193", false, null, null, null, "GUYANA", "GYD", "Guyanese", "+592", 14.0m },
                    { 97L, "HK", "System", new DateTime(2024, 3, 6, 10, 30, 46, 219, DateTimeKind.Local).AddTicks(8768), "192.168.8.193", false, null, null, null, "HONG KONG", "HKD", "Hong konger", "+852", null },
                    { 98L, "HM", "System", new DateTime(2024, 3, 6, 10, 30, 46, 220, DateTimeKind.Local).AddTicks(183), "192.168.8.193", false, null, null, null, "HEARD ISLAND AND MCDONALD ISLANDS", "AUD", null, "+672", null },
                    { 99L, "HN", "System", new DateTime(2024, 3, 6, 10, 30, 46, 220, DateTimeKind.Local).AddTicks(1718), "192.168.8.193", false, null, null, null, "HONDURAS", "HNL", "Hondurian", "+504", 15.0m },
                    { 100L, "HR", "System", new DateTime(2024, 3, 6, 10, 30, 46, 220, DateTimeKind.Local).AddTicks(3734), "192.168.8.193", false, null, null, null, "CROATIA (local name: Hrvatska)", "HRK", "Croat", "+385", 25.0m },
                    { 101L, "HT", "System", new DateTime(2024, 3, 6, 10, 30, 46, 220, DateTimeKind.Local).AddTicks(5759), "192.168.8.193", false, null, null, null, "HAITI", "HTG ", "Haitian", "+509", 10.0m },
                    { 102L, "HU", "System", new DateTime(2024, 3, 6, 10, 30, 46, 220, DateTimeKind.Local).AddTicks(7535), "192.168.8.193", false, null, null, null, "HUNGARY", "HUF", "Hungarian", "+36", 27.0m },
                    { 103L, "ID", "System", new DateTime(2024, 3, 6, 10, 30, 46, 220, DateTimeKind.Local).AddTicks(9541), "192.168.8.193", false, null, null, null, "INDONESIA", "IDR", "Indonesian", "+62", 10.0m },
                    { 104L, "IE", "System", new DateTime(2024, 3, 6, 10, 30, 46, 221, DateTimeKind.Local).AddTicks(1529), "192.168.8.193", false, null, null, null, "IRELAND", "EUR", "IrishPerson", "+353", 23.0m },
                    { 105L, "IL", "System", new DateTime(2024, 3, 6, 10, 30, 46, 221, DateTimeKind.Local).AddTicks(3207), "192.168.8.193", false, null, null, null, "ISRAEL", "ILS", "Isreali", "+972", 18.0m },
                    { 106L, "IM", "System", new DateTime(2024, 3, 6, 10, 30, 46, 221, DateTimeKind.Local).AddTicks(4744), "192.168.8.193", false, null, null, null, "ISLE OF MAN", "GBP", null, "+44", 20.0m },
                    { 107L, "IN", "System", new DateTime(2024, 3, 6, 10, 30, 46, 221, DateTimeKind.Local).AddTicks(6328), "192.168.8.193", false, null, null, null, "INDIA", "INR", "Indian", "+91", 5.0m },
                    { 108L, "IO", "System", new DateTime(2024, 3, 6, 10, 30, 46, 221, DateTimeKind.Local).AddTicks(7693), "192.168.8.193", false, null, null, null, "BRITISH INDIAN OCEAN TERRITORY", "USD", null, "+809", null },
                    { 109L, "IQ", "System", new DateTime(2024, 3, 6, 10, 30, 46, 221, DateTimeKind.Local).AddTicks(8943), "192.168.8.193", false, null, null, null, "IRAQ", "IQD", "Iraqi", "+964", 0.0m },
                    { 110L, "IR", "System", new DateTime(2024, 3, 6, 10, 30, 46, 222, DateTimeKind.Local).AddTicks(133), "192.168.8.193", false, null, null, null, "IRAN, ISLAMIC REPUBLIC OF", "IRR", "Iranian", "+98", null },
                    { 111L, "IS", "System", new DateTime(2024, 3, 6, 10, 30, 46, 222, DateTimeKind.Local).AddTicks(1351), "192.168.8.193", false, null, null, null, "ICELAND", "ISK", "Icelandic", "+354", 24.0m },
                    { 112L, "IT", "System", new DateTime(2024, 3, 6, 10, 30, 46, 222, DateTimeKind.Local).AddTicks(2599), "192.168.8.193", false, null, null, null, "ITALY", "EUR", "Italian", "+295", 22.0m },
                    { 113L, "JE", "System", new DateTime(2024, 3, 6, 10, 30, 46, 222, DateTimeKind.Local).AddTicks(3784), "192.168.8.193", false, null, null, null, "JERSEY", "GBP", null, "+44", 3.0m },
                    { 114L, "JM", "System", new DateTime(2024, 3, 6, 10, 30, 46, 222, DateTimeKind.Local).AddTicks(4962), "192.168.8.193", false, null, null, null, "JAMAICA", "JMD", "Jamaican", "+876", 15.0m },
                    { 115L, "JO", "System", new DateTime(2024, 3, 6, 10, 30, 46, 222, DateTimeKind.Local).AddTicks(6194), "192.168.8.193", false, null, null, null, "JORDAN", "JOD", "Jordanian", "+962", null },
                    { 116L, "JP", "System", new DateTime(2024, 3, 6, 10, 30, 46, 222, DateTimeKind.Local).AddTicks(7351), "192.168.8.193", false, null, null, null, "JAPAN", "JPY", "Japanese", "+81", 8.0m },
                    { 117L, "KE", "System", new DateTime(2024, 3, 6, 10, 30, 46, 222, DateTimeKind.Local).AddTicks(8508), "192.168.8.193", false, null, null, null, "KENYA", "KES", "Kenyan", "+254", 16.0m },
                    { 118L, "KG", "System", new DateTime(2024, 3, 6, 10, 30, 46, 222, DateTimeKind.Local).AddTicks(9781), "192.168.8.193", false, null, null, null, "KYRGYZSTAN", "KGS", "Kyrgyz", "+996", 12.0m },
                    { 119L, "KH", "System", new DateTime(2024, 3, 6, 10, 30, 46, 223, DateTimeKind.Local).AddTicks(960), "192.168.8.193", false, null, null, null, "CAMBODIA", "KHR", "Cambodian", "+855", 10.0m },
                    { 120L, "KI", "System", new DateTime(2024, 3, 6, 10, 30, 46, 223, DateTimeKind.Local).AddTicks(2124), "192.168.8.193", false, null, null, null, "KIRIBATI", "AUD", "Kiribatian", "+686", 12.0m },
                    { 121L, "KM", "System", new DateTime(2024, 3, 6, 10, 30, 46, 223, DateTimeKind.Local).AddTicks(3279), "192.168.8.193", false, null, null, null, "COMOROS", "KMF", "Comorian", "+269", 35.0m },
                    { 122L, "KN", "System", new DateTime(2024, 3, 6, 10, 30, 46, 223, DateTimeKind.Local).AddTicks(4428), "192.168.8.193", false, null, null, null, "SAINT KITTS AND NEVIS", "XCD", "Kettitian and Nevisian", "+869", 17.0m },
                    { 123L, "KP", "System", new DateTime(2024, 3, 6, 10, 30, 46, 223, DateTimeKind.Local).AddTicks(5632), "192.168.8.193", false, null, null, null, "KOREA, DEMOCRATIC PEOPLE'S REPUBLIC OF", "KPW", "Korean", "+82", 10.0m },
                    { 124L, "KR", "System", new DateTime(2024, 3, 6, 10, 30, 46, 223, DateTimeKind.Local).AddTicks(6778), "192.168.8.193", false, null, null, null, "KOREA, REPUBLIC OF", "KRW", "Korean", "+82", 10.0m },
                    { 125L, "KW", "System", new DateTime(2024, 3, 6, 10, 30, 46, 223, DateTimeKind.Local).AddTicks(7948), "192.168.8.193", false, null, null, null, "KUWAIT", "KWD", "Kuwaiti", "+965", null },
                    { 126L, "KY", "System", new DateTime(2024, 3, 6, 10, 30, 46, 223, DateTimeKind.Local).AddTicks(9106), "192.168.8.193", false, null, null, null, "CAYMAN ISLANDS", "KYD", "Caymanians", "+345", null },
                    { 127L, "KZ", "System", new DateTime(2024, 3, 6, 10, 30, 46, 224, DateTimeKind.Local).AddTicks(288), "192.168.8.193", false, null, null, null, "KAZAKHSTAN", "KZT", "Kazakhs", "+7", 12.0m },
                    { 128L, "LA", "System", new DateTime(2024, 3, 6, 10, 30, 46, 224, DateTimeKind.Local).AddTicks(1564), "192.168.8.193", false, null, null, null, "LAO PEOPLE'S DEMOCRATIC REPUBLIC", "LAK", "Laotian", "+856", 10.0m },
                    { 129L, "LB", "System", new DateTime(2024, 3, 6, 10, 30, 46, 224, DateTimeKind.Local).AddTicks(2850), "192.168.8.193", false, null, null, null, "LEBANON", "LBP", "Lebanese", "+961", 11.0m },
                    { 130L, "LC", "System", new DateTime(2024, 3, 6, 10, 30, 46, 224, DateTimeKind.Local).AddTicks(4171), "192.168.8.193", false, null, null, null, "SAINT LUCIA", "XCD", "Saint Lucian", "+758", 12.5m },
                    { 131L, "LI", "System", new DateTime(2024, 3, 6, 10, 30, 46, 224, DateTimeKind.Local).AddTicks(5602), "192.168.8.193", false, null, null, null, "LIECHTENSTEIN", "CHF", "Liechtensteiner", "+41", 7.7m },
                    { 132L, "LK", "System", new DateTime(2024, 3, 6, 10, 30, 46, 224, DateTimeKind.Local).AddTicks(6958), "192.168.8.193", false, null, null, null, "SRI LANKA", "LKR", "Sri Lankan", "+94", 8.0m },
                    { 133L, "LR", "System", new DateTime(2024, 3, 6, 10, 30, 46, 224, DateTimeKind.Local).AddTicks(8266), "192.168.8.193", false, null, null, null, "LIBERIA", "LRD", "Liberian", "+231", 10.0m },
                    { 134L, "LS", "System", new DateTime(2024, 3, 6, 10, 30, 46, 224, DateTimeKind.Local).AddTicks(9573), "192.168.8.193", false, null, null, null, "LESOTHO", "ZAR", "Basotho", "+266", 15.0m },
                    { 135L, "LT", "System", new DateTime(2024, 3, 6, 10, 30, 46, 225, DateTimeKind.Local).AddTicks(787), "192.168.8.193", false, null, null, null, "LITHUANIA", "EUR", "Lithuanian", "+370", 21.0m },
                    { 136L, "LU", "System", new DateTime(2024, 3, 6, 10, 30, 46, 225, DateTimeKind.Local).AddTicks(3458), "192.168.8.193", false, null, null, null, "LUXEMBOURG", "EUR", "Luxembourger", "+352", 21.0m },
                    { 137L, "LV", "System", new DateTime(2024, 3, 6, 10, 30, 46, 225, DateTimeKind.Local).AddTicks(4695), "192.168.8.193", false, null, null, null, "LATVIA", "EUR", "Latvian", "+371", null },
                    { 138L, "LY", "System", new DateTime(2024, 3, 6, 10, 30, 46, 225, DateTimeKind.Local).AddTicks(5913), "192.168.8.193", false, null, null, null, "LIBYAN ARAB JAMAHIRIYA", "LYD", "Libyan", "+218", null },
                    { 139L, "MA", "System", new DateTime(2024, 3, 6, 10, 30, 46, 225, DateTimeKind.Local).AddTicks(7132), "192.168.8.193", false, null, null, null, "MOROCCO", "MAD", "Moroccan", "+212", 20.0m },
                    { 140L, "MC", "System", new DateTime(2024, 3, 6, 10, 30, 46, 225, DateTimeKind.Local).AddTicks(8346), "192.168.8.193", false, null, null, null, "MONACO", "EUR", "Monegasque", "+377", 20.0m },
                    { 141L, "MD", "System", new DateTime(2024, 3, 6, 10, 30, 46, 225, DateTimeKind.Local).AddTicks(9575), "192.168.8.193", false, null, null, null, "MOLDOVA", "MDL", "Moldovan", "+373", 20.0m },
                    { 142L, "ME", "System", new DateTime(2024, 3, 6, 10, 30, 46, 226, DateTimeKind.Local).AddTicks(1401), "192.168.8.193", false, null, null, null, "MONTENEGRO", "EUR", "Montenegrin", "+382", 21.0m },
                    { 143L, "MF", "System", new DateTime(2024, 3, 6, 10, 30, 46, 226, DateTimeKind.Local).AddTicks(3483), "192.168.8.193", false, null, null, null, "SAINT MARTIN (FRENCH PART)", "EUR", null, "+599", null },
                    { 144L, "MG", "System", new DateTime(2024, 3, 6, 10, 30, 46, 226, DateTimeKind.Local).AddTicks(5454), "192.168.8.193", false, null, null, null, "MADAGASCAR", "MGA", "Malagasy", "+261", 20.0m },
                    { 145L, "MH", "System", new DateTime(2024, 3, 6, 10, 30, 46, 226, DateTimeKind.Local).AddTicks(7477), "192.168.8.193", false, null, null, null, "MARSHALL ISLANDS", "USD", "Marshallese", "+692", null },
                    { 146L, "MK", "System", new DateTime(2024, 3, 6, 10, 30, 46, 226, DateTimeKind.Local).AddTicks(9308), "192.168.8.193", false, null, null, null, "MACEDONIA, THE FORMER YUGOSLAV REP. OF", "MKD", "Macedonians", "+389", 18.0m },
                    { 147L, "ML", "System", new DateTime(2024, 3, 6, 10, 30, 46, 227, DateTimeKind.Local).AddTicks(1244), "192.168.8.193", false, null, null, null, "MALI", "XOF", "Malian", "+223", 20.0m },
                    { 148L, "MM", "System", new DateTime(2024, 3, 6, 10, 30, 46, 227, DateTimeKind.Local).AddTicks(3069), "192.168.8.193", false, null, null, null, "MYANMAR", "MMK", "Burmese", "+95", 5.0m },
                    { 149L, "MN", "System", new DateTime(2024, 3, 6, 10, 30, 46, 227, DateTimeKind.Local).AddTicks(4898), "192.168.8.193", false, null, null, null, "MONGOLIA", "MNT", "Mongolian", "+976", 5.0m },
                    { 150L, "MO", "System", new DateTime(2024, 3, 6, 10, 30, 46, 227, DateTimeKind.Local).AddTicks(6696), "192.168.8.193", false, null, null, null, "MACAO", "MOP", "Macanese", "+853", null },
                    { 151L, "MP", "System", new DateTime(2024, 3, 6, 10, 30, 46, 227, DateTimeKind.Local).AddTicks(8487), "192.168.8.193", false, null, null, null, "NORTHERN MARIANA ISLANDS", "USD", null, "+670", null },
                    { 152L, "MQ", "System", new DateTime(2024, 3, 6, 10, 30, 46, 228, DateTimeKind.Local).AddTicks(1613), "192.168.8.193", false, null, null, null, "MARTINIQUE", "EUR", "Martiniquais", "+597", null },
                    { 153L, "MR", "System", new DateTime(2024, 3, 6, 10, 30, 46, 228, DateTimeKind.Local).AddTicks(3574), "192.168.8.193", false, null, null, null, "MAURITANIA", "MRO", "Mauritanian", "+222", 5.0m },
                    { 154L, "MS", "System", new DateTime(2024, 3, 6, 10, 30, 46, 228, DateTimeKind.Local).AddTicks(5592), "192.168.8.193", false, null, null, null, "MONTSERRAT", "XCD", "Montserratian", "+1", null },
                    { 155L, "MT", "System", new DateTime(2024, 3, 6, 10, 30, 46, 228, DateTimeKind.Local).AddTicks(7708), "192.168.8.193", false, null, null, null, "MALTA", "EUR", "Maltese", "+356", 18.0m },
                    { 156L, "MU", "System", new DateTime(2024, 3, 6, 10, 30, 46, 229, DateTimeKind.Local).AddTicks(104), "192.168.8.193", false, null, null, null, "MAURITIUS", "MUR", "Mauritian", "+230", 15.0m },
                    { 157L, "MV", "System", new DateTime(2024, 3, 6, 10, 30, 46, 229, DateTimeKind.Local).AddTicks(2465), "192.168.8.193", false, null, null, null, "MALDIVES", "MVR", "Maldivian", "+960", 6.0m },
                    { 158L, "MW", "System", new DateTime(2024, 3, 6, 10, 30, 46, 229, DateTimeKind.Local).AddTicks(4566), "192.168.8.193", false, null, null, null, "MALAWI", "MWK", "Malawian", "+265", 16.5m },
                    { 159L, "MX", "System", new DateTime(2024, 3, 6, 10, 30, 46, 229, DateTimeKind.Local).AddTicks(6705), "192.168.8.193", false, null, null, null, "MEXICO", "MXN", "Mexican", "+52", 16.0m },
                    { 160L, "MY", "System", new DateTime(2024, 3, 6, 10, 30, 46, 229, DateTimeKind.Local).AddTicks(8805), "192.168.8.193", false, null, null, null, "MALAYSIA", "MYR", "Malasian", "+60", 6.0m },
                    { 161L, "MZ", "System", new DateTime(2024, 3, 6, 10, 30, 46, 230, DateTimeKind.Local).AddTicks(899), "192.168.8.193", false, null, null, null, "MOZAMBIQUE", "MZN", "Mozambican", "+258", 17.0m },
                    { 162L, "NA", "System", new DateTime(2024, 3, 6, 10, 30, 46, 230, DateTimeKind.Local).AddTicks(3159), "192.168.8.193", false, null, null, null, "NAMIBIA", "ZAR", "Namibian", "+264", 15.0m },
                    { 163L, "NC", "System", new DateTime(2024, 3, 6, 10, 30, 46, 230, DateTimeKind.Local).AddTicks(5529), "192.168.8.193", false, null, null, null, "NEW CALEDONIA", "XPF", "New Caledonian", "+687", 4.0m },
                    { 164L, "NE", "System", new DateTime(2024, 3, 6, 10, 30, 46, 230, DateTimeKind.Local).AddTicks(7645), "192.168.8.193", false, null, null, null, "NIGER", "XOF", "Nigerien", "+227", 7.5m },
                    { 165L, "NF", "System", new DateTime(2024, 3, 6, 10, 30, 46, 230, DateTimeKind.Local).AddTicks(9664), "192.168.8.193", false, null, null, null, "NORFOLK ISLAND", "AUD", "Norfolk Islander", "+672", null },
                    { 166L, "NG", "System", new DateTime(2024, 3, 6, 10, 30, 46, 231, DateTimeKind.Local).AddTicks(1691), "192.168.8.193", false, null, null, null, "NIGERIA", "NGN", "Nigerian", "+234", 7.5m },
                    { 167L, "NI", "System", new DateTime(2024, 3, 6, 10, 30, 46, 231, DateTimeKind.Local).AddTicks(3811), "192.168.8.193", false, null, null, null, "NICARAGUA", "NIO", "Nicaraguan", "+505", 15.0m },
                    { 168L, "NL", "System", new DateTime(2024, 3, 6, 10, 30, 46, 231, DateTimeKind.Local).AddTicks(5695), "192.168.8.193", false, null, null, null, "NETHERLANDS", "EUR", "Dutch Person", "+31", 21.0m },
                    { 169L, "NO", "System", new DateTime(2024, 3, 6, 10, 30, 46, 231, DateTimeKind.Local).AddTicks(7604), "192.168.8.193", false, null, null, null, "NORWAY", "NOK", "Norwegian", "+47", 25.0m },
                    { 170L, "NP", "System", new DateTime(2024, 3, 6, 10, 30, 46, 231, DateTimeKind.Local).AddTicks(9495), "192.168.8.193", false, null, null, null, "NEPAL", "NPR", "Nepalese", "+977", 13.0m },
                    { 171L, "NR", "System", new DateTime(2024, 3, 6, 10, 30, 46, 232, DateTimeKind.Local).AddTicks(1381), "192.168.8.193", false, null, null, null, "NAURU", "AUD", "Nauruan", "+674", 5.0m },
                    { 172L, "NU", "System", new DateTime(2024, 3, 6, 10, 30, 46, 232, DateTimeKind.Local).AddTicks(3282), "192.168.8.193", false, null, null, null, "NIUE", "NZD", "Niueans", "+683", 5.0m },
                    { 173L, "NZ", "System", new DateTime(2024, 3, 6, 10, 30, 46, 232, DateTimeKind.Local).AddTicks(5101), "192.168.8.193", false, null, null, null, "NEW ZEALAND", "NZD", "New Zealander", "+64", 13.0m },
                    { 174L, "OM", "System", new DateTime(2024, 3, 6, 10, 30, 46, 232, DateTimeKind.Local).AddTicks(6999), "192.168.8.193", false, null, null, null, "OMAN", "OMR", "Omani", "+968", 5.0m },
                    { 175L, "PA", "System", new DateTime(2024, 3, 6, 10, 30, 46, 232, DateTimeKind.Local).AddTicks(8946), "192.168.8.193", false, null, null, null, "PANAMA", "PAB", "Panamanian", "+507", 7.0m },
                    { 176L, "PE", "System", new DateTime(2024, 3, 6, 10, 30, 46, 233, DateTimeKind.Local).AddTicks(833), "192.168.8.193", false, null, null, null, "PERU", "PEN", "Peruvian", "+51", 18.0m },
                    { 177L, "PF", "System", new DateTime(2024, 3, 6, 10, 30, 46, 233, DateTimeKind.Local).AddTicks(2693), "192.168.8.193", false, null, null, null, "FRENCH POLYNESIA", "XPF", "Polynesian", "+689", 16.0m },
                    { 178L, "PG", "System", new DateTime(2024, 3, 6, 10, 30, 46, 233, DateTimeKind.Local).AddTicks(4561), "192.168.8.193", false, null, null, null, "PAPUA NEW GUINEA", "PGK", null, "+675", 0.0m },
                    { 179L, "PH", "System", new DateTime(2024, 3, 6, 10, 30, 46, 233, DateTimeKind.Local).AddTicks(6487), "192.168.8.193", false, null, null, null, "PHILIPPINES", "PHP", "Filipino", "+63", 12.0m },
                    { 180L, "PK", "System", new DateTime(2024, 3, 6, 10, 30, 46, 233, DateTimeKind.Local).AddTicks(8327), "192.168.8.193", false, null, null, null, "PAKISTAN", "PKR", "Pakistani", "+92", 17.0m },
                    { 181L, "PL", "System", new DateTime(2024, 3, 6, 10, 30, 46, 234, DateTimeKind.Local).AddTicks(107), "192.168.8.193", false, null, null, null, "POLAND", "PLN", "Pole", "+48", 23.0m },
                    { 182L, "PM", "System", new DateTime(2024, 3, 6, 10, 30, 46, 234, DateTimeKind.Local).AddTicks(1831), "192.168.8.193", false, null, null, null, "ST. PIERRE AND MIQUELON", "EUR", null, "+508", 20.0m },
                    { 183L, "PN", "System", new DateTime(2024, 3, 6, 10, 30, 46, 234, DateTimeKind.Local).AddTicks(3657), "192.168.8.193", false, null, null, null, "PITCAIRN", "NZD", null, "+64", 15.25m },
                    { 184L, "PR", "System", new DateTime(2024, 3, 6, 10, 30, 46, 234, DateTimeKind.Local).AddTicks(5466), "192.168.8.193", false, null, null, null, "PUERTO RICO", "USD", "Puerto Rican", "+1", 10.5m },
                    { 185L, "PS", "System", new DateTime(2024, 3, 6, 10, 30, 46, 234, DateTimeKind.Local).AddTicks(7329), "192.168.8.193", false, null, null, null, "PALESTINIAN TERRITORY, OCCUPIED", "ILS", "Palestinian", "+970", 16.0m },
                    { 186L, "PT", "System", new DateTime(2024, 3, 6, 10, 30, 46, 234, DateTimeKind.Local).AddTicks(9371), "192.168.8.193", false, null, null, null, "PORTUGAL", "EUR", "Portugese", "+351", 23.0m },
                    { 187L, "PW", "System", new DateTime(2024, 3, 6, 10, 30, 46, 235, DateTimeKind.Local).AddTicks(1365), "192.168.8.193", false, null, null, null, "PALAU", "USD", null, "+680", 7.5m },
                    { 188L, "PY", "System", new DateTime(2024, 3, 6, 10, 30, 46, 235, DateTimeKind.Local).AddTicks(3366), "192.168.8.193", false, null, null, null, "PARAGUAY", "PYG", "Paraguayan", "+595", 10.0m },
                    { 189L, "QA", "System", new DateTime(2024, 3, 6, 10, 30, 46, 235, DateTimeKind.Local).AddTicks(5295), "192.168.8.193", false, null, null, null, "QATAR", "QAR", "Qatari", "+974", 5.0m },
                    { 190L, "RE", "System", new DateTime(2024, 3, 6, 10, 30, 46, 235, DateTimeKind.Local).AddTicks(7231), "192.168.8.193", false, null, null, null, "REUNION", "EUR", null, "+262", 8.5m },
                    { 191L, "RO", "System", new DateTime(2024, 3, 6, 10, 30, 46, 235, DateTimeKind.Local).AddTicks(9276), "192.168.8.193", false, null, null, null, "ROMANIA", "RON", "Romanian", "+40", 19.0m },
                    { 192L, "RS", "System", new DateTime(2024, 3, 6, 10, 30, 46, 236, DateTimeKind.Local).AddTicks(1526), "192.168.8.193", false, null, null, null, "SERBIA", "RSD", "Serbian", "+381", 20.0m },
                    { 193L, "RU", "System", new DateTime(2024, 3, 6, 10, 30, 46, 236, DateTimeKind.Local).AddTicks(3702), "192.168.8.193", false, null, null, null, "RUSSIAN FEDERATION", "RUB", "Russian", "+7", 20.0m },
                    { 194L, "RW", "System", new DateTime(2024, 3, 6, 10, 30, 46, 236, DateTimeKind.Local).AddTicks(5704), "192.168.8.193", false, null, null, null, "RWANDA", "RWF", "Not Set", "+250", 18.0m },
                    { 195L, "SA", "System", new DateTime(2024, 3, 6, 10, 30, 46, 236, DateTimeKind.Local).AddTicks(7856), "192.168.8.193", false, null, null, null, "SAUDI ARABIA", "SAR", "Saudi Arabian", "+966", 15.0m },
                    { 196L, "SB", "System", new DateTime(2024, 3, 6, 10, 30, 46, 236, DateTimeKind.Local).AddTicks(9804), "192.168.8.193", false, null, null, null, "SOLOMON ISLANDS", "SBD", "Not Set", "+677", 10.0m },
                    { 197L, "SC", "System", new DateTime(2024, 3, 6, 10, 30, 46, 237, DateTimeKind.Local).AddTicks(1757), "192.168.8.193", false, null, null, null, "SEYCHELLES", "SCR", "Not Set", "+677", 15.0m },
                    { 198L, "SD", "System", new DateTime(2024, 3, 6, 10, 30, 46, 237, DateTimeKind.Local).AddTicks(3664), "192.168.8.193", false, null, null, null, "SUDAN", "SDG", "Sudanese", "+249", 17.0m },
                    { 199L, "SE", "System", new DateTime(2024, 3, 6, 10, 30, 46, 237, DateTimeKind.Local).AddTicks(5572), "192.168.8.193", false, null, null, null, "SWEDEN", "SEK", "Swede", "+46", 25.0m },
                    { 200L, "SG", "System", new DateTime(2024, 3, 6, 10, 30, 46, 237, DateTimeKind.Local).AddTicks(7623), "192.168.8.193", false, null, null, null, "SINGAPORE", "SGD", "Singaporean", "+65", 7.0m },
                    { 201L, "SH", "System", new DateTime(2024, 3, 6, 10, 30, 46, 237, DateTimeKind.Local).AddTicks(9511), "192.168.8.193", false, null, null, null, "ST. HELENA, ASCENSION AND TRISTAN DA CUNHA", "SHP", null, "+290", null },
                    { 202L, "SI", "System", new DateTime(2024, 3, 6, 10, 30, 46, 238, DateTimeKind.Local).AddTicks(1393), "192.168.8.193", false, null, null, null, "SLOVENIA", "EUR", "slovanian", "+386", 22.0m },
                    { 203L, "SJ", "System", new DateTime(2024, 3, 6, 10, 30, 46, 238, DateTimeKind.Local).AddTicks(3270), "192.168.8.193", false, null, null, null, "SVALBARD AND JAN MAYEN", "NOK", null, "+47", 25.0m },
                    { 204L, "SK", "System", new DateTime(2024, 3, 6, 10, 30, 46, 238, DateTimeKind.Local).AddTicks(4991), "192.168.8.193", false, null, null, null, "SLOVAKIA (Slovak Republic)", "EUR", "Slovak", "+421", 20.0m },
                    { 205L, "SL", "System", new DateTime(2024, 3, 6, 10, 30, 46, 238, DateTimeKind.Local).AddTicks(6779), "192.168.8.193", false, null, null, null, "SIERRA LEONE", "SLL", "Sierra leonean", "+232", 15.0m },
                    { 206L, "SM", "System", new DateTime(2024, 3, 6, 10, 30, 46, 238, DateTimeKind.Local).AddTicks(8423), "192.168.8.193", false, null, null, null, "SAN MARINO", "EUR", "Sammarinese", "+378", 17.0m },
                    { 207L, "SN", "System", new DateTime(2024, 3, 6, 10, 30, 46, 239, DateTimeKind.Local).AddTicks(61), "192.168.8.193", false, null, null, null, "SENEGAL", "XOF", "Senegalese", "+221", 18.0m },
                    { 208L, "SO", "System", new DateTime(2024, 3, 6, 10, 30, 46, 239, DateTimeKind.Local).AddTicks(1679), "192.168.8.193", false, null, null, null, "SOMALIA", "SOS", "Somali", "+252", 10.0m },
                    { 209L, "SR", "System", new DateTime(2024, 3, 6, 10, 30, 46, 239, DateTimeKind.Local).AddTicks(3300), "192.168.8.193", false, null, null, null, "SURINAME", "SRD", null, "+597", 10.0m },
                    { 210L, "SS", "System", new DateTime(2024, 3, 6, 10, 30, 46, 239, DateTimeKind.Local).AddTicks(4937), "192.168.8.193", false, null, null, null, "SOUTH SUDAN", "SSP", "Sudanese", "+211", 15.0m },
                    { 211L, "ST", "System", new DateTime(2024, 3, 6, 10, 30, 46, 239, DateTimeKind.Local).AddTicks(6768), "192.168.8.193", false, null, null, null, "SAO TOME AND PRINCIPE", "STD", "Sao Tomean", "+239", 15.0m },
                    { 212L, "SV", "System", new DateTime(2024, 3, 6, 10, 30, 46, 239, DateTimeKind.Local).AddTicks(8395), "192.168.8.193", false, null, null, null, "EL SALVADOR", "USD", "Salvadorean", "+503", 13.0m },
                    { 213L, "SX", "System", new DateTime(2024, 3, 6, 10, 30, 46, 240, DateTimeKind.Local).AddTicks(104), "192.168.8.193", false, null, null, null, "SINT MAARTEN (DUTCH PART)", "ANG", null, "+599", 5.0m },
                    { 214L, "SY", "System", new DateTime(2024, 3, 6, 10, 30, 46, 240, DateTimeKind.Local).AddTicks(1796), "192.168.8.193", false, null, null, null, "SYRIAN ARAB REPUBLIC", "SYP", "Syrian", "+963", 40.0m },
                    { 215L, "SZ", "System", new DateTime(2024, 3, 6, 10, 30, 46, 240, DateTimeKind.Local).AddTicks(3624), "192.168.8.193", false, null, null, null, "SWAZILAND", "SZL", "Swazi", "+268", 14.5m },
                    { 216L, "TC", "System", new DateTime(2024, 3, 6, 10, 30, 46, 240, DateTimeKind.Local).AddTicks(5686), "192.168.8.193", false, null, null, null, "TURKS AND CAICOS ISLANDS", "USD", "Belongers", "+1", 37.5m },
                    { 217L, "TD", "System", new DateTime(2024, 3, 6, 10, 30, 46, 240, DateTimeKind.Local).AddTicks(7722), "192.168.8.193", false, null, null, null, "CHAD", "XAF", "Chadian", "+235", 18.0m },
                    { 218L, "TF", "System", new DateTime(2024, 3, 6, 10, 30, 46, 240, DateTimeKind.Local).AddTicks(9893), "192.168.8.193", false, null, null, null, "FRENCH SOUTHERN TERRITORIES", "EUR", "Not Set", "+262", null },
                    { 219L, "TG", "System", new DateTime(2024, 3, 6, 10, 30, 46, 241, DateTimeKind.Local).AddTicks(2011), "192.168.8.193", false, null, null, null, "TOGO", "XOF", "Togolese", "+228", 18.0m },
                    { 220L, "TH", "System", new DateTime(2024, 3, 6, 10, 30, 46, 241, DateTimeKind.Local).AddTicks(4249), "192.168.8.193", false, null, null, null, "THAILAND", "THB", "Thai", "+66", 7.0m },
                    { 221L, "TJ", "System", new DateTime(2024, 3, 6, 10, 30, 46, 241, DateTimeKind.Local).AddTicks(6296), "192.168.8.193", false, null, null, null, "TAJIKISTAN", "TJS", "Tajikistani", "+7", 18.0m },
                    { 222L, "TK", "System", new DateTime(2024, 3, 6, 10, 30, 46, 241, DateTimeKind.Local).AddTicks(9681), "192.168.8.193", false, null, null, null, "TOKELAU", "NZD", "Tokelau", "+690", 0.0m },
                    { 223L, "TL", "System", new DateTime(2024, 3, 6, 10, 30, 46, 242, DateTimeKind.Local).AddTicks(2365), "192.168.8.193", false, null, null, null, "TIMOR-LESTE", "USD", "portuguese", "+670", 10.0m },
                    { 224L, "TM", "System", new DateTime(2024, 3, 6, 10, 30, 46, 242, DateTimeKind.Local).AddTicks(4486), "192.168.8.193", false, null, null, null, "TURKMENISTAN", "TMT", "Turkmen", "+993", 15.0m },
                    { 225L, "TN", "System", new DateTime(2024, 3, 6, 10, 30, 46, 242, DateTimeKind.Local).AddTicks(6516), "192.168.8.193", false, null, null, null, "TUNISIA", "TND", "Tunisian", "+216", 19.0m },
                    { 226L, "TO", "System", new DateTime(2024, 3, 6, 10, 30, 46, 242, DateTimeKind.Local).AddTicks(8541), "192.168.8.193", false, null, null, null, "TONGA", "TOP", "Tongan", "+676", 15.0m },
                    { 227L, "TR", "System", new DateTime(2024, 3, 6, 10, 30, 46, 243, DateTimeKind.Local).AddTicks(584), "192.168.8.193", false, null, null, null, "TURKEY", "TRY", "Turk", "+90", 18.0m },
                    { 228L, "TT", "System", new DateTime(2024, 3, 6, 10, 30, 46, 243, DateTimeKind.Local).AddTicks(2678), "192.168.8.193", false, null, null, null, "TRINIDAD AND TOBAGO", "TTD", "Trinidian", "+868", 12.5m },
                    { 229L, "TV", "System", new DateTime(2024, 3, 6, 10, 30, 46, 243, DateTimeKind.Local).AddTicks(4670), "192.168.8.193", false, null, null, null, "TUVALU", "AUD", null, "+688", 5.0m },
                    { 230L, "TW", "System", new DateTime(2024, 3, 6, 10, 30, 46, 243, DateTimeKind.Local).AddTicks(6720), "192.168.8.193", false, null, null, null, "TAIWAN, PROVINCE OF CHINA", "TWD", "Taiwanese", "+86", null },
                    { 231L, "TZ", "System", new DateTime(2024, 3, 6, 10, 30, 46, 243, DateTimeKind.Local).AddTicks(8725), "192.168.8.193", false, null, null, null, "TANZANIA, UNITED REPUBLIC", "TZS", "Tanzanian", "+255", 18.0m },
                    { 232L, "UA", "System", new DateTime(2024, 3, 6, 10, 30, 46, 244, DateTimeKind.Local).AddTicks(624), "192.168.8.193", false, null, null, null, "UKRAINE", "UAH", "Ukranian", "+380", 20.0m },
                    { 233L, "UG", "System", new DateTime(2024, 3, 6, 10, 30, 46, 244, DateTimeKind.Local).AddTicks(2737), "192.168.8.193", false, null, null, null, "UGANDA", "UGX", "Ugandan", "+256", 18.0m },
                    { 234L, "UM", "System", new DateTime(2024, 3, 6, 10, 30, 46, 244, DateTimeKind.Local).AddTicks(4697), "192.168.8.193", false, null, null, null, "UNITED STATES MINOR OUTLYING ISLANDS", "USD", "American", "+1", null },
                    { 235L, "US", "System", new DateTime(2024, 3, 6, 10, 30, 46, 244, DateTimeKind.Local).AddTicks(6618), "192.168.8.193", false, null, null, null, "UNITED STATES", "USD", "American", "+1", null },
                    { 236L, "UY", "System", new DateTime(2024, 3, 6, 10, 30, 46, 244, DateTimeKind.Local).AddTicks(8661), "192.168.8.193", false, null, null, null, "URUGUAY", "UYU", "Uruguayan", "+598", 22.0m },
                    { 237L, "UZ", "System", new DateTime(2024, 3, 6, 10, 30, 46, 245, DateTimeKind.Local).AddTicks(607), "192.168.8.193", false, null, null, null, "UZBEKISTAN", "UZS", "Uzbek", "+7", 14.0m },
                    { 238L, "VA", "System", new DateTime(2024, 3, 6, 10, 30, 46, 245, DateTimeKind.Local).AddTicks(2811), "192.168.8.193", false, null, null, null, "HOLY SEE (VATICAN CITY STATE)", "EUR", null, "+379", null },
                    { 239L, "VC", "System", new DateTime(2024, 3, 6, 10, 30, 46, 245, DateTimeKind.Local).AddTicks(4938), "192.168.8.193", false, null, null, null, "SAINT VINCENT AND THE GRENADINES", "XCD", null, "+784", 14.0m },
                    { 240L, "VE", "System", new DateTime(2024, 3, 6, 10, 30, 46, 245, DateTimeKind.Local).AddTicks(7218), "192.168.8.193", false, null, null, null, "VENEZUELA, BOLIVARIAN REPUBLIC", "VEF", "Venezualan", "+58", 10.0m },
                    { 241L, "VG", "System", new DateTime(2024, 3, 6, 10, 30, 46, 245, DateTimeKind.Local).AddTicks(9528), "192.168.8.193", false, null, null, null, "VIRGIN ISLANDS (BRITISH)", "USD", "Virgin islander", "+1", null },
                    { 242L, "VI", "System", new DateTime(2024, 3, 6, 10, 30, 46, 246, DateTimeKind.Local).AddTicks(1858), "192.168.8.193", false, null, null, null, "VIRGIN ISLANDS (U.S.)", "USD", "Virgin islander", "+1", null },
                    { 243L, "VN", "System", new DateTime(2024, 3, 6, 10, 30, 46, 246, DateTimeKind.Local).AddTicks(4049), "192.168.8.193", false, null, null, null, "VIETNAM", "VND", "Vietnamese", "+84", 10.0m },
                    { 244L, "VU", "System", new DateTime(2024, 3, 6, 10, 30, 46, 246, DateTimeKind.Local).AddTicks(6273), "192.168.8.193", false, null, null, null, "VANUATU", "VUV", "Ni-Vanatu", "+678", 12.5m },
                    { 245L, "WF", "System", new DateTime(2024, 3, 6, 10, 30, 46, 246, DateTimeKind.Local).AddTicks(8325), "192.168.8.193", false, null, null, null, "WALLIS AND FUTUNA", "XPF", "Wallisian and Futunan", "+681", 6.0m },
                    { 246L, "WS", "System", new DateTime(2024, 3, 6, 10, 30, 46, 247, DateTimeKind.Local).AddTicks(463), "192.168.8.193", false, null, null, null, "SAMOA", "WST", "Samoan", "+684", 15.0m },
                    { 247L, "YE", "System", new DateTime(2024, 3, 6, 10, 30, 46, 247, DateTimeKind.Local).AddTicks(2594), "192.168.8.193", false, null, null, null, "YEMEN", "YER", "Yemenis", "+967", 5.0m },
                    { 248L, "YT", "System", new DateTime(2024, 3, 6, 10, 30, 46, 247, DateTimeKind.Local).AddTicks(4641), "192.168.8.193", false, null, null, null, "MAYOTTE", "EUR", null, "+262", null },
                    { 249L, "ZA", "System", new DateTime(2024, 3, 6, 10, 30, 46, 247, DateTimeKind.Local).AddTicks(6695), "192.168.8.193", false, null, null, null, "SOUTH AFRICA", "ZAR", "South African", "+27", 15.0m },
                    { 250L, "ZM", "System", new DateTime(2024, 3, 6, 10, 30, 46, 247, DateTimeKind.Local).AddTicks(8646), "192.168.8.193", false, null, null, null, "ZAMBIA", "ZMW", "Zambian", "+260", 16.0m },
                    { 251L, "ZW", "System", new DateTime(2024, 3, 6, 10, 30, 46, 248, DateTimeKind.Local).AddTicks(546), "192.168.8.193", false, null, null, null, "ZIMBABWE", "ZWL", "Zimbabwean", "+263", 14.5m }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "CountryId", "CreatedBy", "CreatedDate", "IPAddress", "IsActive", "IsDeleted", "LastModified", "ModifiedBy", "Name", "StateCode" },
                values: new object[,]
                {
                    { 1L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 248, DateTimeKind.Local).AddTicks(3131), "192.168.8.193", false, null, null, null, "Akwa Ibom", "01" },
                    { 2L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 248, DateTimeKind.Local).AddTicks(5118), "192.168.8.193", false, null, null, null, "Anambra", "02" },
                    { 3L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 248, DateTimeKind.Local).AddTicks(7091), "192.168.8.193", false, null, null, null, "Bauchi", "03" },
                    { 4L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 248, DateTimeKind.Local).AddTicks(9147), "192.168.8.193", false, null, null, null, "Adamawa", "04" },
                    { 5L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 249, DateTimeKind.Local).AddTicks(1103), "192.168.8.193", false, null, null, null, "Benue", "05" },
                    { 6L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 249, DateTimeKind.Local).AddTicks(3078), "192.168.8.193", false, null, null, null, "Borno", "06" },
                    { 7L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 249, DateTimeKind.Local).AddTicks(5024), "192.168.8.193", false, null, null, null, "Cross River", "07" },
                    { 8L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 249, DateTimeKind.Local).AddTicks(6958), "192.168.8.193", false, null, null, null, "FCT", "08" },
                    { 9L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 249, DateTimeKind.Local).AddTicks(8898), "192.168.8.193", false, null, null, null, "Delta", "09" },
                    { 10L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 250, DateTimeKind.Local).AddTicks(840), "192.168.8.193", false, null, null, null, "Imo", "10" },
                    { 11L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 250, DateTimeKind.Local).AddTicks(2897), "192.168.8.193", false, null, null, null, "Kaduna", "11" },
                    { 12L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 250, DateTimeKind.Local).AddTicks(5124), "192.168.8.193", false, null, null, null, "Kano", "12" },
                    { 13L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 250, DateTimeKind.Local).AddTicks(7305), "192.168.8.193", false, null, null, null, "Katsina", "13" },
                    { 14L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 250, DateTimeKind.Local).AddTicks(9451), "192.168.8.193", false, null, null, null, "Kwara", "14" },
                    { 15L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 251, DateTimeKind.Local).AddTicks(1707), "192.168.8.193", false, null, null, null, "Lagos", "15" },
                    { 16L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 251, DateTimeKind.Local).AddTicks(4245), "192.168.8.193", false, null, null, null, "Niger", "16" },
                    { 17L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 251, DateTimeKind.Local).AddTicks(6595), "192.168.8.193", false, null, null, null, "Ogun", "17" },
                    { 18L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 251, DateTimeKind.Local).AddTicks(9027), "192.168.8.193", false, null, null, null, "Ondo", "18" },
                    { 19L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 252, DateTimeKind.Local).AddTicks(1129), "192.168.8.193", false, null, null, null, "Oyo", "19" },
                    { 20L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 252, DateTimeKind.Local).AddTicks(3177), "192.168.8.193", false, null, null, null, "Plateau", "20" },
                    { 21L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 252, DateTimeKind.Local).AddTicks(5268), "192.168.8.193", false, null, null, null, "Rivers", "21" },
                    { 22L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 252, DateTimeKind.Local).AddTicks(7352), "192.168.8.193", false, null, null, null, "Sokoto", "22" },
                    { 23L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 252, DateTimeKind.Local).AddTicks(9484), "192.168.8.193", false, null, null, null, "Abia", "23" },
                    { 24L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 253, DateTimeKind.Local).AddTicks(1466), "192.168.8.193", false, null, null, null, "Edo", "24" },
                    { 25L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 253, DateTimeKind.Local).AddTicks(3400), "192.168.8.193", false, null, null, null, "Enugu", "25" },
                    { 26L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 253, DateTimeKind.Local).AddTicks(5445), "192.168.8.193", false, null, null, null, "Jigawa", "26" },
                    { 27L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 253, DateTimeKind.Local).AddTicks(7281), "192.168.8.193", false, null, null, null, "Kebbi", "27" },
                    { 28L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 253, DateTimeKind.Local).AddTicks(9218), "192.168.8.193", false, null, null, null, "Kogi", "28" },
                    { 29L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 254, DateTimeKind.Local).AddTicks(1050), "192.168.8.193", false, null, null, null, "Osun", "29" },
                    { 30L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 254, DateTimeKind.Local).AddTicks(2918), "192.168.8.193", false, null, null, null, "Taraba", "30" },
                    { 31L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 254, DateTimeKind.Local).AddTicks(4717), "192.168.8.193", false, null, null, null, "Yobe", "31" },
                    { 32L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 254, DateTimeKind.Local).AddTicks(6582), "192.168.8.193", false, null, null, null, "Bayelsa", "32" },
                    { 33L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 254, DateTimeKind.Local).AddTicks(8555), "192.168.8.193", false, null, null, null, "Ebonyi", "33" },
                    { 34L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 255, DateTimeKind.Local).AddTicks(426), "192.168.8.193", false, null, null, null, "Ekiti", "34" },
                    { 35L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 255, DateTimeKind.Local).AddTicks(2262), "192.168.8.193", false, null, null, null, "Gombe", "35" },
                    { 36L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 255, DateTimeKind.Local).AddTicks(4148), "192.168.8.193", false, null, null, null, "Nassarawa", "36" },
                    { 37L, 166L, "System", new DateTime(2024, 3, 6, 10, 30, 46, 255, DateTimeKind.Local).AddTicks(6140), "192.168.8.193", false, null, null, null, "Zamfara", "37" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ContinentId",
                table: "Products",
                column: "ContinentId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CountryId",
                table: "Products",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_StateId",
                table: "Products",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Kycs_ContinentId",
                table: "Kycs",
                column: "ContinentId");

            migrationBuilder.CreateIndex(
                name: "IX_Kycs_CountryId",
                table: "Kycs",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Kycs_StateId",
                table: "Kycs",
                column: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kycs_Continents_ContinentId",
                table: "Kycs",
                column: "ContinentId",
                principalTable: "Continents",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kycs_Countries_CountryId",
                table: "Kycs",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kycs_States_StateId",
                table: "Kycs",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Continents_ContinentId",
                table: "Products",
                column: "ContinentId",
                principalTable: "Continents",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Countries_CountryId",
                table: "Products",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_States_StateId",
                table: "Products",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kycs_Continents_ContinentId",
                table: "Kycs");

            migrationBuilder.DropForeignKey(
                name: "FK_Kycs_Countries_CountryId",
                table: "Kycs");

            migrationBuilder.DropForeignKey(
                name: "FK_Kycs_States_StateId",
                table: "Kycs");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Continents_ContinentId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Countries_CountryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_States_StateId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Continents");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropIndex(
                name: "IX_Products_ContinentId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CountryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_StateId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Kycs_ContinentId",
                table: "Kycs");

            migrationBuilder.DropIndex(
                name: "IX_Kycs_CountryId",
                table: "Kycs");

            migrationBuilder.DropIndex(
                name: "IX_Kycs_StateId",
                table: "Kycs");

            migrationBuilder.DropColumn(
                name: "ContinentId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ContinentId",
                table: "Kycs");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Kycs");

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "Kycs");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Kycs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Kycs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
