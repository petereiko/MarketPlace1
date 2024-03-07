using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarketPlace.Data.Migrations
{
    /// <inheritdoc />
    public partial class MigrationNew4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyTables",
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
                    table.PrimaryKey("PK_MyTables", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryCode", "CreatedBy", "CreatedDate", "IPAddress", "IsActive", "IsDeleted", "LastModified", "ModifiedBy", "Name", "NationalCurrency", "Nationality", "PhoneCode", "StateId", "VatRate" },
                values: new object[,]
                {
                    { 1L, "AD", "System", new DateTime(2024, 3, 7, 2, 36, 33, 899, DateTimeKind.Local).AddTicks(7936), "192.168.8.193", false, null, null, null, "ANDORRA", "EUR", "Andorran", "+376", null, null },
                    { 2L, "AE", "System", new DateTime(2024, 3, 7, 2, 36, 33, 900, DateTimeKind.Local).AddTicks(124), "192.168.8.193", false, null, null, null, "UNITED ARAB EMIRATES", "AED", "Emirati", "+967", null, 5.0m },
                    { 3L, "AF", "System", new DateTime(2024, 3, 7, 2, 36, 33, 900, DateTimeKind.Local).AddTicks(1811), "192.168.8.193", false, null, null, null, "AFGHANISTAN", "AFN", "Afgans", "+93", null, null },
                    { 4L, "AG", "System", new DateTime(2024, 3, 7, 2, 36, 33, 900, DateTimeKind.Local).AddTicks(3814), "192.168.8.193", false, null, null, null, "ANTIGUA AND BARBUDA", "XCD", null, "+809", null, null },
                    { 5L, "AI", "System", new DateTime(2024, 3, 7, 2, 36, 33, 900, DateTimeKind.Local).AddTicks(5425), "192.168.8.193", false, null, null, null, "ANGUILLA", "XCD", "Anguillan", "+809", null, null },
                    { 6L, "AL", "System", new DateTime(2024, 3, 7, 2, 36, 33, 900, DateTimeKind.Local).AddTicks(7031), "192.168.8.193", false, null, null, null, "ALBANIA", "ALL", "Albanian", "+355", null, 20.0m },
                    { 7L, "AM", "System", new DateTime(2024, 3, 7, 2, 36, 33, 900, DateTimeKind.Local).AddTicks(8623), "192.168.8.193", false, null, null, null, "ARMENIA", "AMD", "Armenians", "+374", null, 20.0m },
                    { 8L, "AN", "System", new DateTime(2024, 3, 7, 2, 36, 33, 901, DateTimeKind.Local).AddTicks(188), "192.168.8.193", false, null, null, null, "NETHERLANDS ANTILLES", "ANG", "Dutch", "+599", null, 21.0m },
                    { 9L, "AO", "System", new DateTime(2024, 3, 7, 2, 36, 33, 901, DateTimeKind.Local).AddTicks(1811), "192.168.8.193", false, null, null, null, "ANGOLA", "AOA", "Angolans", "+244", null, 14.0m },
                    { 10L, "AQ", "System", new DateTime(2024, 3, 7, 2, 36, 33, 901, DateTimeKind.Local).AddTicks(3380), "192.168.8.193", false, null, null, null, "ANTARCTICA", "N/A", null, "+672", null, null },
                    { 11L, "AR", "System", new DateTime(2024, 3, 7, 2, 36, 33, 901, DateTimeKind.Local).AddTicks(4926), "192.168.8.193", false, null, null, null, "ARGENTINA", "ARS", "Argentine", "+54", null, 21.0m },
                    { 12L, "AS", "System", new DateTime(2024, 3, 7, 2, 36, 33, 901, DateTimeKind.Local).AddTicks(6498), "192.168.8.193", false, null, null, null, "AMERICAN SAMOA", "USD", "American Samoans", "+684", null, null },
                    { 13L, "AT", "System", new DateTime(2024, 3, 7, 2, 36, 33, 901, DateTimeKind.Local).AddTicks(8083), "192.168.8.193", false, null, null, null, "AUSTRIA", "EUR", "Austrian", "+43", null, 21.0m },
                    { 14L, "AU", "System", new DateTime(2024, 3, 7, 2, 36, 33, 901, DateTimeKind.Local).AddTicks(9632), "192.168.8.193", false, null, null, null, "AUSTRALIA", "AUD", "Australian", "+61", null, 10.0m },
                    { 15L, "AW", "System", new DateTime(2024, 3, 7, 2, 36, 33, 902, DateTimeKind.Local).AddTicks(1311), "192.168.8.193", false, null, null, null, "ARUBA", "AWG", "Dutch Caribbean", "+871", null, null },
                    { 16L, "AX", "System", new DateTime(2024, 3, 7, 2, 36, 33, 902, DateTimeKind.Local).AddTicks(2844), "192.168.8.193", false, null, null, null, "ÅLAND ISLANDS", "EUR", "Finnish", "+358", null, null },
                    { 17L, "AZ", "System", new DateTime(2024, 3, 7, 2, 36, 33, 902, DateTimeKind.Local).AddTicks(4479), "192.168.8.193", false, null, null, null, "AZERBAIJAN", "AZN", "Azerbaijani", "+994", null, 18.0m },
                    { 18L, "BA", "System", new DateTime(2024, 3, 7, 2, 36, 33, 902, DateTimeKind.Local).AddTicks(5979), "192.168.8.193", false, null, null, null, "BOSNIA AND HERZEGOVINA", "BAM", "Bosnian", "+387", null, 17.0m },
                    { 19L, "BB", "System", new DateTime(2024, 3, 7, 2, 36, 33, 902, DateTimeKind.Local).AddTicks(8483), "192.168.8.193", false, null, null, null, "BARBADOS", "BBD", "Barbadians", "+246", null, 17.5m },
                    { 20L, "BD", "System", new DateTime(2024, 3, 7, 2, 36, 33, 903, DateTimeKind.Local).AddTicks(128), "192.168.8.193", false, null, null, null, "BANGLADESH", "BDT", "Bangladeshi", "+880", null, null },
                    { 21L, "BE", "System", new DateTime(2024, 3, 7, 2, 36, 33, 903, DateTimeKind.Local).AddTicks(1682), "192.168.8.193", false, null, null, null, "BELGIUM", "EUR", "Belgians", "+32", null, 21.0m },
                    { 22L, "BF", "System", new DateTime(2024, 3, 7, 2, 36, 33, 903, DateTimeKind.Local).AddTicks(3197), "192.168.8.193", false, null, null, null, "BURKINA FASO", "XOF", "Burkinabe", "+226", null, 18.0m },
                    { 23L, "BG", "System", new DateTime(2024, 3, 7, 2, 36, 33, 903, DateTimeKind.Local).AddTicks(4709), "192.168.8.193", false, null, null, null, "BULGARIA", "BGN", "Bulgarian", "+359", null, 20.0m },
                    { 24L, "BH", "System", new DateTime(2024, 3, 7, 2, 36, 33, 903, DateTimeKind.Local).AddTicks(6256), "192.168.8.193", false, null, null, null, "BAHRAIN", "BHD", "Bahraini", "+973", null, 5.0m },
                    { 25L, "BI", "System", new DateTime(2024, 3, 7, 2, 36, 33, 903, DateTimeKind.Local).AddTicks(7762), "192.168.8.193", false, null, null, null, "BURUNDI", "BIF", "Burundian", "+257", null, 18.0m },
                    { 26L, "BJ", "System", new DateTime(2024, 3, 7, 2, 36, 33, 903, DateTimeKind.Local).AddTicks(9397), "192.168.8.193", false, null, null, null, "BENIN", "XOF", "Beninese", "+229", null, 18.0m },
                    { 27L, "BL", "System", new DateTime(2024, 3, 7, 2, 36, 33, 904, DateTimeKind.Local).AddTicks(887), "192.168.8.193", false, null, null, null, "SAINT BARTHÉLEMY", "EUR", "SAINT BARTHÉLEMOIS", "+590", null, 8.5m },
                    { 28L, "BM", "System", new DateTime(2024, 3, 7, 2, 36, 33, 904, DateTimeKind.Local).AddTicks(2382), "192.168.8.193", false, null, null, null, "BERMUDA", "BMD", "Bermudian", "+809", null, null },
                    { 29L, "BN", "System", new DateTime(2024, 3, 7, 2, 36, 33, 904, DateTimeKind.Local).AddTicks(3869), "192.168.8.193", false, null, null, null, "BRUNEI DARUSSALAM", "BND", "Bruneian", "+673", null, null },
                    { 30L, "BO", "System", new DateTime(2024, 3, 7, 2, 36, 33, 904, DateTimeKind.Local).AddTicks(5419), "192.168.8.193", false, null, null, null, "BOLIVIA", "BOB", "Bolivian", "+591", null, 13.0m },
                    { 31L, "BQ", "System", new DateTime(2024, 3, 7, 2, 36, 33, 904, DateTimeKind.Local).AddTicks(6921), "192.168.8.193", false, null, null, null, "BONAIRE, SAINT EUSTATIUS AND SABA", "USD", "Not Set", "+599", null, 8.0m },
                    { 32L, "BR", "System", new DateTime(2024, 3, 7, 2, 36, 33, 904, DateTimeKind.Local).AddTicks(8447), "192.168.8.193", false, null, null, null, "BRAZIL", "BRL", "Bazillian", "+55", null, 18.0m },
                    { 33L, "BS", "System", new DateTime(2024, 3, 7, 2, 36, 33, 905, DateTimeKind.Local).AddTicks(26), "192.168.8.193", false, null, null, null, "BAHAMAS", "BSD", "Bahamian", "+809", null, 12.0m },
                    { 34L, "BT", "System", new DateTime(2024, 3, 7, 2, 36, 33, 905, DateTimeKind.Local).AddTicks(1530), "192.168.8.193", false, null, null, null, "BHUTAN", "BTN", "Bhutanese", "+975", null, 50.0m },
                    { 35L, "BV", "System", new DateTime(2024, 3, 7, 2, 36, 33, 905, DateTimeKind.Local).AddTicks(3042), "192.168.8.193", false, null, null, null, "BOUVET ISLAND", "NOK", null, "+55", null, null },
                    { 36L, "BW", "System", new DateTime(2024, 3, 7, 2, 36, 33, 905, DateTimeKind.Local).AddTicks(4537), "192.168.8.193", false, null, null, null, "BOTSWANA", "BWP", "Batswana", "+267", null, 12.0m },
                    { 37L, "BY", "System", new DateTime(2024, 3, 7, 2, 36, 33, 905, DateTimeKind.Local).AddTicks(6106), "192.168.8.193", false, null, null, null, "BELARUS", "BYR", "Belarussian", "+375", null, 20.0m },
                    { 38L, "BZ", "System", new DateTime(2024, 3, 7, 2, 36, 33, 905, DateTimeKind.Local).AddTicks(7584), "192.168.8.193", false, null, null, null, "BELIZE", "BZD", "Belizean", "+501", null, 15.0m },
                    { 39L, "CA", "System", new DateTime(2024, 3, 7, 2, 36, 33, 905, DateTimeKind.Local).AddTicks(9103), "192.168.8.193", false, null, null, null, "CANADA", "CAD", "Canadaian", "+1", null, 15.0m },
                    { 40L, "CC", "System", new DateTime(2024, 3, 7, 2, 36, 33, 906, DateTimeKind.Local).AddTicks(596), "192.168.8.193", false, null, null, null, "COCOS (KEELING) ISLANDS", "AUD", null, "+61", null, 13.5m },
                    { 41L, "CD", "System", new DateTime(2024, 3, 7, 2, 36, 33, 906, DateTimeKind.Local).AddTicks(2100), "192.168.8.193", false, null, null, null, "CONGO, THE DEMOCRATIC REPUBLIC OF THE", "CDF", "Congolese", "+243", null, 16.0m },
                    { 42L, "CF", "System", new DateTime(2024, 3, 7, 2, 36, 33, 906, DateTimeKind.Local).AddTicks(3573), "192.168.8.193", false, null, null, null, "CENTRAL AFRICAN REPUBLIC", "XAF", "Central African", "+236", null, 19.0m },
                    { 43L, "CG", "System", new DateTime(2024, 3, 7, 2, 36, 33, 906, DateTimeKind.Local).AddTicks(5050), "192.168.8.193", false, null, null, null, "CONGO", "XAF", "Congolese", "+242", null, 16.0m },
                    { 44L, "CH", "System", new DateTime(2024, 3, 7, 2, 36, 33, 906, DateTimeKind.Local).AddTicks(6558), "192.168.8.193", false, null, null, null, "SWITZERLAND", "CHF", "Swiss", "+41", null, 7.7m },
                    { 45L, "CI", "System", new DateTime(2024, 3, 7, 2, 36, 33, 906, DateTimeKind.Local).AddTicks(8046), "192.168.8.193", false, null, null, null, "COTE D'IVOIRE", "XOF", "Ivorian", "+225", null, 18.0m },
                    { 46L, "CK", "System", new DateTime(2024, 3, 7, 2, 36, 33, 906, DateTimeKind.Local).AddTicks(9550), "192.168.8.193", false, null, null, null, "COOK ISLANDS", "NZD", null, "+682", null, 15.0m },
                    { 47L, "CL", "System", new DateTime(2024, 3, 7, 2, 36, 33, 907, DateTimeKind.Local).AddTicks(1029), "192.168.8.193", false, null, null, null, "CHILE", "CLP", "Chilean", "+56", null, 19.0m },
                    { 48L, "CM", "System", new DateTime(2024, 3, 7, 2, 36, 33, 907, DateTimeKind.Local).AddTicks(2593), "192.168.8.193", false, null, null, null, "CAMEROON", "XAF", "Cameroonian", "+237", null, 19.25m },
                    { 49L, "CN", "System", new DateTime(2024, 3, 7, 2, 36, 33, 907, DateTimeKind.Local).AddTicks(4117), "192.168.8.193", false, null, null, null, "CHINA", "CNY", "Chinese", "+86", null, 13.0m },
                    { 50L, "CO", "System", new DateTime(2024, 3, 7, 2, 36, 33, 907, DateTimeKind.Local).AddTicks(5589), "192.168.8.193", false, null, null, null, "COLOMBIA", "COP", "Colombian", "+506", null, 19.0m },
                    { 51L, "CR", "System", new DateTime(2024, 3, 7, 2, 36, 33, 907, DateTimeKind.Local).AddTicks(7066), "192.168.8.193", false, null, null, null, "COSTA RICA", "CRC", "Costa Rican", "+506", null, 13.0m },
                    { 52L, "CU", "System", new DateTime(2024, 3, 7, 2, 36, 33, 907, DateTimeKind.Local).AddTicks(8610), "192.168.8.193", false, null, null, null, "CUBA", "CUP", "Cuban", "+53", null, 2.0m },
                    { 53L, "CV", "System", new DateTime(2024, 3, 7, 2, 36, 33, 908, DateTimeKind.Local).AddTicks(102), "192.168.8.193", false, null, null, null, "CAPE VERDE", "CVE", "Cape Verdean", "+238", null, 15.0m },
                    { 54L, "CW", "System", new DateTime(2024, 3, 7, 2, 36, 33, 908, DateTimeKind.Local).AddTicks(1589), "192.168.8.193", false, null, null, null, "CURACAO", "ANG", "Dutch", "+599", null, 6.0m },
                    { 55L, "CX", "System", new DateTime(2024, 3, 7, 2, 36, 33, 908, DateTimeKind.Local).AddTicks(3067), "192.168.8.193", false, null, null, null, "CHRISTMAS ISLAND", "AUD", "Christmas Islander", "+61", null, null },
                    { 56L, "CY", "System", new DateTime(2024, 3, 7, 2, 36, 33, 908, DateTimeKind.Local).AddTicks(4559), "192.168.8.193", false, null, null, null, "CYPRUS", "EUR", "Cypriot", "+357", null, 19.0m },
                    { 57L, "CZ", "System", new DateTime(2024, 3, 7, 2, 36, 33, 908, DateTimeKind.Local).AddTicks(6077), "192.168.8.193", false, null, null, null, "CZECH REPUBLIC", "CZK", "Czech", "+420", null, 21.0m },
                    { 58L, "DE", "System", new DateTime(2024, 3, 7, 2, 36, 33, 908, DateTimeKind.Local).AddTicks(7554), "192.168.8.193", false, null, null, null, "GERMANY", "EUR", "German", "+49", null, 16.0m },
                    { 59L, "DJ", "System", new DateTime(2024, 3, 7, 2, 36, 33, 908, DateTimeKind.Local).AddTicks(9177), "192.168.8.193", false, null, null, null, "DJIBOUTI", "DJF", "Djibouti", "+253", null, 10.0m },
                    { 60L, "DK", "System", new DateTime(2024, 3, 7, 2, 36, 33, 909, DateTimeKind.Local).AddTicks(658), "192.168.8.193", false, null, null, null, "DENMARK", "DKK", "Dane", "+45", null, 25.0m },
                    { 61L, "DM", "System", new DateTime(2024, 3, 7, 2, 36, 33, 909, DateTimeKind.Local).AddTicks(2137), "192.168.8.193", false, null, null, null, "DOMINICA", "XCD", "Dominican", "+767", null, 15.0m },
                    { 62L, "DO", "System", new DateTime(2024, 3, 7, 2, 36, 33, 909, DateTimeKind.Local).AddTicks(3619), "192.168.8.193", false, null, null, null, "DOMINICAN REPUBLIC", "DOP", "Dominican", "+1", null, 18.0m },
                    { 63L, "DZ", "System", new DateTime(2024, 3, 7, 2, 36, 33, 909, DateTimeKind.Local).AddTicks(5105), "192.168.8.193", false, null, null, null, "ALGERIA", "DZD", "Algerian", "+213", null, 19.0m },
                    { 64L, "EC", "System", new DateTime(2024, 3, 7, 2, 36, 33, 909, DateTimeKind.Local).AddTicks(6609), "192.168.8.193", false, null, null, null, "ECUADOR", "USD", "Ecuadorian", "+593", null, 12.0m },
                    { 65L, "EE", "System", new DateTime(2024, 3, 7, 2, 36, 33, 909, DateTimeKind.Local).AddTicks(8178), "192.168.8.193", false, null, null, null, "ESTONIA", "EUR", "Estonian", "+372", null, 20.0m },
                    { 66L, "EG", "System", new DateTime(2024, 3, 7, 2, 36, 33, 909, DateTimeKind.Local).AddTicks(9665), "192.168.8.193", false, null, null, null, "EGYPT", "EGP", "Egyptian", "+20", null, 18.0m },
                    { 67L, "EH", "System", new DateTime(2024, 3, 7, 2, 36, 33, 910, DateTimeKind.Local).AddTicks(1181), "192.168.8.193", false, null, null, null, "WESTERN SAHARA", "MAD", "Saharawi", "+212", null, null },
                    { 68L, "ER", "System", new DateTime(2024, 3, 7, 2, 36, 33, 910, DateTimeKind.Local).AddTicks(2666), "192.168.8.193", false, null, null, null, "ERITREA", "ERN", "Eritean", "+291", null, 5.0m },
                    { 69L, "ES", "System", new DateTime(2024, 3, 7, 2, 36, 33, 910, DateTimeKind.Local).AddTicks(4154), "192.168.8.193", false, null, null, null, "SPAIN", "EUR", "Spaniard", "+34", null, 21.0m },
                    { 70L, "ET", "System", new DateTime(2024, 3, 7, 2, 36, 33, 910, DateTimeKind.Local).AddTicks(5725), "192.168.8.193", false, null, null, null, "ETHIOPIA", "ETB", "Ethiopian", "+251", null, 15.0m },
                    { 71L, "FI", "System", new DateTime(2024, 3, 7, 2, 36, 33, 910, DateTimeKind.Local).AddTicks(7220), "192.168.8.193", false, null, null, null, "FINLAND", "EUR", "Finn", "+358", null, 24.0m },
                    { 72L, "FJ", "System", new DateTime(2024, 3, 7, 2, 36, 33, 910, DateTimeKind.Local).AddTicks(8709), "192.168.8.193", false, null, null, null, "FIJI", "FJD", "Fijian", "+679", null, 9.0m },
                    { 73L, "FK", "System", new DateTime(2024, 3, 7, 2, 36, 33, 911, DateTimeKind.Local).AddTicks(186), "192.168.8.193", false, null, null, null, "FALKLAND ISLANDS (MALVINAS)", "FKP", "Falkland Islander", "+500", null, 20.0m },
                    { 74L, "FM", "System", new DateTime(2024, 3, 7, 2, 36, 33, 911, DateTimeKind.Local).AddTicks(1658), "192.168.8.193", false, null, null, null, "MICRONESIA, FEDERATED STATES OF", "USD", "Micronesian", "+691", null, 5.0m },
                    { 75L, "FO", "System", new DateTime(2024, 3, 7, 2, 36, 33, 911, DateTimeKind.Local).AddTicks(3133), "192.168.8.193", false, null, null, null, "FAROE ISLANDS", "DKK", "Faroese", "+298", null, 18.0m },
                    { 76L, "FR", "System", new DateTime(2024, 3, 7, 2, 36, 33, 911, DateTimeKind.Local).AddTicks(4637), "192.168.8.193", false, null, null, null, "FRANCE", "EUR", "FrenchPerson", "+508", null, 20.0m },
                    { 77L, "FX", "System", new DateTime(2024, 3, 7, 2, 36, 33, 911, DateTimeKind.Local).AddTicks(6118), "192.168.8.193", false, null, null, null, "FRANCE, METROPOLITAN", "EUR", "FrenchPerson", "+508", null, 20.0m },
                    { 78L, "GA", "System", new DateTime(2024, 3, 7, 2, 36, 33, 911, DateTimeKind.Local).AddTicks(7652), "192.168.8.193", false, null, null, null, "GABON", "XAF", "Gabonese", "+241", null, 18.0m },
                    { 79L, "GB", "System", new DateTime(2024, 3, 7, 2, 36, 33, 911, DateTimeKind.Local).AddTicks(9204), "192.168.8.193", false, null, null, null, "UNITED KINGDOM", "GBP", "Brit", "+44", null, 20.0m },
                    { 80L, "GD", "System", new DateTime(2024, 3, 7, 2, 36, 33, 912, DateTimeKind.Local).AddTicks(711), "192.168.8.193", false, null, null, null, "GRENADA", "XCD", "Grenadian", "+473", null, 15.0m },
                    { 81L, "GE", "System", new DateTime(2024, 3, 7, 2, 36, 33, 912, DateTimeKind.Local).AddTicks(2340), "192.168.8.193", false, null, null, null, "GEORGIA", "GEL", "Georgian", "+995", null, 18.0m },
                    { 82L, "GF", "System", new DateTime(2024, 3, 7, 2, 36, 33, 912, DateTimeKind.Local).AddTicks(3869), "192.168.8.193", false, null, null, null, "FRENCH GUIANA", "EUR", null, "+594", null, 20.0m },
                    { 83L, "GG", "System", new DateTime(2024, 3, 7, 2, 36, 33, 912, DateTimeKind.Local).AddTicks(5383), "192.168.8.193", false, null, null, null, "GUERNSEY", "GBP", null, "+44", null, null },
                    { 84L, "GH", "System", new DateTime(2024, 3, 7, 2, 36, 33, 912, DateTimeKind.Local).AddTicks(6950), "192.168.8.193", false, null, null, null, "GHANA", "GHS", "Ghanaian", "+233", null, 12.5m },
                    { 85L, "GI", "System", new DateTime(2024, 3, 7, 2, 36, 33, 912, DateTimeKind.Local).AddTicks(8558), "192.168.8.193", false, null, null, null, "GIBRALTAR", "GIP", "Gibraltarian", "+350", null, null },
                    { 86L, "GL", "System", new DateTime(2024, 3, 7, 2, 36, 33, 913, DateTimeKind.Local).AddTicks(125), "192.168.8.193", false, null, null, null, "GREENLAND", "DKK", null, "+299", null, null },
                    { 87L, "GM", "System", new DateTime(2024, 3, 7, 2, 36, 33, 913, DateTimeKind.Local).AddTicks(1671), "192.168.8.193", false, null, null, null, "GAMBIA", "GMD", "Gambian", "+220", null, 15.0m },
                    { 88L, "GN", "System", new DateTime(2024, 3, 7, 2, 36, 33, 913, DateTimeKind.Local).AddTicks(3190), "192.168.8.193", false, null, null, null, "GUINEA", "GNF", "Guinean", "+224", null, 18.0m },
                    { 89L, "GP", "System", new DateTime(2024, 3, 7, 2, 36, 33, 913, DateTimeKind.Local).AddTicks(4700), "192.168.8.193", false, null, null, null, "GUADELOUPE", "EUR", null, "+590", null, 8.5m },
                    { 90L, "GQ", "System", new DateTime(2024, 3, 7, 2, 36, 33, 913, DateTimeKind.Local).AddTicks(6217), "192.168.8.193", false, null, null, null, "EQUATORIAL GUINEA", "XAF", "Equatoguinean", "+240", null, 15.0m },
                    { 91L, "GR", "System", new DateTime(2024, 3, 7, 2, 36, 33, 913, DateTimeKind.Local).AddTicks(7723), "192.168.8.193", false, null, null, null, "GREECE", "EUR", "Greek", "+30", null, 24.0m },
                    { 92L, "GS", "System", new DateTime(2024, 3, 7, 2, 36, 33, 913, DateTimeKind.Local).AddTicks(9342), "192.168.8.193", false, null, null, null, "SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS", "GBP", null, "+500", null, null },
                    { 93L, "GT", "System", new DateTime(2024, 3, 7, 2, 36, 33, 914, DateTimeKind.Local).AddTicks(840), "192.168.8.193", false, null, null, null, "GUATEMALA", "GTQ", "Guatemalan", "+502", null, 12.0m },
                    { 94L, "GU", "System", new DateTime(2024, 3, 7, 2, 36, 33, 914, DateTimeKind.Local).AddTicks(2332), "192.168.8.193", false, null, null, null, "GUAM", "USD", "Guamanian", "+671", null, 2.0m },
                    { 95L, "GW", "System", new DateTime(2024, 3, 7, 2, 36, 33, 914, DateTimeKind.Local).AddTicks(3827), "192.168.8.193", false, null, null, null, "GUINEA-BISSAU", "XOF", "Bissau Guinean", "+240", null, 15.0m },
                    { 96L, "GY", "System", new DateTime(2024, 3, 7, 2, 36, 33, 914, DateTimeKind.Local).AddTicks(5307), "192.168.8.193", false, null, null, null, "GUYANA", "GYD", "Guyanese", "+592", null, 14.0m },
                    { 97L, "HK", "System", new DateTime(2024, 3, 7, 2, 36, 33, 914, DateTimeKind.Local).AddTicks(6865), "192.168.8.193", false, null, null, null, "HONG KONG", "HKD", "Hong konger", "+852", null, null },
                    { 98L, "HM", "System", new DateTime(2024, 3, 7, 2, 36, 33, 914, DateTimeKind.Local).AddTicks(8388), "192.168.8.193", false, null, null, null, "HEARD ISLAND AND MCDONALD ISLANDS", "AUD", null, "+672", null, null },
                    { 99L, "HN", "System", new DateTime(2024, 3, 7, 2, 36, 33, 914, DateTimeKind.Local).AddTicks(9902), "192.168.8.193", false, null, null, null, "HONDURAS", "HNL", "Hondurian", "+504", null, 15.0m },
                    { 100L, "HR", "System", new DateTime(2024, 3, 7, 2, 36, 33, 915, DateTimeKind.Local).AddTicks(1415), "192.168.8.193", false, null, null, null, "CROATIA (local name: Hrvatska)", "HRK", "Croat", "+385", null, 25.0m },
                    { 101L, "HT", "System", new DateTime(2024, 3, 7, 2, 36, 33, 915, DateTimeKind.Local).AddTicks(2902), "192.168.8.193", false, null, null, null, "HAITI", "HTG ", "Haitian", "+509", null, 10.0m },
                    { 102L, "HU", "System", new DateTime(2024, 3, 7, 2, 36, 33, 915, DateTimeKind.Local).AddTicks(4421), "192.168.8.193", false, null, null, null, "HUNGARY", "HUF", "Hungarian", "+36", null, 27.0m },
                    { 103L, "ID", "System", new DateTime(2024, 3, 7, 2, 36, 33, 915, DateTimeKind.Local).AddTicks(6009), "192.168.8.193", false, null, null, null, "INDONESIA", "IDR", "Indonesian", "+62", null, 10.0m },
                    { 104L, "IE", "System", new DateTime(2024, 3, 7, 2, 36, 33, 915, DateTimeKind.Local).AddTicks(7490), "192.168.8.193", false, null, null, null, "IRELAND", "EUR", "IrishPerson", "+353", null, 23.0m },
                    { 105L, "IL", "System", new DateTime(2024, 3, 7, 2, 36, 33, 915, DateTimeKind.Local).AddTicks(9059), "192.168.8.193", false, null, null, null, "ISRAEL", "ILS", "Isreali", "+972", null, 18.0m },
                    { 106L, "IM", "System", new DateTime(2024, 3, 7, 2, 36, 33, 916, DateTimeKind.Local).AddTicks(603), "192.168.8.193", false, null, null, null, "ISLE OF MAN", "GBP", null, "+44", null, 20.0m },
                    { 107L, "IN", "System", new DateTime(2024, 3, 7, 2, 36, 33, 916, DateTimeKind.Local).AddTicks(2102), "192.168.8.193", false, null, null, null, "INDIA", "INR", "Indian", "+91", null, 5.0m },
                    { 108L, "IO", "System", new DateTime(2024, 3, 7, 2, 36, 33, 916, DateTimeKind.Local).AddTicks(3575), "192.168.8.193", false, null, null, null, "BRITISH INDIAN OCEAN TERRITORY", "USD", null, "+809", null, null },
                    { 109L, "IQ", "System", new DateTime(2024, 3, 7, 2, 36, 33, 916, DateTimeKind.Local).AddTicks(5089), "192.168.8.193", false, null, null, null, "IRAQ", "IQD", "Iraqi", "+964", null, 0.0m },
                    { 110L, "IR", "System", new DateTime(2024, 3, 7, 2, 36, 33, 916, DateTimeKind.Local).AddTicks(6588), "192.168.8.193", false, null, null, null, "IRAN, ISLAMIC REPUBLIC OF", "IRR", "Iranian", "+98", null, null },
                    { 111L, "IS", "System", new DateTime(2024, 3, 7, 2, 36, 33, 916, DateTimeKind.Local).AddTicks(8274), "192.168.8.193", false, null, null, null, "ICELAND", "ISK", "Icelandic", "+354", null, 24.0m },
                    { 112L, "IT", "System", new DateTime(2024, 3, 7, 2, 36, 33, 916, DateTimeKind.Local).AddTicks(9771), "192.168.8.193", false, null, null, null, "ITALY", "EUR", "Italian", "+295", null, 22.0m },
                    { 113L, "JE", "System", new DateTime(2024, 3, 7, 2, 36, 33, 917, DateTimeKind.Local).AddTicks(1311), "192.168.8.193", false, null, null, null, "JERSEY", "GBP", null, "+44", null, 3.0m },
                    { 114L, "JM", "System", new DateTime(2024, 3, 7, 2, 36, 33, 917, DateTimeKind.Local).AddTicks(2875), "192.168.8.193", false, null, null, null, "JAMAICA", "JMD", "Jamaican", "+876", null, 15.0m },
                    { 115L, "JO", "System", new DateTime(2024, 3, 7, 2, 36, 33, 917, DateTimeKind.Local).AddTicks(4358), "192.168.8.193", false, null, null, null, "JORDAN", "JOD", "Jordanian", "+962", null, null },
                    { 116L, "JP", "System", new DateTime(2024, 3, 7, 2, 36, 33, 917, DateTimeKind.Local).AddTicks(5832), "192.168.8.193", false, null, null, null, "JAPAN", "JPY", "Japanese", "+81", null, 8.0m },
                    { 117L, "KE", "System", new DateTime(2024, 3, 7, 2, 36, 33, 917, DateTimeKind.Local).AddTicks(7329), "192.168.8.193", false, null, null, null, "KENYA", "KES", "Kenyan", "+254", null, 16.0m },
                    { 118L, "KG", "System", new DateTime(2024, 3, 7, 2, 36, 33, 917, DateTimeKind.Local).AddTicks(8857), "192.168.8.193", false, null, null, null, "KYRGYZSTAN", "KGS", "Kyrgyz", "+996", null, 12.0m },
                    { 119L, "KH", "System", new DateTime(2024, 3, 7, 2, 36, 33, 918, DateTimeKind.Local).AddTicks(340), "192.168.8.193", false, null, null, null, "CAMBODIA", "KHR", "Cambodian", "+855", null, 10.0m },
                    { 120L, "KI", "System", new DateTime(2024, 3, 7, 2, 36, 33, 918, DateTimeKind.Local).AddTicks(1813), "192.168.8.193", false, null, null, null, "KIRIBATI", "AUD", "Kiribatian", "+686", null, 12.0m },
                    { 121L, "KM", "System", new DateTime(2024, 3, 7, 2, 36, 33, 918, DateTimeKind.Local).AddTicks(3293), "192.168.8.193", false, null, null, null, "COMOROS", "KMF", "Comorian", "+269", null, 35.0m },
                    { 122L, "KN", "System", new DateTime(2024, 3, 7, 2, 36, 33, 918, DateTimeKind.Local).AddTicks(4757), "192.168.8.193", false, null, null, null, "SAINT KITTS AND NEVIS", "XCD", "Kettitian and Nevisian", "+869", null, 17.0m },
                    { 123L, "KP", "System", new DateTime(2024, 3, 7, 2, 36, 33, 918, DateTimeKind.Local).AddTicks(6233), "192.168.8.193", false, null, null, null, "KOREA, DEMOCRATIC PEOPLE'S REPUBLIC OF", "KPW", "Korean", "+82", null, 10.0m },
                    { 124L, "KR", "System", new DateTime(2024, 3, 7, 2, 36, 33, 918, DateTimeKind.Local).AddTicks(8124), "192.168.8.193", false, null, null, null, "KOREA, REPUBLIC OF", "KRW", "Korean", "+82", null, 10.0m },
                    { 125L, "KW", "System", new DateTime(2024, 3, 7, 2, 36, 33, 919, DateTimeKind.Local).AddTicks(32), "192.168.8.193", false, null, null, null, "KUWAIT", "KWD", "Kuwaiti", "+965", null, null },
                    { 126L, "KY", "System", new DateTime(2024, 3, 7, 2, 36, 33, 919, DateTimeKind.Local).AddTicks(1562), "192.168.8.193", false, null, null, null, "CAYMAN ISLANDS", "KYD", "Caymanians", "+345", null, null },
                    { 127L, "KZ", "System", new DateTime(2024, 3, 7, 2, 36, 33, 919, DateTimeKind.Local).AddTicks(3069), "192.168.8.193", false, null, null, null, "KAZAKHSTAN", "KZT", "Kazakhs", "+7", null, 12.0m },
                    { 128L, "LA", "System", new DateTime(2024, 3, 7, 2, 36, 33, 919, DateTimeKind.Local).AddTicks(4587), "192.168.8.193", false, null, null, null, "LAO PEOPLE'S DEMOCRATIC REPUBLIC", "LAK", "Laotian", "+856", null, 10.0m },
                    { 129L, "LB", "System", new DateTime(2024, 3, 7, 2, 36, 33, 919, DateTimeKind.Local).AddTicks(6143), "192.168.8.193", false, null, null, null, "LEBANON", "LBP", "Lebanese", "+961", null, 11.0m },
                    { 130L, "LC", "System", new DateTime(2024, 3, 7, 2, 36, 33, 919, DateTimeKind.Local).AddTicks(7723), "192.168.8.193", false, null, null, null, "SAINT LUCIA", "XCD", "Saint Lucian", "+758", null, 12.5m },
                    { 131L, "LI", "System", new DateTime(2024, 3, 7, 2, 36, 33, 919, DateTimeKind.Local).AddTicks(9295), "192.168.8.193", false, null, null, null, "LIECHTENSTEIN", "CHF", "Liechtensteiner", "+41", null, 7.7m },
                    { 132L, "LK", "System", new DateTime(2024, 3, 7, 2, 36, 33, 920, DateTimeKind.Local).AddTicks(809), "192.168.8.193", false, null, null, null, "SRI LANKA", "LKR", "Sri Lankan", "+94", null, 8.0m },
                    { 133L, "LR", "System", new DateTime(2024, 3, 7, 2, 36, 33, 920, DateTimeKind.Local).AddTicks(2343), "192.168.8.193", false, null, null, null, "LIBERIA", "LRD", "Liberian", "+231", null, 10.0m },
                    { 134L, "LS", "System", new DateTime(2024, 3, 7, 2, 36, 33, 920, DateTimeKind.Local).AddTicks(3893), "192.168.8.193", false, null, null, null, "LESOTHO", "ZAR", "Basotho", "+266", null, 15.0m },
                    { 135L, "LT", "System", new DateTime(2024, 3, 7, 2, 36, 33, 920, DateTimeKind.Local).AddTicks(5411), "192.168.8.193", false, null, null, null, "LITHUANIA", "EUR", "Lithuanian", "+370", null, 21.0m },
                    { 136L, "LU", "System", new DateTime(2024, 3, 7, 2, 36, 33, 920, DateTimeKind.Local).AddTicks(7019), "192.168.8.193", false, null, null, null, "LUXEMBOURG", "EUR", "Luxembourger", "+352", null, 21.0m },
                    { 137L, "LV", "System", new DateTime(2024, 3, 7, 2, 36, 33, 920, DateTimeKind.Local).AddTicks(8578), "192.168.8.193", false, null, null, null, "LATVIA", "EUR", "Latvian", "+371", null, null },
                    { 138L, "LY", "System", new DateTime(2024, 3, 7, 2, 36, 33, 921, DateTimeKind.Local).AddTicks(82), "192.168.8.193", false, null, null, null, "LIBYAN ARAB JAMAHIRIYA", "LYD", "Libyan", "+218", null, null },
                    { 139L, "MA", "System", new DateTime(2024, 3, 7, 2, 36, 33, 921, DateTimeKind.Local).AddTicks(1656), "192.168.8.193", false, null, null, null, "MOROCCO", "MAD", "Moroccan", "+212", null, 20.0m },
                    { 140L, "MC", "System", new DateTime(2024, 3, 7, 2, 36, 33, 921, DateTimeKind.Local).AddTicks(3168), "192.168.8.193", false, null, null, null, "MONACO", "EUR", "Monegasque", "+377", null, 20.0m },
                    { 141L, "MD", "System", new DateTime(2024, 3, 7, 2, 36, 33, 921, DateTimeKind.Local).AddTicks(4690), "192.168.8.193", false, null, null, null, "MOLDOVA", "MDL", "Moldovan", "+373", null, 20.0m },
                    { 142L, "ME", "System", new DateTime(2024, 3, 7, 2, 36, 33, 921, DateTimeKind.Local).AddTicks(6227), "192.168.8.193", false, null, null, null, "MONTENEGRO", "EUR", "Montenegrin", "+382", null, 21.0m },
                    { 143L, "MF", "System", new DateTime(2024, 3, 7, 2, 36, 33, 921, DateTimeKind.Local).AddTicks(7778), "192.168.8.193", false, null, null, null, "SAINT MARTIN (FRENCH PART)", "EUR", null, "+599", null, null },
                    { 144L, "MG", "System", new DateTime(2024, 3, 7, 2, 36, 33, 921, DateTimeKind.Local).AddTicks(9297), "192.168.8.193", false, null, null, null, "MADAGASCAR", "MGA", "Malagasy", "+261", null, 20.0m },
                    { 145L, "MH", "System", new DateTime(2024, 3, 7, 2, 36, 33, 922, DateTimeKind.Local).AddTicks(875), "192.168.8.193", false, null, null, null, "MARSHALL ISLANDS", "USD", "Marshallese", "+692", null, null },
                    { 146L, "MK", "System", new DateTime(2024, 3, 7, 2, 36, 33, 922, DateTimeKind.Local).AddTicks(2414), "192.168.8.193", false, null, null, null, "MACEDONIA, THE FORMER YUGOSLAV REP. OF", "MKD", "Macedonians", "+389", null, 18.0m },
                    { 147L, "ML", "System", new DateTime(2024, 3, 7, 2, 36, 33, 922, DateTimeKind.Local).AddTicks(3990), "192.168.8.193", false, null, null, null, "MALI", "XOF", "Malian", "+223", null, 20.0m },
                    { 148L, "MM", "System", new DateTime(2024, 3, 7, 2, 36, 33, 922, DateTimeKind.Local).AddTicks(5488), "192.168.8.193", false, null, null, null, "MYANMAR", "MMK", "Burmese", "+95", null, 5.0m },
                    { 149L, "MN", "System", new DateTime(2024, 3, 7, 2, 36, 33, 922, DateTimeKind.Local).AddTicks(6965), "192.168.8.193", false, null, null, null, "MONGOLIA", "MNT", "Mongolian", "+976", null, 5.0m },
                    { 150L, "MO", "System", new DateTime(2024, 3, 7, 2, 36, 33, 922, DateTimeKind.Local).AddTicks(8456), "192.168.8.193", false, null, null, null, "MACAO", "MOP", "Macanese", "+853", null, null },
                    { 151L, "MP", "System", new DateTime(2024, 3, 7, 2, 36, 33, 922, DateTimeKind.Local).AddTicks(9952), "192.168.8.193", false, null, null, null, "NORTHERN MARIANA ISLANDS", "USD", null, "+670", null, null },
                    { 152L, "MQ", "System", new DateTime(2024, 3, 7, 2, 36, 33, 923, DateTimeKind.Local).AddTicks(1430), "192.168.8.193", false, null, null, null, "MARTINIQUE", "EUR", "Martiniquais", "+597", null, null },
                    { 153L, "MR", "System", new DateTime(2024, 3, 7, 2, 36, 33, 923, DateTimeKind.Local).AddTicks(2915), "192.168.8.193", false, null, null, null, "MAURITANIA", "MRO", "Mauritanian", "+222", null, 5.0m },
                    { 154L, "MS", "System", new DateTime(2024, 3, 7, 2, 36, 33, 923, DateTimeKind.Local).AddTicks(4426), "192.168.8.193", false, null, null, null, "MONTSERRAT", "XCD", "Montserratian", "+1", null, null },
                    { 155L, "MT", "System", new DateTime(2024, 3, 7, 2, 36, 33, 923, DateTimeKind.Local).AddTicks(5907), "192.168.8.193", false, null, null, null, "MALTA", "EUR", "Maltese", "+356", null, 18.0m },
                    { 156L, "MU", "System", new DateTime(2024, 3, 7, 2, 36, 33, 923, DateTimeKind.Local).AddTicks(7387), "192.168.8.193", false, null, null, null, "MAURITIUS", "MUR", "Mauritian", "+230", null, 15.0m },
                    { 157L, "MV", "System", new DateTime(2024, 3, 7, 2, 36, 33, 923, DateTimeKind.Local).AddTicks(8891), "192.168.8.193", false, null, null, null, "MALDIVES", "MVR", "Maldivian", "+960", null, 6.0m },
                    { 158L, "MW", "System", new DateTime(2024, 3, 7, 2, 36, 33, 924, DateTimeKind.Local).AddTicks(438), "192.168.8.193", false, null, null, null, "MALAWI", "MWK", "Malawian", "+265", null, 16.5m },
                    { 159L, "MX", "System", new DateTime(2024, 3, 7, 2, 36, 33, 924, DateTimeKind.Local).AddTicks(1912), "192.168.8.193", false, null, null, null, "MEXICO", "MXN", "Mexican", "+52", null, 16.0m },
                    { 160L, "MY", "System", new DateTime(2024, 3, 7, 2, 36, 33, 924, DateTimeKind.Local).AddTicks(3408), "192.168.8.193", false, null, null, null, "MALAYSIA", "MYR", "Malasian", "+60", null, 6.0m },
                    { 161L, "MZ", "System", new DateTime(2024, 3, 7, 2, 36, 33, 924, DateTimeKind.Local).AddTicks(4937), "192.168.8.193", false, null, null, null, "MOZAMBIQUE", "MZN", "Mozambican", "+258", null, 17.0m },
                    { 162L, "NA", "System", new DateTime(2024, 3, 7, 2, 36, 33, 924, DateTimeKind.Local).AddTicks(6455), "192.168.8.193", false, null, null, null, "NAMIBIA", "ZAR", "Namibian", "+264", null, 15.0m },
                    { 163L, "NC", "System", new DateTime(2024, 3, 7, 2, 36, 33, 924, DateTimeKind.Local).AddTicks(7967), "192.168.8.193", false, null, null, null, "NEW CALEDONIA", "XPF", "New Caledonian", "+687", null, 4.0m },
                    { 164L, "NE", "System", new DateTime(2024, 3, 7, 2, 36, 33, 924, DateTimeKind.Local).AddTicks(9455), "192.168.8.193", false, null, null, null, "NIGER", "XOF", "Nigerien", "+227", null, 7.5m },
                    { 165L, "NF", "System", new DateTime(2024, 3, 7, 2, 36, 33, 925, DateTimeKind.Local).AddTicks(947), "192.168.8.193", false, null, null, null, "NORFOLK ISLAND", "AUD", "Norfolk Islander", "+672", null, null },
                    { 166L, "NG", "System", new DateTime(2024, 3, 7, 2, 36, 33, 925, DateTimeKind.Local).AddTicks(2426), "192.168.8.193", false, null, null, null, "NIGERIA", "NGN", "Nigerian", "+234", null, 7.5m },
                    { 167L, "NI", "System", new DateTime(2024, 3, 7, 2, 36, 33, 925, DateTimeKind.Local).AddTicks(3897), "192.168.8.193", false, null, null, null, "NICARAGUA", "NIO", "Nicaraguan", "+505", null, 15.0m },
                    { 168L, "NL", "System", new DateTime(2024, 3, 7, 2, 36, 33, 925, DateTimeKind.Local).AddTicks(5405), "192.168.8.193", false, null, null, null, "NETHERLANDS", "EUR", "Dutch Person", "+31", null, 21.0m },
                    { 169L, "NO", "System", new DateTime(2024, 3, 7, 2, 36, 33, 925, DateTimeKind.Local).AddTicks(6952), "192.168.8.193", false, null, null, null, "NORWAY", "NOK", "Norwegian", "+47", null, 25.0m },
                    { 170L, "NP", "System", new DateTime(2024, 3, 7, 2, 36, 33, 925, DateTimeKind.Local).AddTicks(8455), "192.168.8.193", false, null, null, null, "NEPAL", "NPR", "Nepalese", "+977", null, 13.0m },
                    { 171L, "NR", "System", new DateTime(2024, 3, 7, 2, 36, 33, 925, DateTimeKind.Local).AddTicks(9958), "192.168.8.193", false, null, null, null, "NAURU", "AUD", "Nauruan", "+674", null, 5.0m },
                    { 172L, "NU", "System", new DateTime(2024, 3, 7, 2, 36, 33, 926, DateTimeKind.Local).AddTicks(1434), "192.168.8.193", false, null, null, null, "NIUE", "NZD", "Niueans", "+683", null, 5.0m },
                    { 173L, "NZ", "System", new DateTime(2024, 3, 7, 2, 36, 33, 926, DateTimeKind.Local).AddTicks(2902), "192.168.8.193", false, null, null, null, "NEW ZEALAND", "NZD", "New Zealander", "+64", null, 13.0m },
                    { 174L, "OM", "System", new DateTime(2024, 3, 7, 2, 36, 33, 926, DateTimeKind.Local).AddTicks(4385), "192.168.8.193", false, null, null, null, "OMAN", "OMR", "Omani", "+968", null, 5.0m },
                    { 175L, "PA", "System", new DateTime(2024, 3, 7, 2, 36, 33, 926, DateTimeKind.Local).AddTicks(5863), "192.168.8.193", false, null, null, null, "PANAMA", "PAB", "Panamanian", "+507", null, 7.0m },
                    { 176L, "PE", "System", new DateTime(2024, 3, 7, 2, 36, 33, 926, DateTimeKind.Local).AddTicks(7342), "192.168.8.193", false, null, null, null, "PERU", "PEN", "Peruvian", "+51", null, 18.0m },
                    { 177L, "PF", "System", new DateTime(2024, 3, 7, 2, 36, 33, 926, DateTimeKind.Local).AddTicks(8892), "192.168.8.193", false, null, null, null, "FRENCH POLYNESIA", "XPF", "Polynesian", "+689", null, 16.0m },
                    { 178L, "PG", "System", new DateTime(2024, 3, 7, 2, 36, 33, 927, DateTimeKind.Local).AddTicks(376), "192.168.8.193", false, null, null, null, "PAPUA NEW GUINEA", "PGK", null, "+675", null, 0.0m },
                    { 179L, "PH", "System", new DateTime(2024, 3, 7, 2, 36, 33, 927, DateTimeKind.Local).AddTicks(1856), "192.168.8.193", false, null, null, null, "PHILIPPINES", "PHP", "Filipino", "+63", null, 12.0m },
                    { 180L, "PK", "System", new DateTime(2024, 3, 7, 2, 36, 33, 927, DateTimeKind.Local).AddTicks(3405), "192.168.8.193", false, null, null, null, "PAKISTAN", "PKR", "Pakistani", "+92", null, 17.0m },
                    { 181L, "PL", "System", new DateTime(2024, 3, 7, 2, 36, 33, 927, DateTimeKind.Local).AddTicks(4877), "192.168.8.193", false, null, null, null, "POLAND", "PLN", "Pole", "+48", null, 23.0m },
                    { 182L, "PM", "System", new DateTime(2024, 3, 7, 2, 36, 33, 927, DateTimeKind.Local).AddTicks(6349), "192.168.8.193", false, null, null, null, "ST. PIERRE AND MIQUELON", "EUR", null, "+508", null, 20.0m },
                    { 183L, "PN", "System", new DateTime(2024, 3, 7, 2, 36, 33, 927, DateTimeKind.Local).AddTicks(7856), "192.168.8.193", false, null, null, null, "PITCAIRN", "NZD", null, "+64", null, 15.25m },
                    { 184L, "PR", "System", new DateTime(2024, 3, 7, 2, 36, 33, 927, DateTimeKind.Local).AddTicks(9339), "192.168.8.193", false, null, null, null, "PUERTO RICO", "USD", "Puerto Rican", "+1", null, 10.5m },
                    { 185L, "PS", "System", new DateTime(2024, 3, 7, 2, 36, 33, 928, DateTimeKind.Local).AddTicks(816), "192.168.8.193", false, null, null, null, "PALESTINIAN TERRITORY, OCCUPIED", "ILS", "Palestinian", "+970", null, 16.0m },
                    { 186L, "PT", "System", new DateTime(2024, 3, 7, 2, 36, 33, 928, DateTimeKind.Local).AddTicks(2349), "192.168.8.193", false, null, null, null, "PORTUGAL", "EUR", "Portugese", "+351", null, 23.0m },
                    { 187L, "PW", "System", new DateTime(2024, 3, 7, 2, 36, 33, 928, DateTimeKind.Local).AddTicks(3823), "192.168.8.193", false, null, null, null, "PALAU", "USD", null, "+680", null, 7.5m },
                    { 188L, "PY", "System", new DateTime(2024, 3, 7, 2, 36, 33, 928, DateTimeKind.Local).AddTicks(5319), "192.168.8.193", false, null, null, null, "PARAGUAY", "PYG", "Paraguayan", "+595", null, 10.0m },
                    { 189L, "QA", "System", new DateTime(2024, 3, 7, 2, 36, 33, 928, DateTimeKind.Local).AddTicks(6811), "192.168.8.193", false, null, null, null, "QATAR", "QAR", "Qatari", "+974", null, 5.0m },
                    { 190L, "RE", "System", new DateTime(2024, 3, 7, 2, 36, 33, 928, DateTimeKind.Local).AddTicks(8378), "192.168.8.193", false, null, null, null, "REUNION", "EUR", null, "+262", null, 8.5m },
                    { 191L, "RO", "System", new DateTime(2024, 3, 7, 2, 36, 33, 928, DateTimeKind.Local).AddTicks(9979), "192.168.8.193", false, null, null, null, "ROMANIA", "RON", "Romanian", "+40", null, 19.0m },
                    { 192L, "RS", "System", new DateTime(2024, 3, 7, 2, 36, 33, 929, DateTimeKind.Local).AddTicks(1538), "192.168.8.193", false, null, null, null, "SERBIA", "RSD", "Serbian", "+381", null, 20.0m },
                    { 193L, "RU", "System", new DateTime(2024, 3, 7, 2, 36, 33, 929, DateTimeKind.Local).AddTicks(3119), "192.168.8.193", false, null, null, null, "RUSSIAN FEDERATION", "RUB", "Russian", "+7", null, 20.0m },
                    { 194L, "RW", "System", new DateTime(2024, 3, 7, 2, 36, 33, 929, DateTimeKind.Local).AddTicks(4713), "192.168.8.193", false, null, null, null, "RWANDA", "RWF", "Not Set", "+250", null, 18.0m },
                    { 195L, "SA", "System", new DateTime(2024, 3, 7, 2, 36, 33, 929, DateTimeKind.Local).AddTicks(6288), "192.168.8.193", false, null, null, null, "SAUDI ARABIA", "SAR", "Saudi Arabian", "+966", null, 15.0m },
                    { 196L, "SB", "System", new DateTime(2024, 3, 7, 2, 36, 33, 929, DateTimeKind.Local).AddTicks(7858), "192.168.8.193", false, null, null, null, "SOLOMON ISLANDS", "SBD", "Not Set", "+677", null, 10.0m },
                    { 197L, "SC", "System", new DateTime(2024, 3, 7, 2, 36, 33, 929, DateTimeKind.Local).AddTicks(9388), "192.168.8.193", false, null, null, null, "SEYCHELLES", "SCR", "Not Set", "+677", null, 15.0m },
                    { 198L, "SD", "System", new DateTime(2024, 3, 7, 2, 36, 33, 930, DateTimeKind.Local).AddTicks(909), "192.168.8.193", false, null, null, null, "SUDAN", "SDG", "Sudanese", "+249", null, 17.0m },
                    { 199L, "SE", "System", new DateTime(2024, 3, 7, 2, 36, 33, 930, DateTimeKind.Local).AddTicks(2407), "192.168.8.193", false, null, null, null, "SWEDEN", "SEK", "Swede", "+46", null, 25.0m },
                    { 200L, "SG", "System", new DateTime(2024, 3, 7, 2, 36, 33, 930, DateTimeKind.Local).AddTicks(3899), "192.168.8.193", false, null, null, null, "SINGAPORE", "SGD", "Singaporean", "+65", null, 7.0m },
                    { 201L, "SH", "System", new DateTime(2024, 3, 7, 2, 36, 33, 930, DateTimeKind.Local).AddTicks(5401), "192.168.8.193", false, null, null, null, "ST. HELENA, ASCENSION AND TRISTAN DA CUNHA", "SHP", null, "+290", null, null },
                    { 202L, "SI", "System", new DateTime(2024, 3, 7, 2, 36, 33, 930, DateTimeKind.Local).AddTicks(6956), "192.168.8.193", false, null, null, null, "SLOVENIA", "EUR", "slovanian", "+386", null, 22.0m },
                    { 203L, "SJ", "System", new DateTime(2024, 3, 7, 2, 36, 33, 930, DateTimeKind.Local).AddTicks(8481), "192.168.8.193", false, null, null, null, "SVALBARD AND JAN MAYEN", "NOK", null, "+47", null, 25.0m },
                    { 204L, "SK", "System", new DateTime(2024, 3, 7, 2, 36, 33, 930, DateTimeKind.Local).AddTicks(9975), "192.168.8.193", false, null, null, null, "SLOVAKIA (Slovak Republic)", "EUR", "Slovak", "+421", null, 20.0m },
                    { 205L, "SL", "System", new DateTime(2024, 3, 7, 2, 36, 33, 931, DateTimeKind.Local).AddTicks(1461), "192.168.8.193", false, null, null, null, "SIERRA LEONE", "SLL", "Sierra leonean", "+232", null, 15.0m },
                    { 206L, "SM", "System", new DateTime(2024, 3, 7, 2, 36, 33, 931, DateTimeKind.Local).AddTicks(2964), "192.168.8.193", false, null, null, null, "SAN MARINO", "EUR", "Sammarinese", "+378", null, 17.0m },
                    { 207L, "SN", "System", new DateTime(2024, 3, 7, 2, 36, 33, 931, DateTimeKind.Local).AddTicks(4459), "192.168.8.193", false, null, null, null, "SENEGAL", "XOF", "Senegalese", "+221", null, 18.0m },
                    { 208L, "SO", "System", new DateTime(2024, 3, 7, 2, 36, 33, 931, DateTimeKind.Local).AddTicks(5953), "192.168.8.193", false, null, null, null, "SOMALIA", "SOS", "Somali", "+252", null, 10.0m },
                    { 209L, "SR", "System", new DateTime(2024, 3, 7, 2, 36, 33, 931, DateTimeKind.Local).AddTicks(7608), "192.168.8.193", false, null, null, null, "SURINAME", "SRD", null, "+597", null, 10.0m },
                    { 210L, "SS", "System", new DateTime(2024, 3, 7, 2, 36, 33, 931, DateTimeKind.Local).AddTicks(9132), "192.168.8.193", false, null, null, null, "SOUTH SUDAN", "SSP", "Sudanese", "+211", null, 15.0m },
                    { 211L, "ST", "System", new DateTime(2024, 3, 7, 2, 36, 33, 932, DateTimeKind.Local).AddTicks(615), "192.168.8.193", false, null, null, null, "SAO TOME AND PRINCIPE", "STD", "Sao Tomean", "+239", null, 15.0m },
                    { 212L, "SV", "System", new DateTime(2024, 3, 7, 2, 36, 33, 932, DateTimeKind.Local).AddTicks(2087), "192.168.8.193", false, null, null, null, "EL SALVADOR", "USD", "Salvadorean", "+503", null, 13.0m },
                    { 213L, "SX", "System", new DateTime(2024, 3, 7, 2, 36, 33, 932, DateTimeKind.Local).AddTicks(3630), "192.168.8.193", false, null, null, null, "SINT MAARTEN (DUTCH PART)", "ANG", null, "+599", null, 5.0m },
                    { 214L, "SY", "System", new DateTime(2024, 3, 7, 2, 36, 33, 932, DateTimeKind.Local).AddTicks(5105), "192.168.8.193", false, null, null, null, "SYRIAN ARAB REPUBLIC", "SYP", "Syrian", "+963", null, 40.0m },
                    { 215L, "SZ", "System", new DateTime(2024, 3, 7, 2, 36, 33, 932, DateTimeKind.Local).AddTicks(6589), "192.168.8.193", false, null, null, null, "SWAZILAND", "SZL", "Swazi", "+268", null, 14.5m },
                    { 216L, "TC", "System", new DateTime(2024, 3, 7, 2, 36, 33, 932, DateTimeKind.Local).AddTicks(8086), "192.168.8.193", false, null, null, null, "TURKS AND CAICOS ISLANDS", "USD", "Belongers", "+1", null, 37.5m },
                    { 217L, "TD", "System", new DateTime(2024, 3, 7, 2, 36, 33, 932, DateTimeKind.Local).AddTicks(9554), "192.168.8.193", false, null, null, null, "CHAD", "XAF", "Chadian", "+235", null, 18.0m },
                    { 218L, "TF", "System", new DateTime(2024, 3, 7, 2, 36, 33, 933, DateTimeKind.Local).AddTicks(1037), "192.168.8.193", false, null, null, null, "FRENCH SOUTHERN TERRITORIES", "EUR", "Not Set", "+262", null, null },
                    { 219L, "TG", "System", new DateTime(2024, 3, 7, 2, 36, 33, 933, DateTimeKind.Local).AddTicks(2523), "192.168.8.193", false, null, null, null, "TOGO", "XOF", "Togolese", "+228", null, 18.0m },
                    { 220L, "TH", "System", new DateTime(2024, 3, 7, 2, 36, 33, 933, DateTimeKind.Local).AddTicks(4006), "192.168.8.193", false, null, null, null, "THAILAND", "THB", "Thai", "+66", null, 7.0m },
                    { 221L, "TJ", "System", new DateTime(2024, 3, 7, 2, 36, 33, 933, DateTimeKind.Local).AddTicks(5481), "192.168.8.193", false, null, null, null, "TAJIKISTAN", "TJS", "Tajikistani", "+7", null, 18.0m },
                    { 222L, "TK", "System", new DateTime(2024, 3, 7, 2, 36, 33, 933, DateTimeKind.Local).AddTicks(6954), "192.168.8.193", false, null, null, null, "TOKELAU", "NZD", "Tokelau", "+690", null, 0.0m },
                    { 223L, "TL", "System", new DateTime(2024, 3, 7, 2, 36, 33, 933, DateTimeKind.Local).AddTicks(8455), "192.168.8.193", false, null, null, null, "TIMOR-LESTE", "USD", "portuguese", "+670", null, 10.0m },
                    { 224L, "TM", "System", new DateTime(2024, 3, 7, 2, 36, 33, 934, DateTimeKind.Local).AddTicks(20), "192.168.8.193", false, null, null, null, "TURKMENISTAN", "TMT", "Turkmen", "+993", null, 15.0m },
                    { 225L, "TN", "System", new DateTime(2024, 3, 7, 2, 36, 33, 934, DateTimeKind.Local).AddTicks(1528), "192.168.8.193", false, null, null, null, "TUNISIA", "TND", "Tunisian", "+216", null, 19.0m },
                    { 226L, "TO", "System", new DateTime(2024, 3, 7, 2, 36, 33, 934, DateTimeKind.Local).AddTicks(3017), "192.168.8.193", false, null, null, null, "TONGA", "TOP", "Tongan", "+676", null, 15.0m },
                    { 227L, "TR", "System", new DateTime(2024, 3, 7, 2, 36, 33, 934, DateTimeKind.Local).AddTicks(4535), "192.168.8.193", false, null, null, null, "TURKEY", "TRY", "Turk", "+90", null, 18.0m },
                    { 228L, "TT", "System", new DateTime(2024, 3, 7, 2, 36, 33, 934, DateTimeKind.Local).AddTicks(6017), "192.168.8.193", false, null, null, null, "TRINIDAD AND TOBAGO", "TTD", "Trinidian", "+868", null, 12.5m },
                    { 229L, "TV", "System", new DateTime(2024, 3, 7, 2, 36, 33, 934, DateTimeKind.Local).AddTicks(7748), "192.168.8.193", false, null, null, null, "TUVALU", "AUD", null, "+688", null, 5.0m },
                    { 230L, "TW", "System", new DateTime(2024, 3, 7, 2, 36, 33, 934, DateTimeKind.Local).AddTicks(9332), "192.168.8.193", false, null, null, null, "TAIWAN, PROVINCE OF CHINA", "TWD", "Taiwanese", "+86", null, null },
                    { 231L, "TZ", "System", new DateTime(2024, 3, 7, 2, 36, 33, 935, DateTimeKind.Local).AddTicks(858), "192.168.8.193", false, null, null, null, "TANZANIA, UNITED REPUBLIC", "TZS", "Tanzanian", "+255", null, 18.0m },
                    { 232L, "UA", "System", new DateTime(2024, 3, 7, 2, 36, 33, 935, DateTimeKind.Local).AddTicks(2364), "192.168.8.193", false, null, null, null, "UKRAINE", "UAH", "Ukranian", "+380", null, 20.0m },
                    { 233L, "UG", "System", new DateTime(2024, 3, 7, 2, 36, 33, 935, DateTimeKind.Local).AddTicks(3876), "192.168.8.193", false, null, null, null, "UGANDA", "UGX", "Ugandan", "+256", null, 18.0m },
                    { 234L, "UM", "System", new DateTime(2024, 3, 7, 2, 36, 33, 935, DateTimeKind.Local).AddTicks(5366), "192.168.8.193", false, null, null, null, "UNITED STATES MINOR OUTLYING ISLANDS", "USD", "American", "+1", null, null },
                    { 235L, "US", "System", new DateTime(2024, 3, 7, 2, 36, 33, 935, DateTimeKind.Local).AddTicks(6944), "192.168.8.193", false, null, null, null, "UNITED STATES", "USD", "American", "+1", null, null },
                    { 236L, "UY", "System", new DateTime(2024, 3, 7, 2, 36, 33, 935, DateTimeKind.Local).AddTicks(8467), "192.168.8.193", false, null, null, null, "URUGUAY", "UYU", "Uruguayan", "+598", null, 22.0m },
                    { 237L, "UZ", "System", new DateTime(2024, 3, 7, 2, 36, 33, 935, DateTimeKind.Local).AddTicks(9968), "192.168.8.193", false, null, null, null, "UZBEKISTAN", "UZS", "Uzbek", "+7", null, 14.0m },
                    { 238L, "VA", "System", new DateTime(2024, 3, 7, 2, 36, 33, 936, DateTimeKind.Local).AddTicks(1447), "192.168.8.193", false, null, null, null, "HOLY SEE (VATICAN CITY STATE)", "EUR", null, "+379", null, null },
                    { 239L, "VC", "System", new DateTime(2024, 3, 7, 2, 36, 33, 936, DateTimeKind.Local).AddTicks(2935), "192.168.8.193", false, null, null, null, "SAINT VINCENT AND THE GRENADINES", "XCD", null, "+784", null, 14.0m },
                    { 240L, "VE", "System", new DateTime(2024, 3, 7, 2, 36, 33, 936, DateTimeKind.Local).AddTicks(4421), "192.168.8.193", false, null, null, null, "VENEZUELA, BOLIVARIAN REPUBLIC", "VEF", "Venezualan", "+58", null, 10.0m },
                    { 241L, "VG", "System", new DateTime(2024, 3, 7, 2, 36, 33, 936, DateTimeKind.Local).AddTicks(5944), "192.168.8.193", false, null, null, null, "VIRGIN ISLANDS (BRITISH)", "USD", "Virgin islander", "+1", null, null },
                    { 242L, "VI", "System", new DateTime(2024, 3, 7, 2, 36, 33, 936, DateTimeKind.Local).AddTicks(7469), "192.168.8.193", false, null, null, null, "VIRGIN ISLANDS (U.S.)", "USD", "Virgin islander", "+1", null, null },
                    { 243L, "VN", "System", new DateTime(2024, 3, 7, 2, 36, 33, 936, DateTimeKind.Local).AddTicks(9015), "192.168.8.193", false, null, null, null, "VIETNAM", "VND", "Vietnamese", "+84", null, 10.0m },
                    { 244L, "VU", "System", new DateTime(2024, 3, 7, 2, 36, 33, 937, DateTimeKind.Local).AddTicks(622), "192.168.8.193", false, null, null, null, "VANUATU", "VUV", "Ni-Vanatu", "+678", null, 12.5m },
                    { 245L, "WF", "System", new DateTime(2024, 3, 7, 2, 36, 33, 937, DateTimeKind.Local).AddTicks(2156), "192.168.8.193", false, null, null, null, "WALLIS AND FUTUNA", "XPF", "Wallisian and Futunan", "+681", null, 6.0m },
                    { 246L, "WS", "System", new DateTime(2024, 3, 7, 2, 36, 33, 937, DateTimeKind.Local).AddTicks(3739), "192.168.8.193", false, null, null, null, "SAMOA", "WST", "Samoan", "+684", null, 15.0m },
                    { 247L, "YE", "System", new DateTime(2024, 3, 7, 2, 36, 33, 937, DateTimeKind.Local).AddTicks(5243), "192.168.8.193", false, null, null, null, "YEMEN", "YER", "Yemenis", "+967", null, 5.0m },
                    { 248L, "YT", "System", new DateTime(2024, 3, 7, 2, 36, 33, 937, DateTimeKind.Local).AddTicks(6741), "192.168.8.193", false, null, null, null, "MAYOTTE", "EUR", null, "+262", null, null },
                    { 249L, "ZA", "System", new DateTime(2024, 3, 7, 2, 36, 33, 937, DateTimeKind.Local).AddTicks(8238), "192.168.8.193", false, null, null, null, "SOUTH AFRICA", "ZAR", "South African", "+27", null, 15.0m },
                    { 250L, "ZM", "System", new DateTime(2024, 3, 7, 2, 36, 33, 937, DateTimeKind.Local).AddTicks(9660), "192.168.8.193", false, null, null, null, "ZAMBIA", "ZMW", "Zambian", "+260", null, 16.0m },
                    { 251L, "ZW", "System", new DateTime(2024, 3, 7, 2, 36, 33, 938, DateTimeKind.Local).AddTicks(1100), "192.168.8.193", false, null, null, null, "ZIMBABWE", "ZWL", "Zimbabwean", "+263", null, 14.5m }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IPAddress", "IsActive", "IsDeleted", "LastModified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 946, DateTimeKind.Local).AddTicks(3603), "192.168.8.193", false, null, null, null, "Edible" },
                    { 2L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 946, DateTimeKind.Local).AddTicks(5149), "192.168.8.193", false, null, null, null, "Mechanical" },
                    { 3L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 946, DateTimeKind.Local).AddTicks(6633), "192.168.8.193", false, null, null, null, "Electrical" },
                    { 4L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 946, DateTimeKind.Local).AddTicks(8309), "192.168.8.193", false, null, null, null, "Wooden" },
                    { 5L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 946, DateTimeKind.Local).AddTicks(9756), "192.168.8.193", false, null, null, null, "Ceramic" }
                });

            migrationBuilder.InsertData(
                table: "ProductConditions",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IPAddress", "IsActive", "IsDeleted", "LastModified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 945, DateTimeKind.Local).AddTicks(7428), "192.168.8.193", false, null, null, null, "Brand New" },
                    { 2L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 945, DateTimeKind.Local).AddTicks(8981), "192.168.8.193", false, null, null, null, "Foreign Use" },
                    { 3L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 946, DateTimeKind.Local).AddTicks(498), "192.168.8.193", false, null, null, null, "Fairly Used" },
                    { 4L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 946, DateTimeKind.Local).AddTicks(2011), "192.168.8.193", false, null, null, null, "Really Used" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IPAddress", "IsActive", "IsDeleted", "LastModified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 943, DateTimeKind.Local).AddTicks(6928), "192.168.8.193", false, null, null, null, "Vehicles" },
                    { 2L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 943, DateTimeKind.Local).AddTicks(8451), "192.168.8.193", false, null, null, null, "Properties" },
                    { 3L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 943, DateTimeKind.Local).AddTicks(9891), "192.168.8.193", false, null, null, null, "Mobile Gadgets" },
                    { 4L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 944, DateTimeKind.Local).AddTicks(1344), "192.168.8.193", false, null, null, null, "Electronics" },
                    { 5L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 944, DateTimeKind.Local).AddTicks(2767), "192.168.8.193", false, null, null, null, "Home Appliances" },
                    { 6L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 944, DateTimeKind.Local).AddTicks(4189), "192.168.8.193", false, null, null, null, "Cosmetics/Beauty" },
                    { 7L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 944, DateTimeKind.Local).AddTicks(5626), "192.168.8.193", false, null, null, null, "Fashion" },
                    { 8L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 944, DateTimeKind.Local).AddTicks(7083), "192.168.8.193", false, null, null, null, "Sports" },
                    { 9L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 944, DateTimeKind.Local).AddTicks(8508), "192.168.8.193", false, null, null, null, "Outdoor Equipment" },
                    { 10L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 944, DateTimeKind.Local).AddTicks(9932), "192.168.8.193", false, null, null, null, "Jobs" },
                    { 11L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 945, DateTimeKind.Local).AddTicks(1345), "192.168.8.193", false, null, null, null, "Babies/Toys" },
                    { 12L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 945, DateTimeKind.Local).AddTicks(2776), "192.168.8.193", false, null, null, null, "Pets" },
                    { 13L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 945, DateTimeKind.Local).AddTicks(4324), "192.168.8.193", false, null, null, null, "Agriculture" },
                    { 14L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 945, DateTimeKind.Local).AddTicks(5815), "192.168.8.193", false, null, null, null, "Workman" }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "CountryId", "CreatedBy", "CreatedDate", "IPAddress", "IsActive", "IsDeleted", "LastModified", "ModifiedBy", "Name", "StateCode", "StateId" },
                values: new object[,]
                {
                    { 1L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 938, DateTimeKind.Local).AddTicks(3296), "192.168.8.193", false, null, null, null, "Akwa Ibom", "01", null },
                    { 2L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 938, DateTimeKind.Local).AddTicks(4741), "192.168.8.193", false, null, null, null, "Anambra", "02", null },
                    { 3L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 938, DateTimeKind.Local).AddTicks(6172), "192.168.8.193", false, null, null, null, "Bauchi", "03", null },
                    { 4L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 938, DateTimeKind.Local).AddTicks(7660), "192.168.8.193", false, null, null, null, "Adamawa", "04", null },
                    { 5L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 938, DateTimeKind.Local).AddTicks(9091), "192.168.8.193", false, null, null, null, "Benue", "05", null },
                    { 6L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 939, DateTimeKind.Local).AddTicks(578), "192.168.8.193", false, null, null, null, "Borno", "06", null },
                    { 7L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 939, DateTimeKind.Local).AddTicks(2033), "192.168.8.193", false, null, null, null, "Cross River", "07", null },
                    { 8L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 939, DateTimeKind.Local).AddTicks(3456), "192.168.8.193", false, null, null, null, "FCT", "08", null },
                    { 9L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 939, DateTimeKind.Local).AddTicks(4875), "192.168.8.193", false, null, null, null, "Delta", "09", null },
                    { 10L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 939, DateTimeKind.Local).AddTicks(6342), "192.168.8.193", false, null, null, null, "Imo", "10", null },
                    { 11L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 939, DateTimeKind.Local).AddTicks(7816), "192.168.8.193", false, null, null, null, "Kaduna", "11", null },
                    { 12L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 939, DateTimeKind.Local).AddTicks(9242), "192.168.8.193", false, null, null, null, "Kano", "12", null },
                    { 13L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 940, DateTimeKind.Local).AddTicks(669), "192.168.8.193", false, null, null, null, "Katsina", "13", null },
                    { 14L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 940, DateTimeKind.Local).AddTicks(2100), "192.168.8.193", false, null, null, null, "Kwara", "14", null },
                    { 15L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 940, DateTimeKind.Local).AddTicks(3558), "192.168.8.193", false, null, null, null, "Lagos", "15", null },
                    { 16L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 940, DateTimeKind.Local).AddTicks(4984), "192.168.8.193", false, null, null, null, "Niger", "16", null },
                    { 17L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 940, DateTimeKind.Local).AddTicks(6495), "192.168.8.193", false, null, null, null, "Ogun", "17", null },
                    { 18L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 940, DateTimeKind.Local).AddTicks(7940), "192.168.8.193", false, null, null, null, "Ondo", "18", null },
                    { 19L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 940, DateTimeKind.Local).AddTicks(9368), "192.168.8.193", false, null, null, null, "Oyo", "19", null },
                    { 20L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 941, DateTimeKind.Local).AddTicks(783), "192.168.8.193", false, null, null, null, "Plateau", "20", null },
                    { 21L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 941, DateTimeKind.Local).AddTicks(2203), "192.168.8.193", false, null, null, null, "Rivers", "21", null },
                    { 22L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 941, DateTimeKind.Local).AddTicks(3633), "192.168.8.193", false, null, null, null, "Sokoto", "22", null },
                    { 23L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 941, DateTimeKind.Local).AddTicks(5064), "192.168.8.193", false, null, null, null, "Abia", "23", null },
                    { 24L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 941, DateTimeKind.Local).AddTicks(6550), "192.168.8.193", false, null, null, null, "Edo", "24", null },
                    { 25L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 941, DateTimeKind.Local).AddTicks(7998), "192.168.8.193", false, null, null, null, "Enugu", "25", null },
                    { 26L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 941, DateTimeKind.Local).AddTicks(9422), "192.168.8.193", false, null, null, null, "Jigawa", "26", null },
                    { 27L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 942, DateTimeKind.Local).AddTicks(858), "192.168.8.193", false, null, null, null, "Kebbi", "27", null },
                    { 28L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 942, DateTimeKind.Local).AddTicks(2353), "192.168.8.193", false, null, null, null, "Kogi", "28", null },
                    { 29L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 942, DateTimeKind.Local).AddTicks(3791), "192.168.8.193", false, null, null, null, "Osun", "29", null },
                    { 30L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 942, DateTimeKind.Local).AddTicks(5216), "192.168.8.193", false, null, null, null, "Taraba", "30", null },
                    { 31L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 942, DateTimeKind.Local).AddTicks(6646), "192.168.8.193", false, null, null, null, "Yobe", "31", null },
                    { 32L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 942, DateTimeKind.Local).AddTicks(8105), "192.168.8.193", false, null, null, null, "Bayelsa", "32", null },
                    { 33L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 942, DateTimeKind.Local).AddTicks(9533), "192.168.8.193", false, null, null, null, "Ebonyi", "33", null },
                    { 34L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 943, DateTimeKind.Local).AddTicks(961), "192.168.8.193", false, null, null, null, "Ekiti", "34", null },
                    { 35L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 943, DateTimeKind.Local).AddTicks(2396), "192.168.8.193", false, null, null, null, "Gombe", "35", null },
                    { 36L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 943, DateTimeKind.Local).AddTicks(3863), "192.168.8.193", false, null, null, null, "Nassarawa", "36", null },
                    { 37L, 166L, "System", new DateTime(2024, 3, 7, 2, 36, 33, 943, DateTimeKind.Local).AddTicks(5338), "192.168.8.193", false, null, null, null, "Zamfara", "37", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyTables");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 150L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 151L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 155L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 156L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 157L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 158L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 159L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 160L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 161L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 162L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 164L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 165L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 166L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 167L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 168L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 169L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 170L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 171L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 173L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 177L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 184L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 190L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 191L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 193L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 203L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 204L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 207L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 208L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 209L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 210L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 211L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 212L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 213L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 214L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 215L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 216L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 217L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 218L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 219L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 220L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 221L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 222L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 223L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 224L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 225L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 226L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 227L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 228L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 229L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 230L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 231L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 232L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 233L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 234L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 235L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 236L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 237L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 238L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 239L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 240L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 241L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 242L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 243L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 244L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 245L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 246L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 247L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 248L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 249L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 250L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 251L);

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
        }
    }
}
