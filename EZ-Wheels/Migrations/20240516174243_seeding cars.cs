using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EZ_Wheels.Migrations
{
    /// <inheritdoc />
    public partial class seedingcars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "DEF456");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "GHI789");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "JKL321");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "XYZ999");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "ba192a34-5e39-4537-9ee9-39897619bef2", "AQAAAAIAAYagAAAAENarZoGTJTbEI5FtYtV/mqLAcGa/qz5TSAnFx00trMWQoFHkp/ckc1fmwpgWfoVBaA==", "01100200300", "321d5ec3-0135-459f-83bd-cb761d2443fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "70af17fb-3735-49b5-a6b1-04ba8dbc2402", "AQAAAAIAAYagAAAAEA88DUTH35XlTrYlccB6xLVBP0BQoyJdIlWNs24+keig8DBe1f70OGiXl3AeQoVtgw==", "01020304050", "c99171ea-2331-428e-9935-c6abd57798f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "84494528-346c-4568-9acb-df8a3230297a", "AQAAAAIAAYagAAAAEPxvndOiHM5SHPyUfnJQRMQeb94lZA4xiqfzSP2Sdn7K7GBSORCT5sq9E26Mqwk9FA==", "01234567890", "31f44df9-776c-4c20-ad70-6f3b01687cdb" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "PlateNumber", "ChassisNumber", "Color", "Make", "Mileage", "Model", "NumberOfPassengers", "PhotoUrl", "RentalPrice", "State", "Transmission", "Type", "Variant" },
                values: new object[,]
                {
                    { "BBB001", "CHS021", "Black", "BMW", 1500, "X7", 7, "EZ-Wheels//wwwroot//uploads//bmw-m3-4d-black-2022.png", 2500, 0, 1, 0, "xDrive40i" },
                    { "BBB002", "CHS022", "White", "Jeep", 20000, "Wrangler", 4, "EZ-Wheel//wwwroot//uploads//jeep-grand-cherokee-5d-weiss-2018.png", 3000, 2, 1, 0, "Sport" },
                    { "BBB003", "CHS023", "Black", "Hyundai", 5000, "Santa Cruz", 5, "EZ-Wheels//wwwroot//uploads//hyundai-kona-suv-black-2024.png", 2200, 0, 1, 0, "SE" },
                    { "BBB004", "CHS024", "Black", "Chevrolet", 10000, "Suburban", 8, "EZ-Wheels//wwwroot//uploads//chevrolet-trailblazer-suv-black-2021.png", 3500, 1, 1, 0, "Premier" },
                    { "BBB005", "CHS025", "White", "BMW", 8000, "5 Series", 5, "EZ-Wheels//wwwroot//uploads//bmw-x5-40i-4d-suv-white-2021.png", 2800, 0, 1, 1, "530i" },
                    { "BBB006", "CHS026", "Brown", "Jeep", 12000, "Cherokee", 5, "EZ-Wheels//wwwroot//uploads//jeep-wrangler-5d-braun-2018.png", 3200, 0, 1, 0, "Trailhawk" },
                    { "BBB008", "CHS028", "White", "Chevrolet", 15000, "Blazer", 5, "EZ-Wheels//wwwroot//uploads//chevrolet-tahoe-suv-white-US-2021.png", 2500, 0, 1, 0, "RS" },
                    { "BBB009", "CHS029", "Blue", "BMW", 4000, "X6", 5, "EZ-Wheels//wwwroot//uploads//bmw-m8-competition-convertible-2d-blue-2019-JV.png", 3000, 0, 1, 0, "xDrive40i" },
                    { "BBB012", "CHS032", "White", "Chevrolet", 7000, "Traverse", 7, "EZ-Wheels//wwwroot//uploads//chevrolet-blazer-suv-white-2023.png", 2400, 0, 1, 0, "LS" },
                    { "BBB013", "CHS033", "Black", "BMW", 10000, "X1", 5, "EZ-Wheels//wwwroot//uploads//bmw-x5m-suv-4d-black-2023-JV.png", 2800, 0, 1, 0, "sDrive28i" },
                    { "BBB017", "CHS037", "Blue", "BMW", 15000, "7 Series", 5, "EZ-Wheels//wwwroot//uploads//bmw-x3m-suv-blue-2023.png", 2900, 1, 1, 1, "750i xDrive" },
                    { "BBB020", "CHS040", "Silver", "BMW", 12000, "Spark", 4, "EZ-Wheels//wwwroot//uploads//bmw-7-4d-silver-2021.png", 2300, 0, 1, 2, "LS" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB001");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB002");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB003");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB004");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB005");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB006");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB008");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB009");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB012");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB013");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB017");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "PlateNumber",
                keyValue: "BBB020");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "7196efb7-9773-4994-a363-57b5d11ed823", "AQAAAAIAAYagAAAAEAIGs6H/4ROePqxVDHQEdJDJhYC8CaoTc9US4/JjMPhJTeZgkSxp3N94/vWC9naqiw==", null, "a9cf027a-3d28-4aea-b356-630b40fb6ff9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "b9a71c40-9f3e-4b3a-8be5-c055875836d9", "AQAAAAIAAYagAAAAEDc+irLTJ0Qlxh6KbTsoOQEE7Ct+R4f0d6JXi5JzIJN26zMYfdHeby/aVq4PnylB0A==", null, "8794616b-df0d-49f8-8796-03ef7aae404b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "869f8734-c39d-463a-868f-7207c4e108ca", "AQAAAAIAAYagAAAAEMvzM5LsodtbDFYsMNjsv/qj2KXuXSfM8ULj+18epxSP579SofBLpmuM7zEg3E/Pqw==", null, "5f2060e0-d123-477b-979c-2d0e91f179d9" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "PlateNumber", "ChassisNumber", "Color", "Make", "Mileage", "Model", "NumberOfPassengers", "PhotoUrl", "RentalPrice", "State", "Transmission", "Type", "Variant" },
                values: new object[,]
                {
                    { "DEF456", "CHS456", "Blue", "Honda", 12000, "Accord", 4, null, 120, 0, 1, 1, "EX" },
                    { "GHI789", "CHS789", "Black", "Ford", 8000, "Focus", 4, null, 110, 0, 1, 1, "SE" },
                    { "JKL321", "CHS321", "Silver", "Ford", 7000, "Fiesta", 4, null, 90, 0, 1, 2, "SE" },
                    { "XYZ999", "CHS999", "White", "Chevrolet", 15000, "Malibu", 4, null, 130, 0, 1, 1, "LT" }
                });
        }
    }
}
