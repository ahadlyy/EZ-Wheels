using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EZ_Wheels.Migrations
{
    /// <inheritdoc />
    public partial class seedingallcars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "ABC123");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dff04722-6e44-40fc-8389-a2eb672365b1", "AQAAAAIAAYagAAAAEB7+O5VTwCm6Tf+RouD4bG7DPB8IMf/oqKk/XfptDTeFsRrfW7TwdLtHHyLKr5PMfg==", "1584503b-8603-4094-b97e-473fb41c2897" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "338c52dd-50e5-451f-bb89-1b7853900929", "AQAAAAIAAYagAAAAEPu9JK5HOkaNzSFAqyOqCroD+94di1I4A8XXkuhf0T+9Fp03Lyzcn1RCOVZ9bPc21w==", "4cc69e73-3591-406f-a504-8b639737dcff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "191fd5e7-d0a1-4719-a585-38f34c5999c7", "AQAAAAIAAYagAAAAEGDxEByIn3n6QNfo7vekZd/bRpHCscBYzrzGPIuPpTgPXAxfA748Bcs4B3AKtQSntA==", "82a4674b-ee2a-4d65-b164-f3ae931e475d" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB001",
                column: "PhotoUrl",
                value: "https://localhost:7108/uploads/bmw-m3-4d-black-2022.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB002",
                column: "PhotoUrl",
                value: "https://localhost:7108/uploads/jeep-grand-cherokee-5d-weiss-2018.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB003",
                column: "PhotoUrl",
                value: "https://localhost:7108/uploads/hyundai-kona-suv-black-2024.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB004",
                column: "PhotoUrl",
                value: "https://localhost:7108/uploads/chevrolet-trailblazer-suv-black-2021.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB005",
                column: "PhotoUrl",
                value: "https://localhost:7108/uploads/bmw-x5-40i-4d-suv-white-2021.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB006",
                column: "PhotoUrl",
                value: "https://localhost:7108/uploads/jeep-wrangler-5d-braun-2018.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB008",
                column: "PhotoUrl",
                value: "https://localhost:7108/uploads/chevrolet-tahoe-suv-white-US-2021.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB009",
                column: "PhotoUrl",
                value: "https://localhost:7108/uploads/bmw-m8-competition-convertible-2d-blue-2019-JV.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB012",
                column: "PhotoUrl",
                value: "https://localhost:7108/uploads/chevrolet-blazer-suv-white-2023.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB013",
                column: "PhotoUrl",
                value: "https://localhost:7108/uploads/bmw-x5m-suv-4d-black-2023-JV.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB017",
                column: "PhotoUrl",
                value: "https://localhost:7108/uploads/bmw-x3m-suv-blue-2023.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB020",
                column: "PhotoUrl",
                value: "https://localhost:7108/uploads/bmw-7-4d-silver-2021.png");

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "PlateNumber", "ChassisNumber", "Color", "Make", "Mileage", "Model", "NumberOfPassengers", "PhotoUrl", "RentalPrice", "State", "Transmission", "Type", "Variant" },
                values: new object[,]
                {
                    { "BBB021", "CHS041", "Orange", "Nissan", 9000, "Camry", 5, "https://localhost:7108/uploads/nissan-sentra-4d-orange-2020.png", 2700, 0, 1, 1, "SE" },
                    { "BBB022", "CHS042", "White", "Audi", 10000, "Civic", 5, "https://localhost:7108/uploads/audi-a6-quattro-4d-white-2021.png", 2800, 2, 1, 1, "Touring" },
                    { "BBB023", "CHS043", "Red", "Ford", 8000, "Mustang", 4, "https://localhost:7108/uploads/ford-mustang-cabrio-2d-rot-geschl-2016.png", 2500, 0, 0, 5, "GT" },
                    { "BBB024", "CHS044", "Brown", "Nissan", 15000, "Altima", 5, "https://localhost:7108/uploads/nissan-sunny-4d-braun-2011.png", 2600, 1, 1, 1, "SL" },
                    { "BBB025", "CHS045", "Gray", "Nissan-versa", 7000, "Sorento", 7, "https://localhost:7108/uploads/nissan-versa-4d-grey-2023.png", 2900, 0, 1, 0, "SX" },
                    { "BBB026", "CHS046", "Blue", "Subaru", 6000, "Outback", 5, "https://localhost:7108/uploads/subaru-xv-5d-blau-2019.png", 2800, 0, 1, 3, "Limited" },
                    { "BBB027", "CHS047", "Grey", "Audi", 9000, "CX-5", 5, "https://localhost:7108/uploads/audi-a3-4d-grey-2021.png", 2700, 2, 1, 0, "Grand Touring" },
                    { "BBB028", "CHS048", "Silver", "Skoda-octavia", 8000, "Passat", 5, "https://localhost:7108/uploads/skoda-octavia-4d-silber-2020.png", 2600, 0, 1, 1, "R-Line" },
                    { "BBB029", "CHS049", "Blue", "Audi", 7000, "Q5", 5, "https://localhost:7108/uploads/audi-a4-avant-stw-4d-blue-2023-JV.png", 3500, 2, 1, 0, "Premium Plus" },
                    { "BBB030", "CHS050", "Grey", "Peugeot", 5000, "C-Class", 5, "https://localhost:7108/uploads/peugeot-208-hatch-4d-grey-2020-JV.png", 4000, 0, 1, 1, "C300" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB021");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB022");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB023");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB024");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB025");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB026");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB027");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB028");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB029");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB030");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba192a34-5e39-4537-9ee9-39897619bef2", "AQAAAAIAAYagAAAAENarZoGTJTbEI5FtYtV/mqLAcGa/qz5TSAnFx00trMWQoFHkp/ckc1fmwpgWfoVBaA==", "321d5ec3-0135-459f-83bd-cb761d2443fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70af17fb-3735-49b5-a6b1-04ba8dbc2402", "AQAAAAIAAYagAAAAEA88DUTH35XlTrYlccB6xLVBP0BQoyJdIlWNs24+keig8DBe1f70OGiXl3AeQoVtgw==", "c99171ea-2331-428e-9935-c6abd57798f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84494528-346c-4568-9acb-df8a3230297a", "AQAAAAIAAYagAAAAEPxvndOiHM5SHPyUfnJQRMQeb94lZA4xiqfzSP2Sdn7K7GBSORCT5sq9E26Mqwk9FA==", "31f44df9-776c-4c20-ad70-6f3b01687cdb" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB001",
                column: "PhotoUrl",
                value: "EZ-Wheels//wwwroot//uploads//bmw-m3-4d-black-2022.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB002",
                column: "PhotoUrl",
                value: "EZ-Wheel//wwwroot//uploads//jeep-grand-cherokee-5d-weiss-2018.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB003",
                column: "PhotoUrl",
                value: "EZ-Wheels//wwwroot//uploads//hyundai-kona-suv-black-2024.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB004",
                column: "PhotoUrl",
                value: "EZ-Wheels//wwwroot//uploads//chevrolet-trailblazer-suv-black-2021.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB005",
                column: "PhotoUrl",
                value: "EZ-Wheels//wwwroot//uploads//bmw-x5-40i-4d-suv-white-2021.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB006",
                column: "PhotoUrl",
                value: "EZ-Wheels//wwwroot//uploads//jeep-wrangler-5d-braun-2018.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB008",
                column: "PhotoUrl",
                value: "EZ-Wheels//wwwroot//uploads//chevrolet-tahoe-suv-white-US-2021.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB009",
                column: "PhotoUrl",
                value: "EZ-Wheels//wwwroot//uploads//bmw-m8-competition-convertible-2d-blue-2019-JV.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB012",
                column: "PhotoUrl",
                value: "EZ-Wheels//wwwroot//uploads//chevrolet-blazer-suv-white-2023.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB013",
                column: "PhotoUrl",
                value: "EZ-Wheels//wwwroot//uploads//bmw-x5m-suv-4d-black-2023-JV.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB017",
                column: "PhotoUrl",
                value: "EZ-Wheels//wwwroot//uploads//bmw-x3m-suv-blue-2023.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB020",
                column: "PhotoUrl",
                value: "EZ-Wheels//wwwroot//uploads//bmw-7-4d-silver-2021.png");

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "PlateNumber", "ChassisNumber", "Color", "Make", "Mileage", "Model", "NumberOfPassengers", "PhotoUrl", "RentalPrice", "State", "Transmission", "Type", "Variant" },
                values: new object[] { "ABC123", "CHS123", "Red", "Toyota", 10000, "Camry", 4, null, 100, 0, 1, 1, "LE" });
        }
    }
}
